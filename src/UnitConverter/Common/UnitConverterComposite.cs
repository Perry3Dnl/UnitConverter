namespace UnitConverter
{
    using System;
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
            if (string.IsNullOrWhiteSpace(expression))
            {
                return UnitConverterExpressionParseResult.Fail(
                    UnitConverterError.InvalidExpression,
                    "The unit expression is empty.");
            }

            string normalized = Normalize(expression);
            var parser = new Parser(normalized);
            UnitConverterUnitExpression parsed;

            if (!parser.TryParse(out parsed))
            {
                return UnitConverterExpressionParseResult.Fail(
                    parser.Error,
                    parser.ErrorMessage);
            }

            return UnitConverterExpressionParseResult.Ok(
                new UnitConverterUnitExpression(
                    expression.Trim(),
                    parsed.Dimensions,
                    parsed.ScaleToCanonical));
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

            public bool TryParse(out UnitConverterUnitExpression expression)
            {
                expression = default(UnitConverterUnitExpression);
                SkipWhitespace();

                if (!TryParseProduct(out expression))
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

            private bool TryParseProduct(out UnitConverterUnitExpression expression)
            {
                if (!TryParsePower(out expression))
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

                    UnitConverterUnitExpression right;
                    if (!TryParsePower(out right))
                    {
                        return false;
                    }

                    expression = operation == '/'
                        ? Divide(expression, right)
                        : Multiply(expression, right);
                }
            }

            private bool TryParsePower(out UnitConverterUnitExpression expression)
            {
                if (!TryParsePrimary(out expression))
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
                expression = Power(expression, exponent);
                return true;
            }

            private bool TryParsePrimary(out UnitConverterUnitExpression expression)
            {
                expression = default(UnitConverterUnitExpression);
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
                    if (!TryParseProduct(out expression))
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

                return TryResolveAtom(atom, out expression);
            }

            private bool TryResolveAtom(
                string atom,
                out UnitConverterUnitExpression expression)
            {
                expression = default(UnitConverterUnitExpression);
                UnitConverterDetectionResult detection =
                    UnitConverterDetector.DetectUnit(atom);

                if (detection.Status != UnitConverterDetectionStatus.Unknown)
                {
                    return TryResolveDetection(atom, detection, out expression);
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

                UnitConverterUnitExpression combined =
                    new UnitConverterUnitExpression(
                        atom,
                        UnitConverterDimensions.Dimensionless,
                        1d);

                foreach (string piece in pieces)
                {
                    UnitConverterDetectionResult pieceDetection =
                        UnitConverterDetector.DetectUnit(piece);
                    UnitConverterUnitExpression resolved;

                    if (!TryResolveDetection(piece, pieceDetection, out resolved))
                    {
                        return false;
                    }

                    combined = Multiply(combined, resolved);
                }

                expression = combined;
                return true;
            }

            private bool TryResolveDetection(
                string atom,
                UnitConverterDetectionResult detection,
                out UnitConverterUnitExpression expression)
            {
                expression = default(UnitConverterUnitExpression);

                if (detection.Status == UnitConverterDetectionStatus.Unknown)
                {
                    return Fail(
                        detection.Error == UnitConverterError.None
                            ? UnitConverterError.UnknownUnit
                            : detection.Error,
                        detection.ErrorMessage ?? ("The unit '" + atom + "' is not recognized."));
                }

                if (detection.Status == UnitConverterDetectionStatus.Resolved)
                {
                    double scale;
                    if (!TryGetCanonicalScale(detection.Candidate, out scale))
                    {
                        return Fail(
                            UnitConverterError.UnsupportedUnit,
                            "The unit '" + atom + "' cannot be used as a multiplicative expression factor.");
                    }

                    expression = new UnitConverterUnitExpression(
                        atom,
                        detection.Candidate.Unit.Dimensions,
                        scale);
                    return true;
                }

                IReadOnlyList<UnitConverterUnitCandidate> candidates =
                    detection.Candidates;
                var exactSymbolCandidates =
                    new List<UnitConverterUnitCandidate>();

                foreach (UnitConverterUnitCandidate candidate in detection.Candidates)
                {
                    if (string.Equals(
                        candidate.Unit.Symbol,
                        atom,
                        StringComparison.Ordinal))
                    {
                        exactSymbolCandidates.Add(candidate);
                    }
                }

                if (exactSymbolCandidates.Count == 1)
                {
                    double exactScale;
                    if (!TryGetCanonicalScale(
                        exactSymbolCandidates[0],
                        out exactScale))
                    {
                        return Fail(
                            UnitConverterError.UnsupportedUnit,
                            "The unit '" + atom +
                            "' cannot be used as a multiplicative expression factor.");
                    }

                    expression = new UnitConverterUnitExpression(
                        atom,
                        exactSymbolCandidates[0].Unit.Dimensions,
                        exactScale);
                    return true;
                }

                if (exactSymbolCandidates.Count > 1)
                {
                    candidates = exactSymbolCandidates;
                }

                UnitConverterUnitCandidate first = null;
                UnitConverterDimensions dimensions =
                    UnitConverterDimensions.Dimensionless;
                double firstScale = 0d;

                foreach (UnitConverterUnitCandidate candidate in candidates)
                {
                    double scale;
                    if (!TryGetCanonicalScale(candidate, out scale))
                    {
                        continue;
                    }

                    if (first == null)
                    {
                        first = candidate;
                        dimensions = candidate.Unit.Dimensions;
                        firstScale = scale;
                        continue;
                    }

                    if (candidate.Unit.Dimensions != dimensions ||
                        !NearlyEqual(scale, firstScale))
                    {
                        return Fail(
                            UnitConverterError.AmbiguousUnit,
                            "The unit '" + atom + "' is ambiguous across incompatible candidates.");
                    }
                }

                if (first == null)
                {
                    return Fail(
                        UnitConverterError.UnsupportedUnit,
                        "The unit '" + atom + "' cannot be used as a multiplicative expression factor.");
                }

                expression = new UnitConverterUnitExpression(
                    atom,
                    dimensions,
                    firstScale);
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

        private static bool NearlyEqual(double left, double right)
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
            UnitConverterExpressionParseResult from =
                UnitConverterExpressionParser.TryParse(fromExpression);
            if (!from.Success)
            {
                return UnitConverterCompositeResult.Fail(
                    from.Error,
                    from.ErrorMessage);
            }

            UnitConverterExpressionParseResult to =
                UnitConverterExpressionParser.TryParse(toExpression);
            if (!to.Success)
            {
                return UnitConverterCompositeResult.Fail(
                    to.Error,
                    to.ErrorMessage);
            }

            if (!from.Expression.IsCompatibleWith(to.Expression))
            {
                return UnitConverterCompositeResult.Fail(
                    UnitConverterError.IncompatibleDimensions,
                    "The unit expressions do not have compatible dimensions.");
            }

            double converted =
                value *
                from.Expression.ScaleToCanonical /
                to.Expression.ScaleToCanonical;

            return UnitConverterCompositeResult.Ok(
                converted,
                from.Expression,
                to.Expression);
        }
    }
}
