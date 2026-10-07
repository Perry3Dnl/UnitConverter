namespace UnitConverter.SurfaceTension
{
    /// <summary>
    /// Extension-method API for Surface Tension conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterSurfaceTensionExtensions
    {
        public static double Convert(this double value, UnitConverterSurfaceTensionUnit from, UnitConverterSurfaceTensionUnit to)
        {
            return UnitConverterSurfaceTension.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterSurfaceTensionUnit from, UnitConverterSurfaceTensionUnit to)
        {
            return (float)UnitConverterSurfaceTension.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterSurfaceTensionUnit from, UnitConverterSurfaceTensionUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterSurfaceTensionUnit from, UnitConverterSurfaceTensionUnit to)
        {
            return UnitConverterSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterSurfaceTensionUnit from, UnitConverterSurfaceTensionUnit to)
        {
            return UnitConverterSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterSurfaceTensionUnit from, UnitConverterSurfaceTensionUnit to)
        {
            return UnitConverterSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterSurfaceTensionUnit from, UnitConverterSurfaceTensionUnit to)
        {
            return UnitConverterSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterSurfaceTensionUnit from, UnitConverterSurfaceTensionUnit to)
        {
            return UnitConverterSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterSurfaceTensionUnit from, UnitConverterSurfaceTensionUnit to)
        {
            return UnitConverterSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterSurfaceTensionUnit from, UnitConverterSurfaceTensionUnit to)
        {
            return UnitConverterSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterSurfaceTensionUnit from, UnitConverterSurfaceTensionUnit to)
        {
            return UnitConverterSurfaceTension.Convert(value, from, to);
        }
    }
}
