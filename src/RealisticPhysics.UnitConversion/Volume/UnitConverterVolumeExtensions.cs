namespace RealisticPhysics.UnitConversion.Volume
{
    /// <summary>
    /// Extension-method API for Volume conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterVolumeExtensions
    {
        public static double Convert(this double value, UnitConverterVolumeUnit from, UnitConverterVolumeUnit to)
        {
            return UnitConverterVolume.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterVolumeUnit from, UnitConverterVolumeUnit to)
        {
            return (float)UnitConverterVolume.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterVolumeUnit from, UnitConverterVolumeUnit to)
        {
            return (decimal)UnitConverterVolume.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterVolumeUnit from, UnitConverterVolumeUnit to)
        {
            return UnitConverterVolume.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterVolumeUnit from, UnitConverterVolumeUnit to)
        {
            return UnitConverterVolume.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterVolumeUnit from, UnitConverterVolumeUnit to)
        {
            return UnitConverterVolume.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterVolumeUnit from, UnitConverterVolumeUnit to)
        {
            return UnitConverterVolume.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterVolumeUnit from, UnitConverterVolumeUnit to)
        {
            return UnitConverterVolume.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterVolumeUnit from, UnitConverterVolumeUnit to)
        {
            return UnitConverterVolume.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterVolumeUnit from, UnitConverterVolumeUnit to)
        {
            return UnitConverterVolume.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterVolumeUnit from, UnitConverterVolumeUnit to)
        {
            return UnitConverterVolume.Convert(value, from, to);
        }
    }
}
