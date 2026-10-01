namespace RealisticPhysics.UnitConversion.ElectricCharge.Scientific
{
    public static class UnitConverterScientificElectricCharge
    {
        public static double FaradayToCoulomb(double value)
        {
            return value * 96485.332123310014d;
        }

        public static double CoulombToFaraday(double baseValue)
        {
            return baseValue / 96485.332123310014d;
        }

        public static double ElementaryChargeToCoulomb(double value)
        {
            return value * 1.6021766339999999e-19d;
        }

        public static double CoulombToElementaryCharge(double baseValue)
        {
            return baseValue / 1.6021766339999999e-19d;
        }

        public static double StatcoulombToCoulomb(double value)
        {
            return value * 3.3356409519815202e-10d;
        }

        public static double CoulombToStatcoulomb(double baseValue)
        {
            return baseValue / 3.3356409519815202e-10d;
        }

        public static double FranklinToCoulomb(double value)
        {
            return value * 3.3356409519815202e-10d;
        }

        public static double CoulombToFranklin(double baseValue)
        {
            return baseValue / 3.3356409519815202e-10d;
        }

        public static double AbcoulombToCoulomb(double value)
        {
            return value * 10.0d;
        }

        public static double CoulombToAbcoulomb(double baseValue)
        {
            return baseValue / 10.0d;
        }
    }
}
