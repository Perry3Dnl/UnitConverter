namespace UnitTools.Length
{
    /// <summary>
    /// Extension-method API for Length conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsLengthExtensions
    {
        public static double Convert(this double value, UnitToolsLengthUnit from, UnitToolsLengthUnit to)
        {
            return UnitToolsLength.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsLengthUnit from, UnitToolsLengthUnit to)
        {
            return (float)UnitToolsLength.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsLengthUnit from, UnitToolsLengthUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsLengthUnit from, UnitToolsLengthUnit to) { return UnitToolsLength.Convert(value, from, to); }
        public static double Convert(this sbyte value, UnitToolsLengthUnit from, UnitToolsLengthUnit to) { return UnitToolsLength.Convert(value, from, to); }
        public static double Convert(this short value, UnitToolsLengthUnit from, UnitToolsLengthUnit to) { return UnitToolsLength.Convert(value, from, to); }
        public static double Convert(this ushort value, UnitToolsLengthUnit from, UnitToolsLengthUnit to) { return UnitToolsLength.Convert(value, from, to); }
        public static double Convert(this int value, UnitToolsLengthUnit from, UnitToolsLengthUnit to) { return UnitToolsLength.Convert(value, from, to); }
        public static double Convert(this uint value, UnitToolsLengthUnit from, UnitToolsLengthUnit to) { return UnitToolsLength.Convert(value, from, to); }
        public static double Convert(this long value, UnitToolsLengthUnit from, UnitToolsLengthUnit to) { return UnitToolsLength.Convert(value, from, to); }
        public static double Convert(this ulong value, UnitToolsLengthUnit from, UnitToolsLengthUnit to) { return UnitToolsLength.Convert(value, from, to); }
    }
}
