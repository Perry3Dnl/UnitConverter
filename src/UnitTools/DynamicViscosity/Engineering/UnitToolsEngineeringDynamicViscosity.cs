namespace UnitTools.DynamicViscosity.Engineering
{
    public static class UnitToolsEngineeringDynamicViscosity
    {
        public static double NewtonSecondPerSquareMeterToPascalSecond(double value)
        {
            return value * 1.0d;
        }

        public static double PascalSecondToNewtonSecondPerSquareMeter(double baseValue)
        {
            return baseValue / 1.0d;
        }
    }
}
