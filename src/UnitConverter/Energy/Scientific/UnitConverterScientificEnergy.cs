namespace UnitConverter.Energy.Scientific
{
    public static class UnitConverterScientificEnergy
    {
        public static double ElectronVoltToJoule(double value)
        {
            return value * 1.6021766339999999e-19d;
        }

        public static double JouleToElectronVolt(double baseValue)
        {
            return baseValue / 1.6021766339999999e-19d;
        }

        public static double ErgToJoule(double value)
        {
            return value * 9.9999999999999995e-08d;
        }

        public static double JouleToErg(double baseValue)
        {
            return baseValue / 9.9999999999999995e-08d;
        }

        public static double TonTNTToJoule(double value)
        {
            return value * 4184000000.0d;
        }

        public static double JouleToTonTNT(double baseValue)
        {
            return baseValue / 4184000000.0d;
        }

        public static double KiloelectronVoltToJoule(double value)
        {
            return value * 1.6021766339999999e-16d;
        }

        public static double JouleToKiloelectronVolt(double baseValue)
        {
            return baseValue / 1.6021766339999999e-16d;
        }

        public static double MegaelectronVoltToJoule(double value)
        {
            return value * 1.6021766340000001e-13d;
        }

        public static double JouleToMegaelectronVolt(double baseValue)
        {
            return baseValue / 1.6021766340000001e-13d;
        }

        public static double GigaelectronVoltToJoule(double value)
        {
            return value * 1.6021766340000001e-10d;
        }

        public static double JouleToGigaelectronVolt(double baseValue)
        {
            return baseValue / 1.6021766340000001e-10d;
        }

        public static double TeraelectronVoltToJoule(double value)
        {
            return value * 1.6021766339999999e-07d;
        }

        public static double JouleToTeraelectronVolt(double baseValue)
        {
            return baseValue / 1.6021766339999999e-07d;
        }
    }
}
