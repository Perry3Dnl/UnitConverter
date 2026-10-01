namespace RealisticPhysics.UnitConversion.ThermalDiffusivity
{
    using RealisticPhysics.UnitConversion.ThermalDiffusivity.Metric;
    using RealisticPhysics.UnitConversion.ThermalDiffusivity.Imperial;

    public enum UnitConverterThermalDiffusivityUnit
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

    public static class UnitConverterThermalDiffusivity
    {
        public static double Convert(double value, UnitConverterThermalDiffusivityUnit from, UnitConverterThermalDiffusivityUnit to)
        {
            double baseValue = ToSquareMeterPerSecond(value, from);
            return FromSquareMeterPerSecond(baseValue, to);
        }

        public static double ToSquareMeterPerSecond(double value, UnitConverterThermalDiffusivityUnit from)
        {
            switch (from)
            {
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerSecond:
                    return UnitConverterMetricThermalDiffusivity.SquareMeterPerSecondToSquareMeterPerSecond(value);
                case UnitConverterThermalDiffusivityUnit.SquareCentimeterPerSecond:
                    return UnitConverterMetricThermalDiffusivity.SquareCentimeterPerSecondToSquareMeterPerSecond(value);
                case UnitConverterThermalDiffusivityUnit.SquareMillimeterPerSecond:
                    return UnitConverterMetricThermalDiffusivity.SquareMillimeterPerSecondToSquareMeterPerSecond(value);
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerHour:
                    return UnitConverterMetricThermalDiffusivity.SquareMeterPerHourToSquareMeterPerSecond(value);
                case UnitConverterThermalDiffusivityUnit.SquareFootPerSecond:
                    return UnitConverterImperialThermalDiffusivity.SquareFootPerSecondToSquareMeterPerSecond(value);
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerMinute:
                    return UnitConverterMetricThermalDiffusivity.SquareMeterPerMinuteToSquareMeterPerSecond(value);
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerDay:
                    return UnitConverterMetricThermalDiffusivity.SquareMeterPerDayToSquareMeterPerSecond(value);
                case UnitConverterThermalDiffusivityUnit.SquareCentimeterPerMinute:
                    return UnitConverterMetricThermalDiffusivity.SquareCentimeterPerMinuteToSquareMeterPerSecond(value);
                case UnitConverterThermalDiffusivityUnit.SquareMillimeterPerMinute:
                    return UnitConverterMetricThermalDiffusivity.SquareMillimeterPerMinuteToSquareMeterPerSecond(value);
                case UnitConverterThermalDiffusivityUnit.SquareFootPerMinute:
                    return UnitConverterImperialThermalDiffusivity.SquareFootPerMinuteToSquareMeterPerSecond(value);
                case UnitConverterThermalDiffusivityUnit.SquareInchPerMinute:
                    return UnitConverterImperialThermalDiffusivity.SquareInchPerMinuteToSquareMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported thermal diffusivity unit.");
            }
        }

        public static double FromSquareMeterPerSecond(double baseValue, UnitConverterThermalDiffusivityUnit to)
        {
            switch (to)
            {
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerSecond:
                    return UnitConverterMetricThermalDiffusivity.SquareMeterPerSecondToSquareMeterPerSecond(baseValue);
                case UnitConverterThermalDiffusivityUnit.SquareCentimeterPerSecond:
                    return UnitConverterMetricThermalDiffusivity.SquareMeterPerSecondToSquareCentimeterPerSecond(baseValue);
                case UnitConverterThermalDiffusivityUnit.SquareMillimeterPerSecond:
                    return UnitConverterMetricThermalDiffusivity.SquareMeterPerSecondToSquareMillimeterPerSecond(baseValue);
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerHour:
                    return UnitConverterMetricThermalDiffusivity.SquareMeterPerSecondToSquareMeterPerHour(baseValue);
                case UnitConverterThermalDiffusivityUnit.SquareFootPerSecond:
                    return UnitConverterImperialThermalDiffusivity.SquareMeterPerSecondToSquareFootPerSecond(baseValue);
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerMinute:
                    return UnitConverterMetricThermalDiffusivity.SquareMeterPerSecondToSquareMeterPerMinute(baseValue);
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerDay:
                    return UnitConverterMetricThermalDiffusivity.SquareMeterPerSecondToSquareMeterPerDay(baseValue);
                case UnitConverterThermalDiffusivityUnit.SquareCentimeterPerMinute:
                    return UnitConverterMetricThermalDiffusivity.SquareMeterPerSecondToSquareCentimeterPerMinute(baseValue);
                case UnitConverterThermalDiffusivityUnit.SquareMillimeterPerMinute:
                    return UnitConverterMetricThermalDiffusivity.SquareMeterPerSecondToSquareMillimeterPerMinute(baseValue);
                case UnitConverterThermalDiffusivityUnit.SquareFootPerMinute:
                    return UnitConverterImperialThermalDiffusivity.SquareMeterPerSecondToSquareFootPerMinute(baseValue);
                case UnitConverterThermalDiffusivityUnit.SquareInchPerMinute:
                    return UnitConverterImperialThermalDiffusivity.SquareMeterPerSecondToSquareInchPerMinute(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported thermal diffusivity unit.");
            }
        }

        public static string GetSymbol(UnitConverterThermalDiffusivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerSecond:
                    return "m²/s";
                case UnitConverterThermalDiffusivityUnit.SquareCentimeterPerSecond:
                    return "cm²/s";
                case UnitConverterThermalDiffusivityUnit.SquareMillimeterPerSecond:
                    return "mm²/s";
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerHour:
                    return "m²/h";
                case UnitConverterThermalDiffusivityUnit.SquareFootPerSecond:
                    return "ft²/s";
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerMinute:
                    return "m²/min";
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerDay:
                    return "m²/d";
                case UnitConverterThermalDiffusivityUnit.SquareCentimeterPerMinute:
                    return "cm²/min";
                case UnitConverterThermalDiffusivityUnit.SquareMillimeterPerMinute:
                    return "mm²/min";
                case UnitConverterThermalDiffusivityUnit.SquareFootPerMinute:
                    return "ft²/min";
                case UnitConverterThermalDiffusivityUnit.SquareInchPerMinute:
                    return "in²/min";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterThermalDiffusivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerSecond:
                    return "Square Meter Per Second";
                case UnitConverterThermalDiffusivityUnit.SquareCentimeterPerSecond:
                    return "Square Centimeter Per Second";
                case UnitConverterThermalDiffusivityUnit.SquareMillimeterPerSecond:
                    return "Square Millimeter Per Second";
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerHour:
                    return "Square Meter Per Hour";
                case UnitConverterThermalDiffusivityUnit.SquareFootPerSecond:
                    return "Square Foot Per Second";
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerMinute:
                    return "Square Meter Per Minute";
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerDay:
                    return "Square Meter Per Day";
                case UnitConverterThermalDiffusivityUnit.SquareCentimeterPerMinute:
                    return "Square Centimeter Per Minute";
                case UnitConverterThermalDiffusivityUnit.SquareMillimeterPerMinute:
                    return "Square Millimeter Per Minute";
                case UnitConverterThermalDiffusivityUnit.SquareFootPerMinute:
                    return "Square Foot Per Minute";
                case UnitConverterThermalDiffusivityUnit.SquareInchPerMinute:
                    return "Square Inch Per Minute";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterThermalDiffusivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalDiffusivityUnit.SquareCentimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalDiffusivityUnit.SquareMillimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalDiffusivityUnit.SquareFootPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalDiffusivityUnit.SquareMeterPerDay:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalDiffusivityUnit.SquareCentimeterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalDiffusivityUnit.SquareMillimeterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalDiffusivityUnit.SquareFootPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterThermalDiffusivityUnit.SquareInchPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterThermalDiffusivityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterThermalDiffusivityUnit.SquareMeterPerSecond, UnitConverterThermalDiffusivityUnit.SquareCentimeterPerSecond, UnitConverterThermalDiffusivityUnit.SquareMillimeterPerSecond, UnitConverterThermalDiffusivityUnit.SquareMeterPerHour, UnitConverterThermalDiffusivityUnit.SquareMeterPerMinute, UnitConverterThermalDiffusivityUnit.SquareMeterPerDay, UnitConverterThermalDiffusivityUnit.SquareCentimeterPerMinute, UnitConverterThermalDiffusivityUnit.SquareMillimeterPerMinute };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterThermalDiffusivityUnit.SquareFootPerSecond, UnitConverterThermalDiffusivityUnit.SquareFootPerMinute, UnitConverterThermalDiffusivityUnit.SquareInchPerMinute };
                default:
                    return new[] { UnitConverterThermalDiffusivityUnit.SquareMeterPerSecond, UnitConverterThermalDiffusivityUnit.SquareCentimeterPerSecond, UnitConverterThermalDiffusivityUnit.SquareMillimeterPerSecond, UnitConverterThermalDiffusivityUnit.SquareMeterPerHour, UnitConverterThermalDiffusivityUnit.SquareFootPerSecond, UnitConverterThermalDiffusivityUnit.SquareMeterPerMinute, UnitConverterThermalDiffusivityUnit.SquareMeterPerDay, UnitConverterThermalDiffusivityUnit.SquareCentimeterPerMinute, UnitConverterThermalDiffusivityUnit.SquareMillimeterPerMinute, UnitConverterThermalDiffusivityUnit.SquareFootPerMinute, UnitConverterThermalDiffusivityUnit.SquareInchPerMinute };
            }
        }
    }
}
