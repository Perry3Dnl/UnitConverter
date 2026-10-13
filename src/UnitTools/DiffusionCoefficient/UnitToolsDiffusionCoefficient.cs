namespace UnitTools.DiffusionCoefficient
{
    using UnitTools.DiffusionCoefficient.Metric;
    using UnitTools.DiffusionCoefficient.Imperial;

    public enum UnitToolsDiffusionCoefficientUnit
    {
        SquareMeterPerSecond = 0,
        SquareCentimeterPerSecond = 1,
        SquareMillimeterPerSecond = 2,
        SquareFootPerSecond = 3,
        SquareInchPerSecond = 4,
        SquareMeterPerMinute = 5,
        SquareMeterPerDay = 6,
        SquareCentimeterPerMinute = 7,
        SquareMillimeterPerMinute = 8,
        SquareFootPerMinute = 9,
        SquareInchPerMinute = 10,
    }

    public static class UnitToolsDiffusionCoefficient
    {
        public static double Convert(double value, UnitToolsDiffusionCoefficientUnit from, UnitToolsDiffusionCoefficientUnit to)
        {
            double baseValue = ToSquareMeterPerSecond(value, from);
            return FromSquareMeterPerSecond(baseValue, to);
        }

        public static double ToSquareMeterPerSecond(double value, UnitToolsDiffusionCoefficientUnit from)
        {
            switch (from)
            {
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerSecond:
                    return UnitToolsMetricDiffusionCoefficient.SquareMeterPerSecondToSquareMeterPerSecond(value);
                case UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerSecond:
                    return UnitToolsMetricDiffusionCoefficient.SquareCentimeterPerSecondToSquareMeterPerSecond(value);
                case UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerSecond:
                    return UnitToolsMetricDiffusionCoefficient.SquareMillimeterPerSecondToSquareMeterPerSecond(value);
                case UnitToolsDiffusionCoefficientUnit.SquareFootPerSecond:
                    return UnitToolsImperialDiffusionCoefficient.SquareFootPerSecondToSquareMeterPerSecond(value);
                case UnitToolsDiffusionCoefficientUnit.SquareInchPerSecond:
                    return UnitToolsImperialDiffusionCoefficient.SquareInchPerSecondToSquareMeterPerSecond(value);
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerMinute:
                    return UnitToolsMetricDiffusionCoefficient.SquareMeterPerMinuteToSquareMeterPerSecond(value);
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerDay:
                    return UnitToolsMetricDiffusionCoefficient.SquareMeterPerDayToSquareMeterPerSecond(value);
                case UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerMinute:
                    return UnitToolsMetricDiffusionCoefficient.SquareCentimeterPerMinuteToSquareMeterPerSecond(value);
                case UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerMinute:
                    return UnitToolsMetricDiffusionCoefficient.SquareMillimeterPerMinuteToSquareMeterPerSecond(value);
                case UnitToolsDiffusionCoefficientUnit.SquareFootPerMinute:
                    return UnitToolsImperialDiffusionCoefficient.SquareFootPerMinuteToSquareMeterPerSecond(value);
                case UnitToolsDiffusionCoefficientUnit.SquareInchPerMinute:
                    return UnitToolsImperialDiffusionCoefficient.SquareInchPerMinuteToSquareMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported diffusion coefficient unit.");
            }
        }

        public static double FromSquareMeterPerSecond(double baseValue, UnitToolsDiffusionCoefficientUnit to)
        {
            switch (to)
            {
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerSecond:
                    return UnitToolsMetricDiffusionCoefficient.SquareMeterPerSecondToSquareMeterPerSecond(baseValue);
                case UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerSecond:
                    return UnitToolsMetricDiffusionCoefficient.SquareMeterPerSecondToSquareCentimeterPerSecond(baseValue);
                case UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerSecond:
                    return UnitToolsMetricDiffusionCoefficient.SquareMeterPerSecondToSquareMillimeterPerSecond(baseValue);
                case UnitToolsDiffusionCoefficientUnit.SquareFootPerSecond:
                    return UnitToolsImperialDiffusionCoefficient.SquareMeterPerSecondToSquareFootPerSecond(baseValue);
                case UnitToolsDiffusionCoefficientUnit.SquareInchPerSecond:
                    return UnitToolsImperialDiffusionCoefficient.SquareMeterPerSecondToSquareInchPerSecond(baseValue);
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerMinute:
                    return UnitToolsMetricDiffusionCoefficient.SquareMeterPerSecondToSquareMeterPerMinute(baseValue);
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerDay:
                    return UnitToolsMetricDiffusionCoefficient.SquareMeterPerSecondToSquareMeterPerDay(baseValue);
                case UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerMinute:
                    return UnitToolsMetricDiffusionCoefficient.SquareMeterPerSecondToSquareCentimeterPerMinute(baseValue);
                case UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerMinute:
                    return UnitToolsMetricDiffusionCoefficient.SquareMeterPerSecondToSquareMillimeterPerMinute(baseValue);
                case UnitToolsDiffusionCoefficientUnit.SquareFootPerMinute:
                    return UnitToolsImperialDiffusionCoefficient.SquareMeterPerSecondToSquareFootPerMinute(baseValue);
                case UnitToolsDiffusionCoefficientUnit.SquareInchPerMinute:
                    return UnitToolsImperialDiffusionCoefficient.SquareMeterPerSecondToSquareInchPerMinute(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported diffusion coefficient unit.");
            }
        }

        public static string GetSymbol(UnitToolsDiffusionCoefficientUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerSecond:
                    return "m²/s";
                case UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerSecond:
                    return "cm²/s";
                case UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerSecond:
                    return "mm²/s";
                case UnitToolsDiffusionCoefficientUnit.SquareFootPerSecond:
                    return "ft²/s";
                case UnitToolsDiffusionCoefficientUnit.SquareInchPerSecond:
                    return "in²/s";
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerMinute:
                    return "m²/min";
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerDay:
                    return "m²/d";
                case UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerMinute:
                    return "cm²/min";
                case UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerMinute:
                    return "mm²/min";
                case UnitToolsDiffusionCoefficientUnit.SquareFootPerMinute:
                    return "ft²/min";
                case UnitToolsDiffusionCoefficientUnit.SquareInchPerMinute:
                    return "in²/min";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsDiffusionCoefficientUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerSecond:
                    return "Square Meter Per Second";
                case UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerSecond:
                    return "Square Centimeter Per Second";
                case UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerSecond:
                    return "Square Millimeter Per Second";
                case UnitToolsDiffusionCoefficientUnit.SquareFootPerSecond:
                    return "Square Foot Per Second";
                case UnitToolsDiffusionCoefficientUnit.SquareInchPerSecond:
                    return "Square Inch Per Second";
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerMinute:
                    return "Square Meter Per Minute";
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerDay:
                    return "Square Meter Per Day";
                case UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerMinute:
                    return "Square Centimeter Per Minute";
                case UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerMinute:
                    return "Square Millimeter Per Minute";
                case UnitToolsDiffusionCoefficientUnit.SquareFootPerMinute:
                    return "Square Foot Per Minute";
                case UnitToolsDiffusionCoefficientUnit.SquareInchPerMinute:
                    return "Square Inch Per Minute";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsDiffusionCoefficientUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDiffusionCoefficientUnit.SquareFootPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDiffusionCoefficientUnit.SquareInchPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDiffusionCoefficientUnit.SquareMeterPerDay:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsDiffusionCoefficientUnit.SquareFootPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsDiffusionCoefficientUnit.SquareInchPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsDiffusionCoefficientUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsDiffusionCoefficientUnit.SquareMeterPerSecond, UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerSecond, UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerSecond, UnitToolsDiffusionCoefficientUnit.SquareMeterPerMinute, UnitToolsDiffusionCoefficientUnit.SquareMeterPerDay, UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerMinute, UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerMinute };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsDiffusionCoefficientUnit.SquareFootPerSecond, UnitToolsDiffusionCoefficientUnit.SquareInchPerSecond, UnitToolsDiffusionCoefficientUnit.SquareFootPerMinute, UnitToolsDiffusionCoefficientUnit.SquareInchPerMinute };
                default:
                    return new[] { UnitToolsDiffusionCoefficientUnit.SquareMeterPerSecond, UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerSecond, UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerSecond, UnitToolsDiffusionCoefficientUnit.SquareFootPerSecond, UnitToolsDiffusionCoefficientUnit.SquareInchPerSecond, UnitToolsDiffusionCoefficientUnit.SquareMeterPerMinute, UnitToolsDiffusionCoefficientUnit.SquareMeterPerDay, UnitToolsDiffusionCoefficientUnit.SquareCentimeterPerMinute, UnitToolsDiffusionCoefficientUnit.SquareMillimeterPerMinute, UnitToolsDiffusionCoefficientUnit.SquareFootPerMinute, UnitToolsDiffusionCoefficientUnit.SquareInchPerMinute };
            }
        }
    }
}
