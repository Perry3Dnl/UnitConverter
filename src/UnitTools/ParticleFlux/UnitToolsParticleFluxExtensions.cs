namespace UnitTools.ParticleFlux
{
    /// <summary>
    /// Extension-method API for Particle Flux conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsParticleFluxExtensions
    {
        public static double Convert(this double value, UnitToolsParticleFluxUnit from, UnitToolsParticleFluxUnit to)
        {
            return UnitToolsParticleFlux.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsParticleFluxUnit from, UnitToolsParticleFluxUnit to)
        {
            return (float)UnitToolsParticleFlux.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsParticleFluxUnit from, UnitToolsParticleFluxUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsParticleFluxUnit from, UnitToolsParticleFluxUnit to)
        {
            return UnitToolsParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsParticleFluxUnit from, UnitToolsParticleFluxUnit to)
        {
            return UnitToolsParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsParticleFluxUnit from, UnitToolsParticleFluxUnit to)
        {
            return UnitToolsParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsParticleFluxUnit from, UnitToolsParticleFluxUnit to)
        {
            return UnitToolsParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsParticleFluxUnit from, UnitToolsParticleFluxUnit to)
        {
            return UnitToolsParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsParticleFluxUnit from, UnitToolsParticleFluxUnit to)
        {
            return UnitToolsParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsParticleFluxUnit from, UnitToolsParticleFluxUnit to)
        {
            return UnitToolsParticleFlux.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsParticleFluxUnit from, UnitToolsParticleFluxUnit to)
        {
            return UnitToolsParticleFlux.Convert(value, from, to);
        }
    }
}
