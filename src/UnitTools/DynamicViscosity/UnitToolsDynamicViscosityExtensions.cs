namespace UnitTools.DynamicViscosity
{
    /// <summary>
    /// Extension-method API for Dynamic Viscosity conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsDynamicViscosityExtensions
    {
        public static double Convert(this double value, UnitToolsDynamicViscosityUnit from, UnitToolsDynamicViscosityUnit to)
        {
            return UnitToolsDynamicViscosity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsDynamicViscosityUnit from, UnitToolsDynamicViscosityUnit to)
        {
            return (float)UnitToolsDynamicViscosity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsDynamicViscosityUnit from, UnitToolsDynamicViscosityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsDynamicViscosityUnit from, UnitToolsDynamicViscosityUnit to)
        {
            return UnitToolsDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsDynamicViscosityUnit from, UnitToolsDynamicViscosityUnit to)
        {
            return UnitToolsDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsDynamicViscosityUnit from, UnitToolsDynamicViscosityUnit to)
        {
            return UnitToolsDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsDynamicViscosityUnit from, UnitToolsDynamicViscosityUnit to)
        {
            return UnitToolsDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsDynamicViscosityUnit from, UnitToolsDynamicViscosityUnit to)
        {
            return UnitToolsDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsDynamicViscosityUnit from, UnitToolsDynamicViscosityUnit to)
        {
            return UnitToolsDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsDynamicViscosityUnit from, UnitToolsDynamicViscosityUnit to)
        {
            return UnitToolsDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsDynamicViscosityUnit from, UnitToolsDynamicViscosityUnit to)
        {
            return UnitToolsDynamicViscosity.Convert(value, from, to);
        }
    }
}
