namespace UnitConverter.Length.ImperialUS
{
    public static class UnitConverterImperialUSLength
    {
        public static double USSurveyInchToMeter(double value)
        {
            return value * 0.0254000508001016d;
        }

        public static double MeterToUSSurveyInch(double baseValue)
        {
            return baseValue / 0.0254000508001016d;
        }

        public static double USSurveyFootToMeter(double value)
        {
            return value * 0.30480060960121919d;
        }

        public static double MeterToUSSurveyFoot(double baseValue)
        {
            return baseValue / 0.30480060960121919d;
        }

        public static double USSurveyYardToMeter(double value)
        {
            return value * 0.91440182880365761d;
        }

        public static double MeterToUSSurveyYard(double baseValue)
        {
            return baseValue / 0.91440182880365761d;
        }

        public static double USSurveyMileToMeter(double value)
        {
            return value * 1609.3472186944373d;
        }

        public static double MeterToUSSurveyMile(double baseValue)
        {
            return baseValue / 1609.3472186944373d;
        }
    }
}
