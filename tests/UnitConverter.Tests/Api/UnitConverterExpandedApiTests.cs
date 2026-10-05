namespace UnitConverter.Tests
{
    using System;
    using System.Globalization;
    using System.Linq;
    using NUnit.Framework;
    using UnitConverter.Catalog;
    using UnitConverter.Length;
    using UnitConverter.Time;
    using UnitConverter.Speed;
    using UnitConverter.Area;
    using UnitConverter.Volume;
    using UnitConverter.Temperature;
    using UnitConverter.TemperatureDelta;
    using UnitConverter.Power;
    using UnitConverter.FuelEconomy;
    using UnitConverter.Frequency;

    public sealed class UnitConverterExpandedApiTests
    {
        [Test]
        public void NumbersAndOptionalValuesCoexist()
        {
            double number = UnitConverterLength.Convert(1, UnitConverterLengthUnit.Meter, UnitConverterLengthUnit.Centimeter);
            var length = new UnitConverterLengthValue(1, UnitConverterLengthUnit.Meter);
            var converted = length.To(UnitConverterLengthUnit.Centimeter);
            Assert.AreEqual(number, converted.Value);
            Assert.AreEqual(UnitConverterLengthUnit.Centimeter, converted.Unit);
            Assert.AreEqual(length, converted);
            Assert.AreEqual(length.GetHashCode(), converted.GetHashCode());
            Assert.AreEqual(150, (length + 50d.WithUnit(UnitConverterLengthUnit.Centimeter)).As(UnitConverterLengthUnit.Centimeter));
            Assert.AreEqual(typeof(double), number.GetType());
        }

        [Test]
        public void ArithmeticProducesTheCorrectQuantityAndHandlesLiters()
        {
            var length = new UnitConverterLengthValue(10, UnitConverterLengthUnit.Meter);
            var time = new UnitConverterTimeValue(2, UnitConverterTimeUnit.Second);
            UnitConverterSpeedValue speed = length / time;
            Assert.AreEqual(5, speed.As(UnitConverterSpeedUnit.MeterPerSecond));
            UnitConverterAreaValue area = length * length;
            UnitConverterVolumeValue volume = area * length;
            Assert.AreEqual(1000, volume.As(UnitConverterVolumeUnit.CubicMeter));
            Assert.AreEqual(1000000, volume.As(UnitConverterVolumeUnit.Liter));
            Assert.AreEqual(length, volume / area);
        }

        [Test]
        public void TemperatureDifferencesDoNotApplyAbsoluteOffsets()
        {
            var hot = new UnitConverterTemperatureValue(30, UnitConverterTemperatureUnit.Celsius);
            var cold = new UnitConverterTemperatureValue(20, UnitConverterTemperatureUnit.Celsius);
            UnitConverterTemperatureDeltaValue delta = hot - cold;
            Assert.AreEqual(18, delta.As(UnitConverterTemperatureDeltaUnit.DegreeFahrenheit), 1e-12);
            Assert.AreEqual(hot, cold + delta);
            Assert.AreEqual(10, UnitConverterTemperatureDelta.Convert(18, UnitConverterTemperatureDeltaUnit.DegreeFahrenheit, UnitConverterTemperatureDeltaUnit.Kelvin), 1e-12);
        }

        [Test]
        public void DecimalConversionPreservesDigitsAndAvoidsBaseUnitOverflow()
        {
            const decimal input = 12345678901234567890.123456789m;
            Assert.AreEqual(input, input.Convert(UnitConverterLengthUnit.Meter, UnitConverterLengthUnit.Meter));
            Assert.AreEqual(1234567890123456789.0123456789m,
                UnitConverterLength.ConvertDecimal(input, UnitConverterLengthUnit.Millimeter, UnitConverterLengthUnit.Centimeter));
            Assert.AreEqual(decimal.MaxValue / 10m,
                UnitConverterLength.ConvertDecimal(decimal.MaxValue, UnitConverterLengthUnit.Ronnameter, UnitConverterLengthUnit.Quettameter) * 100m,
                "Exact rational intermediates must not overflow in meters.");
            Assert.AreEqual(1m, UnitConverterLength.ConvertDecimal(1000m, UnitConverterLengthUnit.Quectometer, UnitConverterLengthUnit.Rontometer));
            Assert.AreEqual(0m, UnitConverterTemperature.ConvertDecimal(32m, UnitConverterTemperatureUnit.Fahrenheit, UnitConverterTemperatureUnit.Celsius));
            Assert.AreEqual(12.5m, UnitConverterFuelEconomy.ConvertDecimal(8m, UnitConverterFuelEconomyUnit.LiterPer100Kilometer, UnitConverterFuelEconomyUnit.KilometerPerLiter));
        }

        [Test]
        public void SafeConversionsRejectInvalidEnumsNonFiniteAndUndefinedValues()
        {
            Assert.IsFalse(UnitConverterLength.TryConvert(1, (UnitConverterLengthUnit)(-1), (UnitConverterLengthUnit)(-1)).Success);
            Assert.IsFalse(UnitConverterLength.TryConvert(double.NaN, UnitConverterLengthUnit.Meter, UnitConverterLengthUnit.Foot).Success);
            Assert.IsFalse(UnitConverterFuelEconomy.TryConvert(0, UnitConverterFuelEconomyUnit.LiterPer100Kilometer, UnitConverterFuelEconomyUnit.KilometerPerLiter).Success);
            decimal result;
            Assert.IsFalse(UnitConverterLength.TryConvertDecimal(decimal.MaxValue, UnitConverterLengthUnit.Meter, UnitConverterLengthUnit.Millimeter, out result));
            Assert.IsFalse(UnitConverterFrequency.TryConvertDecimal(1, UnitConverterFrequencyUnit.BUnit, UnitConverterFrequencyUnit.Hertz, out result));
            Assert.Throws<ArgumentOutOfRangeException>(() => UnitConverterLength.Convert(1, (UnitConverterLengthUnit)99999, (UnitConverterLengthUnit)99999));
        }

        [Test]
        public void ParsingAndFormattingRespectCultureAndSymbolCase()
        {
            var dutch = CultureInfo.GetCultureInfo("nl-NL");
            var value = UnitConverterLength.Parse("1,25 km", dutch);
            Assert.AreEqual(1250, value.As(UnitConverterLengthUnit.Meter));
            Assert.AreEqual("1,25 km", value.ToString("F2", dutch));
            Assert.AreEqual(1000, UnitConverterLength.Parse("1e3m", CultureInfo.InvariantCulture).Value);
            Assert.AreEqual(UnitConverterPowerUnit.Milliwatt, UnitConverterPower.ParseUnit("mW"));
            Assert.AreEqual(UnitConverterPowerUnit.Megawatt, UnitConverterPower.ParseUnit("MW"));
            Assert.AreEqual(UnitConverterLengthUnit.Meter, UnitConverterLength.ParseUnit("Meters"));
            UnitConverterLengthValue parsed;
            Assert.IsFalse(UnitConverterLength.TryParse("NaN m", out parsed));
            Assert.IsFalse(UnitConverterLength.TryParse("12 nonsense", out parsed));
            Assert.IsFalse(UnitConverterLength.TryParse("1,234 m", out parsed, CultureInfo.InvariantCulture));
            Assert.AreEqual(2, UnitConverterLength.Parse("2米", CultureInfo.GetCultureInfo("zh-CN")).Value);
        }

        [Test]
        public void CatalogIsCompleteAndMetadataIsImmutable()
        {
            Assert.AreEqual(191, UnitConverterCatalog.GetFamilyNames().Length);
            Assert.AreEqual(191, Enum.GetValues(typeof(UnitConverterFamily)).Length);
            Assert.AreEqual(100, UnitConverterCatalog.Convert(1, "Length", "Meter", "Centimeter"));
            Assert.AreEqual(3010, Enum.GetValues(typeof(UnitConverterFamily)).Cast<UnitConverterFamily>().Sum(f => UnitConverterCatalog.GetUnits(f).Count));
            var units = (System.Collections.Generic.IList<UnitConverterUnitInfo>)UnitConverterLength.GetUnits();
            Assert.Throws<NotSupportedException>(() => units.Clear());
        }
    }
}
