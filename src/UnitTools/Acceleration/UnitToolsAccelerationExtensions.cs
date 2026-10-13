namespace UnitTools.Acceleration
{
    /// <summary>
    /// Extension-method API for Acceleration conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsAccelerationExtensions
    {
        public static double Convert(this double value, UnitToolsAccelerationUnit from, UnitToolsAccelerationUnit to)
        {
            return UnitToolsAcceleration.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsAccelerationUnit from, UnitToolsAccelerationUnit to)
        {
            return (float)UnitToolsAcceleration.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsAccelerationUnit from, UnitToolsAccelerationUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsAccelerationUnit from, UnitToolsAccelerationUnit to)
        {
            return UnitToolsAcceleration.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsAccelerationUnit from, UnitToolsAccelerationUnit to)
        {
            return UnitToolsAcceleration.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsAccelerationUnit from, UnitToolsAccelerationUnit to)
        {
            return UnitToolsAcceleration.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsAccelerationUnit from, UnitToolsAccelerationUnit to)
        {
            return UnitToolsAcceleration.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsAccelerationUnit from, UnitToolsAccelerationUnit to)
        {
            return UnitToolsAcceleration.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsAccelerationUnit from, UnitToolsAccelerationUnit to)
        {
            return UnitToolsAcceleration.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsAccelerationUnit from, UnitToolsAccelerationUnit to)
        {
            return UnitToolsAcceleration.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsAccelerationUnit from, UnitToolsAccelerationUnit to)
        {
            return UnitToolsAcceleration.Convert(value, from, to);
        }
    }
}
