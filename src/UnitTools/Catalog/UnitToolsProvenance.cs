namespace UnitTools.Catalog
{
    using System;
    using System.Collections.Generic;

    public enum UnitToolsProvenanceStatus
    {
        LegacyMigrated = 0,
        StandardsReferenced = 1,
        FundamentalConstantReferenced = 2,
        NominalDefinitionReferenced = 3,
    }

    public sealed class UnitToolsProvenanceSource
    {
        internal UnitToolsProvenanceSource(
            string id,
            string title,
            string organization,
            string reference)
        {
            Id = id;
            Title = title;
            Organization = organization;
            Reference = reference;
        }

        public string Id { get; }
        public string Title { get; }
        public string Organization { get; }
        public string Reference { get; }
    }

    public sealed class UnitToolsProvenance
    {
        internal UnitToolsProvenance(
            UnitToolsProvenanceStatus status,
            string note,
            UnitToolsProvenanceSource[] sources)
        {
            Status = status;
            Note = note;
            UnitToolsProvenanceSource[] snapshot =
                sources == null
                    ? new UnitToolsProvenanceSource[0]
                    : (UnitToolsProvenanceSource[])sources.Clone();
            Sources = Array.AsReadOnly(snapshot);
        }

        public UnitToolsProvenanceStatus Status { get; }
        public string Note { get; }
        public IReadOnlyList<UnitToolsProvenanceSource> Sources { get; }
        public bool HasAuthoritativeReference =>
            Status != UnitToolsProvenanceStatus.LegacyMigrated &&
            Sources.Count > 0;
    }

    internal static class UnitToolsProvenanceCatalog
    {
        private static readonly UnitToolsProvenanceSource LegacySource =
            new UnitToolsProvenanceSource(
                "legacy-1.1.3",
                "UnitTools 1.1.3 conversion core",
                "UnitTools",
                "Repository import commit 332369313b1a428a66432e811c542562efa24e40");

        private static readonly UnitToolsProvenanceSource BipmSi =
            new UnitToolsProvenanceSource(
                "bipm-si-9",
                "The International System of Units (SI), 9th edition",
                "BIPM",
                "https://www.bipm.org/en/publications/si-brochure");

        private static readonly UnitToolsProvenanceSource NistSp811 =
            new UnitToolsProvenanceSource(
                "nist-sp811",
                "Guide for the Use of the International System of Units (SI), NIST SP 811",
                "NIST",
                "https://doi.org/10.6028/NIST.SP.811e2008");

        private static readonly UnitToolsProvenanceSource Codata2022 =
            new UnitToolsProvenanceSource(
                "codata-2022",
                "CODATA Recommended Values of the Fundamental Physical Constants: 2022",
                "CODATA / NIST",
                "https://physics.nist.gov/constants");

        private static readonly UnitToolsProvenanceSource Iau2015B3 =
            new UnitToolsProvenanceSource(
                "iau-2015-b3",
                "IAU 2015 Resolution B3: Nominal Solar and Planetary Conversion Constants",
                "International Astronomical Union",
                "https://www.iau.org/static/resolutions/IAU2015_English.pdf");

        public static UnitToolsProvenance Get(
            UnitToolsFamily family,
            string unitName)
        {
            if (UsesFundamentalConstants(family, unitName))
            {
                return new UnitToolsProvenance(
                    UnitToolsProvenanceStatus.FundamentalConstantReferenced,
                    "Reference set includes the current CODATA recommended fundamental constants. Individual numerical values should still be audited before claiming exactness.",
                    new[] { Codata2022, BipmSi });
            }

            if (UsesAstronomicalDefinitions(family, unitName))
            {
                return new UnitToolsProvenance(
                    UnitToolsProvenanceStatus.NominalDefinitionReferenced,
                    "Reference set includes IAU nominal conversion constants where applicable. This provenance record identifies the standard set; it does not assert that every astronomical unit in the family has completed a numerical audit.",
                    new[] { Iau2015B3, BipmSi });
            }

            if (IsStandardsBackedFamily(family))
            {
                return new UnitToolsProvenance(
                    UnitToolsProvenanceStatus.StandardsReferenced,
                    "Reference set for SI and commonly used non-SI conversion definitions. This marks the standards used for catalogue auditing; unaudited legacy factors remain subject to validation.",
                    new[] { BipmSi, NistSp811 });
            }

            return new UnitToolsProvenance(
                UnitToolsProvenanceStatus.LegacyMigrated,
                "Migrated from the UnitTools 1.1.3 conversion core. No authoritative external source has yet been attached to this unit.",
                new[] { LegacySource });
        }

        private static bool UsesFundamentalConstants(
            UnitToolsFamily family,
            string unitName)
        {
            if (family == UnitToolsFamily.Temperature ||
                family == UnitToolsFamily.TemperatureDelta ||
                family == UnitToolsFamily.Energy ||
                family == UnitToolsFamily.AngularMomentum)
            {
                return unitName.IndexOf("ElectronVolt", StringComparison.Ordinal) >= 0 ||
                    unitName.IndexOf("Planck", StringComparison.Ordinal) >= 0;
            }

            return unitName.IndexOf("Planck", StringComparison.Ordinal) >= 0;
        }

        private static bool UsesAstronomicalDefinitions(
            UnitToolsFamily family,
            string unitName)
        {
            if (family != UnitToolsFamily.Length &&
                family != UnitToolsFamily.Mass &&
                family != UnitToolsFamily.Power)
            {
                return false;
            }

            return unitName.IndexOf("Astronomical", StringComparison.Ordinal) >= 0 ||
                unitName.IndexOf("Solar", StringComparison.Ordinal) >= 0 ||
                unitName.IndexOf("Earth", StringComparison.Ordinal) >= 0 ||
                unitName.IndexOf("Jupiter", StringComparison.Ordinal) >= 0;
        }

        private static bool IsStandardsBackedFamily(UnitToolsFamily family)
        {
            switch (family)
            {
                case UnitToolsFamily.Length:
                case UnitToolsFamily.Area:
                case UnitToolsFamily.Volume:
                case UnitToolsFamily.Mass:
                case UnitToolsFamily.Time:
                case UnitToolsFamily.Temperature:
                case UnitToolsFamily.TemperatureDelta:
                case UnitToolsFamily.Angle:
                case UnitToolsFamily.Frequency:
                case UnitToolsFamily.Speed:
                case UnitToolsFamily.Acceleration:
                case UnitToolsFamily.Force:
                case UnitToolsFamily.Pressure:
                case UnitToolsFamily.Energy:
                case UnitToolsFamily.Power:
                case UnitToolsFamily.ElectricCharge:
                case UnitToolsFamily.Current:
                case UnitToolsFamily.Voltage:
                case UnitToolsFamily.ElectricResistance:
                case UnitToolsFamily.Capacitance:
                case UnitToolsFamily.Inductance:
                case UnitToolsFamily.Conductance:
                case UnitToolsFamily.MagneticFlux:
                case UnitToolsFamily.MagneticField:
                case UnitToolsFamily.AmountOfSubstance:
                case UnitToolsFamily.LuminousIntensity:
                case UnitToolsFamily.LuminousFlux:
                case UnitToolsFamily.Illuminance:
                    return true;
                default:
                    return false;
            }
        }
    }
}
