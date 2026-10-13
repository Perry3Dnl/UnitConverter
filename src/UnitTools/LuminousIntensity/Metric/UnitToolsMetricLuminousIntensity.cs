namespace UnitTools.LuminousIntensity.Metric
{
    public static class UnitToolsMetricLuminousIntensity
    {
        public static double CandelaToCandela(double value)
        {
            return value;
        }

        public static double MillicandelaToCandela(double value)
        {
            return value * 0.001d;
        }

        public static double CandelaToMillicandela(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilocandelaToCandela(double value)
        {
            return value * 1000.0d;
        }

        public static double CandelaToKilocandela(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MicrocandelaToCandela(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double CandelaToMicrocandela(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double NanocandelaToCandela(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double CandelaToNanocandela(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double MegacandelaToCandela(double value)
        {
            return value * 1000000.0d;
        }

        public static double CandelaToMegacandela(double baseValue)
        {
            return baseValue / 1000000.0d;
        }
    }
}
