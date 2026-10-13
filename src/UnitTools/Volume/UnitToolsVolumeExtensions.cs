namespace UnitTools.Volume
{
    /// <summary>
    /// Extension-method API for Volume conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsVolumeExtensions
    {
        public static double Convert(this double value, UnitToolsVolumeUnit from, UnitToolsVolumeUnit to)
        {
            return UnitToolsVolume.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsVolumeUnit from, UnitToolsVolumeUnit to)
        {
            return (float)UnitToolsVolume.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsVolumeUnit from, UnitToolsVolumeUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsVolumeUnit from, UnitToolsVolumeUnit to)
        {
            return UnitToolsVolume.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsVolumeUnit from, UnitToolsVolumeUnit to)
        {
            return UnitToolsVolume.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsVolumeUnit from, UnitToolsVolumeUnit to)
        {
            return UnitToolsVolume.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsVolumeUnit from, UnitToolsVolumeUnit to)
        {
            return UnitToolsVolume.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsVolumeUnit from, UnitToolsVolumeUnit to)
        {
            return UnitToolsVolume.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsVolumeUnit from, UnitToolsVolumeUnit to)
        {
            return UnitToolsVolume.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsVolumeUnit from, UnitToolsVolumeUnit to)
        {
            return UnitToolsVolume.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsVolumeUnit from, UnitToolsVolumeUnit to)
        {
            return UnitToolsVolume.Convert(value, from, to);
        }
    }
}
