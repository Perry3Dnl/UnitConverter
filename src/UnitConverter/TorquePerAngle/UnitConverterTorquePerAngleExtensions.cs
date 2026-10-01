namespace UnitConverter.TorquePerAngle
{
    /// <summary>
    /// Extension-method API for Torque Per Angle conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterTorquePerAngleExtensions
    {
        public static double Convert(this double value, UnitConverterTorquePerAngleUnit from, UnitConverterTorquePerAngleUnit to)
        {
            return UnitConverterTorquePerAngle.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterTorquePerAngleUnit from, UnitConverterTorquePerAngleUnit to)
        {
            return (float)UnitConverterTorquePerAngle.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterTorquePerAngleUnit from, UnitConverterTorquePerAngleUnit to)
        {
            return (decimal)UnitConverterTorquePerAngle.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterTorquePerAngleUnit from, UnitConverterTorquePerAngleUnit to)
        {
            return UnitConverterTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterTorquePerAngleUnit from, UnitConverterTorquePerAngleUnit to)
        {
            return UnitConverterTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterTorquePerAngleUnit from, UnitConverterTorquePerAngleUnit to)
        {
            return UnitConverterTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterTorquePerAngleUnit from, UnitConverterTorquePerAngleUnit to)
        {
            return UnitConverterTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterTorquePerAngleUnit from, UnitConverterTorquePerAngleUnit to)
        {
            return UnitConverterTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterTorquePerAngleUnit from, UnitConverterTorquePerAngleUnit to)
        {
            return UnitConverterTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterTorquePerAngleUnit from, UnitConverterTorquePerAngleUnit to)
        {
            return UnitConverterTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterTorquePerAngleUnit from, UnitConverterTorquePerAngleUnit to)
        {
            return UnitConverterTorquePerAngle.Convert(value, from, to);
        }
    }
}
