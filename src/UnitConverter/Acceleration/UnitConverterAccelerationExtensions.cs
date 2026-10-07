namespace UnitConverter.Acceleration
{
    /// <summary>
    /// Extension-method API for Acceleration conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterAccelerationExtensions
    {
        public static double Convert(this double value, UnitConverterAccelerationUnit from, UnitConverterAccelerationUnit to)
        {
            return UnitConverterAcceleration.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterAccelerationUnit from, UnitConverterAccelerationUnit to)
        {
            return (float)UnitConverterAcceleration.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterAccelerationUnit from, UnitConverterAccelerationUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterAccelerationUnit from, UnitConverterAccelerationUnit to)
        {
            return UnitConverterAcceleration.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterAccelerationUnit from, UnitConverterAccelerationUnit to)
        {
            return UnitConverterAcceleration.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterAccelerationUnit from, UnitConverterAccelerationUnit to)
        {
            return UnitConverterAcceleration.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterAccelerationUnit from, UnitConverterAccelerationUnit to)
        {
            return UnitConverterAcceleration.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterAccelerationUnit from, UnitConverterAccelerationUnit to)
        {
            return UnitConverterAcceleration.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterAccelerationUnit from, UnitConverterAccelerationUnit to)
        {
            return UnitConverterAcceleration.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterAccelerationUnit from, UnitConverterAccelerationUnit to)
        {
            return UnitConverterAcceleration.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterAccelerationUnit from, UnitConverterAccelerationUnit to)
        {
            return UnitConverterAcceleration.Convert(value, from, to);
        }
    }
}
