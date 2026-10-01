namespace UnitConverter.Conductance.Scientific
{
    public static class UnitConverterScientificConductance
    {
        public static double AbmhoToSiemens(double value)
        {
            return value * 1000000000.0d;
        }

        public static double SiemensToAbmho(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }

        public static double StatmhoToSiemens(double value)
        {
            return value * 1.1126500559999999e-12d;
        }

        public static double SiemensToStatmho(double baseValue)
        {
            return baseValue / 1.1126500559999999e-12d;
        }
    }
}
