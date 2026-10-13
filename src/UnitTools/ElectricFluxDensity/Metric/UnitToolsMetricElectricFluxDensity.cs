namespace UnitTools.ElectricFluxDensity.Metric
{
    public static class UnitToolsMetricElectricFluxDensity
    {
        public static double CoulombPerSquareMeterToCoulombPerSquareMeter(double value)
        {
            return value;
        }

        public static double MillicoulombPerSquareMeterToCoulombPerSquareMeter(double value)
        {
            return value * 0.001d;
        }

        public static double CoulombPerSquareMeterToMillicoulombPerSquareMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicrocoulombPerSquareMeterToCoulombPerSquareMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double CoulombPerSquareMeterToMicrocoulombPerSquareMeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double CoulombPerSquareCentimeterToCoulombPerSquareMeter(double value)
        {
            return value * 10000.0d;
        }

        public static double CoulombPerSquareMeterToCoulombPerSquareCentimeter(double baseValue)
        {
            return baseValue / 10000.0d;
        }

        public static double NanocoulombPerSquareMeterToCoulombPerSquareMeter(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double CoulombPerSquareMeterToNanocoulombPerSquareMeter(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double MicrocoulombPerSquareCentimeterToCoulombPerSquareMeter(double value)
        {
            return value * 0.0099999999999999985d;
        }

        public static double CoulombPerSquareMeterToMicrocoulombPerSquareCentimeter(double baseValue)
        {
            return baseValue / 0.0099999999999999985d;
        }

        public static double NanocoulombPerSquareCentimeterToCoulombPerSquareMeter(double value)
        {
            return value * 1.0000000000000001e-05d;
        }

        public static double CoulombPerSquareMeterToNanocoulombPerSquareCentimeter(double baseValue)
        {
            return baseValue / 1.0000000000000001e-05d;
        }
    }
}
