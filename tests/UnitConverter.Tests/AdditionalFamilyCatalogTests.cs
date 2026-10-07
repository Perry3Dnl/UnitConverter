using NUnit.Framework;
using UnitConverter.Catalog;
using UnitConverter.Quantities;

namespace UnitConverter.Tests
{
    [TestFixture]
    public sealed class AdditionalFamilyCatalogTests
    {
        [Test]
        public void CatalogContainsExactly150FamiliesAnd1858Units()
        {
            UnitConverterFamilyDescriptor[] families = UnitConverterCatalog.GetFamilies();
            int units = 0;
            foreach (UnitConverterFamilyDescriptor family in families)
            {
                units += family.Units.Count;
            }

            Assert.That(families.Length, Is.EqualTo(150));
            Assert.That(units, Is.EqualTo(1858));
        }

        [Test]
        public void All52AdditionalFamiliesAreRegisteredWithFourUnits()
        {
            int count = 0;
            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                if ((int)family.Family < 98)
                    continue;

                count++;
                Assert.That(family.Units.Count, Is.EqualTo(4), family.Name);
                Assert.That(family.HasUniformDimensions, Is.True, family.Name);
            }

            Assert.That(count, Is.EqualTo(52));
        }

        [Test]
        public void MechanicalFamilyUsesExactDecimalScale()
        {
            decimal kilopascals = global::UnitConverter.UnitConverterExact.Convert(
                1m,
                UnitConverter.Stress.UnitConverterStressUnit.Megapascal,
                UnitConverter.Stress.UnitConverterStressUnit.Kilopascal);

            Assert.That(kilopascals, Is.EqualTo(1000m));
        }

        [Test]
        public void FractionalScaleIsComposedAsRational()
        {
            decimal perSecond = global::UnitConverter.UnitConverterExact.Convert(
                1m,
                UnitConverter.AmountFlowRate.UnitConverterAmountFlowRateUnit.MolePerMinute,
                UnitConverter.AmountFlowRate.UnitConverterAmountFlowRateUnit.MolePerSecond);

            Assert.That(perSecond, Is.EqualTo(1m / 60m));
        }

        [Test]
        public void ThermalAndScientificFamiliesUseDecimalNativeConversions()
        {
            decimal joulesPerKilogram = global::UnitConverter.UnitConverterExact.Convert(
                1m,
                UnitConverter.SpecificEnergy.UnitConverterSpecificEnergyUnit.WattHourPerKilogram,
                UnitConverter.SpecificEnergy.UnitConverterSpecificEnergyUnit.JoulePerKilogram);

            decimal perMeter = global::UnitConverter.UnitConverterExact.Convert(
                1m,
                UnitConverter.Wavenumber.UnitConverterWavenumberUnit.PerCentimeter,
                UnitConverter.Wavenumber.UnitConverterWavenumberUnit.PerMeter);

            Assert.That(joulesPerKilogram, Is.EqualTo(3600m));
            Assert.That(perMeter, Is.EqualTo(100m));
        }

        [Test]
        public void EngineeringDirectMethodsRemainAvailable()
        {
            double newtonsPerMeter =
                UnitConverter.SpringConstant.UnitConverterSpringConstant
                    .NewtonPerMillimeterToNewtonPerMeter(2d);

            Assert.That(newtonsPerMeter, Is.EqualTo(2000d));
        }

#if NET8_0_OR_GREATER
        [Test]
        public void UniversalQuantityImmediatelySupportsNewFamilies()
        {
            UnitQuantity<decimal, UnitConverter.Porosity.UnitConverterPorosityUnit> porosity =
                UnitQuantity.From(
                    25m,
                    UnitConverter.Porosity.UnitConverterPorosityUnit.Percent);

            Assert.That(
                porosity.As(UnitConverter.Porosity.UnitConverterPorosityUnit.Ratio),
                Is.EqualTo(0.25m));
        }
#endif
    }
}
