namespace UnitConverter.ExposureRate
{
    using UnitConverter.ExposureRate.Metric;
    using UnitConverter.ExposureRate.Historical;

    public enum UnitConverterExposureRateUnit
    {
        CoulombPerKilogramSecond = 0,
        MillicoulombPerKilogramSecond = 1,
        RoentgenPerSecond = 2,
        RoentgenPerHour = 3,
        MilliroentgenPerHour = 4,
        MicrocoulombPerKilogramSecond = 5,
        CoulombPerKilogramHour = 6,
        MicrocoulombPerKilogramHour = 7,
        MicroroentgenPerHour = 8,
        RoentgenPerMinute = 9,
    }

    public static class UnitConverterExposureRate
    {
        public static double Convert(double value, UnitConverterExposureRateUnit from, UnitConverterExposureRateUnit to)
        {
            double baseValue = ToCoulombPerKilogramSecond(value, from);
            return FromCoulombPerKilogramSecond(baseValue, to);
        }

        public static double ToCoulombPerKilogramSecond(double value, UnitConverterExposureRateUnit from)
        {
            switch (from)
            {
                case UnitConverterExposureRateUnit.CoulombPerKilogramSecond:
                    return UnitConverterMetricExposureRate.CoulombPerKilogramSecondToCoulombPerKilogramSecond(value);
                case UnitConverterExposureRateUnit.MillicoulombPerKilogramSecond:
                    return UnitConverterMetricExposureRate.MillicoulombPerKilogramSecondToCoulombPerKilogramSecond(value);
                case UnitConverterExposureRateUnit.RoentgenPerSecond:
                    return UnitConverterHistoricalExposureRate.RoentgenPerSecondToCoulombPerKilogramSecond(value);
                case UnitConverterExposureRateUnit.RoentgenPerHour:
                    return UnitConverterHistoricalExposureRate.RoentgenPerHourToCoulombPerKilogramSecond(value);
                case UnitConverterExposureRateUnit.MilliroentgenPerHour:
                    return UnitConverterHistoricalExposureRate.MilliroentgenPerHourToCoulombPerKilogramSecond(value);
                case UnitConverterExposureRateUnit.MicrocoulombPerKilogramSecond:
                    return UnitConverterMetricExposureRate.MicrocoulombPerKilogramSecondToCoulombPerKilogramSecond(value);
                case UnitConverterExposureRateUnit.CoulombPerKilogramHour:
                    return UnitConverterMetricExposureRate.CoulombPerKilogramHourToCoulombPerKilogramSecond(value);
                case UnitConverterExposureRateUnit.MicrocoulombPerKilogramHour:
                    return UnitConverterMetricExposureRate.MicrocoulombPerKilogramHourToCoulombPerKilogramSecond(value);
                case UnitConverterExposureRateUnit.MicroroentgenPerHour:
                    return UnitConverterHistoricalExposureRate.MicroroentgenPerHourToCoulombPerKilogramSecond(value);
                case UnitConverterExposureRateUnit.RoentgenPerMinute:
                    return UnitConverterHistoricalExposureRate.RoentgenPerMinuteToCoulombPerKilogramSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported exposure rate unit.");
            }
        }

        public static double FromCoulombPerKilogramSecond(double baseValue, UnitConverterExposureRateUnit to)
        {
            switch (to)
            {
                case UnitConverterExposureRateUnit.CoulombPerKilogramSecond:
                    return UnitConverterMetricExposureRate.CoulombPerKilogramSecondToCoulombPerKilogramSecond(baseValue);
                case UnitConverterExposureRateUnit.MillicoulombPerKilogramSecond:
                    return UnitConverterMetricExposureRate.CoulombPerKilogramSecondToMillicoulombPerKilogramSecond(baseValue);
                case UnitConverterExposureRateUnit.RoentgenPerSecond:
                    return UnitConverterHistoricalExposureRate.CoulombPerKilogramSecondToRoentgenPerSecond(baseValue);
                case UnitConverterExposureRateUnit.RoentgenPerHour:
                    return UnitConverterHistoricalExposureRate.CoulombPerKilogramSecondToRoentgenPerHour(baseValue);
                case UnitConverterExposureRateUnit.MilliroentgenPerHour:
                    return UnitConverterHistoricalExposureRate.CoulombPerKilogramSecondToMilliroentgenPerHour(baseValue);
                case UnitConverterExposureRateUnit.MicrocoulombPerKilogramSecond:
                    return UnitConverterMetricExposureRate.CoulombPerKilogramSecondToMicrocoulombPerKilogramSecond(baseValue);
                case UnitConverterExposureRateUnit.CoulombPerKilogramHour:
                    return UnitConverterMetricExposureRate.CoulombPerKilogramSecondToCoulombPerKilogramHour(baseValue);
                case UnitConverterExposureRateUnit.MicrocoulombPerKilogramHour:
                    return UnitConverterMetricExposureRate.CoulombPerKilogramSecondToMicrocoulombPerKilogramHour(baseValue);
                case UnitConverterExposureRateUnit.MicroroentgenPerHour:
                    return UnitConverterHistoricalExposureRate.CoulombPerKilogramSecondToMicroroentgenPerHour(baseValue);
                case UnitConverterExposureRateUnit.RoentgenPerMinute:
                    return UnitConverterHistoricalExposureRate.CoulombPerKilogramSecondToRoentgenPerMinute(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported exposure rate unit.");
            }
        }

        public static string GetSymbol(UnitConverterExposureRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterExposureRateUnit.CoulombPerKilogramSecond:
                    return "C/(kg·s)";
                case UnitConverterExposureRateUnit.MillicoulombPerKilogramSecond:
                    return "mC/(kg·s)";
                case UnitConverterExposureRateUnit.RoentgenPerSecond:
                    return "R/s";
                case UnitConverterExposureRateUnit.RoentgenPerHour:
                    return "R/h";
                case UnitConverterExposureRateUnit.MilliroentgenPerHour:
                    return "mR/h";
                case UnitConverterExposureRateUnit.MicrocoulombPerKilogramSecond:
                    return "µC/(kg·s)";
                case UnitConverterExposureRateUnit.CoulombPerKilogramHour:
                    return "C/(kg·h)";
                case UnitConverterExposureRateUnit.MicrocoulombPerKilogramHour:
                    return "µC/(kg·h)";
                case UnitConverterExposureRateUnit.MicroroentgenPerHour:
                    return "µR/h";
                case UnitConverterExposureRateUnit.RoentgenPerMinute:
                    return "R/min";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterExposureRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterExposureRateUnit.CoulombPerKilogramSecond:
                    return "Coulomb Per Kilogram Second";
                case UnitConverterExposureRateUnit.MillicoulombPerKilogramSecond:
                    return "Millicoulomb Per Kilogram Second";
                case UnitConverterExposureRateUnit.RoentgenPerSecond:
                    return "Roentgen Per Second";
                case UnitConverterExposureRateUnit.RoentgenPerHour:
                    return "Roentgen Per Hour";
                case UnitConverterExposureRateUnit.MilliroentgenPerHour:
                    return "Milliroentgen Per Hour";
                case UnitConverterExposureRateUnit.MicrocoulombPerKilogramSecond:
                    return "Microcoulomb Per Kilogram Second";
                case UnitConverterExposureRateUnit.CoulombPerKilogramHour:
                    return "Coulomb Per Kilogram Hour";
                case UnitConverterExposureRateUnit.MicrocoulombPerKilogramHour:
                    return "Microcoulomb Per Kilogram Hour";
                case UnitConverterExposureRateUnit.MicroroentgenPerHour:
                    return "Microroentgen Per Hour";
                case UnitConverterExposureRateUnit.RoentgenPerMinute:
                    return "Roentgen Per Minute";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterExposureRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterExposureRateUnit.CoulombPerKilogramSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterExposureRateUnit.MillicoulombPerKilogramSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterExposureRateUnit.RoentgenPerSecond:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterExposureRateUnit.RoentgenPerHour:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterExposureRateUnit.MilliroentgenPerHour:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterExposureRateUnit.MicrocoulombPerKilogramSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterExposureRateUnit.CoulombPerKilogramHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterExposureRateUnit.MicrocoulombPerKilogramHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterExposureRateUnit.MicroroentgenPerHour:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterExposureRateUnit.RoentgenPerMinute:
                    return UnitConverterUnitSystem.Historical;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterExposureRateUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterExposureRateUnit.CoulombPerKilogramSecond, UnitConverterExposureRateUnit.MillicoulombPerKilogramSecond, UnitConverterExposureRateUnit.MicrocoulombPerKilogramSecond, UnitConverterExposureRateUnit.CoulombPerKilogramHour, UnitConverterExposureRateUnit.MicrocoulombPerKilogramHour };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterExposureRateUnit.RoentgenPerSecond, UnitConverterExposureRateUnit.RoentgenPerHour, UnitConverterExposureRateUnit.MilliroentgenPerHour, UnitConverterExposureRateUnit.MicroroentgenPerHour, UnitConverterExposureRateUnit.RoentgenPerMinute };
                default:
                    return new[] { UnitConverterExposureRateUnit.CoulombPerKilogramSecond, UnitConverterExposureRateUnit.MillicoulombPerKilogramSecond, UnitConverterExposureRateUnit.RoentgenPerSecond, UnitConverterExposureRateUnit.RoentgenPerHour, UnitConverterExposureRateUnit.MilliroentgenPerHour, UnitConverterExposureRateUnit.MicrocoulombPerKilogramSecond, UnitConverterExposureRateUnit.CoulombPerKilogramHour, UnitConverterExposureRateUnit.MicrocoulombPerKilogramHour, UnitConverterExposureRateUnit.MicroroentgenPerHour, UnitConverterExposureRateUnit.RoentgenPerMinute };
            }
        }
    }
}
