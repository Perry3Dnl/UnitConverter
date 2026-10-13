namespace UnitTools.Compressibility
{
    /// <summary>
    /// Extension-method API for Compressibility conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsCompressibilityExtensions
    {
        public static double Convert(this double value, UnitToolsCompressibilityUnit from, UnitToolsCompressibilityUnit to)
        {
            return UnitToolsCompressibility.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsCompressibilityUnit from, UnitToolsCompressibilityUnit to)
        {
            return (float)UnitToolsCompressibility.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsCompressibilityUnit from, UnitToolsCompressibilityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsCompressibilityUnit from, UnitToolsCompressibilityUnit to)
        {
            return UnitToolsCompressibility.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsCompressibilityUnit from, UnitToolsCompressibilityUnit to)
        {
            return UnitToolsCompressibility.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsCompressibilityUnit from, UnitToolsCompressibilityUnit to)
        {
            return UnitToolsCompressibility.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsCompressibilityUnit from, UnitToolsCompressibilityUnit to)
        {
            return UnitToolsCompressibility.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsCompressibilityUnit from, UnitToolsCompressibilityUnit to)
        {
            return UnitToolsCompressibility.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsCompressibilityUnit from, UnitToolsCompressibilityUnit to)
        {
            return UnitToolsCompressibility.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsCompressibilityUnit from, UnitToolsCompressibilityUnit to)
        {
            return UnitToolsCompressibility.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsCompressibilityUnit from, UnitToolsCompressibilityUnit to)
        {
            return UnitToolsCompressibility.Convert(value, from, to);
        }
    }
}
