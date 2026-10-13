namespace UnitTools.ThermalDiffusivity
{
    using UnitTools.ThermalDiffusivity.Metric;
    using UnitTools.ThermalDiffusivity.Imperial;

    public enum UnitToolsThermalDiffusivityUnit
    {
        SquareMeterPerSecond = 0,
        SquareCentimeterPerSecond = 1,
        SquareMillimeterPerSecond = 2,
        SquareMeterPerHour = 3,
        SquareFootPerSecond = 4,
        SquareMeterPerMinute = 5,
        SquareMeterPerDay = 6,
        SquareCentimeterPerMinute = 7,
        SquareMillimeterPerMinute = 8,
        SquareFootPerMinute = 9,
        SquareInchPerMinute = 10,
    }

    public static class UnitToolsThermalDiffusivity
    {
        public static double Convert(double value, UnitToolsThermalDiffusivityUnit from, UnitToolsThermalDiffusivityUnit to)
        {
            double baseValue = ToSquareMeterPerSecond(value, from);
            return FromSquareMeterPerSecond(baseValue, to);
        }

        public static double ToSquareMeterPerSecond(double value, UnitToolsThermalDiffusivityUnit from)
        {
            switch (from)
            {
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerSecond:
                    return UnitToolsMetricThermalDiffusivity.SquareMeterPerSecondToSquareMeterPerSecond(value);
                case UnitToolsThermalDiffusivityUnit.SquareCentimeterPerSecond:
                    return UnitToolsMetricThermalDiffusivity.SquareCentimeterPerSecondToSquareMeterPerSecond(value);
                case UnitToolsThermalDiffusivityUnit.SquareMillimeterPerSecond:
                    return UnitToolsMetricThermalDiffusivity.SquareMillimeterPerSecondToSquareMeterPerSecond(value);
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerHour:
                    return UnitToolsMetricThermalDiffusivity.SquareMeterPerHourToSquareMeterPerSecond(value);
                case UnitToolsThermalDiffusivityUnit.SquareFootPerSecond:
                    return UnitToolsImperialThermalDiffusivity.SquareFootPerSecondToSquareMeterPerSecond(value);
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerMinute:
                    return UnitToolsMetricThermalDiffusivity.SquareMeterPerMinuteToSquareMeterPerSecond(value);
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerDay:
                    return UnitToolsMetricThermalDiffusivity.SquareMeterPerDayToSquareMeterPerSecond(value);
                case UnitToolsThermalDiffusivityUnit.SquareCentimeterPerMinute:
                    return UnitToolsMetricThermalDiffusivity.SquareCentimeterPerMinuteToSquareMeterPerSecond(value);
                case UnitToolsThermalDiffusivityUnit.SquareMillimeterPerMinute:
                    return UnitToolsMetricThermalDiffusivity.SquareMillimeterPerMinuteToSquareMeterPerSecond(value);
                case UnitToolsThermalDiffusivityUnit.SquareFootPerMinute:
                    return UnitToolsImperialThermalDiffusivity.SquareFootPerMinuteToSquareMeterPerSecond(value);
                case UnitToolsThermalDiffusivityUnit.SquareInchPerMinute:
                    return UnitToolsImperialThermalDiffusivity.SquareInchPerMinuteToSquareMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported thermal diffusivity unit.");
            }
        }

        public static double FromSquareMeterPerSecond(double baseValue, UnitToolsThermalDiffusivityUnit to)
        {
            switch (to)
            {
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerSecond:
                    return UnitToolsMetricThermalDiffusivity.SquareMeterPerSecondToSquareMeterPerSecond(baseValue);
                case UnitToolsThermalDiffusivityUnit.SquareCentimeterPerSecond:
                    return UnitToolsMetricThermalDiffusivity.SquareMeterPerSecondToSquareCentimeterPerSecond(baseValue);
                case UnitToolsThermalDiffusivityUnit.SquareMillimeterPerSecond:
                    return UnitToolsMetricThermalDiffusivity.SquareMeterPerSecondToSquareMillimeterPerSecond(baseValue);
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerHour:
                    return UnitToolsMetricThermalDiffusivity.SquareMeterPerSecondToSquareMeterPerHour(baseValue);
                case UnitToolsThermalDiffusivityUnit.SquareFootPerSecond:
                    return UnitToolsImperialThermalDiffusivity.SquareMeterPerSecondToSquareFootPerSecond(baseValue);
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerMinute:
                    return UnitToolsMetricThermalDiffusivity.SquareMeterPerSecondToSquareMeterPerMinute(baseValue);
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerDay:
                    return UnitToolsMetricThermalDiffusivity.SquareMeterPerSecondToSquareMeterPerDay(baseValue);
                case UnitToolsThermalDiffusivityUnit.SquareCentimeterPerMinute:
                    return UnitToolsMetricThermalDiffusivity.SquareMeterPerSecondToSquareCentimeterPerMinute(baseValue);
                case UnitToolsThermalDiffusivityUnit.SquareMillimeterPerMinute:
                    return UnitToolsMetricThermalDiffusivity.SquareMeterPerSecondToSquareMillimeterPerMinute(baseValue);
                case UnitToolsThermalDiffusivityUnit.SquareFootPerMinute:
                    return UnitToolsImperialThermalDiffusivity.SquareMeterPerSecondToSquareFootPerMinute(baseValue);
                case UnitToolsThermalDiffusivityUnit.SquareInchPerMinute:
                    return UnitToolsImperialThermalDiffusivity.SquareMeterPerSecondToSquareInchPerMinute(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported thermal diffusivity unit.");
            }
        }

        public static string GetSymbol(UnitToolsThermalDiffusivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerSecond:
                    return "m²/s";
                case UnitToolsThermalDiffusivityUnit.SquareCentimeterPerSecond:
                    return "cm²/s";
                case UnitToolsThermalDiffusivityUnit.SquareMillimeterPerSecond:
                    return "mm²/s";
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerHour:
                    return "m²/h";
                case UnitToolsThermalDiffusivityUnit.SquareFootPerSecond:
                    return "ft²/s";
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerMinute:
                    return "m²/min";
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerDay:
                    return "m²/d";
                case UnitToolsThermalDiffusivityUnit.SquareCentimeterPerMinute:
                    return "cm²/min";
                case UnitToolsThermalDiffusivityUnit.SquareMillimeterPerMinute:
                    return "mm²/min";
                case UnitToolsThermalDiffusivityUnit.SquareFootPerMinute:
                    return "ft²/min";
                case UnitToolsThermalDiffusivityUnit.SquareInchPerMinute:
                    return "in²/min";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsThermalDiffusivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerSecond:
                    return "Square Meter Per Second";
                case UnitToolsThermalDiffusivityUnit.SquareCentimeterPerSecond:
                    return "Square Centimeter Per Second";
                case UnitToolsThermalDiffusivityUnit.SquareMillimeterPerSecond:
                    return "Square Millimeter Per Second";
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerHour:
                    return "Square Meter Per Hour";
                case UnitToolsThermalDiffusivityUnit.SquareFootPerSecond:
                    return "Square Foot Per Second";
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerMinute:
                    return "Square Meter Per Minute";
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerDay:
                    return "Square Meter Per Day";
                case UnitToolsThermalDiffusivityUnit.SquareCentimeterPerMinute:
                    return "Square Centimeter Per Minute";
                case UnitToolsThermalDiffusivityUnit.SquareMillimeterPerMinute:
                    return "Square Millimeter Per Minute";
                case UnitToolsThermalDiffusivityUnit.SquareFootPerMinute:
                    return "Square Foot Per Minute";
                case UnitToolsThermalDiffusivityUnit.SquareInchPerMinute:
                    return "Square Inch Per Minute";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsThermalDiffusivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalDiffusivityUnit.SquareCentimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalDiffusivityUnit.SquareMillimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalDiffusivityUnit.SquareFootPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalDiffusivityUnit.SquareMeterPerDay:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalDiffusivityUnit.SquareCentimeterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalDiffusivityUnit.SquareMillimeterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalDiffusivityUnit.SquareFootPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsThermalDiffusivityUnit.SquareInchPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsThermalDiffusivityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsThermalDiffusivityUnit.SquareMeterPerSecond, UnitToolsThermalDiffusivityUnit.SquareCentimeterPerSecond, UnitToolsThermalDiffusivityUnit.SquareMillimeterPerSecond, UnitToolsThermalDiffusivityUnit.SquareMeterPerHour, UnitToolsThermalDiffusivityUnit.SquareMeterPerMinute, UnitToolsThermalDiffusivityUnit.SquareMeterPerDay, UnitToolsThermalDiffusivityUnit.SquareCentimeterPerMinute, UnitToolsThermalDiffusivityUnit.SquareMillimeterPerMinute };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsThermalDiffusivityUnit.SquareFootPerSecond, UnitToolsThermalDiffusivityUnit.SquareFootPerMinute, UnitToolsThermalDiffusivityUnit.SquareInchPerMinute };
                default:
                    return new[] { UnitToolsThermalDiffusivityUnit.SquareMeterPerSecond, UnitToolsThermalDiffusivityUnit.SquareCentimeterPerSecond, UnitToolsThermalDiffusivityUnit.SquareMillimeterPerSecond, UnitToolsThermalDiffusivityUnit.SquareMeterPerHour, UnitToolsThermalDiffusivityUnit.SquareFootPerSecond, UnitToolsThermalDiffusivityUnit.SquareMeterPerMinute, UnitToolsThermalDiffusivityUnit.SquareMeterPerDay, UnitToolsThermalDiffusivityUnit.SquareCentimeterPerMinute, UnitToolsThermalDiffusivityUnit.SquareMillimeterPerMinute, UnitToolsThermalDiffusivityUnit.SquareFootPerMinute, UnitToolsThermalDiffusivityUnit.SquareInchPerMinute };
            }
        }
    }
}
