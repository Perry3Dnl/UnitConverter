namespace UnitConverter.Tests
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using UnitConverter.Catalog;
    using UnitConverter.Length;
    using UnitConverter.Temperature;

    public sealed class UnitConverterCatalogTests
    {
        [Test]
        public void FamilyEnum_PreservesOriginalNumericValues()
        {
            Assert.That((int)UnitConverterFamily.Length, Is.EqualTo(0));
            Assert.That((int)UnitConverterFamily.FuelEconomy, Is.EqualTo(21));
            Assert.That((int)UnitConverterFamily.ActivityConcentration, Is.EqualTo(22));
            Assert.That((int)UnitConverterFamily.Yank, Is.EqualTo(96));
            Assert.That((int)UnitConverterFamily.TemperatureDelta, Is.EqualTo(97));
        }

        [Test]
        public void Catalog_HasDescriptorForEveryFamilyEnumValue()
        {
            UnitConverterFamilyDescriptor[] descriptors = UnitConverterCatalog.GetFamilies();
            Array enumValues = Enum.GetValues(typeof(UnitConverterFamily));

            Assert.That(descriptors.Length, Is.EqualTo(98));
            Assert.That(descriptors.Length, Is.EqualTo(enumValues.Length));

            foreach (UnitConverterFamily family in enumValues)
            {
                UnitConverterFamilyDescriptor descriptor;
                Assert.That(UnitConverterCatalog.TryGetFamily(family, out descriptor), Is.True, family.ToString());
                Assert.That(descriptor, Is.Not.Null);
                Assert.That(descriptor.Family, Is.EqualTo(family));
            }
        }

        [Test]
        public void Catalog_EveryFamilyHasBaseUnitPresentInItsUnitEnum()
        {
            foreach (UnitConverterFamilyDescriptor descriptor in UnitConverterCatalog.GetFamilies())
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
            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                Assert.That(family.UnitType.IsEnum, Is.True, family.Name);
                Assert.That(family.Units.Count, Is.GreaterThan(0), family.Name);

                foreach (UnitConverterUnitDescriptor unit in family.Units)
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
        public void Catalog_ExposesStandardsAndLegacyProvenanceStates()
        {
            UnitConverterFamilyDescriptor length =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.Length);
            UnitConverterUnitDescriptor meter =
                length.Units.First(unit => unit.Name == "Meter");

            Assert.That(
                meter.Provenance.Status,
                Is.EqualTo(UnitConverterProvenanceStatus.StandardsReferenced));
            Assert.That(meter.Provenance.HasAuthoritativeReference, Is.True);

            UnitConverterFamilyDescriptor yank =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.Yank);
            UnitConverterUnitDescriptor yankBase = yank.Units.First();

            Assert.That(
                yankBase.Provenance.Status,
                Is.EqualTo(UnitConverterProvenanceStatus.LegacyMigrated));
            Assert.That(yankBase.Provenance.HasAuthoritativeReference, Is.False);
        }

        [Test]
        public void Catalog_FundamentalConstantUnitsReferenceCodata()
        {
            UnitConverterFamilyDescriptor temperature =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.Temperature);
            UnitConverterUnitDescriptor planckTemperature =
                temperature.Units.First(unit => unit.Name == "PlanckTemperature");

            Assert.That(
                planckTemperature.Provenance.Status,
                Is.EqualTo(UnitConverterProvenanceStatus.FundamentalConstantReferenced));
            Assert.That(
                planckTemperature.Provenance.Sources.Any(source => source.Id == "codata-2022"),
                Is.True);
        }

        [Test]
        public void Catalog_ResolvesFamilyNamesCaseInsensitively()
        {
            UnitConverterFamilyDescriptor descriptor;

            Assert.That(UnitConverterCatalog.TryGetFamily("length", out descriptor), Is.True);
            Assert.That(descriptor.Family, Is.EqualTo(UnitConverterFamily.Length));
        }

        [Test]
        public void Catalog_ProvidesTypedLengthDescriptor()
        {
            UnitConverterFamilyDescriptor<UnitConverterLengthUnit> descriptor;

            Assert.That(UnitConverterCatalog.TryGetFamily(out descriptor), Is.True);
            Assert.That(descriptor.Family, Is.EqualTo(UnitConverterFamily.Length));
            Assert.That(descriptor.BaseUnitName, Is.EqualTo("Meter"));
        }

        [Test]
        public void Aliases_AreExplicitAndSupportIrregularForms()
        {
            UnitConverterFamilyDescriptor<UnitConverterLengthUnit> length;
            Assert.That(UnitConverterCatalog.TryGetFamily(out length), Is.True);

            UnitConverterLengthUnit lengthUnit;
            Assert.That(length.TryResolveUnit("feet", out lengthUnit), Is.True);
            Assert.That(lengthUnit, Is.EqualTo(UnitConverterLengthUnit.Foot));

            UnitConverterFamilyDescriptor<UnitConverterTemperatureUnit> temperature;
            Assert.That(UnitConverterCatalog.TryGetFamily(out temperature), Is.True);

            UnitConverterTemperatureUnit temperatureUnit;
            Assert.That(temperature.TryResolveUnit("degrees celsius", out temperatureUnit), Is.True);
            Assert.That(temperatureUnit, Is.EqualTo(UnitConverterTemperatureUnit.Celsius));
        }

        [Test]
        public void Aliases_DoNotGuessUnknownPlurals()
        {
            UnitConverterFamilyDescriptor<UnitConverterLengthUnit> descriptor;
            Assert.That(UnitConverterCatalog.TryGetFamily(out descriptor), Is.True);

            UnitConverterLengthUnit unit;
            Assert.That(descriptor.TryResolveUnit("smoots", out unit), Is.False);
        }
    }
}
