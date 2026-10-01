namespace UnitConverter.Luminance.Imperial
{
    public static class UnitConverterImperialLuminance
    {
        public static double FootLambertToCandelaPerSquareMeter(double value)
        {
            return value * 3.4262590999999998d;
        }

        public static double CandelaPerSquareMeterToFootLambert(double baseValue)
        {
            return baseValue / 3.4262590999999998d;
        }

        public static double CandelaPerSquareFootToCandelaPerSquareMeter(double value)
        {
            return value * 10.763910416709722d;
        }

        public static double CandelaPerSquareMeterToCandelaPerSquareFoot(double baseValue)
        {
            return baseValue / 10.763910416709722d;
        }

        public static double CandelaPerSquareInchToCandelaPerSquareMeter(double value)
        {
            return value * 1550.0031000062002d;
        }

        public static double CandelaPerSquareMeterToCandelaPerSquareInch(double baseValue)
        {
            return baseValue / 1550.0031000062002d;
        }
    }
}
