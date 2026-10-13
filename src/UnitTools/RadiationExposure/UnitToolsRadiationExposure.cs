namespace UnitTools.RadiationExposure
{
    using UnitTools.RadiationExposure.Metric;
    using UnitTools.RadiationExposure.Historical;
    using UnitTools.RadiationExposure.Scientific;

    public enum UnitToolsRadiationExposureUnit
    {
        CoulombPerKilogram = 0,
        MillicoulombPerKilogram = 1,
        MicrocoulombPerKilogram = 2,
        Roentgen = 3,
        Milliroentgen = 4,
        NanocoulombPerKilogram = 5,
        PicocoulombPerKilogram = 6,
        Kiloroentgen = 7,
        Microroentgen = 8,
        Nanoroentgen = 9,
        Picoroentgen = 10,
        CoulombPerGram = 11,
        MicrocoulombPerGram = 12,
        StatcoulombPerGram = 13,
    }

    public static class UnitToolsRadiationExposure
    {
        public static double Convert(double value, UnitToolsRadiationExposureUnit from, UnitToolsRadiationExposureUnit to)
        {
            double baseValue = ToCoulombPerKilogram(value, from);
            return FromCoulombPerKilogram(baseValue, to);
        }

        public static double ToCoulombPerKilogram(double value, UnitToolsRadiationExposureUnit from)
        {
            switch (from)
            {
                case UnitToolsRadiationExposureUnit.CoulombPerKilogram:
                    return UnitToolsMetricRadiationExposure.CoulombPerKilogramToCoulombPerKilogram(value);
                case UnitToolsRadiationExposureUnit.MillicoulombPerKilogram:
                    return UnitToolsMetricRadiationExposure.MillicoulombPerKilogramToCoulombPerKilogram(value);
                case UnitToolsRadiationExposureUnit.MicrocoulombPerKilogram:
                    return UnitToolsMetricRadiationExposure.MicrocoulombPerKilogramToCoulombPerKilogram(value);
                case UnitToolsRadiationExposureUnit.Roentgen:
                    return UnitToolsHistoricalRadiationExposure.RoentgenToCoulombPerKilogram(value);
                case UnitToolsRadiationExposureUnit.Milliroentgen:
                    return UnitToolsHistoricalRadiationExposure.MilliroentgenToCoulombPerKilogram(value);
                case UnitToolsRadiationExposureUnit.NanocoulombPerKilogram:
                    return UnitToolsMetricRadiationExposure.NanocoulombPerKilogramToCoulombPerKilogram(value);
                case UnitToolsRadiationExposureUnit.PicocoulombPerKilogram:
                    return UnitToolsMetricRadiationExposure.PicocoulombPerKilogramToCoulombPerKilogram(value);
                case UnitToolsRadiationExposureUnit.Kiloroentgen:
                    return UnitToolsHistoricalRadiationExposure.KiloroentgenToCoulombPerKilogram(value);
                case UnitToolsRadiationExposureUnit.Microroentgen:
                    return UnitToolsHistoricalRadiationExposure.MicroroentgenToCoulombPerKilogram(value);
                case UnitToolsRadiationExposureUnit.Nanoroentgen:
                    return UnitToolsHistoricalRadiationExposure.NanoroentgenToCoulombPerKilogram(value);
                case UnitToolsRadiationExposureUnit.Picoroentgen:
                    return UnitToolsHistoricalRadiationExposure.PicoroentgenToCoulombPerKilogram(value);
                case UnitToolsRadiationExposureUnit.CoulombPerGram:
                    return UnitToolsMetricRadiationExposure.CoulombPerGramToCoulombPerKilogram(value);
                case UnitToolsRadiationExposureUnit.MicrocoulombPerGram:
                    return UnitToolsMetricRadiationExposure.MicrocoulombPerGramToCoulombPerKilogram(value);
                case UnitToolsRadiationExposureUnit.StatcoulombPerGram:
                    return UnitToolsScientificRadiationExposure.StatcoulombPerGramToCoulombPerKilogram(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported radiation exposure unit.");
            }
        }

        public static double FromCoulombPerKilogram(double baseValue, UnitToolsRadiationExposureUnit to)
        {
            switch (to)
            {
                case UnitToolsRadiationExposureUnit.CoulombPerKilogram:
                    return UnitToolsMetricRadiationExposure.CoulombPerKilogramToCoulombPerKilogram(baseValue);
                case UnitToolsRadiationExposureUnit.MillicoulombPerKilogram:
                    return UnitToolsMetricRadiationExposure.CoulombPerKilogramToMillicoulombPerKilogram(baseValue);
                case UnitToolsRadiationExposureUnit.MicrocoulombPerKilogram:
                    return UnitToolsMetricRadiationExposure.CoulombPerKilogramToMicrocoulombPerKilogram(baseValue);
                case UnitToolsRadiationExposureUnit.Roentgen:
                    return UnitToolsHistoricalRadiationExposure.CoulombPerKilogramToRoentgen(baseValue);
                case UnitToolsRadiationExposureUnit.Milliroentgen:
                    return UnitToolsHistoricalRadiationExposure.CoulombPerKilogramToMilliroentgen(baseValue);
                case UnitToolsRadiationExposureUnit.NanocoulombPerKilogram:
                    return UnitToolsMetricRadiationExposure.CoulombPerKilogramToNanocoulombPerKilogram(baseValue);
                case UnitToolsRadiationExposureUnit.PicocoulombPerKilogram:
                    return UnitToolsMetricRadiationExposure.CoulombPerKilogramToPicocoulombPerKilogram(baseValue);
                case UnitToolsRadiationExposureUnit.Kiloroentgen:
                    return UnitToolsHistoricalRadiationExposure.CoulombPerKilogramToKiloroentgen(baseValue);
                case UnitToolsRadiationExposureUnit.Microroentgen:
                    return UnitToolsHistoricalRadiationExposure.CoulombPerKilogramToMicroroentgen(baseValue);
                case UnitToolsRadiationExposureUnit.Nanoroentgen:
                    return UnitToolsHistoricalRadiationExposure.CoulombPerKilogramToNanoroentgen(baseValue);
                case UnitToolsRadiationExposureUnit.Picoroentgen:
                    return UnitToolsHistoricalRadiationExposure.CoulombPerKilogramToPicoroentgen(baseValue);
                case UnitToolsRadiationExposureUnit.CoulombPerGram:
                    return UnitToolsMetricRadiationExposure.CoulombPerKilogramToCoulombPerGram(baseValue);
                case UnitToolsRadiationExposureUnit.MicrocoulombPerGram:
                    return UnitToolsMetricRadiationExposure.CoulombPerKilogramToMicrocoulombPerGram(baseValue);
                case UnitToolsRadiationExposureUnit.StatcoulombPerGram:
                    return UnitToolsScientificRadiationExposure.CoulombPerKilogramToStatcoulombPerGram(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported radiation exposure unit.");
            }
        }

        public static string GetSymbol(UnitToolsRadiationExposureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsRadiationExposureUnit.CoulombPerKilogram:
                    return "C/kg";
                case UnitToolsRadiationExposureUnit.MillicoulombPerKilogram:
                    return "mC/kg";
                case UnitToolsRadiationExposureUnit.MicrocoulombPerKilogram:
                    return "µC/kg";
                case UnitToolsRadiationExposureUnit.Roentgen:
                    return "R";
                case UnitToolsRadiationExposureUnit.Milliroentgen:
                    return "mR";
                case UnitToolsRadiationExposureUnit.NanocoulombPerKilogram:
                    return "nC/kg";
                case UnitToolsRadiationExposureUnit.PicocoulombPerKilogram:
                    return "pC/kg";
                case UnitToolsRadiationExposureUnit.Kiloroentgen:
                    return "kR";
                case UnitToolsRadiationExposureUnit.Microroentgen:
                    return "µR";
                case UnitToolsRadiationExposureUnit.Nanoroentgen:
                    return "nR";
                case UnitToolsRadiationExposureUnit.Picoroentgen:
                    return "pR";
                case UnitToolsRadiationExposureUnit.CoulombPerGram:
                    return "C/g";
                case UnitToolsRadiationExposureUnit.MicrocoulombPerGram:
                    return "µC/g";
                case UnitToolsRadiationExposureUnit.StatcoulombPerGram:
                    return "statC/g";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsRadiationExposureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsRadiationExposureUnit.CoulombPerKilogram:
                    return "Coulomb Per Kilogram";
                case UnitToolsRadiationExposureUnit.MillicoulombPerKilogram:
                    return "Millicoulomb Per Kilogram";
                case UnitToolsRadiationExposureUnit.MicrocoulombPerKilogram:
                    return "Microcoulomb Per Kilogram";
                case UnitToolsRadiationExposureUnit.Roentgen:
                    return "Roentgen";
                case UnitToolsRadiationExposureUnit.Milliroentgen:
                    return "Milliroentgen";
                case UnitToolsRadiationExposureUnit.NanocoulombPerKilogram:
                    return "Nanocoulomb Per Kilogram";
                case UnitToolsRadiationExposureUnit.PicocoulombPerKilogram:
                    return "Picocoulomb Per Kilogram";
                case UnitToolsRadiationExposureUnit.Kiloroentgen:
                    return "Kiloroentgen";
                case UnitToolsRadiationExposureUnit.Microroentgen:
                    return "Microroentgen";
                case UnitToolsRadiationExposureUnit.Nanoroentgen:
                    return "Nanoroentgen";
                case UnitToolsRadiationExposureUnit.Picoroentgen:
                    return "Picoroentgen";
                case UnitToolsRadiationExposureUnit.CoulombPerGram:
                    return "Coulomb Per Gram";
                case UnitToolsRadiationExposureUnit.MicrocoulombPerGram:
                    return "Microcoulomb Per Gram";
                case UnitToolsRadiationExposureUnit.StatcoulombPerGram:
                    return "Statcoulomb Per Gram";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsRadiationExposureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsRadiationExposureUnit.CoulombPerKilogram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationExposureUnit.MillicoulombPerKilogram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationExposureUnit.MicrocoulombPerKilogram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationExposureUnit.Roentgen:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsRadiationExposureUnit.Milliroentgen:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsRadiationExposureUnit.NanocoulombPerKilogram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationExposureUnit.PicocoulombPerKilogram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationExposureUnit.Kiloroentgen:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsRadiationExposureUnit.Microroentgen:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsRadiationExposureUnit.Nanoroentgen:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsRadiationExposureUnit.Picoroentgen:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsRadiationExposureUnit.CoulombPerGram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationExposureUnit.MicrocoulombPerGram:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadiationExposureUnit.StatcoulombPerGram:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsRadiationExposureUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsRadiationExposureUnit.CoulombPerKilogram, UnitToolsRadiationExposureUnit.MillicoulombPerKilogram, UnitToolsRadiationExposureUnit.MicrocoulombPerKilogram, UnitToolsRadiationExposureUnit.NanocoulombPerKilogram, UnitToolsRadiationExposureUnit.PicocoulombPerKilogram, UnitToolsRadiationExposureUnit.CoulombPerGram, UnitToolsRadiationExposureUnit.MicrocoulombPerGram };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsRadiationExposureUnit.Roentgen, UnitToolsRadiationExposureUnit.Milliroentgen, UnitToolsRadiationExposureUnit.Kiloroentgen, UnitToolsRadiationExposureUnit.Microroentgen, UnitToolsRadiationExposureUnit.Nanoroentgen, UnitToolsRadiationExposureUnit.Picoroentgen };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsRadiationExposureUnit.StatcoulombPerGram };
                default:
                    return new[] { UnitToolsRadiationExposureUnit.CoulombPerKilogram, UnitToolsRadiationExposureUnit.MillicoulombPerKilogram, UnitToolsRadiationExposureUnit.MicrocoulombPerKilogram, UnitToolsRadiationExposureUnit.Roentgen, UnitToolsRadiationExposureUnit.Milliroentgen, UnitToolsRadiationExposureUnit.NanocoulombPerKilogram, UnitToolsRadiationExposureUnit.PicocoulombPerKilogram, UnitToolsRadiationExposureUnit.Kiloroentgen, UnitToolsRadiationExposureUnit.Microroentgen, UnitToolsRadiationExposureUnit.Nanoroentgen, UnitToolsRadiationExposureUnit.Picoroentgen, UnitToolsRadiationExposureUnit.CoulombPerGram, UnitToolsRadiationExposureUnit.MicrocoulombPerGram, UnitToolsRadiationExposureUnit.StatcoulombPerGram };
            }
        }
    }
}
