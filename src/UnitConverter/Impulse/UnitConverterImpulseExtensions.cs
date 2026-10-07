namespace UnitConverter.Impulse
{
    /// <summary>
    /// Extension-method API for Impulse conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterImpulseExtensions
    {
        public static double Convert(this double value, UnitConverterImpulseUnit from, UnitConverterImpulseUnit to)
        {
            return UnitConverterImpulse.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterImpulseUnit from, UnitConverterImpulseUnit to)
        {
            return (float)UnitConverterImpulse.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterImpulseUnit from, UnitConverterImpulseUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterImpulseUnit from, UnitConverterImpulseUnit to)
        {
            return UnitConverterImpulse.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterImpulseUnit from, UnitConverterImpulseUnit to)
        {
            return UnitConverterImpulse.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterImpulseUnit from, UnitConverterImpulseUnit to)
        {
            return UnitConverterImpulse.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterImpulseUnit from, UnitConverterImpulseUnit to)
        {
            return UnitConverterImpulse.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterImpulseUnit from, UnitConverterImpulseUnit to)
        {
            return UnitConverterImpulse.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterImpulseUnit from, UnitConverterImpulseUnit to)
        {
            return UnitConverterImpulse.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterImpulseUnit from, UnitConverterImpulseUnit to)
        {
            return UnitConverterImpulse.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterImpulseUnit from, UnitConverterImpulseUnit to)
        {
            return UnitConverterImpulse.Convert(value, from, to);
        }
    }
}
