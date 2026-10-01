namespace UnitConverter.Compressibility.Imperial
{
    public static class UnitConverterImperialCompressibility
    {
        public static double PerPsiToPerPascal(double value)
        {
            return value * 0.00014503773773021683d;
        }

        public static double PerPascalToPerPsi(double baseValue)
        {
            return baseValue / 0.00014503773773021683d;
        }

        public static double PerInchMercuryToPerPascal(double value)
        {
            return value * 0.00029529987508079483d;
        }

        public static double PerPascalToPerInchMercury(double baseValue)
        {
            return baseValue / 0.00029529987508079483d;
        }
    }
}
