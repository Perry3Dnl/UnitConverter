namespace UnitTools.TorquePerAngle.Metric
{
    public static class UnitToolsMetricTorquePerAngle
    {
        public static double NewtonMeterPerRadianToNewtonMeterPerRadian(double value)
        {
            return value;
        }

        public static double NewtonMeterPerDegreeToNewtonMeterPerRadian(double value)
        {
            return value * 57.295779513082323d;
        }

        public static double NewtonMeterPerRadianToNewtonMeterPerDegree(double baseValue)
        {
            return baseValue / 57.295779513082323d;
        }

        public static double NewtonMeterPerTurnToNewtonMeterPerRadian(double value)
        {
            return value * 0.15915494309189535d;
        }

        public static double NewtonMeterPerRadianToNewtonMeterPerTurn(double baseValue)
        {
            return baseValue / 0.15915494309189535d;
        }

        public static double MillinewtonMeterPerRadianToNewtonMeterPerRadian(double value)
        {
            return value * 0.001d;
        }

        public static double NewtonMeterPerRadianToMillinewtonMeterPerRadian(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilonewtonMeterPerRadianToNewtonMeterPerRadian(double value)
        {
            return value * 1000.0d;
        }

        public static double NewtonMeterPerRadianToKilonewtonMeterPerRadian(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double NewtonMillimeterPerRadianToNewtonMeterPerRadian(double value)
        {
            return value * 0.001d;
        }

        public static double NewtonMeterPerRadianToNewtonMillimeterPerRadian(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilogramForceMeterPerRadianToNewtonMeterPerRadian(double value)
        {
            return value * 9.8066499999999994d;
        }

        public static double NewtonMeterPerRadianToKilogramForceMeterPerRadian(double baseValue)
        {
            return baseValue / 9.8066499999999994d;
        }
    }
}
