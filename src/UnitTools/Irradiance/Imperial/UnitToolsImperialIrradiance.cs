namespace UnitTools.Irradiance.Imperial
{
    public static class UnitToolsImperialIrradiance
    {
        public static double WattPerSquareFootToWattPerSquareMeter(double value)
        {
            return value * 10.763910416709722d;
        }

        public static double WattPerSquareMeterToWattPerSquareFoot(double baseValue)
        {
            return baseValue / 10.763910416709722d;
        }

        public static double WattPerSquareInchToWattPerSquareMeter(double value)
        {
            return value * 1550.0031000062002d;
        }

        public static double WattPerSquareMeterToWattPerSquareInch(double baseValue)
        {
            return baseValue / 1550.0031000062002d;
        }
    }
}
