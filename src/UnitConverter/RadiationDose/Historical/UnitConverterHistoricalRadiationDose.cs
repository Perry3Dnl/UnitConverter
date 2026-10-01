namespace UnitConverter.RadiationDose.Historical
{
    public static class UnitConverterHistoricalRadiationDose
    {
        public static double RoentgenApproxToGray(double value)
        {
            return value * 0.00877d;
        }

        public static double GrayToRoentgenApprox(double baseValue)
        {
            return baseValue / 0.00877d;
        }

        public static double MilliroentgenApproxToGray(double value)
        {
            return value * 8.7700000000000007e-06d;
        }

        public static double GrayToMilliroentgenApprox(double baseValue)
        {
            return baseValue / 8.7700000000000007e-06d;
        }

        public static double KiloremToGray(double value)
        {
            return value * 10.0d;
        }

        public static double GrayToKilorem(double baseValue)
        {
            return baseValue / 10.0d;
        }
    }
}
