namespace RealisticPhysics.UnitConversion.ChargeDensity
{
    /// <summary>
    /// Extension-method API for Charge Density conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterChargeDensityExtensions
    {
        public static double Convert(this double value, UnitConverterChargeDensityUnit from, UnitConverterChargeDensityUnit to)
        {
            return UnitConverterChargeDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterChargeDensityUnit from, UnitConverterChargeDensityUnit to)
        {
            return (float)UnitConverterChargeDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterChargeDensityUnit from, UnitConverterChargeDensityUnit to)
        {
            return (decimal)UnitConverterChargeDensity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterChargeDensityUnit from, UnitConverterChargeDensityUnit to)
        {
            return UnitConverterChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterChargeDensityUnit from, UnitConverterChargeDensityUnit to)
        {
            return UnitConverterChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterChargeDensityUnit from, UnitConverterChargeDensityUnit to)
        {
            return UnitConverterChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterChargeDensityUnit from, UnitConverterChargeDensityUnit to)
        {
            return UnitConverterChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterChargeDensityUnit from, UnitConverterChargeDensityUnit to)
        {
            return UnitConverterChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterChargeDensityUnit from, UnitConverterChargeDensityUnit to)
        {
            return UnitConverterChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterChargeDensityUnit from, UnitConverterChargeDensityUnit to)
        {
            return UnitConverterChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterChargeDensityUnit from, UnitConverterChargeDensityUnit to)
        {
            return UnitConverterChargeDensity.Convert(value, from, to);
        }
    }
}
