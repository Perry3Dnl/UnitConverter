namespace UnitConverter.Temperature
{
    /// <summary>
    /// Extension-method API for temperature conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterTemperatureExtensions
    {
        public static double Convert(this double value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
        {
            return (float)UnitConverterTemperature.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
        {
            return (decimal)UnitConverterTemperature.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.Convert(value, from, to);
        }

        public static double ToKelvin(this double value, UnitConverterTemperatureUnit from)
        {
            return UnitConverterTemperature.ToKelvin(value, from);
        }

        public static float ToKelvin(this float value, UnitConverterTemperatureUnit from)
        {
            return (float)UnitConverterTemperature.ToKelvin(value, from);
        }

        public static decimal ToKelvin(this decimal value, UnitConverterTemperatureUnit from)
        {
            return (decimal)UnitConverterTemperature.ToKelvin((double)value, from);
        }

        public static double ToKelvin(this byte value, UnitConverterTemperatureUnit from)
        {
            return UnitConverterTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this sbyte value, UnitConverterTemperatureUnit from)
        {
            return UnitConverterTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this short value, UnitConverterTemperatureUnit from)
        {
            return UnitConverterTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this ushort value, UnitConverterTemperatureUnit from)
        {
            return UnitConverterTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this int value, UnitConverterTemperatureUnit from)
        {
            return UnitConverterTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this uint value, UnitConverterTemperatureUnit from)
        {
            return UnitConverterTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this long value, UnitConverterTemperatureUnit from)
        {
            return UnitConverterTemperature.ToKelvin(value, from);
        }

        public static double ToKelvin(this ulong value, UnitConverterTemperatureUnit from)
        {
            return UnitConverterTemperature.ToKelvin(value, from);
        }

        public static double FromKelvin(this double value, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.FromKelvin(value, to);
        }

        public static float FromKelvin(this float value, UnitConverterTemperatureUnit to)
        {
            return (float)UnitConverterTemperature.FromKelvin(value, to);
        }

        public static decimal FromKelvin(this decimal value, UnitConverterTemperatureUnit to)
        {
            return (decimal)UnitConverterTemperature.FromKelvin((double)value, to);
        }

        public static double FromKelvin(this byte value, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this sbyte value, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this short value, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this ushort value, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this int value, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this uint value, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this long value, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.FromKelvin(value, to);
        }

        public static double FromKelvin(this ulong value, UnitConverterTemperatureUnit to)
        {
            return UnitConverterTemperature.FromKelvin(value, to);
        }
    }
}
