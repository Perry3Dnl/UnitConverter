namespace UnitConverter
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using UnitConverter.Catalog;

    public readonly struct UnitConverterUnitExpression
    {
        internal UnitConverterUnitExpression(
            string text,
            UnitConverterDimensions dimensions,
            double scaleToCanonical)
        {
            Text = text;
            Dimensions = dimensions;
            ScaleToCanonical = scaleToCanonical;
        }

        public string Text { get; }
        public UnitConverterDimensions Dimensions { get; }
        public double ScaleToCanonical { get; }

        public bool IsCompatibleWith(UnitConverterUnitExpression other)
        {
            return Dimensions == other.Dimensions;
        }
    }

    public readonly struct UnitConverterExpressionParseResult
    {
        private UnitConverterExpressionParseResult(
            bool success,
            UnitConverterUnitExpression expression,
            UnitConverterError error,
            string errorMessage)
        {
            Success = success;
            Expression = expression;
            Error = error;
            ErrorMessage = errorMessage;
        }

        public bool Success { get; }
        public UnitConverterUnitExpression Expression { get; }
        public UnitConverterError Error { get; }
        public string ErrorMessage { get; }

        public static UnitConverterExpressionParseResult Ok(
            UnitConverterUnitExpression expression)
        {
            return new UnitConverterExpressionParseResult(
                true,
                expression,
                UnitConverterError.None,
                null);
        }

        public static UnitConverterExpressionParseResult Fail(
            UnitConverterError error,
            string errorMessage)
        {
            return new UnitConverterExpressionParseResult(
                false,
                default(UnitConverterUnitExpression),
                error,
                errorMessage);
        }
    }

    public readonly struct UnitConverterCompositeResult
    {
        private UnitConverterCompositeResult(
            bool success,
            double value,
            UnitConverterUnitExpression from,
            UnitConverterUnitExpression to,
            UnitConverterError error,
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
        public UnitConverterUnitExpression From { get; }
        public UnitConverterUnitExpression To { get; }
        public UnitConverterError Error { get; }
        public string ErrorMessage { get; }

        public static UnitConverterCompositeResult Ok(
            double value,
            UnitConverterUnitExpression from,
            UnitConverterUnitExpression to)
        {
            return new UnitConverterCompositeResult(
                true,
                value,
                from,
                to,
                UnitConverterError.None,
                null);
        }

        public static UnitConverterCompositeResult Fail(
            UnitConverterError error,
            string errorMessage)
        {
            return new UnitConverterCompositeResult(
                false,
                0d,
                default(UnitConverterUnitExpression),
                default(UnitConverterUnitExpression),
                error,
                errorMessage);
        }
    }

    public static class UnitConverterExpressionParser
    {
        private const int MaxCandidates = 128;
        private const int MaxCachedBuiltInExpressions = 256;
        private static readonly ConcurrentDictionary<string, UnitConverterUnitExpression[]> BuiltInCandidateCache =
            new ConcurrentDictionary<string, UnitConverterUnitExpression[]>(StringComparer.Ordinal);

        public static UnitConverterUnitExpression Parse(string expression)
        {
            UnitConverterExpressionParseResult result = TryParse(expression);
            if (!result.Success)
            {
                throw new FormatException(result.ErrorMessage);
            }

            return result.Expression;
        }

        public static UnitConverterExpressionParseResult TryParse(string expression)
        {
            UnitConverterUnitExpression[] candidates;
            UnitConverterError error;
            string errorMessage;

            if (!TryParseCandidates(
                expression,
                out candidates,
                out error,
                out errorMessage))
            {
                return UnitConverterExpressionParseResult.Fail(
                    error,
                    errorMessage);
            }

            UnitConverterUnitExpression collapsed;
            if (!TryCollapseCandidates(candidates, out collapsed))
            {
                return UnitConverterExpressionParseResult.Fail(
                    UnitConverterError.AmbiguousUnit,
                    "The unit expression '" + expression +
                    "' has multiple dimensionally distinct interpretations.");
            }

            return UnitConverterExpressionParseResult.Ok(
                new UnitConverterUnitExpression(
                    expression.Trim(),
                    collapsed.Dimensions,
                    collapsed.ScaleToCanonical));
        }

        internal static bool TryParseCandidates(
            string expression,
            out UnitConverterUnitExpression[] candidates,
            out UnitConverterError error,
            out string errorMessage)
        {
            candidates = new UnitConverterUnitExpression[0];
            error = UnitConverterError.InvalidExpression;
            errorMessage = null;

            if (string.IsNullOrWhiteSpace(expression))
            {
                errorMessage = "The unit expression is empty.";
                return false;
            }

            string normalized = Normalize(expression.Trim());
            bool cacheEligible = !UnitConverterCustomUnits.HasUnits;
            UnitConverterUnitExpression[] cached;
            if (cacheEligible &&
                BuiltInCandidateCache.TryGetValue(normalized, out cached))
            {
                candidates = cached;
                error = UnitConverterError.None;
                return true;
            }

            var parser = new Parser(normalized);
            List<UnitConverterUnitExpression> parsed;

            if (!parser.TryParseCandidates(out parsed))
            {
                error = parser.Error;
                errorMessage = parser.ErrorMessage;
                return false;
            }

            candidates = parsed.ToArray();

            if (cacheEligible &&
                !UnitConverterCustomUnits.HasUnits &&
                BuiltInCandidateCache.Count < MaxCachedBuiltInExpressions)
            {
                candidates = BuiltInCandidateCache.GetOrAdd(
                    normalized,
                    candidates);
            }

            error = UnitConverterError.None;
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

            public Parser(string text)
            {
                _text = text;
                Error = UnitConverterError.InvalidExpression;
                ErrorMessage = "The unit expression is invalid.";
            }

            public UnitConverterError Error { get; private set; }
            public string ErrorMessage { get; private set; }

            public bool TryParseCandidates(
                out List<UnitConverterUnitExpression> expressions)
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
                        UnitConverterError.InvalidExpression,
                        "Unexpected token at position " + _index + ".");
                }

                return true;
            }

            private bool TryParseProduct(
                out List<UnitConverterUnitExpression> expressions)
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
                            UnitConverterError.InvalidExpression,
                            "Unexpected exponent operator at position " + _index + ".");
                    }

                    List<UnitConverterUnitExpression> right;
                    if (!TryParsePower(out right))
                    {
                        return false;
                    }

                    List<UnitConverterUnitExpression> combined;
                    if (!TryCombine(expressions, right, operation, out combined))
                    {
                        return false;
                    }

                    expressions = combined;
                }
            }

            private bool TryParsePower(
                out List<UnitConverterUnitExpression> expressions)
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
                    exponent = (exponent * 10) + (_text[_index] - '0');
                    _index++;
                }

                if (_index == start)
                {
                    return Fail(
                        UnitConverterError.InvalidExpression,
                        "An integer exponent is required after '^'.");
                }

                exponent *= sign;
                var powered = new List<UnitConverterUnitExpression>();

                foreach (UnitConverterUnitExpression expression in expressions)
                {
                    AddCandidate(powered, Power(expression, exponent));
                }

                expressions = powered;
                return true;
            }

            private bool TryParsePrimary(
                out List<UnitConverterUnitExpression> expressions)
            {
                expressions = null;
                SkipWhitespace();

                if (_index >= _text.Length)
                {
                    return Fail(
                        UnitConverterError.InvalidExpression,
                        "The unit expression ended unexpectedly.");
                }

                if (_text[_index] == '(')
                {
                    _index++;
                    if (!TryParseProduct(out expressions))
                    {
                        return false;
                    }

                    SkipWhitespace();
                    if (_index >= _text.Length || _text[_index] != ')')
                    {
                        return Fail(
                            UnitConverterError.InvalidExpression,
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
                        UnitConverterError.InvalidExpression,
                        "A unit is required at position " + start + ".");
                }

                return TryResolveAtom(atom, out expressions);
            }

            private bool TryResolveAtom(
                string atom,
                out List<UnitConverterUnitExpression> expressions)
            {
                expressions = null;
                UnitConverterDetectionResult detection =
                    UnitConverterDetector.DetectUnit(atom);

                if (detection.Status != UnitConverterDetectionStatus.Unknown)
                {
                    return TryResolveDetection(atom, detection, out expressions);
                }

                string[] pieces = atom.Split(
                    new[] { ' ', '\t', '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (pieces.Length <= 1)
                {
                    return Fail(
                        UnitConverterError.UnknownUnit,
                        "The unit '" + atom + "' is not recognized.");
                }

                var combined = new List<UnitConverterUnitExpression>
                {
                    new UnitConverterUnitExpression(
                        atom,
                        UnitConverterDimensions.Dimensionless,
                        1d)
                };

                foreach (string piece in pieces)
                {
                    UnitConverterDetectionResult pieceDetection =
                        UnitConverterDetector.DetectUnit(piece);
                    List<UnitConverterUnitExpression> resolved;

                    if (!TryResolveDetection(piece, pieceDetection, out resolved))
                    {
                        return false;
                    }

                    List<UnitConverterUnitExpression> next;
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
                UnitConverterDetectionResult detection,
                out List<UnitConverterUnitExpression> expressions)
            {
                expressions = new List<UnitConverterUnitExpression>();

                if (detection.Status == UnitConverterDetectionStatus.Unknown)
                {
                    return Fail(
                        detection.Error == UnitConverterError.None
                            ? UnitConverterError.UnknownUnit
                            : detection.Error,
                        detection.ErrorMessage ?? ("The unit '" + atom + "' is not recognized."));
                }

                IReadOnlyList<UnitConverterUnitCandidate> candidates;
                if (detection.Status == UnitConverterDetectionStatus.Resolved)
                {
                    candidates = new[] { detection.Candidate };
                }
                else
                {
                    candidates = detection.Candidates;
                    var exactSymbolCandidates =
                        new List<UnitConverterUnitCandidate>();

                    foreach (UnitConverterUnitCandidate candidate in detection.Candidates)
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

                foreach (UnitConverterUnitCandidate candidate in candidates)
                {
                    double scale;
                    if (!TryGetCanonicalScale(candidate, out scale))
                    {
                        continue;
                    }

                    AddCandidate(
                        expressions,
                        new UnitConverterUnitExpression(
                            atom,
                            candidate.Dimensions,
                            scale));
                }

                if (expressions.Count == 0)
                {
                    return Fail(
                        UnitConverterError.UnsupportedUnit,
                        "The unit '" + atom +
                        "' cannot be used as a multiplicative expression factor.");
                }

                return true;
            }

            private bool TryCombine(
                List<UnitConverterUnitExpression> left,
                List<UnitConverterUnitExpression> right,
                char operation,
                out List<UnitConverterUnitExpression> combined)
            {
                combined = new List<UnitConverterUnitExpression>();

                foreach (UnitConverterUnitExpression leftExpression in left)
                {
                    foreach (UnitConverterUnitExpression rightExpression in right)
                    {
                        AddCandidate(
                            combined,
                            operation == '/'
                                ? Divide(leftExpression, rightExpression)
                                : Multiply(leftExpression, rightExpression));

                        if (combined.Count > MaxCandidates)
                        {
                            return Fail(
                                UnitConverterError.AmbiguousUnit,
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

            private bool Fail(UnitConverterError error, string message)
            {
                Error = error;
                ErrorMessage = message;
                return false;
            }
        }

        private static void AddCandidate(
            List<UnitConverterUnitExpression> candidates,
            UnitConverterUnitExpression candidate)
        {
            foreach (UnitConverterUnitExpression existing in candidates)
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
            UnitConverterUnitExpression[] candidates,
            out UnitConverterUnitExpression expression)
        {
            expression = default(UnitConverterUnitExpression);

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

        private static UnitConverterUnitExpression Multiply(
            UnitConverterUnitExpression left,
            UnitConverterUnitExpression right)
        {
            return new UnitConverterUnitExpression(
                left.Text + "*" + right.Text,
                left.Dimensions.Multiply(right.Dimensions),
                left.ScaleToCanonical * right.ScaleToCanonical);
        }

        private static UnitConverterUnitExpression Divide(
            UnitConverterUnitExpression left,
            UnitConverterUnitExpression right)
        {
            return new UnitConverterUnitExpression(
                left.Text + "/" + right.Text,
                left.Dimensions.Divide(right.Dimensions),
                left.ScaleToCanonical / right.ScaleToCanonical);
        }

        private static UnitConverterUnitExpression Power(
            UnitConverterUnitExpression value,
            int exponent)
        {
            return new UnitConverterUnitExpression(
                value.Text + "^" + exponent,
                value.Dimensions.Pow(exponent),
                Math.Pow(value.ScaleToCanonical, exponent));
        }

        private static bool TryGetCanonicalScale(
            UnitConverterUnitCandidate candidate,
            out double scale)
        {
            scale = 0d;
            UnitConverterFamilyDescriptor family = candidate.Family;

            if (candidate.IsCustom)
            {
                if (candidate.CustomUnit.OffsetToReference != 0d)
                {
                    return false;
                }

                UnitConverterUnitDescriptor referenceDescriptor = null;
                foreach (UnitConverterUnitDescriptor unit in family.Units)
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
                    new UnitConverterUnitCandidate(
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

            if (family.Family == UnitConverterFamily.FuelEconomy)
            {
                return TryGetFuelEconomyScale(candidate, out scale);
            }

            UnitConverterUnitDescriptor baseUnit = null;
            foreach (UnitConverterUnitDescriptor unit in family.Units)
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
            UnitConverterUnitCandidate candidate,
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

            UnitConverterUnitDescriptor reference = null;
            foreach (UnitConverterUnitDescriptor unit in candidate.Family.Units)
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

        private static double GetBaseCanonicalScale(UnitConverterFamily family)
        {
            switch (family)
            {
                case UnitConverterFamily.Angle:
                    return Math.PI / 180d;
                case UnitConverterFamily.DigitalStorage:
                    return 8d;
                case UnitConverterFamily.Volume:
                    return 0.001d;
                default:
                    return 1d;
            }
        }

        private static string DescribeCandidates(
            IReadOnlyList<UnitConverterUnitCandidate> candidates)
        {
            var parts = new string[candidates.Count];

            for (int index = 0; index < candidates.Count; index++)
            {
                UnitConverterUnitCandidate candidate = candidates[index];
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

    public static class UnitConverterComposite
    {
        public static double Convert(
            double value,
            string fromExpression,
            string toExpression)
        {
            UnitConverterCompositeResult result =
                TryConvert(value, fromExpression, toExpression);

            if (!result.Success)
            {
                throw new ArgumentException(result.ErrorMessage);
            }

            return result.Value;
        }

        public static UnitConverterCompositeResult TryConvert(
            double value,
            string fromExpression,
            string toExpression)
        {
            UnitConverterUnitExpression[] fromCandidates;
            UnitConverterError fromError;
            string fromErrorMessage;

            if (!UnitConverterExpressionParser.TryParseCandidates(
                fromExpression,
                out fromCandidates,
                out fromError,
                out fromErrorMessage))
            {
                return UnitConverterCompositeResult.Fail(
                    fromError,
                    fromErrorMessage);
            }

            UnitConverterUnitExpression[] toCandidates;
            UnitConverterError toError;
            string toErrorMessage;

            if (!UnitConverterExpressionParser.TryParseCandidates(
                toExpression,
                out toCandidates,
                out toError,
                out toErrorMessage))
            {
                return UnitConverterCompositeResult.Fail(
                    toError,
                    toErrorMessage);
            }

            bool found = false;
            double ratio = 0d;
            UnitConverterUnitExpression selectedFrom =
                default(UnitConverterUnitExpression);
            UnitConverterUnitExpression selectedTo =
                default(UnitConverterUnitExpression);

            foreach (UnitConverterUnitExpression from in fromCandidates)
            {
                foreach (UnitConverterUnitExpression to in toCandidates)
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

                    if (!UnitConverterExpressionParser.NearlyEqual(
                        ratio,
                        candidateRatio))
                    {
                        return UnitConverterCompositeResult.Fail(
                            UnitConverterError.AmbiguousUnit,
                            "The conversion has multiple dimensionally valid interpretations.");
                    }
                }
            }

            if (!found)
            {
                return UnitConverterCompositeResult.Fail(
                    UnitConverterError.IncompatibleDimensions,
                    "The unit expressions do not have compatible dimensions.");
            }

            return UnitConverterCompositeResult.Ok(
                value * ratio,
                new UnitConverterUnitExpression(
                    fromExpression.Trim(),
                    selectedFrom.Dimensions,
                    selectedFrom.ScaleToCanonical),
                new UnitConverterUnitExpression(
                    toExpression.Trim(),
                    selectedTo.Dimensions,
                    selectedTo.ScaleToCanonical));
        }
    }
}
