namespace UnitTools.Snap
{
    /// <summary>
    /// Extension-method API for Snap conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsSnapExtensions
    {
        public static double Convert(this double value, UnitToolsSnapUnit from, UnitToolsSnapUnit to)
        {
            return UnitToolsSnap.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsSnapUnit from, UnitToolsSnapUnit to)
        {
            return (float)UnitToolsSnap.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsSnapUnit from, UnitToolsSnapUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsSnapUnit from, UnitToolsSnapUnit to)
        {
            return UnitToolsSnap.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsSnapUnit from, UnitToolsSnapUnit to)
        {
            return UnitToolsSnap.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsSnapUnit from, UnitToolsSnapUnit to)
        {
            return UnitToolsSnap.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsSnapUnit from, UnitToolsSnapUnit to)
        {
            return UnitToolsSnap.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsSnapUnit from, UnitToolsSnapUnit to)
        {
            return UnitToolsSnap.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsSnapUnit from, UnitToolsSnapUnit to)
        {
            return UnitToolsSnap.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsSnapUnit from, UnitToolsSnapUnit to)
        {
            return UnitToolsSnap.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsSnapUnit from, UnitToolsSnapUnit to)
        {
            return UnitToolsSnap.Convert(value, from, to);
        }
    }
}
