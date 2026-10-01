namespace RealisticPhysics.UnitConversion.Mass.Scientific
{
    public static class UnitConverterScientificMass
    {
        public static double AtomicMassUnitToKilogram(double value)
        {
            return value * 1.6605390666e-27d;
        }

        public static double KilogramToAtomicMassUnit(double baseValue)
        {
            return baseValue / 1.6605390666e-27d;
        }

        public static double ElectronMassToKilogram(double value)
        {
            return value * 9.1093837015000008e-31d;
        }

        public static double KilogramToElectronMass(double baseValue)
        {
            return baseValue / 9.1093837015000008e-31d;
        }

        public static double ProtonMassToKilogram(double value)
        {
            return value * 1.6726219236900001e-27d;
        }

        public static double KilogramToProtonMass(double baseValue)
        {
            return baseValue / 1.6726219236900001e-27d;
        }

        public static double NeutronMassToKilogram(double value)
        {
            return value * 1.67492749804e-27d;
        }

        public static double KilogramToNeutronMass(double baseValue)
        {
            return baseValue / 1.67492749804e-27d;
        }

        public static double PlanckMassToKilogram(double value)
        {
            return value * 2.1764340000000001e-08d;
        }

        public static double KilogramToPlanckMass(double baseValue)
        {
            return baseValue / 2.1764340000000001e-08d;
        }

        public static double PlanckMassGramToKilogram(double value)
        {
            return value * 2.1764339999999999e-11d;
        }

        public static double KilogramToPlanckMassGram(double baseValue)
        {
            return baseValue / 2.1764339999999999e-11d;
        }
    }
}
