namespace RealisticPhysics.UnitConversion.Time.Metric
{
    public static class UnitConverterMetricTime
    {
        public static double MillisecondToSecond(double value)
        {
            return value * 0.001d;
        }

        public static double SecondToMillisecond(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double SecondToSecond(double value)
        {
            return value;
        }

        public static double FemtosecondToSecond(double value)
        {
            return value * 1.0000000000000001e-15d;
        }

        public static double SecondToFemtosecond(double baseValue)
        {
            return baseValue / 1.0000000000000001e-15d;
        }

        public static double PicosecondToSecond(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double SecondToPicosecond(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double DecisecondToSecond(double value)
        {
            return value * 0.10000000000000001d;
        }

        public static double SecondToDecisecond(double baseValue)
        {
            return baseValue / 0.10000000000000001d;
        }

        public static double CentisecondToSecond(double value)
        {
            return value * 0.01d;
        }

        public static double SecondToCentisecond(double baseValue)
        {
            return baseValue / 0.01d;
        }
    }
}
