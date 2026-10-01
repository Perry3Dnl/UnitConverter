namespace RealisticPhysics.UnitConversion.HydraulicPermeability.Metric
{
    public static class UnitConverterMetricHydraulicPermeability
    {
        public static double SquareMeterToSquareMeter(double value)
        {
            return value;
        }

        public static double SquareCentimeterToSquareMeter(double value)
        {
            return value * 0.0001d;
        }

        public static double SquareMeterToSquareCentimeter(double baseValue)
        {
            return baseValue / 0.0001d;
        }

        public static double SquareMillimeterToSquareMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double SquareMeterToSquareMillimeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double SquareMicrometerToSquareMeter(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double SquareMeterToSquareMicrometer(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double SquareNanometerToSquareMeter(double value)
        {
            return value * 1.0000000000000001e-18d;
        }

        public static double SquareMeterToSquareNanometer(double baseValue)
        {
            return baseValue / 1.0000000000000001e-18d;
        }
    }
}
