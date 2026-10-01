namespace UnitConverter.Snap
{
    /// <summary>
    /// Extension-method API for Snap conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterSnapExtensions
    {
        public static double Convert(this double value, UnitConverterSnapUnit from, UnitConverterSnapUnit to)
        {
            return UnitConverterSnap.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterSnapUnit from, UnitConverterSnapUnit to)
        {
            return (float)UnitConverterSnap.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterSnapUnit from, UnitConverterSnapUnit to)
        {
            return (decimal)UnitConverterSnap.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterSnapUnit from, UnitConverterSnapUnit to)
        {
            return UnitConverterSnap.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterSnapUnit from, UnitConverterSnapUnit to)
        {
            return UnitConverterSnap.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterSnapUnit from, UnitConverterSnapUnit to)
        {
            return UnitConverterSnap.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterSnapUnit from, UnitConverterSnapUnit to)
        {
            return UnitConverterSnap.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterSnapUnit from, UnitConverterSnapUnit to)
        {
            return UnitConverterSnap.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterSnapUnit from, UnitConverterSnapUnit to)
        {
            return UnitConverterSnap.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterSnapUnit from, UnitConverterSnapUnit to)
        {
            return UnitConverterSnap.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterSnapUnit from, UnitConverterSnapUnit to)
        {
            return UnitConverterSnap.Convert(value, from, to);
        }
    }
}
