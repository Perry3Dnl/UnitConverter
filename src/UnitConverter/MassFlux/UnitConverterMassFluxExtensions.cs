namespace UnitConverter.MassFlux
{
    /// <summary>
    /// Extension-method API for Mass Flux conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterMassFluxExtensions
    {
        public static double Convert(this double value, UnitConverterMassFluxUnit from, UnitConverterMassFluxUnit to)
        {
            return UnitConverterMassFlux.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterMassFluxUnit from, UnitConverterMassFluxUnit to)
        {
            return (float)UnitConverterMassFlux.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterMassFluxUnit from, UnitConverterMassFluxUnit to)
        {
            return (decimal)UnitConverterMassFlux.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterMassFluxUnit from, UnitConverterMassFluxUnit to)
        {
            return UnitConverterMassFlux.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterMassFluxUnit from, UnitConverterMassFluxUnit to)
        {
            return UnitConverterMassFlux.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterMassFluxUnit from, UnitConverterMassFluxUnit to)
        {
            return UnitConverterMassFlux.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterMassFluxUnit from, UnitConverterMassFluxUnit to)
        {
            return UnitConverterMassFlux.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterMassFluxUnit from, UnitConverterMassFluxUnit to)
        {
            return UnitConverterMassFlux.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterMassFluxUnit from, UnitConverterMassFluxUnit to)
        {
            return UnitConverterMassFlux.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterMassFluxUnit from, UnitConverterMassFluxUnit to)
        {
            return UnitConverterMassFlux.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterMassFluxUnit from, UnitConverterMassFluxUnit to)
        {
            return UnitConverterMassFlux.Convert(value, from, to);
        }
    }
}
