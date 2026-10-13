namespace UnitTools.Frequency
{
    /// <summary>
    /// Extension-method API for Frequency conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsFrequencyExtensions
    {
        public static double Convert(this double value, UnitToolsFrequencyUnit from, UnitToolsFrequencyUnit to)
        {
            return UnitToolsFrequency.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsFrequencyUnit from, UnitToolsFrequencyUnit to)
        {
            return (float)UnitToolsFrequency.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsFrequencyUnit from, UnitToolsFrequencyUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsFrequencyUnit from, UnitToolsFrequencyUnit to)
        {
            return UnitToolsFrequency.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsFrequencyUnit from, UnitToolsFrequencyUnit to)
        {
            return UnitToolsFrequency.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsFrequencyUnit from, UnitToolsFrequencyUnit to)
        {
            return UnitToolsFrequency.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsFrequencyUnit from, UnitToolsFrequencyUnit to)
        {
            return UnitToolsFrequency.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsFrequencyUnit from, UnitToolsFrequencyUnit to)
        {
            return UnitToolsFrequency.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsFrequencyUnit from, UnitToolsFrequencyUnit to)
        {
            return UnitToolsFrequency.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsFrequencyUnit from, UnitToolsFrequencyUnit to)
        {
            return UnitToolsFrequency.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsFrequencyUnit from, UnitToolsFrequencyUnit to)
        {
            return UnitToolsFrequency.Convert(value, from, to);
        }
    }
}
