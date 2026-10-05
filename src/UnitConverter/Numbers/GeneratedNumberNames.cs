namespace UnitConverter.Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public readonly struct GeneratedNumberScalePosition
        : IEquatable<GeneratedNumberScalePosition>
    {
        public GeneratedNumberScalePosition(
            BigInteger layer,
            BigInteger magnitude,
            BigInteger coefficient)
        {
            if (layer < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(layer));
            }

            if (magnitude < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(magnitude));
            }

            if (coefficient < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(coefficient));
            }

            Layer = layer;
            Magnitude = magnitude;
            Coefficient = coefficient;
        }

        public BigInteger Layer { get; }
        public BigInteger Magnitude { get; }
        public BigInteger Coefficient { get; }

        public bool Equals(GeneratedNumberScalePosition other)
        {
            return Layer == other.Layer &&
                Magnitude == other.Magnitude &&
                Coefficient == other.Coefficient;
        }

        public override bool Equals(object obj)
        {
            return obj is GeneratedNumberScalePosition &&
                Equals((GeneratedNumberScalePosition)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 31) + Layer.GetHashCode();
                hash = (hash * 31) + Magnitude.GetHashCode();
                hash = (hash * 31) + Coefficient.GetHashCode();
                return hash;
            }
        }

        public static bool operator ==(
            GeneratedNumberScalePosition left,
            GeneratedNumberScalePosition right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(
            GeneratedNumberScalePosition left,
            GeneratedNumberScalePosition right)
        {
            return !left.Equals(right);
        }
    }

    /// <summary>
    /// Deterministic reversible generated number-name grammar inherited from Ginor.
    /// Ginozillion is the generated name at layer 2, magnitude 4, coefficient 1.
    /// </summary>
    public static class GeneratedNumberNames
    {
        private static readonly string[] Syllables =
        {
            "ba", "be", "bi", "bo", "bu",
            "da", "de", "di", "do", "du",
            "fa", "fe", "fi", "fo", "fu",
            "ga", "ge", "gi", "go", "gu",
            "ka", "ke", "ki", "ko", "ku",
            "la", "le", "li", "lo", "lu",
            "ma", "me", "mi", "mo", "mu",
            "na", "ne", "ni", "no", "nu"
        };

        private const int LexicalOffset = 90;
        private const string Suffix = "zillion";

        private static readonly Dictionary<string, int> SyllableIndexes =
            CreateSyllableIndexes();

        public static string GetName(
            BigInteger layer,
            BigInteger magnitude)
        {
            return GetName(
                new GeneratedNumberScalePosition(
                    layer,
                    magnitude,
                    BigInteger.One));
        }

        public static string GetName(
            GeneratedNumberScalePosition position)
        {
            BigInteger structure =
                Pair(
                    Pair(
                        position.Layer,
                        position.Magnitude),
                    position.Coefficient - 1);

            BigInteger payload = structure * 2;
            BigInteger lexicalOrdinal =
                payload + LexicalOffset;

            return EncodeNameInteger(
                    lexicalOrdinal) +
                Suffix;
        }

        public static GeneratedNumberScalePosition Parse(
            string name)
        {
            GeneratedNumberScalePosition position;

            if (!TryParse(name, out position))
            {
                throw new FormatException(
                    "'" + name +
                    "' is not a generated number scale name.");
            }

            return position;
        }

        public static bool TryParse(
            string name,
            out GeneratedNumberScalePosition position)
        {
            position =
                default(GeneratedNumberScalePosition);

            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            string candidate =
                name.Trim()
                    .ToLowerInvariant();

            if (!candidate.EndsWith(
                Suffix,
                StringComparison.Ordinal))
            {
                return false;
            }

            string lexical =
                candidate.Substring(
                    0,
                    candidate.Length - Suffix.Length);

            BigInteger lexicalOrdinal;

            if (!TryDecodeNameInteger(
                lexical,
                out lexicalOrdinal))
            {
                return false;
            }

            BigInteger payload =
                lexicalOrdinal - LexicalOffset;

            if (payload < 0 ||
                payload % 2 != 0)
            {
                return false;
            }

            BigInteger structure =
                payload / 2;

            BigInteger pairedLayerMagnitude;
            BigInteger coefficientMinusOne;

            Unpair(
                structure,
                out pairedLayerMagnitude,
                out coefficientMinusOne);

            BigInteger layer;
            BigInteger magnitude;

            Unpair(
                pairedLayerMagnitude,
                out layer,
                out magnitude);

            try
            {
                var decoded =
                    new GeneratedNumberScalePosition(
                        layer,
                        magnitude,
                        coefficientMinusOne + 1);

                if (!string.Equals(
                    GetName(decoded),
                    candidate,
                    StringComparison.Ordinal))
                {
                    return false;
                }

                position = decoded;
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }

        private static BigInteger Pair(
            BigInteger left,
            BigInteger right)
        {
            BigInteger sum = left + right;

            return
                (sum * (sum + 1)) /
                2 +
                right;
        }

        private static void Unpair(
            BigInteger value,
            out BigInteger left,
            out BigInteger right)
        {
            BigInteger root =
                IntegerSquareRoot(
                    (value * 8) + 1);

            BigInteger diagonal =
                (root - 1) / 2;

            BigInteger triangle =
                diagonal *
                (diagonal + 1) /
                2;

            right = value - triangle;
            left = diagonal - right;
        }

        private static string EncodeNameInteger(
            BigInteger value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value));
            }

            BigInteger alphabet =
                Syllables.Length;

            BigInteger continuation =
                alphabet - 1;

            int length = 1;
            BigInteger blockSize = alphabet;
            BigInteger ordinal = value;

            while (ordinal >= blockSize)
            {
                ordinal -= blockSize;
                blockSize *= continuation;
                length++;
            }

            var result =
                new System.Text.StringBuilder();

            BigInteger place =
                BigInteger.Pow(
                    continuation,
                    length - 1);

            int previous = -1;

            for (int position = 0;
                position < length;
                position++)
            {
                int digit;

                if (position == 0)
                {
                    digit =
                        (int)(ordinal / place);

                    ordinal %= place;
                }
                else
                {
                    int rank =
                        (int)(ordinal / place);

                    ordinal %= place;

                    digit =
                        rank >= previous
                            ? rank + 1
                            : rank;
                }

                result.Append(
                    Syllables[digit]);

                previous = digit;

                if (position + 1 < length)
                {
                    place /= continuation;
                }
            }

            return result.ToString();
        }

        private static bool TryDecodeNameInteger(
            string text,
            out BigInteger value)
        {
            value = BigInteger.Zero;

            if (string.IsNullOrEmpty(text) ||
                text.Length % 2 != 0)
            {
                return false;
            }

            int length = text.Length / 2;
            var digits = new int[length];

            for (int index = 0;
                index < length;
                index++)
            {
                string syllable =
                    text.Substring(
                        index * 2,
                        2);

                int digit;

                if (!SyllableIndexes.TryGetValue(
                    syllable,
                    out digit))
                {
                    return false;
                }

                if (index > 0 &&
                    digit == digits[index - 1])
                {
                    return false;
                }

                digits[index] = digit;
            }

            BigInteger alphabet =
                Syllables.Length;

            BigInteger continuation =
                alphabet - 1;

            BigInteger ordinal =
                BigInteger.Zero;

            BigInteger block = alphabet;

            for (int shorter = 1;
                shorter < length;
                shorter++)
            {
                ordinal += block;
                block *= continuation;
            }

            BigInteger place =
                BigInteger.Pow(
                    continuation,
                    length - 1);

            ordinal +=
                digits[0] *
                place;

            int previous = digits[0];

            for (int index = 1;
                index < length;
                index++)
            {
                place /= continuation;

                int digit = digits[index];
                int rank =
                    digit > previous
                        ? digit - 1
                        : digit;

                ordinal +=
                    rank *
                    place;

                previous = digit;
            }

            value = ordinal;
            return true;
        }

        private static BigInteger IntegerSquareRoot(
            BigInteger value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value));
            }

            if (value < 2)
            {
                return value;
            }

            BigInteger low = BigInteger.One;
            BigInteger high = value;

            while (low <= high)
            {
                BigInteger middle =
                    (low + high) / 2;

                BigInteger square =
                    middle * middle;

                if (square == value)
                {
                    return middle;
                }

                if (square < value)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }

            return high;
        }

        private static Dictionary<string, int>
            CreateSyllableIndexes()
        {
            var result =
                new Dictionary<string, int>(
                    StringComparer.Ordinal);

            for (int index = 0;
                index < Syllables.Length;
                index++)
            {
                result.Add(
                    Syllables[index],
                    index);
            }

            return result;
        }
    }
}
