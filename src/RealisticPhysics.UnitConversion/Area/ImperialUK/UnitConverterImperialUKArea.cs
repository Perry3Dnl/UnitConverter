namespace RealisticPhysics.UnitConversion.Area.ImperialUK
{
    public static class UnitConverterImperialUKArea
    {
        public static double RoodToSquareMeter(double value)
        {
            return value * 1011.7141056d;
        }

        public static double SquareMeterToRood(double baseValue)
        {
            return baseValue / 1011.7141056d;
        }
    }
}
