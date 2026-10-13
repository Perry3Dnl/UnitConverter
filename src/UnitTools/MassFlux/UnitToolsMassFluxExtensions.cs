namespace UnitTools.MassFlux
{
    /// <summary>
    /// Extension-method API for Mass Flux conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsMassFluxExtensions
    {
        public static double Convert(this double value, UnitToolsMassFluxUnit from, UnitToolsMassFluxUnit to)
        {
            return UnitToolsMassFlux.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsMassFluxUnit from, UnitToolsMassFluxUnit to)
        {
            return (float)UnitToolsMassFlux.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsMassFluxUnit from, UnitToolsMassFluxUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsMassFluxUnit from, UnitToolsMassFluxUnit to)
        {
            return UnitToolsMassFlux.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsMassFluxUnit from, UnitToolsMassFluxUnit to)
        {
            return UnitToolsMassFlux.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsMassFluxUnit from, UnitToolsMassFluxUnit to)
        {
            return UnitToolsMassFlux.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsMassFluxUnit from, UnitToolsMassFluxUnit to)
        {
            return UnitToolsMassFlux.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsMassFluxUnit from, UnitToolsMassFluxUnit to)
        {
            return UnitToolsMassFlux.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsMassFluxUnit from, UnitToolsMassFluxUnit to)
        {
            return UnitToolsMassFlux.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsMassFluxUnit from, UnitToolsMassFluxUnit to)
        {
            return UnitToolsMassFlux.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsMassFluxUnit from, UnitToolsMassFluxUnit to)
        {
            return UnitToolsMassFlux.Convert(value, from, to);
        }
    }
}
