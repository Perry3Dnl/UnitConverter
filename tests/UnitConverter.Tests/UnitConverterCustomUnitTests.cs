namespace UnitConverter.Tests
{
    using System.Globalization;
    using NUnit.Framework;
    using UnitConverter.Catalog;

    public sealed class UnitConverterCustomUnitTests
    {
        [SetUp]
        public void SetUp()
        {
            UnitConverterCustomUnits.Clear();
        }

        [TearDown]
        public void TearDown()
        {
            UnitConverterCustomUnits.Clear();
        }

        [Test]
        public void RegisterLinear_CustomLength_ConvertsToBuiltIn()
        {
            UnitConverterCustomUnit perryLength =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    1.7018d,
                    "perryLengths");

            double meters =
                UnitConverterCustomUnits.Convert(
                    2d,
                    perryLength,
                    "Meter");

            Assert.That(meters, Is.EqualTo(3.4036d).Within(1e-12d));
        }

        [Test]
        public void RegisterLinear_BuiltInConvertsToCustom()
        {
            UnitConverterCustomUnit perryLength =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    1.7018d);

            double perryLengths =
                UnitConverterCustomUnits.Convert(
                    1.7018d,
                    UnitConverterFamily.Length,
                    "Meter",
                    perryLength);

            Assert.That(perryLengths, Is.EqualTo(1d).Within(1e-12d));
        }

        [Test]
        public void CustomToCustom_UsesFamilyConversion()
        {
            UnitConverterCustomUnit perryLength =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    1.7018d);

            UnitConverterCustomUnit doublePerryLength =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "DoublePerryLength",
                    "double-perryLength",
                    "Meter",
                    3.4036d);

            double result =
                UnitConverterCustomUnits.Convert(
                    2d,
                    perryLength,
                    doublePerryLength);

            Assert.That(result, Is.EqualTo(1d).Within(1e-12d));
        }

        [Test]
        public void RegisterAffine_SupportsOffsetUnits()
        {
            UnitConverterCustomUnit customTemperature =
                UnitConverterCustomUnits.RegisterAffine(
                    UnitConverterFamily.Temperature,
                    "CustomTemperature",
                    "°X",
                    "Custom temperature",
                    "Celsius",
                    2d,
                    10d);

            double celsius =
                UnitConverterCustomUnits.Convert(
                    5d,
                    customTemperature,
                    "Celsius");

            Assert.That(celsius, Is.EqualTo(20d).Within(1e-12d));

            double custom =
                UnitConverterCustomUnits.Convert(
                    20d,
                    UnitConverterFamily.Temperature,
                    "Celsius",
                    customTemperature);

            Assert.That(custom, Is.EqualTo(5d).Within(1e-12d));
        }

        [Test]
        public void DynamicConversion_ResolvesCustomUnits()
        {
            UnitConverterCustomUnit perryLength =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    1.7018d);

            UnitConverterDynamicResult result =
                UnitConverterDynamic.TryConvert(
                    2d,
                    UnitConverterFamily.Length,
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
            UnitConverterCustomUnit perryLength =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    2d);

            UnitConverterDynamicResult fromLocalized =
                UnitConverterDynamic.TryConvert(
                    1d,
                    UnitConverterFamily.Length,
                    "voet",
                    "perryLength",
                    culture);

            Assert.That(fromLocalized.Success, Is.True);
            Assert.That(
                fromLocalized.Value,
                Is.EqualTo(0.1524d).Within(1e-12d));

            UnitConverterDynamicResult toLocalized =
                UnitConverterDynamic.TryConvert(
                    1d,
                    UnitConverterFamily.Length,
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
            UnitConverterCustomUnit perryLength =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    1.7018d);

            UnitConverterDetectionResult result =
                UnitConverterDetector.Detect("2 perryLength");

            Assert.That(result.Success, Is.True);
            Assert.That(result.Candidate.IsCustom, Is.True);
            Assert.That(result.Candidate.CustomUnit, Is.SameAs(perryLength));
        }

        [Test]
        public void GlobalDetection_LocalizedBuiltInAndCustomAliasCollisionIsAmbiguous()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("nl-NL");

            UnitConverterCustomUnits.RegisterLinear(
                UnitConverterFamily.Time,
                "CustomMileWord",
                "mijl",
                "Second",
                2d);

            UnitConverterDetectionResult result =
                UnitConverterDetector.Detect(
                    "2 mijl",
                    culture);

            Assert.That(result.Success, Is.False);
            Assert.That(
                result.Status,
                Is.EqualTo(UnitConverterDetectionStatus.Ambiguous));
            Assert.That(
                result.Candidates,
                Has.Some.Matches<UnitConverterUnitCandidate>(
                    candidate =>
                        candidate.IsCustom &&
                        candidate.CustomUnit.Name == "CustomMileWord"));
            Assert.That(
                result.Candidates,
                Has.Some.Matches<UnitConverterUnitCandidate>(
                    candidate =>
                        !candidate.IsCustom &&
                        candidate.Family.Family == UnitConverterFamily.Length &&
                        candidate.Unit.Name == "Mile"));
        }

        [Test]
        public void GlobalDetection_CustomUnitCanMakeBuiltInAliasAmbiguousAcrossFamilies()
        {
            UnitConverterCustomUnits.RegisterLinear(
                UnitConverterFamily.Time,
                "CustomLightYear",
                "light-year",
                "Second",
                2d);

            UnitConverterDetectionResult result =
                UnitConverterDetector.Detect("2 light-year");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Status, Is.EqualTo(UnitConverterDetectionStatus.Ambiguous));
            Assert.That(result.Candidates.Count, Is.EqualTo(2));
        }

        [Test]
        public void GlobalDynamicConversion_UsesCustomUnit()
        {
            UnitConverterCustomUnits.RegisterLinear(
                UnitConverterFamily.Length,
                "PerryLength",
                "perryLength",
                "Meter",
                1.7018d);

            double meters =
                UnitConverterDynamic.Convert(
                    "2 perryLength",
                    "Meter");

            Assert.That(meters, Is.EqualTo(3.4036d).Within(1e-12d));
        }

        [Test]
        public void CompositeConversion_UsesLinearCustomUnit()
        {
            UnitConverterCustomUnits.RegisterLinear(
                UnitConverterFamily.Length,
                "PerryLength",
                "perryLength",
                "Meter",
                1.7018d);

            double metersPerSecond =
                UnitConverterComposite.Convert(
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
            UnitConverterCustomUnits.RegisterAffine(
                UnitConverterFamily.Temperature,
                "CustomTemperature",
                "°X",
                "Custom temperature",
                "Celsius",
                2d,
                10d);

            UnitConverterExpressionParseResult result =
                UnitConverterExpressionParser.TryParse("°X");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.UnsupportedUnit));
        }

        [Test]
        public void Registration_RejectsBuiltInAliasCollision()
        {
            Assert.Throws<System.InvalidOperationException>(() =>
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "FakeMeter",
                    "m",
                    "Meter",
                    2d));
        }

        [Test]
        public void Registration_RejectsCustomAliasCollision()
        {
            UnitConverterCustomUnits.RegisterLinear(
                UnitConverterFamily.Length,
                "PerryLength",
                "perryLength",
                "Meter",
                1.7018d);

            Assert.Throws<System.InvalidOperationException>(() =>
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "OtherPerryLength",
                    "PERRYLENGTH",
                    "Meter",
                    2d));
        }

        [Test]
        public void Unregister_RemovesCustomUnit()
        {
            UnitConverterCustomUnit perryLength =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "PerryLength",
                    "perryLength",
                    "Meter",
                    1.7018d);

            Assert.That(UnitConverterCustomUnits.Unregister(perryLength), Is.True);

            UnitConverterCustomUnit resolved;
            Assert.That(
                UnitConverterCustomUnits.TryResolve(
                    UnitConverterFamily.Length,
                    "perryLength",
                    out resolved),
                Is.False);
        }
    }
}
