namespace UnitConverter.Compressibility
{
    /// <summary>
    /// Extension-method API for Compressibility conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterCompressibilityExtensions
    {
        public static double Convert(this double value, UnitConverterCompressibilityUnit from, UnitConverterCompressibilityUnit to)
        {
            return UnitConverterCompressibility.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterCompressibilityUnit from, UnitConverterCompressibilityUnit to)
        {
            return (float)UnitConverterCompressibility.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterCompressibilityUnit from, UnitConverterCompressibilityUnit to)
        {
            return (decimal)UnitConverterCompressibility.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterCompressibilityUnit from, UnitConverterCompressibilityUnit to)
        {
            return UnitConverterCompressibility.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterCompressibilityUnit from, UnitConverterCompressibilityUnit to)
        {
            return UnitConverterCompressibility.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterCompressibilityUnit from, UnitConverterCompressibilityUnit to)
        {
            return UnitConverterCompressibility.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterCompressibilityUnit from, UnitConverterCompressibilityUnit to)
        {
            return UnitConverterCompressibility.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterCompressibilityUnit from, UnitConverterCompressibilityUnit to)
        {
            return UnitConverterCompressibility.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterCompressibilityUnit from, UnitConverterCompressibilityUnit to)
        {
            return UnitConverterCompressibility.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterCompressibilityUnit from, UnitConverterCompressibilityUnit to)
        {
            return UnitConverterCompressibility.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterCompressibilityUnit from, UnitConverterCompressibilityUnit to)
        {
            return UnitConverterCompressibility.Convert(value, from, to);
        }
    }
}
