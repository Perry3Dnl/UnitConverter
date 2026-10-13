namespace UnitTools.VolumetricFlux.Metric
{
    public static class UnitToolsMetricVolumetricFlux
    {
        public static double MeterPerSecondToMeterPerSecond(double value)
        {
            return value;
        }

        public static double CentimeterPerSecondToMeterPerSecond(double value)
        {
            return value * 0.01d;
        }

        public static double MeterPerSecondToCentimeterPerSecond(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double MillimeterPerSecondToMeterPerSecond(double value)
        {
            return value * 0.001d;
        }

        public static double MeterPerSecondToMillimeterPerSecond(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MeterPerHourToMeterPerSecond(double value)
        {
            return value * 0.00027777777777777778d;
        }

        public static double MeterPerSecondToMeterPerHour(double baseValue)
        {
            return baseValue / 0.00027777777777777778d;
        }

        public static double MicrometerPerSecondToMeterPerSecond(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double MeterPerSecondToMicrometerPerSecond(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MeterPerDayToMeterPerSecond(double value)
        {
            return value * 1.1574074074074073e-05d;
        }

        public static double MeterPerSecondToMeterPerDay(double baseValue)
        {
            return baseValue / 1.1574074074074073e-05d;
        }

        public static double MillimeterPerHourToMeterPerSecond(double value)
        {
            return value * 2.7777777777777776e-07d;
        }

        public static double MeterPerSecondToMillimeterPerHour(double baseValue)
        {
            return baseValue / 2.7777777777777776e-07d;
        }

        public static double CentimeterPerHourToMeterPerSecond(double value)
        {
            return value * 2.7777777777777779e-06d;
        }

        public static double MeterPerSecondToCentimeterPerHour(double baseValue)
        {
            return baseValue / 2.7777777777777779e-06d;
        }
    }
}
