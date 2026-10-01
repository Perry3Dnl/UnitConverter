namespace RealisticPhysics.UnitConversion.MolarMass
{
    using RealisticPhysics.UnitConversion.MolarMass.Metric;
    using RealisticPhysics.UnitConversion.MolarMass.Imperial;

    public enum UnitConverterMolarMassUnit
    {
        KilogramPerMole = 0,
        GramPerMole = 1,
        MilligramPerMole = 2,
        KilogramPerKilomole = 3,
        PoundPerPoundMole = 4,
        MicrogramPerMole = 5,
        NanogramPerMole = 6,
        KilogramPerMillimole = 7,
        GramPerKilomole = 8,
        OuncePerMole = 9,
        PoundPerMole = 10,
    }

    public static class UnitConverterMolarMass
    {
        public static double Convert(double value, UnitConverterMolarMassUnit from, UnitConverterMolarMassUnit to)
        {
            double baseValue = ToKilogramPerMole(value, from);
            return FromKilogramPerMole(baseValue, to);
        }

        public static double ToKilogramPerMole(double value, UnitConverterMolarMassUnit from)
        {
            switch (from)
            {
                case UnitConverterMolarMassUnit.KilogramPerMole:
                    return UnitConverterMetricMolarMass.KilogramPerMoleToKilogramPerMole(value);
                case UnitConverterMolarMassUnit.GramPerMole:
                    return UnitConverterMetricMolarMass.GramPerMoleToKilogramPerMole(value);
                case UnitConverterMolarMassUnit.MilligramPerMole:
                    return UnitConverterMetricMolarMass.MilligramPerMoleToKilogramPerMole(value);
                case UnitConverterMolarMassUnit.KilogramPerKilomole:
                    return UnitConverterMetricMolarMass.KilogramPerKilomoleToKilogramPerMole(value);
                case UnitConverterMolarMassUnit.PoundPerPoundMole:
                    return UnitConverterImperialMolarMass.PoundPerPoundMoleToKilogramPerMole(value);
                case UnitConverterMolarMassUnit.MicrogramPerMole:
                    return UnitConverterMetricMolarMass.MicrogramPerMoleToKilogramPerMole(value);
                case UnitConverterMolarMassUnit.NanogramPerMole:
                    return UnitConverterMetricMolarMass.NanogramPerMoleToKilogramPerMole(value);
                case UnitConverterMolarMassUnit.KilogramPerMillimole:
                    return UnitConverterMetricMolarMass.KilogramPerMillimoleToKilogramPerMole(value);
                case UnitConverterMolarMassUnit.GramPerKilomole:
                    return UnitConverterMetricMolarMass.GramPerKilomoleToKilogramPerMole(value);
                case UnitConverterMolarMassUnit.OuncePerMole:
                    return UnitConverterImperialMolarMass.OuncePerMoleToKilogramPerMole(value);
                case UnitConverterMolarMassUnit.PoundPerMole:
                    return UnitConverterImperialMolarMass.PoundPerMoleToKilogramPerMole(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported molar mass unit.");
            }
        }

        public static double FromKilogramPerMole(double baseValue, UnitConverterMolarMassUnit to)
        {
            switch (to)
            {
                case UnitConverterMolarMassUnit.KilogramPerMole:
                    return UnitConverterMetricMolarMass.KilogramPerMoleToKilogramPerMole(baseValue);
                case UnitConverterMolarMassUnit.GramPerMole:
                    return UnitConverterMetricMolarMass.KilogramPerMoleToGramPerMole(baseValue);
                case UnitConverterMolarMassUnit.MilligramPerMole:
                    return UnitConverterMetricMolarMass.KilogramPerMoleToMilligramPerMole(baseValue);
                case UnitConverterMolarMassUnit.KilogramPerKilomole:
                    return UnitConverterMetricMolarMass.KilogramPerMoleToKilogramPerKilomole(baseValue);
                case UnitConverterMolarMassUnit.PoundPerPoundMole:
                    return UnitConverterImperialMolarMass.KilogramPerMoleToPoundPerPoundMole(baseValue);
                case UnitConverterMolarMassUnit.MicrogramPerMole:
                    return UnitConverterMetricMolarMass.KilogramPerMoleToMicrogramPerMole(baseValue);
                case UnitConverterMolarMassUnit.NanogramPerMole:
                    return UnitConverterMetricMolarMass.KilogramPerMoleToNanogramPerMole(baseValue);
                case UnitConverterMolarMassUnit.KilogramPerMillimole:
                    return UnitConverterMetricMolarMass.KilogramPerMoleToKilogramPerMillimole(baseValue);
                case UnitConverterMolarMassUnit.GramPerKilomole:
                    return UnitConverterMetricMolarMass.KilogramPerMoleToGramPerKilomole(baseValue);
                case UnitConverterMolarMassUnit.OuncePerMole:
                    return UnitConverterImperialMolarMass.KilogramPerMoleToOuncePerMole(baseValue);
                case UnitConverterMolarMassUnit.PoundPerMole:
                    return UnitConverterImperialMolarMass.KilogramPerMoleToPoundPerMole(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported molar mass unit.");
            }
        }

        public static string GetSymbol(UnitConverterMolarMassUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMolarMassUnit.KilogramPerMole:
                    return "kg/mol";
                case UnitConverterMolarMassUnit.GramPerMole:
                    return "g/mol";
                case UnitConverterMolarMassUnit.MilligramPerMole:
                    return "mg/mol";
                case UnitConverterMolarMassUnit.KilogramPerKilomole:
                    return "kg/kmol";
                case UnitConverterMolarMassUnit.PoundPerPoundMole:
                    return "lb/lbmol";
                case UnitConverterMolarMassUnit.MicrogramPerMole:
                    return "µg/mol";
                case UnitConverterMolarMassUnit.NanogramPerMole:
                    return "ng/mol";
                case UnitConverterMolarMassUnit.KilogramPerMillimole:
                    return "kg/mmol";
                case UnitConverterMolarMassUnit.GramPerKilomole:
                    return "g/kmol";
                case UnitConverterMolarMassUnit.OuncePerMole:
                    return "oz/mol";
                case UnitConverterMolarMassUnit.PoundPerMole:
                    return "lb/mol";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterMolarMassUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMolarMassUnit.KilogramPerMole:
                    return "Kilogram Per Mole";
                case UnitConverterMolarMassUnit.GramPerMole:
                    return "Gram Per Mole";
                case UnitConverterMolarMassUnit.MilligramPerMole:
                    return "Milligram Per Mole";
                case UnitConverterMolarMassUnit.KilogramPerKilomole:
                    return "Kilogram Per Kilomole";
                case UnitConverterMolarMassUnit.PoundPerPoundMole:
                    return "Pound Per Pound Mole";
                case UnitConverterMolarMassUnit.MicrogramPerMole:
                    return "Microgram Per Mole";
                case UnitConverterMolarMassUnit.NanogramPerMole:
                    return "Nanogram Per Mole";
                case UnitConverterMolarMassUnit.KilogramPerMillimole:
                    return "Kilogram Per Millimole";
                case UnitConverterMolarMassUnit.GramPerKilomole:
                    return "Gram Per Kilomole";
                case UnitConverterMolarMassUnit.OuncePerMole:
                    return "Ounce Per Mole";
                case UnitConverterMolarMassUnit.PoundPerMole:
                    return "Pound Per Mole";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterMolarMassUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMolarMassUnit.KilogramPerMole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarMassUnit.GramPerMole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarMassUnit.MilligramPerMole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarMassUnit.KilogramPerKilomole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarMassUnit.PoundPerPoundMole:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMolarMassUnit.MicrogramPerMole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarMassUnit.NanogramPerMole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarMassUnit.KilogramPerMillimole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarMassUnit.GramPerKilomole:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMolarMassUnit.OuncePerMole:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMolarMassUnit.PoundPerMole:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterMolarMassUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterMolarMassUnit.KilogramPerMole, UnitConverterMolarMassUnit.GramPerMole, UnitConverterMolarMassUnit.MilligramPerMole, UnitConverterMolarMassUnit.KilogramPerKilomole, UnitConverterMolarMassUnit.MicrogramPerMole, UnitConverterMolarMassUnit.NanogramPerMole, UnitConverterMolarMassUnit.KilogramPerMillimole, UnitConverterMolarMassUnit.GramPerKilomole };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterMolarMassUnit.PoundPerPoundMole, UnitConverterMolarMassUnit.OuncePerMole, UnitConverterMolarMassUnit.PoundPerMole };
                default:
                    return new[] { UnitConverterMolarMassUnit.KilogramPerMole, UnitConverterMolarMassUnit.GramPerMole, UnitConverterMolarMassUnit.MilligramPerMole, UnitConverterMolarMassUnit.KilogramPerKilomole, UnitConverterMolarMassUnit.PoundPerPoundMole, UnitConverterMolarMassUnit.MicrogramPerMole, UnitConverterMolarMassUnit.NanogramPerMole, UnitConverterMolarMassUnit.KilogramPerMillimole, UnitConverterMolarMassUnit.GramPerKilomole, UnitConverterMolarMassUnit.OuncePerMole, UnitConverterMolarMassUnit.PoundPerMole };
            }
        }
    }
}
