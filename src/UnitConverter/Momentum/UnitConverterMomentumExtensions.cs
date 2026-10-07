namespace UnitConverter.Momentum
{
    /// <summary>
    /// Extension-method API for Momentum conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterMomentumExtensions
    {
        public static double Convert(this double value, UnitConverterMomentumUnit from, UnitConverterMomentumUnit to)
        {
            return UnitConverterMomentum.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterMomentumUnit from, UnitConverterMomentumUnit to)
        {
            return (float)UnitConverterMomentum.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterMomentumUnit from, UnitConverterMomentumUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterMomentumUnit from, UnitConverterMomentumUnit to)
        {
            return UnitConverterMomentum.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterMomentumUnit from, UnitConverterMomentumUnit to)
        {
            return UnitConverterMomentum.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterMomentumUnit from, UnitConverterMomentumUnit to)
        {
            return UnitConverterMomentum.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterMomentumUnit from, UnitConverterMomentumUnit to)
        {
            return UnitConverterMomentum.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterMomentumUnit from, UnitConverterMomentumUnit to)
        {
            return UnitConverterMomentum.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterMomentumUnit from, UnitConverterMomentumUnit to)
        {
            return UnitConverterMomentum.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterMomentumUnit from, UnitConverterMomentumUnit to)
        {
            return UnitConverterMomentum.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterMomentumUnit from, UnitConverterMomentumUnit to)
        {
            return UnitConverterMomentum.Convert(value, from, to);
        }
    }
}
