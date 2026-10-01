namespace RealisticPhysics.UnitConversion.AreaDensity.Metric
{
    public static class UnitConverterMetricAreaDensity
    {
        public static double KilogramPerSquareMeterToKilogramPerSquareMeter(double value)
        {
            return value;
        }

        public static double GramPerSquareMeterToKilogramPerSquareMeter(double value)
        {
            return value * 0.001d;
        }

        public static double KilogramPerSquareMeterToGramPerSquareMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MilligramPerSquareMeterToKilogramPerSquareMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double KilogramPerSquareMeterToMilligramPerSquareMeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MicrogramPerSquareMeterToKilogramPerSquareMeter(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double KilogramPerSquareMeterToMicrogramPerSquareMeter(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double GramPerSquareCentimeterToKilogramPerSquareMeter(double value)
        {
            return value * 10.0d;
        }

        public static double KilogramPerSquareMeterToGramPerSquareCentimeter(double baseValue)
        {
            return baseValue / 10.0d;
        }

        public static double KilogramPerSquareMillimeterToKilogramPerSquareMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double KilogramPerSquareMeterToKilogramPerSquareMillimeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }
    }
}
