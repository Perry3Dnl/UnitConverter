namespace UnitTools.LuminousFlux
{
    /// <summary>
    /// Extension-method API for Luminous Flux conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsLuminousFluxExtensions
    {
        public static double Convert(this double value, UnitToolsLuminousFluxUnit from, UnitToolsLuminousFluxUnit to)
        {
            return UnitToolsLuminousFlux.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsLuminousFluxUnit from, UnitToolsLuminousFluxUnit to)
        {
            return (float)UnitToolsLuminousFlux.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsLuminousFluxUnit from, UnitToolsLuminousFluxUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsLuminousFluxUnit from, UnitToolsLuminousFluxUnit to)
        {
            return UnitToolsLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsLuminousFluxUnit from, UnitToolsLuminousFluxUnit to)
        {
            return UnitToolsLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsLuminousFluxUnit from, UnitToolsLuminousFluxUnit to)
        {
            return UnitToolsLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsLuminousFluxUnit from, UnitToolsLuminousFluxUnit to)
        {
            return UnitToolsLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsLuminousFluxUnit from, UnitToolsLuminousFluxUnit to)
        {
            return UnitToolsLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsLuminousFluxUnit from, UnitToolsLuminousFluxUnit to)
        {
            return UnitToolsLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsLuminousFluxUnit from, UnitToolsLuminousFluxUnit to)
        {
            return UnitToolsLuminousFlux.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsLuminousFluxUnit from, UnitToolsLuminousFluxUnit to)
        {
            return UnitToolsLuminousFlux.Convert(value, from, to);
        }
    }
}
