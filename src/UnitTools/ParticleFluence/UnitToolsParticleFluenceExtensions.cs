namespace UnitTools.ParticleFluence
{
    /// <summary>
    /// Extension-method API for Particle Fluence conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsParticleFluenceExtensions
    {
        public static double Convert(this double value, UnitToolsParticleFluenceUnit from, UnitToolsParticleFluenceUnit to)
        {
            return UnitToolsParticleFluence.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsParticleFluenceUnit from, UnitToolsParticleFluenceUnit to)
        {
            return (float)UnitToolsParticleFluence.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsParticleFluenceUnit from, UnitToolsParticleFluenceUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsParticleFluenceUnit from, UnitToolsParticleFluenceUnit to)
        {
            return UnitToolsParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsParticleFluenceUnit from, UnitToolsParticleFluenceUnit to)
        {
            return UnitToolsParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsParticleFluenceUnit from, UnitToolsParticleFluenceUnit to)
        {
            return UnitToolsParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsParticleFluenceUnit from, UnitToolsParticleFluenceUnit to)
        {
            return UnitToolsParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsParticleFluenceUnit from, UnitToolsParticleFluenceUnit to)
        {
            return UnitToolsParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsParticleFluenceUnit from, UnitToolsParticleFluenceUnit to)
        {
            return UnitToolsParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsParticleFluenceUnit from, UnitToolsParticleFluenceUnit to)
        {
            return UnitToolsParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsParticleFluenceUnit from, UnitToolsParticleFluenceUnit to)
        {
            return UnitToolsParticleFluence.Convert(value, from, to);
        }
    }
}
