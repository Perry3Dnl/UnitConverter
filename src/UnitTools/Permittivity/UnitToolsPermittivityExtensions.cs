namespace UnitTools.Permittivity
{
    /// <summary>
    /// Extension-method API for Permittivity conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsPermittivityExtensions
    {
        public static double Convert(this double value, UnitToolsPermittivityUnit from, UnitToolsPermittivityUnit to)
        {
            return UnitToolsPermittivity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsPermittivityUnit from, UnitToolsPermittivityUnit to)
        {
            return (float)UnitToolsPermittivity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsPermittivityUnit from, UnitToolsPermittivityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsPermittivityUnit from, UnitToolsPermittivityUnit to)
        {
            return UnitToolsPermittivity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsPermittivityUnit from, UnitToolsPermittivityUnit to)
        {
            return UnitToolsPermittivity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsPermittivityUnit from, UnitToolsPermittivityUnit to)
        {
            return UnitToolsPermittivity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsPermittivityUnit from, UnitToolsPermittivityUnit to)
        {
            return UnitToolsPermittivity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsPermittivityUnit from, UnitToolsPermittivityUnit to)
        {
            return UnitToolsPermittivity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsPermittivityUnit from, UnitToolsPermittivityUnit to)
        {
            return UnitToolsPermittivity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsPermittivityUnit from, UnitToolsPermittivityUnit to)
        {
            return UnitToolsPermittivity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsPermittivityUnit from, UnitToolsPermittivityUnit to)
        {
            return UnitToolsPermittivity.Convert(value, from, to);
        }
    }
}
