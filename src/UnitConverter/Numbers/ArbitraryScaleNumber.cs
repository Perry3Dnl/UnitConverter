namespace UnitConverter.Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.Linq;
    using System.Numerics;

    /// <summary>
    /// Exact sparse base-10 number. Values are stored as coefficient × 10^exponent
    /// terms so enormous gaps never require materializing zeroes.
    /// </summary>
    public readonly struct ArbitraryScaleNumber : IEquatable<ArbitraryScaleNumber>
    {
        private readonly SortedDictionary<BigInteger, BigInteger> _terms;

        public IReadOnlyDictionary<BigInteger, BigInteger> Terms
        {
            get
            {
                var copy = _terms == null
                    ? new SortedDictionary<BigInteger, BigInteger>()
                    : new SortedDictionary<BigInteger, BigInteger>(_terms);

                return new ReadOnlyDictionary<BigInteger, BigInteger>(copy);
            }
        }

        public BigInteger Significand
        {
            get
            {
                EnsureSingleTerm();
                return _terms.Values.Single();
            }
        }

        public BigInteger Exponent
        {
            get
            {
                EnsureSingleTerm();
                return _terms.Keys.Single();
            }
        }

        public bool IsZero
        {
            get { return _terms == null || _terms.Count == 0; }
        }

        public int Sign
        {
            get
            {
                if (IsZero)
                {
                    return 0;
                }

                return _terms.Last().Value.Sign;
            }
        }

        public ArbitraryScaleNumber(BigInteger coefficient, BigInteger exponent)
            : this(new[]
            {
                new KeyValuePair<BigInteger, BigInteger>(exponent, coefficient)
            })
        {
        }

        private ArbitraryScaleNumber(
            IEnumerable<KeyValuePair<BigInteger, BigInteger>> terms)
        {
            var canonical =
                new SortedDictionary<BigInteger, BigInteger>();

            foreach (KeyValuePair<BigInteger, BigInteger> term in terms)
            {
                AddCanonical(canonical, term.Value, term.Key);
            }

            _terms = canonical.Count == 0 ? null : canonical;
        }

        public static ArbitraryScaleNumber Zero
        {
            get { return default(ArbitraryScaleNumber); }
        }

        public static ArbitraryScaleNumber One
        {
            get
            {
                return new ArbitraryScaleNumber(
                    BigInteger.One,
                    BigInteger.Zero);
            }
        }

        public static ArbitraryScaleNumber Parse(string text)
        {
            return ArbitraryScaleNumberParser.Parse(text);
        }

        public static bool TryParse(
            string text,
            out ArbitraryScaleNumber value)
        {
            try
            {
                value = Parse(text);
                return true;
            }
            catch (ArgumentException)
            {
            }
            catch (FormatException)
            {
            }
            catch (InvalidOperationException)
            {
            }
            catch (OverflowException)
            {
            }

            value = default(ArbitraryScaleNumber);
            return false;
        }

        public ArbitraryScaleNumber In(string scale)
        {
            NumberScaleDescriptor descriptor =
                NumberScaleCatalog.Get(scale);

            return Shift(-descriptor.Exponent);
        }

        public ArbitraryScaleNumber Shift(BigInteger decimalPlaces)
        {
            if (IsZero)
            {
                return this;
            }

            return new ArbitraryScaleNumber(
                _terms.Select(
                    term =>
                        new KeyValuePair<BigInteger, BigInteger>(
                            term.Key + decimalPlaces,
                            term.Value)));
        }

        public ArbitraryScaleNumber Abs()
        {
            return Sign >= 0 ? this : -this;
        }

        public static ArbitraryScaleNumber operator -(
            ArbitraryScaleNumber value)
        {
            if (value.IsZero)
            {
                return value;
            }

            return new ArbitraryScaleNumber(
                value._terms.Select(
                    term =>
                        new KeyValuePair<BigInteger, BigInteger>(
                            term.Key,
                            -term.Value)));
        }

        public static ArbitraryScaleNumber operator +(
            ArbitraryScaleNumber left,
            ArbitraryScaleNumber right)
        {
            if (left.IsZero)
            {
                return right;
            }

            if (right.IsZero)
            {
                return left;
            }

            return new ArbitraryScaleNumber(
                left._terms.Concat(right._terms));
        }

        public static ArbitraryScaleNumber operator -(
            ArbitraryScaleNumber left,
            ArbitraryScaleNumber right)
        {
            return left + (-right);
        }

        public static ArbitraryScaleNumber operator *(
            ArbitraryScaleNumber left,
            ArbitraryScaleNumber right)
        {
            if (left.IsZero || right.IsZero)
            {
                return Zero;
            }

            var products =
                from a in left._terms
                from b in right._terms
                select new KeyValuePair<BigInteger, BigInteger>(
                    a.Key + b.Key,
                    a.Value * b.Value);

            return new ArbitraryScaleNumber(products);
        }

        public static ArbitraryScaleNumber Pow(
            ArbitraryScaleNumber value,
            int exponent)
        {
            if (exponent < 0)
            {
                throw new NotSupportedException(
                    "Negative powers require rational arbitrary-scale number support.");
            }

            ArbitraryScaleNumber result = One;
            ArbitraryScaleNumber factor = value;
            int power = exponent;

            while (power > 0)
            {
                if ((power & 1) != 0)
                {
                    result *= factor;
                }

                power >>= 1;

                if (power != 0)
                {
                    factor *= factor;
                }
            }

            return result;
        }

        public string ToScientific()
        {
            if (IsZero)
            {
                return "0";
            }

            if (_terms.Count == 1)
            {
                KeyValuePair<BigInteger, BigInteger> term =
                    _terms.Single();

                string digits =
                    BigInteger.Abs(term.Value)
                        .ToString(CultureInfo.InvariantCulture);

                BigInteger exponent =
                    term.Key + digits.Length - 1;

                string coefficient =
                    (term.Value.Sign < 0 ? "-" : "") +
                    digits[0] +
                    (digits.Length > 1
                        ? "." + digits.Substring(1)
                        : "");

                return coefficient + "e" +
                    exponent.ToString(CultureInfo.InvariantCulture);
            }

            return string.Join(
                " + ",
                _terms
                    .Reverse()
                    .Select(
                        term => FormatTerm(
                            term.Value,
                            term.Key))
                    .ToArray());
        }

        public string ToDecimalString(int maxOutputDigits = 100000)
        {
            if (maxOutputDigits <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(maxOutputDigits));
            }

            if (IsZero)
            {
                return "0";
            }

            BigInteger minExponent = _terms.First().Key;
            KeyValuePair<BigInteger, BigInteger> maxTerm =
                _terms.Last();

            int leadingDigits =
                BigInteger.Abs(maxTerm.Value)
                    .ToString(CultureInfo.InvariantCulture)
                    .Length;

            BigInteger span =
                maxTerm.Key +
                leadingDigits -
                minExponent;

            if (span > maxOutputDigits ||
                span > int.MaxValue ||
                minExponent < -maxOutputDigits)
            {
                throw new InvalidOperationException(
                    "Expanded decimal exceeds the configured output limit; use sparse/scientific formatting.");
            }

            BigInteger scaled = BigInteger.Zero;

            foreach (KeyValuePair<BigInteger, BigInteger> term in _terms)
            {
                BigInteger shift = term.Key - minExponent;

                scaled +=
                    term.Value *
                    BigInteger.Pow(
                        new BigInteger(10),
                        checked((int)shift));
            }

            return new ArbitraryScaleNumber(
                scaled,
                minExponent)
                .ToDecimalSingle(maxOutputDigits);
        }

        private string ToDecimalSingle(int limit)
        {
            BigInteger coefficient = Significand;
            BigInteger exponent = Exponent;
            bool negative = coefficient.Sign < 0;

            string digits =
                BigInteger.Abs(coefficient)
                    .ToString(CultureInfo.InvariantCulture);

            if (exponent > limit || exponent < -limit)
            {
                throw new InvalidOperationException(
                    "Expanded decimal exceeds the configured output limit.");
            }

            int numericExponent = (int)exponent;
            string result;

            if (numericExponent >= 0)
            {
                result =
                    digits +
                    new string('0', numericExponent);
            }
            else
            {
                int point = digits.Length + numericExponent;

                result = point > 0
                    ? digits.Insert(point, ".")
                    : "0." +
                        new string('0', -point) +
                        digits;
            }

            return negative ? "-" + result : result;
        }

        private static void AddCanonical(
            SortedDictionary<BigInteger, BigInteger> terms,
            BigInteger coefficient,
            BigInteger exponent)
        {
            while (!coefficient.IsZero)
            {
                while (coefficient % 10 == 0)
                {
                    coefficient /= 10;
                    exponent++;
                }

                BigInteger existing;

                if (!terms.TryGetValue(
                    exponent,
                    out existing))
                {
                    terms.Add(
                        exponent,
                        coefficient);

                    return;
                }

                terms.Remove(exponent);
                coefficient += existing;
            }
        }

        private static string FormatTerm(
            BigInteger coefficient,
            BigInteger exponent)
        {
            if (exponent.IsZero)
            {
                return coefficient.ToString(
                    CultureInfo.InvariantCulture);
            }

            return coefficient.ToString(
                    CultureInfo.InvariantCulture) +
                "e" +
                exponent.ToString(
                    CultureInfo.InvariantCulture);
        }

        private void EnsureSingleTerm()
        {
            if (_terms == null || _terms.Count != 1)
            {
                throw new InvalidOperationException(
                    "This value contains multiple sparse terms.");
            }
        }

        public bool Equals(ArbitraryScaleNumber other)
        {
            if (IsZero || other.IsZero)
            {
                return IsZero == other.IsZero;
            }

            return _terms.SequenceEqual(other._terms);
        }

        public override bool Equals(object obj)
        {
            return obj is ArbitraryScaleNumber &&
                Equals((ArbitraryScaleNumber)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                if (_terms != null)
                {
                    foreach (KeyValuePair<BigInteger, BigInteger> term in _terms)
                    {
                        hash = (hash * 31) + term.Key.GetHashCode();
                        hash = (hash * 31) + term.Value.GetHashCode();
                    }
                }

                return hash;
            }
        }

        public static bool operator ==(
            ArbitraryScaleNumber left,
            ArbitraryScaleNumber right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(
            ArbitraryScaleNumber left,
            ArbitraryScaleNumber right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            return ToScientific();
        }
    }

    internal static class ArbitraryScaleNumberParser
    {
        public static ArbitraryScaleNumber Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException(
                    "A number is required.",
                    nameof(input));
            }

            string text =
                input.Trim()
                    .Replace(",", "")
                    .Replace("_", "");

            int separator = text.LastIndexOf(' ');

            if (separator > 0)
            {
                string coefficientText =
                    text.Substring(0, separator).Trim();
                string scaleName =
                    text.Substring(separator + 1).Trim();

                NumberScaleDescriptor scale;
                if (NumberScaleCatalog.TryGet(
                    scaleName,
                    out scale))
                {
                    ArbitraryScaleNumber coefficient =
                        ParseNumeric(coefficientText);

                    ValidateCanonicalNamedCoefficient(
                        coefficient,
                        scale.Name);

                    return coefficient.Shift(
                        scale.Exponent);
                }
            }

            return ParseNumeric(text);
        }

        private static void ValidateCanonicalNamedCoefficient(
            ArbitraryScaleNumber coefficient,
            string scaleName)
        {
            ArbitraryScaleNumber absolute =
                coefficient.Abs();

            decimal value;

            try
            {
                value = decimal.Parse(
                    absolute.ToDecimalString(64),
                    NumberStyles.Number |
                        NumberStyles.AllowExponent,
                    CultureInfo.InvariantCulture);
            }
            catch (Exception exception)
            {
                throw new FormatException(
                    "The named-scale coefficient cannot be materialized for canonical validation.",
                    exception);
            }

            if (value < 1m || value >= 1000m)
            {
                throw new FormatException(
                    "'" +
                    coefficient.ToScientific() +
                    " " +
                    scaleName +
                    "' is not a canonical named-scale value. " +
                    "Named-scale coefficients must be at least 1 and less than 1000.");
            }
        }

        private static ArbitraryScaleNumber ParseNumeric(
            string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new FormatException(
                    "The numeric component is empty.");
            }

            int exponentIndex = -1;

            for (int index = 0; index < text.Length; index++)
            {
                char character = text[index];

                if (character == 'e' ||
                    character == 'E')
                {
                    if (exponentIndex >= 0)
                    {
                        throw new FormatException(
                            "'" + text +
                            "' is not a supported number.");
                    }

                    exponentIndex = index;
                }
            }

            string coefficient =
                exponentIndex >= 0
                    ? text.Substring(0, exponentIndex)
                    : text;

            string exponentText =
                exponentIndex >= 0
                    ? text.Substring(exponentIndex + 1)
                    : null;

            BigInteger exponent = BigInteger.Zero;

            if (exponentText != null &&
                !BigInteger.TryParse(
                    exponentText,
                    NumberStyles.AllowLeadingSign,
                    CultureInfo.InvariantCulture,
                    out exponent))
            {
                throw new FormatException(
                    "'" + text +
                    "' is not a supported number.");
            }

            bool negative = false;

            if (coefficient.StartsWith(
                "-",
                StringComparison.Ordinal))
            {
                negative = true;
                coefficient = coefficient.Substring(1);
            }
            else if (coefficient.StartsWith(
                "+",
                StringComparison.Ordinal))
            {
                coefficient = coefficient.Substring(1);
            }

            int dot = coefficient.IndexOf('.');

            if (dot != coefficient.LastIndexOf('.'))
            {
                throw new FormatException(
                    "'" + text +
                    "' is not a supported number.");
            }

            int fractionDigits =
                dot < 0
                    ? 0
                    : coefficient.Length - dot - 1;

            string digits =
                coefficient.Replace(".", "");

            if (digits.Length == 0 ||
                digits.Any(character =>
                    character < '0' ||
                    character > '9'))
            {
                throw new FormatException(
                    "'" + text +
                    "' is not a supported number.");
            }

            BigInteger significand;

            if (!BigInteger.TryParse(
                (negative ? "-" : "") + digits,
                NumberStyles.AllowLeadingSign,
                CultureInfo.InvariantCulture,
                out significand))
            {
                throw new FormatException(
                    "'" + text +
                    "' is not a supported number.");
            }

            return new ArbitraryScaleNumber(
                significand,
                exponent - fractionDigits);
        }
    }
}
