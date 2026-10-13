namespace UnitTools.Tests
{
    using System.Globalization;
    using NUnit.Framework;
    using UnitTools.Length;
    using UnitTools.Temperature;

    public sealed class UnitToolsParserTests
    {
        [Test]
        public void TryParse_LengthSymbol_ExtractsValueAndUnit()
        {
            double value;
            UnitToolsLengthUnit unit;

            bool success = UnitToolsParser.TryParse("1.8 km", out value, out unit);

            Assert.That(success, Is.True);
            Assert.That(value, Is.EqualTo(1.8d));
            Assert.That(unit, Is.EqualTo(UnitToolsLengthUnit.Kilometer));
        }

        [Test]
        public void TryParse_NoWhitespace_ExtractsValueAndUnit()
        {
            double value;
            UnitToolsLengthUnit unit;

            bool success = UnitToolsParser.TryParse("1.8km", out value, out unit);

            Assert.That(success, Is.True);
            Assert.That(value, Is.EqualTo(1.8d));
            Assert.That(unit, Is.EqualTo(UnitToolsLengthUnit.Kilometer));
        }

        [Test]
        public void TryParse_DisplayName_IsCaseInsensitive()
        {
            double value;
            UnitToolsLengthUnit unit;

            bool success = UnitToolsParser.TryParse("1.8 KILOMETER", out value, out unit);

            Assert.That(success, Is.True);
            Assert.That(unit, Is.EqualTo(UnitToolsLengthUnit.Kilometer));
        }

        [Test]
        public void TryParse_RegularPlural_IsAccepted()
        {
            double value;
            UnitToolsLengthUnit unit;

            bool success = UnitToolsParser.TryParse("1.8 kilometers", out value, out unit);

            Assert.That(success, Is.True);
            Assert.That(unit, Is.EqualTo(UnitToolsLengthUnit.Kilometer));
        }

        [Test]
        public void TryParse_SymbolCaseCollision_IsNotCollapsed()
        {
            double value;
            UnitToolsLengthUnit unit;

            Assert.That(
                UnitToolsParser.TryParse("1 mm", out value, out unit),
                Is.True);
            Assert.That(unit, Is.EqualTo(UnitToolsLengthUnit.Millimeter));

            Assert.That(
                UnitToolsParser.TryParse("1 Mm", out value, out unit),
                Is.True);
            Assert.That(unit, Is.EqualTo(UnitToolsLengthUnit.Megameter));

            Assert.That(
                UnitToolsParser.TryParse("1 MM", out value, out unit),
                Is.False);
        }

        [Test]
        public void Convert_UsesExistingLengthConverter()
        {
            double result = UnitToolsParser.Convert(
                "1.8 km",
                UnitToolsLengthUnit.Mile);

            double expected = UnitToolsLength.Convert(
                1.8d,
                UnitToolsLengthUnit.Kilometer,
                UnitToolsLengthUnit.Mile);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Convert_UsesExistingOffsetConversion()
        {
            double result = UnitToolsParser.Convert(
                "20 °C",
                UnitToolsTemperatureUnit.Fahrenheit);

            double expected = UnitToolsTemperature.Convert(
                20d,
                UnitToolsTemperatureUnit.Celsius,
                UnitToolsTemperatureUnit.Fahrenheit);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TryParse_ScientificNotation_IsAccepted()
        {
            double value;
            UnitToolsLengthUnit unit;

            bool success = UnitToolsParser.TryParse("1.2e3 m", out value, out unit);

            Assert.That(success, Is.True);
            Assert.That(value, Is.EqualTo(1200d));
            Assert.That(unit, Is.EqualTo(UnitToolsLengthUnit.Meter));
        }

        [Test]
        public void TryParse_CustomCulture_IsSupported()
        {
            double value;
            UnitToolsLengthUnit unit;

            bool success = UnitToolsParser.TryParse(
                "1,8 km",
                CultureInfo.GetCultureInfo("nl-NL"),
                out value,
                out unit);

            Assert.That(success, Is.True);
            Assert.That(value, Is.EqualTo(1.8d));
            Assert.That(unit, Is.EqualTo(UnitToolsLengthUnit.Kilometer));
        }

        [Test]
        public void TryParse_CustomCulture_WithThousandsSeparator_IsSupported()
        {
            double value;
            UnitToolsLengthUnit unit;

            bool success = UnitToolsParser.TryParse(
                "1.234,5 km",
                CultureInfo.GetCultureInfo("nl-NL"),
                out value,
                out unit);

            Assert.That(success, Is.True);
            Assert.That(value, Is.EqualTo(1234.5d));
            Assert.That(unit, Is.EqualTo(UnitToolsLengthUnit.Kilometer));
        }

        [Test]
        public void TryConvert_CustomCulture_UsesSameCultureRulesAsParse()
        {
            UnitToolsConversionResult result = UnitToolsParser.TryConvert(
                "1.234,5 km",
                UnitToolsLengthUnit.Meter,
                CultureInfo.GetCultureInfo("nl-NL"));

            Assert.That(result.Success, Is.True);
            Assert.That(result.Value, Is.EqualTo(1234500d));
        }

        [Test]
        public void ParsedValue_ToString_UsesCanonicalSymbolFormatting()
        {
            UnitToolsParsedValue<UnitToolsLengthUnit> parsed =
                UnitToolsParser.Parse<UnitToolsLengthUnit>("1.5 kilometer");

            Assert.That(parsed.ToString(), Is.EqualTo("1.5 km"));
            Assert.That(
                parsed.ToString("0.0", CultureInfo.GetCultureInfo("nl-NL")),
                Is.EqualTo("1,5 km"));
        }

        [Test]
        public void TryConvert_InvalidInput_ReturnsFailure()
        {
            UnitToolsConversionResult result = UnitToolsParser.TryConvert(
                "not a unit",
                UnitToolsLengthUnit.Meter);

            Assert.That(result.Success, Is.False);
        }
    }
}