namespace UnitConverter.ElectricResistance
{
    /// <summary>
    /// Extension-method API for Electric Resistance conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterElectricResistanceExtensions
    {
        public static double Convert(this double value, UnitConverterElectricResistanceUnit from, UnitConverterElectricResistanceUnit to)
        {
            return UnitConverterElectricResistance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterElectricResistanceUnit from, UnitConverterElectricResistanceUnit to)
        {
            return (float)UnitConverterElectricResistance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterElectricResistanceUnit from, UnitConverterElectricResistanceUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterElectricResistanceUnit from, UnitConverterElectricResistanceUnit to)
        {
            return UnitConverterElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterElectricResistanceUnit from, UnitConverterElectricResistanceUnit to)
        {
            return UnitConverterElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterElectricResistanceUnit from, UnitConverterElectricResistanceUnit to)
        {
            return UnitConverterElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterElectricResistanceUnit from, UnitConverterElectricResistanceUnit to)
        {
            return UnitConverterElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterElectricResistanceUnit from, UnitConverterElectricResistanceUnit to)
        {
            return UnitConverterElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterElectricResistanceUnit from, UnitConverterElectricResistanceUnit to)
        {
            return UnitConverterElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterElectricResistanceUnit from, UnitConverterElectricResistanceUnit to)
        {
            return UnitConverterElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterElectricResistanceUnit from, UnitConverterElectricResistanceUnit to)
        {
            return UnitConverterElectricResistance.Convert(value, from, to);
        }
    }
}
