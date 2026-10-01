namespace UnitConverter.CurrentDensity
{
    /// <summary>
    /// Extension-method API for Current Density conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterCurrentDensityExtensions
    {
        public static double Convert(this double value, UnitConverterCurrentDensityUnit from, UnitConverterCurrentDensityUnit to)
        {
            return UnitConverterCurrentDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterCurrentDensityUnit from, UnitConverterCurrentDensityUnit to)
        {
            return (float)UnitConverterCurrentDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterCurrentDensityUnit from, UnitConverterCurrentDensityUnit to)
        {
            return (decimal)UnitConverterCurrentDensity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterCurrentDensityUnit from, UnitConverterCurrentDensityUnit to)
        {
            return UnitConverterCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterCurrentDensityUnit from, UnitConverterCurrentDensityUnit to)
        {
            return UnitConverterCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterCurrentDensityUnit from, UnitConverterCurrentDensityUnit to)
        {
            return UnitConverterCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterCurrentDensityUnit from, UnitConverterCurrentDensityUnit to)
        {
            return UnitConverterCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterCurrentDensityUnit from, UnitConverterCurrentDensityUnit to)
        {
            return UnitConverterCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterCurrentDensityUnit from, UnitConverterCurrentDensityUnit to)
        {
            return UnitConverterCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterCurrentDensityUnit from, UnitConverterCurrentDensityUnit to)
        {
            return UnitConverterCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterCurrentDensityUnit from, UnitConverterCurrentDensityUnit to)
        {
            return UnitConverterCurrentDensity.Convert(value, from, to);
        }
    }
}
