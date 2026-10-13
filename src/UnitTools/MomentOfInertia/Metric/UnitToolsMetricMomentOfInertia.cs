namespace UnitTools.MomentOfInertia.Metric
{
    public static class UnitToolsMetricMomentOfInertia
    {
        public static double KilogramSquareMeterToKilogramSquareMeter(double value)
        {
            return value;
        }

        public static double GramSquareCentimeterToKilogramSquareMeter(double value)
        {
            return value * 9.9999999999999995e-08d;
        }

        public static double KilogramSquareMeterToGramSquareCentimeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-08d;
        }

        public static double KilogramSquareCentimeterToKilogramSquareMeter(double value)
        {
            return value * 0.0001d;
        }

        public static double KilogramSquareMeterToKilogramSquareCentimeter(double baseValue)
        {
            return baseValue / 0.0001d;
        }

        public static double GramSquareMeterToKilogramSquareMeter(double value)
        {
            return value * 0.001d;
        }

        public static double KilogramSquareMeterToGramSquareMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilogramSquareMillimeterToKilogramSquareMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double KilogramSquareMeterToKilogramSquareMillimeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double GramSquareMillimeterToKilogramSquareMeter(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double KilogramSquareMeterToGramSquareMillimeter(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double TonneSquareMeterToKilogramSquareMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double KilogramSquareMeterToTonneSquareMeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }
    }
}
