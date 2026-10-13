namespace UnitTools.ElectricResistance
{
    /// <summary>
    /// Extension-method API for Electric Resistance conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsElectricResistanceExtensions
    {
        public static double Convert(this double value, UnitToolsElectricResistanceUnit from, UnitToolsElectricResistanceUnit to)
        {
            return UnitToolsElectricResistance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsElectricResistanceUnit from, UnitToolsElectricResistanceUnit to)
        {
            return (float)UnitToolsElectricResistance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsElectricResistanceUnit from, UnitToolsElectricResistanceUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsElectricResistanceUnit from, UnitToolsElectricResistanceUnit to)
        {
            return UnitToolsElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsElectricResistanceUnit from, UnitToolsElectricResistanceUnit to)
        {
            return UnitToolsElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsElectricResistanceUnit from, UnitToolsElectricResistanceUnit to)
        {
            return UnitToolsElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsElectricResistanceUnit from, UnitToolsElectricResistanceUnit to)
        {
            return UnitToolsElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsElectricResistanceUnit from, UnitToolsElectricResistanceUnit to)
        {
            return UnitToolsElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsElectricResistanceUnit from, UnitToolsElectricResistanceUnit to)
        {
            return UnitToolsElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsElectricResistanceUnit from, UnitToolsElectricResistanceUnit to)
        {
            return UnitToolsElectricResistance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsElectricResistanceUnit from, UnitToolsElectricResistanceUnit to)
        {
            return UnitToolsElectricResistance.Convert(value, from, to);
        }
    }
}
