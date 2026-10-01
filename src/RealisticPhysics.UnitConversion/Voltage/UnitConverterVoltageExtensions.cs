namespace RealisticPhysics.UnitConversion.Voltage
{
    /// <summary>
    /// Extension-method API for Voltage conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterVoltageExtensions
    {
        public static double Convert(this double value, UnitConverterVoltageUnit from, UnitConverterVoltageUnit to)
        {
            return UnitConverterVoltage.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterVoltageUnit from, UnitConverterVoltageUnit to)
        {
            return (float)UnitConverterVoltage.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterVoltageUnit from, UnitConverterVoltageUnit to)
        {
            return (decimal)UnitConverterVoltage.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterVoltageUnit from, UnitConverterVoltageUnit to)
        {
            return UnitConverterVoltage.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterVoltageUnit from, UnitConverterVoltageUnit to)
        {
            return UnitConverterVoltage.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterVoltageUnit from, UnitConverterVoltageUnit to)
        {
            return UnitConverterVoltage.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterVoltageUnit from, UnitConverterVoltageUnit to)
        {
            return UnitConverterVoltage.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterVoltageUnit from, UnitConverterVoltageUnit to)
        {
            return UnitConverterVoltage.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterVoltageUnit from, UnitConverterVoltageUnit to)
        {
            return UnitConverterVoltage.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterVoltageUnit from, UnitConverterVoltageUnit to)
        {
            return UnitConverterVoltage.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterVoltageUnit from, UnitConverterVoltageUnit to)
        {
            return UnitConverterVoltage.Convert(value, from, to);
        }
    }
}
