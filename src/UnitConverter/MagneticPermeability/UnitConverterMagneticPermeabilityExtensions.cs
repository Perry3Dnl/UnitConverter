namespace UnitConverter.MagneticPermeability
{
    /// <summary>
    /// Extension-method API for Magnetic Permeability conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterMagneticPermeabilityExtensions
    {
        public static double Convert(this double value, UnitConverterMagneticPermeabilityUnit from, UnitConverterMagneticPermeabilityUnit to)
        {
            return UnitConverterMagneticPermeability.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterMagneticPermeabilityUnit from, UnitConverterMagneticPermeabilityUnit to)
        {
            return (float)UnitConverterMagneticPermeability.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterMagneticPermeabilityUnit from, UnitConverterMagneticPermeabilityUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterMagneticPermeabilityUnit from, UnitConverterMagneticPermeabilityUnit to)
        {
            return UnitConverterMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterMagneticPermeabilityUnit from, UnitConverterMagneticPermeabilityUnit to)
        {
            return UnitConverterMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterMagneticPermeabilityUnit from, UnitConverterMagneticPermeabilityUnit to)
        {
            return UnitConverterMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterMagneticPermeabilityUnit from, UnitConverterMagneticPermeabilityUnit to)
        {
            return UnitConverterMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterMagneticPermeabilityUnit from, UnitConverterMagneticPermeabilityUnit to)
        {
            return UnitConverterMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterMagneticPermeabilityUnit from, UnitConverterMagneticPermeabilityUnit to)
        {
            return UnitConverterMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterMagneticPermeabilityUnit from, UnitConverterMagneticPermeabilityUnit to)
        {
            return UnitConverterMagneticPermeability.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterMagneticPermeabilityUnit from, UnitConverterMagneticPermeabilityUnit to)
        {
            return UnitConverterMagneticPermeability.Convert(value, from, to);
        }
    }
}
