namespace UnitTools.Speed
{
    /// <summary>
    /// Extension-method API for Speed conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsSpeedExtensions
    {
        public static double Convert(this double value, UnitToolsSpeedUnit from, UnitToolsSpeedUnit to)
        {
            return UnitToolsSpeed.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsSpeedUnit from, UnitToolsSpeedUnit to)
        {
            return (float)UnitToolsSpeed.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsSpeedUnit from, UnitToolsSpeedUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsSpeedUnit from, UnitToolsSpeedUnit to)
        {
            return UnitToolsSpeed.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsSpeedUnit from, UnitToolsSpeedUnit to)
        {
            return UnitToolsSpeed.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsSpeedUnit from, UnitToolsSpeedUnit to)
        {
            return UnitToolsSpeed.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsSpeedUnit from, UnitToolsSpeedUnit to)
        {
            return UnitToolsSpeed.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsSpeedUnit from, UnitToolsSpeedUnit to)
        {
            return UnitToolsSpeed.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsSpeedUnit from, UnitToolsSpeedUnit to)
        {
            return UnitToolsSpeed.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsSpeedUnit from, UnitToolsSpeedUnit to)
        {
            return UnitToolsSpeed.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsSpeedUnit from, UnitToolsSpeedUnit to)
        {
            return UnitToolsSpeed.Convert(value, from, to);
        }
    }
}
