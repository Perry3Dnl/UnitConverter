namespace UnitTools.Capacitance
{
    /// <summary>
    /// Extension-method API for Capacitance conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsCapacitanceExtensions
    {
        public static double Convert(this double value, UnitToolsCapacitanceUnit from, UnitToolsCapacitanceUnit to)
        {
            return UnitToolsCapacitance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsCapacitanceUnit from, UnitToolsCapacitanceUnit to)
        {
            return (float)UnitToolsCapacitance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsCapacitanceUnit from, UnitToolsCapacitanceUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsCapacitanceUnit from, UnitToolsCapacitanceUnit to)
        {
            return UnitToolsCapacitance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsCapacitanceUnit from, UnitToolsCapacitanceUnit to)
        {
            return UnitToolsCapacitance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsCapacitanceUnit from, UnitToolsCapacitanceUnit to)
        {
            return UnitToolsCapacitance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsCapacitanceUnit from, UnitToolsCapacitanceUnit to)
        {
            return UnitToolsCapacitance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsCapacitanceUnit from, UnitToolsCapacitanceUnit to)
        {
            return UnitToolsCapacitance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsCapacitanceUnit from, UnitToolsCapacitanceUnit to)
        {
            return UnitToolsCapacitance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsCapacitanceUnit from, UnitToolsCapacitanceUnit to)
        {
            return UnitToolsCapacitance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsCapacitanceUnit from, UnitToolsCapacitanceUnit to)
        {
            return UnitToolsCapacitance.Convert(value, from, to);
        }
    }
}
