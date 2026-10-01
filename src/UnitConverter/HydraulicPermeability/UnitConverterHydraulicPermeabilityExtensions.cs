namespace UnitConverter.HydraulicPermeability
{
    /// <summary>
    /// Extension-method API for Hydraulic Permeability conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterHydraulicPermeabilityExtensions
    {
        public static double Convert(this double value, UnitConverterHydraulicPermeabilityUnit from, UnitConverterHydraulicPermeabilityUnit to)
        {
            return UnitConverterHydraulicPermeability.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterHydraulicPermeabilityUnit from, UnitConverterHydraulicPermeabilityUnit to)
        {
            return (float)UnitConverterHydraulicPermeability.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterHydraulicPermeabilityUnit from, UnitConverterHydraulicPermeabilityUnit to)
        {
            return (decimal)UnitConverterHydraulicPermeability.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterHydraulicPermeabilityUnit from, UnitConverterHydraulicPermeabilityUnit to)
        {
            return UnitConverterHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterHydraulicPermeabilityUnit from, UnitConverterHydraulicPermeabilityUnit to)
        {
            return UnitConverterHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterHydraulicPermeabilityUnit from, UnitConverterHydraulicPermeabilityUnit to)
        {
            return UnitConverterHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterHydraulicPermeabilityUnit from, UnitConverterHydraulicPermeabilityUnit to)
        {
            return UnitConverterHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterHydraulicPermeabilityUnit from, UnitConverterHydraulicPermeabilityUnit to)
        {
            return UnitConverterHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterHydraulicPermeabilityUnit from, UnitConverterHydraulicPermeabilityUnit to)
        {
            return UnitConverterHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterHydraulicPermeabilityUnit from, UnitConverterHydraulicPermeabilityUnit to)
        {
            return UnitConverterHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterHydraulicPermeabilityUnit from, UnitConverterHydraulicPermeabilityUnit to)
        {
            return UnitConverterHydraulicPermeability.Convert(value, from, to);
        }
    }
}
