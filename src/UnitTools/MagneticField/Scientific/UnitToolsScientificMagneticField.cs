namespace UnitTools.MagneticField.Scientific
{
    public static class UnitToolsScientificMagneticField
    {
        public static double GammaToTesla(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double TeslaToGamma(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double LinePerSquareCentimeterToTesla(double value)
        {
            return value * 0.0001d;
        }

        public static double TeslaToLinePerSquareCentimeter(double baseValue)
        {
            return baseValue / 0.0001d;
        }

        public static double MicrogaussToTesla(double value)
        {
            return value * 1e-10d;
        }

        public static double TeslaToMicrogauss(double baseValue)
        {
            return baseValue / 1e-10d;
        }

        public static double MilligaussToTesla(double value)
        {
            return value * 9.9999999999999995e-08d;
        }

        public static double TeslaToMilligauss(double baseValue)
        {
            return baseValue / 9.9999999999999995e-08d;
        }

        public static double KilogaussToTesla(double value)
        {
            return value * 0.10000000000000001d;
        }

        public static double TeslaToKilogauss(double baseValue)
        {
            return baseValue / 0.10000000000000001d;
        }

        public static double MegagaussToTesla(double value)
        {
            return value * 100.0d;
        }

        public static double TeslaToMegagauss(double baseValue)
        {
            return baseValue / 100.0d;
        }

        public static double OerstedVacuumEquivalentToTesla(double value)
        {
            return value * 0.0001d;
        }

        public static double TeslaToOerstedVacuumEquivalent(double baseValue)
        {
            return baseValue / 0.0001d;
        }
    }
}
