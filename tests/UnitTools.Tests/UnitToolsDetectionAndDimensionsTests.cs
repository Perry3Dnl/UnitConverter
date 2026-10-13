namespace UnitTools.Tests
{
    using NUnit.Framework;
    using UnitTools.Catalog;
    using UnitTools.FuelEconomy;

    public sealed class UnitToolsDetectionAndDimensionsTests
    {
        [Test]
        public void Detector_UniqueUnit_ResolvesFamilyAndUnit()
        {
            UnitToolsDetectionResult result =
                UnitToolsDetector.Detect("2 light-year");

            Assert.That(result.Success, Is.True);
            Assert.That(result.Candidate, Is.Not.Null);
            Assert.That(result.Candidate.Family.Family, Is.EqualTo(UnitToolsFamily.Length));
            Assert.That(result.Candidate.Unit.Name, Is.EqualTo("LightYear"));
            Assert.That(result.Value, Is.EqualTo(2d));
        }

        [Test]
        public void Detector_UnknownUnit_ReturnsUnknown()
        {
            UnitToolsDetectionResult result =
                UnitToolsDetector.Detect("2 definitely-not-a-unit");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Status, Is.EqualTo(UnitToolsDetectionStatus.Unknown));
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.UnknownUnit));
        }

        [Test]
        public void Detector_AmbiguousGlobalUnit_ReturnsCandidates()
        {
            UnitToolsDetectionResult result =
                UnitToolsDetector.Detect("2 Pa");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Status, Is.EqualTo(UnitToolsDetectionStatus.Ambiguous));
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.AmbiguousUnit));
            Assert.That(result.Candidates.Count, Is.GreaterThan(1));
        }

        [Test]
        public void Detector_ExactCaseWinsBeforeCaseInsensitiveMatching()
        {
            UnitToolsDetectionResult result =
                UnitToolsDetector.Detect("2 Mm");

            Assert.That(result.Success, Is.True);
            Assert.That(result.Candidate.Family.Family, Is.EqualTo(UnitToolsFamily.Length));
            Assert.That(result.Candidate.Unit.Name, Is.EqualTo("Megameter"));
        }

        [Test]
        public void DynamicConvert_WithoutFamily_UsesGlobalDetection()
        {
            double meters = UnitToolsDynamic.Convert(
                "2 light-year",
                "m");

            Assert.That(meters, Is.GreaterThan(1e16d));
        }

        [Test]
        public void Dimensions_ForceEqualsMassTimesAcceleration()
        {
            UnitToolsDimensions mass =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Mass).Dimensions;
            UnitToolsDimensions acceleration =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Acceleration).Dimensions;
            UnitToolsDimensions force =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Force).Dimensions;

            Assert.That(mass.Multiply(acceleration), Is.EqualTo(force));
        }

        [Test]
        public void Dimensions_PowerEqualsEnergyPerTime()
        {
            UnitToolsDimensions energy =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Energy).Dimensions;
            UnitToolsDimensions time =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Time).Dimensions;
            UnitToolsDimensions power =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Power).Dimensions;

            Assert.That(energy.Divide(time), Is.EqualTo(power));
        }

        [Test]
        public void Dimensions_DataRateIsDistinctFromFrequency()
        {
            UnitToolsDimensions dataRate =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.DataRate).Dimensions;
            UnitToolsDimensions frequency =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Frequency).Dimensions;

            Assert.That(dataRate, Is.Not.EqualTo(frequency));
            Assert.That(dataRate.Information, Is.EqualTo(1));
            Assert.That(frequency.Information, Is.EqualTo(0));
        }

        [Test]
        public void Dimensions_EnergyAndTorqueShareDimensionsButNotSemantics()
        {
            UnitToolsFamilyDescriptor energy =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Energy);
            UnitToolsFamilyDescriptor torque =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Torque);

            Assert.That(energy.Dimensions, Is.EqualTo(torque.Dimensions));
            Assert.That(energy.Family, Is.Not.EqualTo(torque.Family));
        }

        [Test]
        public void Dimensions_FuelEconomyTracksReciprocalUnitDimensions()
        {
            UnitToolsFamilyDescriptor<UnitToolsFuelEconomyUnit> descriptor;
            Assert.That(UnitToolsCatalog.TryGetFamily(out descriptor), Is.True);
            Assert.That(descriptor.HasUniformDimensions, Is.False);

            UnitToolsUnitDescriptor economy =
                descriptor.GetUnit(UnitToolsFuelEconomyUnit.KilometerPerLiter);
            UnitToolsUnitDescriptor consumption =
                descriptor.GetUnit(UnitToolsFuelEconomyUnit.LiterPer100Kilometer);

            Assert.That(economy.Dimensions.Length, Is.EqualTo(-2));
            Assert.That(consumption.Dimensions.Length, Is.EqualTo(2));
        }

        [Test]
        public void Dimensions_AllOrdinaryFamiliesAreUniformExceptFuelEconomy()
        {
            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                if (family.Family == UnitToolsFamily.FuelEconomy)
                {
                    Assert.That(family.HasUniformDimensions, Is.False);
                }
                else
                {
                    Assert.That(family.HasUniformDimensions, Is.True, family.Name);
                }
            }
        }
    }
}
