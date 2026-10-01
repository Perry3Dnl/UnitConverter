namespace RealisticPhysics.UnitConversion.MagneticField.Common
{
    public static class UnitConverterCommonMagneticField
    {
        public static double GaussToTesla(double value)
        {
            return value * 0.0001d;
        }

        public static double TeslaToGauss(double baseValue)
        {
            return baseValue / 0.0001d;
        }
    }
}
