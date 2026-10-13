namespace UnitTools.Tests
{
    using NUnit.Framework;
    using UnitTools.AngularVelocity;
    using UnitTools.Area;
    using UnitTools.Length;
    using UnitTools.MagneticFlux;
    using UnitTools.Mass;
    using UnitTools.MolarConcentration;
    using UnitTools.Speed;
    using UnitTools.ThermalConductivity;
    using UnitTools.Time;
    using UnitTools.Volume;

    public sealed class UnitToolsAliasCoverageTests
    {
        [TestCase("1 μm")]
        [TestCase("1 um")]
        public void MicroNotationVariants_ParseAsMicrometer(string input)
        {
            double value;
            UnitToolsLengthUnit unit;

            Assert.That(UnitToolsParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(value, Is.EqualTo(1d));
            Assert.That(unit, Is.EqualTo(UnitToolsLengthUnit.Micrometer));
        }

        [Test]
        public void CaretSquaredNotation_ParsesArea()
        {
            double value;
            UnitToolsAreaUnit unit;

            Assert.That(UnitToolsParser.TryParse("1 m^2", out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitToolsAreaUnit.SquareMeter));
        }

        [Test]
        public void CaretCubedNotation_ParsesVolume()
        {
            double value;
            UnitToolsVolumeUnit unit;

            Assert.That(UnitToolsParser.TryParse("1 m^3", out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitToolsVolumeUnit.CubicMeter));
        }

        [TestCase("60 kph")]
        [TestCase("60 kmh")]
        [TestCase("60 km/hr")]
        public void CommonSpeedAliases_Parse(string input)
        {
            double value;
            UnitToolsSpeedUnit unit;

            Assert.That(UnitToolsParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitToolsSpeedUnit.KilometerPerHour));
        }

        [TestCase("60 rev/min")]
        [TestCase("60 r/min")]
        [TestCase("60 rotations per minute")]
        public void CommonAngularVelocityAliases_Parse(string input)
        {
            double value;
            UnitToolsAngularVelocityUnit unit;

            Assert.That(UnitToolsParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitToolsAngularVelocityUnit.RevolutionPerMinute));
        }

        [TestCase("2 litres")]
        [TestCase("2 litre")]
        public void BritishVolumeAliases_Parse(string input)
        {
            double value;
            UnitToolsVolumeUnit unit;

            Assert.That(UnitToolsParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitToolsVolumeUnit.Liter));
        }

        [TestCase("2 hrs")]
        [TestCase("2 hours")]
        public void CommonTimeAliases_Parse(string input)
        {
            double value;
            UnitToolsTimeUnit unit;

            Assert.That(UnitToolsParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitToolsTimeUnit.Hour));
        }

        [TestCase("2 lbs")]
        [TestCase("2 pounds")]
        public void CommonMassAliases_Parse(string input)
        {
            double value;
            UnitToolsMassUnit unit;

            Assert.That(UnitToolsParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitToolsMassUnit.Pound));
        }

        [TestCase("2 square metres")]
        [TestCase("2 sqm")]
        public void CommonAreaAliases_Parse(string input)
        {
            double value;
            UnitToolsAreaUnit unit;

            Assert.That(UnitToolsParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitToolsAreaUnit.SquareMeter));
        }

        [Test]
        public void GeneratedAliases_CoverPreviouslyUncuratedScientificFamilies()
        {
            double value;
            UnitToolsMolarConcentrationUnit concentration;
            Assert.That(
                UnitToolsParser.TryParse("2 mole per cubic meter", out value, out concentration),
                Is.True);
            Assert.That(concentration, Is.EqualTo(UnitToolsMolarConcentrationUnit.MolePerCubicMeter));

            UnitToolsThermalConductivityUnit conductivity;
            Assert.That(
                UnitToolsParser.TryParse("2 watt per meter kelvin", out value, out conductivity),
                Is.True);
            Assert.That(conductivity, Is.EqualTo(UnitToolsThermalConductivityUnit.WattPerMeterKelvin));

            UnitToolsMagneticFluxUnit flux;
            Assert.That(
                UnitToolsParser.TryParse("2 volt second", out value, out flux),
                Is.True);
            Assert.That(flux, Is.EqualTo(UnitToolsMagneticFluxUnit.VoltSecond));
        }

        [Test]
        public void DescriptorAliasMetadata_IncludesGeneratedNotationVariants()
        {
            UnitTools.Catalog.UnitToolsFamilyDescriptor<UnitToolsAreaUnit> descriptor;
            Assert.That(UnitTools.Catalog.UnitToolsCatalog.TryGetFamily(out descriptor), Is.True);

            UnitTools.Catalog.UnitToolsUnitDescriptor squareMeter =
                descriptor.GetUnit(UnitToolsAreaUnit.SquareMeter);

            Assert.That(squareMeter.Aliases, Does.Contain("m²"));
            Assert.That(squareMeter.Aliases, Does.Contain("m^2"));
        }

        [Test]
        public void EveryPublishedAlias_ResolvesToItsUnitOrIsExplicitlyAmbiguous()
        {
            foreach (UnitTools.Catalog.UnitToolsFamilyDescriptor family in
                UnitTools.Catalog.UnitToolsCatalog.GetFamilies())
            {
                foreach (UnitTools.Catalog.UnitToolsUnitDescriptor unit in family.Units)
                {
                    foreach (string alias in unit.Aliases)
                    {
                        object resolved;
                        UnitTools.Catalog.UnitToolsUnitResolution resolution =
                            family.ResolveUnit(alias, out resolved);

                        Assert.That(
                            resolution == UnitTools.Catalog.UnitToolsUnitResolution.Resolved ||
                            resolution == UnitTools.Catalog.UnitToolsUnitResolution.Ambiguous,
                            Is.True,
                            family.Name + "." + unit.Name + " alias '" + alias + "'");
                    }
                }
            }
        }
    }
}
