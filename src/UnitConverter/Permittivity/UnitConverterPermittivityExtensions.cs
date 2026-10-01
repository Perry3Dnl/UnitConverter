namespace UnitConverter.Permittivity
{
    /// <summary>
    /// Extension-method API for Permittivity conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterPermittivityExtensions
    {
        public static double Convert(this double value, UnitConverterPermittivityUnit from, UnitConverterPermittivityUnit to)
        {
            return UnitConverterPermittivity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterPermittivityUnit from, UnitConverterPermittivityUnit to)
        {
            return (float)UnitConverterPermittivity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterPermittivityUnit from, UnitConverterPermittivityUnit to)
        {
            return (decimal)UnitConverterPermittivity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterPermittivityUnit from, UnitConverterPermittivityUnit to)
        {
            return UnitConverterPermittivity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterPermittivityUnit from, UnitConverterPermittivityUnit to)
        {
            return UnitConverterPermittivity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterPermittivityUnit from, UnitConverterPermittivityUnit to)
        {
            return UnitConverterPermittivity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterPermittivityUnit from, UnitConverterPermittivityUnit to)
        {
            return UnitConverterPermittivity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterPermittivityUnit from, UnitConverterPermittivityUnit to)
        {
            return UnitConverterPermittivity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterPermittivityUnit from, UnitConverterPermittivityUnit to)
        {
            return UnitConverterPermittivity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterPermittivityUnit from, UnitConverterPermittivityUnit to)
        {
            return UnitConverterPermittivity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterPermittivityUnit from, UnitConverterPermittivityUnit to)
        {
            return UnitConverterPermittivity.Convert(value, from, to);
        }
    }
}
