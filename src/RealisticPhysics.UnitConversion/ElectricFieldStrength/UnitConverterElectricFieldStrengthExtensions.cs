namespace RealisticPhysics.UnitConversion.ElectricFieldStrength
{
    /// <summary>
    /// Extension-method API for Electric Field Strength conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterElectricFieldStrengthExtensions
    {
        public static double Convert(this double value, UnitConverterElectricFieldStrengthUnit from, UnitConverterElectricFieldStrengthUnit to)
        {
            return UnitConverterElectricFieldStrength.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterElectricFieldStrengthUnit from, UnitConverterElectricFieldStrengthUnit to)
        {
            return (float)UnitConverterElectricFieldStrength.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterElectricFieldStrengthUnit from, UnitConverterElectricFieldStrengthUnit to)
        {
            return (decimal)UnitConverterElectricFieldStrength.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterElectricFieldStrengthUnit from, UnitConverterElectricFieldStrengthUnit to)
        {
            return UnitConverterElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterElectricFieldStrengthUnit from, UnitConverterElectricFieldStrengthUnit to)
        {
            return UnitConverterElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterElectricFieldStrengthUnit from, UnitConverterElectricFieldStrengthUnit to)
        {
            return UnitConverterElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterElectricFieldStrengthUnit from, UnitConverterElectricFieldStrengthUnit to)
        {
            return UnitConverterElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterElectricFieldStrengthUnit from, UnitConverterElectricFieldStrengthUnit to)
        {
            return UnitConverterElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterElectricFieldStrengthUnit from, UnitConverterElectricFieldStrengthUnit to)
        {
            return UnitConverterElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterElectricFieldStrengthUnit from, UnitConverterElectricFieldStrengthUnit to)
        {
            return UnitConverterElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterElectricFieldStrengthUnit from, UnitConverterElectricFieldStrengthUnit to)
        {
            return UnitConverterElectricFieldStrength.Convert(value, from, to);
        }
    }
}
