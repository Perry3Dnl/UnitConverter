namespace UnitConverter.Tests
{
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
            UnitConverterCustomUnit perry-length =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "PerryLength",
                    "perry-length",
                    "Meter",
                    1.7018d,
                    "perry-lengths");

            double meters =
                UnitConverterCustomUnits.Convert(
                    2d,
                    perry-length,
                    "Meter");

            Assert.That(meters, Is.EqualTo(3.4036d).Within(1e-12d));
        }

        [Test]
        public void RegisterLinear_BuiltInConvertsToCustom()
        {
            UnitConverterCustomUnit perry-length =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "PerryLength",
                    "perry-length",
                    "Meter",
                    1.7018d);

            double perry-lengths =
                UnitConverterCustomUnits.Convert(
                    1.7018d,
                    UnitConverterFamily.Length,
                    "Meter",
                    perry-length);

            Assert.That(perry-lengths, Is.EqualTo(1d).Within(1e-12d));
        }

        [Test]
        public void CustomToCustom_UsesFamilyConversion()
        {
            UnitConverterCustomUnit perry-length =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "PerryLength",
                    "perry-length",
                    "Meter",
                    1.7018d);

            UnitConverterCustomUnit doublePerryLength =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "DoublePerryLength",
                    "double-perry-length",
                    "Meter",
                    3.4036d);

            double result =
                UnitConverterCustomUnits.Convert(
                    2d,
                    perry-length,
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
            UnitConverterCustomUnit perry-length =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "PerryLength",
                    "perry-length",
                    "Meter",
                    1.7018d);

            UnitConverterDynamicResult result =
                UnitConverterDynamic.TryConvert(
                    2d,
                    UnitConverterFamily.Length,
                    "perry-length",
                    "Meter");

            Assert.That(result.Success, Is.True);
            Assert.That(result.Value, Is.EqualTo(3.4036d).Within(1e-12d));
            Assert.That(result.CustomFromUnit, Is.SameAs(perry-length));
            Assert.That(result.FromUnit, Is.Null);
            Assert.That(result.ToUnit, Is.Not.Null);
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
                "perry-length",
                "Meter",
                1.7018d);

            Assert.Throws<System.InvalidOperationException>(() =>
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "OtherPerryLength",
                    "PERRY-LENGTH",
                    "Meter",
                    2d));
        }

        [Test]
        public void Unregister_RemovesCustomUnit()
        {
            UnitConverterCustomUnit perry-length =
                UnitConverterCustomUnits.RegisterLinear(
                    UnitConverterFamily.Length,
                    "PerryLength",
                    "perry-length",
                    "Meter",
                    1.7018d);

            Assert.That(UnitConverterCustomUnits.Unregister(perry-length), Is.True);

            UnitConverterCustomUnit resolved;
            Assert.That(
                UnitConverterCustomUnits.TryResolve(
                    UnitConverterFamily.Length,
                    "perry-length",
                    out resolved),
                Is.False);
        }
    }
}
