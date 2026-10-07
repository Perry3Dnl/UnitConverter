namespace UnitConverter.SpecificVolume
{
    /// <summary>
    /// Extension-method API for Specific Volume conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterSpecificVolumeExtensions
    {
        public static double Convert(this double value, UnitConverterSpecificVolumeUnit from, UnitConverterSpecificVolumeUnit to)
        {
            return UnitConverterSpecificVolume.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterSpecificVolumeUnit from, UnitConverterSpecificVolumeUnit to)
        {
            return (float)UnitConverterSpecificVolume.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterSpecificVolumeUnit from, UnitConverterSpecificVolumeUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterSpecificVolumeUnit from, UnitConverterSpecificVolumeUnit to)
        {
            return UnitConverterSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterSpecificVolumeUnit from, UnitConverterSpecificVolumeUnit to)
        {
            return UnitConverterSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterSpecificVolumeUnit from, UnitConverterSpecificVolumeUnit to)
        {
            return UnitConverterSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterSpecificVolumeUnit from, UnitConverterSpecificVolumeUnit to)
        {
            return UnitConverterSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterSpecificVolumeUnit from, UnitConverterSpecificVolumeUnit to)
        {
            return UnitConverterSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterSpecificVolumeUnit from, UnitConverterSpecificVolumeUnit to)
        {
            return UnitConverterSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterSpecificVolumeUnit from, UnitConverterSpecificVolumeUnit to)
        {
            return UnitConverterSpecificVolume.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterSpecificVolumeUnit from, UnitConverterSpecificVolumeUnit to)
        {
            return UnitConverterSpecificVolume.Convert(value, from, to);
        }
    }
}
