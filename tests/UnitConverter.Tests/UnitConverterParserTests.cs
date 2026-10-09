namespace UnitConverter.Tests
{
    using System.Globalization;
    using NUnit.Framework;
    using UnitConverter.Length;
    using UnitConverter.Temperature;

    public sealed class UnitConverterParserTests
    {
        [Test]
        public void TryParse_LengthSymbol_ExtractsValueAndUnit()
        {
            double value;
            UnitConverterLengthUnit unit;

            bool success = UnitConverterParser.TryParse("1.8 km", out value, out unit);

            Assert.That(success, Is.True);
            Assert.That(value, Is.EqualTo(1.8d));
            Assert.That(unit, Is.EqualTo(UnitConverterLengthUnit.Kilometer));
        }

        [Test]
        public void TryParse_NoWhitespace_ExtractsValueAndUnit()
        {
            double value;
            UnitConverterLengthUnit unit;

            bool success = UnitConverterParser.TryParse("1.8km", out value, out unit);

            Assert.That(success, Is.True);
            Assert.That(value, Is.EqualTo(1.8d));
            Assert.That(unit, Is.EqualTo(UnitConverterLengthUnit.Kilometer));
        }

        [Test]
        public void TryParse_DisplayName_IsCaseInsensitive()
        {
            double value;
            UnitConverterLengthUnit unit;

            bool success = UnitConverterParser.TryParse("1.8 KILOMETER", out value, out unit);

            Assert.That(success, Is.True);
            Assert.That(unit, Is.EqualTo(UnitConverterLengthUnit.Kilometer));
        }

        [Test]
        public void TryParse_RegularPlural_IsAccepted()
        {
            double value;
            UnitConverterLengthUnit unit;

            bool success = UnitConverterParser.TryParse("1.8 kilometers", out value, out unit);

            Assert.That(success, Is.True);
            Assert.That(unit, Is.EqualTo(UnitConverterLengthUnit.Kilometer));
        }

        [Test]
        public void TryParse_SymbolCaseCollision_IsNotCollapsed()
        {
            double value;
            UnitConverterLengthUnit unit;

            Assert.That(
                UnitConverterParser.TryParse("1 mm", out value, out unit),
                Is.True);
            Assert.That(unit, Is.EqualTo(UnitConverterLengthUnit.Millimeter));

            Assert.That(
                UnitConverterParser.TryParse("1 Mm", out value, out unit),
                Is.True);
            Assert.That(unit, Is.EqualTo(UnitConverterLengthUnit.Megameter));

            Assert.That(
                UnitConverterParser.TryParse("1 MM", out value, out unit),
                Is.False);
        }

        [Test]
        public void Convert_UsesExistingLengthConverter()
        {
            double result = UnitConverterParser.Convert(
                "1.8 km",
                UnitConverterLengthUnit.Mile);

            double expected = UnitConverterLength.Convert(
                1.8d,
                UnitConverterLengthUnit.Kilometer,
                UnitConverterLengthUnit.Mile);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Convert_UsesExistingOffsetConversion()
        {
            double result = UnitConverterParser.Convert(
                "20 °C",
                UnitConverterTemperatureUnit.Fahrenheit);

            double expected = UnitConverterTemperature.Convert(
                20d,
                UnitConverterTemperatureUnit.Celsius,
                UnitConverterTemperatureUnit.Fahrenheit);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TryParse_ScientificNotation_IsAccepted()
        {
            double value;
            UnitConverterLengthUnit unit;

            bool success = UnitConverterParser.TryParse("1.2e3 m", out value, out unit);

            Assert.That(success, Is.True);
            Assert.That(value, Is.EqualTo(1200d));
            Assert.That(unit, Is.EqualTo(UnitConverterLengthUnit.Meter));
        }

        [Test]
        public void TryParse_CustomCulture_IsSupported()
        {
            double value;
            UnitConverterLengthUnit unit;

            bool success = UnitConverterParser.TryParse(
                "1,8 km",
                CultureInfo.GetCultureInfo("nl-NL"),
                out value,
                out unit);

            Assert.That(success, Is.True);
            Assert.That(value, Is.EqualTo(1.8d));
            Assert.That(unit, Is.EqualTo(UnitConverterLengthUnit.Kilometer));
        }

        [Test]
        public void TryParse_CustomCulture_WithThousandsSeparator_IsSupported()
        {
            double value;
            UnitConverterLengthUnit unit;

            bool success = UnitConverterParser.TryParse(
                "1.234,5 km",
                CultureInfo.GetCultureInfo("nl-NL"),
                out value,
                out unit);

            Assert.That(success, Is.True);
            Assert.That(value, Is.EqualTo(1234.5d));
            Assert.That(unit, Is.EqualTo(UnitConverterLengthUnit.Kilometer));
        }

        [Test]
        public void TryConvert_CustomCulture_UsesSameCultureRulesAsParse()
        {
            UnitConverterConversionResult result = UnitConverterParser.TryConvert(
                "1.234,5 km",
                UnitConverterLengthUnit.Meter,
                CultureInfo.GetCultureInfo("nl-NL"));

            Assert.That(result.Success, Is.True);
            Assert.That(result.Value, Is.EqualTo(1234500d));
        }

        [Test]
        public void ParsedValue_ToString_UsesCanonicalSymbolFormatting()
        {
            UnitConverterParsedValue<UnitConverterLengthUnit> parsed =
                UnitConverterParser.Parse<UnitConverterLengthUnit>("1.5 kilometer");

            Assert.That(parsed.ToString(), Is.EqualTo("1.5 km"));
            Assert.That(
                parsed.ToString("0.0", CultureInfo.GetCultureInfo("nl-NL")),
                Is.EqualTo("1,5 km"));
        }

        [Test]
        public void TryConvert_InvalidInput_ReturnsFailure()
        {
            UnitConverterConversionResult result = UnitConverterParser.TryConvert(
                "not a unit",
                UnitConverterLengthUnit.Meter);

            Assert.That(result.Success, Is.False);
        }
    }
}