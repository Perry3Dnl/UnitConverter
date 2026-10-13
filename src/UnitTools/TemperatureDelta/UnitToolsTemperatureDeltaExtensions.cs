namespace UnitTools.TemperatureDelta
{
    /// <summary>
    /// Extension-method API for temperature-delta conversions.
    /// Decimal conversions use the shared exact rational path.
    /// </summary>
    public static class UnitToolsTemperatureDeltaExtensions
    {
        public static double Convert(this double value, UnitToolsTemperatureDeltaUnit from, UnitToolsTemperatureDeltaUnit to)
            => UnitToolsTemperatureDelta.Convert(value, from, to);

        public static float Convert(this float value, UnitToolsTemperatureDeltaUnit from, UnitToolsTemperatureDeltaUnit to)
            => (float)UnitToolsTemperatureDelta.Convert(value, from, to);

        public static decimal Convert(this decimal value, UnitToolsTemperatureDeltaUnit from, UnitToolsTemperatureDeltaUnit to)
            => global::UnitTools.UnitToolsExact.Convert(value, from, to);

        public static double Convert(this byte value, UnitToolsTemperatureDeltaUnit from, UnitToolsTemperatureDeltaUnit to)
            => UnitToolsTemperatureDelta.Convert(value, from, to);
        public static double Convert(this sbyte value, UnitToolsTemperatureDeltaUnit from, UnitToolsTemperatureDeltaUnit to)
            => UnitToolsTemperatureDelta.Convert(value, from, to);
        public static double Convert(this short value, UnitToolsTemperatureDeltaUnit from, UnitToolsTemperatureDeltaUnit to)
            => UnitToolsTemperatureDelta.Convert(value, from, to);
        public static double Convert(this ushort value, UnitToolsTemperatureDeltaUnit from, UnitToolsTemperatureDeltaUnit to)
            => UnitToolsTemperatureDelta.Convert(value, from, to);
        public static double Convert(this int value, UnitToolsTemperatureDeltaUnit from, UnitToolsTemperatureDeltaUnit to)
            => UnitToolsTemperatureDelta.Convert(value, from, to);
        public static double Convert(this uint value, UnitToolsTemperatureDeltaUnit from, UnitToolsTemperatureDeltaUnit to)
            => UnitToolsTemperatureDelta.Convert(value, from, to);
        public static double Convert(this long value, UnitToolsTemperatureDeltaUnit from, UnitToolsTemperatureDeltaUnit to)
            => UnitToolsTemperatureDelta.Convert(value, from, to);
        public static double Convert(this ulong value, UnitToolsTemperatureDeltaUnit from, UnitToolsTemperatureDeltaUnit to)
            => UnitToolsTemperatureDelta.Convert(value, from, to);
    }
}
