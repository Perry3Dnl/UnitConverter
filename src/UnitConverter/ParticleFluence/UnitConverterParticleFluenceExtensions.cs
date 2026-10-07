namespace UnitConverter.ParticleFluence
{
    /// <summary>
    /// Extension-method API for Particle Fluence conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterParticleFluenceExtensions
    {
        public static double Convert(this double value, UnitConverterParticleFluenceUnit from, UnitConverterParticleFluenceUnit to)
        {
            return UnitConverterParticleFluence.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterParticleFluenceUnit from, UnitConverterParticleFluenceUnit to)
        {
            return (float)UnitConverterParticleFluence.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterParticleFluenceUnit from, UnitConverterParticleFluenceUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterParticleFluenceUnit from, UnitConverterParticleFluenceUnit to)
        {
            return UnitConverterParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterParticleFluenceUnit from, UnitConverterParticleFluenceUnit to)
        {
            return UnitConverterParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterParticleFluenceUnit from, UnitConverterParticleFluenceUnit to)
        {
            return UnitConverterParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterParticleFluenceUnit from, UnitConverterParticleFluenceUnit to)
        {
            return UnitConverterParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterParticleFluenceUnit from, UnitConverterParticleFluenceUnit to)
        {
            return UnitConverterParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterParticleFluenceUnit from, UnitConverterParticleFluenceUnit to)
        {
            return UnitConverterParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterParticleFluenceUnit from, UnitConverterParticleFluenceUnit to)
        {
            return UnitConverterParticleFluence.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterParticleFluenceUnit from, UnitConverterParticleFluenceUnit to)
        {
            return UnitConverterParticleFluence.Convert(value, from, to);
        }
    }
}
