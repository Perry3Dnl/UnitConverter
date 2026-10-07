namespace UnitConverter.Torque
{
    /// <summary>
    /// Extension-method API for Torque conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterTorqueExtensions
    {
        public static double Convert(this double value, UnitConverterTorqueUnit from, UnitConverterTorqueUnit to)
        {
            return UnitConverterTorque.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterTorqueUnit from, UnitConverterTorqueUnit to)
        {
            return (float)UnitConverterTorque.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterTorqueUnit from, UnitConverterTorqueUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterTorqueUnit from, UnitConverterTorqueUnit to)
        {
            return UnitConverterTorque.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterTorqueUnit from, UnitConverterTorqueUnit to)
        {
            return UnitConverterTorque.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterTorqueUnit from, UnitConverterTorqueUnit to)
        {
            return UnitConverterTorque.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterTorqueUnit from, UnitConverterTorqueUnit to)
        {
            return UnitConverterTorque.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterTorqueUnit from, UnitConverterTorqueUnit to)
        {
            return UnitConverterTorque.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterTorqueUnit from, UnitConverterTorqueUnit to)
        {
            return UnitConverterTorque.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterTorqueUnit from, UnitConverterTorqueUnit to)
        {
            return UnitConverterTorque.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterTorqueUnit from, UnitConverterTorqueUnit to)
        {
            return UnitConverterTorque.Convert(value, from, to);
        }
    }
}
