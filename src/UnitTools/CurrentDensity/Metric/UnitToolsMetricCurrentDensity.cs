namespace UnitTools.CurrentDensity.Metric
{
    public static class UnitToolsMetricCurrentDensity
    {
        public static double AmperePerSquareMeterToAmperePerSquareMeter(double value)
        {
            return value;
        }

        public static double MilliamperePerSquareMeterToAmperePerSquareMeter(double value)
        {
            return value * 0.001d;
        }

        public static double AmperePerSquareMeterToMilliamperePerSquareMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double AmperePerSquareCentimeterToAmperePerSquareMeter(double value)
        {
            return value * 10000.0d;
        }

        public static double AmperePerSquareMeterToAmperePerSquareCentimeter(double baseValue)
        {
            return baseValue / 10000.0d;
        }

        public static double AmperePerSquareMillimeterToAmperePerSquareMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double AmperePerSquareMeterToAmperePerSquareMillimeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double KiloamperePerSquareMeterToAmperePerSquareMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double AmperePerSquareMeterToKiloamperePerSquareMeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegaamperePerSquareMeterToAmperePerSquareMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double AmperePerSquareMeterToMegaamperePerSquareMeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double MilliamperePerSquareCentimeterToAmperePerSquareMeter(double value)
        {
            return value * 10.0d;
        }

        public static double AmperePerSquareMeterToMilliamperePerSquareCentimeter(double baseValue)
        {
            return baseValue / 10.0d;
        }

        public static double MicroamperePerSquareCentimeterToAmperePerSquareMeter(double value)
        {
            return value * 0.01d;
        }

        public static double AmperePerSquareMeterToMicroamperePerSquareCentimeter(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double NanoamperePerSquareMeterToAmperePerSquareMeter(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double AmperePerSquareMeterToNanoamperePerSquareMeter(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double KiloamperePerSquareCentimeterToAmperePerSquareMeter(double value)
        {
            return value * 10000000.0d;
        }

        public static double AmperePerSquareMeterToKiloamperePerSquareCentimeter(double baseValue)
        {
            return baseValue / 10000000.0d;
        }

        public static double MegaamperePerSquareMillimeterToAmperePerSquareMeter(double value)
        {
            return value * 1000000000000.0d;
        }

        public static double AmperePerSquareMeterToMegaamperePerSquareMillimeter(double baseValue)
        {
            return baseValue / 1000000000000.0d;
        }
    }
}
