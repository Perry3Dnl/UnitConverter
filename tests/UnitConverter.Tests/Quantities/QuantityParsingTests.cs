using System;
using System.Globalization;
using NUnit.Framework;
using UnitConverter.Quantities;

namespace UnitConverter.Tests.Quantities
{
    [TestFixture]
    public sealed class QuantityParsingTests
    {
        [Test]
        public void LengthParsesFromString()
        {
            Length<decimal> length = Length<decimal>.Parse("12.5 km", CultureInfo.InvariantCulture);

            Assert.That(length.Metres, Is.EqualTo(12500m));
        }

        [Test]
        public void LengthParsesFromSpanWithoutIntermediateString()
        {
            ReadOnlySpan<char> text = "254 cm".AsSpan();

            bool success = Length<decimal>.TryParse(text, CultureInfo.InvariantCulture, out Length<decimal> length);

            Assert.That(success, Is.True);
            Assert.That(length.Metres, Is.EqualTo(2.54m));
        }

        [Test]
        public void TimeParsesSupportedUnits()
        {
            Time<decimal> time = Time<decimal>.Parse("2.5 h", CultureInfo.InvariantCulture);

            Assert.That(time.Minutes, Is.EqualTo(150m));
        }

        [Test]
        public void SpeedParsesSupportedUnits()
        {
            Speed<decimal> speed = Speed<decimal>.Parse("90 km/h", CultureInfo.InvariantCulture);

            Assert.That(speed.MetresPerSecond, Is.EqualTo(25m));
        }

        [Test]
        public void ParsingRespectsFormatProvider()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("nl-NL");

            bool success = Length<decimal>.TryParse("12,5 m", culture, out Length<decimal> length);

            Assert.That(success, Is.True);
            Assert.That(length.Metres, Is.EqualTo(12.5m));
        }

        [Test]
        public void TryParseRejectsUnknownUnit()
        {
            bool success = Length<decimal>.TryParse("12.5 parsecs", CultureInfo.InvariantCulture, out _);

            Assert.That(success, Is.False);
        }
    }
}
