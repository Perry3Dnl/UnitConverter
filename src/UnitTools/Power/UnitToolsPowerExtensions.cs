namespace UnitTools.Power
{
    /// <summary>
    /// Extension-method API for Power conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsPowerExtensions
    {
        public static double Convert(this double value, UnitToolsPowerUnit from, UnitToolsPowerUnit to)
        {
            return UnitToolsPower.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsPowerUnit from, UnitToolsPowerUnit to)
        {
            return (float)UnitToolsPower.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsPowerUnit from, UnitToolsPowerUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsPowerUnit from, UnitToolsPowerUnit to)
        {
            return UnitToolsPower.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsPowerUnit from, UnitToolsPowerUnit to)
        {
            return UnitToolsPower.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsPowerUnit from, UnitToolsPowerUnit to)
        {
            return UnitToolsPower.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsPowerUnit from, UnitToolsPowerUnit to)
        {
            return UnitToolsPower.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsPowerUnit from, UnitToolsPowerUnit to)
        {
            return UnitToolsPower.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsPowerUnit from, UnitToolsPowerUnit to)
        {
            return UnitToolsPower.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsPowerUnit from, UnitToolsPowerUnit to)
        {
            return UnitToolsPower.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsPowerUnit from, UnitToolsPowerUnit to)
        {
            return UnitToolsPower.Convert(value, from, to);
        }
    }
}
