namespace UnitTools.VolumetricFlux
{
    /// <summary>
    /// Extension-method API for Volumetric Flux conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsVolumetricFluxExtensions
    {
        public static double Convert(this double value, UnitToolsVolumetricFluxUnit from, UnitToolsVolumetricFluxUnit to)
        {
            return UnitToolsVolumetricFlux.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsVolumetricFluxUnit from, UnitToolsVolumetricFluxUnit to)
        {
            return (float)UnitToolsVolumetricFlux.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsVolumetricFluxUnit from, UnitToolsVolumetricFluxUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsVolumetricFluxUnit from, UnitToolsVolumetricFluxUnit to)
        {
            return UnitToolsVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsVolumetricFluxUnit from, UnitToolsVolumetricFluxUnit to)
        {
            return UnitToolsVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsVolumetricFluxUnit from, UnitToolsVolumetricFluxUnit to)
        {
            return UnitToolsVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsVolumetricFluxUnit from, UnitToolsVolumetricFluxUnit to)
        {
            return UnitToolsVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsVolumetricFluxUnit from, UnitToolsVolumetricFluxUnit to)
        {
            return UnitToolsVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsVolumetricFluxUnit from, UnitToolsVolumetricFluxUnit to)
        {
            return UnitToolsVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsVolumetricFluxUnit from, UnitToolsVolumetricFluxUnit to)
        {
            return UnitToolsVolumetricFlux.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsVolumetricFluxUnit from, UnitToolsVolumetricFluxUnit to)
        {
            return UnitToolsVolumetricFlux.Convert(value, from, to);
        }
    }
}
