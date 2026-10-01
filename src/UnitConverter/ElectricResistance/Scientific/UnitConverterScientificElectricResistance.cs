namespace UnitConverter.ElectricResistance.Scientific
{
    public static class UnitConverterScientificElectricResistance
    {
        public static double StatohmToOhm(double value)
        {
            return value * 898755178700.0d;
        }

        public static double OhmToStatohm(double baseValue)
        {
            return baseValue / 898755178700.0d;
        }

        public static double AbohmToOhm(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double OhmToAbohm(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double QuantumHallResistanceToOhm(double value)
        {
            return value * 25812.80745d;
        }

        public static double OhmToQuantumHallResistance(double baseValue)
        {
            return baseValue / 25812.80745d;
        }
    }
}
