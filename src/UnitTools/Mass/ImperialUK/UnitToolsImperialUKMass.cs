namespace UnitTools.Mass.ImperialUK
{
    public static class UnitToolsImperialUKMass
    {
        public static double StoneToKilogram(double value)
        {
            return value * 6.3502931800000004d;
        }

        public static double KilogramToStone(double baseValue)
        {
            return baseValue / 6.3502931800000004d;
        }

        public static double QuarterToKilogram(double value)
        {
            return value * 12.700586360000001d;
        }

        public static double KilogramToQuarter(double baseValue)
        {
            return baseValue / 12.700586360000001d;
        }

        public static double HundredweightUKToKilogram(double value)
        {
            return value * 50.802345440000003d;
        }

        public static double KilogramToHundredweightUK(double baseValue)
        {
            return baseValue / 50.802345440000003d;
        }

        public static double LongTonToKilogram(double value)
        {
            return value * 1016.0469088d;
        }

        public static double KilogramToLongTon(double baseValue)
        {
            return baseValue / 1016.0469088d;
        }
    }
}
