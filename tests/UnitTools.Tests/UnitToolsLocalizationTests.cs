namespace UnitTools.Tests
{
    using System.Globalization;
    using NUnit.Framework;
    using UnitTools.Length;

    public sealed class UnitToolsLocalizationTests
    {
        [Test]
        public void Parser_UsesLocalizedAliases_WhenCultureIsExplicit()
        {
            double value;
            UnitToolsLengthUnit unit;

            bool success = UnitToolsParser.TryParse(
                "1,5 mijl",
                CultureInfo.GetCultureInfo("nl-NL"),
                out value,
                out unit);

            Assert.That(success, Is.True);
            Assert.That(value, Is.EqualTo(1.5d));
            Assert.That(unit, Is.EqualTo(UnitToolsLengthUnit.Mile));
        }

        [Test]
        public void Parser_DoesNotApplyLocalizedAlias_ToInvariantCulture()
        {
            double value;
            UnitToolsLengthUnit unit;

            bool success = UnitToolsParser.TryParse(
                "1.5 mijl",
                CultureInfo.InvariantCulture,
                out value,
                out unit);

            Assert.That(success, Is.False);
        }

        [Test]
        public void Formatter_DisplayName_UsesSpecificCultureWithParentFallback()
        {
            string text = UnitToolsFormatter.Format(
                1.5d,
                UnitToolsLengthUnit.Mile,
                "0.0",
                CultureInfo.GetCultureInfo("nl-NL"),
                UnitToolsUnitFormat.DisplayName);

            Assert.That(text, Is.EqualTo("1,5 mijl"));
        }

        [Test]
        public void Formatter_Symbol_RemainsInvariantAcrossCultures()
        {
            string text = UnitToolsFormatter.Format(
                1.5d,
                UnitToolsLengthUnit.Kilometer,
                "0.0",
                CultureInfo.GetCultureInfo("nl-NL"),
                UnitToolsUnitFormat.Symbol);

            Assert.That(text, Is.EqualTo("1,5 km"));
        }

        [Test]
        public void BuiltInLocalization_ExposesSupportedCultureMetadata()
        {
            CultureInfo[] cultures =
                UnitToolsLocalization.GetSupportedCultures<UnitToolsLengthUnit>();

            Assert.That(cultures, Has.Some.Property("Name").EqualTo("nl"));
        }

        [Test]
        public void BuiltInLocalization_CoversMultipleCoreFamilies()
        {
            string speed = UnitToolsFormatter.Format(
                36d,
                UnitTools.Speed.UnitToolsSpeedUnit.KilometerPerHour,
                "G",
                CultureInfo.GetCultureInfo("nl-NL"),
                UnitToolsUnitFormat.DisplayName);

            string pressure = UnitToolsFormatter.Format(
                1d,
                UnitTools.Pressure.UnitToolsPressureUnit.Atmosphere,
                "G",
                CultureInfo.GetCultureInfo("nl-NL"),
                UnitToolsUnitFormat.DisplayName);

            Assert.That(speed, Is.EqualTo("36 kilometer per uur"));
            Assert.That(pressure, Is.EqualTo("1 atmosfeer"));
        }

        [Test]
        public void LocalizationRegistration_RejectsInvariantAliasForDifferentUnit()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("fr-FR");

            Assert.Throws<System.InvalidOperationException>(() =>
                UnitToolsLocalization.Register(
                    culture,
                    UnitToolsLengthUnit.Mile,
                    "m",
                    "metre"));
        }

        [Test]
        public void LocalizationRegistration_AllowsInvariantAliasForSameUnit()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("fr-FR");

            Assert.DoesNotThrow(() =>
                UnitToolsLocalization.Register(
                    culture,
                    UnitToolsLengthUnit.Meter,
                    "mètre",
                    "m"));
        }

        [Test]
        public void CustomLocalization_CanBeRegisteredWithoutChangingCatalog()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("fr-FR");
            UnitToolsLocalization.Register(
                culture,
                UnitToolsLengthUnit.Mile,
                "mille",
                "mille", "milles");

            double value;
            UnitToolsLengthUnit unit;
            Assert.That(
                UnitToolsParser.TryParse("2 milles", culture, out value, out unit),
                Is.True);
            Assert.That(unit, Is.EqualTo(UnitToolsLengthUnit.Mile));

            Assert.That(
                UnitToolsFormatter.Format(
                    value,
                    unit,
                    "G",
                    culture,
                    UnitToolsUnitFormat.DisplayName),
                Is.EqualTo("2 mille"));
        }
    }
}