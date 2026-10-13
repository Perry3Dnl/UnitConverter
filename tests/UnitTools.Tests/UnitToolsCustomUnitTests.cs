namespace UnitTools.Tests
{
    using System.Globalization;
    using NUnit.Framework;
    using UnitTools.Catalog;

    public sealed class UnitToolsCustomUnitTests
    {
        [SetUp]
        public void SetUp()
        {
            UnitToolsCustomUnits.Clear();
        }

        [TearDown]
        public void TearDown()
        {
            UnitToolsCustomUnits.Clear();
        }

        [Test]
        public void RegisterLinear_CustomLength_ConvertsToBuiltIn()
        {
            UnitToolsCustomUnit perryLength =
                UnitToolsCustomUnits.RegisterLinear(
                    UnitToolsFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    1.7018d,
                    "perryLengths");

            double meters =
                UnitToolsCustomUnits.Convert(
                    2d,
                    perryLength,
                    "Meter");

            Assert.That(meters, Is.EqualTo(3.4036d).Within(1e-12d));
        }

        [Test]
        public void RegisterLinear_BuiltInConvertsToCustom()
        {
            UnitToolsCustomUnit perryLength =
                UnitToolsCustomUnits.RegisterLinear(
                    UnitToolsFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    1.7018d);

            double perryLengths =
                UnitToolsCustomUnits.Convert(
                    1.7018d,
                    UnitToolsFamily.Length,
                    "Meter",
                    perryLength);

            Assert.That(perryLengths, Is.EqualTo(1d).Within(1e-12d));
        }

        [Test]
        public void CustomToCustom_UsesFamilyConversion()
        {
            UnitToolsCustomUnit perryLength =
                UnitToolsCustomUnits.RegisterLinear(
                    UnitToolsFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    1.7018d);

            UnitToolsCustomUnit doublePerryLength =
                UnitToolsCustomUnits.RegisterLinear(
                    UnitToolsFamily.Length,
                    "DoublePerryLength",
                    "double-perryLength",
                    "Meter",
                    3.4036d);

            double result =
                UnitToolsCustomUnits.Convert(
                    2d,
                    perryLength,
                    doublePerryLength);

            Assert.That(result, Is.EqualTo(1d).Within(1e-12d));
        }

        [Test]
        public void RegisterAffine_SupportsOffsetUnits()
        {
            UnitToolsCustomUnit customTemperature =
                UnitToolsCustomUnits.RegisterAffine(
                    UnitToolsFamily.Temperature,
                    "CustomTemperature",
                    "°X",
                    "Custom temperature",
                    "Celsius",
                    2d,
                    10d);

            double celsius =
                UnitToolsCustomUnits.Convert(
                    5d,
                    customTemperature,
                    "Celsius");

            Assert.That(celsius, Is.EqualTo(20d).Within(1e-12d));

            double custom =
                UnitToolsCustomUnits.Convert(
                    20d,
                    UnitToolsFamily.Temperature,
                    "Celsius",
                    customTemperature);

            Assert.That(custom, Is.EqualTo(5d).Within(1e-12d));
        }

        [Test]
        public void DynamicConversion_ResolvesCustomUnits()
        {
            UnitToolsCustomUnit perryLength =
                UnitToolsCustomUnits.RegisterLinear(
                    UnitToolsFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    1.7018d);

            UnitToolsDynamicResult result =
                UnitToolsDynamic.TryConvert(
                    2d,
                    UnitToolsFamily.Length,
                    "perryLength",
                    "Meter");

            Assert.That(result.Success, Is.True);
            Assert.That(result.Value, Is.EqualTo(3.4036d).Within(1e-12d));
            Assert.That(result.CustomFromUnit, Is.SameAs(perryLength));
            Assert.That(result.FromUnit, Is.Null);
            Assert.That(result.ToUnit, Is.Not.Null);
        }

        [Test]
        public void DynamicConversion_MixesLocalizedBuiltInAndCustomUnits()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("nl-NL");
            UnitToolsCustomUnit perryLength =
                UnitToolsCustomUnits.RegisterLinear(
                    UnitToolsFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    2d);

            UnitToolsDynamicResult fromLocalized =
                UnitToolsDynamic.TryConvert(
                    1d,
                    UnitToolsFamily.Length,
                    "voet",
                    "perryLength",
                    culture);

            Assert.That(fromLocalized.Success, Is.True);
            Assert.That(
                fromLocalized.Value,
                Is.EqualTo(0.1524d).Within(1e-12d));

            UnitToolsDynamicResult toLocalized =
                UnitToolsDynamic.TryConvert(
                    1d,
                    UnitToolsFamily.Length,
                    "perryLength",
                    "voet",
                    culture);

            Assert.That(toLocalized.Success, Is.True);
            Assert.That(
                toLocalized.Value,
                Is.EqualTo(2d / 0.3048d).Within(1e-12d));
            Assert.That(toLocalized.CustomFromUnit, Is.SameAs(perryLength));
            Assert.That(toLocalized.ToUnit.Name, Is.EqualTo("Foot"));
        }

        [Test]
        public void GlobalDetection_FindsCustomUnit()
        {
            UnitToolsCustomUnit perryLength =
                UnitToolsCustomUnits.RegisterLinear(
                    UnitToolsFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    1.7018d);

            UnitToolsDetectionResult result =
                UnitToolsDetector.Detect("2 perryLength");

            Assert.That(result.Success, Is.True);
            Assert.That(result.Candidate.IsCustom, Is.True);
            Assert.That(result.Candidate.CustomUnit, Is.SameAs(perryLength));
        }

        [Test]
        public void GlobalDetection_LocalizedBuiltInAndCustomAliasCollisionIsAmbiguous()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("nl-NL");

            UnitToolsCustomUnits.RegisterLinear(
                UnitToolsFamily.Time,
                "CustomMileWord",
                "mijl",
                "Second",
                2d);

            UnitToolsDetectionResult result =
                UnitToolsDetector.Detect(
                    "2 mijl",
                    culture);

            Assert.That(result.Success, Is.False);
            Assert.That(
                result.Status,
                Is.EqualTo(UnitToolsDetectionStatus.Ambiguous));
            Assert.That(
                result.Candidates,
                Has.Some.Matches<UnitToolsUnitCandidate>(
                    candidate =>
                        candidate.IsCustom &&
                        candidate.CustomUnit.Name == "CustomMileWord"));
            Assert.That(
                result.Candidates,
                Has.Some.Matches<UnitToolsUnitCandidate>(
                    candidate =>
                        !candidate.IsCustom &&
                        candidate.Family.Family == UnitToolsFamily.Length &&
                        candidate.Unit.Name == "Mile"));
        }

        [Test]
        public void GlobalDetection_CustomUnitCanMakeBuiltInAliasAmbiguousAcrossFamilies()
        {
            UnitToolsCustomUnits.RegisterLinear(
                UnitToolsFamily.Time,
                "CustomLightYear",
                "light-year",
                "Second",
                2d);

            UnitToolsDetectionResult result =
                UnitToolsDetector.Detect("2 light-year");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Status, Is.EqualTo(UnitToolsDetectionStatus.Ambiguous));
            Assert.That(result.Candidates.Count, Is.EqualTo(2));
        }

        [Test]
        public void GlobalDynamicConversion_UsesCustomUnit()
        {
            UnitToolsCustomUnits.RegisterLinear(
                UnitToolsFamily.Length,
                "PerryLength",
                "perryLength",
                "Meter",
                1.7018d);

            double meters =
                UnitToolsDynamic.Convert(
                    "2 perryLength",
                    "Meter");

            Assert.That(meters, Is.EqualTo(3.4036d).Within(1e-12d));
        }

        [Test]
        public void CompositeConversion_UsesLinearCustomUnit()
        {
            UnitToolsCustomUnits.RegisterLinear(
                UnitToolsFamily.Length,
                "PerryLength",
                "perryLength",
                "Meter",
                1.7018d);

            double metersPerSecond =
                UnitToolsComposite.Convert(
                    2d,
                    "perryLength/s",
                    "m/s");

            Assert.That(
                metersPerSecond,
                Is.EqualTo(3.4036d).Within(1e-12d));
        }

        [Test]
        public void CompositeParser_RejectsAffineCustomUnitAsFactor()
        {
            UnitToolsCustomUnits.RegisterAffine(
                UnitToolsFamily.Temperature,
                "CustomTemperature",
                "°X",
                "Custom temperature",
                "Celsius",
                2d,
                10d);

            UnitToolsExpressionParseResult result =
                UnitToolsExpressionParser.TryParse("°X");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.UnsupportedUnit));
        }

        [Test]
        public void Registration_RejectsBuiltInAliasCollision()
        {
            Assert.Throws<System.InvalidOperationException>(() =>
                UnitToolsCustomUnits.RegisterLinear(
                    UnitToolsFamily.Length,
                    "FakeMeter",
                    "m",
                    "Meter",
                    2d));
        }

        [Test]
        public void Registration_RejectsCustomAliasCollision()
        {
            UnitToolsCustomUnits.RegisterLinear(
                UnitToolsFamily.Length,
                "PerryLength",
                "perryLength",
                "Meter",
                1.7018d);

            Assert.Throws<System.InvalidOperationException>(() =>
                UnitToolsCustomUnits.RegisterLinear(
                    UnitToolsFamily.Length,
                    "OtherPerryLength",
                    "PERRYLENGTH",
                    "Meter",
                    2d));
        }

        [Test]
        public void Unregister_RemovesCustomUnit()
        {
            UnitToolsCustomUnit perryLength =
                UnitToolsCustomUnits.RegisterLinear(
                    UnitToolsFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    1.7018d);

            Assert.That(UnitToolsCustomUnits.Unregister(perryLength), Is.True);

            UnitToolsCustomUnit resolved;
            Assert.That(
                UnitToolsCustomUnits.TryResolve(
                    UnitToolsFamily.Length,
                    "perryLength",
                    out resolved),
                Is.False);
        }
    }
}
