namespace UnitConverter.Time.Common
{
    public static class UnitConverterCommonTime
    {
        public static double MinuteToSecond(double value)
        {
            return value * 60.0d;
        }

        public static double SecondToMinute(double baseValue)
        {
            return baseValue / 60.0d;
        }

        public static double HourToSecond(double value)
        {
            return value * 3600.0d;
        }

        public static double SecondToHour(double baseValue)
        {
            return baseValue / 3600.0d;
        }

        public static double DayToSecond(double value)
        {
            return value * 86400.0d;
        }

        public static double SecondToDay(double baseValue)
        {
            return baseValue / 86400.0d;
        }

        public static double WeekToSecond(double value)
        {
            return value * 604800.0d;
        }

        public static double SecondToWeek(double baseValue)
        {
            return baseValue / 604800.0d;
        }

        public static double FortnightToSecond(double value)
        {
            return value * 1209600.0d;
        }

        public static double SecondToFortnight(double baseValue)
        {
            return baseValue / 1209600.0d;
        }

        public static double CommonYearToSecond(double value)
        {
            return value * 31536000.0d;
        }

        public static double SecondToCommonYear(double baseValue)
        {
            return baseValue / 31536000.0d;
        }

        public static double JulianMonthToSecond(double value)
        {
            return value * 2629800.0d;
        }

        public static double SecondToJulianMonth(double baseValue)
        {
            return baseValue / 2629800.0d;
        }

        public static double ThirtyDayMonthToSecond(double value)
        {
            return value * 2592000.0d;
        }

        public static double SecondToThirtyDayMonth(double baseValue)
        {
            return baseValue / 2592000.0d;
        }

        public static double DecadeToSecond(double value)
        {
            return value * 315576000.0d;
        }

        public static double SecondToDecade(double baseValue)
        {
            return baseValue / 315576000.0d;
        }

        public static double CenturyToSecond(double value)
        {
            return value * 3155760000.0d;
        }

        public static double SecondToCentury(double baseValue)
        {
            return baseValue / 3155760000.0d;
        }

        public static double MillenniumToSecond(double value)
        {
            return value * 31557600000.0d;
        }

        public static double SecondToMillennium(double baseValue)
        {
            return baseValue / 31557600000.0d;
        }
    }
}
