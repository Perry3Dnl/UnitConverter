namespace RealisticPhysics.UnitConversion.MomentOfInertia
{
    /// <summary>
    /// Extension-method API for Moment Of Inertia conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterMomentOfInertiaExtensions
    {
        public static double Convert(this double value, UnitConverterMomentOfInertiaUnit from, UnitConverterMomentOfInertiaUnit to)
        {
            return UnitConverterMomentOfInertia.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterMomentOfInertiaUnit from, UnitConverterMomentOfInertiaUnit to)
        {
            return (float)UnitConverterMomentOfInertia.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterMomentOfInertiaUnit from, UnitConverterMomentOfInertiaUnit to)
        {
            return (decimal)UnitConverterMomentOfInertia.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterMomentOfInertiaUnit from, UnitConverterMomentOfInertiaUnit to)
        {
            return UnitConverterMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterMomentOfInertiaUnit from, UnitConverterMomentOfInertiaUnit to)
        {
            return UnitConverterMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterMomentOfInertiaUnit from, UnitConverterMomentOfInertiaUnit to)
        {
            return UnitConverterMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterMomentOfInertiaUnit from, UnitConverterMomentOfInertiaUnit to)
        {
            return UnitConverterMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterMomentOfInertiaUnit from, UnitConverterMomentOfInertiaUnit to)
        {
            return UnitConverterMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterMomentOfInertiaUnit from, UnitConverterMomentOfInertiaUnit to)
        {
            return UnitConverterMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterMomentOfInertiaUnit from, UnitConverterMomentOfInertiaUnit to)
        {
            return UnitConverterMomentOfInertia.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterMomentOfInertiaUnit from, UnitConverterMomentOfInertiaUnit to)
        {
            return UnitConverterMomentOfInertia.Convert(value, from, to);
        }
    }
}
