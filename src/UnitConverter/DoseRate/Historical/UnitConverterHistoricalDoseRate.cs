namespace UnitConverter.DoseRate.Historical
{
    public static class UnitConverterHistoricalDoseRate
    {
        public static double RadPerHourToGrayPerSecond(double value)
        {
            return value * 2.7777777777777779e-06d;
        }

        public static double GrayPerSecondToRadPerHour(double baseValue)
        {
            return baseValue / 2.7777777777777779e-06d;
        }

        public static double RemPerSecondToGrayPerSecond(double value)
        {
            return value * 0.01d;
        }

        public static double GrayPerSecondToRemPerSecond(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double RemPerYearToGrayPerSecond(double value)
        {
            return value * 3.1688087814028952e-10d;
        }

        public static double GrayPerSecondToRemPerYear(double baseValue)
        {
            return baseValue / 3.1688087814028952e-10d;
        }
    }
}
