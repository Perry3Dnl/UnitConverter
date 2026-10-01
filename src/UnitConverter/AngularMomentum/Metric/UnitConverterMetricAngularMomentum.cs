namespace UnitConverter.AngularMomentum.Metric
{
    public static class UnitConverterMetricAngularMomentum
    {
        public static double KilogramSquareMeterPerSecondToKilogramSquareMeterPerSecond(double value)
        {
            return value;
        }

        public static double NewtonMeterSecondToKilogramSquareMeterPerSecond(double value)
        {
            return value * 1.0d;
        }

        public static double KilogramSquareMeterPerSecondToNewtonMeterSecond(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double JouleSecondToKilogramSquareMeterPerSecond(double value)
        {
            return value * 1.0d;
        }

        public static double KilogramSquareMeterPerSecondToJouleSecond(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double GramSquareCentimeterPerSecondToKilogramSquareMeterPerSecond(double value)
        {
            return value * 9.9999999999999995e-08d;
        }

        public static double KilogramSquareMeterPerSecondToGramSquareCentimeterPerSecond(double baseValue)
        {
            return baseValue / 9.9999999999999995e-08d;
        }

        public static double KilogramSquareMeterPerMinuteToKilogramSquareMeterPerSecond(double value)
        {
            return value * 0.016666666666666666d;
        }

        public static double KilogramSquareMeterPerSecondToKilogramSquareMeterPerMinute(double baseValue)
        {
            return baseValue / 0.016666666666666666d;
        }

        public static double GramSquareMeterPerSecondToKilogramSquareMeterPerSecond(double value)
        {
            return value * 0.001d;
        }

        public static double KilogramSquareMeterPerSecondToGramSquareMeterPerSecond(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilogramSquareCentimeterPerSecondToKilogramSquareMeterPerSecond(double value)
        {
            return value * 0.0001d;
        }

        public static double KilogramSquareMeterPerSecondToKilogramSquareCentimeterPerSecond(double baseValue)
        {
            return baseValue / 0.0001d;
        }
    }
}
