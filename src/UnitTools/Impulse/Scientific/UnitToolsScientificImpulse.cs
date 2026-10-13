namespace UnitTools.Impulse.Scientific
{
    public static class UnitToolsScientificImpulse
    {
        public static double DyneSecondToNewtonSecond(double value)
        {
            return value * 1.0000000000000001e-05d;
        }

        public static double NewtonSecondToDyneSecond(double baseValue)
        {
            return baseValue / 1.0000000000000001e-05d;
        }
    }
}
