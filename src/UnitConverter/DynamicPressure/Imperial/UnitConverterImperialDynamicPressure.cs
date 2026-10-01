namespace UnitConverter.DynamicPressure.Imperial
{
    public static class UnitConverterImperialDynamicPressure
    {
        public static double PsiToPascal(double value)
        {
            return value * 6894.7572931679997d;
        }

        public static double PascalToPsi(double baseValue)
        {
            return baseValue / 6894.7572931679997d;
        }

        public static double PsfToPascal(double value)
        {
            return value * 47.880258980335839d;
        }

        public static double PascalToPsf(double baseValue)
        {
            return baseValue / 47.880258980335839d;
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

        public static double FootWaterToPascal(double value)
        {
            return value * 2989.0669200000002d;
        }

        public static double PascalToFootWater(double baseValue)
        {
            return baseValue / 2989.0669200000002d;
        }
    }
}
