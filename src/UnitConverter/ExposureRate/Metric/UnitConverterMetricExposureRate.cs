namespace UnitConverter.ExposureRate.Metric
{
    public static class UnitConverterMetricExposureRate
    {
        public static double CoulombPerKilogramSecondToCoulombPerKilogramSecond(double value)
        {
            return value;
        }

        public static double MillicoulombPerKilogramSecondToCoulombPerKilogramSecond(double value)
        {
            return value * 0.001d;
        }

        public static double CoulombPerKilogramSecondToMillicoulombPerKilogramSecond(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicrocoulombPerKilogramSecondToCoulombPerKilogramSecond(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double CoulombPerKilogramSecondToMicrocoulombPerKilogramSecond(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double CoulombPerKilogramHourToCoulombPerKilogramSecond(double value)
        {
            return value * 0.00027777777777777778d;
        }

        public static double CoulombPerKilogramSecondToCoulombPerKilogramHour(double baseValue)
        {
            return baseValue / 0.00027777777777777778d;
        }

        public static double MicrocoulombPerKilogramHourToCoulombPerKilogramSecond(double value)
        {
            return value * 2.7777777777777777e-10d;
        }

        public static double CoulombPerKilogramSecondToMicrocoulombPerKilogramHour(double baseValue)
        {
            return baseValue / 2.7777777777777777e-10d;
        }
    }
}
