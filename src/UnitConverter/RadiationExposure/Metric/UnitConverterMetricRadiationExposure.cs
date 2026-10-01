namespace UnitConverter.RadiationExposure.Metric
{
    public static class UnitConverterMetricRadiationExposure
    {
        public static double CoulombPerKilogramToCoulombPerKilogram(double value)
        {
            return value;
        }

        public static double MillicoulombPerKilogramToCoulombPerKilogram(double value)
        {
            return value * 0.001d;
        }

        public static double CoulombPerKilogramToMillicoulombPerKilogram(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicrocoulombPerKilogramToCoulombPerKilogram(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double CoulombPerKilogramToMicrocoulombPerKilogram(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double NanocoulombPerKilogramToCoulombPerKilogram(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double CoulombPerKilogramToNanocoulombPerKilogram(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double PicocoulombPerKilogramToCoulombPerKilogram(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double CoulombPerKilogramToPicocoulombPerKilogram(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double CoulombPerGramToCoulombPerKilogram(double value)
        {
            return value * 1000.0d;
        }

        public static double CoulombPerKilogramToCoulombPerGram(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MicrocoulombPerGramToCoulombPerKilogram(double value)
        {
            return value * 0.001d;
        }

        public static double CoulombPerKilogramToMicrocoulombPerGram(double baseValue)
        {
            return baseValue / 0.001d;
        }
    }
}
