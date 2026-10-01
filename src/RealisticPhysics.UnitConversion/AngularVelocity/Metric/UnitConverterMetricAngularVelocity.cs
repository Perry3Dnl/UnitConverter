namespace RealisticPhysics.UnitConversion.AngularVelocity.Metric
{
    public static class UnitConverterMetricAngularVelocity
    {
        public static double RadianPerMinuteToRadianPerSecond(double value)
        {
            return value * 0.016666666666666666d;
        }

        public static double RadianPerSecondToRadianPerMinute(double baseValue)
        {
            return baseValue / 0.016666666666666666d;
        }

        public static double RadianPerHourToRadianPerSecond(double value)
        {
            return value * 0.00027777777777777778d;
        }

        public static double RadianPerSecondToRadianPerHour(double baseValue)
        {
            return baseValue / 0.00027777777777777778d;
        }

        public static double DegreePerHourToRadianPerSecond(double value)
        {
            return value * 4.8481368110953598e-06d;
        }

        public static double RadianPerSecondToDegreePerHour(double baseValue)
        {
            return baseValue / 4.8481368110953598e-06d;
        }

        public static double MilliradianPerSecondToRadianPerSecond(double value)
        {
            return value * 0.001d;
        }

        public static double RadianPerSecondToMilliradianPerSecond(double baseValue)
        {
            return baseValue / 0.001d;
        }
    }
}
