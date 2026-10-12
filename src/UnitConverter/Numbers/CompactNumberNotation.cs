namespace UnitConverter.Numbers
{
    using System;
    using System.Numerics;

    /// <summary>
    /// Case-sensitive human-readable short-scale suffixes.
    /// Examples: 1.5M, 2B, 3Qa. Lowercase m is intentionally
    /// NOT treated as million, because SI uses m for milli.
    /// </summary>
    public static class CompactNumberNotation
    {
        private static readonly string[] Suffixes =
        {
            "K", "M", "B", "T", "Qa", "Qi", "Sx", "Sp", "Oc", "No", "Dc"
        };

        public static ArbitraryScaleNumber Parse(string text)
        {
            ArbitraryScaleNumber result;
            if (!TryParse(text, out result))
                throw new FormatException("Invalid compact number notation.");
            return result;
        }

        public static bool TryParse(string text, out ArbitraryScaleNumber result)
        {
            result = ArbitraryScaleNumber.Zero;
            if (string.IsNullOrWhiteSpace(text))
                return false;

            string candidate = text.Trim();
            for (int i = Suffixes.Length - 1; i >= 0; i--)
            {
                string suffix = Suffixes[i];
                if (!candidate.EndsWith(suffix, StringComparison.Ordinal))
                    continue;

                string prefix = candidate.Substring(
                    0, candidate.Length - suffix.Length).TrimEnd();
                ArbitraryScaleNumber coefficient;
                if (!ArbitraryScaleNumber.TryParse(prefix, out coefficient))
                    return false;

                result = coefficient.Shift((i + 1) * 3);
                return true;
            }

            return ArbitraryScaleNumber.TryParse(candidate, out result);
        }

        public static string Format(ArbitraryScaleNumber number, int maxOutputDigits = 4096)
        {
            if (number.IsZero)
                return "0";

            BigInteger magnitude = NumberNotationMagnitude.GetBase10Magnitude(number);
            if (magnitude < 3)
                return number.ToDecimalString(maxOutputDigits);

            if (magnitude >= 36)
                return number.ToScientific();

            int index = (int)(magnitude / 3) - 1;
            int exponent = (index + 1) * 3;
            return number.Shift(-exponent).ToDecimalString(maxOutputDigits) +
                Suffixes[index];
        }
    }
}
