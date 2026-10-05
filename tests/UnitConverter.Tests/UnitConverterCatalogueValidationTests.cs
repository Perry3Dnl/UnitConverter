namespace UnitConverter.Tests
{
    using System;
    using NUnit.Framework;
    using UnitConverter.Catalog;

    public sealed class UnitConverterCatalogueValidationTests
    {
        private static readonly double[] RoundTripValues =
        {
            -123.456d,
            -1d,
            0d,
            1d,
            123.456d,
        };

        [Test]
        public void Catalogue_HasExpectedFamilyAndUnitCounts()
        {
            UnitConverterFamilyDescriptor[] families =
                UnitConverterCatalog.GetFamilies();

            int units = 0;
            foreach (UnitConverterFamilyDescriptor family in families)
            {
                units += family.Units.Count;
            }

            Assert.That(families.Length, Is.EqualTo(98));
            Assert.That(units, Is.EqualTo(1650));
        }

        [Test]
        public void EveryUnit_HasCompleteMetadataAndProvenance()
        {
            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    string context = family.Name + "." + unit.Name;

                    Assert.That(unit.Unit, Is.Not.Null, context);
                    Assert.That(unit.Name, Is.Not.Null.And.Not.Empty, context);
                    Assert.That(unit.Symbol, Is.Not.Null.And.Not.Empty, context);
                    Assert.That(unit.DisplayName, Is.Not.Null.And.Not.Empty, context);
                    Assert.That(unit.Aliases, Is.Not.Null.And.Not.Empty, context);
                    Assert.That(unit.Provenance, Is.Not.Null, context);
                    Assert.That(unit.Provenance.Sources, Is.Not.Null.And.Not.Empty, context);

                    foreach (UnitConverterProvenanceSource source in unit.Provenance.Sources)
                    {
                        Assert.That(source.Id, Is.Not.Null.And.Not.Empty, context);
                        Assert.That(source.Title, Is.Not.Null.And.Not.Empty, context);
                        Assert.That(source.Organization, Is.Not.Null.And.Not.Empty, context);
                        Assert.That(source.Reference, Is.Not.Null.And.Not.Empty, context);
                    }
                }
            }
        }

        [Test]
        public void EverySameUnitConversion_IsIdentity()
        {
            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    foreach (double value in RoundTripValues)
                    {
                        double converted = family.Convert(
                            value,
                            unit.Unit,
                            unit.Unit);

                        Assert.That(
                            converted,
                            Is.EqualTo(value).Within(Tolerance(value)),
                            family.Name + "." + unit.Name + " at " + value);
                    }
                }
            }
        }

        [Test]
        public void EveryConversionPath_ReturnsFiniteValuesForRepresentativeInput()
        {
            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                foreach (UnitConverterUnitDescriptor from in family.Units)
                {
                    foreach (UnitConverterUnitDescriptor to in family.Units)
                    {
                        double converted = family.Convert(
                            1d,
                            from.Unit,
                            to.Unit);

                        Assert.That(
                            double.IsNaN(converted),
                            Is.False,
                            family.Name + ": " + from.Name + " -> " + to.Name);
                        Assert.That(
                            double.IsInfinity(converted),
                            Is.False,
                            family.Name + ": " + from.Name + " -> " + to.Name);
                    }
                }
            }
        }

        [Test]
        public void EveryConversionPath_RoundTripsRepresentativeValues()
        {
            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                foreach (UnitConverterUnitDescriptor from in family.Units)
                {
                    foreach (UnitConverterUnitDescriptor to in family.Units)
                    {
                        foreach (double value in RoundTripValues)
                        {
                            double converted = family.Convert(
                                value,
                                from.Unit,
                                to.Unit);
                            double restored = family.Convert(
                                converted,
                                to.Unit,
                                from.Unit);

                            Assert.That(
                                double.IsNaN(restored) || double.IsInfinity(restored),
                                Is.False,
                                family.Name + ": " + from.Name + " -> " + to.Name);

                            Assert.That(
                                restored,
                                Is.EqualTo(value).Within(RoundTripTolerance(value)),
                                family.Name + ": " + from.Name + " -> " + to.Name +
                                " -> " + from.Name + " at " + value);
                        }
                    }
                }
            }
        }

        [Test]
        public void EveryFormattedSymbol_ResolvesWithinItsFamilyOrIsExplicitlyAmbiguous()
        {
            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    object resolved;
                    UnitConverterUnitResolution resolution =
                        family.ResolveUnit(unit.Symbol, out resolved);

                    Assert.That(
                        resolution == UnitConverterUnitResolution.Resolved ||
                        resolution == UnitConverterUnitResolution.Ambiguous,
                        Is.True,
                        family.Name + "." + unit.Name + " symbol '" + unit.Symbol + "'");
                }
            }
        }

        private static double Tolerance(double value)
        {
            return Math.Max(1e-12d, Math.Abs(value) * 1e-12d);
        }

        private static double RoundTripTolerance(double value)
        {
            return Math.Max(1e-10d, Math.Abs(value) * 1e-9d);
        }
    }
}
