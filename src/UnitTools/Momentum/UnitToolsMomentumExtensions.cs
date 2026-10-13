namespace UnitTools.Momentum
{
    /// <summary>
    /// Extension-method API for Momentum conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsMomentumExtensions
    {
        public static double Convert(this double value, UnitToolsMomentumUnit from, UnitToolsMomentumUnit to)
        {
            return UnitToolsMomentum.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsMomentumUnit from, UnitToolsMomentumUnit to)
        {
            return (float)UnitToolsMomentum.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsMomentumUnit from, UnitToolsMomentumUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsMomentumUnit from, UnitToolsMomentumUnit to)
        {
            return UnitToolsMomentum.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsMomentumUnit from, UnitToolsMomentumUnit to)
        {
            return UnitToolsMomentum.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsMomentumUnit from, UnitToolsMomentumUnit to)
        {
            return UnitToolsMomentum.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsMomentumUnit from, UnitToolsMomentumUnit to)
        {
            return UnitToolsMomentum.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsMomentumUnit from, UnitToolsMomentumUnit to)
        {
            return UnitToolsMomentum.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsMomentumUnit from, UnitToolsMomentumUnit to)
        {
            return UnitToolsMomentum.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsMomentumUnit from, UnitToolsMomentumUnit to)
        {
            return UnitToolsMomentum.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsMomentumUnit from, UnitToolsMomentumUnit to)
        {
            return UnitToolsMomentum.Convert(value, from, to);
        }
    }
}
