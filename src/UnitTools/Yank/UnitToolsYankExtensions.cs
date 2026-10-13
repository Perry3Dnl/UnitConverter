namespace UnitTools.Yank
{
    /// <summary>
    /// Extension-method API for Yank conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsYankExtensions
    {
        public static double Convert(this double value, UnitToolsYankUnit from, UnitToolsYankUnit to)
        {
            return UnitToolsYank.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsYankUnit from, UnitToolsYankUnit to)
        {
            return (float)UnitToolsYank.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsYankUnit from, UnitToolsYankUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsYankUnit from, UnitToolsYankUnit to)
        {
            return UnitToolsYank.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsYankUnit from, UnitToolsYankUnit to)
        {
            return UnitToolsYank.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsYankUnit from, UnitToolsYankUnit to)
        {
            return UnitToolsYank.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsYankUnit from, UnitToolsYankUnit to)
        {
            return UnitToolsYank.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsYankUnit from, UnitToolsYankUnit to)
        {
            return UnitToolsYank.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsYankUnit from, UnitToolsYankUnit to)
        {
            return UnitToolsYank.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsYankUnit from, UnitToolsYankUnit to)
        {
            return UnitToolsYank.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsYankUnit from, UnitToolsYankUnit to)
        {
            return UnitToolsYank.Convert(value, from, to);
        }
    }
}
