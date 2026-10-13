namespace UnitTools.Voltage
{
    /// <summary>
    /// Extension-method API for Voltage conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsVoltageExtensions
    {
        public static double Convert(this double value, UnitToolsVoltageUnit from, UnitToolsVoltageUnit to)
        {
            return UnitToolsVoltage.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsVoltageUnit from, UnitToolsVoltageUnit to)
        {
            return (float)UnitToolsVoltage.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsVoltageUnit from, UnitToolsVoltageUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsVoltageUnit from, UnitToolsVoltageUnit to)
        {
            return UnitToolsVoltage.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsVoltageUnit from, UnitToolsVoltageUnit to)
        {
            return UnitToolsVoltage.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsVoltageUnit from, UnitToolsVoltageUnit to)
        {
            return UnitToolsVoltage.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsVoltageUnit from, UnitToolsVoltageUnit to)
        {
            return UnitToolsVoltage.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsVoltageUnit from, UnitToolsVoltageUnit to)
        {
            return UnitToolsVoltage.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsVoltageUnit from, UnitToolsVoltageUnit to)
        {
            return UnitToolsVoltage.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsVoltageUnit from, UnitToolsVoltageUnit to)
        {
            return UnitToolsVoltage.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsVoltageUnit from, UnitToolsVoltageUnit to)
        {
            return UnitToolsVoltage.Convert(value, from, to);
        }
    }
}
