namespace UnitTools.PressureGradient
{
    /// <summary>
    /// Extension-method API for Pressure Gradient conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsPressureGradientExtensions
    {
        public static double Convert(this double value, UnitToolsPressureGradientUnit from, UnitToolsPressureGradientUnit to)
        {
            return UnitToolsPressureGradient.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsPressureGradientUnit from, UnitToolsPressureGradientUnit to)
        {
            return (float)UnitToolsPressureGradient.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsPressureGradientUnit from, UnitToolsPressureGradientUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsPressureGradientUnit from, UnitToolsPressureGradientUnit to)
        {
            return UnitToolsPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsPressureGradientUnit from, UnitToolsPressureGradientUnit to)
        {
            return UnitToolsPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsPressureGradientUnit from, UnitToolsPressureGradientUnit to)
        {
            return UnitToolsPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsPressureGradientUnit from, UnitToolsPressureGradientUnit to)
        {
            return UnitToolsPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsPressureGradientUnit from, UnitToolsPressureGradientUnit to)
        {
            return UnitToolsPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsPressureGradientUnit from, UnitToolsPressureGradientUnit to)
        {
            return UnitToolsPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsPressureGradientUnit from, UnitToolsPressureGradientUnit to)
        {
            return UnitToolsPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsPressureGradientUnit from, UnitToolsPressureGradientUnit to)
        {
            return UnitToolsPressureGradient.Convert(value, from, to);
        }
    }
}
