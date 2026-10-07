namespace UnitConverter.Angle
{
    /// <summary>
    /// Extension-method API for Angle conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterAngleExtensions
    {
        public static double Convert(this double value, UnitConverterAngleUnit from, UnitConverterAngleUnit to)
        {
            return UnitConverterAngle.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterAngleUnit from, UnitConverterAngleUnit to)
        {
            return (float)UnitConverterAngle.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterAngleUnit from, UnitConverterAngleUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterAngleUnit from, UnitConverterAngleUnit to)
        {
            return UnitConverterAngle.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterAngleUnit from, UnitConverterAngleUnit to)
        {
            return UnitConverterAngle.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterAngleUnit from, UnitConverterAngleUnit to)
        {
            return UnitConverterAngle.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterAngleUnit from, UnitConverterAngleUnit to)
        {
            return UnitConverterAngle.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterAngleUnit from, UnitConverterAngleUnit to)
        {
            return UnitConverterAngle.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterAngleUnit from, UnitConverterAngleUnit to)
        {
            return UnitConverterAngle.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterAngleUnit from, UnitConverterAngleUnit to)
        {
            return UnitConverterAngle.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterAngleUnit from, UnitConverterAngleUnit to)
        {
            return UnitConverterAngle.Convert(value, from, to);
        }
    }
}
