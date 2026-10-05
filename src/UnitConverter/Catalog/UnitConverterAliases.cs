namespace UnitConverter.Catalog
{
    using UnitConverter.AngularVelocity;
    using UnitConverter.Area;
    using UnitConverter.Length;
    using UnitConverter.Mass;
    using UnitConverter.Pressure;
    using UnitConverter.Speed;
    using UnitConverter.Temperature;
    using UnitConverter.TemperatureDelta;
    using UnitConverter.Time;
    using UnitConverter.Volume;

    internal static class UnitConverterAliases
    {

        public static string[] GetSpeedAliases(UnitConverterSpeedUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpeedUnit.MeterPerSecond:
                    return new[] { "mps", "meter per second", "meters per second", "metre per second", "metres per second" };
                case UnitConverterSpeedUnit.KilometerPerHour:
                    return new[] { "kph", "kmh", "km/hr", "kilometers per hour", "kilometre per hour", "kilometres per hour" };
                case UnitConverterSpeedUnit.FootPerSecond:
                    return new[] { "feet per second" };
                case UnitConverterSpeedUnit.MilePerHour:
                    return new[] { "miles per hour" };
                case UnitConverterSpeedUnit.Knot:
                    return new[] { "knots", "kt", "kts" };
                case UnitConverterSpeedUnit.MicrometerPerSecond:
                    return new[] { "micrometre per second", "micrometers per second", "micrometres per second" };
                case UnitConverterSpeedUnit.CentimeterPerSecond:
                    return new[] { "centimetre per second", "centimeters per second", "centimetres per second" };
                case UnitConverterSpeedUnit.MillimeterPerSecond:
                    return new[] { "millimetre per second", "millimeters per second", "millimetres per second" };
                default:
                    return null;
            }
        }

        public static string[] GetAngularVelocityAliases(UnitConverterAngularVelocityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAngularVelocityUnit.RadianPerSecond:
                    return new[] { "rad/sec", "radians per second" };
                case UnitConverterAngularVelocityUnit.RevolutionPerSecond:
                    return new[] { "rps", "rev/sec", "revolutions per second", "rotations per second" };
                case UnitConverterAngularVelocityUnit.RevolutionPerMinute:
                    return new[] { "rev/min", "r/min", "revolutions per minute", "rotations per minute" };
                case UnitConverterAngularVelocityUnit.RevolutionPerHour:
                    return new[] { "rev/hr", "revolutions per hour" };
                case UnitConverterAngularVelocityUnit.MilliradianPerSecond:
                    return new[] { "mrad/sec", "milliradians per second" };
                default:
                    return null;
            }
        }

        public static string[] GetAreaAliases(UnitConverterAreaUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAreaUnit.SquareMillimeter:
                    return new[] { "square millimeter", "square millimeters", "square millimetre", "square millimetres", "sq mm" };
                case UnitConverterAreaUnit.SquareCentimeter:
                    return new[] { "square centimeter", "square centimeters", "square centimetre", "square centimetres", "sq cm" };
                case UnitConverterAreaUnit.SquareMeter:
                    return new[] { "square meter", "square meters", "square metre", "square metres", "sq m", "sqm" };
                case UnitConverterAreaUnit.SquareKilometer:
                    return new[] { "square kilometer", "square kilometers", "square kilometre", "square kilometres", "sq km" };
                case UnitConverterAreaUnit.SquareFoot:
                    return new[] { "square feet", "sq ft" };
                case UnitConverterAreaUnit.SquareInch:
                    return new[] { "square inches", "sq in" };
                case UnitConverterAreaUnit.SquareYard:
                    return new[] { "square yards", "sq yd" };
                case UnitConverterAreaUnit.SquareMile:
                    return new[] { "square miles", "sq mi" };
                case UnitConverterAreaUnit.Hectare:
                    return new[] { "hectares" };
                case UnitConverterAreaUnit.Acre:
                    return new[] { "acres" };
                default:
                    return null;
            }
        }

        public static string[] GetVolumeAliases(UnitConverterVolumeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVolumeUnit.Milliliter:
                    return new[] { "millilitre", "milliliters", "millilitres" };
                case UnitConverterVolumeUnit.Centiliter:
                    return new[] { "centilitre", "centiliters", "centilitres" };
                case UnitConverterVolumeUnit.Deciliter:
                    return new[] { "decilitre", "deciliters", "decilitres" };
                case UnitConverterVolumeUnit.Liter:
                    return new[] { "litre", "liters", "litres" };
                case UnitConverterVolumeUnit.Decaliter:
                    return new[] { "decalitre", "decaliters", "decalitres" };
                case UnitConverterVolumeUnit.Hectoliter:
                    return new[] { "hectolitre", "hectoliters", "hectolitres" };
                case UnitConverterVolumeUnit.Kiloliter:
                    return new[] { "kilolitre", "kiloliters", "kilolitres" };
                case UnitConverterVolumeUnit.Microliter:
                    return new[] { "microlitre", "microliters", "microlitres" };
                case UnitConverterVolumeUnit.Nanoliter:
                    return new[] { "nanolitre", "nanoliters", "nanolitres" };
                case UnitConverterVolumeUnit.CubicMeter:
                    return new[] { "cubic meter", "cubic meters", "cubic metre", "cubic metres" };
                case UnitConverterVolumeUnit.CubicFoot:
                    return new[] { "cubic feet" };
                case UnitConverterVolumeUnit.USGallon:
                    return new[] { "US gallon", "US gallons", "gallon US", "gallons US" };
                case UnitConverterVolumeUnit.ImperialGallon:
                    return new[] { "imperial gallon", "imperial gallons", "UK gallon", "UK gallons" };
                default:
                    return null;
            }
        }

        public static string[] GetTimeAliases(UnitConverterTimeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTimeUnit.Nanosecond: return new[] { "nanoseconds", "nsec", "nsecs" };
                case UnitConverterTimeUnit.Microsecond: return new[] { "microseconds", "usec", "usecs" };
                case UnitConverterTimeUnit.Millisecond: return new[] { "milliseconds", "msec", "msecs" };
                case UnitConverterTimeUnit.Second: return new[] { "seconds", "sec", "secs" };
                case UnitConverterTimeUnit.Minute: return new[] { "minutes", "min", "mins" };
                case UnitConverterTimeUnit.Hour: return new[] { "hours", "hr", "hrs" };
                case UnitConverterTimeUnit.Day: return new[] { "days" };
                case UnitConverterTimeUnit.Week: return new[] { "weeks", "wk", "wks" };
                case UnitConverterTimeUnit.Fortnight: return new[] { "fortnights" };
                case UnitConverterTimeUnit.CommonYear: return new[] { "year", "years", "yr", "yrs" };
                case UnitConverterTimeUnit.Decade: return new[] { "decades" };
                case UnitConverterTimeUnit.Century: return new[] { "centuries" };
                case UnitConverterTimeUnit.Millennium: return new[] { "millennia", "millenniums" };
                default: return null;
            }
        }

        public static string[] GetMassAliases(UnitConverterMassUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMassUnit.Microgram: return new[] { "micrograms" };
                case UnitConverterMassUnit.Milligram: return new[] { "milligrams" };
                case UnitConverterMassUnit.Gram: return new[] { "grams" };
                case UnitConverterMassUnit.Kilogram: return new[] { "kilograms", "kilo", "kilos" };
                case UnitConverterMassUnit.MetricTon: return new[] { "metric ton", "metric tons", "tonne", "tonnes" };
                case UnitConverterMassUnit.Ounce: return new[] { "ounces", "ozs" };
                case UnitConverterMassUnit.Pound: return new[] { "pounds", "lb", "lbs" };
                case UnitConverterMassUnit.Stone: return new[] { "stones" };
                case UnitConverterMassUnit.ShortTon: return new[] { "short ton", "short tons", "US ton", "US tons" };
                case UnitConverterMassUnit.LongTon: return new[] { "long ton", "long tons", "imperial ton", "imperial tons" };
                case UnitConverterMassUnit.TroyOunce: return new[] { "troy ounces" };
                case UnitConverterMassUnit.TroyPound: return new[] { "troy pounds" };
                case UnitConverterMassUnit.Carat: return new[] { "carats" };
                default: return null;
            }
        }

        public static string[] GetPressureAliases(UnitConverterPressureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPressureUnit.Pascal: return new[] { "pascals" };
                case UnitConverterPressureUnit.Hectopascal: return new[] { "hectopascals" };
                case UnitConverterPressureUnit.Kilopascal: return new[] { "kilopascals" };
                case UnitConverterPressureUnit.Megapascal: return new[] { "megapascals" };
                case UnitConverterPressureUnit.Bar: return new[] { "bars" };
                case UnitConverterPressureUnit.Millibar: return new[] { "millibars" };
                case UnitConverterPressureUnit.Atmosphere: return new[] { "atmospheres", "standard atmosphere", "standard atmospheres" };
                case UnitConverterPressureUnit.Torr: return new[] { "torrs" };
                case UnitConverterPressureUnit.MillimeterMercury: return new[] { "millimeters of mercury", "millimetres of mercury" };
                case UnitConverterPressureUnit.InchMercury: return new[] { "inches of mercury" };
                case UnitConverterPressureUnit.Psi: return new[] { "pounds per square inch", "pound-force per square inch" };
                case UnitConverterPressureUnit.Psf: return new[] { "pounds per square foot", "pound-force per square foot" };
                default: return null;
            }
        }

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
