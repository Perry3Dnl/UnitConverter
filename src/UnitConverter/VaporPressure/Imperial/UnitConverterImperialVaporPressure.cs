namespace UnitConverter.VaporPressure.Imperial
{
    public static class UnitConverterImperialVaporPressure
    {
        public static double PsiToPascal(double value)
        {
            return value * 6894.7572931679997d;
        }

        public static double PascalToPsi(double baseValue)
        {
            return baseValue / 6894.7572931679997d;
        }

        public static double InchMercuryToPascal(double value)
        {
            return value * 3386.38815789d;
        }

        public static double PascalToInchMercury(double baseValue)
        {
            return baseValue / 3386.38815789d;
        }

        public static double InchWaterToPascal(double value)
        {
            return value * 249.08891d;
        }

        public static double PascalToInchWater(double baseValue)
        {
            return baseValue / 249.08891d;
        }
    }
}
