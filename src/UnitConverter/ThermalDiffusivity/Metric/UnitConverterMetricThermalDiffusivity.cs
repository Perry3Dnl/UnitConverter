namespace UnitConverter.ThermalDiffusivity.Metric
{
    public static class UnitConverterMetricThermalDiffusivity
    {
        public static double SquareMeterPerSecondToSquareMeterPerSecond(double value)
        {
            return value;
        }

        public static double SquareCentimeterPerSecondToSquareMeterPerSecond(double value)
        {
            return value * 0.0001d;
        }

        public static double SquareMeterPerSecondToSquareCentimeterPerSecond(double baseValue)
        {
            return baseValue / 0.0001d;
        }

        public static double SquareMillimeterPerSecondToSquareMeterPerSecond(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double SquareMeterPerSecondToSquareMillimeterPerSecond(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double SquareMeterPerHourToSquareMeterPerSecond(double value)
        {
            return value * 0.00027777777777777778d;
        }

        public static double SquareMeterPerSecondToSquareMeterPerHour(double baseValue)
        {
            return baseValue / 0.00027777777777777778d;
        }

        public static double SquareMeterPerMinuteToSquareMeterPerSecond(double value)
        {
            return value * 0.016666666666666666d;
        }

        public static double SquareMeterPerSecondToSquareMeterPerMinute(double baseValue)
        {
            return baseValue / 0.016666666666666666d;
        }

        public static double SquareMeterPerDayToSquareMeterPerSecond(double value)
        {
            return value * 1.1574074074074073e-05d;
        }

        public static double SquareMeterPerSecondToSquareMeterPerDay(double baseValue)
        {
            return baseValue / 1.1574074074074073e-05d;
        }

        public static double SquareCentimeterPerMinuteToSquareMeterPerSecond(double value)
        {
            return value * 1.6666666666666667e-06d;
        }

        public static double SquareMeterPerSecondToSquareCentimeterPerMinute(double baseValue)
        {
            return baseValue / 1.6666666666666667e-06d;
        }

        public static double SquareMillimeterPerMinuteToSquareMeterPerSecond(double value)
        {
            return value * 1.6666666666666667e-08d;
        }

        public static double SquareMeterPerSecondToSquareMillimeterPerMinute(double baseValue)
        {
            return baseValue / 1.6666666666666667e-08d;
        }
    }
}
