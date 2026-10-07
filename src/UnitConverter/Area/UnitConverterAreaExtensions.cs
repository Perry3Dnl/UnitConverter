namespace UnitConverter.Area
{
    /// <summary>
    /// Extension-method API for Area conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterAreaExtensions
    {
        public static double Convert(this double value, UnitConverterAreaUnit from, UnitConverterAreaUnit to)
        {
            return UnitConverterArea.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterAreaUnit from, UnitConverterAreaUnit to)
        {
            return (float)UnitConverterArea.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterAreaUnit from, UnitConverterAreaUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterAreaUnit from, UnitConverterAreaUnit to)
        {
            return UnitConverterArea.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterAreaUnit from, UnitConverterAreaUnit to)
        {
            return UnitConverterArea.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterAreaUnit from, UnitConverterAreaUnit to)
        {
            return UnitConverterArea.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterAreaUnit from, UnitConverterAreaUnit to)
        {
            return UnitConverterArea.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterAreaUnit from, UnitConverterAreaUnit to)
        {
            return UnitConverterArea.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterAreaUnit from, UnitConverterAreaUnit to)
        {
            return UnitConverterArea.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterAreaUnit from, UnitConverterAreaUnit to)
        {
            return UnitConverterArea.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterAreaUnit from, UnitConverterAreaUnit to)
        {
            return UnitConverterArea.Convert(value, from, to);
        }
    }
}
