namespace UnitConverter.TorquePerAngle
{
    using UnitConverter.TorquePerAngle.Metric;
    using UnitConverter.TorquePerAngle.Imperial;

    public enum UnitConverterTorquePerAngleUnit
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

    public static class UnitConverterTorquePerAngle
    {
        public static double Convert(double value, UnitConverterTorquePerAngleUnit from, UnitConverterTorquePerAngleUnit to)
        {
            double baseValue = ToNewtonMeterPerRadian(value, from);
            return FromNewtonMeterPerRadian(baseValue, to);
        }

        public static double ToNewtonMeterPerRadian(double value, UnitConverterTorquePerAngleUnit from)
        {
            switch (from)
            {
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerRadian:
                    return UnitConverterMetricTorquePerAngle.NewtonMeterPerRadianToNewtonMeterPerRadian(value);
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerDegree:
                    return UnitConverterMetricTorquePerAngle.NewtonMeterPerDegreeToNewtonMeterPerRadian(value);
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerTurn:
                    return UnitConverterMetricTorquePerAngle.NewtonMeterPerTurnToNewtonMeterPerRadian(value);
                case UnitConverterTorquePerAngleUnit.PoundForceFootPerRadian:
                    return UnitConverterImperialTorquePerAngle.PoundForceFootPerRadianToNewtonMeterPerRadian(value);
                case UnitConverterTorquePerAngleUnit.MillinewtonMeterPerRadian:
                    return UnitConverterMetricTorquePerAngle.MillinewtonMeterPerRadianToNewtonMeterPerRadian(value);
                case UnitConverterTorquePerAngleUnit.KilonewtonMeterPerRadian:
                    return UnitConverterMetricTorquePerAngle.KilonewtonMeterPerRadianToNewtonMeterPerRadian(value);
                case UnitConverterTorquePerAngleUnit.NewtonMillimeterPerRadian:
                    return UnitConverterMetricTorquePerAngle.NewtonMillimeterPerRadianToNewtonMeterPerRadian(value);
                case UnitConverterTorquePerAngleUnit.PoundForceInchPerDegree:
                    return UnitConverterImperialTorquePerAngle.PoundForceInchPerDegreeToNewtonMeterPerRadian(value);
                case UnitConverterTorquePerAngleUnit.PoundForceFootPerDegree:
                    return UnitConverterImperialTorquePerAngle.PoundForceFootPerDegreeToNewtonMeterPerRadian(value);
                case UnitConverterTorquePerAngleUnit.KilogramForceMeterPerRadian:
                    return UnitConverterMetricTorquePerAngle.KilogramForceMeterPerRadianToNewtonMeterPerRadian(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported torque per angle unit.");
            }
        }

        public static double FromNewtonMeterPerRadian(double baseValue, UnitConverterTorquePerAngleUnit to)
        {
            switch (to)
            {
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerRadian:
                    return UnitConverterMetricTorquePerAngle.NewtonMeterPerRadianToNewtonMeterPerRadian(baseValue);
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerDegree:
                    return UnitConverterMetricTorquePerAngle.NewtonMeterPerRadianToNewtonMeterPerDegree(baseValue);
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerTurn:
                    return UnitConverterMetricTorquePerAngle.NewtonMeterPerRadianToNewtonMeterPerTurn(baseValue);
                case UnitConverterTorquePerAngleUnit.PoundForceFootPerRadian:
                    return UnitConverterImperialTorquePerAngle.NewtonMeterPerRadianToPoundForceFootPerRadian(baseValue);
                case UnitConverterTorquePerAngleUnit.MillinewtonMeterPerRadian:
                    return UnitConverterMetricTorquePerAngle.NewtonMeterPerRadianToMillinewtonMeterPerRadian(baseValue);
                case UnitConverterTorquePerAngleUnit.KilonewtonMeterPerRadian:
                    return UnitConverterMetricTorquePerAngle.NewtonMeterPerRadianToKilonewtonMeterPerRadian(baseValue);
                case UnitConverterTorquePerAngleUnit.NewtonMillimeterPerRadian:
                    return UnitConverterMetricTorquePerAngle.NewtonMeterPerRadianToNewtonMillimeterPerRadian(baseValue);
                case UnitConverterTorquePerAngleUnit.PoundForceInchPerDegree:
                    return UnitConverterImperialTorquePerAngle.NewtonMeterPerRadianToPoundForceInchPerDegree(baseValue);
                case UnitConverterTorquePerAngleUnit.PoundForceFootPerDegree:
                    return UnitConverterImperialTorquePerAngle.NewtonMeterPerRadianToPoundForceFootPerDegree(baseValue);
                case UnitConverterTorquePerAngleUnit.KilogramForceMeterPerRadian:
                    return UnitConverterMetricTorquePerAngle.NewtonMeterPerRadianToKilogramForceMeterPerRadian(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported torque per angle unit.");
            }
        }

        public static string GetSymbol(UnitConverterTorquePerAngleUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerRadian:
                    return "N·m/rad";
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerDegree:
                    return "N·m/°";
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerTurn:
                    return "N·m/turn";
                case UnitConverterTorquePerAngleUnit.PoundForceFootPerRadian:
                    return "lbf·ft/rad";
                case UnitConverterTorquePerAngleUnit.MillinewtonMeterPerRadian:
                    return "mN·m/rad";
                case UnitConverterTorquePerAngleUnit.KilonewtonMeterPerRadian:
                    return "kN·m/rad";
                case UnitConverterTorquePerAngleUnit.NewtonMillimeterPerRadian:
                    return "N·mm/rad";
                case UnitConverterTorquePerAngleUnit.PoundForceInchPerDegree:
                    return "lbf·in/°";
                case UnitConverterTorquePerAngleUnit.PoundForceFootPerDegree:
                    return "lbf·ft/°";
                case UnitConverterTorquePerAngleUnit.KilogramForceMeterPerRadian:
                    return "kgf·m/rad";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterTorquePerAngleUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerRadian:
                    return "Newton Meter Per Radian";
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerDegree:
                    return "Newton Meter Per Degree";
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerTurn:
                    return "Newton Meter Per Turn";
                case UnitConverterTorquePerAngleUnit.PoundForceFootPerRadian:
                    return "Pound Force Foot Per Radian";
                case UnitConverterTorquePerAngleUnit.MillinewtonMeterPerRadian:
                    return "Millinewton Meter Per Radian";
                case UnitConverterTorquePerAngleUnit.KilonewtonMeterPerRadian:
                    return "Kilonewton Meter Per Radian";
                case UnitConverterTorquePerAngleUnit.NewtonMillimeterPerRadian:
                    return "Newton Millimeter Per Radian";
                case UnitConverterTorquePerAngleUnit.PoundForceInchPerDegree:
                    return "Pound Force Inch Per Degree";
                case UnitConverterTorquePerAngleUnit.PoundForceFootPerDegree:
                    return "Pound Force Foot Per Degree";
                case UnitConverterTorquePerAngleUnit.KilogramForceMeterPerRadian:
                    return "Kilogram Force Meter Per Radian";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterTorquePerAngleUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerRadian:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerDegree:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorquePerAngleUnit.NewtonMeterPerTurn:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorquePerAngleUnit.PoundForceFootPerRadian:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterTorquePerAngleUnit.MillinewtonMeterPerRadian:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorquePerAngleUnit.KilonewtonMeterPerRadian:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorquePerAngleUnit.NewtonMillimeterPerRadian:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterTorquePerAngleUnit.PoundForceInchPerDegree:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterTorquePerAngleUnit.PoundForceFootPerDegree:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterTorquePerAngleUnit.KilogramForceMeterPerRadian:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterTorquePerAngleUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterTorquePerAngleUnit.NewtonMeterPerRadian, UnitConverterTorquePerAngleUnit.NewtonMeterPerDegree, UnitConverterTorquePerAngleUnit.NewtonMeterPerTurn, UnitConverterTorquePerAngleUnit.MillinewtonMeterPerRadian, UnitConverterTorquePerAngleUnit.KilonewtonMeterPerRadian, UnitConverterTorquePerAngleUnit.NewtonMillimeterPerRadian, UnitConverterTorquePerAngleUnit.KilogramForceMeterPerRadian };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterTorquePerAngleUnit.PoundForceFootPerRadian, UnitConverterTorquePerAngleUnit.PoundForceInchPerDegree, UnitConverterTorquePerAngleUnit.PoundForceFootPerDegree };
                default:
                    return new[] { UnitConverterTorquePerAngleUnit.NewtonMeterPerRadian, UnitConverterTorquePerAngleUnit.NewtonMeterPerDegree, UnitConverterTorquePerAngleUnit.NewtonMeterPerTurn, UnitConverterTorquePerAngleUnit.PoundForceFootPerRadian, UnitConverterTorquePerAngleUnit.MillinewtonMeterPerRadian, UnitConverterTorquePerAngleUnit.KilonewtonMeterPerRadian, UnitConverterTorquePerAngleUnit.NewtonMillimeterPerRadian, UnitConverterTorquePerAngleUnit.PoundForceInchPerDegree, UnitConverterTorquePerAngleUnit.PoundForceFootPerDegree, UnitConverterTorquePerAngleUnit.KilogramForceMeterPerRadian };
            }
        }
    }
}
