using System;
using System.Globalization;
using NUnit.Framework;
using UnitTools.Quantities;

namespace UnitTools.Tests.Quantities
{
    [TestFixture]
    public sealed class QuantityFormattingConsistencyTests
    {
        [Test]
        public void EstablishedNamedQuantities_IncludeTheirInvariantBaseSymbol()
        {
            Assert.That(Length<decimal>.FromMetres(1m).ToString(), Is.EqualTo("1 m"));
            Assert.That(Time<decimal>.FromSeconds(1m).ToString(), Is.EqualTo("1 s"));
            Assert.That(Speed<decimal>.FromMetresPerSecond(1m).ToString(), Is.EqualTo("1 m/s"));
            Assert.That(Mass<decimal>.FromKilograms(1m).ToString(), Is.EqualTo("1 kg"));
            Assert.That(Acceleration<decimal>.FromMetresPerSecondSquared(1m).ToString(), Is.EqualTo("1 m/s²"));
            Assert.That(Force<decimal>.FromNewtons(1m).ToString(), Is.EqualTo("1 N"));
            Assert.That(Area<decimal>.FromSquareMetres(1m).ToString(), Is.EqualTo("1 m²"));
            Assert.That(Volume<decimal>.FromCubicMetres(1m).ToString(), Is.EqualTo("1 m³"));
            Assert.That(Density<decimal>.FromKilogramsPerCubicMetre(1m).ToString(), Is.EqualTo("1 kg/m³"));
            Assert.That(Frequency<decimal>.FromHertz(1m).ToString(), Is.EqualTo("1 Hz"));
            Assert.That(ElectricCurrent<decimal>.FromAmperes(1m).ToString(), Is.EqualTo("1 A"));
            Assert.That(Energy<decimal>.FromJoules(1m).ToString(), Is.EqualTo("1 J"));
            Assert.That(Power<decimal>.FromWatts(1m).ToString(), Is.EqualTo("1 W"));
            Assert.That(Pressure<decimal>.FromPascals(1m).ToString(), Is.EqualTo("1 Pa"));
        }

        [Test]
        public void EstablishedNamedQuantityFormatting_UsesCultureOnlyForNumericText()
        {
            string text = Length<decimal>.FromMetres(1234.5m).ToString(
                "N1",
                CultureInfo.GetCultureInfo("nl-NL"));

            Assert.That(text, Is.EqualTo("1.234,5 m"));
        }

        [Test]
        public void EstablishedNamedQuantitySpanFormatting_IncludesBaseSymbolWithoutAllocationContractChanges()
        {
            Span<char> buffer = stackalloc char[32];
            bool success = Force<decimal>.FromNewtons(12.5m).TryFormat(
                buffer,
                out int written,
                "0.0".AsSpan(),
                CultureInfo.InvariantCulture);

            Assert.That(success, Is.True);
            Assert.That(buffer.Slice(0, written).ToString(), Is.EqualTo("12.5 N"));
        }

        [Test]
        public void EstablishedNamedQuantity_DefaultText_RoundTripsThroughParser()
        {
            Length<decimal> original = Length<decimal>.FromMetres(12.5m);
            Length<decimal> restored =
                Length<decimal>.Parse(original.ToString(), CultureInfo.InvariantCulture);

            Assert.That(restored, Is.EqualTo(original));
        }
    }
}
