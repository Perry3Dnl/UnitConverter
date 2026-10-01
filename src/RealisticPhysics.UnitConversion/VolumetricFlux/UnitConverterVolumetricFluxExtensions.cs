namespace RealisticPhysics.UnitConversion.VolumetricFlux
{
    /// <summary>
    /// Extension-method API for Volumetric Flux conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterVolumetricFluxExtensions
    {
        public static double Convert(this double value, UnitConverterVolumetricFluxUnit from, UnitConverterVolumetricFluxUnit to)
        {
            return UnitConverterVolumetricFlux.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterVolumetricFluxUnit from, UnitConverterVolumetricFluxUnit to)
        {
            return (float)UnitConverterVolumetricFlux.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterVolumetricFluxUnit from, UnitConverterVolumetricFluxUnit to)
        {
            return (decimal)UnitConverterVolumetricFlux.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterVolumetricFluxUnit from, UnitConverterVolumetricFluxUnit to)
        {
            return UnitConverterVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterVolumetricFluxUnit from, UnitConverterVolumetricFluxUnit to)
        {
            return UnitConverterVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterVolumetricFluxUnit from, UnitConverterVolumetricFluxUnit to)
        {
            return UnitConverterVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterVolumetricFluxUnit from, UnitConverterVolumetricFluxUnit to)
        {
            return UnitConverterVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterVolumetricFluxUnit from, UnitConverterVolumetricFluxUnit to)
        {
            return UnitConverterVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterVolumetricFluxUnit from, UnitConverterVolumetricFluxUnit to)
        {
            return UnitConverterVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterVolumetricFluxUnit from, UnitConverterVolumetricFluxUnit to)
        {
            return UnitConverterVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterVolumetricFluxUnit from, UnitConverterVolumetricFluxUnit to)
        {
            return UnitConverterVolumetricFlux.Convert(value, from, to);
        }
    }
}
