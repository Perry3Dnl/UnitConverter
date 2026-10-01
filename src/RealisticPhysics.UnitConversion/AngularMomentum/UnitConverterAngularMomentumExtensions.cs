namespace RealisticPhysics.UnitConversion.AngularMomentum
{
    /// <summary>
    /// Extension-method API for Angular Momentum conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterAngularMomentumExtensions
    {
        public static double Convert(this double value, UnitConverterAngularMomentumUnit from, UnitConverterAngularMomentumUnit to)
        {
            return UnitConverterAngularMomentum.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterAngularMomentumUnit from, UnitConverterAngularMomentumUnit to)
        {
            return (float)UnitConverterAngularMomentum.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterAngularMomentumUnit from, UnitConverterAngularMomentumUnit to)
        {
            return (decimal)UnitConverterAngularMomentum.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterAngularMomentumUnit from, UnitConverterAngularMomentumUnit to)
        {
            return UnitConverterAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterAngularMomentumUnit from, UnitConverterAngularMomentumUnit to)
        {
            return UnitConverterAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterAngularMomentumUnit from, UnitConverterAngularMomentumUnit to)
        {
            return UnitConverterAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterAngularMomentumUnit from, UnitConverterAngularMomentumUnit to)
        {
            return UnitConverterAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterAngularMomentumUnit from, UnitConverterAngularMomentumUnit to)
        {
            return UnitConverterAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterAngularMomentumUnit from, UnitConverterAngularMomentumUnit to)
        {
            return UnitConverterAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterAngularMomentumUnit from, UnitConverterAngularMomentumUnit to)
        {
            return UnitConverterAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterAngularMomentumUnit from, UnitConverterAngularMomentumUnit to)
        {
            return UnitConverterAngularMomentum.Convert(value, from, to);
        }
    }
}
