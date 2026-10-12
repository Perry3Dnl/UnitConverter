namespace UnitConverter.Numbers
{
    using System;
    using System.Globalization;
    using System.Numerics;

    /// <summary>Reversible developer-friendly and base-62 Ginor addresses.
    /// These encode name coordinates, not necessarily materializable numeric values.</summary>
    public static class GinorNotation
    {
        private const string Alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        public static string ToShortName(GeneratedNumberScalePosition position)
        {
            return ToShortName(new GeneratedNumberNameAddress(position, BigInteger.Zero));
        }

        public static string ToShortName(GeneratedNumberNameAddress address)
        {
            GeneratedNumberScalePosition p = address.Position;
            string prefix = p.Direction == GeneratedNumberScaleDirection.Tiny ? "G-" : "G";
            string result = prefix + p.Layer.ToString(CultureInfo.InvariantCulture) + ":" +
                p.Magnitude.ToString(CultureInfo.InvariantCulture) + ":" +
                p.Coefficient.ToString(CultureInfo.InvariantCulture);
            return address.FoldDepth.IsZero ? result :
                result + ":F" + address.FoldDepth.ToString(CultureInfo.InvariantCulture);
        }

        public static GeneratedNumberScalePosition ParseShortName(string text)
        {
            GeneratedNumberNameAddress address = ParseShortAddress(text);
            if (!address.FoldDepth.IsZero)
                throw new FormatException("Folded Ginor address cannot be represented as a scale position.");
            return address.Position;
        }

        public static GeneratedNumberNameAddress ParseShortAddress(string text)
        {
            GeneratedNumberNameAddress result;
            if (!TryParseShortAddress(text, out result))
                throw new FormatException("Invalid Ginor shortname.");
            return result;
        }

        public static bool TryParseShortAddress(string text, out GeneratedNumberNameAddress address)
        {
            address = default(GeneratedNumberNameAddress);
            if (string.IsNullOrEmpty(text)) return false;
            bool tiny = text.StartsWith("G-", StringComparison.Ordinal);
            if (!tiny && !text.StartsWith("G", StringComparison.Ordinal)) return false;
            string[] parts = text.Substring(tiny ? 2 : 1).Split(':');
            if (parts.Length != 3 && parts.Length != 4) return false;

            BigInteger layer, magnitude, coefficient, fold = BigInteger.Zero;
            if (!TryNonnegative(parts[0], out layer) ||
                !TryNonnegative(parts[1], out magnitude) ||
                !TryNonnegative(parts[2], out coefficient) ||
                coefficient.IsZero) return false;
            if (parts.Length == 4 &&
                (parts[3].Length < 2 || parts[3][0] != 'F' ||
                 !TryNonnegative(parts[3].Substring(1), out fold) || fold.IsZero))
                return false;

            address = new GeneratedNumberNameAddress(
                new GeneratedNumberScalePosition(
                    tiny ? GeneratedNumberScaleDirection.Tiny : GeneratedNumberScaleDirection.Large,
                    layer, magnitude, coefficient), fold);
            return ToShortName(address) == text;
        }

        public static string ToCompactName(GeneratedNumberScalePosition position)
        {
            return ToCompactName(new GeneratedNumberNameAddress(position, BigInteger.Zero));
        }

        public static string ToCompactName(GeneratedNumberNameAddress address)
        {
            GeneratedNumberScalePosition p = address.Position;
            BigInteger encoded = Pair(
                Pair(
                    Pair(
                        Pair(p.Direction == GeneratedNumberScaleDirection.Tiny ?
                            BigInteger.One : BigInteger.Zero, p.Layer),
                        p.Magnitude),
                    p.Coefficient - BigInteger.One),
                address.FoldDepth);
            return "G~" + ToBase62(encoded);
        }

        public static GeneratedNumberNameAddress ParseCompactName(string text)
        {
            GeneratedNumberNameAddress result;
            if (!TryParseCompactName(text, out result))
                throw new FormatException("Invalid Ginor compact name.");
            return result;
        }

        public static bool TryParseCompactName(string text, out GeneratedNumberNameAddress address)
        {
            address = default(GeneratedNumberNameAddress);
            if (string.IsNullOrEmpty(text) ||
                !text.StartsWith("G~", StringComparison.Ordinal)) return false;

            BigInteger encoded;
            if (!TryFromBase62(text.Substring(2), out encoded)) return false;
            BigInteger fold, coefficientMinusOne, magnitude, layer, direction;
            Unpair(encoded, out encoded, out fold);
            Unpair(encoded, out encoded, out coefficientMinusOne);
            Unpair(encoded, out encoded, out magnitude);
            Unpair(encoded, out direction, out layer);
            if (direction > BigInteger.One) return false;

            address = new GeneratedNumberNameAddress(
                new GeneratedNumberScalePosition(
                    direction.IsZero ? GeneratedNumberScaleDirection.Large :
                        GeneratedNumberScaleDirection.Tiny,
                    layer, magnitude, coefficientMinusOne + BigInteger.One),
                fold);
            return ToCompactName(address) == text;
        }

        private static bool TryNonnegative(string text, out BigInteger value)
        {
            value = BigInteger.Zero;
            if (string.IsNullOrEmpty(text)) return false;
            foreach (char c in text)
                if (c < '0' || c > '9') return false;
            return BigInteger.TryParse(text, NumberStyles.None,
                CultureInfo.InvariantCulture, out value) && value >= 0;
        }

        private static BigInteger Pair(BigInteger a, BigInteger b)
        {
            BigInteger sum = a + b;
            return sum * (sum + 1) / 2 + b;
        }

        private static void Unpair(BigInteger n, out BigInteger a, out BigInteger b)
        {
            BigInteger root = IntegerSquareRoot(8 * n + 1);
            BigInteger diagonal = (root - 1) / 2;
            b = n - diagonal * (diagonal + 1) / 2;
            a = diagonal - b;
        }

        private static BigInteger IntegerSquareRoot(BigInteger n)
        {
            if (n < 2) return n;
            BigInteger x = n, y = (x + 1) / 2;
            while (y < x) { x = y; y = (x + n / x) / 2; }
            return x;
        }

        private static string ToBase62(BigInteger n)
        {
            if (n.IsZero) return "0";
            var builder = new System.Text.StringBuilder();
            while (n > 0)
            {
                BigInteger remainder;
                n = BigInteger.DivRem(n, 62, out remainder);
                builder.Insert(0, Alphabet[(int)remainder]);
            }
            return builder.ToString();
        }

        private static bool TryFromBase62(string text, out BigInteger n)
        {
            n = BigInteger.Zero;
            if (string.IsNullOrEmpty(text)) return false;
            foreach (char c in text)
            {
                int digit = Alphabet.IndexOf(c);
                if (digit < 0) { n = BigInteger.Zero; return false; }
                n = n * 62 + digit;
            }
            return ToBase62(n) == text;
        }
    }
}
