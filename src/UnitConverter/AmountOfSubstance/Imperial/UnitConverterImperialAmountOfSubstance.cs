namespace UnitConverter.AmountOfSubstance.Imperial
{
    public static class UnitConverterImperialAmountOfSubstance
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
