namespace UnitConverter.Impulse.Metric
{
    public static class UnitConverterMetricImpulse
    {
        public static double NewtonSecondToNewtonSecond(double value)
        {
            return value;
        }

        public static double KilonewtonSecondToNewtonSecond(double value)
        {
            return value * 1000.0d;
        }

        public static double NewtonSecondToKilonewtonSecond(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double KilogramForceSecondToNewtonSecond(double value)
        {
            return value * 9.8066499999999994d;
        }

        public static double NewtonSecondToKilogramForceSecond(double baseValue)
        {
            return baseValue / 9.8066499999999994d;
        }

        public static double MillinewtonSecondToNewtonSecond(double value)
        {
            return value * 0.001d;
        }

        public static double NewtonSecondToMillinewtonSecond(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MeganewtonSecondToNewtonSecond(double value)
        {
            return value * 1000000.0d;
        }

        public static double NewtonSecondToMeganewtonSecond(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double NewtonMinuteToNewtonSecond(double value)
        {
            return value * 60.0d;
        }

        public static double NewtonSecondToNewtonMinute(double baseValue)
        {
            return baseValue / 60.0d;
        }

        public static double KilogramMeterPerSecondToNewtonSecond(double value)
        {
            return value * 1.0d;
        }

        public static double NewtonSecondToKilogramMeterPerSecond(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double GramCentimeterPerSecondToNewtonSecond(double value)
        {
            return value * 1.0000000000000001e-05d;
        }

        public static double NewtonSecondToGramCentimeterPerSecond(double baseValue)
        {
            return baseValue / 1.0000000000000001e-05d;
        }
    }
}
