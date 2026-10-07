namespace UnitConverter.Current
{
    /// <summary>
    /// Extension-method API for Current conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterCurrentExtensions
    {
        public static double Convert(this double value, UnitConverterCurrentUnit from, UnitConverterCurrentUnit to)
        {
            return UnitConverterCurrent.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterCurrentUnit from, UnitConverterCurrentUnit to)
        {
            return (float)UnitConverterCurrent.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterCurrentUnit from, UnitConverterCurrentUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterCurrentUnit from, UnitConverterCurrentUnit to)
        {
            return UnitConverterCurrent.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterCurrentUnit from, UnitConverterCurrentUnit to)
        {
            return UnitConverterCurrent.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterCurrentUnit from, UnitConverterCurrentUnit to)
        {
            return UnitConverterCurrent.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterCurrentUnit from, UnitConverterCurrentUnit to)
        {
            return UnitConverterCurrent.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterCurrentUnit from, UnitConverterCurrentUnit to)
        {
            return UnitConverterCurrent.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterCurrentUnit from, UnitConverterCurrentUnit to)
        {
            return UnitConverterCurrent.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterCurrentUnit from, UnitConverterCurrentUnit to)
        {
            return UnitConverterCurrent.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterCurrentUnit from, UnitConverterCurrentUnit to)
        {
            return UnitConverterCurrent.Convert(value, from, to);
        }
    }
}
