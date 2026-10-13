namespace UnitTools.Current.Metric
{
    public static class UnitToolsMetricCurrent
    {
        public static double NanoampereToAmpere(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double AmpereToNanoampere(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double MicroampereToAmpere(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double AmpereToMicroampere(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MilliampereToAmpere(double value)
        {
            return value * 0.001d;
        }

        public static double AmpereToMilliampere(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double AmpereToAmpere(double value)
        {
            return value;
        }

        public static double KiloampereToAmpere(double value)
        {
            return value * 1000.0d;
        }

        public static double AmpereToKiloampere(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegaampereToAmpere(double value)
        {
            return value * 1000000.0d;
        }

        public static double AmpereToMegaampere(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double FemtoampereToAmpere(double value)
        {
            return value * 1.0000000000000001e-15d;
        }

        public static double AmpereToFemtoampere(double baseValue)
        {
            return baseValue / 1.0000000000000001e-15d;
        }

        public static double PicoampereToAmpere(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double AmpereToPicoampere(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double TeraampereToAmpere(double value)
        {
            return value * 1000000000000.0d;
        }

        public static double AmpereToTeraampere(double baseValue)
        {
            return baseValue / 1000000000000.0d;
        }

        public static double PetaampereToAmpere(double value)
        {
            return value * 1000000000000000.0d;
        }

        public static double AmpereToPetaampere(double baseValue)
        {
            return baseValue / 1000000000000000.0d;
        }
    }
}
