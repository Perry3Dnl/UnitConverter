namespace UnitConverter.Catalog
{
    using System;
    using System.Collections.Generic;

    public enum UnitConverterProvenanceStatus
    {
        LegacyMigrated = 0,
        StandardsReferenced = 1,
        FundamentalConstantReferenced = 2,
        NominalDefinitionReferenced = 3,
    }

    public sealed class UnitConverterProvenanceSource
    {
        internal UnitConverterProvenanceSource(
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

    public sealed class UnitConverterProvenance
    {
        internal UnitConverterProvenance(
            UnitConverterProvenanceStatus status,
            string note,
            UnitConverterProvenanceSource[] sources)
        {
            Status = status;
            Note = note;
            Sources = sources ?? new UnitConverterProvenanceSource[0];
        }

        public UnitConverterProvenanceStatus Status { get; }
        public string Note { get; }
        public IReadOnlyList<UnitConverterProvenanceSource> Sources { get; }
        public bool HasAuthoritativeReference =>
            Status != UnitConverterProvenanceStatus.LegacyMigrated &&
            Sources.Count > 0;
    }

    internal static class UnitConverterProvenanceCatalog
    {
        private static readonly UnitConverterProvenanceSource LegacySource =
            new UnitConverterProvenanceSource(
                "legacy-1.1.3",
                "UnitConverter 1.1.3 conversion core",
                "UnitConverter",
                "Repository import commit 332369313b1a428a66432e811c542562efa24e40");

        private static readonly UnitConverterProvenanceSource BipmSi =
            new UnitConverterProvenanceSource(
                "bipm-si-9",
                "The International System of Units (SI), 9th edition",
                "BIPM",
                "https://www.bipm.org/en/publications/si-brochure");

        private static readonly UnitConverterProvenanceSource NistSp811 =
            new UnitConverterProvenanceSource(
                "nist-sp811",
                "Guide for the Use of the International System of Units (SI), NIST SP 811",
                "NIST",
                "https://doi.org/10.6028/NIST.SP.811e2008");

        private static readonly UnitConverterProvenanceSource Codata2022 =
            new UnitConverterProvenanceSource(
                "codata-2022",
                "CODATA Recommended Values of the Fundamental Physical Constants: 2022",
                "CODATA / NIST",
                "https://physics.nist.gov/constants");

        private static readonly UnitConverterProvenanceSource Iau2015B3 =
            new UnitConverterProvenanceSource(
                "iau-2015-b3",
                "IAU 2015 Resolution B3: Nominal Solar and Planetary Conversion Constants",
                "International Astronomical Union",
                "https://www.iau.org/static/resolutions/IAU2015_English.pdf");

        public static UnitConverterProvenance Get(
            UnitConverterFamily family,
            string unitName)
        {
            if (UsesFundamentalConstants(family, unitName))
            {
                return new UnitConverterProvenance(
                    UnitConverterProvenanceStatus.FundamentalConstantReferenced,
                    "Reference set includes the current CODATA recommended fundamental constants. Individual numerical values should still be audited before claiming exactness.",
                    new[] { Codata2022, BipmSi });
            }

            if (UsesAstronomicalDefinitions(family, unitName))
            {
                return new UnitConverterProvenance(
                    UnitConverterProvenanceStatus.NominalDefinitionReferenced,
                    "Reference set includes IAU nominal conversion constants where applicable. This provenance record identifies the standard set; it does not assert that every astronomical unit in the family has completed a numerical audit.",
                    new[] { Iau2015B3, BipmSi });
            }

            if (IsStandardsBackedFamily(family))
            {
                return new UnitConverterProvenance(
                    UnitConverterProvenanceStatus.StandardsReferenced,
                    "Reference set for SI and commonly used non-SI conversion definitions. This marks the standards used for catalogue auditing; unaudited legacy factors remain subject to validation.",
                    new[] { BipmSi, NistSp811 });
            }

            return new UnitConverterProvenance(
                UnitConverterProvenanceStatus.LegacyMigrated,
                "Migrated from the UnitConverter 1.1.3 conversion core. No authoritative external source has yet been attached to this unit.",
                new[] { LegacySource });
        }

        private static bool UsesFundamentalConstants(
            UnitConverterFamily family,
            string unitName)
        {
            if (family == UnitConverterFamily.Temperature ||
                family == UnitConverterFamily.TemperatureDelta ||
                family == UnitConverterFamily.Energy ||
                family == UnitConverterFamily.AngularMomentum)
            {
                return unitName.IndexOf("ElectronVolt", StringComparison.Ordinal) >= 0 ||
                    unitName.IndexOf("Planck", StringComparison.Ordinal) >= 0;
            }

            return unitName.IndexOf("Planck", StringComparison.Ordinal) >= 0;
        }

        private static bool UsesAstronomicalDefinitions(
            UnitConverterFamily family,
            string unitName)
        {
            if (family != UnitConverterFamily.Length &&
                family != UnitConverterFamily.Mass &&
                family != UnitConverterFamily.Power)
            {
                return false;
            }

            return unitName.IndexOf("Astronomical", StringComparison.Ordinal) >= 0 ||
                unitName.IndexOf("Solar", StringComparison.Ordinal) >= 0 ||
                unitName.IndexOf("Earth", StringComparison.Ordinal) >= 0 ||
                unitName.IndexOf("Jupiter", StringComparison.Ordinal) >= 0;
        }

        private static bool IsStandardsBackedFamily(UnitConverterFamily family)
        {
            switch (family)
            {
                case UnitConverterFamily.Length:
                case UnitConverterFamily.Area:
                case UnitConverterFamily.Volume:
                case UnitConverterFamily.Mass:
                case UnitConverterFamily.Time:
                case UnitConverterFamily.Temperature:
                case UnitConverterFamily.TemperatureDelta:
                case UnitConverterFamily.Angle:
                case UnitConverterFamily.Frequency:
                case UnitConverterFamily.Speed:
                case UnitConverterFamily.Acceleration:
                case UnitConverterFamily.Force:
                case UnitConverterFamily.Pressure:
                case UnitConverterFamily.Energy:
                case UnitConverterFamily.Power:
                case UnitConverterFamily.ElectricCharge:
                case UnitConverterFamily.Current:
                case UnitConverterFamily.Voltage:
                case UnitConverterFamily.ElectricResistance:
                case UnitConverterFamily.Capacitance:
                case UnitConverterFamily.Inductance:
                case UnitConverterFamily.Conductance:
                case UnitConverterFamily.MagneticFlux:
                case UnitConverterFamily.MagneticField:
                case UnitConverterFamily.AmountOfSubstance:
                case UnitConverterFamily.LuminousIntensity:
                case UnitConverterFamily.LuminousFlux:
                case UnitConverterFamily.Illuminance:
                    return true;
                default:
                    return false;
            }
        }
    }
}
