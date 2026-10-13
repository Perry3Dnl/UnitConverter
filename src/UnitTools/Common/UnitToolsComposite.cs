namespace UnitTools
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using UnitTools.Catalog;

    public readonly struct UnitToolsUnitExpression
    {
        internal UnitToolsUnitExpression(
            string text,
            UnitToolsDimensions dimensions,
            double scaleToCanonical)
        {
            Text = text;
            Dimensions = dimensions;
            ScaleToCanonical = scaleToCanonical;
        }

        public string Text { get; }
        public UnitToolsDimensions Dimensions { get; }
        public double ScaleToCanonical { get; }

        public bool IsCompatibleWith(UnitToolsUnitExpression other)
        {
            return Dimensions == other.Dimensions;
        }
    }

    public readonly struct UnitToolsExpressionParseResult
    {
        private UnitToolsExpressionParseResult(
            bool success,
            UnitToolsUnitExpression expression,
            UnitToolsError error,
            string errorMessage)
        {
            Success = success;
            Expression = expression;
            Error = error;
            ErrorMessage = errorMessage;
        }

        public bool Success { get; }
        public UnitToolsUnitExpression Expression { get; }
        public UnitToolsError Error { get; }
        public string ErrorMessage { get; }

        internal static UnitToolsExpressionParseResult Ok(
            UnitToolsUnitExpression expression)
        {
            return new UnitToolsExpressionParseResult(
                true,
                expression,
                UnitToolsError.None,
                null);
        }

        internal static UnitToolsExpressionParseResult Fail(
            UnitToolsError error,
            string errorMessage)
        {
            return new UnitToolsExpressionParseResult(
                false,
                default(UnitToolsUnitExpression),
                error,
                errorMessage);
        }
    }

    public readonly struct UnitToolsCompositeResult
    {
        private UnitToolsCompositeResult(
            bool success,
            double value,
            UnitToolsUnitExpression from,
            UnitToolsUnitExpression to,
            UnitToolsError error,
            string errorMessage)
        {
            Success = success;
            Value = value;
            From = from;
            To = to;
            Error = error;
            ErrorMessage = errorMessage;
        }

        public bool Success { get; }
        public double Value { get; }
        public UnitToolsUnitExpression From { get; }
        public UnitToolsUnitExpression To { get; }
        public UnitToolsError Error { get; }
        public string ErrorMessage { get; }

        internal static UnitToolsCompositeResult Ok(
            double value,
            UnitToolsUnitExpression from,
            UnitToolsUnitExpression to)
        {
            return new UnitToolsCompositeResult(
                true,
                value,
                from,
                to,
                UnitToolsError.None,
                null);
        }

        internal static UnitToolsCompositeResult Fail(
            UnitToolsError error,
            string errorMessage)
        {
            return new UnitToolsCompositeResult(
                false,
                0d,
                default(UnitToolsUnitExpression),
                default(UnitToolsUnitExpression),
                error,
                errorMessage);
        }
    }

    public static class UnitToolsExpressionParser
    {
        private const int MaxCandidates = 128;
        private const int MaxCachedBuiltInExpressions = 256;
        private const int MaxExpressionLength = 4096;
        private const int MaxNestingDepth = 64;
        private const int MaxAbsoluteExponent = 1024;
        private static readonly ConcurrentDictionary<string, UnitToolsUnitExpression[]> BuiltInCandidateCache =
            new ConcurrentDictionary<string, UnitToolsUnitExpression[]>(StringComparer.Ordinal);

        public static UnitToolsUnitExpression Parse(string expression)
        {
            UnitToolsExpressionParseResult result = TryParse(expression);
            if (!result.Success)
            {
                throw new FormatException(result.ErrorMessage);
            }

            return result.Expression;
        }

        public static UnitToolsExpressionParseResult TryParse(string expression)
        {
            UnitToolsUnitExpression[] candidates;
            UnitToolsError error;
            string errorMessage;

            if (!TryParseCandidates(
                expression,
                out candidates,
                out error,
                out errorMessage))
            {
                return UnitToolsExpressionParseResult.Fail(
                    error,
                    errorMessage);
            }

            UnitToolsUnitExpression collapsed;
            if (!TryCollapseCandidates(candidates, out collapsed))
            {
                return UnitToolsExpressionParseResult.Fail(
                    UnitToolsError.AmbiguousUnit,
                    "The unit expression '" + expression +
                    "' has multiple dimensionally distinct interpretations.");
            }

            return UnitToolsExpressionParseResult.Ok(
                new UnitToolsUnitExpression(
                    expression.Trim(),
                    collapsed.Dimensions,
                    collapsed.ScaleToCanonical));
        }

        internal static bool TryParseCandidates(
            string expression,
            out UnitToolsUnitExpression[] candidates,
            out UnitToolsError error,
            out string errorMessage)
        {
            candidates = new UnitToolsUnitExpression[0];
            error = UnitToolsError.InvalidExpression;
            errorMessage = null;

            if (string.IsNullOrWhiteSpace(expression))
            {
                errorMessage = "The unit expression is empty.";
                return false;
            }

            if (expression.Length > MaxExpressionLength)
            {
                errorMessage = "The unit expression exceeds the maximum supported length.";
                return false;
            }

            string normalized = Normalize(expression.Trim());
            bool cacheEligible = !UnitToolsCustomUnits.HasUnits;
            UnitToolsUnitExpression[] cached;
            if (cacheEligible &&
                BuiltInCandidateCache.TryGetValue(normalized, out cached))
            {
                candidates = cached;
                error = UnitToolsError.None;
                return true;
            }

            var parser = new Parser(normalized);
            List<UnitToolsUnitExpression> parsed;

            if (!parser.TryParseCandidates(out parsed))
            {
                error = parser.Error;
                errorMessage = parser.ErrorMessage;
                return false;
            }

            candidates = parsed.ToArray();

            if (cacheEligible &&
                !UnitToolsCustomUnits.HasUnits &&
                BuiltInCandidateCache.Count < MaxCachedBuiltInExpressions)
            {
                candidates = BuiltInCandidateCache.GetOrAdd(
                    normalized,
                    candidates);
            }

            error = UnitToolsError.None;
            return true;
        }

        private static string Normalize(string expression)
        {
            return expression
                .Replace("²", "^2")
                .Replace("³", "^3")
                .Replace("·", "*")
                .Replace("⋅", "*");
        }

        private sealed class Parser
        {
            private readonly string _text;
            private int _index;
            private int _nestingDepth;

            public Parser(string text)
            {
                _text = text;
                Error = UnitToolsError.InvalidExpression;
                ErrorMessage = "The unit expression is invalid.";
            }

            public UnitToolsError Error { get; private set; }
            public string ErrorMessage { get; private set; }

            public bool TryParseCandidates(
                out List<UnitToolsUnitExpression> expressions)
            {
                expressions = null;
                SkipWhitespace();

                if (!TryParseProduct(out expressions))
                {
                    return false;
                }

                SkipWhitespace();
                if (_index != _text.Length)
                {
                    return Fail(
                        UnitToolsError.InvalidExpression,
                        "Unexpected token at position " + _index + ".");
                }

                return true;
            }

            private bool TryParseProduct(
                out List<UnitToolsUnitExpression> expressions)
            {
                if (!TryParsePower(out expressions))
                {
                    return false;
                }

                while (true)
                {
                    SkipWhitespace();
                    if (_index >= _text.Length || _text[_index] == ')')
                    {
                        return true;
                    }

                    char operation = '*';
                    if (_text[_index] == '*' || _text[_index] == '/')
                    {
                        operation = _text[_index];
                        _index++;
                    }
                    else if (_text[_index] == '^')
                    {
                        return Fail(
                            UnitToolsError.InvalidExpression,
                            "Unexpected exponent operator at position " + _index + ".");
                    }

                    List<UnitToolsUnitExpression> right;
                    if (!TryParsePower(out right))
                    {
                        return false;
                    }

                    List<UnitToolsUnitExpression> combined;
                    if (!TryCombine(expressions, right, operation, out combined))
                    {
                        return false;
                    }

                    expressions = combined;
                }
            }

            private bool TryParsePower(
                out List<UnitToolsUnitExpression> expressions)
            {
                if (!TryParsePrimary(out expressions))
                {
                    return false;
                }

                SkipWhitespace();
                if (_index >= _text.Length || _text[_index] != '^')
                {
                    return true;
                }

                _index++;
                SkipWhitespace();

                int sign = 1;
                if (_index < _text.Length && (_text[_index] == '+' || _text[_index] == '-'))
                {
                    sign = _text[_index] == '-' ? -1 : 1;
                    _index++;
                }

                int start = _index;
                int exponent = 0;
                while (_index < _text.Length &&
                    _text[_index] >= '0' &&
                    _text[_index] <= '9')
                {
                    int digit = _text[_index] - '0';
                    if (exponent > (MaxAbsoluteExponent - digit) / 10)
                    {
                        return Fail(
                            UnitToolsError.InvalidExpression,
                            "The unit expression exponent exceeds the supported limit.");
                    }

                    exponent = (exponent * 10) + digit;
                    _index++;
                }

                if (_index == start)
                {
                    return Fail(
                        UnitToolsError.InvalidExpression,
                        "An integer exponent is required after '^'.");
                }

                exponent *= sign;
                var powered = new List<UnitToolsUnitExpression>();

                foreach (UnitToolsUnitExpression expression in expressions)
                {
                    AddCandidate(powered, Power(expression, exponent));
                }

                expressions = powered;
                return true;
            }

            private bool TryParsePrimary(
                out List<UnitToolsUnitExpression> expressions)
            {
                expressions = null;
                SkipWhitespace();

                if (_index >= _text.Length)
                {
                    return Fail(
                        UnitToolsError.InvalidExpression,
                        "The unit expression ended unexpectedly.");
                }

                if (_text[_index] == '(')
                {
                    if (_nestingDepth >= MaxNestingDepth)
                    {
                        return Fail(
                            UnitToolsError.InvalidExpression,
                            "The unit expression nesting depth exceeds the supported limit.");
                    }

                    _nestingDepth++;
                    _index++;
                    bool parsed = TryParseProduct(out expressions);
                    _nestingDepth--;

                    if (!parsed)
                    {
                        return false;
                    }

                    SkipWhitespace();
                    if (_index >= _text.Length || _text[_index] != ')')
                    {
                        return Fail(
                            UnitToolsError.InvalidExpression,
                            "A closing ')' is required.");
                    }

                    _index++;
                    return true;
                }

                int start = _index;
                while (_index < _text.Length)
                {
                    char character = _text[_index];
                    if (character == '*' ||
                        character == '/' ||
                        character == '(' ||
                        character == ')' ||
                        character == '^')
                    {
                        break;
                    }

                    _index++;
                }

                string atom = _text.Substring(start, _index - start).Trim();
                if (atom.Length == 0)
                {
                    return Fail(
                        UnitToolsError.InvalidExpression,
                        "A unit is required at position " + start + ".");
                }

                return TryResolveAtom(atom, out expressions);
            }

            private bool TryResolveAtom(
                string atom,
                out List<UnitToolsUnitExpression> expressions)
            {
                expressions = null;
                UnitToolsDetectionResult detection =
                    UnitToolsDetector.DetectUnit(atom);

                if (detection.Status != UnitToolsDetectionStatus.Unknown)
                {
                    return TryResolveDetection(atom, detection, out expressions);
                }

                string[] pieces = atom.Split(
                    new[] { ' ', '\t', '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (pieces.Length <= 1)
                {
                    return Fail(
                        UnitToolsError.UnknownUnit,
                        "The unit '" + atom + "' is not recognized.");
                }

                var combined = new List<UnitToolsUnitExpression>
                {
                    new UnitToolsUnitExpression(
                        atom,
                        UnitToolsDimensions.Dimensionless,
                        1d)
                };

                foreach (string piece in pieces)
                {
                    UnitToolsDetectionResult pieceDetection =
                        UnitToolsDetector.DetectUnit(piece);
                    List<UnitToolsUnitExpression> resolved;

                    if (!TryResolveDetection(piece, pieceDetection, out resolved))
                    {
                        return false;
                    }

                    List<UnitToolsUnitExpression> next;
                    if (!TryCombine(combined, resolved, '*', out next))
                    {
                        return false;
                    }

                    combined = next;
                }

                expressions = combined;
                return true;
            }

            private bool TryResolveDetection(
                string atom,
                UnitToolsDetectionResult detection,
                out List<UnitToolsUnitExpression> expressions)
            {
                expressions = new List<UnitToolsUnitExpression>();

                if (detection.Status == UnitToolsDetectionStatus.Unknown)
                {
                    return Fail(
                        detection.Error == UnitToolsError.None
                            ? UnitToolsError.UnknownUnit
                            : detection.Error,
                        detection.ErrorMessage ?? ("The unit '" + atom + "' is not recognized."));
                }

                IReadOnlyList<UnitToolsUnitCandidate> candidates;
                if (detection.Status == UnitToolsDetectionStatus.Resolved)
                {
                    candidates = new[] { detection.Candidate };
                }
                else
                {
                    candidates = detection.Candidates;
                    var exactSymbolCandidates =
                        new List<UnitToolsUnitCandidate>();

                    foreach (UnitToolsUnitCandidate candidate in detection.Candidates)
                    {
                        if (string.Equals(
                            candidate.Symbol,
                            atom,
                            StringComparison.Ordinal))
                        {
                            exactSymbolCandidates.Add(candidate);
                        }
                    }

                    if (exactSymbolCandidates.Count > 0)
                    {
                        candidates = exactSymbolCandidates;
                    }
                }

                foreach (UnitToolsUnitCandidate candidate in candidates)
                {
                    double scale;
                    if (!TryGetCanonicalScale(candidate, out scale))
                    {
                        continue;
                    }

                    AddCandidate(
                        expressions,
                        new UnitToolsUnitExpression(
                            atom,
                            candidate.Dimensions,
                            scale));
                }

                if (expressions.Count == 0)
                {
                    return Fail(
                        UnitToolsError.UnsupportedUnit,
                        "The unit '" + atom +
                        "' cannot be used as a multiplicative expression factor.");
                }

                return true;
            }

            private bool TryCombine(
                List<UnitToolsUnitExpression> left,
                List<UnitToolsUnitExpression> right,
                char operation,
                out List<UnitToolsUnitExpression> combined)
            {
                combined = new List<UnitToolsUnitExpression>();

                foreach (UnitToolsUnitExpression leftExpression in left)
                {
                    foreach (UnitToolsUnitExpression rightExpression in right)
                    {
                        AddCandidate(
                            combined,
                            operation == '/'
                                ? Divide(leftExpression, rightExpression)
                                : Multiply(leftExpression, rightExpression));

                        if (combined.Count > MaxCandidates)
                        {
                            return Fail(
                                UnitToolsError.AmbiguousUnit,
                                "The unit expression has too many ambiguous interpretations.");
                        }
                    }
                }

                return true;
            }

            private void SkipWhitespace()
            {
                while (_index < _text.Length && char.IsWhiteSpace(_text[_index]))
                {
                    _index++;
                }
            }

            private bool Fail(UnitToolsError error, string message)
            {
                Error = error;
                ErrorMessage = message;
                return false;
            }
        }

        private static void AddCandidate(
            List<UnitToolsUnitExpression> candidates,
            UnitToolsUnitExpression candidate)
        {
            foreach (UnitToolsUnitExpression existing in candidates)
            {
                if (existing.Dimensions == candidate.Dimensions &&
                    NearlyEqual(
                        existing.ScaleToCanonical,
                        candidate.ScaleToCanonical))
                {
                    return;
                }
            }

            candidates.Add(candidate);
        }

        private static bool TryCollapseCandidates(
            UnitToolsUnitExpression[] candidates,
            out UnitToolsUnitExpression expression)
        {
            expression = default(UnitToolsUnitExpression);

            if (candidates == null || candidates.Length == 0)
            {
                return false;
            }

            expression = candidates[0];

            for (int index = 1; index < candidates.Length; index++)
            {
                if (candidates[index].Dimensions != expression.Dimensions ||
                    !NearlyEqual(
                        candidates[index].ScaleToCanonical,
                        expression.ScaleToCanonical))
                {
                    return false;
                }
            }

            return true;
        }

        private static UnitToolsUnitExpression Multiply(
            UnitToolsUnitExpression left,
            UnitToolsUnitExpression right)
        {
            return new UnitToolsUnitExpression(
                left.Text + "*" + right.Text,
                left.Dimensions.Multiply(right.Dimensions),
                left.ScaleToCanonical * right.ScaleToCanonical);
        }

        private static UnitToolsUnitExpression Divide(
            UnitToolsUnitExpression left,
            UnitToolsUnitExpression right)
        {
            return new UnitToolsUnitExpression(
                left.Text + "/" + right.Text,
                left.Dimensions.Divide(right.Dimensions),
                left.ScaleToCanonical / right.ScaleToCanonical);
        }

        private static UnitToolsUnitExpression Power(
            UnitToolsUnitExpression value,
            int exponent)
        {
            return new UnitToolsUnitExpression(
                value.Text + "^" + exponent,
                value.Dimensions.Pow(exponent),
                Math.Pow(value.ScaleToCanonical, exponent));
        }

        private static bool TryGetCanonicalScale(
            UnitToolsUnitCandidate candidate,
            out double scale)
        {
            scale = 0d;
            UnitToolsFamilyDescriptor family = candidate.Family;

            if (candidate.IsCustom)
            {
                if (candidate.CustomUnit.OffsetToReference != 0d)
                {
                    return false;
                }

                UnitToolsUnitDescriptor referenceDescriptor = null;
                foreach (UnitToolsUnitDescriptor unit in family.Units)
                {
                    if (object.Equals(
                        unit.Unit,
                        candidate.CustomUnit.ReferenceUnit))
                    {
                        referenceDescriptor = unit;
                        break;
                    }
                }

                if (referenceDescriptor == null)
                {
                    return false;
                }

                double referenceScale;
                if (!TryGetCanonicalScale(
                    new UnitToolsUnitCandidate(
                        family,
                        referenceDescriptor),
                    out referenceScale))
                {
                    return false;
                }

                scale =
                    candidate.CustomUnit.ScaleToReference *
                    referenceScale;

                return !double.IsNaN(scale) &&
                    !double.IsInfinity(scale) &&
                    scale != 0d;
            }

            if (family.Family == UnitToolsFamily.FuelEconomy)
            {
                return TryGetFuelEconomyScale(candidate, out scale);
            }

            UnitToolsUnitDescriptor baseUnit = null;
            foreach (UnitToolsUnitDescriptor unit in family.Units)
            {
                if (unit.Name == family.BaseUnitName)
                {
                    baseUnit = unit;
                    break;
                }
            }

            if (baseUnit == null)
            {
                return false;
            }

            double zero;
            double one;

            try
            {
                zero = family.Convert(0d, candidate.Unit.Unit, baseUnit.Unit);
                one = family.Convert(1d, candidate.Unit.Unit, baseUnit.Unit);
            }
            catch
            {
                return false;
            }

            double localScale = one - zero;
            if (double.IsNaN(localScale) ||
                double.IsInfinity(localScale) ||
                localScale == 0d)
            {
                return false;
            }

            scale = localScale * GetBaseCanonicalScale(family.Family);
            return !double.IsNaN(scale) &&
                !double.IsInfinity(scale) &&
                scale != 0d;
        }

        private static bool TryGetFuelEconomyScale(
            UnitToolsUnitCandidate candidate,
            out double scale)
        {
            scale = 0d;
            string referenceName;
            double referenceScale;

            if (candidate.Unit.Dimensions.Length == -2)
            {
                referenceName = "KilometerPerLiter";
                referenceScale = 1000000d;
            }
            else if (candidate.Unit.Dimensions.Length == 2)
            {
                referenceName = "LiterPer100Kilometer";
                referenceScale = 0.00000001d;
            }
            else
            {
                return false;
            }

            UnitToolsUnitDescriptor reference = null;
            foreach (UnitToolsUnitDescriptor unit in candidate.Family.Units)
            {
                if (unit.Name == referenceName)
                {
                    reference = unit;
                    break;
                }
            }

            if (reference == null)
            {
                return false;
            }

            try
            {
                double converted =
                    candidate.Family.Convert(
                        1d,
                        candidate.Unit.Unit,
                        reference.Unit);

                scale = converted * referenceScale;
            }
            catch
            {
                return false;
            }

            return !double.IsNaN(scale) &&
                !double.IsInfinity(scale) &&
                scale != 0d;
        }

        private static double GetBaseCanonicalScale(UnitToolsFamily family)
        {
            switch (family)
            {
                case UnitToolsFamily.Angle:
                    return Math.PI / 180d;
                case UnitToolsFamily.DigitalStorage:
                    return 8d;
                case UnitToolsFamily.Volume:
                    return 0.001d;
                default:
                    return 1d;
            }
        }

        private static string DescribeCandidates(
            IReadOnlyList<UnitToolsUnitCandidate> candidates)
        {
            var parts = new string[candidates.Count];

            for (int index = 0; index < candidates.Count; index++)
            {
                UnitToolsUnitCandidate candidate = candidates[index];
                parts[index] =
                    candidate.Family.Name +
                    "." +
                    candidate.Name +
                    " [" +
                    candidate.Symbol +
                    "]";
            }

            return string.Join(", ", parts);
        }

        internal static bool NearlyEqual(double left, double right)
        {
            if (left.Equals(right))
            {
                return true;
            }

            double scale = Math.Max(Math.Abs(left), Math.Abs(right));
            if (scale == 0d)
            {
                return true;
            }

            return Math.Abs(left - right) <= scale * 1e-12d;
        }
    }

    public static class UnitToolsComposite
    {
        public static double Convert(
            double value,
            string fromExpression,
            string toExpression)
        {
            UnitToolsCompositeResult result =
                TryConvert(value, fromExpression, toExpression);

            if (!result.Success)
            {
                throw new ArgumentException(result.ErrorMessage);
            }

            return result.Value;
        }

        public static UnitToolsCompositeResult TryConvert(
            double value,
            string fromExpression,
            string toExpression)
        {
            UnitToolsUnitExpression[] fromCandidates;
            UnitToolsError fromError;
            string fromErrorMessage;

            if (!UnitToolsExpressionParser.TryParseCandidates(
                fromExpression,
                out fromCandidates,
                out fromError,
                out fromErrorMessage))
            {
                return UnitToolsCompositeResult.Fail(
                    fromError,
                    fromErrorMessage);
            }

            UnitToolsUnitExpression[] toCandidates;
            UnitToolsError toError;
            string toErrorMessage;

            if (!UnitToolsExpressionParser.TryParseCandidates(
                toExpression,
                out toCandidates,
                out toError,
                out toErrorMessage))
            {
                return UnitToolsCompositeResult.Fail(
                    toError,
                    toErrorMessage);
            }

            bool found = false;
            double ratio = 0d;
            UnitToolsUnitExpression selectedFrom =
                default(UnitToolsUnitExpression);
            UnitToolsUnitExpression selectedTo =
                default(UnitToolsUnitExpression);

            foreach (UnitToolsUnitExpression from in fromCandidates)
            {
                foreach (UnitToolsUnitExpression to in toCandidates)
                {
                    if (!from.IsCompatibleWith(to))
                    {
                        continue;
                    }

                    double candidateRatio =
                        from.ScaleToCanonical /
                        to.ScaleToCanonical;

                    if (!found)
                    {
                        found = true;
                        ratio = candidateRatio;
                        selectedFrom = from;
                        selectedTo = to;
                        continue;
                    }

                    if (!UnitToolsExpressionParser.NearlyEqual(
                        ratio,
                        candidateRatio))
                    {
                        return UnitToolsCompositeResult.Fail(
                            UnitToolsError.AmbiguousUnit,
                            "The conversion has multiple dimensionally valid interpretations.");
                    }
                }
            }

            if (!found)
            {
                return UnitToolsCompositeResult.Fail(
                    UnitToolsError.IncompatibleDimensions,
                    "The unit expressions do not have compatible dimensions.");
            }

            return UnitToolsCompositeResult.Ok(
                value * ratio,
                new UnitToolsUnitExpression(
                    fromExpression.Trim(),
                    selectedFrom.Dimensions,
                    selectedFrom.ScaleToCanonical),
                new UnitToolsUnitExpression(
                    toExpression.Trim(),
                    selectedTo.Dimensions,
                    selectedTo.ScaleToCanonical));
        }
    }
}
