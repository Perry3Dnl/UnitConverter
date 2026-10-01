namespace UnitConverter.Pressure.ImperialUS
{
    public static class UnitConverterImperialUSPressure
    {
        public static double TonForceUSPerSquareFootToPascal(double value)
        {
            return value * 95760.517960678219d;
        }

        public static double PascalToTonForceUSPerSquareFoot(double baseValue)
        {
            return baseValue / 95760.517960678219d;
        }
    }
}
