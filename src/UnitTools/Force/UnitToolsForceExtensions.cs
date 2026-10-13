namespace UnitTools.Force
{
    /// <summary>
    /// Extension-method API for Force conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsForceExtensions
    {
        public static double Convert(this double value, UnitToolsForceUnit from, UnitToolsForceUnit to)
        {
            return UnitToolsForce.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsForceUnit from, UnitToolsForceUnit to)
        {
            return (float)UnitToolsForce.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsForceUnit from, UnitToolsForceUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsForceUnit from, UnitToolsForceUnit to)
        {
            return UnitToolsForce.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsForceUnit from, UnitToolsForceUnit to)
        {
            return UnitToolsForce.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsForceUnit from, UnitToolsForceUnit to)
        {
            return UnitToolsForce.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsForceUnit from, UnitToolsForceUnit to)
        {
            return UnitToolsForce.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsForceUnit from, UnitToolsForceUnit to)
        {
            return UnitToolsForce.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsForceUnit from, UnitToolsForceUnit to)
        {
            return UnitToolsForce.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsForceUnit from, UnitToolsForceUnit to)
        {
            return UnitToolsForce.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsForceUnit from, UnitToolsForceUnit to)
        {
            return UnitToolsForce.Convert(value, from, to);
        }
    }
}
