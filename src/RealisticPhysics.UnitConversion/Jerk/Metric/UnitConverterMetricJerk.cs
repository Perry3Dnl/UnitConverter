namespace RealisticPhysics.UnitConversion.Jerk.Metric
{
    public static class UnitConverterMetricJerk
    {
        public static double MeterPerSecondCubedToMeterPerSecondCubed(double value)
        {
            return value;
        }

        public static double CentimeterPerSecondCubedToMeterPerSecondCubed(double value)
        {
            return value * 0.01d;
        }

        public static double MeterPerSecondCubedToCentimeterPerSecondCubed(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double MillimeterPerSecondCubedToMeterPerSecondCubed(double value)
        {
            return value * 0.001d;
        }

        public static double MeterPerSecondCubedToMillimeterPerSecondCubed(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilometerPerHourPerSecondSquaredToMeterPerSecondCubed(double value)
        {
            return value * 0.27777777777777779d;
        }

        public static double MeterPerSecondCubedToKilometerPerHourPerSecondSquared(double baseValue)
        {
            return baseValue / 0.27777777777777779d;
        }
    }
}
