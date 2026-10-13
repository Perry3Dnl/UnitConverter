namespace UnitTools.PressureGradient.Imperial
{
    public static class UnitToolsImperialPressureGradient
    {
        public static double PsiPerFootToPascalPerMeter(double value)
        {
            return value * 22620.594793858265d;
        }

        public static double PascalPerMeterToPsiPerFoot(double baseValue)
        {
            return baseValue / 22620.594793858265d;
        }

        public static double PsiPerInchToPascalPerMeter(double value)
        {
            return value * 271447.13752629922d;
        }

        public static double PascalPerMeterToPsiPerInch(double baseValue)
        {
            return baseValue / 271447.13752629922d;
        }

        public static double InchMercuryPerFootToPascalPerMeter(double value)
        {
            return value * 11110.197368405512d;
        }

        public static double PascalPerMeterToInchMercuryPerFoot(double baseValue)
        {
            return baseValue / 11110.197368405512d;
        }
    }
}
