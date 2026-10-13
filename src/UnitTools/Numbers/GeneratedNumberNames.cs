namespace UnitTools.Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public enum GeneratedNumberScaleDirection
    {
        Large = 0,
        Tiny = 1,
    }

    public readonly struct GeneratedNumberScalePosition
        : IEquatable<GeneratedNumberScalePosition>
    {
        public GeneratedNumberScalePosition(
            BigInteger layer,
            BigInteger magnitude,
            BigInteger coefficient)
            : this(
                GeneratedNumberScaleDirection.Large,
                layer,
                magnitude,
                coefficient)
        {
        }

        public GeneratedNumberScalePosition(
            GeneratedNumberScaleDirection direction,
            BigInteger layer,
            BigInteger magnitude,
            BigInteger coefficient)
        {
            if (direction != GeneratedNumberScaleDirection.Large &&
                direction != GeneratedNumberScaleDirection.Tiny)
            {
                throw new ArgumentOutOfRangeException(nameof(direction));
            }
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

            Direction = direction;
            Layer = layer;
            Magnitude = magnitude;
            Coefficient = coefficient;
        }

        public GeneratedNumberScaleDirection Direction { get; }
        public BigInteger Layer { get; }
        public BigInteger Magnitude { get; }
        public BigInteger Coefficient { get; }

        public bool Equals(GeneratedNumberScalePosition other)
        {
            return Direction == other.Direction &&
                Layer == other.Layer &&
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
                hash = (hash * 31) + Direction.GetHashCode();
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

    public readonly struct GeneratedNumberNameAddress
        : IEquatable<GeneratedNumberNameAddress>
    {
        public GeneratedNumberNameAddress(
            GeneratedNumberScalePosition position,
            BigInteger foldDepth)
        {
            if (foldDepth < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(foldDepth));
            }

            Position = position;
            FoldDepth = foldDepth;
        }

        public GeneratedNumberScalePosition Position { get; }
        public BigInteger FoldDepth { get; }

        public string ToSymbolicExpression()
        {
            string expression =
                "10^(10^" +
                Position.Magnitude.ToString() +
                ")";

            BigInteger remaining = FoldDepth;

            while (remaining > 0)
            {
                expression =
                    "10^(" +
                    expression +
                    ")";

                remaining--;
            }

            return Position.Direction == GeneratedNumberScaleDirection.Tiny
                ? "1/(" + expression + ")"
                : expression;
        }

        public bool Equals(GeneratedNumberNameAddress other)
        {
            return Position == other.Position &&
                FoldDepth == other.FoldDepth;
        }

        public override bool Equals(object obj)
        {
            return obj is GeneratedNumberNameAddress &&
                Equals((GeneratedNumberNameAddress)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return
                    (Position.GetHashCode() * 397) ^
                    FoldDepth.GetHashCode();
            }
        }

        public static bool operator ==(
            GeneratedNumberNameAddress left,
            GeneratedNumberNameAddress right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(
            GeneratedNumberNameAddress left,
            GeneratedNumberNameAddress right)
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
        private const string FoldSeparator = "ra";

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

            BigInteger payload =
                (structure * 2) +
                (position.Direction == GeneratedNumberScaleDirection.Tiny
                    ? BigInteger.One
                    : BigInteger.Zero);
            BigInteger lexicalOrdinal =
                payload + LexicalOffset;

            return EncodeNameInteger(
                    lexicalOrdinal) +
                Suffix;
        }

        public static string GetName(
            GeneratedNumberNameAddress address)
        {
            if (address.FoldDepth.IsZero)
            {
                return GetName(address.Position);
            }

            string foldCode =
                EncodeNameInteger(
                    address.FoldDepth);

            string positionCode =
                EncodeCoordinate(
                    CreatePositionCoordinate(
                        address.Position),
                    0);

            return
                foldCode +
                FoldSeparator +
                positionCode +
                Suffix;
        }

        public static GeneratedNumberNameAddress ParseAddress(
            string name)
        {
            GeneratedNumberNameAddress address;

            if (!TryParseAddress(
                name,
                out address))
            {
                throw new FormatException(
                    "'" + name +
                    "' is not a generated number name.");
            }

            return address;
        }

        public static bool TryParseAddress(
            string name,
            out GeneratedNumberNameAddress address)
        {
            address =
                default(GeneratedNumberNameAddress);

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

            string body =
                candidate.Substring(
                    0,
                    candidate.Length - Suffix.Length);

            int separator =
                body.IndexOf(
                    FoldSeparator,
                    StringComparison.Ordinal);

            if (separator < 0)
            {
                GeneratedNumberScalePosition position;

                if (!TryParse(
                    candidate,
                    out position))
                {
                    return false;
                }

                address =
                    new GeneratedNumberNameAddress(
                        position,
                        BigInteger.Zero);

                return true;
            }

            if (body.IndexOf(
                    FoldSeparator,
                    separator + FoldSeparator.Length,
                    StringComparison.Ordinal) >= 0)
            {
                return false;
            }

            string foldText =
                body.Substring(
                    0,
                    separator);

            string coordinateText =
                body.Substring(
                    separator + FoldSeparator.Length);

            BigInteger foldDepth;

            if (!TryDecodeNameInteger(
                foldText,
                out foldDepth) ||
                foldDepth <= 0)
            {
                return false;
            }

            int index = 0;
            CoordinateNode node;

            if (!TryDecodeCoordinate(
                    coordinateText,
                    ref index,
                    0,
                    out node) ||
                index != coordinateText.Length)
            {
                return false;
            }

            GeneratedNumberScalePosition decodedPosition;

            if (!TryReadPositionCoordinate(
                node,
                out decodedPosition))
            {
                return false;
            }

            var decoded =
                new GeneratedNumberNameAddress(
                    decodedPosition,
                    foldDepth);

            if (!string.Equals(
                GetName(decoded),
                candidate,
                StringComparison.Ordinal))
            {
                return false;
            }

            address = decoded;
            return true;
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

            if (payload < 0)
            {
                return false;
            }

            GeneratedNumberScaleDirection direction =
                payload % 2 == 0
                    ? GeneratedNumberScaleDirection.Large
                    : GeneratedNumberScaleDirection.Tiny;

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
                        direction,
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

        private sealed class CoordinateNode
        {
            public bool IsInteger;
            public BigInteger Integer;
            public CoordinateNode Left;
            public CoordinateNode Right;
        }

        private static CoordinateNode CreatePositionCoordinate(
            GeneratedNumberScalePosition position)
        {
            return PairNode(
                IntegerNode(
                    position.Direction == GeneratedNumberScaleDirection.Tiny
                        ? new BigInteger(2)
                        : BigInteger.One),
                PairNode(
                    IntegerNode(position.Layer),
                    PairNode(
                        IntegerNode(position.Magnitude),
                        IntegerNode(position.Coefficient - 1))));
        }

        private static CoordinateNode IntegerNode(
            BigInteger value)
        {
            return new CoordinateNode
            {
                IsInteger = true,
                Integer = value
            };
        }

        private static CoordinateNode PairNode(
            CoordinateNode left,
            CoordinateNode right)
        {
            return new CoordinateNode
            {
                Left = left,
                Right = right
            };
        }

        private static string EncodeCoordinate(
            CoordinateNode node,
            int depth)
        {
            if (node.IsInteger)
            {
                return
                    "re" +
                    EncodeNameInteger(node.Integer) +
                    "ri";
            }

            string marker =
                depth % 2 == 0
                    ? "ro"
                    : "ru";

            return
                marker +
                EncodeCoordinate(
                    node.Left,
                    depth + 1) +
                EncodeCoordinate(
                    node.Right,
                    depth + 1);
        }

        private static bool TryDecodeCoordinate(
            string text,
            ref int index,
            int depth,
            out CoordinateNode node)
        {
            node = null;

            if (index + 2 > text.Length)
            {
                return false;
            }

            string marker =
                text.Substring(
                    index,
                    2);

            if (marker == "re")
            {
                int end =
                    text.IndexOf(
                        "ri",
                        index + 2,
                        StringComparison.Ordinal);

                if (end < 0)
                {
                    return false;
                }

                string encodedInteger =
                    text.Substring(
                        index + 2,
                        end - index - 2);

                BigInteger integer;

                if (!TryDecodeNameInteger(
                    encodedInteger,
                    out integer))
                {
                    return false;
                }

                index = end + 2;
                node = IntegerNode(integer);
                return true;
            }

            string expected =
                depth % 2 == 0
                    ? "ro"
                    : "ru";

            if (marker != expected)
            {
                return false;
            }

            index += 2;

            CoordinateNode left;
            CoordinateNode right;

            if (!TryDecodeCoordinate(
                    text,
                    ref index,
                    depth + 1,
                    out left) ||
                !TryDecodeCoordinate(
                    text,
                    ref index,
                    depth + 1,
                    out right))
            {
                return false;
            }

            node = PairNode(left, right);
            return true;
        }

        private static bool TryReadPositionCoordinate(
            CoordinateNode node,
            out GeneratedNumberScalePosition position)
        {
            position =
                default(GeneratedNumberScalePosition);

            if (node == null ||
                node.IsInteger ||
                node.Left == null ||
                !node.Left.IsInteger ||
                (node.Left.Integer != BigInteger.One &&
                 node.Left.Integer != new BigInteger(2)))
            {
                return false;
            }

            GeneratedNumberScaleDirection direction =
                node.Left.Integer == new BigInteger(2)
                    ? GeneratedNumberScaleDirection.Tiny
                    : GeneratedNumberScaleDirection.Large;

            CoordinateNode layerPair = node.Right;

            if (layerPair == null ||
                layerPair.IsInteger ||
                layerPair.Left == null ||
                !layerPair.Left.IsInteger)
            {
                return false;
            }

            CoordinateNode magnitudePair =
                layerPair.Right;

            if (magnitudePair == null ||
                magnitudePair.IsInteger ||
                magnitudePair.Left == null ||
                !magnitudePair.Left.IsInteger ||
                magnitudePair.Right == null ||
                !magnitudePair.Right.IsInteger)
            {
                return false;
            }

            try
            {
                position =
                    new GeneratedNumberScalePosition(
                        direction,
                        layerPair.Left.Integer,
                        magnitudePair.Left.Integer,
                        magnitudePair.Right.Integer + 1);

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

            BigInteger current = value;
            BigInteger next =
                (current + 1) / 2;

            while (next < current)
            {
                current = next;
                next =
                    (current +
                    (value / current)) /
                    2;
            }

            return current;
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
