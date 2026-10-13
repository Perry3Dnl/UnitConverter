namespace UnitTools.Tests
{
    using System;
    using NUnit.Framework;
    using UnitTools.Catalog;

    public sealed class UnitToolsCatalogueValidationTests
    {
        private static readonly double[] IdentityValues =
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
            UnitToolsFamilyDescriptor[] families =
                UnitToolsCatalog.GetFamilies();

            int units = 0;
            foreach (UnitToolsFamilyDescriptor family in families)
            {
                units += family.Units.Count;
            }

            Assert.That(families.Length, Is.EqualTo(150));
            Assert.That(units, Is.EqualTo(1858));
        }

        [Test]
        public void EveryUnit_HasCompleteMetadataAndProvenance()
        {
            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                foreach (UnitToolsUnitDescriptor unit in family.Units)
                {
                    string context = family.Name + "." + unit.Name;

                    Assert.That(unit.Unit, Is.Not.Null, context);
                    Assert.That(unit.Name, Is.Not.Null.And.Not.Empty, context);
                    Assert.That(unit.Symbol, Is.Not.Null.And.Not.Empty, context);
                    Assert.That(unit.DisplayName, Is.Not.Null.And.Not.Empty, context);
                    Assert.That(unit.Aliases, Is.Not.Null.And.Not.Empty, context);
                    Assert.That(unit.Provenance, Is.Not.Null, context);
                    Assert.That(unit.Provenance.Sources, Is.Not.Null.And.Not.Empty, context);

                    foreach (UnitToolsProvenanceSource source in unit.Provenance.Sources)
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
            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                foreach (UnitToolsUnitDescriptor unit in family.Units)
                {
                    foreach (double value in IdentityValues)
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
            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                foreach (UnitToolsUnitDescriptor from in family.Units)
                {
                    foreach (UnitToolsUnitDescriptor to in family.Units)
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
        public void EveryConversionPath_RoundTripsSharedPhysicalValues()
        {
            double[] baseValues = { 0.5d, 1d, 2d };

            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                UnitToolsUnitDescriptor baseUnit = null;
                foreach (UnitToolsUnitDescriptor unit in family.Units)
                {
                    if (unit.Name == family.BaseUnitName)
                    {
                        baseUnit = unit;
                        break;
                    }
                }

                Assert.That(baseUnit, Is.Not.Null, family.Name);

                foreach (double baseValue in baseValues)
                {
                    foreach (UnitToolsUnitDescriptor from in family.Units)
                    {
                        double sourceValue = family.Convert(
                            baseValue,
                            baseUnit.Unit,
                            from.Unit);

                        Assert.That(
                            double.IsNaN(sourceValue) || double.IsInfinity(sourceValue),
                            Is.False,
                            family.Name + ": " + baseUnit.Name + " -> " + from.Name);

                        foreach (UnitToolsUnitDescriptor to in family.Units)
                        {
                            double converted = family.Convert(
                                sourceValue,
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
                                Is.EqualTo(sourceValue).Within(RoundTripTolerance(sourceValue)),
                                family.Name + ": " + from.Name + " -> " + to.Name +
                                " -> " + from.Name + " for base " + baseValue);
                        }
                    }
                }
            }
        }

        [Test]
        public void EveryFormattedSymbol_ResolvesWithinItsFamilyOrIsExplicitlyAmbiguous()
        {
            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                foreach (UnitToolsUnitDescriptor unit in family.Units)
                {
                    object resolved;
                    UnitToolsUnitResolution resolution =
                        family.ResolveUnit(unit.Symbol, out resolved);

                    Assert.That(
                        resolution == UnitToolsUnitResolution.Resolved ||
                        resolution == UnitToolsUnitResolution.Ambiguous,
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
            return Math.Max(1e-10d, Math.Abs(value) * 1e-10d);
        }
    }
}
