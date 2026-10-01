namespace RealisticPhysics.UnitConversion.Force.Metric
{
    public static class UnitConverterMetricForce
    {
        public static double MicronewtonToNewton(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double NewtonToMicronewton(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MillinewtonToNewton(double value)
        {
            return value * 0.001d;
        }

        public static double NewtonToMillinewton(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double NewtonToNewton(double value)
        {
            return value;
        }

        public static double KilonewtonToNewton(double value)
        {
            return value * 1000.0d;
        }

        public static double NewtonToKilonewton(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MeganewtonToNewton(double value)
        {
            return value * 1000000.0d;
        }

        public static double NewtonToMeganewton(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double KilogramForceToNewton(double value)
        {
            return value * 9.8066499999999994d;
        }

        public static double NewtonToKilogramForce(double baseValue)
        {
            return baseValue / 9.8066499999999994d;
        }

        public static double PiconewtonToNewton(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double NewtonToPiconewton(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double NanonewtonToNewton(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double NewtonToNanonewton(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double GramForceToNewton(double value)
        {
            return value * 0.0098066500000000001d;
        }

        public static double NewtonToGramForce(double baseValue)
        {
            return baseValue / 0.0098066500000000001d;
        }

        public static double MilligramForceToNewton(double value)
        {
            return value * 9.8066500000000004e-06d;
        }

        public static double NewtonToMilligramForce(double baseValue)
        {
            return baseValue / 9.8066500000000004e-06d;
        }
    }
}
