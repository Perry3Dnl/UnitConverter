namespace UnitTools.ExposureRate
{
    using UnitTools.ExposureRate.Metric;
    using UnitTools.ExposureRate.Historical;

    public enum UnitToolsExposureRateUnit
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

    public static class UnitToolsExposureRate
    {
        public static double Convert(double value, UnitToolsExposureRateUnit from, UnitToolsExposureRateUnit to)
        {
            double baseValue = ToCoulombPerKilogramSecond(value, from);
            return FromCoulombPerKilogramSecond(baseValue, to);
        }

        public static double ToCoulombPerKilogramSecond(double value, UnitToolsExposureRateUnit from)
        {
            switch (from)
            {
                case UnitToolsExposureRateUnit.CoulombPerKilogramSecond:
                    return UnitToolsMetricExposureRate.CoulombPerKilogramSecondToCoulombPerKilogramSecond(value);
                case UnitToolsExposureRateUnit.MillicoulombPerKilogramSecond:
                    return UnitToolsMetricExposureRate.MillicoulombPerKilogramSecondToCoulombPerKilogramSecond(value);
                case UnitToolsExposureRateUnit.RoentgenPerSecond:
                    return UnitToolsHistoricalExposureRate.RoentgenPerSecondToCoulombPerKilogramSecond(value);
                case UnitToolsExposureRateUnit.RoentgenPerHour:
                    return UnitToolsHistoricalExposureRate.RoentgenPerHourToCoulombPerKilogramSecond(value);
                case UnitToolsExposureRateUnit.MilliroentgenPerHour:
                    return UnitToolsHistoricalExposureRate.MilliroentgenPerHourToCoulombPerKilogramSecond(value);
                case UnitToolsExposureRateUnit.MicrocoulombPerKilogramSecond:
                    return UnitToolsMetricExposureRate.MicrocoulombPerKilogramSecondToCoulombPerKilogramSecond(value);
                case UnitToolsExposureRateUnit.CoulombPerKilogramHour:
                    return UnitToolsMetricExposureRate.CoulombPerKilogramHourToCoulombPerKilogramSecond(value);
                case UnitToolsExposureRateUnit.MicrocoulombPerKilogramHour:
                    return UnitToolsMetricExposureRate.MicrocoulombPerKilogramHourToCoulombPerKilogramSecond(value);
                case UnitToolsExposureRateUnit.MicroroentgenPerHour:
                    return UnitToolsHistoricalExposureRate.MicroroentgenPerHourToCoulombPerKilogramSecond(value);
                case UnitToolsExposureRateUnit.RoentgenPerMinute:
                    return UnitToolsHistoricalExposureRate.RoentgenPerMinuteToCoulombPerKilogramSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported exposure rate unit.");
            }
        }

        public static double FromCoulombPerKilogramSecond(double baseValue, UnitToolsExposureRateUnit to)
        {
            switch (to)
            {
                case UnitToolsExposureRateUnit.CoulombPerKilogramSecond:
                    return UnitToolsMetricExposureRate.CoulombPerKilogramSecondToCoulombPerKilogramSecond(baseValue);
                case UnitToolsExposureRateUnit.MillicoulombPerKilogramSecond:
                    return UnitToolsMetricExposureRate.CoulombPerKilogramSecondToMillicoulombPerKilogramSecond(baseValue);
                case UnitToolsExposureRateUnit.RoentgenPerSecond:
                    return UnitToolsHistoricalExposureRate.CoulombPerKilogramSecondToRoentgenPerSecond(baseValue);
                case UnitToolsExposureRateUnit.RoentgenPerHour:
                    return UnitToolsHistoricalExposureRate.CoulombPerKilogramSecondToRoentgenPerHour(baseValue);
                case UnitToolsExposureRateUnit.MilliroentgenPerHour:
                    return UnitToolsHistoricalExposureRate.CoulombPerKilogramSecondToMilliroentgenPerHour(baseValue);
                case UnitToolsExposureRateUnit.MicrocoulombPerKilogramSecond:
                    return UnitToolsMetricExposureRate.CoulombPerKilogramSecondToMicrocoulombPerKilogramSecond(baseValue);
                case UnitToolsExposureRateUnit.CoulombPerKilogramHour:
                    return UnitToolsMetricExposureRate.CoulombPerKilogramSecondToCoulombPerKilogramHour(baseValue);
                case UnitToolsExposureRateUnit.MicrocoulombPerKilogramHour:
                    return UnitToolsMetricExposureRate.CoulombPerKilogramSecondToMicrocoulombPerKilogramHour(baseValue);
                case UnitToolsExposureRateUnit.MicroroentgenPerHour:
                    return UnitToolsHistoricalExposureRate.CoulombPerKilogramSecondToMicroroentgenPerHour(baseValue);
                case UnitToolsExposureRateUnit.RoentgenPerMinute:
                    return UnitToolsHistoricalExposureRate.CoulombPerKilogramSecondToRoentgenPerMinute(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported exposure rate unit.");
            }
        }

        public static string GetSymbol(UnitToolsExposureRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsExposureRateUnit.CoulombPerKilogramSecond:
                    return "C/(kg·s)";
                case UnitToolsExposureRateUnit.MillicoulombPerKilogramSecond:
                    return "mC/(kg·s)";
                case UnitToolsExposureRateUnit.RoentgenPerSecond:
                    return "R/s";
                case UnitToolsExposureRateUnit.RoentgenPerHour:
                    return "R/h";
                case UnitToolsExposureRateUnit.MilliroentgenPerHour:
                    return "mR/h";
                case UnitToolsExposureRateUnit.MicrocoulombPerKilogramSecond:
                    return "µC/(kg·s)";
                case UnitToolsExposureRateUnit.CoulombPerKilogramHour:
                    return "C/(kg·h)";
                case UnitToolsExposureRateUnit.MicrocoulombPerKilogramHour:
                    return "µC/(kg·h)";
                case UnitToolsExposureRateUnit.MicroroentgenPerHour:
                    return "µR/h";
                case UnitToolsExposureRateUnit.RoentgenPerMinute:
                    return "R/min";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsExposureRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsExposureRateUnit.CoulombPerKilogramSecond:
                    return "Coulomb Per Kilogram Second";
                case UnitToolsExposureRateUnit.MillicoulombPerKilogramSecond:
                    return "Millicoulomb Per Kilogram Second";
                case UnitToolsExposureRateUnit.RoentgenPerSecond:
                    return "Roentgen Per Second";
                case UnitToolsExposureRateUnit.RoentgenPerHour:
                    return "Roentgen Per Hour";
                case UnitToolsExposureRateUnit.MilliroentgenPerHour:
                    return "Milliroentgen Per Hour";
                case UnitToolsExposureRateUnit.MicrocoulombPerKilogramSecond:
                    return "Microcoulomb Per Kilogram Second";
                case UnitToolsExposureRateUnit.CoulombPerKilogramHour:
                    return "Coulomb Per Kilogram Hour";
                case UnitToolsExposureRateUnit.MicrocoulombPerKilogramHour:
                    return "Microcoulomb Per Kilogram Hour";
                case UnitToolsExposureRateUnit.MicroroentgenPerHour:
                    return "Microroentgen Per Hour";
                case UnitToolsExposureRateUnit.RoentgenPerMinute:
                    return "Roentgen Per Minute";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsExposureRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsExposureRateUnit.CoulombPerKilogramSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsExposureRateUnit.MillicoulombPerKilogramSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsExposureRateUnit.RoentgenPerSecond:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsExposureRateUnit.RoentgenPerHour:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsExposureRateUnit.MilliroentgenPerHour:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsExposureRateUnit.MicrocoulombPerKilogramSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsExposureRateUnit.CoulombPerKilogramHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsExposureRateUnit.MicrocoulombPerKilogramHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsExposureRateUnit.MicroroentgenPerHour:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsExposureRateUnit.RoentgenPerMinute:
                    return UnitToolsUnitSystem.Historical;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsExposureRateUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsExposureRateUnit.CoulombPerKilogramSecond, UnitToolsExposureRateUnit.MillicoulombPerKilogramSecond, UnitToolsExposureRateUnit.MicrocoulombPerKilogramSecond, UnitToolsExposureRateUnit.CoulombPerKilogramHour, UnitToolsExposureRateUnit.MicrocoulombPerKilogramHour };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsExposureRateUnit.RoentgenPerSecond, UnitToolsExposureRateUnit.RoentgenPerHour, UnitToolsExposureRateUnit.MilliroentgenPerHour, UnitToolsExposureRateUnit.MicroroentgenPerHour, UnitToolsExposureRateUnit.RoentgenPerMinute };
                default:
                    return new[] { UnitToolsExposureRateUnit.CoulombPerKilogramSecond, UnitToolsExposureRateUnit.MillicoulombPerKilogramSecond, UnitToolsExposureRateUnit.RoentgenPerSecond, UnitToolsExposureRateUnit.RoentgenPerHour, UnitToolsExposureRateUnit.MilliroentgenPerHour, UnitToolsExposureRateUnit.MicrocoulombPerKilogramSecond, UnitToolsExposureRateUnit.CoulombPerKilogramHour, UnitToolsExposureRateUnit.MicrocoulombPerKilogramHour, UnitToolsExposureRateUnit.MicroroentgenPerHour, UnitToolsExposureRateUnit.RoentgenPerMinute };
            }
        }
    }
}
