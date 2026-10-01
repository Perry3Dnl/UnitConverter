namespace UnitConverter.LinearDensity
{
    /// <summary>
    /// Extension-method API for Linear Density conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterLinearDensityExtensions
    {
        public static double Convert(this double value, UnitConverterLinearDensityUnit from, UnitConverterLinearDensityUnit to)
        {
            return UnitConverterLinearDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterLinearDensityUnit from, UnitConverterLinearDensityUnit to)
        {
            return (float)UnitConverterLinearDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterLinearDensityUnit from, UnitConverterLinearDensityUnit to)
        {
            return (decimal)UnitConverterLinearDensity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterLinearDensityUnit from, UnitConverterLinearDensityUnit to)
        {
            return UnitConverterLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterLinearDensityUnit from, UnitConverterLinearDensityUnit to)
        {
            return UnitConverterLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterLinearDensityUnit from, UnitConverterLinearDensityUnit to)
        {
            return UnitConverterLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterLinearDensityUnit from, UnitConverterLinearDensityUnit to)
        {
            return UnitConverterLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterLinearDensityUnit from, UnitConverterLinearDensityUnit to)
        {
            return UnitConverterLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterLinearDensityUnit from, UnitConverterLinearDensityUnit to)
        {
            return UnitConverterLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterLinearDensityUnit from, UnitConverterLinearDensityUnit to)
        {
            return UnitConverterLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterLinearDensityUnit from, UnitConverterLinearDensityUnit to)
        {
            return UnitConverterLinearDensity.Convert(value, from, to);
        }
    }
}
