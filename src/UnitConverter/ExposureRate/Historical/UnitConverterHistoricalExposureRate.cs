namespace UnitConverter.ExposureRate.Historical
{
    public static class UnitConverterHistoricalExposureRate
    {
        public static double RoentgenPerSecondToCoulombPerKilogramSecond(double value)
        {
            return value * 0.00025799999999999998d;
        }

        public static double CoulombPerKilogramSecondToRoentgenPerSecond(double baseValue)
        {
            return baseValue / 0.00025799999999999998d;
        }

        public static double RoentgenPerHourToCoulombPerKilogramSecond(double value)
        {
            return value * 7.166666666666666e-08d;
        }

        public static double CoulombPerKilogramSecondToRoentgenPerHour(double baseValue)
        {
            return baseValue / 7.166666666666666e-08d;
        }

        public static double MilliroentgenPerHourToCoulombPerKilogramSecond(double value)
        {
            return value * 7.1666666666666665e-11d;
        }

        public static double CoulombPerKilogramSecondToMilliroentgenPerHour(double baseValue)
        {
            return baseValue / 7.1666666666666665e-11d;
        }

        public static double MicroroentgenPerHourToCoulombPerKilogramSecond(double value)
        {
            return value * 7.166666666666666e-14d;
        }

        public static double CoulombPerKilogramSecondToMicroroentgenPerHour(double baseValue)
        {
            return baseValue / 7.166666666666666e-14d;
        }

        public static double RoentgenPerMinuteToCoulombPerKilogramSecond(double value)
        {
            return value * 4.2999999999999995e-06d;
        }

        public static double CoulombPerKilogramSecondToRoentgenPerMinute(double baseValue)
        {
            return baseValue / 4.2999999999999995e-06d;
        }
    }
}
