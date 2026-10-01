namespace UnitConverter.Capacitance.Scientific
{
    public static class UnitConverterScientificCapacitance
    {
        public static double AbfaradToFarad(double value)
        {
            return value * 1000000000.0d;
        }

        public static double FaradToAbfarad(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }

        public static double StatfaradToFarad(double value)
        {
            return value * 1.1126500559999999e-12d;
        }

        public static double FaradToStatfarad(double baseValue)
        {
            return baseValue / 1.1126500559999999e-12d;
        }
    }
}
