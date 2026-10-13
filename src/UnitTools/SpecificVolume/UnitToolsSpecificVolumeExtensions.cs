namespace UnitTools.SpecificVolume
{
    /// <summary>
    /// Extension-method API for Specific Volume conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsSpecificVolumeExtensions
    {
        public static double Convert(this double value, UnitToolsSpecificVolumeUnit from, UnitToolsSpecificVolumeUnit to)
        {
            return UnitToolsSpecificVolume.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsSpecificVolumeUnit from, UnitToolsSpecificVolumeUnit to)
        {
            return (float)UnitToolsSpecificVolume.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsSpecificVolumeUnit from, UnitToolsSpecificVolumeUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsSpecificVolumeUnit from, UnitToolsSpecificVolumeUnit to)
        {
            return UnitToolsSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsSpecificVolumeUnit from, UnitToolsSpecificVolumeUnit to)
        {
            return UnitToolsSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsSpecificVolumeUnit from, UnitToolsSpecificVolumeUnit to)
        {
            return UnitToolsSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsSpecificVolumeUnit from, UnitToolsSpecificVolumeUnit to)
        {
            return UnitToolsSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsSpecificVolumeUnit from, UnitToolsSpecificVolumeUnit to)
        {
            return UnitToolsSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsSpecificVolumeUnit from, UnitToolsSpecificVolumeUnit to)
        {
            return UnitToolsSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsSpecificVolumeUnit from, UnitToolsSpecificVolumeUnit to)
        {
            return UnitToolsSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsSpecificVolumeUnit from, UnitToolsSpecificVolumeUnit to)
        {
            return UnitToolsSpecificVolume.Convert(value, from, to);
        }
    }
}
