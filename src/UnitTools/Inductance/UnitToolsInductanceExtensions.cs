namespace UnitTools.Inductance
{
    /// <summary>
    /// Extension-method API for Inductance conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsInductanceExtensions
    {
        public static double Convert(this double value, UnitToolsInductanceUnit from, UnitToolsInductanceUnit to)
        {
            return UnitToolsInductance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsInductanceUnit from, UnitToolsInductanceUnit to)
        {
            return (float)UnitToolsInductance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsInductanceUnit from, UnitToolsInductanceUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsInductanceUnit from, UnitToolsInductanceUnit to)
        {
            return UnitToolsInductance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsInductanceUnit from, UnitToolsInductanceUnit to)
        {
            return UnitToolsInductance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsInductanceUnit from, UnitToolsInductanceUnit to)
        {
            return UnitToolsInductance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsInductanceUnit from, UnitToolsInductanceUnit to)
        {
            return UnitToolsInductance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsInductanceUnit from, UnitToolsInductanceUnit to)
        {
            return UnitToolsInductance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsInductanceUnit from, UnitToolsInductanceUnit to)
        {
            return UnitToolsInductance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsInductanceUnit from, UnitToolsInductanceUnit to)
        {
            return UnitToolsInductance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsInductanceUnit from, UnitToolsInductanceUnit to)
        {
            return UnitToolsInductance.Convert(value, from, to);
        }
    }
}
