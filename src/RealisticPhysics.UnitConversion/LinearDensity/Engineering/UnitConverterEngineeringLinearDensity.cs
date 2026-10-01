namespace RealisticPhysics.UnitConversion.LinearDensity.Engineering
{
    public static class UnitConverterEngineeringLinearDensity
    {
        public static double TexToKilogramPerMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double KilogramPerMeterToTex(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double DenierToKilogramPerMeter(double value)
        {
            return value * 1.1111111111111111e-07d;
        }

        public static double KilogramPerMeterToDenier(double baseValue)
        {
            return baseValue / 1.1111111111111111e-07d;
        }
    }
}
