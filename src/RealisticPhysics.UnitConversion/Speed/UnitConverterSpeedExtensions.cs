namespace RealisticPhysics.UnitConversion.Speed
{
    /// <summary>
    /// Extension-method API for Speed conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterSpeedExtensions
    {
        public static double Convert(this double value, UnitConverterSpeedUnit from, UnitConverterSpeedUnit to)
        {
            return UnitConverterSpeed.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterSpeedUnit from, UnitConverterSpeedUnit to)
        {
            return (float)UnitConverterSpeed.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterSpeedUnit from, UnitConverterSpeedUnit to)
        {
            return (decimal)UnitConverterSpeed.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterSpeedUnit from, UnitConverterSpeedUnit to)
        {
            return UnitConverterSpeed.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterSpeedUnit from, UnitConverterSpeedUnit to)
        {
            return UnitConverterSpeed.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterSpeedUnit from, UnitConverterSpeedUnit to)
        {
            return UnitConverterSpeed.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterSpeedUnit from, UnitConverterSpeedUnit to)
        {
            return UnitConverterSpeed.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterSpeedUnit from, UnitConverterSpeedUnit to)
        {
            return UnitConverterSpeed.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterSpeedUnit from, UnitConverterSpeedUnit to)
        {
            return UnitConverterSpeed.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterSpeedUnit from, UnitConverterSpeedUnit to)
        {
            return UnitConverterSpeed.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterSpeedUnit from, UnitConverterSpeedUnit to)
        {
            return UnitConverterSpeed.Convert(value, from, to);
        }
    }
}
