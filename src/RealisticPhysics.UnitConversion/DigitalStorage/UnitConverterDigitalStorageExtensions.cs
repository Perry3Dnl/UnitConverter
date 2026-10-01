namespace RealisticPhysics.UnitConversion.DigitalStorage
{
    /// <summary>
    /// Extension-method API for Digital Storage conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterDigitalStorageExtensions
    {
        public static double Convert(this double value, UnitConverterDigitalStorageUnit from, UnitConverterDigitalStorageUnit to)
        {
            return UnitConverterDigitalStorage.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterDigitalStorageUnit from, UnitConverterDigitalStorageUnit to)
        {
            return (float)UnitConverterDigitalStorage.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterDigitalStorageUnit from, UnitConverterDigitalStorageUnit to)
        {
            return (decimal)UnitConverterDigitalStorage.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterDigitalStorageUnit from, UnitConverterDigitalStorageUnit to)
        {
            return UnitConverterDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterDigitalStorageUnit from, UnitConverterDigitalStorageUnit to)
        {
            return UnitConverterDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterDigitalStorageUnit from, UnitConverterDigitalStorageUnit to)
        {
            return UnitConverterDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterDigitalStorageUnit from, UnitConverterDigitalStorageUnit to)
        {
            return UnitConverterDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterDigitalStorageUnit from, UnitConverterDigitalStorageUnit to)
        {
            return UnitConverterDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterDigitalStorageUnit from, UnitConverterDigitalStorageUnit to)
        {
            return UnitConverterDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterDigitalStorageUnit from, UnitConverterDigitalStorageUnit to)
        {
            return UnitConverterDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterDigitalStorageUnit from, UnitConverterDigitalStorageUnit to)
        {
            return UnitConverterDigitalStorage.Convert(value, from, to);
        }
    }
}
