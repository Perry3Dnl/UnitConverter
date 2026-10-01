namespace UnitConverter.Power
{
    /// <summary>
    /// Extension-method API for Power conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterPowerExtensions
    {
        public static double Convert(this double value, UnitConverterPowerUnit from, UnitConverterPowerUnit to)
        {
            return UnitConverterPower.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterPowerUnit from, UnitConverterPowerUnit to)
        {
            return (float)UnitConverterPower.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterPowerUnit from, UnitConverterPowerUnit to)
        {
            return (decimal)UnitConverterPower.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterPowerUnit from, UnitConverterPowerUnit to)
        {
            return UnitConverterPower.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterPowerUnit from, UnitConverterPowerUnit to)
        {
            return UnitConverterPower.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterPowerUnit from, UnitConverterPowerUnit to)
        {
            return UnitConverterPower.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterPowerUnit from, UnitConverterPowerUnit to)
        {
            return UnitConverterPower.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterPowerUnit from, UnitConverterPowerUnit to)
        {
            return UnitConverterPower.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterPowerUnit from, UnitConverterPowerUnit to)
        {
            return UnitConverterPower.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterPowerUnit from, UnitConverterPowerUnit to)
        {
            return UnitConverterPower.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterPowerUnit from, UnitConverterPowerUnit to)
        {
            return UnitConverterPower.Convert(value, from, to);
        }
    }
}
