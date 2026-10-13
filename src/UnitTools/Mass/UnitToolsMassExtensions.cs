namespace UnitTools.Mass
{
    /// <summary>
    /// Extension-method API for Mass conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsMassExtensions
    {
        public static double Convert(this double value, UnitToolsMassUnit from, UnitToolsMassUnit to)
        {
            return UnitToolsMass.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsMassUnit from, UnitToolsMassUnit to)
        {
            return (float)UnitToolsMass.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsMassUnit from, UnitToolsMassUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsMassUnit from, UnitToolsMassUnit to)
        {
            return UnitToolsMass.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsMassUnit from, UnitToolsMassUnit to)
        {
            return UnitToolsMass.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsMassUnit from, UnitToolsMassUnit to)
        {
            return UnitToolsMass.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsMassUnit from, UnitToolsMassUnit to)
        {
            return UnitToolsMass.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsMassUnit from, UnitToolsMassUnit to)
        {
            return UnitToolsMass.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsMassUnit from, UnitToolsMassUnit to)
        {
            return UnitToolsMass.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsMassUnit from, UnitToolsMassUnit to)
        {
            return UnitToolsMass.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsMassUnit from, UnitToolsMassUnit to)
        {
            return UnitToolsMass.Convert(value, from, to);
        }
    }
}
