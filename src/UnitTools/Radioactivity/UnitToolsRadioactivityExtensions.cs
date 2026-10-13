namespace UnitTools.Radioactivity
{
    /// <summary>
    /// Extension-method API for Radioactivity conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsRadioactivityExtensions
    {
        public static double Convert(this double value, UnitToolsRadioactivityUnit from, UnitToolsRadioactivityUnit to)
        {
            return UnitToolsRadioactivity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsRadioactivityUnit from, UnitToolsRadioactivityUnit to)
        {
            return (float)UnitToolsRadioactivity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsRadioactivityUnit from, UnitToolsRadioactivityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsRadioactivityUnit from, UnitToolsRadioactivityUnit to)
        {
            return UnitToolsRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsRadioactivityUnit from, UnitToolsRadioactivityUnit to)
        {
            return UnitToolsRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsRadioactivityUnit from, UnitToolsRadioactivityUnit to)
        {
            return UnitToolsRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsRadioactivityUnit from, UnitToolsRadioactivityUnit to)
        {
            return UnitToolsRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsRadioactivityUnit from, UnitToolsRadioactivityUnit to)
        {
            return UnitToolsRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsRadioactivityUnit from, UnitToolsRadioactivityUnit to)
        {
            return UnitToolsRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsRadioactivityUnit from, UnitToolsRadioactivityUnit to)
        {
            return UnitToolsRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsRadioactivityUnit from, UnitToolsRadioactivityUnit to)
        {
            return UnitToolsRadioactivity.Convert(value, from, to);
        }
    }
}
