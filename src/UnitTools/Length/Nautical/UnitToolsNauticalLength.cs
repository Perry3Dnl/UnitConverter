namespace UnitTools.Length.Nautical
{
    public static class UnitToolsNauticalLength
    {
        public static double FathomToMeter(double value)
        {
            return value * 1.8288d;
        }

        public static double MeterToFathom(double baseValue)
        {
            return baseValue / 1.8288d;
        }

        public static double CableToMeter(double value)
        {
            return value * 185.19999999999999d;
        }

        public static double MeterToCable(double baseValue)
        {
            return baseValue / 185.19999999999999d;
        }

        public static double NauticalMileToMeter(double value)
        {
            return value * 1852.0d;
        }

        public static double MeterToNauticalMile(double baseValue)
        {
            return baseValue / 1852.0d;
        }

        public static double NauticalLeagueToMeter(double value)
        {
            return value * 5556.0d;
        }

        public static double MeterToNauticalLeague(double baseValue)
        {
            return baseValue / 5556.0d;
        }
    }
}
