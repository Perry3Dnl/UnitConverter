namespace UnitTools.Area
{
    /// <summary>
    /// Extension-method API for Area conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsAreaExtensions
    {
        public static double Convert(this double value, UnitToolsAreaUnit from, UnitToolsAreaUnit to)
        {
            return UnitToolsArea.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsAreaUnit from, UnitToolsAreaUnit to)
        {
            return (float)UnitToolsArea.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsAreaUnit from, UnitToolsAreaUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsAreaUnit from, UnitToolsAreaUnit to)
        {
            return UnitToolsArea.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsAreaUnit from, UnitToolsAreaUnit to)
        {
            return UnitToolsArea.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsAreaUnit from, UnitToolsAreaUnit to)
        {
            return UnitToolsArea.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsAreaUnit from, UnitToolsAreaUnit to)
        {
            return UnitToolsArea.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsAreaUnit from, UnitToolsAreaUnit to)
        {
            return UnitToolsArea.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsAreaUnit from, UnitToolsAreaUnit to)
        {
            return UnitToolsArea.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsAreaUnit from, UnitToolsAreaUnit to)
        {
            return UnitToolsArea.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsAreaUnit from, UnitToolsAreaUnit to)
        {
            return UnitToolsArea.Convert(value, from, to);
        }
    }
}
