using System;
using System.Reflection;
using NUnit.Framework;
using UnitTools.Catalog;
using UnitTools.FuelEconomy;
using UnitTools.Length;
using UnitTools.Quantities;
using UnitTools.SpecificGravity;
using UnitTools.Temperature;

namespace UnitTools.Tests.Quantities
{
    [TestFixture]
    public sealed class PrecisionAndUniversalQuantityTests
    {
        [Test]
        public void LegacyDecimalExtensionPreservesAllDecimalDigits()
        {
            decimal value = 12345678901234567890.12345678m;

            decimal converted = value.Convert(
                UnitToolsLengthUnit.Meter,
                UnitToolsLengthUnit.Meter);

            Assert.That(converted, Is.EqualTo(value));
        }

        [Test]
        public void LegacyDecimalExtensionUsesExactImperialFactor()
        {
            decimal converted = 1m.Convert(
                UnitToolsLengthUnit.Inch,
                UnitToolsLengthUnit.Meter);

            Assert.That(converted, Is.EqualTo(0.0254m));
        }

        [Test]
        public void ExactConverterPowerOfTenFastPathPreservesDecimalPrecision()
        {
            decimal converted = global::UnitTools.UnitToolsExact.Convert(
                12345678901234567890.12345678m,
                UnitToolsLengthUnit.Centimeter,
                UnitToolsLengthUnit.Meter);

            Assert.That(
                converted,
                Is.EqualTo(123456789012345678.9012345678m));
        }

        [Test]
        public void ExactConverterComposesRationalFactorsBeforeApplyingThem()
        {
            decimal converted = global::UnitTools.UnitToolsExact.Convert(
                1m,
                UnitToolsLengthUnit.Inch,
                UnitToolsLengthUnit.Foot);

            Assert.That(converted, Is.EqualTo(1m / 12m));
        }

        [Test]
        public void ExactConverterAvoidsTinyIntermediateUnderflow()
        {
            decimal converted = global::UnitTools.UnitToolsExact.Convert(
                1m,
                UnitToolsLengthUnit.Quectometer,
                UnitToolsLengthUnit.Rontometer);

            Assert.That(converted, Is.EqualTo(0.001m));
        }

        [Test]
        public void ExactConverterCanRepresentTinyResultWhenFinalValueFitsDecimal()
        {
            decimal converted = global::UnitTools.UnitToolsExact.Convert(
                100m,
                UnitToolsLengthUnit.Quectometer,
                UnitToolsLengthUnit.Meter);

            Assert.That(converted, Is.EqualTo(0.0000000000000000000000000001m));
        }

        [Test]
        public void TemperatureUsesExplicitRationalAffineTransform()
        {
            decimal fahrenheit = global::UnitTools.UnitToolsExact.Convert(
                0.1m,
                UnitToolsTemperatureUnit.Celsius,
                UnitToolsTemperatureUnit.Fahrenheit);

            Assert.That(fahrenheit, Is.EqualTo(32.18m));
        }

        [Test]
        public void FuelEconomyUsesDecimalNativeReciprocalTransform()
        {
            decimal efficiency = global::UnitTools.UnitToolsExact.Convert(
                2.5m,
                UnitToolsFuelEconomyUnit.LiterPer100Kilometer,
                UnitToolsFuelEconomyUnit.KilometerPerLiter);

            decimal consumption = global::UnitTools.UnitToolsExact.Convert(
                efficiency,
                UnitToolsFuelEconomyUnit.KilometerPerLiter,
                UnitToolsFuelEconomyUnit.LiterPer100Kilometer);

            Assert.That(efficiency, Is.EqualTo(40m));
            Assert.That(consumption, Is.EqualTo(2.5m));
        }

        [Test]
        public void SpecificGravityFormulaUnitsUseExactRationalTransforms()
        {
            decimal apiRatio = global::UnitTools.UnitToolsExact.Convert(
                10m,
                UnitToolsSpecificGravityUnit.APIGravity,
                UnitToolsSpecificGravityUnit.Ratio);
            decimal lightRatio = global::UnitTools.UnitToolsExact.Convert(
                10m,
                UnitToolsSpecificGravityUnit.BaumeLight,
                UnitToolsSpecificGravityUnit.Ratio);
            decimal heavyRatio = global::UnitTools.UnitToolsExact.Convert(
                0m,
                UnitToolsSpecificGravityUnit.BaumeHeavy,
                UnitToolsSpecificGravityUnit.Ratio);
            decimal twaddellRatio = global::UnitTools.UnitToolsExact.Convert(
                0m,
                UnitToolsSpecificGravityUnit.Twaddell,
                UnitToolsSpecificGravityUnit.Ratio);

            Assert.That(apiRatio, Is.EqualTo(1m));
            Assert.That(lightRatio, Is.EqualTo(1m));
            Assert.That(heavyRatio, Is.EqualTo(1m));
            Assert.That(twaddellRatio, Is.EqualTo(1m));

            Assert.That(
                global::UnitTools.UnitToolsExact.Convert(
                    1m,
                    UnitToolsSpecificGravityUnit.Ratio,
                    UnitToolsSpecificGravityUnit.APIGravity),
                Is.EqualTo(10m));
        }

        [Test]
        public void UniversalQuantityProvidesStrongTypingForFamiliesOutsideNamedCore()
        {
            UnitQuantity<decimal, UnitTools.Torque.UnitToolsTorqueUnit> torque =
                UnitQuantity.From(
                    12.5m,
                    UnitTools.Torque.UnitToolsTorqueUnit.NewtonMeter);

            UnitQuantity<decimal, UnitTools.Torque.UnitToolsTorqueUnit> doubled =
                torque + torque;

            Assert.That(
                doubled.As(UnitTools.Torque.UnitToolsTorqueUnit.NewtonMeter),
                Is.EqualTo(25m));
        }

        [Test]
        public void UniversalQuantityTypeIncludesTheUnitFamilyAtCompileTime()
        {
            Assert.That(
                typeof(UnitQuantity<decimal, UnitToolsLengthUnit>),
                Is.Not.EqualTo(
                    typeof(UnitQuantity<decimal, UnitTools.Time.UnitToolsTimeUnit>)));
        }

        [Test]
        public void EveryUniformCatalogFamilyCanCreateAUniversalDecimalQuantity()
        {
            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                if (!family.HasUniformDimensions)
                    continue;

                UnitToolsUnitDescriptor baseUnit = null;
                foreach (UnitToolsUnitDescriptor unit in family.Units)
                {
                    if (unit.Name == family.BaseUnitName)
                    {
                        baseUnit = unit;
                        break;
                    }
                }

                Assert.That(
                    baseUnit,
                    Is.Not.Null,
                    family.Name + " has no base unit descriptor.");

                Type closedType = typeof(UnitQuantity<,>).MakeGenericType(
                    typeof(decimal),
                    family.UnitType);

                MethodInfo from = closedType.GetMethod(
                    "From",
                    BindingFlags.Public | BindingFlags.Static);
                object quantity = from.Invoke(
                    null,
                    new[] { (object)1m, baseUnit.Unit });

                MethodInfo asMethod = closedType.GetMethod(
                    "As",
                    BindingFlags.Public | BindingFlags.Instance);
                decimal roundTrip = (decimal)asMethod.Invoke(
                    quantity,
                    new[] { baseUnit.Unit });

                Assert.That(roundTrip, Is.EqualTo(1m), family.Name);
            }
        }

        [Test]
        public void EveryRegisteredUnitHasADecimalConversionPath()
        {
            MethodInfo genericConvert = typeof(global::UnitTools.UnitToolsExact)
                .GetMethod("Convert", BindingFlags.Public | BindingFlags.Static);

            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                MethodInfo convert = genericConvert.MakeGenericMethod(family.UnitType);
                UnitToolsUnitDescriptor baseUnit = null;
                foreach (UnitToolsUnitDescriptor unit in family.Units)
                {
                    if (unit.Name == family.BaseUnitName)
                    {
                        baseUnit = unit;
                        break;
                    }
                }

                Assert.That(baseUnit, Is.Not.Null, family.Name + " has no base unit.");

                foreach (UnitToolsUnitDescriptor unit in family.Units)
                {
                    try
                    {
                        convert.Invoke(null, new[] { (object)1m, unit.Unit, baseUnit.Unit });
                        convert.Invoke(null, new[] { (object)1m, baseUnit.Unit, unit.Unit });
                    }
                    catch (TargetInvocationException exception)
                        when (exception.InnerException is OverflowException)
                    {
                        // A valid decimal path may still produce a mathematically correct
                        // result outside System.Decimal's finite range.
                    }
                    catch (TargetInvocationException exception)
                    {
                        Assert.Fail(
                            family.Name + "." + unit.Name +
                            " has no usable decimal path: " +
                            exception.InnerException?.GetType().Name + " - " +
                            exception.InnerException?.Message);
                    }
                }
            }
        }

        [Test]
        public void NonUniformFuelEconomyCannotPretendToBeOneDimension()
        {
            Assert.Throws<NotSupportedException>(() =>
                UnitQuantity<decimal, UnitToolsFuelEconomyUnit>.From(
                    5m,
                    UnitToolsFuelEconomyUnit.KilometerPerLiter));
        }

        [Test]
        public void FuelEconomyHasSeparateCompileTimeTypesForReciprocalDimensions()
        {
            FuelEfficiency<decimal> efficiency = FuelEfficiency<decimal>.From(
                20m,
                FuelEfficiencyUnit.KilometerPerLiter);

            FuelConsumption<decimal> consumption = efficiency.ToConsumption(
                FuelConsumptionUnit.LiterPer100Kilometer);

            Assert.That(consumption.Value, Is.EqualTo(5m));
            Assert.That(
                typeof(FuelEfficiency<decimal>),
                Is.Not.EqualTo(typeof(FuelConsumption<decimal>)));
        }
    }
}
