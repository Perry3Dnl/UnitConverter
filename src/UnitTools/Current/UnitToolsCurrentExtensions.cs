namespace UnitTools.Current
{
    /// <summary>
    /// Extension-method API for Current conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsCurrentExtensions
    {
        public static double Convert(this double value, UnitToolsCurrentUnit from, UnitToolsCurrentUnit to)
        {
            return UnitToolsCurrent.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsCurrentUnit from, UnitToolsCurrentUnit to)
        {
            return (float)UnitToolsCurrent.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsCurrentUnit from, UnitToolsCurrentUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsCurrentUnit from, UnitToolsCurrentUnit to)
        {
            return UnitToolsCurrent.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsCurrentUnit from, UnitToolsCurrentUnit to)
        {
            return UnitToolsCurrent.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsCurrentUnit from, UnitToolsCurrentUnit to)
        {
            return UnitToolsCurrent.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsCurrentUnit from, UnitToolsCurrentUnit to)
        {
            return UnitToolsCurrent.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsCurrentUnit from, UnitToolsCurrentUnit to)
        {
            return UnitToolsCurrent.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsCurrentUnit from, UnitToolsCurrentUnit to)
        {
            return UnitToolsCurrent.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsCurrentUnit from, UnitToolsCurrentUnit to)
        {
            return UnitToolsCurrent.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsCurrentUnit from, UnitToolsCurrentUnit to)
        {
            return UnitToolsCurrent.Convert(value, from, to);
        }
    }
}
