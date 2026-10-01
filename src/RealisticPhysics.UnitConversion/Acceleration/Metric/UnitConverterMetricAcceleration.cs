namespace RealisticPhysics.UnitConversion.Acceleration.Metric
{
    public static class UnitConverterMetricAcceleration
    {
        public static double MeterPerSecondSquaredToMeterPerSecondSquared(double value)
        {
            return value;
        }

        public static double KilometerPerHourPerSecondToMeterPerSecondSquared(double value)
        {
            return value * 0.27777777777777779d;
        }

        public static double MeterPerSecondSquaredToKilometerPerHourPerSecond(double baseValue)
        {
            return baseValue / 0.27777777777777779d;
        }

        public static double CentimeterPerSecondSquaredToMeterPerSecondSquared(double value)
        {
            return value * 0.01d;
        }

        public static double MeterPerSecondSquaredToCentimeterPerSecondSquared(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double MillimeterPerSecondSquaredToMeterPerSecondSquared(double value)
        {
            return value * 0.001d;
        }

        public static double MeterPerSecondSquaredToMillimeterPerSecondSquared(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilometerPerSecondSquaredToMeterPerSecondSquared(double value)
        {
            return value * 1000.0d;
        }

        public static double MeterPerSecondSquaredToKilometerPerSecondSquared(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MeterPerMinuteSquaredToMeterPerSecondSquared(double value)
        {
            return value * 0.00027777777777777778d;
        }

        public static double MeterPerSecondSquaredToMeterPerMinuteSquared(double baseValue)
        {
            return baseValue / 0.00027777777777777778d;
        }
    }
}
