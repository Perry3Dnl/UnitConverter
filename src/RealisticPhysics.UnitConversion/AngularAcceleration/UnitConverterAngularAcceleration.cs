namespace RealisticPhysics.UnitConversion.AngularAcceleration
{
    using RealisticPhysics.UnitConversion.AngularAcceleration.Scientific;
    using RealisticPhysics.UnitConversion.AngularAcceleration.Common;
    using RealisticPhysics.UnitConversion.AngularAcceleration.Metric;

    public enum UnitConverterAngularAccelerationUnit
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

    public static class UnitConverterAngularAcceleration
    {
        public static double Convert(double value, UnitConverterAngularAccelerationUnit from, UnitConverterAngularAccelerationUnit to)
        {
            double baseValue = ToRadianPerSecondSquared(value, from);
            return FromRadianPerSecondSquared(baseValue, to);
        }

        public static double ToRadianPerSecondSquared(double value, UnitConverterAngularAccelerationUnit from)
        {
            switch (from)
            {
                case UnitConverterAngularAccelerationUnit.RadianPerSecondSquared:
                    return UnitConverterScientificAngularAcceleration.RadianPerSecondSquaredToRadianPerSecondSquared(value);
                case UnitConverterAngularAccelerationUnit.DegreePerSecondSquared:
                    return UnitConverterCommonAngularAcceleration.DegreePerSecondSquaredToRadianPerSecondSquared(value);
                case UnitConverterAngularAccelerationUnit.RevolutionPerSecondSquared:
                    return UnitConverterCommonAngularAcceleration.RevolutionPerSecondSquaredToRadianPerSecondSquared(value);
                case UnitConverterAngularAccelerationUnit.RevolutionPerMinutePerSecond:
                    return UnitConverterCommonAngularAcceleration.RevolutionPerMinutePerSecondToRadianPerSecondSquared(value);
                case UnitConverterAngularAccelerationUnit.MilliradianPerSecondSquared:
                    return UnitConverterMetricAngularAcceleration.MilliradianPerSecondSquaredToRadianPerSecondSquared(value);
                case UnitConverterAngularAccelerationUnit.RadianPerMinuteSquared:
                    return UnitConverterMetricAngularAcceleration.RadianPerMinuteSquaredToRadianPerSecondSquared(value);
                case UnitConverterAngularAccelerationUnit.DegreePerMinuteSquared:
                    return UnitConverterMetricAngularAcceleration.DegreePerMinuteSquaredToRadianPerSecondSquared(value);
                case UnitConverterAngularAccelerationUnit.RevolutionPerMinuteSquared:
                    return UnitConverterCommonAngularAcceleration.RevolutionPerMinuteSquaredToRadianPerSecondSquared(value);
                case UnitConverterAngularAccelerationUnit.TurnPerSecondSquared:
                    return UnitConverterCommonAngularAcceleration.TurnPerSecondSquaredToRadianPerSecondSquared(value);
                case UnitConverterAngularAccelerationUnit.TurnPerMinuteSquared:
                    return UnitConverterCommonAngularAcceleration.TurnPerMinuteSquaredToRadianPerSecondSquared(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported angular acceleration unit.");
            }
        }

        public static double FromRadianPerSecondSquared(double baseValue, UnitConverterAngularAccelerationUnit to)
        {
            switch (to)
            {
                case UnitConverterAngularAccelerationUnit.RadianPerSecondSquared:
                    return UnitConverterScientificAngularAcceleration.RadianPerSecondSquaredToRadianPerSecondSquared(baseValue);
                case UnitConverterAngularAccelerationUnit.DegreePerSecondSquared:
                    return UnitConverterCommonAngularAcceleration.RadianPerSecondSquaredToDegreePerSecondSquared(baseValue);
                case UnitConverterAngularAccelerationUnit.RevolutionPerSecondSquared:
                    return UnitConverterCommonAngularAcceleration.RadianPerSecondSquaredToRevolutionPerSecondSquared(baseValue);
                case UnitConverterAngularAccelerationUnit.RevolutionPerMinutePerSecond:
                    return UnitConverterCommonAngularAcceleration.RadianPerSecondSquaredToRevolutionPerMinutePerSecond(baseValue);
                case UnitConverterAngularAccelerationUnit.MilliradianPerSecondSquared:
                    return UnitConverterMetricAngularAcceleration.RadianPerSecondSquaredToMilliradianPerSecondSquared(baseValue);
                case UnitConverterAngularAccelerationUnit.RadianPerMinuteSquared:
                    return UnitConverterMetricAngularAcceleration.RadianPerSecondSquaredToRadianPerMinuteSquared(baseValue);
                case UnitConverterAngularAccelerationUnit.DegreePerMinuteSquared:
                    return UnitConverterMetricAngularAcceleration.RadianPerSecondSquaredToDegreePerMinuteSquared(baseValue);
                case UnitConverterAngularAccelerationUnit.RevolutionPerMinuteSquared:
                    return UnitConverterCommonAngularAcceleration.RadianPerSecondSquaredToRevolutionPerMinuteSquared(baseValue);
                case UnitConverterAngularAccelerationUnit.TurnPerSecondSquared:
                    return UnitConverterCommonAngularAcceleration.RadianPerSecondSquaredToTurnPerSecondSquared(baseValue);
                case UnitConverterAngularAccelerationUnit.TurnPerMinuteSquared:
                    return UnitConverterCommonAngularAcceleration.RadianPerSecondSquaredToTurnPerMinuteSquared(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported angular acceleration unit.");
            }
        }

        public static string GetSymbol(UnitConverterAngularAccelerationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAngularAccelerationUnit.RadianPerSecondSquared:
                    return "rad/s²";
                case UnitConverterAngularAccelerationUnit.DegreePerSecondSquared:
                    return "°/s²";
                case UnitConverterAngularAccelerationUnit.RevolutionPerSecondSquared:
                    return "rev/s²";
                case UnitConverterAngularAccelerationUnit.RevolutionPerMinutePerSecond:
                    return "rpm/s";
                case UnitConverterAngularAccelerationUnit.MilliradianPerSecondSquared:
                    return "mrad/s²";
                case UnitConverterAngularAccelerationUnit.RadianPerMinuteSquared:
                    return "rad/min²";
                case UnitConverterAngularAccelerationUnit.DegreePerMinuteSquared:
                    return "°/min²";
                case UnitConverterAngularAccelerationUnit.RevolutionPerMinuteSquared:
                    return "rev/min²";
                case UnitConverterAngularAccelerationUnit.TurnPerSecondSquared:
                    return "turn/s²";
                case UnitConverterAngularAccelerationUnit.TurnPerMinuteSquared:
                    return "turn/min²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterAngularAccelerationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAngularAccelerationUnit.RadianPerSecondSquared:
                    return "radian per second squared";
                case UnitConverterAngularAccelerationUnit.DegreePerSecondSquared:
                    return "degree per second squared";
                case UnitConverterAngularAccelerationUnit.RevolutionPerSecondSquared:
                    return "revolution per second squared";
                case UnitConverterAngularAccelerationUnit.RevolutionPerMinutePerSecond:
                    return "revolution per minute per second";
                case UnitConverterAngularAccelerationUnit.MilliradianPerSecondSquared:
                    return "Milliradian Per Second Squared";
                case UnitConverterAngularAccelerationUnit.RadianPerMinuteSquared:
                    return "Radian Per Minute Squared";
                case UnitConverterAngularAccelerationUnit.DegreePerMinuteSquared:
                    return "Degree Per Minute Squared";
                case UnitConverterAngularAccelerationUnit.RevolutionPerMinuteSquared:
                    return "Revolution Per Minute Squared";
                case UnitConverterAngularAccelerationUnit.TurnPerSecondSquared:
                    return "Turn Per Second Squared";
                case UnitConverterAngularAccelerationUnit.TurnPerMinuteSquared:
                    return "Turn Per Minute Squared";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterAngularAccelerationUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAngularAccelerationUnit.RadianPerSecondSquared:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAngularAccelerationUnit.DegreePerSecondSquared:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularAccelerationUnit.RevolutionPerSecondSquared:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularAccelerationUnit.RevolutionPerMinutePerSecond:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularAccelerationUnit.MilliradianPerSecondSquared:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngularAccelerationUnit.RadianPerMinuteSquared:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngularAccelerationUnit.DegreePerMinuteSquared:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngularAccelerationUnit.RevolutionPerMinuteSquared:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularAccelerationUnit.TurnPerSecondSquared:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterAngularAccelerationUnit.TurnPerMinuteSquared:
                    return UnitConverterUnitSystem.Common;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterAngularAccelerationUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterAngularAccelerationUnit.RadianPerSecondSquared };
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterAngularAccelerationUnit.DegreePerSecondSquared, UnitConverterAngularAccelerationUnit.RevolutionPerSecondSquared, UnitConverterAngularAccelerationUnit.RevolutionPerMinutePerSecond, UnitConverterAngularAccelerationUnit.RevolutionPerMinuteSquared, UnitConverterAngularAccelerationUnit.TurnPerSecondSquared, UnitConverterAngularAccelerationUnit.TurnPerMinuteSquared };
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterAngularAccelerationUnit.MilliradianPerSecondSquared, UnitConverterAngularAccelerationUnit.RadianPerMinuteSquared, UnitConverterAngularAccelerationUnit.DegreePerMinuteSquared };
                default:
                    return new[] { UnitConverterAngularAccelerationUnit.RadianPerSecondSquared, UnitConverterAngularAccelerationUnit.DegreePerSecondSquared, UnitConverterAngularAccelerationUnit.RevolutionPerSecondSquared, UnitConverterAngularAccelerationUnit.RevolutionPerMinutePerSecond, UnitConverterAngularAccelerationUnit.MilliradianPerSecondSquared, UnitConverterAngularAccelerationUnit.RadianPerMinuteSquared, UnitConverterAngularAccelerationUnit.DegreePerMinuteSquared, UnitConverterAngularAccelerationUnit.RevolutionPerMinuteSquared, UnitConverterAngularAccelerationUnit.TurnPerSecondSquared, UnitConverterAngularAccelerationUnit.TurnPerMinuteSquared };
            }
        }
    }
}
