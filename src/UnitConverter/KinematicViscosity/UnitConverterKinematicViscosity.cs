namespace UnitConverter.KinematicViscosity
{
    using UnitConverter.KinematicViscosity.Metric;
    using UnitConverter.KinematicViscosity.Imperial;

    public enum UnitConverterKinematicViscosityUnit
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

    public static class UnitConverterKinematicViscosity
    {
        public static double Convert(double value, UnitConverterKinematicViscosityUnit from, UnitConverterKinematicViscosityUnit to)
        {
            double baseValue = ToSquareMeterPerSecond(value, from);
            return FromSquareMeterPerSecond(baseValue, to);
        }

        public static double ToSquareMeterPerSecond(double value, UnitConverterKinematicViscosityUnit from)
        {
            switch (from)
            {
                case UnitConverterKinematicViscosityUnit.SquareMeterPerSecond:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerSecond:
                    return UnitConverterMetricKinematicViscosity.SquareCentimeterPerSecondToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerSecond:
                    return UnitConverterMetricKinematicViscosity.SquareMillimeterPerSecondToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.Stokes:
                    return UnitConverterMetricKinematicViscosity.StokesToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.Centistokes:
                    return UnitConverterMetricKinematicViscosity.CentistokesToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareFootPerSecond:
                    return UnitConverterImperialKinematicViscosity.SquareFootPerSecondToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareInchPerSecond:
                    return UnitConverterImperialKinematicViscosity.SquareInchPerSecondToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareMeterPerMinute:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerMinuteToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareMeterPerHour:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerHourToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerMinute:
                    return UnitConverterMetricKinematicViscosity.SquareCentimeterPerMinuteToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerMinute:
                    return UnitConverterMetricKinematicViscosity.SquareMillimeterPerMinuteToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.Millistokes:
                    return UnitConverterMetricKinematicViscosity.MillistokesToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.Microstokes:
                    return UnitConverterMetricKinematicViscosity.MicrostokesToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareFootPerMinute:
                    return UnitConverterImperialKinematicViscosity.SquareFootPerMinuteToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareFootPerHour:
                    return UnitConverterImperialKinematicViscosity.SquareFootPerHourToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareInchPerMinute:
                    return UnitConverterImperialKinematicViscosity.SquareInchPerMinuteToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareMeterPerDay:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerDayToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerHour:
                    return UnitConverterMetricKinematicViscosity.SquareCentimeterPerHourToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerHour:
                    return UnitConverterMetricKinematicViscosity.SquareMillimeterPerHourToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareInchPerHour:
                    return UnitConverterImperialKinematicViscosity.SquareInchPerHourToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareYardPerSecond:
                    return UnitConverterImperialKinematicViscosity.SquareYardPerSecondToSquareMeterPerSecond(value);
                case UnitConverterKinematicViscosityUnit.SquareYardPerMinute:
                    return UnitConverterImperialKinematicViscosity.SquareYardPerMinuteToSquareMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported kinematic viscosity unit.");
            }
        }

        public static double FromSquareMeterPerSecond(double baseValue, UnitConverterKinematicViscosityUnit to)
        {
            switch (to)
            {
                case UnitConverterKinematicViscosityUnit.SquareMeterPerSecond:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToSquareMeterPerSecond(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerSecond:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToSquareCentimeterPerSecond(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerSecond:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToSquareMillimeterPerSecond(baseValue);
                case UnitConverterKinematicViscosityUnit.Stokes:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToStokes(baseValue);
                case UnitConverterKinematicViscosityUnit.Centistokes:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToCentistokes(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareFootPerSecond:
                    return UnitConverterImperialKinematicViscosity.SquareMeterPerSecondToSquareFootPerSecond(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareInchPerSecond:
                    return UnitConverterImperialKinematicViscosity.SquareMeterPerSecondToSquareInchPerSecond(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareMeterPerMinute:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToSquareMeterPerMinute(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareMeterPerHour:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToSquareMeterPerHour(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerMinute:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToSquareCentimeterPerMinute(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerMinute:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToSquareMillimeterPerMinute(baseValue);
                case UnitConverterKinematicViscosityUnit.Millistokes:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToMillistokes(baseValue);
                case UnitConverterKinematicViscosityUnit.Microstokes:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToMicrostokes(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareFootPerMinute:
                    return UnitConverterImperialKinematicViscosity.SquareMeterPerSecondToSquareFootPerMinute(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareFootPerHour:
                    return UnitConverterImperialKinematicViscosity.SquareMeterPerSecondToSquareFootPerHour(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareInchPerMinute:
                    return UnitConverterImperialKinematicViscosity.SquareMeterPerSecondToSquareInchPerMinute(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareMeterPerDay:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToSquareMeterPerDay(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerHour:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToSquareCentimeterPerHour(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerHour:
                    return UnitConverterMetricKinematicViscosity.SquareMeterPerSecondToSquareMillimeterPerHour(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareInchPerHour:
                    return UnitConverterImperialKinematicViscosity.SquareMeterPerSecondToSquareInchPerHour(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareYardPerSecond:
                    return UnitConverterImperialKinematicViscosity.SquareMeterPerSecondToSquareYardPerSecond(baseValue);
                case UnitConverterKinematicViscosityUnit.SquareYardPerMinute:
                    return UnitConverterImperialKinematicViscosity.SquareMeterPerSecondToSquareYardPerMinute(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported kinematic viscosity unit.");
            }
        }

        public static string GetSymbol(UnitConverterKinematicViscosityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterKinematicViscosityUnit.SquareMeterPerSecond:
                    return "m²/s";
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerSecond:
                    return "cm²/s";
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerSecond:
                    return "mm²/s";
                case UnitConverterKinematicViscosityUnit.Stokes:
                    return "St";
                case UnitConverterKinematicViscosityUnit.Centistokes:
                    return "cSt";
                case UnitConverterKinematicViscosityUnit.SquareFootPerSecond:
                    return "ft²/s";
                case UnitConverterKinematicViscosityUnit.SquareInchPerSecond:
                    return "in²/s";
                case UnitConverterKinematicViscosityUnit.SquareMeterPerMinute:
                    return "m²/min";
                case UnitConverterKinematicViscosityUnit.SquareMeterPerHour:
                    return "m²/h";
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerMinute:
                    return "cm²/min";
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerMinute:
                    return "mm²/min";
                case UnitConverterKinematicViscosityUnit.Millistokes:
                    return "mSt";
                case UnitConverterKinematicViscosityUnit.Microstokes:
                    return "µSt";
                case UnitConverterKinematicViscosityUnit.SquareFootPerMinute:
                    return "ft²/min";
                case UnitConverterKinematicViscosityUnit.SquareFootPerHour:
                    return "ft²/h";
                case UnitConverterKinematicViscosityUnit.SquareInchPerMinute:
                    return "in²/min";
                case UnitConverterKinematicViscosityUnit.SquareMeterPerDay:
                    return "m²/d";
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerHour:
                    return "cm²/h";
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerHour:
                    return "mm²/h";
                case UnitConverterKinematicViscosityUnit.SquareInchPerHour:
                    return "in²/h";
                case UnitConverterKinematicViscosityUnit.SquareYardPerSecond:
                    return "yd²/s";
                case UnitConverterKinematicViscosityUnit.SquareYardPerMinute:
                    return "yd²/min";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterKinematicViscosityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterKinematicViscosityUnit.SquareMeterPerSecond:
                    return "square meter per second";
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerSecond:
                    return "square centimeter per second";
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerSecond:
                    return "square millimeter per second";
                case UnitConverterKinematicViscosityUnit.Stokes:
                    return "stokes";
                case UnitConverterKinematicViscosityUnit.Centistokes:
                    return "centistokes";
                case UnitConverterKinematicViscosityUnit.SquareFootPerSecond:
                    return "square foot per second";
                case UnitConverterKinematicViscosityUnit.SquareInchPerSecond:
                    return "square inch per second";
                case UnitConverterKinematicViscosityUnit.SquareMeterPerMinute:
                    return "Square Meter Per Minute";
                case UnitConverterKinematicViscosityUnit.SquareMeterPerHour:
                    return "Square Meter Per Hour";
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerMinute:
                    return "Square Centimeter Per Minute";
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerMinute:
                    return "Square Millimeter Per Minute";
                case UnitConverterKinematicViscosityUnit.Millistokes:
                    return "Millistokes";
                case UnitConverterKinematicViscosityUnit.Microstokes:
                    return "Microstokes";
                case UnitConverterKinematicViscosityUnit.SquareFootPerMinute:
                    return "Square Foot Per Minute";
                case UnitConverterKinematicViscosityUnit.SquareFootPerHour:
                    return "Square Foot Per Hour";
                case UnitConverterKinematicViscosityUnit.SquareInchPerMinute:
                    return "Square Inch Per Minute";
                case UnitConverterKinematicViscosityUnit.SquareMeterPerDay:
                    return "Square Meter Per Day";
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerHour:
                    return "Square Centimeter Per Hour";
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerHour:
                    return "Square Millimeter Per Hour";
                case UnitConverterKinematicViscosityUnit.SquareInchPerHour:
                    return "Square Inch Per Hour";
                case UnitConverterKinematicViscosityUnit.SquareYardPerSecond:
                    return "Square Yard Per Second";
                case UnitConverterKinematicViscosityUnit.SquareYardPerMinute:
                    return "Square Yard Per Minute";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterKinematicViscosityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterKinematicViscosityUnit.SquareMeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.Stokes:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.Centistokes:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.SquareFootPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterKinematicViscosityUnit.SquareInchPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterKinematicViscosityUnit.SquareMeterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.SquareMeterPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.Millistokes:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.Microstokes:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.SquareFootPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterKinematicViscosityUnit.SquareFootPerHour:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterKinematicViscosityUnit.SquareInchPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterKinematicViscosityUnit.SquareMeterPerDay:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.SquareCentimeterPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.SquareMillimeterPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterKinematicViscosityUnit.SquareInchPerHour:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterKinematicViscosityUnit.SquareYardPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterKinematicViscosityUnit.SquareYardPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterKinematicViscosityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterKinematicViscosityUnit.SquareMeterPerSecond, UnitConverterKinematicViscosityUnit.SquareCentimeterPerSecond, UnitConverterKinematicViscosityUnit.SquareMillimeterPerSecond, UnitConverterKinematicViscosityUnit.Stokes, UnitConverterKinematicViscosityUnit.Centistokes, UnitConverterKinematicViscosityUnit.SquareMeterPerMinute, UnitConverterKinematicViscosityUnit.SquareMeterPerHour, UnitConverterKinematicViscosityUnit.SquareCentimeterPerMinute, UnitConverterKinematicViscosityUnit.SquareMillimeterPerMinute, UnitConverterKinematicViscosityUnit.Millistokes, UnitConverterKinematicViscosityUnit.Microstokes, UnitConverterKinematicViscosityUnit.SquareMeterPerDay, UnitConverterKinematicViscosityUnit.SquareCentimeterPerHour, UnitConverterKinematicViscosityUnit.SquareMillimeterPerHour };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterKinematicViscosityUnit.SquareFootPerSecond, UnitConverterKinematicViscosityUnit.SquareInchPerSecond, UnitConverterKinematicViscosityUnit.SquareFootPerMinute, UnitConverterKinematicViscosityUnit.SquareFootPerHour, UnitConverterKinematicViscosityUnit.SquareInchPerMinute, UnitConverterKinematicViscosityUnit.SquareInchPerHour, UnitConverterKinematicViscosityUnit.SquareYardPerSecond, UnitConverterKinematicViscosityUnit.SquareYardPerMinute };
                default:
                    return new[] { UnitConverterKinematicViscosityUnit.SquareMeterPerSecond, UnitConverterKinematicViscosityUnit.SquareCentimeterPerSecond, UnitConverterKinematicViscosityUnit.SquareMillimeterPerSecond, UnitConverterKinematicViscosityUnit.Stokes, UnitConverterKinematicViscosityUnit.Centistokes, UnitConverterKinematicViscosityUnit.SquareFootPerSecond, UnitConverterKinematicViscosityUnit.SquareInchPerSecond, UnitConverterKinematicViscosityUnit.SquareMeterPerMinute, UnitConverterKinematicViscosityUnit.SquareMeterPerHour, UnitConverterKinematicViscosityUnit.SquareCentimeterPerMinute, UnitConverterKinematicViscosityUnit.SquareMillimeterPerMinute, UnitConverterKinematicViscosityUnit.Millistokes, UnitConverterKinematicViscosityUnit.Microstokes, UnitConverterKinematicViscosityUnit.SquareFootPerMinute, UnitConverterKinematicViscosityUnit.SquareFootPerHour, UnitConverterKinematicViscosityUnit.SquareInchPerMinute, UnitConverterKinematicViscosityUnit.SquareMeterPerDay, UnitConverterKinematicViscosityUnit.SquareCentimeterPerHour, UnitConverterKinematicViscosityUnit.SquareMillimeterPerHour, UnitConverterKinematicViscosityUnit.SquareInchPerHour, UnitConverterKinematicViscosityUnit.SquareYardPerSecond, UnitConverterKinematicViscosityUnit.SquareYardPerMinute };
            }
        }
    }
}
