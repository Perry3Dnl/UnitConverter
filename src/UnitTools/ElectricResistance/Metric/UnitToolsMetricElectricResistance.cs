namespace UnitTools.ElectricResistance.Metric
{
    public static class UnitToolsMetricElectricResistance
    {
        public static double MicroohmToOhm(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double OhmToMicroohm(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MilliohmToOhm(double value)
        {
            return value * 0.001d;
        }

        public static double OhmToMilliohm(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double OhmToOhm(double value)
        {
            return value;
        }

        public static double KiloohmToOhm(double value)
        {
            return value * 1000.0d;
        }

        public static double OhmToKiloohm(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegaohmToOhm(double value)
        {
            return value * 1000000.0d;
        }

        public static double OhmToMegaohm(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double GigaohmToOhm(double value)
        {
            return value * 1000000000.0d;
        }

        public static double OhmToGigaohm(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }

        public static double PicoohmToOhm(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double OhmToPicoohm(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double NanoohmToOhm(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double OhmToNanoohm(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double TeraohmToOhm(double value)
        {
            return value * 1000000000000.0d;
        }

        public static double OhmToTeraohm(double baseValue)
        {
            return baseValue / 1000000000000.0d;
        }

        public static double PetaohmToOhm(double value)
        {
            return value * 1000000000000000.0d;
        }

        public static double OhmToPetaohm(double baseValue)
        {
            return baseValue / 1000000000000000.0d;
        }
    }
}
