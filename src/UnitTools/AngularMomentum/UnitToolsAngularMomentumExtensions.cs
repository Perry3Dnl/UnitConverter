namespace UnitTools.AngularMomentum
{
    /// <summary>
    /// Extension-method API for Angular Momentum conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsAngularMomentumExtensions
    {
        public static double Convert(this double value, UnitToolsAngularMomentumUnit from, UnitToolsAngularMomentumUnit to)
        {
            return UnitToolsAngularMomentum.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsAngularMomentumUnit from, UnitToolsAngularMomentumUnit to)
        {
            return (float)UnitToolsAngularMomentum.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsAngularMomentumUnit from, UnitToolsAngularMomentumUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsAngularMomentumUnit from, UnitToolsAngularMomentumUnit to)
        {
            return UnitToolsAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsAngularMomentumUnit from, UnitToolsAngularMomentumUnit to)
        {
            return UnitToolsAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsAngularMomentumUnit from, UnitToolsAngularMomentumUnit to)
        {
            return UnitToolsAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsAngularMomentumUnit from, UnitToolsAngularMomentumUnit to)
        {
            return UnitToolsAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsAngularMomentumUnit from, UnitToolsAngularMomentumUnit to)
        {
            return UnitToolsAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsAngularMomentumUnit from, UnitToolsAngularMomentumUnit to)
        {
            return UnitToolsAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsAngularMomentumUnit from, UnitToolsAngularMomentumUnit to)
        {
            return UnitToolsAngularMomentum.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsAngularMomentumUnit from, UnitToolsAngularMomentumUnit to)
        {
            return UnitToolsAngularMomentum.Convert(value, from, to);
        }
    }
}
