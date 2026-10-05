namespace UnitConverter.Tests
{
    using NUnit.Framework;
    using UnitConverter.Catalog;
    using UnitConverter.FuelEconomy;

    public sealed class UnitConverterDetectionAndDimensionsTests
    {
        [Test]
        public void Detector_UniqueUnit_ResolvesFamilyAndUnit()
        {
            UnitConverterDetectionResult result =
                UnitConverterDetector.Detect("2 light-year");

            Assert.That(result.Success, Is.True);
            Assert.That(result.Candidate, Is.Not.Null);
            Assert.That(result.Candidate.Family.Family, Is.EqualTo(UnitConverterFamily.Length));
            Assert.That(result.Candidate.Unit.Name, Is.EqualTo("LightYear"));
            Assert.That(result.Value, Is.EqualTo(2d));
        }

        [Test]
        public void Detector_UnknownUnit_ReturnsUnknown()
        {
            UnitConverterDetectionResult result =
                UnitConverterDetector.Detect("2 definitely-not-a-unit");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Status, Is.EqualTo(UnitConverterDetectionStatus.Unknown));
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.UnknownUnit));
        }

        [Test]
        public void Detector_AmbiguousGlobalUnit_ReturnsCandidates()
        {
            UnitConverterDetectionResult result =
                UnitConverterDetector.Detect("2 Pa");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Status, Is.EqualTo(UnitConverterDetectionStatus.Ambiguous));
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.AmbiguousUnit));
            Assert.That(result.Candidates.Count, Is.GreaterThan(1));
        }

        [Test]
        public void Detector_ExactCaseWinsBeforeCaseInsensitiveMatching()
        {
            UnitConverterDetectionResult result =
                UnitConverterDetector.Detect("2 Mm");

            Assert.That(result.Success, Is.True);
            Assert.That(result.Candidate.Family.Family, Is.EqualTo(UnitConverterFamily.Length));
            Assert.That(result.Candidate.Unit.Name, Is.EqualTo("Megameter"));
        }

        [Test]
        public void DynamicConvert_WithoutFamily_UsesGlobalDetection()
        {
            double meters = UnitConverterDynamic.Convert(
                "2 light-year",
                "m");

            Assert.That(meters, Is.GreaterThan(1e16d));
        }

        [Test]
        public void Dimensions_ForceEqualsMassTimesAcceleration()
        {
            UnitConverterDimensions mass =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.Mass).Dimensions;
            UnitConverterDimensions acceleration =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.Acceleration).Dimensions;
            UnitConverterDimensions force =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.Force).Dimensions;

            Assert.That(mass.Multiply(acceleration), Is.EqualTo(force));
        }

        [Test]
        public void Dimensions_PowerEqualsEnergyPerTime()
        {
            UnitConverterDimensions energy =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.Energy).Dimensions;
            UnitConverterDimensions time =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.Time).Dimensions;
            UnitConverterDimensions power =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.Power).Dimensions;

            Assert.That(energy.Divide(time), Is.EqualTo(power));
        }

        [Test]
        public void Dimensions_DataRateIsDistinctFromFrequency()
        {
            UnitConverterDimensions dataRate =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.DataRate).Dimensions;
            UnitConverterDimensions frequency =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.Frequency).Dimensions;

            Assert.That(dataRate, Is.Not.EqualTo(frequency));
            Assert.That(dataRate.Information, Is.EqualTo(1));
            Assert.That(frequency.Information, Is.EqualTo(0));
        }

        [Test]
        public void Dimensions_EnergyAndTorqueShareDimensionsButNotSemantics()
        {
            UnitConverterFamilyDescriptor energy =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.Energy);
            UnitConverterFamilyDescriptor torque =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.Torque);

            Assert.That(energy.Dimensions, Is.EqualTo(torque.Dimensions));
            Assert.That(energy.Family, Is.Not.EqualTo(torque.Family));
        }

        [Test]
        public void Dimensions_FuelEconomyTracksReciprocalUnitDimensions()
        {
            UnitConverterFamilyDescriptor<UnitConverterFuelEconomyUnit> descriptor;
            Assert.That(UnitConverterCatalog.TryGetFamily(out descriptor), Is.True);
            Assert.That(descriptor.HasUniformDimensions, Is.False);

            UnitConverterUnitDescriptor economy =
                descriptor.GetUnit(UnitConverterFuelEconomyUnit.KilometerPerLiter);
            UnitConverterUnitDescriptor consumption =
                descriptor.GetUnit(UnitConverterFuelEconomyUnit.LiterPer100Kilometer);

            Assert.That(economy.Dimensions.Length, Is.EqualTo(-2));
            Assert.That(consumption.Dimensions.Length, Is.EqualTo(2));
        }

        [Test]
        public void Dimensions_AllOrdinaryFamiliesAreUniformExceptFuelEconomy()
        {
            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                if (family.Family == UnitConverterFamily.FuelEconomy)
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
