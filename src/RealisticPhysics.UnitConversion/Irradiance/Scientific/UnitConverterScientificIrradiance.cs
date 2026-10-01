namespace RealisticPhysics.UnitConversion.Irradiance.Scientific
{
    public static class UnitConverterScientificIrradiance
    {
        public static double LangleyPerMinuteToWattPerSquareMeter(double value)
        {
            return value * 697.33333333333337d;
        }

        public static double WattPerSquareMeterToLangleyPerMinute(double baseValue)
        {
            return baseValue / 697.33333333333337d;
        }

        public static double LangleyPerHourToWattPerSquareMeter(double value)
        {
            return value * 11.622222222222222d;
        }

        public static double WattPerSquareMeterToLangleyPerHour(double baseValue)
        {
            return baseValue / 11.622222222222222d;
        }

        public static double LangleyPerSecondToWattPerSquareMeter(double value)
        {
            return value * 41840.0d;
        }

        public static double WattPerSquareMeterToLangleyPerSecond(double baseValue)
        {
            return baseValue / 41840.0d;
        }
    }
}
