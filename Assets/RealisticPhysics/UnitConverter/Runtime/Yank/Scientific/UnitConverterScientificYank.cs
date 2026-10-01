namespace RealisticPhysics.UnitConversion.Yank.Scientific
{
    public static class UnitConverterScientificYank
    {
        public static double DynePerSecondToNewtonPerSecond(double value)
        {
            return value * 1.0000000000000001e-05d;
        }

        public static double NewtonPerSecondToDynePerSecond(double baseValue)
        {
            return baseValue / 1.0000000000000001e-05d;
        }
    }
}
