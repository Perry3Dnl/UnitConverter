namespace UnitTools.MomentOfInertia
{
    /// <summary>
    /// Extension-method API for Moment Of Inertia conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsMomentOfInertiaExtensions
    {
        public static double Convert(this double value, UnitToolsMomentOfInertiaUnit from, UnitToolsMomentOfInertiaUnit to)
        {
            return UnitToolsMomentOfInertia.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsMomentOfInertiaUnit from, UnitToolsMomentOfInertiaUnit to)
        {
            return (float)UnitToolsMomentOfInertia.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsMomentOfInertiaUnit from, UnitToolsMomentOfInertiaUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsMomentOfInertiaUnit from, UnitToolsMomentOfInertiaUnit to)
        {
            return UnitToolsMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsMomentOfInertiaUnit from, UnitToolsMomentOfInertiaUnit to)
        {
            return UnitToolsMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsMomentOfInertiaUnit from, UnitToolsMomentOfInertiaUnit to)
        {
            return UnitToolsMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsMomentOfInertiaUnit from, UnitToolsMomentOfInertiaUnit to)
        {
            return UnitToolsMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsMomentOfInertiaUnit from, UnitToolsMomentOfInertiaUnit to)
        {
            return UnitToolsMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsMomentOfInertiaUnit from, UnitToolsMomentOfInertiaUnit to)
        {
            return UnitToolsMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsMomentOfInertiaUnit from, UnitToolsMomentOfInertiaUnit to)
        {
            return UnitToolsMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsMomentOfInertiaUnit from, UnitToolsMomentOfInertiaUnit to)
        {
            return UnitToolsMomentOfInertia.Convert(value, from, to);
        }
    }
}
