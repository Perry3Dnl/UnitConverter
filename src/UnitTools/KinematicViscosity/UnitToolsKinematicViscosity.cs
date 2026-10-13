namespace UnitTools.KinematicViscosity
{
    using UnitTools.KinematicViscosity.Metric;
    using UnitTools.KinematicViscosity.Imperial;

    public enum UnitToolsKinematicViscosityUnit
    {
        SquareMeterPerSecond = 0,
        SquareCentimeterPerSecond = 1,
        SquareMillimeterPerSecond = 2,
        Stokes = 3,
        Centistokes = 4,
        SquareFootPerSecond = 5,
        SquareInchPerSecond = 6,
        SquareMeterPerMinute = 7,
        SquareMeterPerHour = 8,
        SquareCentimeterPerMinute = 9,
        SquareMillimeterPerMinute = 10,
        Millistokes = 11,
        Microstokes = 12,
        SquareFootPerMinute = 13,
        SquareFootPerHour = 14,
        SquareInchPerMinute = 15,
        SquareMeterPerDay = 16,
        SquareCentimeterPerHour = 17,
        SquareMillimeterPerHour = 18,
        SquareInchPerHour = 19,
        SquareYardPerSecond = 20,
        SquareYardPerMinute = 21,
    }

    public static class UnitToolsKinematicViscosity
    {
        public static double Convert(double value, UnitToolsKinematicViscosityUnit from, UnitToolsKinematicViscosityUnit to)
        {
            double baseValue = ToSquareMeterPerSecond(value, from);
            return FromSquareMeterPerSecond(baseValue, to);
        }

        public static double ToSquareMeterPerSecond(double value, UnitToolsKinematicViscosityUnit from)
        {
            switch (from)
            {
                case UnitToolsKinematicViscosityUnit.SquareMeterPerSecond:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerSecond:
                    return UnitToolsMetricKinematicViscosity.SquareCentimeterPerSecondToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerSecond:
                    return UnitToolsMetricKinematicViscosity.SquareMillimeterPerSecondToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.Stokes:
                    return UnitToolsMetricKinematicViscosity.StokesToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.Centistokes:
                    return UnitToolsMetricKinematicViscosity.CentistokesToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareFootPerSecond:
                    return UnitToolsImperialKinematicViscosity.SquareFootPerSecondToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareInchPerSecond:
                    return UnitToolsImperialKinematicViscosity.SquareInchPerSecondToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareMeterPerMinute:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerMinuteToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareMeterPerHour:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerHourToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerMinute:
                    return UnitToolsMetricKinematicViscosity.SquareCentimeterPerMinuteToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerMinute:
                    return UnitToolsMetricKinematicViscosity.SquareMillimeterPerMinuteToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.Millistokes:
                    return UnitToolsMetricKinematicViscosity.MillistokesToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.Microstokes:
                    return UnitToolsMetricKinematicViscosity.MicrostokesToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareFootPerMinute:
                    return UnitToolsImperialKinematicViscosity.SquareFootPerMinuteToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareFootPerHour:
                    return UnitToolsImperialKinematicViscosity.SquareFootPerHourToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareInchPerMinute:
                    return UnitToolsImperialKinematicViscosity.SquareInchPerMinuteToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareMeterPerDay:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerDayToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerHour:
                    return UnitToolsMetricKinematicViscosity.SquareCentimeterPerHourToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerHour:
                    return UnitToolsMetricKinematicViscosity.SquareMillimeterPerHourToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareInchPerHour:
                    return UnitToolsImperialKinematicViscosity.SquareInchPerHourToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareYardPerSecond:
                    return UnitToolsImperialKinematicViscosity.SquareYardPerSecondToSquareMeterPerSecond(value);
                case UnitToolsKinematicViscosityUnit.SquareYardPerMinute:
                    return UnitToolsImperialKinematicViscosity.SquareYardPerMinuteToSquareMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported kinematic viscosity unit.");
            }
        }

        public static double FromSquareMeterPerSecond(double baseValue, UnitToolsKinematicViscosityUnit to)
        {
            switch (to)
            {
                case UnitToolsKinematicViscosityUnit.SquareMeterPerSecond:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToSquareMeterPerSecond(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerSecond:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToSquareCentimeterPerSecond(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerSecond:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToSquareMillimeterPerSecond(baseValue);
                case UnitToolsKinematicViscosityUnit.Stokes:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToStokes(baseValue);
                case UnitToolsKinematicViscosityUnit.Centistokes:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToCentistokes(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareFootPerSecond:
                    return UnitToolsImperialKinematicViscosity.SquareMeterPerSecondToSquareFootPerSecond(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareInchPerSecond:
                    return UnitToolsImperialKinematicViscosity.SquareMeterPerSecondToSquareInchPerSecond(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareMeterPerMinute:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToSquareMeterPerMinute(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareMeterPerHour:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToSquareMeterPerHour(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerMinute:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToSquareCentimeterPerMinute(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerMinute:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToSquareMillimeterPerMinute(baseValue);
                case UnitToolsKinematicViscosityUnit.Millistokes:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToMillistokes(baseValue);
                case UnitToolsKinematicViscosityUnit.Microstokes:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToMicrostokes(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareFootPerMinute:
                    return UnitToolsImperialKinematicViscosity.SquareMeterPerSecondToSquareFootPerMinute(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareFootPerHour:
                    return UnitToolsImperialKinematicViscosity.SquareMeterPerSecondToSquareFootPerHour(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareInchPerMinute:
                    return UnitToolsImperialKinematicViscosity.SquareMeterPerSecondToSquareInchPerMinute(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareMeterPerDay:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToSquareMeterPerDay(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerHour:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToSquareCentimeterPerHour(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerHour:
                    return UnitToolsMetricKinematicViscosity.SquareMeterPerSecondToSquareMillimeterPerHour(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareInchPerHour:
                    return UnitToolsImperialKinematicViscosity.SquareMeterPerSecondToSquareInchPerHour(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareYardPerSecond:
                    return UnitToolsImperialKinematicViscosity.SquareMeterPerSecondToSquareYardPerSecond(baseValue);
                case UnitToolsKinematicViscosityUnit.SquareYardPerMinute:
                    return UnitToolsImperialKinematicViscosity.SquareMeterPerSecondToSquareYardPerMinute(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported kinematic viscosity unit.");
            }
        }

        public static string GetSymbol(UnitToolsKinematicViscosityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsKinematicViscosityUnit.SquareMeterPerSecond:
                    return "m²/s";
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerSecond:
                    return "cm²/s";
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerSecond:
                    return "mm²/s";
                case UnitToolsKinematicViscosityUnit.Stokes:
                    return "St";
                case UnitToolsKinematicViscosityUnit.Centistokes:
                    return "cSt";
                case UnitToolsKinematicViscosityUnit.SquareFootPerSecond:
                    return "ft²/s";
                case UnitToolsKinematicViscosityUnit.SquareInchPerSecond:
                    return "in²/s";
                case UnitToolsKinematicViscosityUnit.SquareMeterPerMinute:
                    return "m²/min";
                case UnitToolsKinematicViscosityUnit.SquareMeterPerHour:
                    return "m²/h";
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerMinute:
                    return "cm²/min";
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerMinute:
                    return "mm²/min";
                case UnitToolsKinematicViscosityUnit.Millistokes:
                    return "mSt";
                case UnitToolsKinematicViscosityUnit.Microstokes:
                    return "µSt";
                case UnitToolsKinematicViscosityUnit.SquareFootPerMinute:
                    return "ft²/min";
                case UnitToolsKinematicViscosityUnit.SquareFootPerHour:
                    return "ft²/h";
                case UnitToolsKinematicViscosityUnit.SquareInchPerMinute:
                    return "in²/min";
                case UnitToolsKinematicViscosityUnit.SquareMeterPerDay:
                    return "m²/d";
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerHour:
                    return "cm²/h";
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerHour:
                    return "mm²/h";
                case UnitToolsKinematicViscosityUnit.SquareInchPerHour:
                    return "in²/h";
                case UnitToolsKinematicViscosityUnit.SquareYardPerSecond:
                    return "yd²/s";
                case UnitToolsKinematicViscosityUnit.SquareYardPerMinute:
                    return "yd²/min";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsKinematicViscosityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsKinematicViscosityUnit.SquareMeterPerSecond:
                    return "square meter per second";
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerSecond:
                    return "square centimeter per second";
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerSecond:
                    return "square millimeter per second";
                case UnitToolsKinematicViscosityUnit.Stokes:
                    return "stokes";
                case UnitToolsKinematicViscosityUnit.Centistokes:
                    return "centistokes";
                case UnitToolsKinematicViscosityUnit.SquareFootPerSecond:
                    return "square foot per second";
                case UnitToolsKinematicViscosityUnit.SquareInchPerSecond:
                    return "square inch per second";
                case UnitToolsKinematicViscosityUnit.SquareMeterPerMinute:
                    return "Square Meter Per Minute";
                case UnitToolsKinematicViscosityUnit.SquareMeterPerHour:
                    return "Square Meter Per Hour";
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerMinute:
                    return "Square Centimeter Per Minute";
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerMinute:
                    return "Square Millimeter Per Minute";
                case UnitToolsKinematicViscosityUnit.Millistokes:
                    return "Millistokes";
                case UnitToolsKinematicViscosityUnit.Microstokes:
                    return "Microstokes";
                case UnitToolsKinematicViscosityUnit.SquareFootPerMinute:
                    return "Square Foot Per Minute";
                case UnitToolsKinematicViscosityUnit.SquareFootPerHour:
                    return "Square Foot Per Hour";
                case UnitToolsKinematicViscosityUnit.SquareInchPerMinute:
                    return "Square Inch Per Minute";
                case UnitToolsKinematicViscosityUnit.SquareMeterPerDay:
                    return "Square Meter Per Day";
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerHour:
                    return "Square Centimeter Per Hour";
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerHour:
                    return "Square Millimeter Per Hour";
                case UnitToolsKinematicViscosityUnit.SquareInchPerHour:
                    return "Square Inch Per Hour";
                case UnitToolsKinematicViscosityUnit.SquareYardPerSecond:
                    return "Square Yard Per Second";
                case UnitToolsKinematicViscosityUnit.SquareYardPerMinute:
                    return "Square Yard Per Minute";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsKinematicViscosityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsKinematicViscosityUnit.SquareMeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.Stokes:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.Centistokes:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.SquareFootPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsKinematicViscosityUnit.SquareInchPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsKinematicViscosityUnit.SquareMeterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.SquareMeterPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.Millistokes:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.Microstokes:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.SquareFootPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsKinematicViscosityUnit.SquareFootPerHour:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsKinematicViscosityUnit.SquareInchPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsKinematicViscosityUnit.SquareMeterPerDay:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.SquareCentimeterPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.SquareMillimeterPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsKinematicViscosityUnit.SquareInchPerHour:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsKinematicViscosityUnit.SquareYardPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsKinematicViscosityUnit.SquareYardPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsKinematicViscosityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsKinematicViscosityUnit.SquareMeterPerSecond, UnitToolsKinematicViscosityUnit.SquareCentimeterPerSecond, UnitToolsKinematicViscosityUnit.SquareMillimeterPerSecond, UnitToolsKinematicViscosityUnit.Stokes, UnitToolsKinematicViscosityUnit.Centistokes, UnitToolsKinematicViscosityUnit.SquareMeterPerMinute, UnitToolsKinematicViscosityUnit.SquareMeterPerHour, UnitToolsKinematicViscosityUnit.SquareCentimeterPerMinute, UnitToolsKinematicViscosityUnit.SquareMillimeterPerMinute, UnitToolsKinematicViscosityUnit.Millistokes, UnitToolsKinematicViscosityUnit.Microstokes, UnitToolsKinematicViscosityUnit.SquareMeterPerDay, UnitToolsKinematicViscosityUnit.SquareCentimeterPerHour, UnitToolsKinematicViscosityUnit.SquareMillimeterPerHour };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsKinematicViscosityUnit.SquareFootPerSecond, UnitToolsKinematicViscosityUnit.SquareInchPerSecond, UnitToolsKinematicViscosityUnit.SquareFootPerMinute, UnitToolsKinematicViscosityUnit.SquareFootPerHour, UnitToolsKinematicViscosityUnit.SquareInchPerMinute, UnitToolsKinematicViscosityUnit.SquareInchPerHour, UnitToolsKinematicViscosityUnit.SquareYardPerSecond, UnitToolsKinematicViscosityUnit.SquareYardPerMinute };
                default:
                    return new[] { UnitToolsKinematicViscosityUnit.SquareMeterPerSecond, UnitToolsKinematicViscosityUnit.SquareCentimeterPerSecond, UnitToolsKinematicViscosityUnit.SquareMillimeterPerSecond, UnitToolsKinematicViscosityUnit.Stokes, UnitToolsKinematicViscosityUnit.Centistokes, UnitToolsKinematicViscosityUnit.SquareFootPerSecond, UnitToolsKinematicViscosityUnit.SquareInchPerSecond, UnitToolsKinematicViscosityUnit.SquareMeterPerMinute, UnitToolsKinematicViscosityUnit.SquareMeterPerHour, UnitToolsKinematicViscosityUnit.SquareCentimeterPerMinute, UnitToolsKinematicViscosityUnit.SquareMillimeterPerMinute, UnitToolsKinematicViscosityUnit.Millistokes, UnitToolsKinematicViscosityUnit.Microstokes, UnitToolsKinematicViscosityUnit.SquareFootPerMinute, UnitToolsKinematicViscosityUnit.SquareFootPerHour, UnitToolsKinematicViscosityUnit.SquareInchPerMinute, UnitToolsKinematicViscosityUnit.SquareMeterPerDay, UnitToolsKinematicViscosityUnit.SquareCentimeterPerHour, UnitToolsKinematicViscosityUnit.SquareMillimeterPerHour, UnitToolsKinematicViscosityUnit.SquareInchPerHour, UnitToolsKinematicViscosityUnit.SquareYardPerSecond, UnitToolsKinematicViscosityUnit.SquareYardPerMinute };
            }
        }
    }
}
