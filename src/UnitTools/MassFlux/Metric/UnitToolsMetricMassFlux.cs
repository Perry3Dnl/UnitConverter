namespace UnitTools.MassFlux.Metric
{
    public static class UnitToolsMetricMassFlux
    {
        public static double KilogramPerSquareMeterSecondToKilogramPerSquareMeterSecond(double value)
        {
            return value;
        }

        public static double GramPerSquareMeterSecondToKilogramPerSquareMeterSecond(double value)
        {
            return value * 0.001d;
        }

        public static double KilogramPerSquareMeterSecondToGramPerSquareMeterSecond(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilogramPerSquareMeterHourToKilogramPerSquareMeterSecond(double value)
        {
            return value * 0.00027777777777777778d;
        }

        public static double KilogramPerSquareMeterSecondToKilogramPerSquareMeterHour(double baseValue)
        {
            return baseValue / 0.00027777777777777778d;
        }

        public static double GramPerSquareCentimeterSecondToKilogramPerSquareMeterSecond(double value)
        {
            return value * 10.0d;
        }

        public static double KilogramPerSquareMeterSecondToGramPerSquareCentimeterSecond(double baseValue)
        {
            return baseValue / 10.0d;
        }

        public static double MilligramPerSquareMeterSecondToKilogramPerSquareMeterSecond(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double KilogramPerSquareMeterSecondToMilligramPerSquareMeterSecond(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MicrogramPerSquareMeterSecondToKilogramPerSquareMeterSecond(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double KilogramPerSquareMeterSecondToMicrogramPerSquareMeterSecond(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double KilogramPerSquareCentimeterSecondToKilogramPerSquareMeterSecond(double value)
        {
            return value * 10000.0d;
        }

        public static double KilogramPerSquareMeterSecondToKilogramPerSquareCentimeterSecond(double baseValue)
        {
            return baseValue / 10000.0d;
        }

        public static double KilogramPerSquareMillimeterSecondToKilogramPerSquareMeterSecond(double value)
        {
            return value * 1000000.0d;
        }

        public static double KilogramPerSquareMeterSecondToKilogramPerSquareMillimeterSecond(double baseValue)
        {
            return baseValue / 1000000.0d;
        }
    }
}
