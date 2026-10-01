namespace RealisticPhysics.UnitConversion.MagnetizingFieldStrength
{
    /// <summary>
    /// Extension-method API for Magnetizing Field Strength conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterMagnetizingFieldStrengthExtensions
    {
        public static double Convert(this double value, UnitConverterMagnetizingFieldStrengthUnit from, UnitConverterMagnetizingFieldStrengthUnit to)
        {
            return UnitConverterMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterMagnetizingFieldStrengthUnit from, UnitConverterMagnetizingFieldStrengthUnit to)
        {
            return (float)UnitConverterMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterMagnetizingFieldStrengthUnit from, UnitConverterMagnetizingFieldStrengthUnit to)
        {
            return (decimal)UnitConverterMagnetizingFieldStrength.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterMagnetizingFieldStrengthUnit from, UnitConverterMagnetizingFieldStrengthUnit to)
        {
            return UnitConverterMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterMagnetizingFieldStrengthUnit from, UnitConverterMagnetizingFieldStrengthUnit to)
        {
            return UnitConverterMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterMagnetizingFieldStrengthUnit from, UnitConverterMagnetizingFieldStrengthUnit to)
        {
            return UnitConverterMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterMagnetizingFieldStrengthUnit from, UnitConverterMagnetizingFieldStrengthUnit to)
        {
            return UnitConverterMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterMagnetizingFieldStrengthUnit from, UnitConverterMagnetizingFieldStrengthUnit to)
        {
            return UnitConverterMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterMagnetizingFieldStrengthUnit from, UnitConverterMagnetizingFieldStrengthUnit to)
        {
            return UnitConverterMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterMagnetizingFieldStrengthUnit from, UnitConverterMagnetizingFieldStrengthUnit to)
        {
            return UnitConverterMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterMagnetizingFieldStrengthUnit from, UnitConverterMagnetizingFieldStrengthUnit to)
        {
            return UnitConverterMagnetizingFieldStrength.Convert(value, from, to);
        }
    }
}
