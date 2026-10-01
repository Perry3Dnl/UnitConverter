namespace RealisticPhysics.UnitConversion.Radioactivity
{
    /// <summary>
    /// Extension-method API for Radioactivity conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterRadioactivityExtensions
    {
        public static double Convert(this double value, UnitConverterRadioactivityUnit from, UnitConverterRadioactivityUnit to)
        {
            return UnitConverterRadioactivity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterRadioactivityUnit from, UnitConverterRadioactivityUnit to)
        {
            return (float)UnitConverterRadioactivity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterRadioactivityUnit from, UnitConverterRadioactivityUnit to)
        {
            return (decimal)UnitConverterRadioactivity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterRadioactivityUnit from, UnitConverterRadioactivityUnit to)
        {
            return UnitConverterRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterRadioactivityUnit from, UnitConverterRadioactivityUnit to)
        {
            return UnitConverterRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterRadioactivityUnit from, UnitConverterRadioactivityUnit to)
        {
            return UnitConverterRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterRadioactivityUnit from, UnitConverterRadioactivityUnit to)
        {
            return UnitConverterRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterRadioactivityUnit from, UnitConverterRadioactivityUnit to)
        {
            return UnitConverterRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterRadioactivityUnit from, UnitConverterRadioactivityUnit to)
        {
            return UnitConverterRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterRadioactivityUnit from, UnitConverterRadioactivityUnit to)
        {
            return UnitConverterRadioactivity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterRadioactivityUnit from, UnitConverterRadioactivityUnit to)
        {
            return UnitConverterRadioactivity.Convert(value, from, to);
        }
    }
}
