namespace UnitTools.TorquePerAngle
{
    using UnitTools.TorquePerAngle.Metric;
    using UnitTools.TorquePerAngle.Imperial;

    public enum UnitToolsTorquePerAngleUnit
    {
        NewtonMeterPerRadian = 0,
        NewtonMeterPerDegree = 1,
        NewtonMeterPerTurn = 2,
        PoundForceFootPerRadian = 3,
        MillinewtonMeterPerRadian = 4,
        KilonewtonMeterPerRadian = 5,
        NewtonMillimeterPerRadian = 6,
        PoundForceInchPerDegree = 7,
        PoundForceFootPerDegree = 8,
        KilogramForceMeterPerRadian = 9,
    }

    public static class UnitToolsTorquePerAngle
    {
        public static double Convert(double value, UnitToolsTorquePerAngleUnit from, UnitToolsTorquePerAngleUnit to)
        {
            double baseValue = ToNewtonMeterPerRadian(value, from);
            return FromNewtonMeterPerRadian(baseValue, to);
        }

        public static double ToNewtonMeterPerRadian(double value, UnitToolsTorquePerAngleUnit from)
        {
            switch (from)
            {
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerRadian:
                    return UnitToolsMetricTorquePerAngle.NewtonMeterPerRadianToNewtonMeterPerRadian(value);
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerDegree:
                    return UnitToolsMetricTorquePerAngle.NewtonMeterPerDegreeToNewtonMeterPerRadian(value);
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerTurn:
                    return UnitToolsMetricTorquePerAngle.NewtonMeterPerTurnToNewtonMeterPerRadian(value);
                case UnitToolsTorquePerAngleUnit.PoundForceFootPerRadian:
                    return UnitToolsImperialTorquePerAngle.PoundForceFootPerRadianToNewtonMeterPerRadian(value);
                case UnitToolsTorquePerAngleUnit.MillinewtonMeterPerRadian:
                    return UnitToolsMetricTorquePerAngle.MillinewtonMeterPerRadianToNewtonMeterPerRadian(value);
                case UnitToolsTorquePerAngleUnit.KilonewtonMeterPerRadian:
                    return UnitToolsMetricTorquePerAngle.KilonewtonMeterPerRadianToNewtonMeterPerRadian(value);
                case UnitToolsTorquePerAngleUnit.NewtonMillimeterPerRadian:
                    return UnitToolsMetricTorquePerAngle.NewtonMillimeterPerRadianToNewtonMeterPerRadian(value);
                case UnitToolsTorquePerAngleUnit.PoundForceInchPerDegree:
                    return UnitToolsImperialTorquePerAngle.PoundForceInchPerDegreeToNewtonMeterPerRadian(value);
                case UnitToolsTorquePerAngleUnit.PoundForceFootPerDegree:
                    return UnitToolsImperialTorquePerAngle.PoundForceFootPerDegreeToNewtonMeterPerRadian(value);
                case UnitToolsTorquePerAngleUnit.KilogramForceMeterPerRadian:
                    return UnitToolsMetricTorquePerAngle.KilogramForceMeterPerRadianToNewtonMeterPerRadian(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported torque per angle unit.");
            }
        }

        public static double FromNewtonMeterPerRadian(double baseValue, UnitToolsTorquePerAngleUnit to)
        {
            switch (to)
            {
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerRadian:
                    return UnitToolsMetricTorquePerAngle.NewtonMeterPerRadianToNewtonMeterPerRadian(baseValue);
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerDegree:
                    return UnitToolsMetricTorquePerAngle.NewtonMeterPerRadianToNewtonMeterPerDegree(baseValue);
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerTurn:
                    return UnitToolsMetricTorquePerAngle.NewtonMeterPerRadianToNewtonMeterPerTurn(baseValue);
                case UnitToolsTorquePerAngleUnit.PoundForceFootPerRadian:
                    return UnitToolsImperialTorquePerAngle.NewtonMeterPerRadianToPoundForceFootPerRadian(baseValue);
                case UnitToolsTorquePerAngleUnit.MillinewtonMeterPerRadian:
                    return UnitToolsMetricTorquePerAngle.NewtonMeterPerRadianToMillinewtonMeterPerRadian(baseValue);
                case UnitToolsTorquePerAngleUnit.KilonewtonMeterPerRadian:
                    return UnitToolsMetricTorquePerAngle.NewtonMeterPerRadianToKilonewtonMeterPerRadian(baseValue);
                case UnitToolsTorquePerAngleUnit.NewtonMillimeterPerRadian:
                    return UnitToolsMetricTorquePerAngle.NewtonMeterPerRadianToNewtonMillimeterPerRadian(baseValue);
                case UnitToolsTorquePerAngleUnit.PoundForceInchPerDegree:
                    return UnitToolsImperialTorquePerAngle.NewtonMeterPerRadianToPoundForceInchPerDegree(baseValue);
                case UnitToolsTorquePerAngleUnit.PoundForceFootPerDegree:
                    return UnitToolsImperialTorquePerAngle.NewtonMeterPerRadianToPoundForceFootPerDegree(baseValue);
                case UnitToolsTorquePerAngleUnit.KilogramForceMeterPerRadian:
                    return UnitToolsMetricTorquePerAngle.NewtonMeterPerRadianToKilogramForceMeterPerRadian(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported torque per angle unit.");
            }
        }

        public static string GetSymbol(UnitToolsTorquePerAngleUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerRadian:
                    return "N·m/rad";
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerDegree:
                    return "N·m/°";
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerTurn:
                    return "N·m/turn";
                case UnitToolsTorquePerAngleUnit.PoundForceFootPerRadian:
                    return "lbf·ft/rad";
                case UnitToolsTorquePerAngleUnit.MillinewtonMeterPerRadian:
                    return "mN·m/rad";
                case UnitToolsTorquePerAngleUnit.KilonewtonMeterPerRadian:
                    return "kN·m/rad";
                case UnitToolsTorquePerAngleUnit.NewtonMillimeterPerRadian:
                    return "N·mm/rad";
                case UnitToolsTorquePerAngleUnit.PoundForceInchPerDegree:
                    return "lbf·in/°";
                case UnitToolsTorquePerAngleUnit.PoundForceFootPerDegree:
                    return "lbf·ft/°";
                case UnitToolsTorquePerAngleUnit.KilogramForceMeterPerRadian:
                    return "kgf·m/rad";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsTorquePerAngleUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerRadian:
                    return "Newton Meter Per Radian";
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerDegree:
                    return "Newton Meter Per Degree";
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerTurn:
                    return "Newton Meter Per Turn";
                case UnitToolsTorquePerAngleUnit.PoundForceFootPerRadian:
                    return "Pound Force Foot Per Radian";
                case UnitToolsTorquePerAngleUnit.MillinewtonMeterPerRadian:
                    return "Millinewton Meter Per Radian";
                case UnitToolsTorquePerAngleUnit.KilonewtonMeterPerRadian:
                    return "Kilonewton Meter Per Radian";
                case UnitToolsTorquePerAngleUnit.NewtonMillimeterPerRadian:
                    return "Newton Millimeter Per Radian";
                case UnitToolsTorquePerAngleUnit.PoundForceInchPerDegree:
                    return "Pound Force Inch Per Degree";
                case UnitToolsTorquePerAngleUnit.PoundForceFootPerDegree:
                    return "Pound Force Foot Per Degree";
                case UnitToolsTorquePerAngleUnit.KilogramForceMeterPerRadian:
                    return "Kilogram Force Meter Per Radian";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsTorquePerAngleUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerRadian:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerDegree:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorquePerAngleUnit.NewtonMeterPerTurn:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorquePerAngleUnit.PoundForceFootPerRadian:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsTorquePerAngleUnit.MillinewtonMeterPerRadian:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorquePerAngleUnit.KilonewtonMeterPerRadian:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorquePerAngleUnit.NewtonMillimeterPerRadian:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsTorquePerAngleUnit.PoundForceInchPerDegree:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsTorquePerAngleUnit.PoundForceFootPerDegree:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsTorquePerAngleUnit.KilogramForceMeterPerRadian:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsTorquePerAngleUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsTorquePerAngleUnit.NewtonMeterPerRadian, UnitToolsTorquePerAngleUnit.NewtonMeterPerDegree, UnitToolsTorquePerAngleUnit.NewtonMeterPerTurn, UnitToolsTorquePerAngleUnit.MillinewtonMeterPerRadian, UnitToolsTorquePerAngleUnit.KilonewtonMeterPerRadian, UnitToolsTorquePerAngleUnit.NewtonMillimeterPerRadian, UnitToolsTorquePerAngleUnit.KilogramForceMeterPerRadian };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsTorquePerAngleUnit.PoundForceFootPerRadian, UnitToolsTorquePerAngleUnit.PoundForceInchPerDegree, UnitToolsTorquePerAngleUnit.PoundForceFootPerDegree };
                default:
                    return new[] { UnitToolsTorquePerAngleUnit.NewtonMeterPerRadian, UnitToolsTorquePerAngleUnit.NewtonMeterPerDegree, UnitToolsTorquePerAngleUnit.NewtonMeterPerTurn, UnitToolsTorquePerAngleUnit.PoundForceFootPerRadian, UnitToolsTorquePerAngleUnit.MillinewtonMeterPerRadian, UnitToolsTorquePerAngleUnit.KilonewtonMeterPerRadian, UnitToolsTorquePerAngleUnit.NewtonMillimeterPerRadian, UnitToolsTorquePerAngleUnit.PoundForceInchPerDegree, UnitToolsTorquePerAngleUnit.PoundForceFootPerDegree, UnitToolsTorquePerAngleUnit.KilogramForceMeterPerRadian };
            }
        }
    }
}
