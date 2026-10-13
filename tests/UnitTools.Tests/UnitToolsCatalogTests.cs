namespace UnitTools.Tests
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using UnitTools.Catalog;
    using UnitTools.Length;
    using UnitTools.Temperature;

    public sealed class UnitToolsCatalogTests
    {
        [Test]
        public void FamilyEnum_PreservesOriginalNumericValues()
        {
            Assert.That((int)UnitToolsFamily.Length, Is.EqualTo(0));
            Assert.That((int)UnitToolsFamily.FuelEconomy, Is.EqualTo(21));
            Assert.That((int)UnitToolsFamily.ActivityConcentration, Is.EqualTo(22));
            Assert.That((int)UnitToolsFamily.Yank, Is.EqualTo(96));
            Assert.That((int)UnitToolsFamily.TemperatureDelta, Is.EqualTo(97));
        }

        [Test]
        public void Catalog_HasDescriptorForEveryFamilyEnumValue()
        {
            UnitToolsFamilyDescriptor[] descriptors = UnitToolsCatalog.GetFamilies();
            Array enumValues = Enum.GetValues(typeof(UnitToolsFamily));

            Assert.That(descriptors.Length, Is.EqualTo(150));
            Assert.That(descriptors.Length, Is.EqualTo(enumValues.Length));

            foreach (UnitToolsFamily family in enumValues)
            {
                UnitToolsFamilyDescriptor descriptor;
                Assert.That(UnitToolsCatalog.TryGetFamily(family, out descriptor), Is.True, family.ToString());
                Assert.That(descriptor, Is.Not.Null);
                Assert.That(descriptor.Family, Is.EqualTo(family));
            }
        }

        [Test]
        public void Catalog_EveryFamilyHasBaseUnitPresentInItsUnitEnum()
        {
            foreach (UnitToolsFamilyDescriptor descriptor in UnitToolsCatalog.GetFamilies())
            {
                Assert.That(
                    descriptor.Units.Any(unit => unit.Name == descriptor.BaseUnitName),
                    Is.True,
                    descriptor.Name + " base unit " + descriptor.BaseUnitName + " was not found.");
            }
        }

        [Test]
        public void Catalog_EveryUnitHasCanonicalMetadata()
        {
            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                Assert.That(family.UnitType.IsEnum, Is.True, family.Name);
                Assert.That(family.Units.Count, Is.GreaterThan(0), family.Name);

                foreach (UnitToolsUnitDescriptor unit in family.Units)
                {
                    Assert.That(unit.Unit, Is.Not.Null, family.Name);
                    Assert.That(unit.Name, Is.Not.Empty, family.Name);
                    Assert.That(unit.Symbol, Is.Not.Null.And.Not.Empty, family.Name + "." + unit.Name);
                    Assert.That(unit.DisplayName, Is.Not.Null.And.Not.Empty, family.Name + "." + unit.Name);
                    Assert.That(unit.Aliases, Does.Contain(unit.Name), family.Name + "." + unit.Name);
                    Assert.That(unit.Aliases, Does.Contain(unit.Symbol), family.Name + "." + unit.Name);
                    Assert.That(unit.Aliases, Does.Contain(unit.DisplayName), family.Name + "." + unit.Name);
                }
            }
        }

        [Test]
        public void Catalog_ThrowingLookupsMirrorTryLookups()
        {
            UnitToolsFamilyDescriptor byName =
                UnitToolsCatalog.GetFamily("length");
            UnitToolsFamilyDescriptor<UnitTools.Length.UnitToolsLengthUnit> byType =
                UnitToolsCatalog.GetFamily<UnitTools.Length.UnitToolsLengthUnit>();

            Assert.That(byName.Family, Is.EqualTo(UnitToolsFamily.Length));
            Assert.That(byType.Family, Is.EqualTo(UnitToolsFamily.Length));
            Assert.That(
                UnitToolsCatalog.GetBaseUnitName(UnitToolsFamily.Length),
                Is.EqualTo(byName.BaseUnitName));

            string baseUnitName;
            Assert.That(
                UnitToolsCatalog.TryGetBaseUnitName(
                    UnitToolsFamily.Length,
                    out baseUnitName),
                Is.True);
            Assert.That(baseUnitName, Is.EqualTo(byName.BaseUnitName));
        }

        [Test]
        public void Catalog_ThrowingLookupsRejectUnknownConsumersClearly()
        {
            Assert.Throws<System.ArgumentException>(() =>
                UnitToolsCatalog.GetFamily("definitely-not-a-family"));

            Assert.Throws<System.NotSupportedException>(() =>
                UnitToolsCatalog.GetFamily<System.DayOfWeek>());
        }

        [Test]
        public void Catalog_MetadataSnapshotsCannotMutateInternalState()
        {
            UnitToolsFamilyDescriptor family =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Length);
            UnitToolsUnitDescriptor meter =
                family.Units.First(unit => unit.Name == "Meter");

            string[] aliases = meter.Aliases;
            string originalAlias = aliases[0];
            aliases[0] = "mutated-outside-catalog";

            Assert.That(
                meter.Aliases[0],
                Is.EqualTo(originalAlias),
                "Alias snapshots must not mutate the catalog.");
            Assert.That(
                family.Units,
                Is.Not.TypeOf<UnitToolsUnitDescriptor[]>(),
                "The read-only unit view must not expose the backing array.");
            Assert.That(
                meter.Provenance.Sources,
                Is.Not.TypeOf<UnitToolsProvenanceSource[]>(),
                "Provenance sources must not expose the backing array.");
        }

        [Test]
        public void RuntimeDescriptorLookup_UsesSameCanonicalMetadataAsTypedLookup()
        {
            UnitToolsFamilyDescriptor family =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Length);

            object resolved;
            Assert.That(
                family.ResolveUnit("m", out resolved),
                Is.EqualTo(UnitToolsUnitResolution.Resolved));

            UnitToolsUnitDescriptor descriptor;
            Assert.That(family.TryGetUnit(resolved, out descriptor), Is.True);
            Assert.That(descriptor.Name, Is.EqualTo("Meter"));
            Assert.That(family.GetUnit(resolved), Is.SameAs(descriptor));
        }

        [Test]
        public void Catalog_ExposesStandardsAndLegacyProvenanceStates()
        {
            UnitToolsFamilyDescriptor length =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Length);
            UnitToolsUnitDescriptor meter =
                length.Units.First(unit => unit.Name == "Meter");

            Assert.That(
                meter.Provenance.Status,
                Is.EqualTo(UnitToolsProvenanceStatus.StandardsReferenced));
            Assert.That(meter.Provenance.HasAuthoritativeReference, Is.True);

            UnitToolsFamilyDescriptor yank =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Yank);
            UnitToolsUnitDescriptor yankBase = yank.Units.First();

            Assert.That(
                yankBase.Provenance.Status,
                Is.EqualTo(UnitToolsProvenanceStatus.LegacyMigrated));
            Assert.That(yankBase.Provenance.HasAuthoritativeReference, Is.False);
        }

        [Test]
        public void Catalog_FundamentalConstantUnitsReferenceCodata()
        {
            UnitToolsFamilyDescriptor temperature =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Temperature);
            UnitToolsUnitDescriptor planckTemperature =
                temperature.Units.First(unit => unit.Name == "PlanckTemperature");

            Assert.That(
                planckTemperature.Provenance.Status,
                Is.EqualTo(UnitToolsProvenanceStatus.FundamentalConstantReferenced));
            Assert.That(
                planckTemperature.Provenance.Sources.Any(source => source.Id == "codata-2022"),
                Is.True);
        }

        [Test]
        public void Catalog_ResolvesFamilyNamesCaseInsensitively()
        {
            UnitToolsFamilyDescriptor descriptor;

            Assert.That(UnitToolsCatalog.TryGetFamily("length", out descriptor), Is.True);
            Assert.That(descriptor.Family, Is.EqualTo(UnitToolsFamily.Length));
        }

        [Test]
        public void Catalog_ProvidesTypedLengthDescriptor()
        {
            UnitToolsFamilyDescriptor<UnitToolsLengthUnit> descriptor;

            Assert.That(UnitToolsCatalog.TryGetFamily(out descriptor), Is.True);
            Assert.That(descriptor.Family, Is.EqualTo(UnitToolsFamily.Length));
            Assert.That(descriptor.BaseUnitName, Is.EqualTo("Meter"));
        }

        [Test]
        public void Aliases_AreExplicitAndSupportIrregularForms()
        {
            UnitToolsFamilyDescriptor<UnitToolsLengthUnit> length;
            Assert.That(UnitToolsCatalog.TryGetFamily(out length), Is.True);

            UnitToolsLengthUnit lengthUnit;
            Assert.That(length.TryResolveUnit("feet", out lengthUnit), Is.True);
            Assert.That(lengthUnit, Is.EqualTo(UnitToolsLengthUnit.Foot));

            UnitToolsFamilyDescriptor<UnitToolsTemperatureUnit> temperature;
            Assert.That(UnitToolsCatalog.TryGetFamily(out temperature), Is.True);

            UnitToolsTemperatureUnit temperatureUnit;
            Assert.That(temperature.TryResolveUnit("degrees celsius", out temperatureUnit), Is.True);
            Assert.That(temperatureUnit, Is.EqualTo(UnitToolsTemperatureUnit.Celsius));
        }

        [Test]
        public void Aliases_DoNotGuessUnknownPlurals()
        {
            UnitToolsFamilyDescriptor<UnitToolsLengthUnit> descriptor;
            Assert.That(UnitToolsCatalog.TryGetFamily(out descriptor), Is.True);

            UnitToolsLengthUnit unit;
            Assert.That(descriptor.TryResolveUnit("smoots", out unit), Is.False);
        }
    }
}
