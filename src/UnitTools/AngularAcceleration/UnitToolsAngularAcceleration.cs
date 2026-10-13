namespace UnitTools.AngularAcceleration
{
    using UnitTools.AngularAcceleration.Scientific;
    using UnitTools.AngularAcceleration.Common;
    using UnitTools.AngularAcceleration.Metric;

    public enum UnitToolsAngularAccelerationUnit
    {
        RadianPerSecondSquared = 0,
        DegreePerSecondSquared = 1,
        RevolutionPerSecondSquared = 2,
        RevolutionPerMinutePerSecond = 3,
        MilliradianPerSecondSquared = 4,
        RadianPerMinuteSquared = 5,
        DegreePerMinuteSquared = 6,
        RevolutionPerMinuteSquared = 7,
        TurnPerSecondSquared = 8,
        TurnPerMinuteSquared = 9,
    }

    public static class UnitToolsAngularAcceleration
    {
        public static double Convert(double value, UnitToolsAngularAccelerationUnit from, UnitToolsAngularAccelerationUnit to)
        {
            double baseValue = ToRadianPerSecondSquared(value, from);
            return FromRadianPerSecondSquared(baseValue, to);
        }

        public static double ToRadianPerSecondSquared(double value, UnitToolsAngularAccelerationUnit from)
        {
            switch (from)
            {
                case UnitToolsAngularAccelerationUnit.RadianPerSecondSquared:
                    return UnitToolsScientificAngularAcceleration.RadianPerSecondSquaredToRadianPerSecondSquared(value);
                case UnitToolsAngularAccelerationUnit.DegreePerSecondSquared:
                    return UnitToolsCommonAngularAcceleration.DegreePerSecondSquaredToRadianPerSecondSquared(value);
                case UnitToolsAngularAccelerationUnit.RevolutionPerSecondSquared:
                    return UnitToolsCommonAngularAcceleration.RevolutionPerSecondSquaredToRadianPerSecondSquared(value);
                case UnitToolsAngularAccelerationUnit.RevolutionPerMinutePerSecond:
                    return UnitToolsCommonAngularAcceleration.RevolutionPerMinutePerSecondToRadianPerSecondSquared(value);
                case UnitToolsAngularAccelerationUnit.MilliradianPerSecondSquared:
                    return UnitToolsMetricAngularAcceleration.MilliradianPerSecondSquaredToRadianPerSecondSquared(value);
                case UnitToolsAngularAccelerationUnit.RadianPerMinuteSquared:
                    return UnitToolsMetricAngularAcceleration.RadianPerMinuteSquaredToRadianPerSecondSquared(value);
                case UnitToolsAngularAccelerationUnit.DegreePerMinuteSquared:
                    return UnitToolsMetricAngularAcceleration.DegreePerMinuteSquaredToRadianPerSecondSquared(value);
                case UnitToolsAngularAccelerationUnit.RevolutionPerMinuteSquared:
                    return UnitToolsCommonAngularAcceleration.RevolutionPerMinuteSquaredToRadianPerSecondSquared(value);
                case UnitToolsAngularAccelerationUnit.TurnPerSecondSquared:
                    return UnitToolsCommonAngularAcceleration.TurnPerSecondSquaredToRadianPerSecondSquared(value);
                case UnitToolsAngularAccelerationUnit.TurnPerMinuteSquared:
                    return UnitToolsCommonAngularAcceleration.TurnPerMinuteSquaredToRadianPerSecondSquared(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported angular acceleration unit.");
            }
        }

        public static double FromRadianPerSecondSquared(double baseValue, UnitToolsAngularAccelerationUnit to)
        {
            switch (to)
            {
                case UnitToolsAngularAccelerationUnit.RadianPerSecondSquared:
                    return UnitToolsScientificAngularAcceleration.RadianPerSecondSquaredToRadianPerSecondSquared(baseValue);
                case UnitToolsAngularAccelerationUnit.DegreePerSecondSquared:
                    return UnitToolsCommonAngularAcceleration.RadianPerSecondSquaredToDegreePerSecondSquared(baseValue);
                case UnitToolsAngularAccelerationUnit.RevolutionPerSecondSquared:
                    return UnitToolsCommonAngularAcceleration.RadianPerSecondSquaredToRevolutionPerSecondSquared(baseValue);
                case UnitToolsAngularAccelerationUnit.RevolutionPerMinutePerSecond:
                    return UnitToolsCommonAngularAcceleration.RadianPerSecondSquaredToRevolutionPerMinutePerSecond(baseValue);
                case UnitToolsAngularAccelerationUnit.MilliradianPerSecondSquared:
                    return UnitToolsMetricAngularAcceleration.RadianPerSecondSquaredToMilliradianPerSecondSquared(baseValue);
                case UnitToolsAngularAccelerationUnit.RadianPerMinuteSquared:
                    return UnitToolsMetricAngularAcceleration.RadianPerSecondSquaredToRadianPerMinuteSquared(baseValue);
                case UnitToolsAngularAccelerationUnit.DegreePerMinuteSquared:
                    return UnitToolsMetricAngularAcceleration.RadianPerSecondSquaredToDegreePerMinuteSquared(baseValue);
                case UnitToolsAngularAccelerationUnit.RevolutionPerMinuteSquared:
                    return UnitToolsCommonAngularAcceleration.RadianPerSecondSquaredToRevolutionPerMinuteSquared(baseValue);
                case UnitToolsAngularAccelerationUnit.TurnPerSecondSquared:
                    return UnitToolsCommonAngularAcceleration.RadianPerSecondSquaredToTurnPerSecondSquared(baseValue);
                case UnitToolsAngularAccelerationUnit.TurnPerMinuteSquared:
                    return UnitToolsCommonAngularAcceleration.RadianPerSecondSquaredToTurnPerMinuteSquared(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported angular acceleration unit.");
            }
        }

        public static string GetSymbol(UnitToolsAngularAccelerationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAngularAccelerationUnit.RadianPerSecondSquared:
                    return "rad/s²";
                case UnitToolsAngularAccelerationUnit.DegreePerSecondSquared:
                    return "°/s²";
                case UnitToolsAngularAccelerationUnit.RevolutionPerSecondSquared:
                    return "rev/s²";
                case UnitToolsAngularAccelerationUnit.RevolutionPerMinutePerSecond:
                    return "rpm/s";
                case UnitToolsAngularAccelerationUnit.MilliradianPerSecondSquared:
                    return "mrad/s²";
                case UnitToolsAngularAccelerationUnit.RadianPerMinuteSquared:
                    return "rad/min²";
                case UnitToolsAngularAccelerationUnit.DegreePerMinuteSquared:
                    return "°/min²";
                case UnitToolsAngularAccelerationUnit.RevolutionPerMinuteSquared:
                    return "rev/min²";
                case UnitToolsAngularAccelerationUnit.TurnPerSecondSquared:
                    return "turn/s²";
                case UnitToolsAngularAccelerationUnit.TurnPerMinuteSquared:
                    return "turn/min²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsAngularAccelerationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAngularAccelerationUnit.RadianPerSecondSquared:
                    return "radian per second squared";
                case UnitToolsAngularAccelerationUnit.DegreePerSecondSquared:
                    return "degree per second squared";
                case UnitToolsAngularAccelerationUnit.RevolutionPerSecondSquared:
                    return "revolution per second squared";
                case UnitToolsAngularAccelerationUnit.RevolutionPerMinutePerSecond:
                    return "revolution per minute per second";
                case UnitToolsAngularAccelerationUnit.MilliradianPerSecondSquared:
                    return "Milliradian Per Second Squared";
                case UnitToolsAngularAccelerationUnit.RadianPerMinuteSquared:
                    return "Radian Per Minute Squared";
                case UnitToolsAngularAccelerationUnit.DegreePerMinuteSquared:
                    return "Degree Per Minute Squared";
                case UnitToolsAngularAccelerationUnit.RevolutionPerMinuteSquared:
                    return "Revolution Per Minute Squared";
                case UnitToolsAngularAccelerationUnit.TurnPerSecondSquared:
                    return "Turn Per Second Squared";
                case UnitToolsAngularAccelerationUnit.TurnPerMinuteSquared:
                    return "Turn Per Minute Squared";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsAngularAccelerationUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAngularAccelerationUnit.RadianPerSecondSquared:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAngularAccelerationUnit.DegreePerSecondSquared:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularAccelerationUnit.RevolutionPerSecondSquared:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularAccelerationUnit.RevolutionPerMinutePerSecond:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularAccelerationUnit.MilliradianPerSecondSquared:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngularAccelerationUnit.RadianPerMinuteSquared:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngularAccelerationUnit.DegreePerMinuteSquared:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngularAccelerationUnit.RevolutionPerMinuteSquared:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularAccelerationUnit.TurnPerSecondSquared:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngularAccelerationUnit.TurnPerMinuteSquared:
                    return UnitToolsUnitSystem.Common;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsAngularAccelerationUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsAngularAccelerationUnit.RadianPerSecondSquared };
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsAngularAccelerationUnit.DegreePerSecondSquared, UnitToolsAngularAccelerationUnit.RevolutionPerSecondSquared, UnitToolsAngularAccelerationUnit.RevolutionPerMinutePerSecond, UnitToolsAngularAccelerationUnit.RevolutionPerMinuteSquared, UnitToolsAngularAccelerationUnit.TurnPerSecondSquared, UnitToolsAngularAccelerationUnit.TurnPerMinuteSquared };
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsAngularAccelerationUnit.MilliradianPerSecondSquared, UnitToolsAngularAccelerationUnit.RadianPerMinuteSquared, UnitToolsAngularAccelerationUnit.DegreePerMinuteSquared };
                default:
                    return new[] { UnitToolsAngularAccelerationUnit.RadianPerSecondSquared, UnitToolsAngularAccelerationUnit.DegreePerSecondSquared, UnitToolsAngularAccelerationUnit.RevolutionPerSecondSquared, UnitToolsAngularAccelerationUnit.RevolutionPerMinutePerSecond, UnitToolsAngularAccelerationUnit.MilliradianPerSecondSquared, UnitToolsAngularAccelerationUnit.RadianPerMinuteSquared, UnitToolsAngularAccelerationUnit.DegreePerMinuteSquared, UnitToolsAngularAccelerationUnit.RevolutionPerMinuteSquared, UnitToolsAngularAccelerationUnit.TurnPerSecondSquared, UnitToolsAngularAccelerationUnit.TurnPerMinuteSquared };
            }
        }
    }
}
