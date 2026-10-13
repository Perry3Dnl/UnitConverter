namespace UnitTools.AmountOfSubstance.Scientific
{
    public static class UnitToolsScientificAmountOfSubstance
    {
        public static double ParticleToMole(double value)
        {
            return value * 1.6605390671738466e-24d;
        }

        public static double MoleToParticle(double baseValue)
        {
            return baseValue / 1.6605390671738466e-24d;
        }

        public static double MoleculeToMole(double value)
        {
            return value * 1.6605390671738466e-24d;
        }

        public static double MoleToMolecule(double baseValue)
        {
            return baseValue / 1.6605390671738466e-24d;
        }

        public static double InternationalUnitMoleApproxToMole(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double MoleToInternationalUnitMoleApprox(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }
    }
}
