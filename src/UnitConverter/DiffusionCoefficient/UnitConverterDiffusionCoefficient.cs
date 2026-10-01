namespace UnitConverter.DiffusionCoefficient
{
    using UnitConverter.DiffusionCoefficient.Metric;
    using UnitConverter.DiffusionCoefficient.Imperial;

    public enum UnitConverterDiffusionCoefficientUnit
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

    public static class UnitConverterDiffusionCoefficient
    {
        public static double Convert(double value, UnitConverterDiffusionCoefficientUnit from, UnitConverterDiffusionCoefficientUnit to)
        {
            double baseValue = ToSquareMeterPerSecond(value, from);
            return FromSquareMeterPerSecond(baseValue, to);
        }

        public static double ToSquareMeterPerSecond(double value, UnitConverterDiffusionCoefficientUnit from)
        {
            switch (from)
            {
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerSecond:
                    return UnitConverterMetricDiffusionCoefficient.SquareMeterPerSecondToSquareMeterPerSecond(value);
                case UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerSecond:
                    return UnitConverterMetricDiffusionCoefficient.SquareCentimeterPerSecondToSquareMeterPerSecond(value);
                case UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerSecond:
                    return UnitConverterMetricDiffusionCoefficient.SquareMillimeterPerSecondToSquareMeterPerSecond(value);
                case UnitConverterDiffusionCoefficientUnit.SquareFootPerSecond:
                    return UnitConverterImperialDiffusionCoefficient.SquareFootPerSecondToSquareMeterPerSecond(value);
                case UnitConverterDiffusionCoefficientUnit.SquareInchPerSecond:
                    return UnitConverterImperialDiffusionCoefficient.SquareInchPerSecondToSquareMeterPerSecond(value);
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerMinute:
                    return UnitConverterMetricDiffusionCoefficient.SquareMeterPerMinuteToSquareMeterPerSecond(value);
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerDay:
                    return UnitConverterMetricDiffusionCoefficient.SquareMeterPerDayToSquareMeterPerSecond(value);
                case UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerMinute:
                    return UnitConverterMetricDiffusionCoefficient.SquareCentimeterPerMinuteToSquareMeterPerSecond(value);
                case UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerMinute:
                    return UnitConverterMetricDiffusionCoefficient.SquareMillimeterPerMinuteToSquareMeterPerSecond(value);
                case UnitConverterDiffusionCoefficientUnit.SquareFootPerMinute:
                    return UnitConverterImperialDiffusionCoefficient.SquareFootPerMinuteToSquareMeterPerSecond(value);
                case UnitConverterDiffusionCoefficientUnit.SquareInchPerMinute:
                    return UnitConverterImperialDiffusionCoefficient.SquareInchPerMinuteToSquareMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported diffusion coefficient unit.");
            }
        }

        public static double FromSquareMeterPerSecond(double baseValue, UnitConverterDiffusionCoefficientUnit to)
        {
            switch (to)
            {
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerSecond:
                    return UnitConverterMetricDiffusionCoefficient.SquareMeterPerSecondToSquareMeterPerSecond(baseValue);
                case UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerSecond:
                    return UnitConverterMetricDiffusionCoefficient.SquareMeterPerSecondToSquareCentimeterPerSecond(baseValue);
                case UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerSecond:
                    return UnitConverterMetricDiffusionCoefficient.SquareMeterPerSecondToSquareMillimeterPerSecond(baseValue);
                case UnitConverterDiffusionCoefficientUnit.SquareFootPerSecond:
                    return UnitConverterImperialDiffusionCoefficient.SquareMeterPerSecondToSquareFootPerSecond(baseValue);
                case UnitConverterDiffusionCoefficientUnit.SquareInchPerSecond:
                    return UnitConverterImperialDiffusionCoefficient.SquareMeterPerSecondToSquareInchPerSecond(baseValue);
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerMinute:
                    return UnitConverterMetricDiffusionCoefficient.SquareMeterPerSecondToSquareMeterPerMinute(baseValue);
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerDay:
                    return UnitConverterMetricDiffusionCoefficient.SquareMeterPerSecondToSquareMeterPerDay(baseValue);
                case UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerMinute:
                    return UnitConverterMetricDiffusionCoefficient.SquareMeterPerSecondToSquareCentimeterPerMinute(baseValue);
                case UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerMinute:
                    return UnitConverterMetricDiffusionCoefficient.SquareMeterPerSecondToSquareMillimeterPerMinute(baseValue);
                case UnitConverterDiffusionCoefficientUnit.SquareFootPerMinute:
                    return UnitConverterImperialDiffusionCoefficient.SquareMeterPerSecondToSquareFootPerMinute(baseValue);
                case UnitConverterDiffusionCoefficientUnit.SquareInchPerMinute:
                    return UnitConverterImperialDiffusionCoefficient.SquareMeterPerSecondToSquareInchPerMinute(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported diffusion coefficient unit.");
            }
        }

        public static string GetSymbol(UnitConverterDiffusionCoefficientUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerSecond:
                    return "m²/s";
                case UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerSecond:
                    return "cm²/s";
                case UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerSecond:
                    return "mm²/s";
                case UnitConverterDiffusionCoefficientUnit.SquareFootPerSecond:
                    return "ft²/s";
                case UnitConverterDiffusionCoefficientUnit.SquareInchPerSecond:
                    return "in²/s";
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerMinute:
                    return "m²/min";
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerDay:
                    return "m²/d";
                case UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerMinute:
                    return "cm²/min";
                case UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerMinute:
                    return "mm²/min";
                case UnitConverterDiffusionCoefficientUnit.SquareFootPerMinute:
                    return "ft²/min";
                case UnitConverterDiffusionCoefficientUnit.SquareInchPerMinute:
                    return "in²/min";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterDiffusionCoefficientUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerSecond:
                    return "Square Meter Per Second";
                case UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerSecond:
                    return "Square Centimeter Per Second";
                case UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerSecond:
                    return "Square Millimeter Per Second";
                case UnitConverterDiffusionCoefficientUnit.SquareFootPerSecond:
                    return "Square Foot Per Second";
                case UnitConverterDiffusionCoefficientUnit.SquareInchPerSecond:
                    return "Square Inch Per Second";
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerMinute:
                    return "Square Meter Per Minute";
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerDay:
                    return "Square Meter Per Day";
                case UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerMinute:
                    return "Square Centimeter Per Minute";
                case UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerMinute:
                    return "Square Millimeter Per Minute";
                case UnitConverterDiffusionCoefficientUnit.SquareFootPerMinute:
                    return "Square Foot Per Minute";
                case UnitConverterDiffusionCoefficientUnit.SquareInchPerMinute:
                    return "Square Inch Per Minute";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterDiffusionCoefficientUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDiffusionCoefficientUnit.SquareFootPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDiffusionCoefficientUnit.SquareInchPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDiffusionCoefficientUnit.SquareMeterPerDay:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterDiffusionCoefficientUnit.SquareFootPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterDiffusionCoefficientUnit.SquareInchPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterDiffusionCoefficientUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterDiffusionCoefficientUnit.SquareMeterPerSecond, UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerSecond, UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerSecond, UnitConverterDiffusionCoefficientUnit.SquareMeterPerMinute, UnitConverterDiffusionCoefficientUnit.SquareMeterPerDay, UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerMinute, UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerMinute };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterDiffusionCoefficientUnit.SquareFootPerSecond, UnitConverterDiffusionCoefficientUnit.SquareInchPerSecond, UnitConverterDiffusionCoefficientUnit.SquareFootPerMinute, UnitConverterDiffusionCoefficientUnit.SquareInchPerMinute };
                default:
                    return new[] { UnitConverterDiffusionCoefficientUnit.SquareMeterPerSecond, UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerSecond, UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerSecond, UnitConverterDiffusionCoefficientUnit.SquareFootPerSecond, UnitConverterDiffusionCoefficientUnit.SquareInchPerSecond, UnitConverterDiffusionCoefficientUnit.SquareMeterPerMinute, UnitConverterDiffusionCoefficientUnit.SquareMeterPerDay, UnitConverterDiffusionCoefficientUnit.SquareCentimeterPerMinute, UnitConverterDiffusionCoefficientUnit.SquareMillimeterPerMinute, UnitConverterDiffusionCoefficientUnit.SquareFootPerMinute, UnitConverterDiffusionCoefficientUnit.SquareInchPerMinute };
            }
        }
    }
}
