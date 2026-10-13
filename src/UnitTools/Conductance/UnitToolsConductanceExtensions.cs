namespace UnitTools.Conductance
{
    /// <summary>
    /// Extension-method API for Conductance conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsConductanceExtensions
    {
        public static double Convert(this double value, UnitToolsConductanceUnit from, UnitToolsConductanceUnit to)
        {
            return UnitToolsConductance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsConductanceUnit from, UnitToolsConductanceUnit to)
        {
            return (float)UnitToolsConductance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsConductanceUnit from, UnitToolsConductanceUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsConductanceUnit from, UnitToolsConductanceUnit to)
        {
            return UnitToolsConductance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsConductanceUnit from, UnitToolsConductanceUnit to)
        {
            return UnitToolsConductance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsConductanceUnit from, UnitToolsConductanceUnit to)
        {
            return UnitToolsConductance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsConductanceUnit from, UnitToolsConductanceUnit to)
        {
            return UnitToolsConductance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsConductanceUnit from, UnitToolsConductanceUnit to)
        {
            return UnitToolsConductance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsConductanceUnit from, UnitToolsConductanceUnit to)
        {
            return UnitToolsConductance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsConductanceUnit from, UnitToolsConductanceUnit to)
        {
            return UnitToolsConductance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsConductanceUnit from, UnitToolsConductanceUnit to)
        {
            return UnitToolsConductance.Convert(value, from, to);
        }
    }
}
