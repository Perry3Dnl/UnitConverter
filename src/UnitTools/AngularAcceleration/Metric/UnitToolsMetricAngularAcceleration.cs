namespace UnitTools.AngularAcceleration.Metric
{
    public static class UnitToolsMetricAngularAcceleration
    {
        public static double MilliradianPerSecondSquaredToRadianPerSecondSquared(double value)
        {
            return value * 0.001d;
        }

        public static double RadianPerSecondSquaredToMilliradianPerSecondSquared(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double RadianPerMinuteSquaredToRadianPerSecondSquared(double value)
        {
            return value * 0.00027777777777777778d;
        }

        public static double RadianPerSecondSquaredToRadianPerMinuteSquared(double baseValue)
        {
            return baseValue / 0.00027777777777777778d;
        }

        public static double DegreePerMinuteSquaredToRadianPerSecondSquared(double value)
        {
            return value * 4.8481368110953598e-06d;
        }

        public static double RadianPerSecondSquaredToDegreePerMinuteSquared(double baseValue)
        {
            return baseValue / 4.8481368110953598e-06d;
        }
    }
}
