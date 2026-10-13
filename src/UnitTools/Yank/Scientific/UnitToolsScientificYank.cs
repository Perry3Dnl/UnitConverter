namespace UnitTools.Yank.Scientific
{
    public static class UnitToolsScientificYank
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
