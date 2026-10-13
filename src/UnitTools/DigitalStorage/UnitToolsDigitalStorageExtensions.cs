namespace UnitTools.DigitalStorage
{
    /// <summary>
    /// Extension-method API for Digital Storage conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsDigitalStorageExtensions
    {
        public static double Convert(this double value, UnitToolsDigitalStorageUnit from, UnitToolsDigitalStorageUnit to)
        {
            return UnitToolsDigitalStorage.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsDigitalStorageUnit from, UnitToolsDigitalStorageUnit to)
        {
            return (float)UnitToolsDigitalStorage.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsDigitalStorageUnit from, UnitToolsDigitalStorageUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsDigitalStorageUnit from, UnitToolsDigitalStorageUnit to)
        {
            return UnitToolsDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsDigitalStorageUnit from, UnitToolsDigitalStorageUnit to)
        {
            return UnitToolsDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsDigitalStorageUnit from, UnitToolsDigitalStorageUnit to)
        {
            return UnitToolsDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsDigitalStorageUnit from, UnitToolsDigitalStorageUnit to)
        {
            return UnitToolsDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsDigitalStorageUnit from, UnitToolsDigitalStorageUnit to)
        {
            return UnitToolsDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsDigitalStorageUnit from, UnitToolsDigitalStorageUnit to)
        {
            return UnitToolsDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsDigitalStorageUnit from, UnitToolsDigitalStorageUnit to)
        {
            return UnitToolsDigitalStorage.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsDigitalStorageUnit from, UnitToolsDigitalStorageUnit to)
        {
            return UnitToolsDigitalStorage.Convert(value, from, to);
        }
    }
}
