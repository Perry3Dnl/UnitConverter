namespace UnitTools.AmountOfSubstance
{
    using UnitTools.AmountOfSubstance.Metric;
    using UnitTools.AmountOfSubstance.Imperial;
    using UnitTools.AmountOfSubstance.Scientific;

    public enum UnitToolsAmountOfSubstanceUnit
    {
        Mole = 0,
        Millimole = 1,
        Micromole = 2,
        Nanomole = 3,
        Kilomole = 4,
        PoundMole = 5,
        Particle = 6,
        Molecule = 7,
        Centimole = 8,
        Decimole = 9,
        Picomole = 10,
        Femtomole = 11,
        InternationalUnitMoleApprox = 12,
    }

    public static class UnitToolsAmountOfSubstance
    {
        public static double Convert(double value, UnitToolsAmountOfSubstanceUnit from, UnitToolsAmountOfSubstanceUnit to)
        {
            double baseValue = ToMole(value, from);
            return FromMole(baseValue, to);
        }

        public static double ToMole(double value, UnitToolsAmountOfSubstanceUnit from)
        {
            switch (from)
            {
                case UnitToolsAmountOfSubstanceUnit.Mole:
                    return UnitToolsMetricAmountOfSubstance.MoleToMole(value);
                case UnitToolsAmountOfSubstanceUnit.Millimole:
                    return UnitToolsMetricAmountOfSubstance.MillimoleToMole(value);
                case UnitToolsAmountOfSubstanceUnit.Micromole:
                    return UnitToolsMetricAmountOfSubstance.MicromoleToMole(value);
                case UnitToolsAmountOfSubstanceUnit.Nanomole:
                    return UnitToolsMetricAmountOfSubstance.NanomoleToMole(value);
                case UnitToolsAmountOfSubstanceUnit.Kilomole:
                    return UnitToolsMetricAmountOfSubstance.KilomoleToMole(value);
                case UnitToolsAmountOfSubstanceUnit.PoundMole:
                    return UnitToolsImperialAmountOfSubstance.PoundMoleToMole(value);
                case UnitToolsAmountOfSubstanceUnit.Particle:
                    return UnitToolsScientificAmountOfSubstance.ParticleToMole(value);
                case UnitToolsAmountOfSubstanceUnit.Molecule:
                    return UnitToolsScientificAmountOfSubstance.MoleculeToMole(value);
                case UnitToolsAmountOfSubstanceUnit.Centimole:
                    return UnitToolsMetricAmountOfSubstance.CentimoleToMole(value);
                case UnitToolsAmountOfSubstanceUnit.Decimole:
                    return UnitToolsMetricAmountOfSubstance.DecimoleToMole(value);
                case UnitToolsAmountOfSubstanceUnit.Picomole:
                    return UnitToolsMetricAmountOfSubstance.PicomoleToMole(value);
                case UnitToolsAmountOfSubstanceUnit.Femtomole:
                    return UnitToolsMetricAmountOfSubstance.FemtomoleToMole(value);
                case UnitToolsAmountOfSubstanceUnit.InternationalUnitMoleApprox:
                    return UnitToolsScientificAmountOfSubstance.InternationalUnitMoleApproxToMole(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported amount of substance unit.");
            }
        }

        public static double FromMole(double baseValue, UnitToolsAmountOfSubstanceUnit to)
        {
            switch (to)
            {
                case UnitToolsAmountOfSubstanceUnit.Mole:
                    return UnitToolsMetricAmountOfSubstance.MoleToMole(baseValue);
                case UnitToolsAmountOfSubstanceUnit.Millimole:
                    return UnitToolsMetricAmountOfSubstance.MoleToMillimole(baseValue);
                case UnitToolsAmountOfSubstanceUnit.Micromole:
                    return UnitToolsMetricAmountOfSubstance.MoleToMicromole(baseValue);
                case UnitToolsAmountOfSubstanceUnit.Nanomole:
                    return UnitToolsMetricAmountOfSubstance.MoleToNanomole(baseValue);
                case UnitToolsAmountOfSubstanceUnit.Kilomole:
                    return UnitToolsMetricAmountOfSubstance.MoleToKilomole(baseValue);
                case UnitToolsAmountOfSubstanceUnit.PoundMole:
                    return UnitToolsImperialAmountOfSubstance.MoleToPoundMole(baseValue);
                case UnitToolsAmountOfSubstanceUnit.Particle:
                    return UnitToolsScientificAmountOfSubstance.MoleToParticle(baseValue);
                case UnitToolsAmountOfSubstanceUnit.Molecule:
                    return UnitToolsScientificAmountOfSubstance.MoleToMolecule(baseValue);
                case UnitToolsAmountOfSubstanceUnit.Centimole:
                    return UnitToolsMetricAmountOfSubstance.MoleToCentimole(baseValue);
                case UnitToolsAmountOfSubstanceUnit.Decimole:
                    return UnitToolsMetricAmountOfSubstance.MoleToDecimole(baseValue);
                case UnitToolsAmountOfSubstanceUnit.Picomole:
                    return UnitToolsMetricAmountOfSubstance.MoleToPicomole(baseValue);
                case UnitToolsAmountOfSubstanceUnit.Femtomole:
                    return UnitToolsMetricAmountOfSubstance.MoleToFemtomole(baseValue);
                case UnitToolsAmountOfSubstanceUnit.InternationalUnitMoleApprox:
                    return UnitToolsScientificAmountOfSubstance.MoleToInternationalUnitMoleApprox(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported amount of substance unit.");
            }
        }

        public static string GetSymbol(UnitToolsAmountOfSubstanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAmountOfSubstanceUnit.Mole:
                    return "mol";
                case UnitToolsAmountOfSubstanceUnit.Millimole:
                    return "mmol";
                case UnitToolsAmountOfSubstanceUnit.Micromole:
                    return "µmol";
                case UnitToolsAmountOfSubstanceUnit.Nanomole:
                    return "nmol";
                case UnitToolsAmountOfSubstanceUnit.Kilomole:
                    return "kmol";
                case UnitToolsAmountOfSubstanceUnit.PoundMole:
                    return "lbmol";
                case UnitToolsAmountOfSubstanceUnit.Particle:
                    return "particle";
                case UnitToolsAmountOfSubstanceUnit.Molecule:
                    return "molecule";
                case UnitToolsAmountOfSubstanceUnit.Centimole:
                    return "cmol";
                case UnitToolsAmountOfSubstanceUnit.Decimole:
                    return "dmol";
                case UnitToolsAmountOfSubstanceUnit.Picomole:
                    return "pmol";
                case UnitToolsAmountOfSubstanceUnit.Femtomole:
                    return "fmol";
                case UnitToolsAmountOfSubstanceUnit.InternationalUnitMoleApprox:
                    return "IU mol approx";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsAmountOfSubstanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAmountOfSubstanceUnit.Mole:
                    return "Mole";
                case UnitToolsAmountOfSubstanceUnit.Millimole:
                    return "Millimole";
                case UnitToolsAmountOfSubstanceUnit.Micromole:
                    return "Micromole";
                case UnitToolsAmountOfSubstanceUnit.Nanomole:
                    return "Nanomole";
                case UnitToolsAmountOfSubstanceUnit.Kilomole:
                    return "Kilomole";
                case UnitToolsAmountOfSubstanceUnit.PoundMole:
                    return "Pound Mole";
                case UnitToolsAmountOfSubstanceUnit.Particle:
                    return "Particle";
                case UnitToolsAmountOfSubstanceUnit.Molecule:
                    return "Molecule";
                case UnitToolsAmountOfSubstanceUnit.Centimole:
                    return "Centimole";
                case UnitToolsAmountOfSubstanceUnit.Decimole:
                    return "Decimole";
                case UnitToolsAmountOfSubstanceUnit.Picomole:
                    return "Picomole";
                case UnitToolsAmountOfSubstanceUnit.Femtomole:
                    return "Femtomole";
                case UnitToolsAmountOfSubstanceUnit.InternationalUnitMoleApprox:
                    return "International Unit Mole Approx";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsAmountOfSubstanceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAmountOfSubstanceUnit.Mole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAmountOfSubstanceUnit.Millimole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAmountOfSubstanceUnit.Micromole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAmountOfSubstanceUnit.Nanomole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAmountOfSubstanceUnit.Kilomole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAmountOfSubstanceUnit.PoundMole:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAmountOfSubstanceUnit.Particle:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAmountOfSubstanceUnit.Molecule:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAmountOfSubstanceUnit.Centimole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAmountOfSubstanceUnit.Decimole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAmountOfSubstanceUnit.Picomole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAmountOfSubstanceUnit.Femtomole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAmountOfSubstanceUnit.InternationalUnitMoleApprox:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsAmountOfSubstanceUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsAmountOfSubstanceUnit.Mole, UnitToolsAmountOfSubstanceUnit.Millimole, UnitToolsAmountOfSubstanceUnit.Micromole, UnitToolsAmountOfSubstanceUnit.Nanomole, UnitToolsAmountOfSubstanceUnit.Kilomole, UnitToolsAmountOfSubstanceUnit.Centimole, UnitToolsAmountOfSubstanceUnit.Decimole, UnitToolsAmountOfSubstanceUnit.Picomole, UnitToolsAmountOfSubstanceUnit.Femtomole };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsAmountOfSubstanceUnit.PoundMole };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsAmountOfSubstanceUnit.Particle, UnitToolsAmountOfSubstanceUnit.Molecule, UnitToolsAmountOfSubstanceUnit.InternationalUnitMoleApprox };
                default:
                    return new[] { UnitToolsAmountOfSubstanceUnit.Mole, UnitToolsAmountOfSubstanceUnit.Millimole, UnitToolsAmountOfSubstanceUnit.Micromole, UnitToolsAmountOfSubstanceUnit.Nanomole, UnitToolsAmountOfSubstanceUnit.Kilomole, UnitToolsAmountOfSubstanceUnit.PoundMole, UnitToolsAmountOfSubstanceUnit.Particle, UnitToolsAmountOfSubstanceUnit.Molecule, UnitToolsAmountOfSubstanceUnit.Centimole, UnitToolsAmountOfSubstanceUnit.Decimole, UnitToolsAmountOfSubstanceUnit.Picomole, UnitToolsAmountOfSubstanceUnit.Femtomole, UnitToolsAmountOfSubstanceUnit.InternationalUnitMoleApprox };
            }
        }
    }
}
