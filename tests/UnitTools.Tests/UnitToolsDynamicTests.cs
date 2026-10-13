namespace UnitTools.Tests
{
    using System.Globalization;
    using NUnit.Framework;
    using UnitTools.Catalog;
    using UnitTools.Length;

    public sealed class UnitToolsDynamicTests
    {
        [Test]
        public void DynamicConvert_ByFamilyAndAliases_UsesExistingConverter()
        {
            double result = UnitToolsDynamic.Convert(
                1.8d,
                UnitToolsFamily.Length,
                "km",
                "mi");

            double expected = UnitToolsLength.Convert(
                1.8d,
                UnitToolsLengthUnit.Kilometer,
                UnitToolsLengthUnit.Mile);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void DynamicConvert_FromString_UsesParsedSourceUnit()
        {
            double result = UnitToolsDynamic.Convert(
                "1.8 km",
                UnitToolsFamily.Length,
                "mi");

            double expected = UnitToolsLength.Convert(
                1.8d,
                UnitToolsLengthUnit.Kilometer,
                UnitToolsLengthUnit.Mile);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void DynamicFamilyConversion_ResolvesLocalizedSourceAndTarget()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("nl-NL");

            UnitToolsDynamicResult result =
                UnitToolsDynamic.TryConvert(
                    "1,0 mijl",
                    UnitToolsFamily.Length,
                    "voet",
                    culture);

            Assert.That(result.Success, Is.True);
            Assert.That(result.Value, Is.EqualTo(5280d).Within(1e-9d));
            Assert.That(result.FromUnit.Name, Is.EqualTo("Mile"));
            Assert.That(result.ToUnit.Name, Is.EqualTo("Foot"));
        }

        [Test]
        public void DynamicFamilyNameRoute_PreservesLocalizationProvider()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("nl-NL");

            UnitToolsDynamicResult result =
                UnitToolsDynamic.TryConvert(
                    "1,0 mijl",
                    "length",
                    "voet",
                    culture);

            Assert.That(result.Success, Is.True);
            Assert.That(result.Value, Is.EqualTo(5280d).Within(1e-9d));
        }

        [Test]
        public void GlobalDetection_UsesLocalizedAliasAsFallback()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("nl-NL");

            UnitToolsDetectionResult detection =
                UnitToolsDetector.Detect(
                    "1,0 mijl",
                    culture);

            Assert.That(detection.Success, Is.True);
            Assert.That(detection.Candidate.Family.Family, Is.EqualTo(UnitToolsFamily.Length));
            Assert.That(detection.Candidate.Unit.Name, Is.EqualTo("Mile"));

            UnitToolsDynamicResult converted =
                UnitToolsDynamic.TryConvert(
                    "1,0 mijl",
                    "voet",
                    culture);

            Assert.That(converted.Success, Is.True);
            Assert.That(converted.Value, Is.EqualTo(5280d).Within(1e-9d));
        }

        [Test]
        public void DynamicTryConvert_ReturnsResolvedUnitMetadata()
        {
            UnitToolsDynamicResult result = UnitToolsDynamic.TryConvert(
                1000d,
                UnitToolsFamily.Length,
                "m",
                "km");

            Assert.That(result.Success, Is.True);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.None));
            Assert.That(result.FromUnit.Name, Is.EqualTo("Meter"));
            Assert.That(result.ToUnit.Name, Is.EqualTo("Kilometer"));
            Assert.That(result.Value, Is.EqualTo(1d));
        }

        [Test]
        public void DynamicTryConvert_AmbiguousCaseFold_ReturnsAmbiguousUnit()
        {
            UnitToolsDynamicResult result = UnitToolsDynamic.TryConvert(
                1d,
                UnitToolsFamily.Length,
                "MM",
                "m");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.AmbiguousUnit));
        }

        [Test]
        public void DynamicTryConvert_UnitFromOtherFamily_ReturnsWrongUnitFamily()
        {
            UnitToolsDynamicResult result = UnitToolsDynamic.TryConvert(
                1d,
                UnitToolsFamily.Length,
                "kg",
                "m");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.WrongUnitFamily));
        }

        [Test]
        public void DynamicTryConvert_UnknownUnit_ReturnsUnknownUnit()
        {
            UnitToolsDynamicResult result = UnitToolsDynamic.TryConvert(
                1d,
                UnitToolsFamily.Length,
                "definitely-not-a-unit",
                "m");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.UnknownUnit));
        }

        [Test]
        public void DynamicTryConvert_InvalidFamily_ReturnsUnknownFamily()
        {
            UnitToolsDynamicResult result = UnitToolsDynamic.TryConvert(
                1d,
                (UnitToolsFamily)9999,
                "m",
                "km");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.UnknownFamily));
        }

        [Test]
        public void DynamicTryConvert_FamilyName_IsCaseInsensitive()
        {
            UnitToolsDynamicResult result = UnitToolsDynamic.TryConvert(
                1000d,
                "length",
                "m",
                "km");

            Assert.That(result.Success, Is.True);
            Assert.That(result.Value, Is.EqualTo(1d));
        }

        [Test]
        public void DynamicTryConvert_InvalidNumber_ReturnsStructuredError()
        {
            UnitToolsDynamicResult result = UnitToolsDynamic.TryConvert(
                "abc km",
                UnitToolsFamily.Length,
                "m");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.InvalidNumber));
        }

        [Test]
        public void DynamicTryConvert_MissingUnit_ReturnsStructuredError()
        {
            UnitToolsDynamicResult result = UnitToolsDynamic.TryConvert(
                "12.5",
                UnitToolsFamily.Length,
                "m");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.MissingUnit));
        }

        [Test]
        public void ParserDetailed_ReportsAmbiguousUnit()
        {
            UnitToolsParseResult<UnitToolsLengthUnit> result =
                UnitToolsParser.ParseDetailed<UnitToolsLengthUnit>("1 MM");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.AmbiguousUnit));
        }

        [Test]
        public void ParserDetailed_ReportsUnknownUnit()
        {
            UnitToolsParseResult<UnitToolsLengthUnit> result =
                UnitToolsParser.ParseDetailed<UnitToolsLengthUnit>("1 xyz");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.UnknownUnit));
        }

        [Test]
        public void ParserDetailed_SuccessContainsValueAndUnit()
        {
            UnitToolsParseResult<UnitToolsLengthUnit> result =
                UnitToolsParser.ParseDetailed<UnitToolsLengthUnit>("1.8 km");

            Assert.That(result.Success, Is.True);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.None));
            Assert.That(result.Value, Is.EqualTo(1.8d));
            Assert.That(result.Unit, Is.EqualTo(UnitToolsLengthUnit.Kilometer));
        }
    }
}
