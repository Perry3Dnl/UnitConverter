namespace UnitTools.AngularVelocity
{
    /// <summary>
    /// Extension-method API for Angular Velocity conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsAngularVelocityExtensions
    {
        public static double Convert(this double value, UnitToolsAngularVelocityUnit from, UnitToolsAngularVelocityUnit to)
        {
            return UnitToolsAngularVelocity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsAngularVelocityUnit from, UnitToolsAngularVelocityUnit to)
        {
            return (float)UnitToolsAngularVelocity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsAngularVelocityUnit from, UnitToolsAngularVelocityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsAngularVelocityUnit from, UnitToolsAngularVelocityUnit to)
        {
            return UnitToolsAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsAngularVelocityUnit from, UnitToolsAngularVelocityUnit to)
        {
            return UnitToolsAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsAngularVelocityUnit from, UnitToolsAngularVelocityUnit to)
        {
            return UnitToolsAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsAngularVelocityUnit from, UnitToolsAngularVelocityUnit to)
        {
            return UnitToolsAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsAngularVelocityUnit from, UnitToolsAngularVelocityUnit to)
        {
            return UnitToolsAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsAngularVelocityUnit from, UnitToolsAngularVelocityUnit to)
        {
            return UnitToolsAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsAngularVelocityUnit from, UnitToolsAngularVelocityUnit to)
        {
            return UnitToolsAngularVelocity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsAngularVelocityUnit from, UnitToolsAngularVelocityUnit to)
        {
            return UnitToolsAngularVelocity.Convert(value, from, to);
        }
    }
}
