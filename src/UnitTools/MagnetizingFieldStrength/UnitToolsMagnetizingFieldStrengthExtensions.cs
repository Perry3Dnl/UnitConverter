namespace UnitTools.MagnetizingFieldStrength
{
    /// <summary>
    /// Extension-method API for Magnetizing Field Strength conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsMagnetizingFieldStrengthExtensions
    {
        public static double Convert(this double value, UnitToolsMagnetizingFieldStrengthUnit from, UnitToolsMagnetizingFieldStrengthUnit to)
        {
            return UnitToolsMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsMagnetizingFieldStrengthUnit from, UnitToolsMagnetizingFieldStrengthUnit to)
        {
            return (float)UnitToolsMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsMagnetizingFieldStrengthUnit from, UnitToolsMagnetizingFieldStrengthUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsMagnetizingFieldStrengthUnit from, UnitToolsMagnetizingFieldStrengthUnit to)
        {
            return UnitToolsMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsMagnetizingFieldStrengthUnit from, UnitToolsMagnetizingFieldStrengthUnit to)
        {
            return UnitToolsMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsMagnetizingFieldStrengthUnit from, UnitToolsMagnetizingFieldStrengthUnit to)
        {
            return UnitToolsMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsMagnetizingFieldStrengthUnit from, UnitToolsMagnetizingFieldStrengthUnit to)
        {
            return UnitToolsMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsMagnetizingFieldStrengthUnit from, UnitToolsMagnetizingFieldStrengthUnit to)
        {
            return UnitToolsMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsMagnetizingFieldStrengthUnit from, UnitToolsMagnetizingFieldStrengthUnit to)
        {
            return UnitToolsMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsMagnetizingFieldStrengthUnit from, UnitToolsMagnetizingFieldStrengthUnit to)
        {
            return UnitToolsMagnetizingFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsMagnetizingFieldStrengthUnit from, UnitToolsMagnetizingFieldStrengthUnit to)
        {
            return UnitToolsMagnetizingFieldStrength.Convert(value, from, to);
        }
    }
}
