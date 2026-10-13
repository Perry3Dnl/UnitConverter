namespace UnitTools.Temperature
{
    /// <summary>
    /// Extension-method API for temperature conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsTemperatureExtensions
    {
        public static double Convert(this double value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
        {
            return (float)UnitToolsTemperature.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.Convert(value, from, to);
        }

        public static double ToKelvin(this double value, UnitToolsTemperatureUnit from)
        {
            return UnitToolsTemperature.ToKelvin(value, from);
        }

        public static float ToKelvin(this float value, UnitToolsTemperatureUnit from)
        {
            return (float)UnitToolsTemperature.ToKelvin(value, from);
        }

        public static decimal ToKelvin(this decimal value, UnitToolsTemperatureUnit from)
        {
            return (decimal)UnitToolsTemperature.ToKelvin((double)value, from);
        }

        public static double ToKelvin(this byte value, UnitToolsTemperatureUnit from)
        {
            return UnitToolsTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this sbyte value, UnitToolsTemperatureUnit from)
        {
            return UnitToolsTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this short value, UnitToolsTemperatureUnit from)
        {
            return UnitToolsTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this ushort value, UnitToolsTemperatureUnit from)
        {
            return UnitToolsTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this int value, UnitToolsTemperatureUnit from)
        {
            return UnitToolsTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this uint value, UnitToolsTemperatureUnit from)
        {
            return UnitToolsTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this long value, UnitToolsTemperatureUnit from)
        {
            return UnitToolsTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this ulong value, UnitToolsTemperatureUnit from)
        {
            return UnitToolsTemperature.ToKelvin(value, from);
        }

        public static double FromKelvin(this double value, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.FromKelvin(value, to);
        }

        public static float FromKelvin(this float value, UnitToolsTemperatureUnit to)
        {
            return (float)UnitToolsTemperature.FromKelvin(value, to);
        }

        public static decimal FromKelvin(this decimal value, UnitToolsTemperatureUnit to)
        {
            return (decimal)UnitToolsTemperature.FromKelvin((double)value, to);
        }

        public static double FromKelvin(this byte value, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this sbyte value, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this short value, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this ushort value, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this int value, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this uint value, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this long value, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this ulong value, UnitToolsTemperatureUnit to)
        {
            return UnitToolsTemperature.FromKelvin(value, to);
        }
    }
}
