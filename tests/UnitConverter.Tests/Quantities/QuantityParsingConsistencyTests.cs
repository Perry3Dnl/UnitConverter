using System.Globalization;
using NUnit.Framework;
using UnitConverter.Quantities;

namespace UnitConverter.Tests.Quantities
{
    [TestFixture]
    public sealed class QuantityParsingConsistencyTests
    {
        [Test]
        public void NamedQuantityParser_AcceptsCompactNumberAndUnit()
        {
            Length<decimal> value =
                Length<decimal>.Parse("1.5km", CultureInfo.InvariantCulture);

            Assert.That(value.Kilometres, Is.EqualTo(1.5m));
        }

        [Test]
        public void NamedQuantityParser_AcceptsCultureSpecificGroupSeparators()
        {
            Length<decimal> value =
                Length<decimal>.Parse(
                    "1.234,5 km",
                    CultureInfo.GetCultureInfo("nl-NL"));

            Assert.That(value.Kilometres, Is.EqualTo(1234.5m));
        }

        [Test]
        public void NamedQuantityParser_UsesLocalizedAliases()
        {
            Length<decimal> value =
                Length<decimal>.Parse(
                    "1,5 mijl",
                    CultureInfo.GetCultureInfo("nl-NL"));

            Assert.That(value.Miles, Is.EqualTo(1.5m));
        }

        [Test]
        public void NamedQuantityParser_AcceptsLocalizedMultiwordUnits()
        {
            Speed<decimal> value =
                Speed<decimal>.Parse(
                    "36 kilometer per uur",
                    CultureInfo.GetCultureInfo("nl-NL"));

            Assert.That(value.KilometresPerHour, Is.EqualTo(36m));
        }

        [Test]
        public void LocalizedAliases_RemainCultureScoped()
        {
            Assert.That(
                Length<decimal>.TryParse(
                    "1.5 mijl",
                    CultureInfo.InvariantCulture,
                    out _),
                Is.False);
        }
    }
}
