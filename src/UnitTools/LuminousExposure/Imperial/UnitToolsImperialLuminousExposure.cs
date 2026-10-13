namespace UnitTools.LuminousExposure.Imperial
{
    public static class UnitToolsImperialLuminousExposure
    {
        public static double FootCandleSecondToLuxSecond(double value)
        {
            return value * 10.763910416709722d;
        }

        public static double LuxSecondToFootCandleSecond(double baseValue)
        {
            return baseValue / 10.763910416709722d;
        }

        public static double FootCandleMinuteToLuxSecond(double value)
        {
            return value * 645.83462500258327d;
        }

        public static double LuxSecondToFootCandleMinute(double baseValue)
        {
            return baseValue / 645.83462500258327d;
        }

        public static double FootCandleHourToLuxSecond(double value)
        {
            return value * 38750.077500154999d;
        }

        public static double LuxSecondToFootCandleHour(double baseValue)
        {
            return baseValue / 38750.077500154999d;
        }
    }
}
