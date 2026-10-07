namespace UnitConverter.ElectricFlux
{
    /// <summary>
    /// Extension-method API for Electric Flux conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterElectricFluxExtensions
    {
        public static double Convert(this double value, UnitConverterElectricFluxUnit from, UnitConverterElectricFluxUnit to)
        {
            return UnitConverterElectricFlux.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterElectricFluxUnit from, UnitConverterElectricFluxUnit to)
        {
            return (float)UnitConverterElectricFlux.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterElectricFluxUnit from, UnitConverterElectricFluxUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterElectricFluxUnit from, UnitConverterElectricFluxUnit to)
        {
            return UnitConverterElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterElectricFluxUnit from, UnitConverterElectricFluxUnit to)
        {
            return UnitConverterElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterElectricFluxUnit from, UnitConverterElectricFluxUnit to)
        {
            return UnitConverterElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterElectricFluxUnit from, UnitConverterElectricFluxUnit to)
        {
            return UnitConverterElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterElectricFluxUnit from, UnitConverterElectricFluxUnit to)
        {
            return UnitConverterElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterElectricFluxUnit from, UnitConverterElectricFluxUnit to)
        {
            return UnitConverterElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterElectricFluxUnit from, UnitConverterElectricFluxUnit to)
        {
            return UnitConverterElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterElectricFluxUnit from, UnitConverterElectricFluxUnit to)
        {
            return UnitConverterElectricFlux.Convert(value, from, to);
        }
    }
}
