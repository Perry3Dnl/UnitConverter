namespace RealisticPhysics.UnitConversion.Yank.Metric
{
    public static class UnitConverterMetricYank
    {
        public static double NewtonPerSecondToNewtonPerSecond(double value)
        {
            return value;
        }

        public static double KilonewtonPerSecondToNewtonPerSecond(double value)
        {
            return value * 1000.0d;
        }

        public static double NewtonPerSecondToKilonewtonPerSecond(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MillinewtonPerSecondToNewtonPerSecond(double value)
        {
            return value * 0.001d;
        }

        public static double NewtonPerSecondToMillinewtonPerSecond(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicronewtonPerSecondToNewtonPerSecond(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double NewtonPerSecondToMicronewtonPerSecond(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MeganewtonPerSecondToNewtonPerSecond(double value)
        {
            return value * 1000000.0d;
        }

        public static double NewtonPerSecondToMeganewtonPerSecond(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double NewtonPerMinuteToNewtonPerSecond(double value)
        {
            return value * 0.016666666666666666d;
        }

        public static double NewtonPerSecondToNewtonPerMinute(double baseValue)
        {
            return baseValue / 0.016666666666666666d;
        }

        public static double KilogramForcePerSecondToNewtonPerSecond(double value)
        {
            return value * 9.8066499999999994d;
        }

        public static double NewtonPerSecondToKilogramForcePerSecond(double baseValue)
        {
            return baseValue / 9.8066499999999994d;
        }
    }
}
