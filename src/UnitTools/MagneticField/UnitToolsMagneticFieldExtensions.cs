namespace UnitTools.MagneticField
{
    /// <summary>
    /// Extension-method API for Magnetic Field conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsMagneticFieldExtensions
    {
        public static double Convert(this double value, UnitToolsMagneticFieldUnit from, UnitToolsMagneticFieldUnit to)
        {
            return UnitToolsMagneticField.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsMagneticFieldUnit from, UnitToolsMagneticFieldUnit to)
        {
            return (float)UnitToolsMagneticField.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsMagneticFieldUnit from, UnitToolsMagneticFieldUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsMagneticFieldUnit from, UnitToolsMagneticFieldUnit to)
        {
            return UnitToolsMagneticField.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsMagneticFieldUnit from, UnitToolsMagneticFieldUnit to)
        {
            return UnitToolsMagneticField.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsMagneticFieldUnit from, UnitToolsMagneticFieldUnit to)
        {
            return UnitToolsMagneticField.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsMagneticFieldUnit from, UnitToolsMagneticFieldUnit to)
        {
            return UnitToolsMagneticField.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsMagneticFieldUnit from, UnitToolsMagneticFieldUnit to)
        {
            return UnitToolsMagneticField.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsMagneticFieldUnit from, UnitToolsMagneticFieldUnit to)
        {
            return UnitToolsMagneticField.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsMagneticFieldUnit from, UnitToolsMagneticFieldUnit to)
        {
            return UnitToolsMagneticField.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsMagneticFieldUnit from, UnitToolsMagneticFieldUnit to)
        {
            return UnitToolsMagneticField.Convert(value, from, to);
        }
    }
}
