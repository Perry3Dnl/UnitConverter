namespace UnitTools.Inductance.Scientific
{
    public static class UnitToolsScientificInductance
    {
        public static double AbhenryToHenry(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double HenryToAbhenry(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double StathenryToHenry(double value)
        {
            return value * 898755178700.0d;
        }

        public static double HenryToStathenry(double baseValue)
        {
            return baseValue / 898755178700.0d;
        }
    }
}
