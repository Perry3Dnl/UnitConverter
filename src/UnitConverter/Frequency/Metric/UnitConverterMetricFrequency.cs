namespace UnitConverter.Frequency.Metric
{
    public static class UnitConverterMetricFrequency
    {
        public static double MillihertzToHertz(double value)
        {
            return value * 0.001d;
        }

        public static double HertzToMillihertz(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double HertzToHertz(double value)
        {
            return value;
        }

        public static double KilohertzToHertz(double value)
        {
            return value * 1000.0d;
        }

        public static double HertzToKilohertz(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegahertzToHertz(double value)
        {
            return value * 1000000.0d;
        }

        public static double HertzToMegahertz(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double GigahertzToHertz(double value)
        {
            return value * 1000000000.0d;
        }

        public static double HertzToGigahertz(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }

        public static double TerahertzToHertz(double value)
        {
            return value * 1000000000000.0d;
        }

        public static double HertzToTerahertz(double baseValue)
        {
            return baseValue / 1000000000000.0d;
        }

        public static double PicohertzToHertz(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double HertzToPicohertz(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double NanohertzToHertz(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double HertzToNanohertz(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double MicrohertzToHertz(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double HertzToMicrohertz(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double PetahertzToHertz(double value)
        {
            return value * 1000000000000000.0d;
        }

        public static double HertzToPetahertz(double baseValue)
        {
            return baseValue / 1000000000000000.0d;
        }

        public static double ExahertzToHertz(double value)
        {
            return value * 1e+18d;
        }

        public static double HertzToExahertz(double baseValue)
        {
            return baseValue / 1e+18d;
        }
    }
}
