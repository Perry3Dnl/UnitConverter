namespace UnitConverter.Tests
{
    using NUnit.Framework;
    using UnitConverter.AngularVelocity;
    using UnitConverter.Area;
    using UnitConverter.Length;
    using UnitConverter.MagneticFlux;
    using UnitConverter.Mass;
    using UnitConverter.MolarConcentration;
    using UnitConverter.Speed;
    using UnitConverter.ThermalConductivity;
    using UnitConverter.Time;
    using UnitConverter.Volume;

    public sealed class UnitConverterAliasCoverageTests
    {
        [TestCase("1 μm")]
        [TestCase("1 um")]
        public void MicroNotationVariants_ParseAsMicrometer(string input)
        {
            double value;
            UnitConverterLengthUnit unit;

            Assert.That(UnitConverterParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(value, Is.EqualTo(1d));
            Assert.That(unit, Is.EqualTo(UnitConverterLengthUnit.Micrometer));
        }

        [Test]
        public void CaretSquaredNotation_ParsesArea()
        {
            double value;
            UnitConverterAreaUnit unit;

            Assert.That(UnitConverterParser.TryParse("1 m^2", out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitConverterAreaUnit.SquareMeter));
        }

        [Test]
        public void CaretCubedNotation_ParsesVolume()
        {
            double value;
            UnitConverterVolumeUnit unit;

            Assert.That(UnitConverterParser.TryParse("1 m^3", out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitConverterVolumeUnit.CubicMeter));
        }

        [TestCase("60 kph")]
        [TestCase("60 kmh")]
        [TestCase("60 km/hr")]
        public void CommonSpeedAliases_Parse(string input)
        {
            double value;
            UnitConverterSpeedUnit unit;

            Assert.That(UnitConverterParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitConverterSpeedUnit.KilometerPerHour));
        }

        [TestCase("60 rev/min")]
        [TestCase("60 r/min")]
        [TestCase("60 rotations per minute")]
        public void CommonAngularVelocityAliases_Parse(string input)
        {
            double value;
            UnitConverterAngularVelocityUnit unit;

            Assert.That(UnitConverterParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitConverterAngularVelocityUnit.RevolutionPerMinute));
        }

        [TestCase("2 litres")]
        [TestCase("2 litre")]
        public void BritishVolumeAliases_Parse(string input)
        {
            double value;
            UnitConverterVolumeUnit unit;

            Assert.That(UnitConverterParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitConverterVolumeUnit.Liter));
        }

        [TestCase("2 hrs")]
        [TestCase("2 hours")]
        public void CommonTimeAliases_Parse(string input)
        {
            double value;
            UnitConverterTimeUnit unit;

            Assert.That(UnitConverterParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitConverterTimeUnit.Hour));
        }

        [TestCase("2 lbs")]
        [TestCase("2 pounds")]
        public void CommonMassAliases_Parse(string input)
        {
            double value;
            UnitConverterMassUnit unit;

            Assert.That(UnitConverterParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitConverterMassUnit.Pound));
        }

        [TestCase("2 square metres")]
        [TestCase("2 sqm")]
        public void CommonAreaAliases_Parse(string input)
        {
            double value;
            UnitConverterAreaUnit unit;

            Assert.That(UnitConverterParser.TryParse(input, out value, out unit), Is.True);
            Assert.That(unit, Is.EqualTo(UnitConverterAreaUnit.SquareMeter));
        }

        [Test]
        public void GeneratedAliases_CoverPreviouslyUncuratedScientificFamilies()
        {
            double value;
            UnitConverterMolarConcentrationUnit concentration;
            Assert.That(
                UnitConverterParser.TryParse("2 mole per cubic meter", out value, out concentration),
                Is.True);
            Assert.That(concentration, Is.EqualTo(UnitConverterMolarConcentrationUnit.MolePerCubicMeter));

            UnitConverterThermalConductivityUnit conductivity;
            Assert.That(
                UnitConverterParser.TryParse("2 watt per meter kelvin", out value, out conductivity),
                Is.True);
            Assert.That(conductivity, Is.EqualTo(UnitConverterThermalConductivityUnit.WattPerMeterKelvin));

            UnitConverterMagneticFluxUnit flux;
            Assert.That(
                UnitConverterParser.TryParse("2 volt second", out value, out flux),
                Is.True);
            Assert.That(flux, Is.EqualTo(UnitConverterMagneticFluxUnit.VoltSecond));
        }

        [Test]
        public void DescriptorAliasMetadata_IncludesGeneratedNotationVariants()
        {
            UnitConverter.Catalog.UnitConverterFamilyDescriptor<UnitConverterAreaUnit> descriptor;
            Assert.That(UnitConverter.Catalog.UnitConverterCatalog.TryGetFamily(out descriptor), Is.True);

            UnitConverter.Catalog.UnitConverterUnitDescriptor squareMeter =
                descriptor.GetUnit(UnitConverterAreaUnit.SquareMeter);

            Assert.That(squareMeter.Aliases, Does.Contain("m²"));
            Assert.That(squareMeter.Aliases, Does.Contain("m^2"));
        }

        [Test]
        public void EveryPublishedAlias_ResolvesToItsUnitOrIsExplicitlyAmbiguous()
        {
            foreach (UnitConverter.Catalog.UnitConverterFamilyDescriptor family in
                UnitConverter.Catalog.UnitConverterCatalog.GetFamilies())
            {
                foreach (UnitConverter.Catalog.UnitConverterUnitDescriptor unit in family.Units)
                {
                    foreach (string alias in unit.Aliases)
                    {
                        object resolved;
                        UnitConverter.Catalog.UnitConverterUnitResolution resolution =
                            family.ResolveUnit(alias, out resolved);

                        Assert.That(
                            resolution == UnitConverter.Catalog.UnitConverterUnitResolution.Resolved ||
                            resolution == UnitConverter.Catalog.UnitConverterUnitResolution.Ambiguous,
                            Is.True,
                            family.Name + "." + unit.Name + " alias '" + alias + "'");
                    }
                }
            }
        }
    }
}
