namespace UnitTools.Radioactivity.Historical
{
    public static class UnitToolsHistoricalRadioactivity
    {
        public static double RutherfordToBecquerel(double value)
        {
            return value * 1000000.0d;
        }

        public static double BecquerelToRutherford(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double PicocurieToBecquerel(double value)
        {
            return value * 0.036999999999999998d;
        }

        public static double BecquerelToPicocurie(double baseValue)
        {
            return baseValue / 0.036999999999999998d;
        }

        public static double NanocurieToBecquerel(double value)
        {
            return value * 37.0d;
        }

        public static double BecquerelToNanocurie(double baseValue)
        {
            return baseValue / 37.0d;
        }

        public static double KilocurieToBecquerel(double value)
        {
            return value * 37000000000000.0d;
        }

        public static double BecquerelToKilocurie(double baseValue)
        {
            return baseValue / 37000000000000.0d;
        }

        public static double MegacurieToBecquerel(double value)
        {
            return value * 37000000000000000.0d;
        }

        public static double BecquerelToMegacurie(double baseValue)
        {
            return baseValue / 37000000000000000.0d;
        }
    }
}
