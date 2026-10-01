namespace RealisticPhysics.UnitConversion.PowerDensity
{
    /// <summary>
    /// Extension-method API for Power Density conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterPowerDensityExtensions
    {
        public static double Convert(this double value, UnitConverterPowerDensityUnit from, UnitConverterPowerDensityUnit to)
        {
            return UnitConverterPowerDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterPowerDensityUnit from, UnitConverterPowerDensityUnit to)
        {
            return (float)UnitConverterPowerDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterPowerDensityUnit from, UnitConverterPowerDensityUnit to)
        {
            return (decimal)UnitConverterPowerDensity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterPowerDensityUnit from, UnitConverterPowerDensityUnit to)
        {
            return UnitConverterPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterPowerDensityUnit from, UnitConverterPowerDensityUnit to)
        {
            return UnitConverterPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterPowerDensityUnit from, UnitConverterPowerDensityUnit to)
        {
            return UnitConverterPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterPowerDensityUnit from, UnitConverterPowerDensityUnit to)
        {
            return UnitConverterPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterPowerDensityUnit from, UnitConverterPowerDensityUnit to)
        {
            return UnitConverterPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterPowerDensityUnit from, UnitConverterPowerDensityUnit to)
        {
            return UnitConverterPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterPowerDensityUnit from, UnitConverterPowerDensityUnit to)
        {
            return UnitConverterPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterPowerDensityUnit from, UnitConverterPowerDensityUnit to)
        {
            return UnitConverterPowerDensity.Convert(value, from, to);
        }
    }
}
