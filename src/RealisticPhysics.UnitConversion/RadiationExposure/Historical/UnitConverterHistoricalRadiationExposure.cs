namespace RealisticPhysics.UnitConversion.RadiationExposure.Historical
{
    public static class UnitConverterHistoricalRadiationExposure
    {
        public static double RoentgenToCoulombPerKilogram(double value)
        {
            return value * 0.00025799999999999998d;
        }

        public static double CoulombPerKilogramToRoentgen(double baseValue)
        {
            return baseValue / 0.00025799999999999998d;
        }

        public static double MilliroentgenToCoulombPerKilogram(double value)
        {
            return value * 2.5800000000000001e-07d;
        }

        public static double CoulombPerKilogramToMilliroentgen(double baseValue)
        {
            return baseValue / 2.5800000000000001e-07d;
        }

        public static double KiloroentgenToCoulombPerKilogram(double value)
        {
            return value * 0.25800000000000001d;
        }

        public static double CoulombPerKilogramToKiloroentgen(double baseValue)
        {
            return baseValue / 0.25800000000000001d;
        }

        public static double MicroroentgenToCoulombPerKilogram(double value)
        {
            return value * 2.5799999999999999e-10d;
        }

        public static double CoulombPerKilogramToMicroroentgen(double baseValue)
        {
            return baseValue / 2.5799999999999999e-10d;
        }

        public static double NanoroentgenToCoulombPerKilogram(double value)
        {
            return value * 2.5800000000000001e-13d;
        }

        public static double CoulombPerKilogramToNanoroentgen(double baseValue)
        {
            return baseValue / 2.5800000000000001e-13d;
        }

        public static double PicoroentgenToCoulombPerKilogram(double value)
        {
            return value * 2.58e-16d;
        }

        public static double CoulombPerKilogramToPicoroentgen(double baseValue)
        {
            return baseValue / 2.58e-16d;
        }
    }
}
