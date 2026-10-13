namespace UnitTools.Impulse
{
    /// <summary>
    /// Extension-method API for Impulse conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsImpulseExtensions
    {
        public static double Convert(this double value, UnitToolsImpulseUnit from, UnitToolsImpulseUnit to)
        {
            return UnitToolsImpulse.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsImpulseUnit from, UnitToolsImpulseUnit to)
        {
            return (float)UnitToolsImpulse.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsImpulseUnit from, UnitToolsImpulseUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsImpulseUnit from, UnitToolsImpulseUnit to)
        {
            return UnitToolsImpulse.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsImpulseUnit from, UnitToolsImpulseUnit to)
        {
            return UnitToolsImpulse.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsImpulseUnit from, UnitToolsImpulseUnit to)
        {
            return UnitToolsImpulse.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsImpulseUnit from, UnitToolsImpulseUnit to)
        {
            return UnitToolsImpulse.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsImpulseUnit from, UnitToolsImpulseUnit to)
        {
            return UnitToolsImpulse.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsImpulseUnit from, UnitToolsImpulseUnit to)
        {
            return UnitToolsImpulse.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsImpulseUnit from, UnitToolsImpulseUnit to)
        {
            return UnitToolsImpulse.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsImpulseUnit from, UnitToolsImpulseUnit to)
        {
            return UnitToolsImpulse.Convert(value, from, to);
        }
    }
}
