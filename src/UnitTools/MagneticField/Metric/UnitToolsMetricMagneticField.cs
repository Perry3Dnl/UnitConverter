namespace UnitTools.MagneticField.Metric
{
    public static class UnitToolsMetricMagneticField
    {
        public static double NanoteslaToTesla(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double TeslaToNanotesla(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double MicroteslaToTesla(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double TeslaToMicrotesla(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MilliteslaToTesla(double value)
        {
            return value * 0.001d;
        }

        public static double TeslaToMillitesla(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double TeslaToTesla(double value)
        {
            return value;
        }

        public static double PicoteslaToTesla(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double TeslaToPicotesla(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double KiloteslaToTesla(double value)
        {
            return value * 1000.0d;
        }

        public static double TeslaToKilotesla(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegateslaToTesla(double value)
        {
            return value * 1000000.0d;
        }

        public static double TeslaToMegatesla(double baseValue)
        {
            return baseValue / 1000000.0d;
        }
    }
}
