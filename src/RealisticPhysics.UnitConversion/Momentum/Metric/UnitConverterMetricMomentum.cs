namespace RealisticPhysics.UnitConversion.Momentum.Metric
{
    public static class UnitConverterMetricMomentum
    {
        public static double KilogramMeterPerSecondToKilogramMeterPerSecond(double value)
        {
            return value;
        }

        public static double NewtonSecondToKilogramMeterPerSecond(double value)
        {
            return value * 1.0d;
        }

        public static double KilogramMeterPerSecondToNewtonSecond(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double GramCentimeterPerSecondToKilogramMeterPerSecond(double value)
        {
            return value * 1.0000000000000001e-05d;
        }

        public static double KilogramMeterPerSecondToGramCentimeterPerSecond(double baseValue)
        {
            return baseValue / 1.0000000000000001e-05d;
        }

        public static double KilogramKilometerPerSecondToKilogramMeterPerSecond(double value)
        {
            return value * 1000.0d;
        }

        public static double KilogramMeterPerSecondToKilogramKilometerPerSecond(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double GramMeterPerSecondToKilogramMeterPerSecond(double value)
        {
            return value * 0.001d;
        }

        public static double KilogramMeterPerSecondToGramMeterPerSecond(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MilligramMeterPerSecondToKilogramMeterPerSecond(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double KilogramMeterPerSecondToMilligramMeterPerSecond(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double TonneMeterPerSecondToKilogramMeterPerSecond(double value)
        {
            return value * 1000.0d;
        }

        public static double KilogramMeterPerSecondToTonneMeterPerSecond(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double KilonewtonSecondToKilogramMeterPerSecond(double value)
        {
            return value * 1000.0d;
        }

        public static double KilogramMeterPerSecondToKilonewtonSecond(double baseValue)
        {
            return baseValue / 1000.0d;
        }
    }
}
