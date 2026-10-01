namespace UnitConverter.Irradiance.Metric
{
    public static class UnitConverterMetricIrradiance
    {
        public static double WattPerSquareMeterToWattPerSquareMeter(double value)
        {
            return value;
        }

        public static double KilowattPerSquareMeterToWattPerSquareMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double WattPerSquareMeterToKilowattPerSquareMeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MilliwattPerSquareCentimeterToWattPerSquareMeter(double value)
        {
            return value * 10.0d;
        }

        public static double WattPerSquareMeterToMilliwattPerSquareCentimeter(double baseValue)
        {
            return baseValue / 10.0d;
        }

        public static double WattPerSquareCentimeterToWattPerSquareMeter(double value)
        {
            return value * 10000.0d;
        }

        public static double WattPerSquareMeterToWattPerSquareCentimeter(double baseValue)
        {
            return baseValue / 10000.0d;
        }

        public static double MilliwattPerSquareMeterToWattPerSquareMeter(double value)
        {
            return value * 0.001d;
        }

        public static double WattPerSquareMeterToMilliwattPerSquareMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicrowattPerSquareMeterToWattPerSquareMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double WattPerSquareMeterToMicrowattPerSquareMeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double CaloriePerSquareCentimeterMinuteToWattPerSquareMeter(double value)
        {
            return value * 697.33333333333337d;
        }

        public static double WattPerSquareMeterToCaloriePerSquareCentimeterMinute(double baseValue)
        {
            return baseValue / 697.33333333333337d;
        }

        public static double NanowattPerSquareMeterToWattPerSquareMeter(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double WattPerSquareMeterToNanowattPerSquareMeter(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double MegawattPerSquareMeterToWattPerSquareMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double WattPerSquareMeterToMegawattPerSquareMeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double CaloriePerSquareCentimeterSecondToWattPerSquareMeter(double value)
        {
            return value * 41840.0d;
        }

        public static double WattPerSquareMeterToCaloriePerSquareCentimeterSecond(double baseValue)
        {
            return baseValue / 41840.0d;
        }
    }
}
