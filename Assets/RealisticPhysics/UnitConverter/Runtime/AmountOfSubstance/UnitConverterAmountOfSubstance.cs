namespace RealisticPhysics.UnitConversion.AmountOfSubstance
{
    using RealisticPhysics.UnitConversion.AmountOfSubstance.Metric;
    using RealisticPhysics.UnitConversion.AmountOfSubstance.Imperial;
    using RealisticPhysics.UnitConversion.AmountOfSubstance.Scientific;

    public enum UnitConverterAmountOfSubstanceUnit
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

    public static class UnitConverterAmountOfSubstance
    {
        public static double Convert(double value, UnitConverterAmountOfSubstanceUnit from, UnitConverterAmountOfSubstanceUnit to)
        {
            double baseValue = ToMole(value, from);
            return FromMole(baseValue, to);
        }

        public static double ToMole(double value, UnitConverterAmountOfSubstanceUnit from)
        {
            switch (from)
            {
                case UnitConverterAmountOfSubstanceUnit.Mole:
                    return UnitConverterMetricAmountOfSubstance.MoleToMole(value);
                case UnitConverterAmountOfSubstanceUnit.Millimole:
                    return UnitConverterMetricAmountOfSubstance.MillimoleToMole(value);
                case UnitConverterAmountOfSubstanceUnit.Micromole:
                    return UnitConverterMetricAmountOfSubstance.MicromoleToMole(value);
                case UnitConverterAmountOfSubstanceUnit.Nanomole:
                    return UnitConverterMetricAmountOfSubstance.NanomoleToMole(value);
                case UnitConverterAmountOfSubstanceUnit.Kilomole:
                    return UnitConverterMetricAmountOfSubstance.KilomoleToMole(value);
                case UnitConverterAmountOfSubstanceUnit.PoundMole:
                    return UnitConverterImperialAmountOfSubstance.PoundMoleToMole(value);
                case UnitConverterAmountOfSubstanceUnit.Particle:
                    return UnitConverterScientificAmountOfSubstance.ParticleToMole(value);
                case UnitConverterAmountOfSubstanceUnit.Molecule:
                    return UnitConverterScientificAmountOfSubstance.MoleculeToMole(value);
                case UnitConverterAmountOfSubstanceUnit.Centimole:
                    return UnitConverterMetricAmountOfSubstance.CentimoleToMole(value);
                case UnitConverterAmountOfSubstanceUnit.Decimole:
                    return UnitConverterMetricAmountOfSubstance.DecimoleToMole(value);
                case UnitConverterAmountOfSubstanceUnit.Picomole:
                    return UnitConverterMetricAmountOfSubstance.PicomoleToMole(value);
                case UnitConverterAmountOfSubstanceUnit.Femtomole:
                    return UnitConverterMetricAmountOfSubstance.FemtomoleToMole(value);
                case UnitConverterAmountOfSubstanceUnit.InternationalUnitMoleApprox:
                    return UnitConverterScientificAmountOfSubstance.InternationalUnitMoleApproxToMole(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported amount of substance unit.");
            }
        }

        public static double FromMole(double baseValue, UnitConverterAmountOfSubstanceUnit to)
        {
            switch (to)
            {
                case UnitConverterAmountOfSubstanceUnit.Mole:
                    return UnitConverterMetricAmountOfSubstance.MoleToMole(baseValue);
                case UnitConverterAmountOfSubstanceUnit.Millimole:
                    return UnitConverterMetricAmountOfSubstance.MoleToMillimole(baseValue);
                case UnitConverterAmountOfSubstanceUnit.Micromole:
                    return UnitConverterMetricAmountOfSubstance.MoleToMicromole(baseValue);
                case UnitConverterAmountOfSubstanceUnit.Nanomole:
                    return UnitConverterMetricAmountOfSubstance.MoleToNanomole(baseValue);
                case UnitConverterAmountOfSubstanceUnit.Kilomole:
                    return UnitConverterMetricAmountOfSubstance.MoleToKilomole(baseValue);
                case UnitConverterAmountOfSubstanceUnit.PoundMole:
                    return UnitConverterImperialAmountOfSubstance.MoleToPoundMole(baseValue);
                case UnitConverterAmountOfSubstanceUnit.Particle:
                    return UnitConverterScientificAmountOfSubstance.MoleToParticle(baseValue);
                case UnitConverterAmountOfSubstanceUnit.Molecule:
                    return UnitConverterScientificAmountOfSubstance.MoleToMolecule(baseValue);
                case UnitConverterAmountOfSubstanceUnit.Centimole:
                    return UnitConverterMetricAmountOfSubstance.MoleToCentimole(baseValue);
                case UnitConverterAmountOfSubstanceUnit.Decimole:
                    return UnitConverterMetricAmountOfSubstance.MoleToDecimole(baseValue);
                case UnitConverterAmountOfSubstanceUnit.Picomole:
                    return UnitConverterMetricAmountOfSubstance.MoleToPicomole(baseValue);
                case UnitConverterAmountOfSubstanceUnit.Femtomole:
                    return UnitConverterMetricAmountOfSubstance.MoleToFemtomole(baseValue);
                case UnitConverterAmountOfSubstanceUnit.InternationalUnitMoleApprox:
                    return UnitConverterScientificAmountOfSubstance.MoleToInternationalUnitMoleApprox(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported amount of substance unit.");
            }
        }

        public static string GetSymbol(UnitConverterAmountOfSubstanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAmountOfSubstanceUnit.Mole:
                    return "mol";
                case UnitConverterAmountOfSubstanceUnit.Millimole:
                    return "mmol";
                case UnitConverterAmountOfSubstanceUnit.Micromole:
                    return "µmol";
                case UnitConverterAmountOfSubstanceUnit.Nanomole:
                    return "nmol";
                case UnitConverterAmountOfSubstanceUnit.Kilomole:
                    return "kmol";
                case UnitConverterAmountOfSubstanceUnit.PoundMole:
                    return "lbmol";
                case UnitConverterAmountOfSubstanceUnit.Particle:
                    return "particle";
                case UnitConverterAmountOfSubstanceUnit.Molecule:
                    return "molecule";
                case UnitConverterAmountOfSubstanceUnit.Centimole:
                    return "cmol";
                case UnitConverterAmountOfSubstanceUnit.Decimole:
                    return "dmol";
                case UnitConverterAmountOfSubstanceUnit.Picomole:
                    return "pmol";
                case UnitConverterAmountOfSubstanceUnit.Femtomole:
                    return "fmol";
                case UnitConverterAmountOfSubstanceUnit.InternationalUnitMoleApprox:
                    return "IU mol approx";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterAmountOfSubstanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAmountOfSubstanceUnit.Mole:
                    return "Mole";
                case UnitConverterAmountOfSubstanceUnit.Millimole:
                    return "Millimole";
                case UnitConverterAmountOfSubstanceUnit.Micromole:
                    return "Micromole";
                case UnitConverterAmountOfSubstanceUnit.Nanomole:
                    return "Nanomole";
                case UnitConverterAmountOfSubstanceUnit.Kilomole:
                    return "Kilomole";
                case UnitConverterAmountOfSubstanceUnit.PoundMole:
                    return "Pound Mole";
                case UnitConverterAmountOfSubstanceUnit.Particle:
                    return "Particle";
                case UnitConverterAmountOfSubstanceUnit.Molecule:
                    return "Molecule";
                case UnitConverterAmountOfSubstanceUnit.Centimole:
                    return "Centimole";
                case UnitConverterAmountOfSubstanceUnit.Decimole:
                    return "Decimole";
                case UnitConverterAmountOfSubstanceUnit.Picomole:
                    return "Picomole";
                case UnitConverterAmountOfSubstanceUnit.Femtomole:
                    return "Femtomole";
                case UnitConverterAmountOfSubstanceUnit.InternationalUnitMoleApprox:
                    return "International Unit Mole Approx";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterAmountOfSubstanceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAmountOfSubstanceUnit.Mole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAmountOfSubstanceUnit.Millimole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAmountOfSubstanceUnit.Micromole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAmountOfSubstanceUnit.Nanomole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAmountOfSubstanceUnit.Kilomole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAmountOfSubstanceUnit.PoundMole:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAmountOfSubstanceUnit.Particle:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAmountOfSubstanceUnit.Molecule:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAmountOfSubstanceUnit.Centimole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAmountOfSubstanceUnit.Decimole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAmountOfSubstanceUnit.Picomole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAmountOfSubstanceUnit.Femtomole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAmountOfSubstanceUnit.InternationalUnitMoleApprox:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterAmountOfSubstanceUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterAmountOfSubstanceUnit.Mole, UnitConverterAmountOfSubstanceUnit.Millimole, UnitConverterAmountOfSubstanceUnit.Micromole, UnitConverterAmountOfSubstanceUnit.Nanomole, UnitConverterAmountOfSubstanceUnit.Kilomole, UnitConverterAmountOfSubstanceUnit.Centimole, UnitConverterAmountOfSubstanceUnit.Decimole, UnitConverterAmountOfSubstanceUnit.Picomole, UnitConverterAmountOfSubstanceUnit.Femtomole };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterAmountOfSubstanceUnit.PoundMole };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterAmountOfSubstanceUnit.Particle, UnitConverterAmountOfSubstanceUnit.Molecule, UnitConverterAmountOfSubstanceUnit.InternationalUnitMoleApprox };
                default:
                    return new[] { UnitConverterAmountOfSubstanceUnit.Mole, UnitConverterAmountOfSubstanceUnit.Millimole, UnitConverterAmountOfSubstanceUnit.Micromole, UnitConverterAmountOfSubstanceUnit.Nanomole, UnitConverterAmountOfSubstanceUnit.Kilomole, UnitConverterAmountOfSubstanceUnit.PoundMole, UnitConverterAmountOfSubstanceUnit.Particle, UnitConverterAmountOfSubstanceUnit.Molecule, UnitConverterAmountOfSubstanceUnit.Centimole, UnitConverterAmountOfSubstanceUnit.Decimole, UnitConverterAmountOfSubstanceUnit.Picomole, UnitConverterAmountOfSubstanceUnit.Femtomole, UnitConverterAmountOfSubstanceUnit.InternationalUnitMoleApprox };
            }
        }
    }
}
