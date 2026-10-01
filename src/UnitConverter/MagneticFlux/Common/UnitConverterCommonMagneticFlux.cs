namespace UnitConverter.MagneticFlux.Common
{
    public static class UnitConverterCommonMagneticFlux
    {
        public static double MaxwellToWeber(double value)
        {
            return value * 1e-08d;
        }

        public static double WeberToMaxwell(double baseValue)
        {
            return baseValue / 1e-08d;
        }
    }
}
