namespace UnitTools.MagneticFlux
{
    /// <summary>
    /// Extension-method API for Magnetic Flux conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsMagneticFluxExtensions
    {
        public static double Convert(this double value, UnitToolsMagneticFluxUnit from, UnitToolsMagneticFluxUnit to)
        {
            return UnitToolsMagneticFlux.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsMagneticFluxUnit from, UnitToolsMagneticFluxUnit to)
        {
            return (float)UnitToolsMagneticFlux.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsMagneticFluxUnit from, UnitToolsMagneticFluxUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsMagneticFluxUnit from, UnitToolsMagneticFluxUnit to)
        {
            return UnitToolsMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsMagneticFluxUnit from, UnitToolsMagneticFluxUnit to)
        {
            return UnitToolsMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsMagneticFluxUnit from, UnitToolsMagneticFluxUnit to)
        {
            return UnitToolsMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsMagneticFluxUnit from, UnitToolsMagneticFluxUnit to)
        {
            return UnitToolsMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsMagneticFluxUnit from, UnitToolsMagneticFluxUnit to)
        {
            return UnitToolsMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsMagneticFluxUnit from, UnitToolsMagneticFluxUnit to)
        {
            return UnitToolsMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsMagneticFluxUnit from, UnitToolsMagneticFluxUnit to)
        {
            return UnitToolsMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsMagneticFluxUnit from, UnitToolsMagneticFluxUnit to)
        {
            return UnitToolsMagneticFlux.Convert(value, from, to);
        }
    }
}
