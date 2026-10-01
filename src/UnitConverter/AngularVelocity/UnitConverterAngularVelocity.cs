namespace UnitConverter.AngularVelocity
{
    using UnitConverter.AngularVelocity.Scientific;
    using UnitConverter.AngularVelocity.Common;
    using UnitConverter.AngularVelocity.Metric;

    public enum UnitConverterAngularVelocityUnit
    {
        RadianPerSecond = 0,
        DegreePerSecond = 1,
        DegreePerMinute = 2,
        RevolutionPerSecond = 3,
        RevolutionPerMinute = 4,
        RevolutionPerHour = 5,
        RadianPerMinute = 6,
        RadianPerHour = 7,
        DegreePerHour = 8,
        RevolutionPerDay = 9,
        TurnPerSecond = 10,
        TurnPerMinute = 11,
        CyclePerSecond = 12,
        MilliradianPerSecond = 13,
    }

    public static class UnitConverterAngularVelocity
    {
        public static double Convert(double value, UnitConverterAngularVelocityUnit from, UnitConverterAngularVelocityUnit to)
        {
            double baseValue = ToRadianPerSecond(value, from);
            return FromRadianPerSecond(baseValue, to);
        }

        public static double ToRadianPerSecond(double value, UnitConverterAngularVelocityUnit from)
        {
            switch (from)
            {
                case UnitConverterAngularVelocityUnit.RadianPerSecond:
                    return UnitConverterScientificAngularVelocity.RadianPerSecondToRadianPerSecond(value);
                case UnitConverterAngularVelocityUnit.DegreePerSecond:
                    return UnitConverterCommonAngularVelocity.DegreePerSecondToRadianPerSecond(value);
                case UnitConverterAngularVelocityUnit.DegreePerMinute:
                    return UnitConverterCommonAngularVelocity.DegreePerMinuteToRadianPerSecond(value);
                case UnitConverterAngularVelocityUnit.RevolutionPerSecond:
                    return UnitConverterCommonAngularVelocity.RevolutionPerSecondToRadianPerSecond(value);
                case UnitConverterAngularVelocityUnit.RevolutionPerMinute:
                    return UnitConverterCommonAngularVelocity.RevolutionPerMinuteToRadianPerSecond(value);
                case UnitConverterAngularVelocityUnit.RevolutionPerHour:
                    return UnitConverterCommonAngularVelocity.RevolutionPerHourToRadianPerSecond(value);
                case UnitConverterAngularVelocityUnit.RadianPerMinute:
                    return UnitConverterMetricAngularVelocity.RadianPerMinuteToRadianPerSecond(value);
                case UnitConverterAngularVelocityUnit.RadianPerHour:
                    return UnitConverterMetricAngularVelocity.RadianPerHourToRadianPerSecond(value);
                case UnitConverterAngularVelocityUnit.DegreePerHour:
                    return UnitConverterMetricAngularVelocity.DegreePerHourToRadianPerSecond(value);
                case UnitConverterAngularVelocityUnit.RevolutionPerDay:
                    return UnitConverterCommonAngularVelocity.RevolutionPerDayToRadianPerSecond(value);
                case UnitConverterAngularVelocityUnit.TurnPerSecond:
                    return UnitConverterCommonAngularVelocity.TurnPerSecondToRadianPerSecond(value);
                case UnitConverterAngularVelocityUnit.TurnPerMinute:
                    return UnitConverterCommonAngularVelocity.TurnPerMinuteToRadianPerSecond(value);
                case UnitConverterAngularVelocityUnit.CyclePerSecond:
                    return UnitConverterCommonAngularVelocity.CyclePerSecondToRadianPerSecond(value);
                case UnitConverterAngularVelocityUnit.MilliradianPerSecond:
                    return UnitConverterMetricAngularVelocity.MilliradianPerSecondToRadianPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported angular velocity unit.");
            }
        }

        public static double FromRadianPerSecond(double baseValue, UnitConverterAngularVelocityUnit to)
        {
            switch (to)
            {
                case UnitConverterAngularVelocityUnit.RadianPerSecond:
                    return UnitConverterScientificAngularVelocity.RadianPerSecondToRadianPerSecond(baseValue);
                case UnitConverterAngularVelocityUnit.DegreePerSecond:
                    return UnitConverterCommonAngularVelocity.RadianPerSecondToDegreePerSecond(baseValue);
                case UnitConverterAngularVelocityUnit.DegreePerMinute:
                    return UnitConverterCommonAngularVelocity.RadianPerSecondToDegreePerMinute(baseValue);
                case UnitConverterAngularVelocityUnit.RevolutionPerSecond:
                    return UnitConverterCommonAngularVelocity.RadianPerSecondToRevolutionPerSecond(baseValue);
                case UnitConverterAngularVelocityUnit.RevolutionPerMinute:
                    return UnitConverterCommonAngularVelocity.RadianPerSecondToRevolutionPerMinute(baseValue);
                case UnitConverterAngularVelocityUnit.RevolutionPerHour:
                    return UnitConverterCommonAngularVelocity.RadianPerSecondToRevolutionPerHour(baseValue);
                case UnitConverterAngularVelocityUnit.RadianPerMinute:
                    return UnitConverterMetricAngularVelocity.RadianPerSecondToRadianPerMinute(baseValue);
                case UnitConverterAngularVelocityUnit.RadianPerHour:
                    return UnitConverterMetricAngularVelocity.RadianPerSecondToRadianPerHour(baseValue);
                case UnitConverterAngularVelocityUnit.DegreePerHour:
                    return UnitConverterMetricAngularVelocity.RadianPerSecondToDegreePerHour(baseValue);
                case UnitConverterAngularVelocityUnit.RevolutionPerDay:
                    return UnitConverterCommonAngularVelocity.RadianPerSecondToRevolutionPerDay(baseValue);
                case UnitConverterAngularVelocityUnit.TurnPerSecond:
                    return UnitConverterCommonAngularVelocity.RadianPerSecondToTurnPerSecond(baseValue);
                case UnitConverterAngularVelocityUnit.TurnPerMinute:
                    return UnitConverterCommonAngularVelocity.RadianPerSecondToTurnPerMinute(baseValue);
                case UnitConverterAngularVelocityUnit.CyclePerSecond:
                    return UnitConverterCommonAngularVelocity.RadianPerSecondToCyclePerSecond(baseValue);
                case UnitConverterAngularVelocityUnit.MilliradianPerSecond:
                    return UnitConverterMetricAngularVelocity.RadianPerSecondToMilliradianPerSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported angular velocity unit.");
            }
        }

        public static string GetSymbol(UnitConverterAngularVelocityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAngularVelocityUnit.RadianPerSecond:
                    return "rad/s";
                case UnitConverterAngularVelocityUnit.DegreePerSecond:
                    return "°/s";
                case UnitConverterAngularVelocityUnit.DegreePerMinute:
                    return "°/min";
                case UnitConverterAngularVelocityUnit.RevolutionPerSecond:
                    return "rev/s";
                case UnitConverterAngularVelocityUnit.RevolutionPerMinute:
                    return "rpm";
                case UnitConverterAngularVelocityUnit.RevolutionPerHour:
                    return "rev/h";
                case UnitConverterAngularVelocityUnit.RadianPerMinute:
                    return "rad/min";
                case UnitConverterAngularVelocityUnit.RadianPerHour:
                    return "rad/h";
                case UnitConverterAngularVelocityUnit.DegreePerHour:
                    return "°/h";
                case UnitConverterAngularVelocityUnit.RevolutionPerDay:
                    return "rev/d";
                case UnitConverterAngularVelocityUnit.TurnPerSecond:
                    return "turn/s";
                case UnitConverterAngularVelocityUnit.TurnPerMinute:
                    return "turn/min";
                case UnitConverterAngularVelocityUnit.CyclePerSecond:
                    return "cycle/s";
                case UnitConverterAngularVelocityUnit.MilliradianPerSecond:
                    return "mrad/s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterAngularVelocityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAngularVelocityUnit.RadianPerSecond:
                    return "radian per second";
                case UnitConverterAngularVelocityUnit.DegreePerSecond:
                    return "degree per second";
                case UnitConverterAngularVelocityUnit.DegreePerMinute:
                    return "degree per minute";
                case UnitConverterAngularVelocityUnit.RevolutionPerSecond:
                    return "revolution per second";
                case UnitConverterAngularVelocityUnit.RevolutionPerMinute:
                    return "revolution per minute";
                case UnitConverterAngularVelocityUnit.RevolutionPerHour:
                    return "revolution per hour";
                case UnitConverterAngularVelocityUnit.RadianPerMinute:
                    return "Radian Per Minute";
                case UnitConverterAngularVelocityUnit.RadianPerHour:
                    return "Radian Per Hour";
                case UnitConverterAngularVelocityUnit.DegreePerHour:
                    return "Degree Per Hour";
                case UnitConverterAngularVelocityUnit.RevolutionPerDay:
                    return "Revolution Per Day";
                case UnitConverterAngularVelocityUnit.TurnPerSecond:
                    return "Turn Per Second";
                case UnitConverterAngularVelocityUnit.TurnPerMinute:
                    return "Turn Per Minute";
                case UnitConverterAngularVelocityUnit.CyclePerSecond:
                    return "Cycle Per Second";
                case UnitConverterAngularVelocityUnit.MilliradianPerSecond:
                    return "Milliradian Per Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterAngularVelocityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAngularVelocityUnit.RadianPerSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAngularVelocityUnit.DegreePerSecond:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularVelocityUnit.DegreePerMinute:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularVelocityUnit.RevolutionPerSecond:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularVelocityUnit.RevolutionPerMinute:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularVelocityUnit.RevolutionPerHour:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularVelocityUnit.RadianPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngularVelocityUnit.RadianPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngularVelocityUnit.DegreePerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngularVelocityUnit.RevolutionPerDay:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularVelocityUnit.TurnPerSecond:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularVelocityUnit.TurnPerMinute:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularVelocityUnit.CyclePerSecond:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularVelocityUnit.MilliradianPerSecond:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterAngularVelocityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterAngularVelocityUnit.RadianPerSecond };
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterAngularVelocityUnit.DegreePerSecond, UnitConverterAngularVelocityUnit.DegreePerMinute, UnitConverterAngularVelocityUnit.RevolutionPerSecond, UnitConverterAngularVelocityUnit.RevolutionPerMinute, UnitConverterAngularVelocityUnit.RevolutionPerHour, UnitConverterAngularVelocityUnit.RevolutionPerDay, UnitConverterAngularVelocityUnit.TurnPerSecond, UnitConverterAngularVelocityUnit.TurnPerMinute, UnitConverterAngularVelocityUnit.CyclePerSecond };
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterAngularVelocityUnit.RadianPerMinute, UnitConverterAngularVelocityUnit.RadianPerHour, UnitConverterAngularVelocityUnit.DegreePerHour, UnitConverterAngularVelocityUnit.MilliradianPerSecond };
                default:
                    return new[] { UnitConverterAngularVelocityUnit.RadianPerSecond, UnitConverterAngularVelocityUnit.DegreePerSecond, UnitConverterAngularVelocityUnit.DegreePerMinute, UnitConverterAngularVelocityUnit.RevolutionPerSecond, UnitConverterAngularVelocityUnit.RevolutionPerMinute, UnitConverterAngularVelocityUnit.RevolutionPerHour, UnitConverterAngularVelocityUnit.RadianPerMinute, UnitConverterAngularVelocityUnit.RadianPerHour, UnitConverterAngularVelocityUnit.DegreePerHour, UnitConverterAngularVelocityUnit.RevolutionPerDay, UnitConverterAngularVelocityUnit.TurnPerSecond, UnitConverterAngularVelocityUnit.TurnPerMinute, UnitConverterAngularVelocityUnit.CyclePerSecond, UnitConverterAngularVelocityUnit.MilliradianPerSecond };
            }
        }
    }
}
