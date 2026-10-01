namespace RealisticPhysics.UnitConversion.AngularAcceleration
{
    /// <summary>
    /// Extension-method API for Angular Acceleration conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterAngularAccelerationExtensions
    {
        public static double Convert(this double value, UnitConverterAngularAccelerationUnit from, UnitConverterAngularAccelerationUnit to)
        {
            return UnitConverterAngularAcceleration.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterAngularAccelerationUnit from, UnitConverterAngularAccelerationUnit to)
        {
            return (float)UnitConverterAngularAcceleration.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterAngularAccelerationUnit from, UnitConverterAngularAccelerationUnit to)
        {
            return (decimal)UnitConverterAngularAcceleration.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterAngularAccelerationUnit from, UnitConverterAngularAccelerationUnit to)
        {
            return UnitConverterAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterAngularAccelerationUnit from, UnitConverterAngularAccelerationUnit to)
        {
            return UnitConverterAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterAngularAccelerationUnit from, UnitConverterAngularAccelerationUnit to)
        {
            return UnitConverterAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterAngularAccelerationUnit from, UnitConverterAngularAccelerationUnit to)
        {
            return UnitConverterAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterAngularAccelerationUnit from, UnitConverterAngularAccelerationUnit to)
        {
            return UnitConverterAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterAngularAccelerationUnit from, UnitConverterAngularAccelerationUnit to)
        {
            return UnitConverterAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterAngularAccelerationUnit from, UnitConverterAngularAccelerationUnit to)
        {
            return UnitConverterAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterAngularAccelerationUnit from, UnitConverterAngularAccelerationUnit to)
        {
            return UnitConverterAngularAcceleration.Convert(value, from, to);
        }
    }
}
