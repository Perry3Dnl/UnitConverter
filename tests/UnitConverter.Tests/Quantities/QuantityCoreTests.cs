using System;
using NUnit.Framework;
using UnitConverter.Quantities;

namespace UnitConverter.Tests.Quantities
{
    [TestFixture]
    public sealed class QuantityCoreTests
    {
        [Test]
        public void DecimalLengthConversionUsesExactDecimalArithmetic()
        {
            Length<decimal> inch = Length.FromInches(1m);

            Assert.That(inch.Metres, Is.EqualTo(0.0254m));
            Assert.That(inch.Centimetres, Is.EqualTo(2.54m));
            Assert.That(inch.Inches, Is.EqualTo(1m));
        }

        [Test]
        public void LengthAdditionPreservesDimensionAndNumericType()
        {
            Length<decimal> left = Length.FromMetres(10.25m);
            Length<decimal> right = Length.FromCentimetres(75m);

            Length<decimal> result = left + right;

            Assert.That(result.Metres, Is.EqualTo(11.00m));
        }

        [Test]
        public void LengthDividedByTimeProducesSpeed()
        {
            Length<decimal> distance = Length.FromKilometres(100m);
            Time<decimal> duration = Time.FromHours(2m);

            Speed<decimal> speed = distance / duration;

            Assert.That(speed.KilometresPerHour, Is.EqualTo(50m));
        }

        [Test]
        public void SpeedMultipliedByTimeProducesLength()
        {
            Speed<decimal> speed = Speed.FromKilometresPerHour(90m);
            Time<decimal> duration = Time.FromHours(2m);

            Length<decimal> distance = speed * duration;

            Assert.That(distance.Kilometres, Is.EqualTo(180m));
        }

        [Test]
        public void ImperialConversionRoundTripsExactlyWithDecimal()
        {
            Length<decimal> mile = Length.FromMiles(1m);

            Assert.That(mile.Metres, Is.EqualTo(1609.344m));
            Assert.That(mile.Miles, Is.EqualTo(1m));
        }

        [Test]
        public void QuantitySupportsSpanFormatting()
        {
            Length<decimal> length = Length.FromMetres(12.5m);
            Span<char> buffer = stackalloc char[32];

            bool success = length.TryFormat(buffer, out int written, "0.0".AsSpan(), null);

            Assert.That(success, Is.True);
            Assert.That(new string(buffer.Slice(0, written)), Is.EqualTo("12.5"));
        }

        [Test]
        public void DifferentDimensionsAreDifferentCompileTimeTypes()
        {
            Assert.That(typeof(Length<decimal>), Is.Not.EqualTo(typeof(Time<decimal>)));
            Assert.That(typeof(Length<decimal>), Is.Not.EqualTo(typeof(Speed<decimal>)));
        }
    }
}
