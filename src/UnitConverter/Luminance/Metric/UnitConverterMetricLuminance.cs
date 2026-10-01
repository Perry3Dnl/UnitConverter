namespace UnitConverter.Luminance.Metric
{
    public static class UnitConverterMetricLuminance
    {
        public static double CandelaPerSquareMeterToCandelaPerSquareMeter(double value)
        {
            return value;
        }

        public static double NitToCandelaPerSquareMeter(double value)
        {
            return value * 1.0d;
        }

        public static double CandelaPerSquareMeterToNit(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double StilbToCandelaPerSquareMeter(double value)
        {
            return value * 10000.0d;
        }

        public static double CandelaPerSquareMeterToStilb(double baseValue)
        {
            return baseValue / 10000.0d;
        }

        public static double LambertToCandelaPerSquareMeter(double value)
        {
            return value * 3183.098861837907d;
        }

        public static double CandelaPerSquareMeterToLambert(double baseValue)
        {
            return baseValue / 3183.098861837907d;
        }

        public static double ApostilbToCandelaPerSquareMeter(double value)
        {
            return value * 0.31830988618379069d;
        }

        public static double CandelaPerSquareMeterToApostilb(double baseValue)
        {
            return baseValue / 0.31830988618379069d;
        }

        public static double CandelaPerSquareCentimeterToCandelaPerSquareMeter(double value)
        {
            return value * 10000.0d;
        }

        public static double CandelaPerSquareMeterToCandelaPerSquareCentimeter(double baseValue)
        {
            return baseValue / 10000.0d;
        }

        public static double CandelaPerSquareMillimeterToCandelaPerSquareMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double CandelaPerSquareMeterToCandelaPerSquareMillimeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }
    }
}
