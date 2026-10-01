namespace UnitConverter.MassFlowRate.ImperialUK
{
    public static class UnitConverterImperialUKMassFlowRate
    {
        public static double LongTonPerHourToKilogramPerSecond(double value)
        {
            return value * 0.28223525244444442d;
        }

        public static double KilogramPerSecondToLongTonPerHour(double baseValue)
        {
            return baseValue / 0.28223525244444442d;
        }

        public static double LongTonPerSecondToKilogramPerSecond(double value)
        {
            return value * 1016.0469088d;
        }

        public static double KilogramPerSecondToLongTonPerSecond(double baseValue)
        {
            return baseValue / 1016.0469088d;
        }

        public static double LongTonPerDayToKilogramPerSecond(double value)
        {
            return value * 0.011759802185185185d;
        }

        public static double KilogramPerSecondToLongTonPerDay(double baseValue)
        {
            return baseValue / 0.011759802185185185d;
        }
    }
}
