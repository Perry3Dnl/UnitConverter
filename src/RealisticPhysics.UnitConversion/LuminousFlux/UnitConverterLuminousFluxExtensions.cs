namespace RealisticPhysics.UnitConversion.LuminousFlux
{
    /// <summary>
    /// Extension-method API for Luminous Flux conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterLuminousFluxExtensions
    {
        public static double Convert(this double value, UnitConverterLuminousFluxUnit from, UnitConverterLuminousFluxUnit to)
        {
            return UnitConverterLuminousFlux.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterLuminousFluxUnit from, UnitConverterLuminousFluxUnit to)
        {
            return (float)UnitConverterLuminousFlux.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterLuminousFluxUnit from, UnitConverterLuminousFluxUnit to)
        {
            return (decimal)UnitConverterLuminousFlux.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterLuminousFluxUnit from, UnitConverterLuminousFluxUnit to)
        {
            return UnitConverterLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterLuminousFluxUnit from, UnitConverterLuminousFluxUnit to)
        {
            return UnitConverterLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterLuminousFluxUnit from, UnitConverterLuminousFluxUnit to)
        {
            return UnitConverterLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterLuminousFluxUnit from, UnitConverterLuminousFluxUnit to)
        {
            return UnitConverterLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterLuminousFluxUnit from, UnitConverterLuminousFluxUnit to)
        {
            return UnitConverterLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterLuminousFluxUnit from, UnitConverterLuminousFluxUnit to)
        {
            return UnitConverterLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterLuminousFluxUnit from, UnitConverterLuminousFluxUnit to)
        {
            return UnitConverterLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterLuminousFluxUnit from, UnitConverterLuminousFluxUnit to)
        {
            return UnitConverterLuminousFlux.Convert(value, from, to);
        }
    }
}
