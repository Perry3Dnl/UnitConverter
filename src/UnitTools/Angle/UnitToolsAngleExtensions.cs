namespace UnitTools.Angle
{
    /// <summary>
    /// Extension-method API for Angle conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsAngleExtensions
    {
        public static double Convert(this double value, UnitToolsAngleUnit from, UnitToolsAngleUnit to)
        {
            return UnitToolsAngle.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsAngleUnit from, UnitToolsAngleUnit to)
        {
            return (float)UnitToolsAngle.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsAngleUnit from, UnitToolsAngleUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsAngleUnit from, UnitToolsAngleUnit to)
        {
            return UnitToolsAngle.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsAngleUnit from, UnitToolsAngleUnit to)
        {
            return UnitToolsAngle.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsAngleUnit from, UnitToolsAngleUnit to)
        {
            return UnitToolsAngle.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsAngleUnit from, UnitToolsAngleUnit to)
        {
            return UnitToolsAngle.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsAngleUnit from, UnitToolsAngleUnit to)
        {
            return UnitToolsAngle.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsAngleUnit from, UnitToolsAngleUnit to)
        {
            return UnitToolsAngle.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsAngleUnit from, UnitToolsAngleUnit to)
        {
            return UnitToolsAngle.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsAngleUnit from, UnitToolsAngleUnit to)
        {
            return UnitToolsAngle.Convert(value, from, to);
        }
    }
}
