namespace UnitTools.AngularAcceleration
{
    /// <summary>
    /// Extension-method API for Angular Acceleration conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsAngularAccelerationExtensions
    {
        public static double Convert(this double value, UnitToolsAngularAccelerationUnit from, UnitToolsAngularAccelerationUnit to)
        {
            return UnitToolsAngularAcceleration.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsAngularAccelerationUnit from, UnitToolsAngularAccelerationUnit to)
        {
            return (float)UnitToolsAngularAcceleration.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsAngularAccelerationUnit from, UnitToolsAngularAccelerationUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsAngularAccelerationUnit from, UnitToolsAngularAccelerationUnit to)
        {
            return UnitToolsAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsAngularAccelerationUnit from, UnitToolsAngularAccelerationUnit to)
        {
            return UnitToolsAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsAngularAccelerationUnit from, UnitToolsAngularAccelerationUnit to)
        {
            return UnitToolsAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsAngularAccelerationUnit from, UnitToolsAngularAccelerationUnit to)
        {
            return UnitToolsAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsAngularAccelerationUnit from, UnitToolsAngularAccelerationUnit to)
        {
            return UnitToolsAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsAngularAccelerationUnit from, UnitToolsAngularAccelerationUnit to)
        {
            return UnitToolsAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsAngularAccelerationUnit from, UnitToolsAngularAccelerationUnit to)
        {
            return UnitToolsAngularAcceleration.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsAngularAccelerationUnit from, UnitToolsAngularAccelerationUnit to)
        {
            return UnitToolsAngularAcceleration.Convert(value, from, to);
        }
    }
}
