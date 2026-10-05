namespace UnitConverter.Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public sealed class NumberScaleDescriptor
    {
        internal NumberScaleDescriptor(
            string name,
            BigInteger exponent,
            bool generated)
        {
            Name = name;
            Exponent = exponent;
            IsGenerated = generated;
        }

        public string Name { get; }
        public BigInteger Exponent { get; }
        public bool IsGenerated { get; }

        public override string ToString()
        {
            return Name;
        }
    }

    public static class NumberScaleCatalog
    {
        private static readonly Dictionary<string, NumberScaleDescriptor> Scales =
            CreateScales();

        public static NumberScaleDescriptor Get(string name)
        {
            NumberScaleDescriptor descriptor;

            if (!TryGet(name, out descriptor))
            {
                throw new FormatException(
                    "Unknown number scale '" + name + "'.");
            }

            return descriptor;
        }

        public static bool TryGet(
            string name,
            out NumberScaleDescriptor descriptor)
        {
            descriptor = null;

            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            string candidate = name.Trim();

            if (Scales.TryGetValue(
                candidate,
                out descriptor))
            {
                return true;
            }

            GeneratedNumberScalePosition position;

            if (!GeneratedNumberNames.TryParse(
                candidate,
                out position))
            {
                return false;
            }

            if (position.Layer != 2 ||
                position.Coefficient != BigInteger.One)
            {
                return false;
            }

            BigInteger exponent;

            if (!TryMaterializeLayerTwoExponent(
                position.Magnitude,
                out exponent))
            {
                return false;
            }

            descriptor =
                new NumberScaleDescriptor(
                    candidate.ToLowerInvariant(),
                    exponent,
                    true);

            return true;
        }

        public static IReadOnlyList<NumberScaleDescriptor> All
        {
            get
            {
                return Scales.Values
                    .OrderBy(scale => scale.Exponent)
                    .ToArray();
            }
        }

        private static Dictionary<string, NumberScaleDescriptor> CreateScales()
        {
            var result =
                new Dictionary<string, NumberScaleDescriptor>(
                    StringComparer.OrdinalIgnoreCase);

            Add(result, "one", 0);
            Add(result, "ten", 1);
            Add(result, "hundred", 2);
            Add(result, "thousand", 3);
            Add(result, "million", 6);
            Add(result, "billion", 9);
            Add(result, "trillion", 12);
            Add(result, "quadrillion", 15);
            Add(result, "quintillion", 18);
            Add(result, "sextillion", 21);
            Add(result, "septillion", 24);
            Add(result, "octillion", 27);
            Add(result, "nonillion", 30);
            Add(result, "decillion", 33);
            Add(result, "googol", 100);

            string ginozillion =
                GeneratedNumberNames.GetName(
                    new GeneratedNumberScalePosition(
                        new BigInteger(2),
                        new BigInteger(4),
                        BigInteger.One));

            Add(
                result,
                ginozillion,
                new BigInteger(10000),
                true);

            return result;
        }

        private static void Add(
            Dictionary<string, NumberScaleDescriptor> result,
            string name,
            int exponent)
        {
            Add(
                result,
                name,
                new BigInteger(exponent),
                false);
        }

        private static void Add(
            Dictionary<string, NumberScaleDescriptor> result,
            string name,
            BigInteger exponent,
            bool generated)
        {
            result.Add(
                name,
                new NumberScaleDescriptor(
                    name,
                    exponent,
                    generated));
        }

        private static bool TryMaterializeLayerTwoExponent(
            BigInteger magnitude,
            out BigInteger exponent)
        {
            exponent = BigInteger.Zero;

            if (magnitude < 0 ||
                magnitude > 100000 ||
                magnitude > int.MaxValue)
            {
                return false;
            }

            exponent =
                BigInteger.Pow(
                    new BigInteger(10),
                    (int)magnitude);

            return true;
        }
    }

    public static class NumberScaleConverter
    {
        public static ArbitraryScaleNumber Convert(
            ArbitraryScaleNumber value,
            string fromScale,
            string toScale)
        {
            NumberScaleDescriptor from =
                NumberScaleCatalog.Get(fromScale);

            NumberScaleDescriptor to =
                NumberScaleCatalog.Get(toScale);

            return value.Shift(
                from.Exponent - to.Exponent);
        }

        public static ArbitraryScaleNumber Convert(
            string input,
            string toScale)
        {
            ArbitraryScaleNumber number =
                ArbitraryScaleNumber.Parse(input);

            return number.In(toScale);
        }

        public static IReadOnlyList<NumberScaleConversion> GetTable(
            ArbitraryScaleNumber number)
        {
            return NumberScaleCatalog.All
                .Select(
                    scale =>
                        new NumberScaleConversion(
                            scale,
                            number.Shift(-scale.Exponent)))
                .ToArray();
        }
    }

    public sealed class NumberScaleConversion
    {
        internal NumberScaleConversion(
            NumberScaleDescriptor scale,
            ArbitraryScaleNumber value)
        {
            Scale = scale;
            Value = value;
        }

        public NumberScaleDescriptor Scale { get; }
        public ArbitraryScaleNumber Value { get; }
    }
}
