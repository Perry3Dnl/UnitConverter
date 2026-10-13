namespace UnitTools.Tests
{
    using System.Globalization;
    using NUnit.Framework;
    using UnitTools.Length;
    using UnitTools.Temperature;
    using UnitTools.TemperatureDelta;

    public sealed class UnitToolsFormattingAndValueTests
    {
        [Test]
        public void Formatter_Default_UsesSymbol()
        {
            string result = UnitToolsFormatter.Format(
                1.8d,
                UnitToolsLengthUnit.Kilometer);

            Assert.That(result, Is.EqualTo("1.8 km"));
        }

        [Test]
        public void Formatter_Culture_FormatsNumericPart()
        {
            string result = UnitToolsFormatter.Format(
                1.8d,
                UnitToolsLengthUnit.Kilometer,
                "0.0",
                CultureInfo.GetCultureInfo("nl-NL"),
                UnitToolsUnitFormat.Symbol);

            Assert.That(result, Is.EqualTo("1,8 km"));
        }

        [Test]
        public void Formatter_CanUseDisplayName()
        {
            string result = UnitToolsFormatter.Format(
                1.8d,
                UnitToolsLengthUnit.Kilometer,
                UnitToolsUnitFormat.DisplayName);

            Assert.That(result, Is.EqualTo("1.8 kilometer"));
        }

        [Test]
        public void UnitValue_To_UsesExistingConverter()
        {
            var distance = new UnitValue<UnitToolsLengthUnit>(
                1.8d,
                UnitToolsLengthUnit.Kilometer);

            UnitValue<UnitToolsLengthUnit> miles =
                distance.To(UnitToolsLengthUnit.Mile);

            double expected = UnitToolsLength.Convert(
                1.8d,
                UnitToolsLengthUnit.Kilometer,
                UnitToolsLengthUnit.Mile);

            Assert.That(miles.Value, Is.EqualTo(expected));
            Assert.That(miles.Unit, Is.EqualTo(UnitToolsLengthUnit.Mile));
        }

        [Test]
        public void UnitValue_ToString_UsesFormatter()
        {
            var distance = new UnitValue<UnitToolsLengthUnit>(
                1.8d,
                UnitToolsLengthUnit.Kilometer);

            Assert.That(distance.ToString(), Is.EqualTo("1.8 km"));
        }

        [Test]
        public void UnitValue_DoesNotReplaceRawNumericConversion()
        {
            double raw = UnitToolsLength.Convert(
                1.8d,
                UnitToolsLengthUnit.Kilometer,
                UnitToolsLengthUnit.Meter);

            var typed = new UnitValue<UnitToolsLengthUnit>(
                1.8d,
                UnitToolsLengthUnit.Kilometer)
                .To(UnitToolsLengthUnit.Meter);

            Assert.That(typed.Value, Is.EqualTo(raw));
        }

        [Test]
        public void TemperatureDelta_CelsiusToFahrenheit_UsesScaleWithoutOffset()
        {
            double delta = UnitToolsTemperatureDelta.Convert(
                20d,
                UnitToolsTemperatureDeltaUnit.Celsius,
                UnitToolsTemperatureDeltaUnit.Fahrenheit);

            Assert.That(delta, Is.EqualTo(36d).Within(1e-12d));
        }

        [Test]
        public void TemperatureDelta_DiffersFromAbsoluteTemperature()
        {
            double absolute = UnitToolsTemperature.Convert(
                20d,
                UnitToolsTemperatureUnit.Celsius,
                UnitToolsTemperatureUnit.Fahrenheit);

            double delta = UnitToolsTemperatureDelta.Convert(
                20d,
                UnitToolsTemperatureDeltaUnit.Celsius,
                UnitToolsTemperatureDeltaUnit.Fahrenheit);

            Assert.That(absolute, Is.EqualTo(68d).Within(1e-12d));
            Assert.That(delta, Is.EqualTo(36d).Within(1e-12d));
        }

        [Test]
        public void TemperatureDelta_ParserAndFormatter_UseDeltaSymbols()
        {
            UnitValue<UnitToolsTemperatureDeltaUnit> value =
                new UnitValue<UnitToolsTemperatureDeltaUnit>(
                    20d,
                    UnitToolsTemperatureDeltaUnit.Celsius);

            Assert.That(value.ToString(), Is.EqualTo("20 Δ°C"));

            double parsed;
            UnitToolsTemperatureDeltaUnit unit;
            Assert.That(
                UnitToolsParser.TryParse("20 Δ°C", out parsed, out unit),
                Is.True);
            Assert.That(parsed, Is.EqualTo(20d));
            Assert.That(unit, Is.EqualTo(UnitToolsTemperatureDeltaUnit.Celsius));
        }

        [TestCase(UnitToolsTemperatureDeltaUnit.Kelvin)]
        [TestCase(UnitToolsTemperatureDeltaUnit.Celsius)]
        [TestCase(UnitToolsTemperatureDeltaUnit.Fahrenheit)]
        [TestCase(UnitToolsTemperatureDeltaUnit.Rankine)]
        [TestCase(UnitToolsTemperatureDeltaUnit.Delisle)]
        [TestCase(UnitToolsTemperatureDeltaUnit.Newton)]
        [TestCase(UnitToolsTemperatureDeltaUnit.Reaumur)]
        [TestCase(UnitToolsTemperatureDeltaUnit.Romer)]
        public void TemperatureDelta_RoundTrip_ReturnsOriginal(
            UnitToolsTemperatureDeltaUnit unit)
        {
            const double input = 12.345d;

            double kelvin = UnitToolsTemperatureDelta.ToKelvin(input, unit);
            double result = UnitToolsTemperatureDelta.FromKelvin(kelvin, unit);

            Assert.That(result, Is.EqualTo(input).Within(1e-10d));
        }
    }
}
