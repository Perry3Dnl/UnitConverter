namespace RealisticPhysics.UnitConversion.MagneticFlux
{
    /// <summary>
    /// Extension-method API for Magnetic Flux conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterMagneticFluxExtensions
    {
        public static double Convert(this double value, UnitConverterMagneticFluxUnit from, UnitConverterMagneticFluxUnit to)
        {
            return UnitConverterMagneticFlux.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterMagneticFluxUnit from, UnitConverterMagneticFluxUnit to)
        {
            return (float)UnitConverterMagneticFlux.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterMagneticFluxUnit from, UnitConverterMagneticFluxUnit to)
        {
            return (decimal)UnitConverterMagneticFlux.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterMagneticFluxUnit from, UnitConverterMagneticFluxUnit to)
        {
            return UnitConverterMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterMagneticFluxUnit from, UnitConverterMagneticFluxUnit to)
        {
            return UnitConverterMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterMagneticFluxUnit from, UnitConverterMagneticFluxUnit to)
        {
            return UnitConverterMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterMagneticFluxUnit from, UnitConverterMagneticFluxUnit to)
        {
            return UnitConverterMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterMagneticFluxUnit from, UnitConverterMagneticFluxUnit to)
        {
            return UnitConverterMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterMagneticFluxUnit from, UnitConverterMagneticFluxUnit to)
        {
            return UnitConverterMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterMagneticFluxUnit from, UnitConverterMagneticFluxUnit to)
        {
            return UnitConverterMagneticFlux.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterMagneticFluxUnit from, UnitConverterMagneticFluxUnit to)
        {
            return UnitConverterMagneticFlux.Convert(value, from, to);
        }
    }
}
