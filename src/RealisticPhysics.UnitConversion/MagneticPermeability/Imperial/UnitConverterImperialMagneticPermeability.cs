namespace RealisticPhysics.UnitConversion.MagneticPermeability.Imperial
{
    public static class UnitConverterImperialMagneticPermeability
    {
        public static double HenryPerInchToHenryPerMeter(double value)
        {
            return value * 39.370078740157481d;
        }

        public static double HenryPerMeterToHenryPerInch(double baseValue)
        {
            return baseValue / 39.370078740157481d;
        }
    }
}
