namespace UnitConverter.Radiance.Imperial
{
    public static class UnitConverterImperialRadiance
    {
        public static double WattPerSteradianSquareFootToWattPerSteradianSquareMeter(double value)
        {
            return value * 10.763910416709722d;
        }

        public static double WattPerSteradianSquareMeterToWattPerSteradianSquareFoot(double baseValue)
        {
            return baseValue / 10.763910416709722d;
        }

        public static double WattPerSteradianSquareInchToWattPerSteradianSquareMeter(double value)
        {
            return value * 1550.0031000062002d;
        }

        public static double WattPerSteradianSquareMeterToWattPerSteradianSquareInch(double baseValue)
        {
            return baseValue / 1550.0031000062002d;
        }
    }
}
