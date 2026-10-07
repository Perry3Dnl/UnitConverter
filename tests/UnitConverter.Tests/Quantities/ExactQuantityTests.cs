using System;
using NUnit.Framework;
using UnitConverter.Quantities;

namespace UnitConverter.Tests.Quantities
{
    [TestFixture]
    public sealed class ExactQuantityTests
    {
        [Test]
        public void FamilyEnumIsPartOfCompileTimeQuantityType()
        {
            Type lengthType = typeof(ExactQuantity<UnitConverter.Length.UnitConverterLengthUnit>);
            Type timeType = typeof(ExactQuantity<UnitConverter.Time.UnitConverterTimeUnit>);
            Type pressureType = typeof(ExactQuantity<UnitConverter.Pressure.UnitConverterPressureUnit>);

            Assert.That(lengthType, Is.Not.EqualTo(timeType));
            Assert.That(lengthType, Is.Not.EqualTo(pressureType));
            Assert.That(timeType, Is.Not.EqualTo(pressureType));
        }

        [Test]
        public void DecimalLengthConversionNeverRoutesValueThroughDouble()
        {
            var length = ExactQuantity.From(
                0.1m,
                UnitConverter.Length.UnitConverterLengthUnit.Meter);

            decimal centimeters = length.In(UnitConverter.Length.UnitConverterLengthUnit.Centimeter);
            decimal inches = ExactQuantity.From(
                1m,
                UnitConverter.Length.UnitConverterLengthUnit.Inch)
                .In(UnitConverter.Length.UnitConverterLengthUnit.Meter);

            Assert.That(centimeters, Is.EqualTo(10m));
            Assert.That(inches, Is.EqualTo(0.0254m));
        }

        [Test]
        public void ExactTemperatureUsesRationalAffineTransform()
        {
            decimal celsius = UnitConverterExact.Convert(
                32m,
                UnitConverter.Temperature.UnitConverterTemperatureUnit.Fahrenheit,
                UnitConverter.Temperature.UnitConverterTemperatureUnit.Celsius);

            Assert.That(celsius, Is.EqualTo(0m));
        }

        [Test]
        public void SameFamilyArithmeticStaysStronglyTypedAndDecimalNative()
        {
            var left = ExactQuantity.From(1.25m, UnitConverter.Length.UnitConverterLengthUnit.Meter);
            var right = ExactQuantity.From(75m, UnitConverter.Length.UnitConverterLengthUnit.Centimeter);

            ExactQuantity<UnitConverter.Length.UnitConverterLengthUnit> total = left + right;

            Assert.That(total.In(UnitConverter.Length.UnitConverterLengthUnit.Meter), Is.EqualTo(2m));
        }

        [Test]
        public void NonUniformFamilyRejectsDimensionallyAmbiguousArithmetic()
        {
            var economyA = ExactQuantity.From(10m, UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.KilometerPerLiter);
            var economyB = ExactQuantity.From(5m, UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.LiterPer100Kilometer);

            Assert.Throws<InvalidOperationException>(() =>
            {
                _ = economyA + economyB;
            });
        }

        [Test]
        public void ExactConverterAcceptsEveryRegisteredUnitEnumTypeForIdentityConversions()
        {
            foreach (var family in UnitConverter.Catalog.UnitConverterCatalog.GetFamilies())
            {
                var method = typeof(UnitConverterExact)
                    .GetMethod(nameof(UnitConverterExact.Convert))
                    .MakeGenericMethod(family.UnitType);

                object unit = family.Units[0].Unit;
                decimal converted = (decimal)method.Invoke(null, new object[] { 123.456m, unit, unit });

                Assert.That(converted, Is.EqualTo(123.456m), family.Name);
            }
        }
    }
}
