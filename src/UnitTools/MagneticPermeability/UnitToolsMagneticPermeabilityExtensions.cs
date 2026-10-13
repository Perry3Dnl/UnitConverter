namespace UnitTools.MagneticPermeability
{
    /// <summary>
    /// Extension-method API for Magnetic Permeability conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsMagneticPermeabilityExtensions
    {
        public static double Convert(this double value, UnitToolsMagneticPermeabilityUnit from, UnitToolsMagneticPermeabilityUnit to)
        {
            return UnitToolsMagneticPermeability.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsMagneticPermeabilityUnit from, UnitToolsMagneticPermeabilityUnit to)
        {
            return (float)UnitToolsMagneticPermeability.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsMagneticPermeabilityUnit from, UnitToolsMagneticPermeabilityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsMagneticPermeabilityUnit from, UnitToolsMagneticPermeabilityUnit to)
        {
            return UnitToolsMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsMagneticPermeabilityUnit from, UnitToolsMagneticPermeabilityUnit to)
        {
            return UnitToolsMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsMagneticPermeabilityUnit from, UnitToolsMagneticPermeabilityUnit to)
        {
            return UnitToolsMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsMagneticPermeabilityUnit from, UnitToolsMagneticPermeabilityUnit to)
        {
            return UnitToolsMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsMagneticPermeabilityUnit from, UnitToolsMagneticPermeabilityUnit to)
        {
            return UnitToolsMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsMagneticPermeabilityUnit from, UnitToolsMagneticPermeabilityUnit to)
        {
            return UnitToolsMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsMagneticPermeabilityUnit from, UnitToolsMagneticPermeabilityUnit to)
        {
            return UnitToolsMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsMagneticPermeabilityUnit from, UnitToolsMagneticPermeabilityUnit to)
        {
            return UnitToolsMagneticPermeability.Convert(value, from, to);
        }
    }
}
