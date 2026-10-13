namespace UnitTools.Time.Astronomical
{
    public static class UnitToolsAstronomicalTime
    {
        public static double SiderealDayToSecond(double value)
        {
            return value * 86164.090500000006d;
        }

        public static double SecondToSiderealDay(double baseValue)
        {
            return baseValue / 86164.090500000006d;
        }

        public static double TropicalYearToSecond(double value)
        {
            return value * 31556925.215999998d;
        }

        public static double SecondToTropicalYear(double baseValue)
        {
            return baseValue / 31556925.215999998d;
        }

        public static double SiderealYearToSecond(double value)
        {
            return value * 31558149.763545599d;
        }

        public static double SecondToSiderealYear(double baseValue)
        {
            return baseValue / 31558149.763545599d;
        }
    }
}
