namespace RealisticPhysics.UnitConversion.Length
{
    /// <summary>
    /// Extension-method API for Length conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterLengthExtensions
    {
        public static double Convert(this double value, UnitConverterLengthUnit from, UnitConverterLengthUnit to)
        {
            return UnitConverterLength.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterLengthUnit from, UnitConverterLengthUnit to)
        {
            return (float)UnitConverterLength.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterLengthUnit from, UnitConverterLengthUnit to)
        {
            return (decimal)UnitConverterLength.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterLengthUnit from, UnitConverterLengthUnit to) { return UnitConverterLength.Convert(value, from, to); }
        public static double Convert(this sbyte value, UnitConverterLengthUnit from, UnitConverterLengthUnit to) { return UnitConverterLength.Convert(value, from, to); }
        public static double Convert(this short value, UnitConverterLengthUnit from, UnitConverterLengthUnit to) { return UnitConverterLength.Convert(value, from, to); }
        public static double Convert(this ushort value, UnitConverterLengthUnit from, UnitConverterLengthUnit to) { return UnitConverterLength.Convert(value, from, to); }
        public static double Convert(this int value, UnitConverterLengthUnit from, UnitConverterLengthUnit to) { return UnitConverterLength.Convert(value, from, to); }
        public static double Convert(this uint value, UnitConverterLengthUnit from, UnitConverterLengthUnit to) { return UnitConverterLength.Convert(value, from, to); }
        public static double Convert(this long value, UnitConverterLengthUnit from, UnitConverterLengthUnit to) { return UnitConverterLength.Convert(value, from, to); }
        public static double Convert(this ulong value, UnitConverterLengthUnit from, UnitConverterLengthUnit to) { return UnitConverterLength.Convert(value, from, to); }
    }
}
