namespace UnitConverter.Catalog
{
    using UnitConverter.Length;
    using UnitConverter.Temperature;
    using UnitConverter.TemperatureDelta;

    internal static class UnitConverterAliases
    {
        public static string[] GetLengthAliases(UnitConverterLengthUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLengthUnit.Micrometer:
                    return new[] { "micrometre", "micrometers", "micrometres" };
                case UnitConverterLengthUnit.Millimeter:
                    return new[] { "millimetre", "millimeters", "millimetres" };
                case UnitConverterLengthUnit.Centimeter:
                    return new[] { "centimetre", "centimeters", "centimetres" };
                case UnitConverterLengthUnit.Decimeter:
                    return new[] { "decimetre", "decimeters", "decimetres" };
                case UnitConverterLengthUnit.Meter:
                    return new[] { "metre", "meters", "metres" };
                case UnitConverterLengthUnit.Decameter:
                    return new[] { "decametre", "decameters", "decametres" };
                case UnitConverterLengthUnit.Hectometer:
                    return new[] { "hectometre", "hectometers", "hectometres" };
                case UnitConverterLengthUnit.Kilometer:
                    return new[] { "kilometre", "kilometers", "kilometres" };
                case UnitConverterLengthUnit.Megameter:
                    return new[] { "megametre", "megameters", "megametres" };
                case UnitConverterLengthUnit.Gigameter:
                    return new[] { "gigametre", "gigameters", "gigametres" };
                case UnitConverterLengthUnit.Inch:
                    return new[] { "inches" };
                case UnitConverterLengthUnit.Foot:
                    return new[] { "feet" };
                case UnitConverterLengthUnit.Yard:
                    return new[] { "yards" };
                case UnitConverterLengthUnit.Mile:
                    return new[] { "miles" };
                case UnitConverterLengthUnit.NauticalMile:
                    return new[] { "nautical miles" };
                case UnitConverterLengthUnit.LightYear:
                    return new[] { "light years", "light-year", "light-years" };
                case UnitConverterLengthUnit.Parsec:
                    return new[] { "parsecs" };
                case UnitConverterLengthUnit.Angstrom:
                    return new[] { "angstrom", "angstroms", "ångströms" };
                default:
                    return null;
            }
        }

        public static string[] GetTemperatureDeltaAliases(UnitConverterTemperatureDeltaUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTemperatureDeltaUnit.Kelvin:
                    return new[] { "delta k", "kelvin delta", "kelvin difference" };
                case UnitConverterTemperatureDeltaUnit.Celsius:
                    return new[] { "delta c", "delta °c", "celsius delta", "celsius difference", "degree celsius difference" };
                case UnitConverterTemperatureDeltaUnit.Fahrenheit:
                    return new[] { "delta f", "delta °f", "fahrenheit delta", "fahrenheit difference", "degree fahrenheit difference" };
                case UnitConverterTemperatureDeltaUnit.Rankine:
                    return new[] { "delta r", "delta °r", "rankine delta", "rankine difference" };
                case UnitConverterTemperatureDeltaUnit.Delisle:
                    return new[] { "delisle delta", "delisle difference" };
                case UnitConverterTemperatureDeltaUnit.Newton:
                    return new[] { "newton delta", "newton difference" };
                case UnitConverterTemperatureDeltaUnit.Reaumur:
                    return new[] { "reaumur delta", "réaumur delta", "reaumur difference", "réaumur difference" };
                case UnitConverterTemperatureDeltaUnit.Romer:
                    return new[] { "romer delta", "rømer delta", "romer difference", "rømer difference" };
                default:
                    return null;
            }
        }

        public static string[] GetTemperatureAliases(UnitConverterTemperatureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTemperatureUnit.Kelvin:
                    return new[] { "kelvins", "deg k", "degree kelvin", "degrees kelvin" };
                case UnitConverterTemperatureUnit.Celsius:
                    return new[] { "c", "deg c", "degree celsius", "degrees celsius" };
                case UnitConverterTemperatureUnit.Fahrenheit:
                    return new[] { "f", "deg f", "degree fahrenheit", "degrees fahrenheit" };
                case UnitConverterTemperatureUnit.Rankine:
                    return new[] { "r", "deg r", "degree rankine", "degrees rankine" };
                case UnitConverterTemperatureUnit.Delisle:
                    return new[] { "degrees delisle" };
                case UnitConverterTemperatureUnit.Newton:
                    return new[] { "degrees newton" };
                case UnitConverterTemperatureUnit.Reaumur:
                    return new[] { "réaumur", "degrees reaumur", "degrees réaumur" };
                case UnitConverterTemperatureUnit.Romer:
                    return new[] { "rømer", "degrees romer", "degrees rømer" };
                default:
                    return null;
            }
        }
    }
}
