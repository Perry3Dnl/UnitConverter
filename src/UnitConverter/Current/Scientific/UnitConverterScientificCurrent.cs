namespace UnitConverter.Current.Scientific
{
    public static class UnitConverterScientificCurrent
    {
        public static double StatampereToAmpere(double value)
        {
            return value * 3.335641e-10d;
        }

        public static double AmpereToStatampere(double baseValue)
        {
            return baseValue / 3.335641e-10d;
        }

        public static double AbampereToAmpere(double value)
        {
            return value * 10.0d;
        }

        public static double AmpereToAbampere(double baseValue)
        {
            return baseValue / 10.0d;
        }

        public static double BiotToAmpere(double value)
        {
            return value * 10.0d;
        }

        public static double AmpereToBiot(double baseValue)
        {
            return baseValue / 10.0d;
        }
    }
}
