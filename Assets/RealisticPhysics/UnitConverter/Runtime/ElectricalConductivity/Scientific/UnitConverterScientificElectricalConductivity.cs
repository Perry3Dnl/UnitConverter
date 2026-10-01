namespace RealisticPhysics.UnitConversion.ElectricalConductivity.Scientific
{
    public static class UnitConverterScientificElectricalConductivity
    {
        public static double AbmhoPerCentimeterToSiemensPerMeter(double value)
        {
            return value * 100000000000.0d;
        }

        public static double SiemensPerMeterToAbmhoPerCentimeter(double baseValue)
        {
            return baseValue / 100000000000.0d;
        }

        public static double StatmhoPerCentimeterToSiemensPerMeter(double value)
        {
            return value * 1.11265e-10d;
        }

        public static double SiemensPerMeterToStatmhoPerCentimeter(double baseValue)
        {
            return baseValue / 1.11265e-10d;
        }

        public static double StatmhoPerMeterToSiemensPerMeter(double value)
        {
            return value * 1.1126500559999999e-12d;
        }

        public static double SiemensPerMeterToStatmhoPerMeter(double baseValue)
        {
            return baseValue / 1.1126500559999999e-12d;
        }
    }
}
