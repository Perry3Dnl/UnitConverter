namespace UnitTools.SurfaceTension
{
    /// <summary>
    /// Extension-method API for Surface Tension conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsSurfaceTensionExtensions
    {
        public static double Convert(this double value, UnitToolsSurfaceTensionUnit from, UnitToolsSurfaceTensionUnit to)
        {
            return UnitToolsSurfaceTension.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsSurfaceTensionUnit from, UnitToolsSurfaceTensionUnit to)
        {
            return (float)UnitToolsSurfaceTension.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsSurfaceTensionUnit from, UnitToolsSurfaceTensionUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsSurfaceTensionUnit from, UnitToolsSurfaceTensionUnit to)
        {
            return UnitToolsSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsSurfaceTensionUnit from, UnitToolsSurfaceTensionUnit to)
        {
            return UnitToolsSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsSurfaceTensionUnit from, UnitToolsSurfaceTensionUnit to)
        {
            return UnitToolsSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsSurfaceTensionUnit from, UnitToolsSurfaceTensionUnit to)
        {
            return UnitToolsSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsSurfaceTensionUnit from, UnitToolsSurfaceTensionUnit to)
        {
            return UnitToolsSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsSurfaceTensionUnit from, UnitToolsSurfaceTensionUnit to)
        {
            return UnitToolsSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsSurfaceTensionUnit from, UnitToolsSurfaceTensionUnit to)
        {
            return UnitToolsSurfaceTension.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsSurfaceTensionUnit from, UnitToolsSurfaceTensionUnit to)
        {
            return UnitToolsSurfaceTension.Convert(value, from, to);
        }
    }
}
