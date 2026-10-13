namespace UnitTools.TorquePerAngle
{
    /// <summary>
    /// Extension-method API for Torque Per Angle conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsTorquePerAngleExtensions
    {
        public static double Convert(this double value, UnitToolsTorquePerAngleUnit from, UnitToolsTorquePerAngleUnit to)
        {
            return UnitToolsTorquePerAngle.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsTorquePerAngleUnit from, UnitToolsTorquePerAngleUnit to)
        {
            return (float)UnitToolsTorquePerAngle.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsTorquePerAngleUnit from, UnitToolsTorquePerAngleUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsTorquePerAngleUnit from, UnitToolsTorquePerAngleUnit to)
        {
            return UnitToolsTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsTorquePerAngleUnit from, UnitToolsTorquePerAngleUnit to)
        {
            return UnitToolsTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsTorquePerAngleUnit from, UnitToolsTorquePerAngleUnit to)
        {
            return UnitToolsTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsTorquePerAngleUnit from, UnitToolsTorquePerAngleUnit to)
        {
            return UnitToolsTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsTorquePerAngleUnit from, UnitToolsTorquePerAngleUnit to)
        {
            return UnitToolsTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsTorquePerAngleUnit from, UnitToolsTorquePerAngleUnit to)
        {
            return UnitToolsTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsTorquePerAngleUnit from, UnitToolsTorquePerAngleUnit to)
        {
            return UnitToolsTorquePerAngle.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsTorquePerAngleUnit from, UnitToolsTorquePerAngleUnit to)
        {
            return UnitToolsTorquePerAngle.Convert(value, from, to);
        }
    }
}
