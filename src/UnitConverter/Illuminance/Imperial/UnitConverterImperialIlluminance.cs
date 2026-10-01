namespace UnitConverter.Illuminance.Imperial
{
    public static class UnitConverterImperialIlluminance
    {
        public static double FootCandleToLux(double value)
        {
            return value * 10.763910416709722d;
        }

        public static double LuxToFootCandle(double baseValue)
        {
            return baseValue / 10.763910416709722d;
        }

        public static double LumenPerSquareFootToLux(double value)
        {
            return value * 10.763910416709722d;
        }

        public static double LuxToLumenPerSquareFoot(double baseValue)
        {
            return baseValue / 10.763910416709722d;
        }

        public static double LumenPerSquareInchToLux(double value)
        {
            return value * 1550.0031000062002d;
        }

        public static double LuxToLumenPerSquareInch(double baseValue)
        {
            return baseValue / 1550.0031000062002d;
        }
    }
}
