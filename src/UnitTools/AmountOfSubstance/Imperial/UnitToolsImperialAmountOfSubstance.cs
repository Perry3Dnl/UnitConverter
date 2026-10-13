namespace UnitTools.AmountOfSubstance.Imperial
{
    public static class UnitToolsImperialAmountOfSubstance
    {
        public static double PoundMoleToMole(double value)
        {
            return value * 453.59237000000002d;
        }

        public static double MoleToPoundMole(double baseValue)
        {
            return baseValue / 453.59237000000002d;
        }
    }
}
