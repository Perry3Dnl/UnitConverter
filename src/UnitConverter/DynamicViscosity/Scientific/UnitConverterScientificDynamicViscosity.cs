namespace UnitConverter.DynamicViscosity.Scientific
{
    public static class UnitConverterScientificDynamicViscosity
    {
        public static double DyneSecondPerSquareCentimeterToPascalSecond(double value)
        {
            return value * 0.10000000000000001d;
        }

        public static double PascalSecondToDyneSecondPerSquareCentimeter(double baseValue)
        {
            return baseValue / 0.10000000000000001d;
        }
    }
}
