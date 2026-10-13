using NUnit.Framework;
using UnitTools.Catalog;
using UnitTools.Quantities;

namespace UnitTools.Tests
{
    [TestFixture]
    public sealed class AdditionalFamilyCatalogTests
    {
        [Test]
        public void CatalogContainsExactly150FamiliesAnd1858Units()
        {
            UnitToolsFamilyDescriptor[] families = UnitToolsCatalog.GetFamilies();
            int units = 0;
            foreach (UnitToolsFamilyDescriptor family in families)
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
            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
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
            decimal kilopascals = global::UnitTools.UnitToolsExact.Convert(
                1m,
                UnitTools.Stress.UnitToolsStressUnit.Megapascal,
                UnitTools.Stress.UnitToolsStressUnit.Kilopascal);

            Assert.That(kilopascals, Is.EqualTo(1000m));
        }

        [Test]
        public void FractionalScaleIsComposedAsRational()
        {
            decimal perSecond = global::UnitTools.UnitToolsExact.Convert(
                1m,
                UnitTools.AmountFlowRate.UnitToolsAmountFlowRateUnit.MolePerMinute,
                UnitTools.AmountFlowRate.UnitToolsAmountFlowRateUnit.MolePerSecond);

            Assert.That(perSecond, Is.EqualTo(1m / 60m));
        }

        [Test]
        public void ThermalAndScientificFamiliesUseDecimalNativeConversions()
        {
            decimal joulesPerKilogram = global::UnitTools.UnitToolsExact.Convert(
                1m,
                UnitTools.SpecificEnergy.UnitToolsSpecificEnergyUnit.WattHourPerKilogram,
                UnitTools.SpecificEnergy.UnitToolsSpecificEnergyUnit.JoulePerKilogram);

            decimal perMeter = global::UnitTools.UnitToolsExact.Convert(
                1m,
                UnitTools.Wavenumber.UnitToolsWavenumberUnit.PerCentimeter,
                UnitTools.Wavenumber.UnitToolsWavenumberUnit.PerMeter);

            Assert.That(joulesPerKilogram, Is.EqualTo(3600m));
            Assert.That(perMeter, Is.EqualTo(100m));
        }

        [Test]
        public void EngineeringDirectMethodsRemainAvailable()
        {
            double newtonsPerMeter =
                UnitTools.SpringConstant.UnitToolsSpringConstant
                    .NewtonPerMillimeterToNewtonPerMeter(2d);

            Assert.That(newtonsPerMeter, Is.EqualTo(2000d));
        }

#if NET8_0_OR_GREATER
        [Test]
        public void UniversalQuantityImmediatelySupportsNewFamilies()
        {
            UnitQuantity<decimal, UnitTools.Porosity.UnitToolsPorosityUnit> porosity =
                UnitQuantity.From(
                    25m,
                    UnitTools.Porosity.UnitToolsPorosityUnit.Percent);

            Assert.That(
                porosity.As(UnitTools.Porosity.UnitToolsPorosityUnit.Ratio),
                Is.EqualTo(0.25m));
        }
#endif
    }
}
