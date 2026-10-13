namespace UnitTools.Force.Scientific
{
    public static class UnitToolsScientificForce
    {
        public static double DyneToNewton(double value)
        {
            return value * 1.0000000000000001e-05d;
        }

        public static double NewtonToDyne(double baseValue)
        {
            return baseValue / 1.0000000000000001e-05d;
        }

        public static double PlanckForceToNewton(double value)
        {
            return value * 1.2102699999999999e+44d;
        }

        public static double NewtonToPlanckForce(double baseValue)
        {
            return baseValue / 1.2102699999999999e+44d;
        }
    }
}
