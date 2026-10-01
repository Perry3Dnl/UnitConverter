namespace UnitConverter.LuminousExposure.Metric
{
    public static class UnitConverterMetricLuminousExposure
    {
        public static double LuxSecondToLuxSecond(double value)
        {
            return value;
        }

        public static double LuxHourToLuxSecond(double value)
        {
            return value * 3600.0d;
        }

        public static double LuxSecondToLuxHour(double baseValue)
        {
            return baseValue / 3600.0d;
        }

        public static double PhotSecondToLuxSecond(double value)
        {
            return value * 10000.0d;
        }

        public static double LuxSecondToPhotSecond(double baseValue)
        {
            return baseValue / 10000.0d;
        }

        public static double LuxMinuteToLuxSecond(double value)
        {
            return value * 60.0d;
        }

        public static double LuxSecondToLuxMinute(double baseValue)
        {
            return baseValue / 60.0d;
        }

        public static double KiloluxSecondToLuxSecond(double value)
        {
            return value * 1000.0d;
        }

        public static double LuxSecondToKiloluxSecond(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double LumenSecondPerSquareMeterToLuxSecond(double value)
        {
            return value * 1.0d;
        }

        public static double LuxSecondToLumenSecondPerSquareMeter(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double MilliluxSecondToLuxSecond(double value)
        {
            return value * 0.001d;
        }

        public static double LuxSecondToMilliluxSecond(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MegaluxSecondToLuxSecond(double value)
        {
            return value * 1000000.0d;
        }

        public static double LuxSecondToMegaluxSecond(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double LumenHourPerSquareMeterToLuxSecond(double value)
        {
            return value * 3600.0d;
        }

        public static double LuxSecondToLumenHourPerSquareMeter(double baseValue)
        {
            return baseValue / 3600.0d;
        }
    }
}
