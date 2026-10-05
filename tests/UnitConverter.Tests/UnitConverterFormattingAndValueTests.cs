namespace UnitConverter.Tests
{
    using System.Globalization;
    using NUnit.Framework;
    using UnitConverter.Length;
    using UnitConverter.Temperature;
    using UnitConverter.TemperatureDelta;

    public sealed class UnitConverterFormattingAndValueTests
    {
        [Test]
        public void Formatter_Default_UsesSymbol()
        {
            string result = UnitConverterFormatter.Format(
                1.8d,
                UnitConverterLengthUnit.Kilometer);

            Assert.That(result, Is.EqualTo("1.8 km"));
        }

        [Test]
        public void Formatter_Culture_FormatsNumericPart()
        {
            string result = UnitConverterFormatter.Format(
                1.8d,
                UnitConverterLengthUnit.Kilometer,
                "0.0",
                CultureInfo.GetCultureInfo("nl-NL"),
                UnitConverterUnitFormat.Symbol);

            Assert.That(result, Is.EqualTo("1,8 km"));
        }

        [Test]
        public void Formatter_CanUseDisplayName()
        {
            string result = UnitConverterFormatter.Format(
                1.8d,
                UnitConverterLengthUnit.Kilometer,
                UnitConverterUnitFormat.DisplayName);

            Assert.That(result, Is.EqualTo("1.8 kilometer"));
        }

        [Test]
        public void UnitValue_To_UsesExistingConverter()
        {
            var distance = new UnitValue<UnitConverterLengthUnit>(
                1.8d,
                UnitConverterLengthUnit.Kilometer);

            UnitValue<UnitConverterLengthUnit> miles =
                distance.To(UnitConverterLengthUnit.Mile);

            double expected = UnitConverterLength.Convert(
                1.8d,
                UnitConverterLengthUnit.Kilometer,
                UnitConverterLengthUnit.Mile);

            Assert.That(miles.Value, Is.EqualTo(expected));
            Assert.That(miles.Unit, Is.EqualTo(UnitConverterLengthUnit.Mile));
        }

        [Test]
        public void UnitValue_ToString_UsesFormatter()
        {
            var distance = new UnitValue<UnitConverterLengthUnit>(
                1.8d,
                UnitConverterLengthUnit.Kilometer);

            Assert.That(distance.ToString(), Is.EqualTo("1.8 km"));
        }

        [Test]
        public void UnitValue_DoesNotReplaceRawNumericConversion()
        {
            double raw = UnitConverterLength.Convert(
                1.8d,
                UnitConverterLengthUnit.Kilometer,
                UnitConverterLengthUnit.Meter);

            var typed = new UnitValue<UnitConverterLengthUnit>(
                1.8d,
                UnitConverterLengthUnit.Kilometer)
                .To(UnitConverterLengthUnit.Meter);

            Assert.That(typed.Value, Is.EqualTo(raw));
        }

        [Test]
        public void TemperatureDelta_CelsiusToFahrenheit_UsesScaleWithoutOffset()
        {
            double delta = UnitConverterTemperatureDelta.Convert(
                20d,
                UnitConverterTemperatureDeltaUnit.Celsius,
                UnitConverterTemperatureDeltaUnit.Fahrenheit);

            Assert.That(delta, Is.EqualTo(36d).Within(1e-12d));
        }

        [Test]
        public void TemperatureDelta_DiffersFromAbsoluteTemperature()
        {
            double absolute = UnitConverterTemperature.Convert(
                20d,
                UnitConverterTemperatureUnit.Celsius,
                UnitConverterTemperatureUnit.Fahrenheit);

            double delta = UnitConverterTemperatureDelta.Convert(
                20d,
                UnitConverterTemperatureDeltaUnit.Celsius,
                UnitConverterTemperatureDeltaUnit.Fahrenheit);

            Assert.That(absolute, Is.EqualTo(68d).Within(1e-12d));
            Assert.That(delta, Is.EqualTo(36d).Within(1e-12d));
        }

        [Test]
        public void TemperatureDelta_ParserAndFormatter_UseDeltaSymbols()
        {
            UnitValue<UnitConverterTemperatureDeltaUnit> value =
                new UnitValue<UnitConverterTemperatureDeltaUnit>(
                    20d,
                    UnitConverterTemperatureDeltaUnit.Celsius);

            Assert.That(value.ToString(), Is.EqualTo("20 Δ°C"));

            double parsed;
            UnitConverterTemperatureDeltaUnit unit;
            Assert.That(
                UnitConverterParser.TryParse("20 Δ°C", out parsed, out unit),
                Is.True);
            Assert.That(parsed, Is.EqualTo(20d));
            Assert.That(unit, Is.EqualTo(UnitConverterTemperatureDeltaUnit.Celsius));
        }

        [TestCase(UnitConverterTemperatureDeltaUnit.Kelvin)]
        [TestCase(UnitConverterTemperatureDeltaUnit.Celsius)]
        [TestCase(UnitConverterTemperatureDeltaUnit.Fahrenheit)]
        [TestCase(UnitConverterTemperatureDeltaUnit.Rankine)]
        [TestCase(UnitConverterTemperatureDeltaUnit.Delisle)]
        [TestCase(UnitConverterTemperatureDeltaUnit.Newton)]
        [TestCase(UnitConverterTemperatureDeltaUnit.Reaumur)]
        [TestCase(UnitConverterTemperatureDeltaUnit.Romer)]
        public void TemperatureDelta_RoundTrip_ReturnsOriginal(
            UnitConverterTemperatureDeltaUnit unit)
        {
            const double input = 12.345d;

            double kelvin = UnitConverterTemperatureDelta.ToKelvin(input, unit);
            double result = UnitConverterTemperatureDelta.FromKelvin(kelvin, unit);

            Assert.That(result, Is.EqualTo(input).Within(1e-10d));
        }
    }
}
