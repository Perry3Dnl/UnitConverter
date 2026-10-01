namespace UnitConverter.AngularVelocity
{
    /// <summary>
    /// Extension-method API for Angular Velocity conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterAngularVelocityExtensions
    {
        public static double Convert(this double value, UnitConverterAngularVelocityUnit from, UnitConverterAngularVelocityUnit to)
        {
            return UnitConverterAngularVelocity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterAngularVelocityUnit from, UnitConverterAngularVelocityUnit to)
        {
            return (float)UnitConverterAngularVelocity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterAngularVelocityUnit from, UnitConverterAngularVelocityUnit to)
        {
            return (decimal)UnitConverterAngularVelocity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterAngularVelocityUnit from, UnitConverterAngularVelocityUnit to)
        {
            return UnitConverterAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterAngularVelocityUnit from, UnitConverterAngularVelocityUnit to)
        {
            return UnitConverterAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterAngularVelocityUnit from, UnitConverterAngularVelocityUnit to)
        {
            return UnitConverterAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterAngularVelocityUnit from, UnitConverterAngularVelocityUnit to)
        {
            return UnitConverterAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterAngularVelocityUnit from, UnitConverterAngularVelocityUnit to)
        {
            return UnitConverterAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterAngularVelocityUnit from, UnitConverterAngularVelocityUnit to)
        {
            return UnitConverterAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterAngularVelocityUnit from, UnitConverterAngularVelocityUnit to)
        {
            return UnitConverterAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterAngularVelocityUnit from, UnitConverterAngularVelocityUnit to)
        {
            return UnitConverterAngularVelocity.Convert(value, from, to);
        }
    }
}
