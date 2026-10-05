namespace UnitConverter.Tests
{
    using System;
    using System.Linq;
    using System.Numerics;
    using NUnit.Framework;
    using UnitConverter.Numbers;

    public sealed class UnitConverterNumberTests
    {
        [TestCase("500 million", "5e8")]
        [TestCase("500000000", "5e8")]
        [TestCase("5e8", "5e8")]
        public void EquivalentInputs_AreIdentical(
            string input,
            string expected)
        {
            Assert.That(
                ArbitraryScaleNumber
                    .Parse(input)
                    .ToScientific(),
                Is.EqualTo(expected));
        }

        [Test]
        public void NamedScaleInput_EnforcesCanonicalCoefficient()
        {
            ArbitraryScaleNumber ignored;

            Assert.That(
                ArbitraryScaleNumber.TryParse(
                    "0.5 billion",
                    out ignored),
                Is.False);

            Assert.That(
                ArbitraryScaleNumber.TryParse(
                    "1000 million",
                    out ignored),
                Is.False);

            Assert.That(
                ArbitraryScaleNumber.TryParse(
                    "500 million",
                    out ignored),
                Is.True);
        }

        [Test]
        public void ScaleConversion_CanProduceNonCanonicalCoefficient()
        {
            ArbitraryScaleNumber result =
                NumberScaleConverter.Convert(
                    "500 million",
                    "billion");

            Assert.That(
                result.ToScientific(),
                Is.EqualTo("5e-1"));
        }

        [Test]
        public void Exponent_IsArbitraryPrecision()
        {
            ArbitraryScaleNumber number =
                ArbitraryScaleNumber.Parse(
                    "1e100000000000000000000");

            Assert.That(
                number.ToScientific(),
                Is.EqualTo(
                    "1e100000000000000000000"));
        }

        [Test]
        public void AdditionAcrossHugeExponentGap_StaysSparse()
        {
            ArbitraryScaleNumber huge =
                ArbitraryScaleNumber.Parse(
                    "1e100000000000000000000");

            ArbitraryScaleNumber result =
                huge +
                ArbitraryScaleNumber.One;

            Assert.That(
                result.Terms.Count,
                Is.EqualTo(2));

            Assert.That(
                result.ToScientific(),
                Is.EqualTo(
                    "1e100000000000000000000 + 1"));
        }

        [Test]
        public void Powers_DoNotMaterializeHugeExponent()
        {
            ArbitraryScaleNumber value =
                ArbitraryScaleNumber.Parse(
                    "2e100000000000000000000");

            ArbitraryScaleNumber result =
                ArbitraryScaleNumber.Pow(
                    value,
                    3);

            Assert.That(
                result.ToScientific(),
                Is.EqualTo(
                    "8e300000000000000000000"));
        }

        [Test]
        public void Arithmetic_HandlesHugeExponents()
        {
            ArbitraryScaleNumber left =
                ArbitraryScaleNumber.Parse(
                    "3e999999999999999999999999");

            ArbitraryScaleNumber right =
                ArbitraryScaleNumber.Parse(
                    "2e999999999999999999999999");

            Assert.That(
                (left + right).ToScientific(),
                Is.EqualTo(
                    "5e999999999999999999999999"));

            Assert.That(
                (left * right).ToScientific(),
                Is.EqualTo(
                    "6e1999999999999999999999998"));
        }

        [Test]
        public void SmallSparseValues_CanMaterializeExactly()
        {
            ArbitraryScaleNumber value =
                ArbitraryScaleNumber.Parse("1e6") +
                ArbitraryScaleNumber.Parse("2e3") +
                ArbitraryScaleNumber.Parse("3");

            Assert.That(
                value.ToDecimalString(),
                Is.EqualTo("1002003"));
        }

        [Test]
        public void HugeSparseValues_RefuseDecimalMaterialization()
        {
            ArbitraryScaleNumber value =
                ArbitraryScaleNumber.Parse(
                    "1e100000000000000000000") +
                ArbitraryScaleNumber.One;

            Assert.Throws<InvalidOperationException>(
                () => value.ToDecimalString());
        }

        [Test]
        public void ThousandsOfIntegerRoundTrips_AreExact()
        {
            for (int value = -10000;
                value <= 10000;
                value += 7)
            {
                var original =
                    new ArbitraryScaleNumber(
                        value,
                        BigInteger.Zero);

                Assert.That(
                    ArbitraryScaleNumber.Parse(
                        original.ToDecimalString()),
                    Is.EqualTo(original));

                Assert.That(
                    ArbitraryScaleNumber.Parse(
                        original.ToScientific()),
                    Is.EqualTo(original));
            }
        }

        [Test]
        public void ConversionTable_IsConsistent()
        {
            ArbitraryScaleNumber number =
                ArbitraryScaleNumber.Parse(
                    "123.456 trillion");

            foreach (NumberScaleConversion conversion in
                NumberScaleConverter.GetTable(number))
            {
                ArbitraryScaleNumber reconstructed =
                    conversion.Value.Shift(
                        conversion.Scale.Exponent);

                Assert.That(
                    reconstructed,
                    Is.EqualTo(number),
                    conversion.Scale.Name);
            }
        }

        [Test]
        public void Ginozillion_IsGeneratedNameForOriginalCoordinate()
        {
            var position =
                new GeneratedNumberScalePosition(
                    new BigInteger(2),
                    new BigInteger(4),
                    BigInteger.One);

            Assert.That(
                GeneratedNumberNames.GetName(position),
                Is.EqualTo("ginozillion"));

            Assert.That(
                GeneratedNumberNames.Parse(
                    "ginozillion"),
                Is.EqualTo(position));
        }

        [TestCase(2, 4, 1)]
        [TestCase(2, 10, 1)]
        [TestCase(3, 27, 7)]
        [TestCase(100, 1000, 999)]
        public void GeneratedNames_AreReversible(
            int layer,
            int magnitude,
            int coefficient)
        {
            var position =
                new GeneratedNumberScalePosition(
                    new BigInteger(layer),
                    new BigInteger(magnitude),
                    new BigInteger(coefficient));

            string name =
                GeneratedNumberNames.GetName(
                    position);

            GeneratedNumberScalePosition restored =
                GeneratedNumberNames.Parse(
                    name);

            Assert.That(
                restored,
                Is.EqualTo(position));
        }

        [Test]
        public void Ginozillion_CanBeUsedAsNumericScale()
        {
            NumberScaleDescriptor scale =
                NumberScaleCatalog.Get(
                    "ginozillion");

            Assert.That(
                scale.Exponent,
                Is.EqualTo(
                    new BigInteger(10000)));

            ArbitraryScaleNumber number =
                ArbitraryScaleNumber.Parse(
                    "1 ginozillion");

            Assert.That(
                number.ToScientific(),
                Is.EqualTo("1e10000"));
        }

        [Test]
        public void Math_CanPreserveResultBeyondDoubleRange()
        {
            ArbitraryScaleNumber ten =
                ArbitraryScaleNumber.Parse("10");

            Assert.Throws<ArbitraryScaleOverflowException>(
                () =>
                {
                    double ignored;
                    ArbitraryScaleMath.Pow(
                        ten,
                        10000,
                        out ignored);
                });

            ArbitraryScaleNumber result;
            ArbitraryScaleMath.Pow(
                ten,
                10000,
                out result);

            Assert.That(
                result.ToScientific(),
                Is.EqualTo("1e10000"));
        }

        [Test]
        public void Math_TryPowReportsClrOverflow()
        {
            double result;

            Assert.That(
                ArbitraryScaleMath.TryPow(
                    ArbitraryScaleNumber.Parse("10"),
                    10000,
                    out result),
                Is.False);

            Assert.That(
                ArbitraryScaleMath.TryPow(
                    ArbitraryScaleNumber.Parse("10"),
                    10,
                    out result),
                Is.True);

            Assert.That(
                result,
                Is.EqualTo(10000000000d));
        }
    }
}
