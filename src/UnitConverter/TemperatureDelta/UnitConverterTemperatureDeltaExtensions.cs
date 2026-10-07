namespace UnitConverter.TemperatureDelta
{
    /// <summary>
    /// Extension-method API for temperature-delta conversions.
    /// Decimal conversions use the shared exact rational path.
    /// </summary>
    public static class UnitConverterTemperatureDeltaExtensions
    {
        public static double Convert(this double value, UnitConverterTemperatureDeltaUnit from, UnitConverterTemperatureDeltaUnit to)
            => UnitConverterTemperatureDelta.Convert(value, from, to);

        public static float Convert(this float value, UnitConverterTemperatureDeltaUnit from, UnitConverterTemperatureDeltaUnit to)
            => (float)UnitConverterTemperatureDelta.Convert(value, from, to);

        public static decimal Convert(this decimal value, UnitConverterTemperatureDeltaUnit from, UnitConverterTemperatureDeltaUnit to)
            => global::UnitConverter.UnitConverterExact.Convert(value, from, to);

        public static double Convert(this byte value, UnitConverterTemperatureDeltaUnit from, UnitConverterTemperatureDeltaUnit to)
            => UnitConverterTemperatureDelta.Convert(value, from, to);
        public static double Convert(this sbyte value, UnitConverterTemperatureDeltaUnit from, UnitConverterTemperatureDeltaUnit to)
            => UnitConverterTemperatureDelta.Convert(value, from, to);
        public static double Convert(this short value, UnitConverterTemperatureDeltaUnit from, UnitConverterTemperatureDeltaUnit to)
            => UnitConverterTemperatureDelta.Convert(value, from, to);
        public static double Convert(this ushort value, UnitConverterTemperatureDeltaUnit from, UnitConverterTemperatureDeltaUnit to)
            => UnitConverterTemperatureDelta.Convert(value, from, to);
        public static double Convert(this int value, UnitConverterTemperatureDeltaUnit from, UnitConverterTemperatureDeltaUnit to)
            => UnitConverterTemperatureDelta.Convert(value, from, to);
        public static double Convert(this uint value, UnitConverterTemperatureDeltaUnit from, UnitConverterTemperatureDeltaUnit to)
            => UnitConverterTemperatureDelta.Convert(value, from, to);
        public static double Convert(this long value, UnitConverterTemperatureDeltaUnit from, UnitConverterTemperatureDeltaUnit to)
            => UnitConverterTemperatureDelta.Convert(value, from, to);
        public static double Convert(this ulong value, UnitConverterTemperatureDeltaUnit from, UnitConverterTemperatureDeltaUnit to)
            => UnitConverterTemperatureDelta.Convert(value, from, to);
    }
}
