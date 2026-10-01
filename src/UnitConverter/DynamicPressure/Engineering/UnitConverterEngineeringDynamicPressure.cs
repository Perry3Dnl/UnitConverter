namespace UnitConverter.DynamicPressure.Engineering
{
    public static class UnitConverterEngineeringDynamicPressure
    {
        public static double KilogramForcePerSquareCentimeterToPascal(double value)
        {
            return value * 98066.5d;
        }

        public static double PascalToKilogramForcePerSquareCentimeter(double baseValue)
        {
            return baseValue / 98066.5d;
        }
    }
}
