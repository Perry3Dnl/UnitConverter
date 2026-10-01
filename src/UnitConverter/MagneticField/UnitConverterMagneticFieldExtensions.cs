namespace UnitConverter.MagneticField
{
    /// <summary>
    /// Extension-method API for Magnetic Field conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterMagneticFieldExtensions
    {
        public static double Convert(this double value, UnitConverterMagneticFieldUnit from, UnitConverterMagneticFieldUnit to)
        {
            return UnitConverterMagneticField.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterMagneticFieldUnit from, UnitConverterMagneticFieldUnit to)
        {
            return (float)UnitConverterMagneticField.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterMagneticFieldUnit from, UnitConverterMagneticFieldUnit to)
        {
            return (decimal)UnitConverterMagneticField.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterMagneticFieldUnit from, UnitConverterMagneticFieldUnit to)
        {
            return UnitConverterMagneticField.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterMagneticFieldUnit from, UnitConverterMagneticFieldUnit to)
        {
            return UnitConverterMagneticField.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterMagneticFieldUnit from, UnitConverterMagneticFieldUnit to)
        {
            return UnitConverterMagneticField.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterMagneticFieldUnit from, UnitConverterMagneticFieldUnit to)
        {
            return UnitConverterMagneticField.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterMagneticFieldUnit from, UnitConverterMagneticFieldUnit to)
        {
            return UnitConverterMagneticField.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterMagneticFieldUnit from, UnitConverterMagneticFieldUnit to)
        {
            return UnitConverterMagneticField.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterMagneticFieldUnit from, UnitConverterMagneticFieldUnit to)
        {
            return UnitConverterMagneticField.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterMagneticFieldUnit from, UnitConverterMagneticFieldUnit to)
        {
            return UnitConverterMagneticField.Convert(value, from, to);
        }
    }
}
