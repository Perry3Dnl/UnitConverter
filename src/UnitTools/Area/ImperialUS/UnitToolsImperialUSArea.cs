namespace UnitTools.Area.ImperialUS
{
    public static class UnitToolsImperialUSArea
    {
        public static double TownshipToSquareMeter(double value)
        {
            return value * 93239571.972095996d;
        }

        public static double SquareMeterToTownship(double baseValue)
        {
            return baseValue / 93239571.972095996d;
        }
    }
}
