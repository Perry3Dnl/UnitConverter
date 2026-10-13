namespace UnitTools.MolarMass
{
    using UnitTools.MolarMass.Metric;
    using UnitTools.MolarMass.Imperial;

    public enum UnitToolsMolarMassUnit
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

    public static class UnitToolsMolarMass
    {
        public static double Convert(double value, UnitToolsMolarMassUnit from, UnitToolsMolarMassUnit to)
        {
            double baseValue = ToKilogramPerMole(value, from);
            return FromKilogramPerMole(baseValue, to);
        }

        public static double ToKilogramPerMole(double value, UnitToolsMolarMassUnit from)
        {
            switch (from)
            {
                case UnitToolsMolarMassUnit.KilogramPerMole:
                    return UnitToolsMetricMolarMass.KilogramPerMoleToKilogramPerMole(value);
                case UnitToolsMolarMassUnit.GramPerMole:
                    return UnitToolsMetricMolarMass.GramPerMoleToKilogramPerMole(value);
                case UnitToolsMolarMassUnit.MilligramPerMole:
                    return UnitToolsMetricMolarMass.MilligramPerMoleToKilogramPerMole(value);
                case UnitToolsMolarMassUnit.KilogramPerKilomole:
                    return UnitToolsMetricMolarMass.KilogramPerKilomoleToKilogramPerMole(value);
                case UnitToolsMolarMassUnit.PoundPerPoundMole:
                    return UnitToolsImperialMolarMass.PoundPerPoundMoleToKilogramPerMole(value);
                case UnitToolsMolarMassUnit.MicrogramPerMole:
                    return UnitToolsMetricMolarMass.MicrogramPerMoleToKilogramPerMole(value);
                case UnitToolsMolarMassUnit.NanogramPerMole:
                    return UnitToolsMetricMolarMass.NanogramPerMoleToKilogramPerMole(value);
                case UnitToolsMolarMassUnit.KilogramPerMillimole:
                    return UnitToolsMetricMolarMass.KilogramPerMillimoleToKilogramPerMole(value);
                case UnitToolsMolarMassUnit.GramPerKilomole:
                    return UnitToolsMetricMolarMass.GramPerKilomoleToKilogramPerMole(value);
                case UnitToolsMolarMassUnit.OuncePerMole:
                    return UnitToolsImperialMolarMass.OuncePerMoleToKilogramPerMole(value);
                case UnitToolsMolarMassUnit.PoundPerMole:
                    return UnitToolsImperialMolarMass.PoundPerMoleToKilogramPerMole(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported molar mass unit.");
            }
        }

        public static double FromKilogramPerMole(double baseValue, UnitToolsMolarMassUnit to)
        {
            switch (to)
            {
                case UnitToolsMolarMassUnit.KilogramPerMole:
                    return UnitToolsMetricMolarMass.KilogramPerMoleToKilogramPerMole(baseValue);
                case UnitToolsMolarMassUnit.GramPerMole:
                    return UnitToolsMetricMolarMass.KilogramPerMoleToGramPerMole(baseValue);
                case UnitToolsMolarMassUnit.MilligramPerMole:
                    return UnitToolsMetricMolarMass.KilogramPerMoleToMilligramPerMole(baseValue);
                case UnitToolsMolarMassUnit.KilogramPerKilomole:
                    return UnitToolsMetricMolarMass.KilogramPerMoleToKilogramPerKilomole(baseValue);
                case UnitToolsMolarMassUnit.PoundPerPoundMole:
                    return UnitToolsImperialMolarMass.KilogramPerMoleToPoundPerPoundMole(baseValue);
                case UnitToolsMolarMassUnit.MicrogramPerMole:
                    return UnitToolsMetricMolarMass.KilogramPerMoleToMicrogramPerMole(baseValue);
                case UnitToolsMolarMassUnit.NanogramPerMole:
                    return UnitToolsMetricMolarMass.KilogramPerMoleToNanogramPerMole(baseValue);
                case UnitToolsMolarMassUnit.KilogramPerMillimole:
                    return UnitToolsMetricMolarMass.KilogramPerMoleToKilogramPerMillimole(baseValue);
                case UnitToolsMolarMassUnit.GramPerKilomole:
                    return UnitToolsMetricMolarMass.KilogramPerMoleToGramPerKilomole(baseValue);
                case UnitToolsMolarMassUnit.OuncePerMole:
                    return UnitToolsImperialMolarMass.KilogramPerMoleToOuncePerMole(baseValue);
                case UnitToolsMolarMassUnit.PoundPerMole:
                    return UnitToolsImperialMolarMass.KilogramPerMoleToPoundPerMole(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported molar mass unit.");
            }
        }

        public static string GetSymbol(UnitToolsMolarMassUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMolarMassUnit.KilogramPerMole:
                    return "kg/mol";
                case UnitToolsMolarMassUnit.GramPerMole:
                    return "g/mol";
                case UnitToolsMolarMassUnit.MilligramPerMole:
                    return "mg/mol";
                case UnitToolsMolarMassUnit.KilogramPerKilomole:
                    return "kg/kmol";
                case UnitToolsMolarMassUnit.PoundPerPoundMole:
                    return "lb/lbmol";
                case UnitToolsMolarMassUnit.MicrogramPerMole:
                    return "µg/mol";
                case UnitToolsMolarMassUnit.NanogramPerMole:
                    return "ng/mol";
                case UnitToolsMolarMassUnit.KilogramPerMillimole:
                    return "kg/mmol";
                case UnitToolsMolarMassUnit.GramPerKilomole:
                    return "g/kmol";
                case UnitToolsMolarMassUnit.OuncePerMole:
                    return "oz/mol";
                case UnitToolsMolarMassUnit.PoundPerMole:
                    return "lb/mol";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsMolarMassUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMolarMassUnit.KilogramPerMole:
                    return "Kilogram Per Mole";
                case UnitToolsMolarMassUnit.GramPerMole:
                    return "Gram Per Mole";
                case UnitToolsMolarMassUnit.MilligramPerMole:
                    return "Milligram Per Mole";
                case UnitToolsMolarMassUnit.KilogramPerKilomole:
                    return "Kilogram Per Kilomole";
                case UnitToolsMolarMassUnit.PoundPerPoundMole:
                    return "Pound Per Pound Mole";
                case UnitToolsMolarMassUnit.MicrogramPerMole:
                    return "Microgram Per Mole";
                case UnitToolsMolarMassUnit.NanogramPerMole:
                    return "Nanogram Per Mole";
                case UnitToolsMolarMassUnit.KilogramPerMillimole:
                    return "Kilogram Per Millimole";
                case UnitToolsMolarMassUnit.GramPerKilomole:
                    return "Gram Per Kilomole";
                case UnitToolsMolarMassUnit.OuncePerMole:
                    return "Ounce Per Mole";
                case UnitToolsMolarMassUnit.PoundPerMole:
                    return "Pound Per Mole";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsMolarMassUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMolarMassUnit.KilogramPerMole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarMassUnit.GramPerMole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarMassUnit.MilligramPerMole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarMassUnit.KilogramPerKilomole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarMassUnit.PoundPerPoundMole:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMolarMassUnit.MicrogramPerMole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarMassUnit.NanogramPerMole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarMassUnit.KilogramPerMillimole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarMassUnit.GramPerKilomole:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMolarMassUnit.OuncePerMole:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMolarMassUnit.PoundPerMole:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsMolarMassUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsMolarMassUnit.KilogramPerMole, UnitToolsMolarMassUnit.GramPerMole, UnitToolsMolarMassUnit.MilligramPerMole, UnitToolsMolarMassUnit.KilogramPerKilomole, UnitToolsMolarMassUnit.MicrogramPerMole, UnitToolsMolarMassUnit.NanogramPerMole, UnitToolsMolarMassUnit.KilogramPerMillimole, UnitToolsMolarMassUnit.GramPerKilomole };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsMolarMassUnit.PoundPerPoundMole, UnitToolsMolarMassUnit.OuncePerMole, UnitToolsMolarMassUnit.PoundPerMole };
                default:
                    return new[] { UnitToolsMolarMassUnit.KilogramPerMole, UnitToolsMolarMassUnit.GramPerMole, UnitToolsMolarMassUnit.MilligramPerMole, UnitToolsMolarMassUnit.KilogramPerKilomole, UnitToolsMolarMassUnit.PoundPerPoundMole, UnitToolsMolarMassUnit.MicrogramPerMole, UnitToolsMolarMassUnit.NanogramPerMole, UnitToolsMolarMassUnit.KilogramPerMillimole, UnitToolsMolarMassUnit.GramPerKilomole, UnitToolsMolarMassUnit.OuncePerMole, UnitToolsMolarMassUnit.PoundPerMole };
            }
        }
    }
}
