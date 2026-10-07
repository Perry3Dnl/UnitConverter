using System;
using System.Reflection;
using NUnit.Framework;
using UnitConverter.Catalog;
using UnitConverter.FuelEconomy;
using UnitConverter.Length;
using UnitConverter.Quantities;
using UnitConverter.SpecificGravity;
using UnitConverter.Temperature;

namespace UnitConverter.Tests.Quantities
{
    [TestFixture]
    public sealed class PrecisionAndUniversalQuantityTests
    {
        [Test]
        public void LegacyDecimalExtensionPreservesAllDecimalDigits()
        {
            decimal value = 12345678901234567890.12345678m;

            decimal converted = value.Convert(
                UnitConverterLengthUnit.Meter,
                UnitConverterLengthUnit.Meter);

            Assert.That(converted, Is.EqualTo(value));
        }

        [Test]
        public void LegacyDecimalExtensionUsesExactImperialFactor()
        {
            decimal converted = 1m.Convert(
                UnitConverterLengthUnit.Inch,
                UnitConverterLengthUnit.Meter);

            Assert.That(converted, Is.EqualTo(0.0254m));
        }

        [Test]
        public void ExactConverterPowerOfTenFastPathPreservesDecimalPrecision()
        {
            decimal converted = global::UnitConverter.UnitConverterExact.Convert(
                12345678901234567890.12345678m,
                UnitConverterLengthUnit.Centimeter,
                UnitConverterLengthUnit.Meter);

            Assert.That(
                converted,
                Is.EqualTo(123456789012345678.9012345678m));
        }

        [Test]
        public void ExactConverterComposesRationalFactorsBeforeApplyingThem()
        {
            decimal converted = global::UnitConverter.UnitConverterExact.Convert(
                1m,
                UnitConverterLengthUnit.Inch,
                UnitConverterLengthUnit.Foot);

            Assert.That(converted, Is.EqualTo(1m / 12m));
        }

        [Test]
        public void ExactConverterAvoidsTinyIntermediateUnderflow()
        {
            decimal converted = global::UnitConverter.UnitConverterExact.Convert(
                1m,
                UnitConverterLengthUnit.Quectometer,
                UnitConverterLengthUnit.Rontometer);

            Assert.That(converted, Is.EqualTo(0.001m));
        }

        [Test]
        public void ExactConverterCanRepresentTinyResultWhenFinalValueFitsDecimal()
        {
            decimal converted = global::UnitConverter.UnitConverterExact.Convert(
                100m,
                UnitConverterLengthUnit.Quectometer,
                UnitConverterLengthUnit.Meter);

            Assert.That(converted, Is.EqualTo(0.0000000000000000000000000001m));
        }

        [Test]
        public void TemperatureUsesExplicitRationalAffineTransform()
        {
            decimal fahrenheit = global::UnitConverter.UnitConverterExact.Convert(
                0.1m,
                UnitConverterTemperatureUnit.Celsius,
                UnitConverterTemperatureUnit.Fahrenheit);

            Assert.That(fahrenheit, Is.EqualTo(32.18m));
        }

        [Test]
        public void FuelEconomyUsesDecimalNativeReciprocalTransform()
        {
            decimal efficiency = global::UnitConverter.UnitConverterExact.Convert(
                2.5m,
                UnitConverterFuelEconomyUnit.LiterPer100Kilometer,
                UnitConverterFuelEconomyUnit.KilometerPerLiter);

            decimal consumption = global::UnitConverter.UnitConverterExact.Convert(
                efficiency,
                UnitConverterFuelEconomyUnit.KilometerPerLiter,
                UnitConverterFuelEconomyUnit.LiterPer100Kilometer);

            Assert.That(efficiency, Is.EqualTo(40m));
            Assert.That(consumption, Is.EqualTo(2.5m));
        }

        [Test]
        public void SpecificGravityFormulaUnitsUseExactRationalTransforms()
        {
            decimal apiRatio = global::UnitConverter.UnitConverterExact.Convert(
                10m,
                UnitConverterSpecificGravityUnit.APIGravity,
                UnitConverterSpecificGravityUnit.Ratio);
            decimal lightRatio = global::UnitConverter.UnitConverterExact.Convert(
                10m,
                UnitConverterSpecificGravityUnit.BaumeLight,
                UnitConverterSpecificGravityUnit.Ratio);
            decimal heavyRatio = global::UnitConverter.UnitConverterExact.Convert(
                0m,
                UnitConverterSpecificGravityUnit.BaumeHeavy,
                UnitConverterSpecificGravityUnit.Ratio);
            decimal twaddellRatio = global::UnitConverter.UnitConverterExact.Convert(
                0m,
                UnitConverterSpecificGravityUnit.Twaddell,
                UnitConverterSpecificGravityUnit.Ratio);

            Assert.That(apiRatio, Is.EqualTo(1m));
            Assert.That(lightRatio, Is.EqualTo(1m));
            Assert.That(heavyRatio, Is.EqualTo(1m));
            Assert.That(twaddellRatio, Is.EqualTo(1m));

            Assert.That(
                global::UnitConverter.UnitConverterExact.Convert(
                    1m,
                    UnitConverterSpecificGravityUnit.Ratio,
                    UnitConverterSpecificGravityUnit.APIGravity),
                Is.EqualTo(10m));
        }

        [Test]
        public void UniversalQuantityProvidesStrongTypingForFamiliesOutsideNamedCore()
        {
            UnitQuantity<decimal, UnitConverter.Torque.UnitConverterTorqueUnit> torque =
                UnitQuantity.From(
                    12.5m,
                    UnitConverter.Torque.UnitConverterTorqueUnit.NewtonMeter);

            UnitQuantity<decimal, UnitConverter.Torque.UnitConverterTorqueUnit> doubled =
                torque + torque;

            Assert.That(
                doubled.As(UnitConverter.Torque.UnitConverterTorqueUnit.NewtonMeter),
                Is.EqualTo(25m));
        }

        [Test]
        public void UniversalQuantityTypeIncludesTheUnitFamilyAtCompileTime()
        {
            Assert.That(
                typeof(UnitQuantity<decimal, UnitConverterLengthUnit>),
                Is.Not.EqualTo(
                    typeof(UnitQuantity<decimal, UnitConverter.Time.UnitConverterTimeUnit>)));
        }

        [Test]
        public void EveryUniformCatalogFamilyCanCreateAUniversalDecimalQuantity()
        {
            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                if (!family.HasUniformDimensions)
                    continue;

                UnitConverterUnitDescriptor baseUnit = null;
                foreach (UnitConverterUnitDescriptor unit in family.Units)
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
            MethodInfo genericConvert = typeof(global::UnitConverter.UnitConverterExact)
                .GetMethod("Convert", BindingFlags.Public | BindingFlags.Static);

            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                MethodInfo convert = genericConvert.MakeGenericMethod(family.UnitType);
                UnitConverterUnitDescriptor baseUnit = null;
                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    if (unit.Name == family.BaseUnitName)
                    {
                        baseUnit = unit;
                        break;
                    }
                }

                Assert.That(baseUnit, Is.Not.Null, family.Name + " has no base unit.");

                foreach (UnitConverterUnitDescriptor unit in family.Units)
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
                UnitQuantity<decimal, UnitConverterFuelEconomyUnit>.From(
                    5m,
                    UnitConverterFuelEconomyUnit.KilometerPerLiter));
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
