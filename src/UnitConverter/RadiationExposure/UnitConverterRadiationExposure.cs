namespace UnitConverter.RadiationExposure
{
    using UnitConverter.RadiationExposure.Metric;
    using UnitConverter.RadiationExposure.Historical;
    using UnitConverter.RadiationExposure.Scientific;

    public enum UnitConverterRadiationExposureUnit
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

    public static class UnitConverterRadiationExposure
    {
        public static double Convert(double value, UnitConverterRadiationExposureUnit from, UnitConverterRadiationExposureUnit to)
        {
            double baseValue = ToCoulombPerKilogram(value, from);
            return FromCoulombPerKilogram(baseValue, to);
        }

        public static double ToCoulombPerKilogram(double value, UnitConverterRadiationExposureUnit from)
        {
            switch (from)
            {
                case UnitConverterRadiationExposureUnit.CoulombPerKilogram:
                    return UnitConverterMetricRadiationExposure.CoulombPerKilogramToCoulombPerKilogram(value);
                case UnitConverterRadiationExposureUnit.MillicoulombPerKilogram:
                    return UnitConverterMetricRadiationExposure.MillicoulombPerKilogramToCoulombPerKilogram(value);
                case UnitConverterRadiationExposureUnit.MicrocoulombPerKilogram:
                    return UnitConverterMetricRadiationExposure.MicrocoulombPerKilogramToCoulombPerKilogram(value);
                case UnitConverterRadiationExposureUnit.Roentgen:
                    return UnitConverterHistoricalRadiationExposure.RoentgenToCoulombPerKilogram(value);
                case UnitConverterRadiationExposureUnit.Milliroentgen:
                    return UnitConverterHistoricalRadiationExposure.MilliroentgenToCoulombPerKilogram(value);
                case UnitConverterRadiationExposureUnit.NanocoulombPerKilogram:
                    return UnitConverterMetricRadiationExposure.NanocoulombPerKilogramToCoulombPerKilogram(value);
                case UnitConverterRadiationExposureUnit.PicocoulombPerKilogram:
                    return UnitConverterMetricRadiationExposure.PicocoulombPerKilogramToCoulombPerKilogram(value);
                case UnitConverterRadiationExposureUnit.Kiloroentgen:
                    return UnitConverterHistoricalRadiationExposure.KiloroentgenToCoulombPerKilogram(value);
                case UnitConverterRadiationExposureUnit.Microroentgen:
                    return UnitConverterHistoricalRadiationExposure.MicroroentgenToCoulombPerKilogram(value);
                case UnitConverterRadiationExposureUnit.Nanoroentgen:
                    return UnitConverterHistoricalRadiationExposure.NanoroentgenToCoulombPerKilogram(value);
                case UnitConverterRadiationExposureUnit.Picoroentgen:
                    return UnitConverterHistoricalRadiationExposure.PicoroentgenToCoulombPerKilogram(value);
                case UnitConverterRadiationExposureUnit.CoulombPerGram:
                    return UnitConverterMetricRadiationExposure.CoulombPerGramToCoulombPerKilogram(value);
                case UnitConverterRadiationExposureUnit.MicrocoulombPerGram:
                    return UnitConverterMetricRadiationExposure.MicrocoulombPerGramToCoulombPerKilogram(value);
                case UnitConverterRadiationExposureUnit.StatcoulombPerGram:
                    return UnitConverterScientificRadiationExposure.StatcoulombPerGramToCoulombPerKilogram(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported radiation exposure unit.");
            }
        }

        public static double FromCoulombPerKilogram(double baseValue, UnitConverterRadiationExposureUnit to)
        {
            switch (to)
            {
                case UnitConverterRadiationExposureUnit.CoulombPerKilogram:
                    return UnitConverterMetricRadiationExposure.CoulombPerKilogramToCoulombPerKilogram(baseValue);
                case UnitConverterRadiationExposureUnit.MillicoulombPerKilogram:
                    return UnitConverterMetricRadiationExposure.CoulombPerKilogramToMillicoulombPerKilogram(baseValue);
                case UnitConverterRadiationExposureUnit.MicrocoulombPerKilogram:
                    return UnitConverterMetricRadiationExposure.CoulombPerKilogramToMicrocoulombPerKilogram(baseValue);
                case UnitConverterRadiationExposureUnit.Roentgen:
                    return UnitConverterHistoricalRadiationExposure.CoulombPerKilogramToRoentgen(baseValue);
                case UnitConverterRadiationExposureUnit.Milliroentgen:
                    return UnitConverterHistoricalRadiationExposure.CoulombPerKilogramToMilliroentgen(baseValue);
                case UnitConverterRadiationExposureUnit.NanocoulombPerKilogram:
                    return UnitConverterMetricRadiationExposure.CoulombPerKilogramToNanocoulombPerKilogram(baseValue);
                case UnitConverterRadiationExposureUnit.PicocoulombPerKilogram:
                    return UnitConverterMetricRadiationExposure.CoulombPerKilogramToPicocoulombPerKilogram(baseValue);
                case UnitConverterRadiationExposureUnit.Kiloroentgen:
                    return UnitConverterHistoricalRadiationExposure.CoulombPerKilogramToKiloroentgen(baseValue);
                case UnitConverterRadiationExposureUnit.Microroentgen:
                    return UnitConverterHistoricalRadiationExposure.CoulombPerKilogramToMicroroentgen(baseValue);
                case UnitConverterRadiationExposureUnit.Nanoroentgen:
                    return UnitConverterHistoricalRadiationExposure.CoulombPerKilogramToNanoroentgen(baseValue);
                case UnitConverterRadiationExposureUnit.Picoroentgen:
                    return UnitConverterHistoricalRadiationExposure.CoulombPerKilogramToPicoroentgen(baseValue);
                case UnitConverterRadiationExposureUnit.CoulombPerGram:
                    return UnitConverterMetricRadiationExposure.CoulombPerKilogramToCoulombPerGram(baseValue);
                case UnitConverterRadiationExposureUnit.MicrocoulombPerGram:
                    return UnitConverterMetricRadiationExposure.CoulombPerKilogramToMicrocoulombPerGram(baseValue);
                case UnitConverterRadiationExposureUnit.StatcoulombPerGram:
                    return UnitConverterScientificRadiationExposure.CoulombPerKilogramToStatcoulombPerGram(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported radiation exposure unit.");
            }
        }

        public static string GetSymbol(UnitConverterRadiationExposureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterRadiationExposureUnit.CoulombPerKilogram:
                    return "C/kg";
                case UnitConverterRadiationExposureUnit.MillicoulombPerKilogram:
                    return "mC/kg";
                case UnitConverterRadiationExposureUnit.MicrocoulombPerKilogram:
                    return "µC/kg";
                case UnitConverterRadiationExposureUnit.Roentgen:
                    return "R";
                case UnitConverterRadiationExposureUnit.Milliroentgen:
                    return "mR";
                case UnitConverterRadiationExposureUnit.NanocoulombPerKilogram:
                    return "nC/kg";
                case UnitConverterRadiationExposureUnit.PicocoulombPerKilogram:
                    return "pC/kg";
                case UnitConverterRadiationExposureUnit.Kiloroentgen:
                    return "kR";
                case UnitConverterRadiationExposureUnit.Microroentgen:
                    return "µR";
                case UnitConverterRadiationExposureUnit.Nanoroentgen:
                    return "nR";
                case UnitConverterRadiationExposureUnit.Picoroentgen:
                    return "pR";
                case UnitConverterRadiationExposureUnit.CoulombPerGram:
                    return "C/g";
                case UnitConverterRadiationExposureUnit.MicrocoulombPerGram:
                    return "µC/g";
                case UnitConverterRadiationExposureUnit.StatcoulombPerGram:
                    return "statC/g";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterRadiationExposureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterRadiationExposureUnit.CoulombPerKilogram:
                    return "Coulomb Per Kilogram";
                case UnitConverterRadiationExposureUnit.MillicoulombPerKilogram:
                    return "Millicoulomb Per Kilogram";
                case UnitConverterRadiationExposureUnit.MicrocoulombPerKilogram:
                    return "Microcoulomb Per Kilogram";
                case UnitConverterRadiationExposureUnit.Roentgen:
                    return "Roentgen";
                case UnitConverterRadiationExposureUnit.Milliroentgen:
                    return "Milliroentgen";
                case UnitConverterRadiationExposureUnit.NanocoulombPerKilogram:
                    return "Nanocoulomb Per Kilogram";
                case UnitConverterRadiationExposureUnit.PicocoulombPerKilogram:
                    return "Picocoulomb Per Kilogram";
                case UnitConverterRadiationExposureUnit.Kiloroentgen:
                    return "Kiloroentgen";
                case UnitConverterRadiationExposureUnit.Microroentgen:
                    return "Microroentgen";
                case UnitConverterRadiationExposureUnit.Nanoroentgen:
                    return "Nanoroentgen";
                case UnitConverterRadiationExposureUnit.Picoroentgen:
                    return "Picoroentgen";
                case UnitConverterRadiationExposureUnit.CoulombPerGram:
                    return "Coulomb Per Gram";
                case UnitConverterRadiationExposureUnit.MicrocoulombPerGram:
                    return "Microcoulomb Per Gram";
                case UnitConverterRadiationExposureUnit.StatcoulombPerGram:
                    return "Statcoulomb Per Gram";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterRadiationExposureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterRadiationExposureUnit.CoulombPerKilogram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationExposureUnit.MillicoulombPerKilogram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationExposureUnit.MicrocoulombPerKilogram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationExposureUnit.Roentgen:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterRadiationExposureUnit.Milliroentgen:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterRadiationExposureUnit.NanocoulombPerKilogram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationExposureUnit.PicocoulombPerKilogram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationExposureUnit.Kiloroentgen:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterRadiationExposureUnit.Microroentgen:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterRadiationExposureUnit.Nanoroentgen:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterRadiationExposureUnit.Picoroentgen:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterRadiationExposureUnit.CoulombPerGram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationExposureUnit.MicrocoulombPerGram:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadiationExposureUnit.StatcoulombPerGram:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterRadiationExposureUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterRadiationExposureUnit.CoulombPerKilogram, UnitConverterRadiationExposureUnit.MillicoulombPerKilogram, UnitConverterRadiationExposureUnit.MicrocoulombPerKilogram, UnitConverterRadiationExposureUnit.NanocoulombPerKilogram, UnitConverterRadiationExposureUnit.PicocoulombPerKilogram, UnitConverterRadiationExposureUnit.CoulombPerGram, UnitConverterRadiationExposureUnit.MicrocoulombPerGram };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterRadiationExposureUnit.Roentgen, UnitConverterRadiationExposureUnit.Milliroentgen, UnitConverterRadiationExposureUnit.Kiloroentgen, UnitConverterRadiationExposureUnit.Microroentgen, UnitConverterRadiationExposureUnit.Nanoroentgen, UnitConverterRadiationExposureUnit.Picoroentgen };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterRadiationExposureUnit.StatcoulombPerGram };
                default:
                    return new[] { UnitConverterRadiationExposureUnit.CoulombPerKilogram, UnitConverterRadiationExposureUnit.MillicoulombPerKilogram, UnitConverterRadiationExposureUnit.MicrocoulombPerKilogram, UnitConverterRadiationExposureUnit.Roentgen, UnitConverterRadiationExposureUnit.Milliroentgen, UnitConverterRadiationExposureUnit.NanocoulombPerKilogram, UnitConverterRadiationExposureUnit.PicocoulombPerKilogram, UnitConverterRadiationExposureUnit.Kiloroentgen, UnitConverterRadiationExposureUnit.Microroentgen, UnitConverterRadiationExposureUnit.Nanoroentgen, UnitConverterRadiationExposureUnit.Picoroentgen, UnitConverterRadiationExposureUnit.CoulombPerGram, UnitConverterRadiationExposureUnit.MicrocoulombPerGram, UnitConverterRadiationExposureUnit.StatcoulombPerGram };
            }
        }
    }
}
