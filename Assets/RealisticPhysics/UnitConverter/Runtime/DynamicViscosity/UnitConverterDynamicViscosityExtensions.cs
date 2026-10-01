namespace RealisticPhysics.UnitConversion.DynamicViscosity
{
    /// <summary>
    /// Extension-method API for Dynamic Viscosity conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterDynamicViscosityExtensions
    {
        public static double Convert(this double value, UnitConverterDynamicViscosityUnit from, UnitConverterDynamicViscosityUnit to)
        {
            return UnitConverterDynamicViscosity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterDynamicViscosityUnit from, UnitConverterDynamicViscosityUnit to)
        {
            return (float)UnitConverterDynamicViscosity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterDynamicViscosityUnit from, UnitConverterDynamicViscosityUnit to)
        {
            return (decimal)UnitConverterDynamicViscosity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterDynamicViscosityUnit from, UnitConverterDynamicViscosityUnit to)
        {
            return UnitConverterDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterDynamicViscosityUnit from, UnitConverterDynamicViscosityUnit to)
        {
            return UnitConverterDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterDynamicViscosityUnit from, UnitConverterDynamicViscosityUnit to)
        {
            return UnitConverterDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterDynamicViscosityUnit from, UnitConverterDynamicViscosityUnit to)
        {
            return UnitConverterDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterDynamicViscosityUnit from, UnitConverterDynamicViscosityUnit to)
        {
            return UnitConverterDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterDynamicViscosityUnit from, UnitConverterDynamicViscosityUnit to)
        {
            return UnitConverterDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterDynamicViscosityUnit from, UnitConverterDynamicViscosityUnit to)
        {
            return UnitConverterDynamicViscosity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterDynamicViscosityUnit from, UnitConverterDynamicViscosityUnit to)
        {
            return UnitConverterDynamicViscosity.Convert(value, from, to);
        }
    }
}
