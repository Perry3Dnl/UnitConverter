namespace UnitConverter.Speed.Metric
{
    public static class UnitConverterMetricSpeed
    {
        public static double MeterPerSecondToMeterPerSecond(double value)
        {
            return value;
        }

        public static double KilometerPerHourToMeterPerSecond(double value)
        {
            return value * 0.27777777777777779d;
        }

        public static double MeterPerSecondToKilometerPerHour(double baseValue)
        {
            return baseValue / 0.27777777777777779d;
        }

        public static double MicrometerPerSecondToMeterPerSecond(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double MeterPerSecondToMicrometerPerSecond(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
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

        public static double MeterPerMinuteToMeterPerSecond(double value)
        {
            return value * 0.016666666666666666d;
        }

        public static double MeterPerSecondToMeterPerMinute(double baseValue)
        {
            return baseValue / 0.016666666666666666d;
        }

        public static double MeterPerHourToMeterPerSecond(double value)
        {
            return value * 0.00027777777777777778d;
        }

        public static double MeterPerSecondToMeterPerHour(double baseValue)
        {
            return baseValue / 0.00027777777777777778d;
        }

        public static double KilometerPerSecondToMeterPerSecond(double value)
        {
            return value * 1000.0d;
        }

        public static double MeterPerSecondToKilometerPerSecond(double baseValue)
        {
            return baseValue / 1000.0d;
        }
    }
}
