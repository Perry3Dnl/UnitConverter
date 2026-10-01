namespace UnitConverter.ParticleFlux
{
    /// <summary>
    /// Extension-method API for Particle Flux conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterParticleFluxExtensions
    {
        public static double Convert(this double value, UnitConverterParticleFluxUnit from, UnitConverterParticleFluxUnit to)
        {
            return UnitConverterParticleFlux.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterParticleFluxUnit from, UnitConverterParticleFluxUnit to)
        {
            return (float)UnitConverterParticleFlux.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterParticleFluxUnit from, UnitConverterParticleFluxUnit to)
        {
            return (decimal)UnitConverterParticleFlux.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterParticleFluxUnit from, UnitConverterParticleFluxUnit to)
        {
            return UnitConverterParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterParticleFluxUnit from, UnitConverterParticleFluxUnit to)
        {
            return UnitConverterParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterParticleFluxUnit from, UnitConverterParticleFluxUnit to)
        {
            return UnitConverterParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterParticleFluxUnit from, UnitConverterParticleFluxUnit to)
        {
            return UnitConverterParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterParticleFluxUnit from, UnitConverterParticleFluxUnit to)
        {
            return UnitConverterParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterParticleFluxUnit from, UnitConverterParticleFluxUnit to)
        {
            return UnitConverterParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterParticleFluxUnit from, UnitConverterParticleFluxUnit to)
        {
            return UnitConverterParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterParticleFluxUnit from, UnitConverterParticleFluxUnit to)
        {
            return UnitConverterParticleFlux.Convert(value, from, to);
        }
    }
}
