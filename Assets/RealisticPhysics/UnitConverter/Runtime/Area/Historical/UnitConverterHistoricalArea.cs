namespace RealisticPhysics.UnitConversion.Area.Historical
{
    public static class UnitConverterHistoricalArea
    {
        public static double SquareLeagueToSquareMeter(double value)
        {
            return value * 23309809.0d;
        }

        public static double SquareMeterToSquareLeague(double baseValue)
        {
            return baseValue / 23309809.0d;
        }

        public static double DunamToSquareMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double SquareMeterToDunam(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double TatamiToSquareMeter(double value)
        {
            return value * 1.653d;
        }

        public static double SquareMeterToTatami(double baseValue)
        {
            return baseValue / 1.653d;
        }
    }
}
