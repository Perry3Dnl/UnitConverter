namespace UnitTools.DoseRate.Metric
{
    public static class UnitToolsMetricDoseRate
    {
        public static double GrayPerSecondToGrayPerSecond(double value)
        {
            return value;
        }

        public static double MilligrayPerSecondToGrayPerSecond(double value)
        {
            return value * 0.001d;
        }

        public static double GrayPerSecondToMilligrayPerSecond(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicrograyPerSecondToGrayPerSecond(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double GrayPerSecondToMicrograyPerSecond(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double GrayPerHourToGrayPerSecond(double value)
        {
            return value * 0.00027777777777777778d;
        }

        public static double GrayPerSecondToGrayPerHour(double baseValue)
        {
            return baseValue / 0.00027777777777777778d;
        }

        public static double MillisievertPerHourToGrayPerSecond(double value)
        {
            return value * 2.7777777777777776e-07d;
        }

        public static double GrayPerSecondToMillisievertPerHour(double baseValue)
        {
            return baseValue / 2.7777777777777776e-07d;
        }

        public static double GrayPerMinuteToGrayPerSecond(double value)
        {
            return value * 0.016666666666666666d;
        }

        public static double GrayPerSecondToGrayPerMinute(double baseValue)
        {
            return baseValue / 0.016666666666666666d;
        }

        public static double MilligrayPerHourToGrayPerSecond(double value)
        {
            return value * 2.7777777777777776e-07d;
        }

        public static double GrayPerSecondToMilligrayPerHour(double baseValue)
        {
            return baseValue / 2.7777777777777776e-07d;
        }

        public static double MicrograyPerHourToGrayPerSecond(double value)
        {
            return value * 2.7777777777777777e-10d;
        }

        public static double GrayPerSecondToMicrograyPerHour(double baseValue)
        {
            return baseValue / 2.7777777777777777e-10d;
        }

        public static double SievertPerSecondToGrayPerSecond(double value)
        {
            return value * 1.0d;
        }

        public static double GrayPerSecondToSievertPerSecond(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double MicrosievertPerHourToGrayPerSecond(double value)
        {
            return value * 2.7777777777777777e-10d;
        }

        public static double GrayPerSecondToMicrosievertPerHour(double baseValue)
        {
            return baseValue / 2.7777777777777777e-10d;
        }

        public static double NanograyPerSecondToGrayPerSecond(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double GrayPerSecondToNanograyPerSecond(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double PicograyPerSecondToGrayPerSecond(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double GrayPerSecondToPicograyPerSecond(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double GrayPerYearToGrayPerSecond(double value)
        {
            return value * 3.1688087814028947e-08d;
        }

        public static double GrayPerSecondToGrayPerYear(double baseValue)
        {
            return baseValue / 3.1688087814028947e-08d;
        }

        public static double SievertPerYearToGrayPerSecond(double value)
        {
            return value * 3.1688087814028947e-08d;
        }

        public static double GrayPerSecondToSievertPerYear(double baseValue)
        {
            return baseValue / 3.1688087814028947e-08d;
        }

        public static double MicrosievertPerYearToGrayPerSecond(double value)
        {
            return value * 3.168808781402895e-14d;
        }

        public static double GrayPerSecondToMicrosievertPerYear(double baseValue)
        {
            return baseValue / 3.168808781402895e-14d;
        }
    }
}
