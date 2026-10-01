namespace UnitConverter.AngularMomentum.Scientific
{
    public static class UnitConverterScientificAngularMomentum
    {
        public static double PlanckConstantToKilogramSquareMeterPerSecond(double value)
        {
            return value * 6.6260701499999998e-34d;
        }

        public static double KilogramSquareMeterPerSecondToPlanckConstant(double baseValue)
        {
            return baseValue / 6.6260701499999998e-34d;
        }

        public static double ReducedPlanckConstantToKilogramSquareMeterPerSecond(double value)
        {
            return value * 1.054571817e-34d;
        }

        public static double KilogramSquareMeterPerSecondToReducedPlanckConstant(double baseValue)
        {
            return baseValue / 1.054571817e-34d;
        }
    }
}
