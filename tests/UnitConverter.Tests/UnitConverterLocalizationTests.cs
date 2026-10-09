namespace UnitConverter.Tests
{
    using System.Globalization;
    using NUnit.Framework;
    using UnitConverter.Length;

    public sealed class UnitConverterLocalizationTests
    {
        [Test]
        public void Parser_UsesLocalizedAliases_WhenCultureIsExplicit()
        {
            double value;
            UnitConverterLengthUnit unit;

            bool success = UnitConverterParser.TryParse(
                "1,5 mijl",
                CultureInfo.GetCultureInfo("nl-NL"),
                out value,
                out unit);

            Assert.That(success, Is.True);
            Assert.That(value, Is.EqualTo(1.5d));
            Assert.That(unit, Is.EqualTo(UnitConverterLengthUnit.Mile));
        }

        [Test]
        public void Parser_DoesNotApplyLocalizedAlias_ToInvariantCulture()
        {
            double value;
            UnitConverterLengthUnit unit;

            bool success = UnitConverterParser.TryParse(
                "1.5 mijl",
                CultureInfo.InvariantCulture,
                out value,
                out unit);

            Assert.That(success, Is.False);
        }

        [Test]
        public void Formatter_DisplayName_UsesSpecificCultureWithParentFallback()
        {
            string text = UnitConverterFormatter.Format(
                1.5d,
                UnitConverterLengthUnit.Mile,
                "0.0",
                CultureInfo.GetCultureInfo("nl-NL"),
                UnitConverterUnitFormat.DisplayName);

            Assert.That(text, Is.EqualTo("1,5 mijl"));
        }

        [Test]
        public void Formatter_Symbol_RemainsInvariantAcrossCultures()
        {
            string text = UnitConverterFormatter.Format(
                1.5d,
                UnitConverterLengthUnit.Kilometer,
                "0.0",
                CultureInfo.GetCultureInfo("nl-NL"),
                UnitConverterUnitFormat.Symbol);

            Assert.That(text, Is.EqualTo("1,5 km"));
        }

        [Test]
        public void BuiltInLocalization_ExposesSupportedCultureMetadata()
        {
            CultureInfo[] cultures =
                UnitConverterLocalization.GetSupportedCultures<UnitConverterLengthUnit>();

            Assert.That(cultures, Has.Some.Property("Name").EqualTo("nl"));
        }

        [Test]
        public void BuiltInLocalization_CoversMultipleCoreFamilies()
        {
            string speed = UnitConverterFormatter.Format(
                36d,
                UnitConverter.Speed.UnitConverterSpeedUnit.KilometerPerHour,
                "G",
                CultureInfo.GetCultureInfo("nl-NL"),
                UnitConverterUnitFormat.DisplayName);

            string pressure = UnitConverterFormatter.Format(
                1d,
                UnitConverter.Pressure.UnitConverterPressureUnit.Atmosphere,
                "G",
                CultureInfo.GetCultureInfo("nl-NL"),
                UnitConverterUnitFormat.DisplayName);

            Assert.That(speed, Is.EqualTo("36 kilometer per uur"));
            Assert.That(pressure, Is.EqualTo("1 atmosfeer"));
        }

        [Test]
        public void LocalizationRegistration_RejectsInvariantAliasForDifferentUnit()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("fr-FR");

            Assert.Throws<System.InvalidOperationException>(() =>
                UnitConverterLocalization.Register(
                    culture,
                    UnitConverterLengthUnit.Mile,
                    "m",
                    "metre"));
        }

        [Test]
        public void LocalizationRegistration_AllowsInvariantAliasForSameUnit()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("fr-FR");

            Assert.DoesNotThrow(() =>
                UnitConverterLocalization.Register(
                    culture,
                    UnitConverterLengthUnit.Meter,
                    "mètre",
                    "m"));
        }

        [Test]
        public void CustomLocalization_CanBeRegisteredWithoutChangingCatalog()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("fr-FR");
            UnitConverterLocalization.Register(
                culture,
                UnitConverterLengthUnit.Mile,
                "mille",
                "mille", "milles");

            double value;
            UnitConverterLengthUnit unit;
            Assert.That(
                UnitConverterParser.TryParse("2 milles", culture, out value, out unit),
                Is.True);
            Assert.That(unit, Is.EqualTo(UnitConverterLengthUnit.Mile));

            Assert.That(
                UnitConverterFormatter.Format(
                    value,
                    unit,
                    "G",
                    culture,
                    UnitConverterUnitFormat.DisplayName),
                Is.EqualTo("2 mille"));
        }
    }
}