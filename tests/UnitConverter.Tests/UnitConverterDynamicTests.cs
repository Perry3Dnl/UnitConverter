namespace UnitConverter.Tests
{
    using NUnit.Framework;
    using UnitConverter.Catalog;
    using UnitConverter.Length;

    public sealed class UnitConverterDynamicTests
    {
        [Test]
        public void DynamicConvert_ByFamilyAndAliases_UsesExistingConverter()
        {
            double result = UnitConverterDynamic.Convert(
                1.8d,
                UnitConverterFamily.Length,
                "km",
                "mi");

            double expected = UnitConverterLength.Convert(
                1.8d,
                UnitConverterLengthUnit.Kilometer,
                UnitConverterLengthUnit.Mile);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void DynamicConvert_FromString_UsesParsedSourceUnit()
        {
            double result = UnitConverterDynamic.Convert(
                "1.8 km",
                UnitConverterFamily.Length,
                "mi");

            double expected = UnitConverterLength.Convert(
                1.8d,
                UnitConverterLengthUnit.Kilometer,
                UnitConverterLengthUnit.Mile);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void DynamicTryConvert_ReturnsResolvedUnitMetadata()
        {
            UnitConverterDynamicResult result = UnitConverterDynamic.TryConvert(
                1000d,
                UnitConverterFamily.Length,
                "m",
                "km");

            Assert.That(result.Success, Is.True);
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.None));
            Assert.That(result.FromUnit.Name, Is.EqualTo("Meter"));
            Assert.That(result.ToUnit.Name, Is.EqualTo("Kilometer"));
            Assert.That(result.Value, Is.EqualTo(1d));
        }

        [Test]
        public void DynamicTryConvert_AmbiguousCaseFold_ReturnsAmbiguousUnit()
        {
            UnitConverterDynamicResult result = UnitConverterDynamic.TryConvert(
                1d,
                UnitConverterFamily.Length,
                "MM",
                "m");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.AmbiguousUnit));
        }

        [Test]
        public void DynamicTryConvert_UnitFromOtherFamily_ReturnsWrongUnitFamily()
        {
            UnitConverterDynamicResult result = UnitConverterDynamic.TryConvert(
                1d,
                UnitConverterFamily.Length,
                "kg",
                "m");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.WrongUnitFamily));
        }

        [Test]
        public void DynamicTryConvert_UnknownUnit_ReturnsUnknownUnit()
        {
            UnitConverterDynamicResult result = UnitConverterDynamic.TryConvert(
                1d,
                UnitConverterFamily.Length,
                "definitely-not-a-unit",
                "m");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.UnknownUnit));
        }

        [Test]
        public void DynamicTryConvert_InvalidFamily_ReturnsUnknownFamily()
        {
            UnitConverterDynamicResult result = UnitConverterDynamic.TryConvert(
                1d,
                (UnitConverterFamily)9999,
                "m",
                "km");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.UnknownFamily));
        }

        [Test]
        public void DynamicTryConvert_FamilyName_IsCaseInsensitive()
        {
            UnitConverterDynamicResult result = UnitConverterDynamic.TryConvert(
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
            UnitConverterDynamicResult result = UnitConverterDynamic.TryConvert(
                "abc km",
                UnitConverterFamily.Length,
                "m");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.InvalidNumber));
        }

        [Test]
        public void DynamicTryConvert_MissingUnit_ReturnsStructuredError()
        {
            UnitConverterDynamicResult result = UnitConverterDynamic.TryConvert(
                "12.5",
                UnitConverterFamily.Length,
                "m");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.MissingUnit));
        }

        [Test]
        public void ParserDetailed_ReportsAmbiguousUnit()
        {
            UnitConverterParseResult<UnitConverterLengthUnit> result =
                UnitConverterParser.ParseDetailed<UnitConverterLengthUnit>("1 MM");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.AmbiguousUnit));
        }

        [Test]
        public void ParserDetailed_ReportsUnknownUnit()
        {
            UnitConverterParseResult<UnitConverterLengthUnit> result =
                UnitConverterParser.ParseDetailed<UnitConverterLengthUnit>("1 xyz");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.UnknownUnit));
        }

        [Test]
        public void ParserDetailed_SuccessContainsValueAndUnit()
        {
            UnitConverterParseResult<UnitConverterLengthUnit> result =
                UnitConverterParser.ParseDetailed<UnitConverterLengthUnit>("1.8 km");

            Assert.That(result.Success, Is.True);
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.None));
            Assert.That(result.Value, Is.EqualTo(1.8d));
            Assert.That(result.Unit, Is.EqualTo(UnitConverterLengthUnit.Kilometer));
        }
    }
}
