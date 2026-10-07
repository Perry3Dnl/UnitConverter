using System;
using System.Globalization;
using NUnit.Framework;
using UnitConverter.Quantities;

namespace UnitConverter.Tests.Quantities
{
    [TestFixture]
    public sealed class ExtendedQuantityTextTests
    {
        [Test]
        public void MechanicalQuantitiesParseFromSpan()
        {
            Assert.That(Force<decimal>.Parse("2.5 kN".AsSpan(), CultureInfo.InvariantCulture).Newtons, Is.EqualTo(2500m));
            Assert.That(Energy<decimal>.Parse("18 kJ".AsSpan(), CultureInfo.InvariantCulture).Joules, Is.EqualTo(18000m));
            Assert.That(Power<decimal>.Parse("1.5 kW".AsSpan(), CultureInfo.InvariantCulture).Watts, Is.EqualTo(1500m));
            Assert.That(Pressure<decimal>.Parse("2 bar".AsSpan(), CultureInfo.InvariantCulture).Pascals, Is.EqualTo(200000m));
        }

        [Test]
        public void AdditionalQuantitiesParseFromSpan()
        {
            Assert.That(Density<decimal>.Parse("1 g/cm3".AsSpan(), CultureInfo.InvariantCulture).KilogramsPerCubicMetre, Is.EqualTo(1000m));
            Assert.That(Frequency<decimal>.Parse("50 Hz".AsSpan(), CultureInfo.InvariantCulture).Hertz, Is.EqualTo(50m));
            Assert.That(ElectricCurrent<decimal>.Parse("250 mA".AsSpan(), CultureInfo.InvariantCulture).Amperes, Is.EqualTo(0.25m));
            Assert.That(Voltage<decimal>.Parse("12 V".AsSpan(), CultureInfo.InvariantCulture).Volts, Is.EqualTo(12m));
            Assert.That(Resistance<decimal>.Parse("4 ohm".AsSpan(), CultureInfo.InvariantCulture).Ohms, Is.EqualTo(4m));
        }

        [Test]
        public void LengthFormatsValueAndUnitWithoutCreatingIntermediateString()
        {
            Length<decimal> length = Length<decimal>.FromMetres(1250m);
            Span<char> buffer = stackalloc char[32];

            bool success = length.TryFormat(
                buffer,
                out int written,
                "0.0".AsSpan(),
                CultureInfo.InvariantCulture,
                "km".AsSpan());

            Assert.That(success, Is.True);
            Assert.That(new string(buffer.Slice(0, written)), Is.EqualTo("1.3 km"));
        }

        [Test]
        public void ExtendedQuantityFormattingWritesRequestedUnit()
        {
            Pressure<decimal> pressure = Pressure<decimal>.FromPascals(2500m);
            Span<char> buffer = stackalloc char[32];

            bool success = pressure.TryFormatWithUnit(
                buffer,
                out int written,
                "0.0".AsSpan(),
                CultureInfo.InvariantCulture,
                "kPa".AsSpan());

            Assert.That(success, Is.True);
            Assert.That(new string(buffer.Slice(0, written)), Is.EqualTo("2.5 kPa"));
        }

        [Test]
        public void FormattingFailsCleanlyWhenBufferIsTooSmall()
        {
            Power<decimal> power = Power<decimal>.FromKilowatts(12.5m);
            Span<char> buffer = stackalloc char[3];

            bool success = power.TryFormatWithUnit(
                buffer,
                out int written,
                "0.0".AsSpan(),
                CultureInfo.InvariantCulture,
                "kW".AsSpan());

            Assert.That(success, Is.False);
            Assert.That(written, Is.EqualTo(0));
        }

        [Test]
        public void NewlyTypedFrequencyUnitCanBeFormatted()
        {
            Frequency<decimal> frequency =
                Frequency<decimal>.FromRevolutionsPerMinute(120m);
            Span<char> buffer = stackalloc char[32];

            bool success = frequency.TryFormatWithUnit(
                buffer,
                out int written,
                "0".AsSpan(),
                CultureInfo.InvariantCulture,
                "rpm".AsSpan());

            Assert.That(success, Is.True);
            Assert.That(new string(buffer.Slice(0, written)), Is.EqualTo("120 rpm"));
        }

        [Test]
        public void UnknownFormattingUnitIsRejected()
        {
            Frequency<decimal> frequency = Frequency<decimal>.FromHertz(50m);
            Span<char> buffer = stackalloc char[32];

            bool success = frequency.TryFormatWithUnit(
                buffer,
                out int written,
                "0".AsSpan(),
                CultureInfo.InvariantCulture,
                "not-a-frequency-unit".AsSpan());

            Assert.That(success, Is.False);
            Assert.That(written, Is.EqualTo(0));
        }
    }
}
