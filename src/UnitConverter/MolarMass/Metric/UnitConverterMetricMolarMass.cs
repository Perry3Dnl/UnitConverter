namespace UnitConverter.MolarMass.Metric
{
    public static class UnitConverterMetricMolarMass
    {
        public static double KilogramPerMoleToKilogramPerMole(double value)
        {
            return value;
        }

        public static double GramPerMoleToKilogramPerMole(double value)
        {
            return value * 0.001d;
        }

        public static double KilogramPerMoleToGramPerMole(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MilligramPerMoleToKilogramPerMole(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double KilogramPerMoleToMilligramPerMole(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double KilogramPerKilomoleToKilogramPerMole(double value)
        {
            return value * 0.001d;
        }

        public static double KilogramPerMoleToKilogramPerKilomole(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicrogramPerMoleToKilogramPerMole(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double KilogramPerMoleToMicrogramPerMole(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double NanogramPerMoleToKilogramPerMole(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double KilogramPerMoleToNanogramPerMole(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double KilogramPerMillimoleToKilogramPerMole(double value)
        {
            return value * 1000.0d;
        }

        public static double KilogramPerMoleToKilogramPerMillimole(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double GramPerKilomoleToKilogramPerMole(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double KilogramPerMoleToGramPerKilomole(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }
    }
}
