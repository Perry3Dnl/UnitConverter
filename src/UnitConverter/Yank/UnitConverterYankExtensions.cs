namespace UnitConverter.Yank
{
    /// <summary>
    /// Extension-method API for Yank conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterYankExtensions
    {
        public static double Convert(this double value, UnitConverterYankUnit from, UnitConverterYankUnit to)
        {
            return UnitConverterYank.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterYankUnit from, UnitConverterYankUnit to)
        {
            return (float)UnitConverterYank.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterYankUnit from, UnitConverterYankUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterYankUnit from, UnitConverterYankUnit to)
        {
            return UnitConverterYank.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterYankUnit from, UnitConverterYankUnit to)
        {
            return UnitConverterYank.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterYankUnit from, UnitConverterYankUnit to)
        {
            return UnitConverterYank.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterYankUnit from, UnitConverterYankUnit to)
        {
            return UnitConverterYank.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterYankUnit from, UnitConverterYankUnit to)
        {
            return UnitConverterYank.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterYankUnit from, UnitConverterYankUnit to)
        {
            return UnitConverterYank.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterYankUnit from, UnitConverterYankUnit to)
        {
            return UnitConverterYank.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterYankUnit from, UnitConverterYankUnit to)
        {
            return UnitConverterYank.Convert(value, from, to);
        }
    }
}
