namespace UnitConverter.Numbers
{
    using System;
    using System.Globalization;
    using System.Numerics;

    /// <summary>
    /// Optional idle/incremental-game notation. a = 10^36, b = 10^39,
    /// z = 10^111, aa = 10^114. Uses bijective base-26 letters.
    /// The numeric value is always stored as an ArbitraryScaleNumber.
    /// </summary>
    public static class GamingNumberNotation
    {
        public static string GetSuffix(BigInteger index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));

            var result = new System.Text.StringBuilder();
            BigInteger position = index + BigInteger.One;
            while (position > 0)
            {
                position -= BigInteger.One;
                result.Insert(0, (char)('a' + (int)(position % 26)));
                position /= 26;
            }
            return result.ToString();
        }

        public static bool TryGetIndex(string suffix, out BigInteger index)
        {
            index = BigInteger.Zero;
            if (string.IsNullOrEmpty(suffix))
                return false;

            foreach (char c in suffix)
            {
                if (c < 'a' || c > 'z')
                {
                    index = BigInteger.Zero;
                    return false;
                }
                index = index * 26 + (c - 'a' + 1);
            }
            index -= BigInteger.One;
            return true;
        }

        public static ArbitraryScaleNumber Parse(string input)
        {
            ArbitraryScaleNumber result;
            if (!TryParse(input, out result))
                throw new FormatException("Invalid gaming number notation.");
            return result;
        }

        public static bool TryParse(string input, out ArbitraryScaleNumber result)
        {
            result = ArbitraryScaleNumber.Zero;
            if (string.IsNullOrWhiteSpace(input))
                return false;

            string text = input.Trim();
            int end = text.Length;
            int begin = end;
            while (begin > 0 && text[begin - 1] >= 'a' && text[begin - 1] <= 'z')
                begin--;

            if (begin == end)
                return ArbitraryScaleNumber.TryParse(text, out result);

            string coefficient = text.Substring(0, begin).TrimEnd();
            string suffix = text.Substring(begin);
            BigInteger index;
            ArbitraryScaleNumber number;
            if (coefficient.Length == 0 ||
                !TryGetIndex(suffix, out index) ||
                !ArbitraryScaleNumber.TryParse(coefficient, out number))
                return false;

            result = number.Shift(new BigInteger(36) + index * 3);
            return true;
        }

        public static string Format(ArbitraryScaleNumber number, int maxOutputDigits = 4096)
        {
            if (number.IsZero)
                return "0";

            BigInteger power = NumberNotationMagnitude.GetBase10Magnitude(number);
            if (power < 36)
                return number.ToDecimalString(maxOutputDigits);

            BigInteger index = (power - 36) / 3;
            BigInteger scalePower = 36 + index * 3;
            return number.Shift(-scalePower).ToDecimalString(maxOutputDigits) +
                GetSuffix(index);
        }
    }

    internal static class NumberNotationMagnitude
    {
        internal static BigInteger GetBase10Magnitude(ArbitraryScaleNumber number)
        {
            // Highest nonzero term is also the leading term of a canonical
            // arbitrary-scale number. BigInteger exponents are not narrowed.
            var terms = number.Terms;
            BigInteger power = BigInteger.Zero;
            BigInteger coefficient = BigInteger.Zero;
            foreach (var term in terms)
            {
                power = term.Key;
                coefficient = term.Value;
            }

            int digitCount = BigInteger.Abs(coefficient)
                .ToString(CultureInfo.InvariantCulture).Length;
            return power + digitCount - 1;
        }
    }
}
