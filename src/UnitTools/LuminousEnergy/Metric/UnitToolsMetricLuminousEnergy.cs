namespace UnitTools.LuminousEnergy.Metric
{
    public static class UnitToolsMetricLuminousEnergy
    {
        public static double LumenSecondToLumenSecond(double value)
        {
            return value;
        }

        public static double LumenMinuteToLumenSecond(double value)
        {
            return value * 60.0d;
        }

        public static double LumenSecondToLumenMinute(double baseValue)
        {
            return baseValue / 60.0d;
        }

        public static double LumenHourToLumenSecond(double value)
        {
            return value * 3600.0d;
        }

        public static double LumenSecondToLumenHour(double baseValue)
        {
            return baseValue / 3600.0d;
        }

        public static double LumenDayToLumenSecond(double value)
        {
            return value * 86400.0d;
        }

        public static double LumenSecondToLumenDay(double baseValue)
        {
            return baseValue / 86400.0d;
        }

        public static double KilolumenHourToLumenSecond(double value)
        {
            return value * 3600000.0d;
        }

        public static double LumenSecondToKilolumenHour(double baseValue)
        {
            return baseValue / 3600000.0d;
        }

        public static double MegalumenSecondToLumenSecond(double value)
        {
            return value * 1000000.0d;
        }

        public static double LumenSecondToMegalumenSecond(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double LumenWeekToLumenSecond(double value)
        {
            return value * 604800.0d;
        }

        public static double LumenSecondToLumenWeek(double baseValue)
        {
            return baseValue / 604800.0d;
        }

        public static double LumenYearToLumenSecond(double value)
        {
            return value * 31557600.0d;
        }

        public static double LumenSecondToLumenYear(double baseValue)
        {
            return baseValue / 31557600.0d;
        }
    }
}
