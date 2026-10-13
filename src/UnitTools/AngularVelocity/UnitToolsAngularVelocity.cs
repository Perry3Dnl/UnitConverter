namespace UnitTools.AngularVelocity
{
    using UnitTools.AngularVelocity.Scientific;
    using UnitTools.AngularVelocity.Common;
    using UnitTools.AngularVelocity.Metric;

    public enum UnitToolsAngularVelocityUnit
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

    public static class UnitToolsAngularVelocity
    {
        public static double Convert(double value, UnitToolsAngularVelocityUnit from, UnitToolsAngularVelocityUnit to)
        {
            double baseValue = ToRadianPerSecond(value, from);
            return FromRadianPerSecond(baseValue, to);
        }

        public static double ToRadianPerSecond(double value, UnitToolsAngularVelocityUnit from)
        {
            switch (from)
            {
                case UnitToolsAngularVelocityUnit.RadianPerSecond:
                    return UnitToolsScientificAngularVelocity.RadianPerSecondToRadianPerSecond(value);
                case UnitToolsAngularVelocityUnit.DegreePerSecond:
                    return UnitToolsCommonAngularVelocity.DegreePerSecondToRadianPerSecond(value);
                case UnitToolsAngularVelocityUnit.DegreePerMinute:
                    return UnitToolsCommonAngularVelocity.DegreePerMinuteToRadianPerSecond(value);
                case UnitToolsAngularVelocityUnit.RevolutionPerSecond:
                    return UnitToolsCommonAngularVelocity.RevolutionPerSecondToRadianPerSecond(value);
                case UnitToolsAngularVelocityUnit.RevolutionPerMinute:
                    return UnitToolsCommonAngularVelocity.RevolutionPerMinuteToRadianPerSecond(value);
                case UnitToolsAngularVelocityUnit.RevolutionPerHour:
                    return UnitToolsCommonAngularVelocity.RevolutionPerHourToRadianPerSecond(value);
                case UnitToolsAngularVelocityUnit.RadianPerMinute:
                    return UnitToolsMetricAngularVelocity.RadianPerMinuteToRadianPerSecond(value);
                case UnitToolsAngularVelocityUnit.RadianPerHour:
                    return UnitToolsMetricAngularVelocity.RadianPerHourToRadianPerSecond(value);
                case UnitToolsAngularVelocityUnit.DegreePerHour:
                    return UnitToolsMetricAngularVelocity.DegreePerHourToRadianPerSecond(value);
                case UnitToolsAngularVelocityUnit.RevolutionPerDay:
                    return UnitToolsCommonAngularVelocity.RevolutionPerDayToRadianPerSecond(value);
                case UnitToolsAngularVelocityUnit.TurnPerSecond:
                    return UnitToolsCommonAngularVelocity.TurnPerSecondToRadianPerSecond(value);
                case UnitToolsAngularVelocityUnit.TurnPerMinute:
                    return UnitToolsCommonAngularVelocity.TurnPerMinuteToRadianPerSecond(value);
                case UnitToolsAngularVelocityUnit.CyclePerSecond:
                    return UnitToolsCommonAngularVelocity.CyclePerSecondToRadianPerSecond(value);
                case UnitToolsAngularVelocityUnit.MilliradianPerSecond:
                    return UnitToolsMetricAngularVelocity.MilliradianPerSecondToRadianPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported angular velocity unit.");
            }
        }

        public static double FromRadianPerSecond(double baseValue, UnitToolsAngularVelocityUnit to)
        {
            switch (to)
            {
                case UnitToolsAngularVelocityUnit.RadianPerSecond:
                    return UnitToolsScientificAngularVelocity.RadianPerSecondToRadianPerSecond(baseValue);
                case UnitToolsAngularVelocityUnit.DegreePerSecond:
                    return UnitToolsCommonAngularVelocity.RadianPerSecondToDegreePerSecond(baseValue);
                case UnitToolsAngularVelocityUnit.DegreePerMinute:
                    return UnitToolsCommonAngularVelocity.RadianPerSecondToDegreePerMinute(baseValue);
                case UnitToolsAngularVelocityUnit.RevolutionPerSecond:
                    return UnitToolsCommonAngularVelocity.RadianPerSecondToRevolutionPerSecond(baseValue);
                case UnitToolsAngularVelocityUnit.RevolutionPerMinute:
                    return UnitToolsCommonAngularVelocity.RadianPerSecondToRevolutionPerMinute(baseValue);
                case UnitToolsAngularVelocityUnit.RevolutionPerHour:
                    return UnitToolsCommonAngularVelocity.RadianPerSecondToRevolutionPerHour(baseValue);
                case UnitToolsAngularVelocityUnit.RadianPerMinute:
                    return UnitToolsMetricAngularVelocity.RadianPerSecondToRadianPerMinute(baseValue);
                case UnitToolsAngularVelocityUnit.RadianPerHour:
                    return UnitToolsMetricAngularVelocity.RadianPerSecondToRadianPerHour(baseValue);
                case UnitToolsAngularVelocityUnit.DegreePerHour:
                    return UnitToolsMetricAngularVelocity.RadianPerSecondToDegreePerHour(baseValue);
                case UnitToolsAngularVelocityUnit.RevolutionPerDay:
                    return UnitToolsCommonAngularVelocity.RadianPerSecondToRevolutionPerDay(baseValue);
                case UnitToolsAngularVelocityUnit.TurnPerSecond:
                    return UnitToolsCommonAngularVelocity.RadianPerSecondToTurnPerSecond(baseValue);
                case UnitToolsAngularVelocityUnit.TurnPerMinute:
                    return UnitToolsCommonAngularVelocity.RadianPerSecondToTurnPerMinute(baseValue);
                case UnitToolsAngularVelocityUnit.CyclePerSecond:
                    return UnitToolsCommonAngularVelocity.RadianPerSecondToCyclePerSecond(baseValue);
                case UnitToolsAngularVelocityUnit.MilliradianPerSecond:
                    return UnitToolsMetricAngularVelocity.RadianPerSecondToMilliradianPerSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported angular velocity unit.");
            }
        }

        public static string GetSymbol(UnitToolsAngularVelocityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAngularVelocityUnit.RadianPerSecond:
                    return "rad/s";
                case UnitToolsAngularVelocityUnit.DegreePerSecond:
                    return "°/s";
                case UnitToolsAngularVelocityUnit.DegreePerMinute:
                    return "°/min";
                case UnitToolsAngularVelocityUnit.RevolutionPerSecond:
                    return "rev/s";
                case UnitToolsAngularVelocityUnit.RevolutionPerMinute:
                    return "rpm";
                case UnitToolsAngularVelocityUnit.RevolutionPerHour:
                    return "rev/h";
                case UnitToolsAngularVelocityUnit.RadianPerMinute:
                    return "rad/min";
                case UnitToolsAngularVelocityUnit.RadianPerHour:
                    return "rad/h";
                case UnitToolsAngularVelocityUnit.DegreePerHour:
                    return "°/h";
                case UnitToolsAngularVelocityUnit.RevolutionPerDay:
                    return "rev/d";
                case UnitToolsAngularVelocityUnit.TurnPerSecond:
                    return "turn/s";
                case UnitToolsAngularVelocityUnit.TurnPerMinute:
                    return "turn/min";
                case UnitToolsAngularVelocityUnit.CyclePerSecond:
                    return "cycle/s";
                case UnitToolsAngularVelocityUnit.MilliradianPerSecond:
                    return "mrad/s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsAngularVelocityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAngularVelocityUnit.RadianPerSecond:
                    return "radian per second";
                case UnitToolsAngularVelocityUnit.DegreePerSecond:
                    return "degree per second";
                case UnitToolsAngularVelocityUnit.DegreePerMinute:
                    return "degree per minute";
                case UnitToolsAngularVelocityUnit.RevolutionPerSecond:
                    return "revolution per second";
                case UnitToolsAngularVelocityUnit.RevolutionPerMinute:
                    return "revolution per minute";
                case UnitToolsAngularVelocityUnit.RevolutionPerHour:
                    return "revolution per hour";
                case UnitToolsAngularVelocityUnit.RadianPerMinute:
                    return "Radian Per Minute";
                case UnitToolsAngularVelocityUnit.RadianPerHour:
                    return "Radian Per Hour";
                case UnitToolsAngularVelocityUnit.DegreePerHour:
                    return "Degree Per Hour";
                case UnitToolsAngularVelocityUnit.RevolutionPerDay:
                    return "Revolution Per Day";
                case UnitToolsAngularVelocityUnit.TurnPerSecond:
                    return "Turn Per Second";
                case UnitToolsAngularVelocityUnit.TurnPerMinute:
                    return "Turn Per Minute";
                case UnitToolsAngularVelocityUnit.CyclePerSecond:
                    return "Cycle Per Second";
                case UnitToolsAngularVelocityUnit.MilliradianPerSecond:
                    return "Milliradian Per Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsAngularVelocityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAngularVelocityUnit.RadianPerSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAngularVelocityUnit.DegreePerSecond:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularVelocityUnit.DegreePerMinute:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularVelocityUnit.RevolutionPerSecond:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularVelocityUnit.RevolutionPerMinute:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularVelocityUnit.RevolutionPerHour:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularVelocityUnit.RadianPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngularVelocityUnit.RadianPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngularVelocityUnit.DegreePerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngularVelocityUnit.RevolutionPerDay:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularVelocityUnit.TurnPerSecond:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularVelocityUnit.TurnPerMinute:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularVelocityUnit.CyclePerSecond:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularVelocityUnit.MilliradianPerSecond:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsAngularVelocityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsAngularVelocityUnit.RadianPerSecond };
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsAngularVelocityUnit.DegreePerSecond, UnitToolsAngularVelocityUnit.DegreePerMinute, UnitToolsAngularVelocityUnit.RevolutionPerSecond, UnitToolsAngularVelocityUnit.RevolutionPerMinute, UnitToolsAngularVelocityUnit.RevolutionPerHour, UnitToolsAngularVelocityUnit.RevolutionPerDay, UnitToolsAngularVelocityUnit.TurnPerSecond, UnitToolsAngularVelocityUnit.TurnPerMinute, UnitToolsAngularVelocityUnit.CyclePerSecond };
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsAngularVelocityUnit.RadianPerMinute, UnitToolsAngularVelocityUnit.RadianPerHour, UnitToolsAngularVelocityUnit.DegreePerHour, UnitToolsAngularVelocityUnit.MilliradianPerSecond };
                default:
                    return new[] { UnitToolsAngularVelocityUnit.RadianPerSecond, UnitToolsAngularVelocityUnit.DegreePerSecond, UnitToolsAngularVelocityUnit.DegreePerMinute, UnitToolsAngularVelocityUnit.RevolutionPerSecond, UnitToolsAngularVelocityUnit.RevolutionPerMinute, UnitToolsAngularVelocityUnit.RevolutionPerHour, UnitToolsAngularVelocityUnit.RadianPerMinute, UnitToolsAngularVelocityUnit.RadianPerHour, UnitToolsAngularVelocityUnit.DegreePerHour, UnitToolsAngularVelocityUnit.RevolutionPerDay, UnitToolsAngularVelocityUnit.TurnPerSecond, UnitToolsAngularVelocityUnit.TurnPerMinute, UnitToolsAngularVelocityUnit.CyclePerSecond, UnitToolsAngularVelocityUnit.MilliradianPerSecond };
            }
        }
    }
}
