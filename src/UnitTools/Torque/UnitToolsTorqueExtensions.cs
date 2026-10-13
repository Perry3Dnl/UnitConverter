namespace UnitTools.Torque
{
    /// <summary>
    /// Extension-method API for Torque conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsTorqueExtensions
    {
        public static double Convert(this double value, UnitToolsTorqueUnit from, UnitToolsTorqueUnit to)
        {
            return UnitToolsTorque.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsTorqueUnit from, UnitToolsTorqueUnit to)
        {
            return (float)UnitToolsTorque.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsTorqueUnit from, UnitToolsTorqueUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsTorqueUnit from, UnitToolsTorqueUnit to)
        {
            return UnitToolsTorque.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsTorqueUnit from, UnitToolsTorqueUnit to)
        {
            return UnitToolsTorque.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsTorqueUnit from, UnitToolsTorqueUnit to)
        {
            return UnitToolsTorque.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsTorqueUnit from, UnitToolsTorqueUnit to)
        {
            return UnitToolsTorque.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsTorqueUnit from, UnitToolsTorqueUnit to)
        {
            return UnitToolsTorque.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsTorqueUnit from, UnitToolsTorqueUnit to)
        {
            return UnitToolsTorque.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsTorqueUnit from, UnitToolsTorqueUnit to)
        {
            return UnitToolsTorque.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsTorqueUnit from, UnitToolsTorqueUnit to)
        {
            return UnitToolsTorque.Convert(value, from, to);
        }
    }
}
