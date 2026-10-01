namespace RealisticPhysics.UnitConversion.PressureGradient
{
    /// <summary>
    /// Extension-method API for Pressure Gradient conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterPressureGradientExtensions
    {
        public static double Convert(this double value, UnitConverterPressureGradientUnit from, UnitConverterPressureGradientUnit to)
        {
            return UnitConverterPressureGradient.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterPressureGradientUnit from, UnitConverterPressureGradientUnit to)
        {
            return (float)UnitConverterPressureGradient.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterPressureGradientUnit from, UnitConverterPressureGradientUnit to)
        {
            return (decimal)UnitConverterPressureGradient.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterPressureGradientUnit from, UnitConverterPressureGradientUnit to)
        {
            return UnitConverterPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterPressureGradientUnit from, UnitConverterPressureGradientUnit to)
        {
            return UnitConverterPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterPressureGradientUnit from, UnitConverterPressureGradientUnit to)
        {
            return UnitConverterPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterPressureGradientUnit from, UnitConverterPressureGradientUnit to)
        {
            return UnitConverterPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterPressureGradientUnit from, UnitConverterPressureGradientUnit to)
        {
            return UnitConverterPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterPressureGradientUnit from, UnitConverterPressureGradientUnit to)
        {
            return UnitConverterPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterPressureGradientUnit from, UnitConverterPressureGradientUnit to)
        {
            return UnitConverterPressureGradient.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterPressureGradientUnit from, UnitConverterPressureGradientUnit to)
        {
            return UnitConverterPressureGradient.Convert(value, from, to);
        }
    }
}
