namespace RealisticPhysics.UnitConversion.Area.Scientific
{
    public static class UnitConverterScientificArea
    {
        public static double BarnToSquareMeter(double value)
        {
            return value * 9.9999999999999997e-29d;
        }

        public static double SquareMeterToBarn(double baseValue)
        {
            return baseValue / 9.9999999999999997e-29d;
        }
    }
}
