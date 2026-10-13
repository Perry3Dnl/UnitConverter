namespace UnitTools.ThermalExpansion
{
    using UnitTools.ThermalExpansion.Metric;
    using UnitTools.ThermalExpansion.Imperial;
    using UnitTools.ThermalExpansion.Engineering;

    public enum UnitToolsThermalExpansionUnit
    {
        PerKelvin = 0,
        PerCelsius = 1,
        PerFahrenheit = 2,
        MicrostrainPerKelvin = 3,
        PpmPerKelvin = 4,
        MicrostrainPerCelsius = 5,
        MicrostrainPerFahrenheit = 6,
        PpmPerCelsius = 7,
        PpmPerFahrenheit = 8,
        PerRankine = 9,
    }

    public static class UnitToolsThermalExpansion
    {
        public static double Convert(double value, UnitToolsThermalExpansionUnit from, UnitToolsThermalExpansionUnit to)
        {
            double baseValue = ToPerKelvin(value, from);
            return FromPerKelvin(baseValue, to);
        }

        public static double ToPerKelvin(double value, UnitToolsThermalExpansionUnit from)
        {
            switch (from)
            {
                case UnitToolsThermalExpansionUnit.PerKelvin:
                    return UnitToolsMetricThermalExpansion.PerKelvinToPerKelvin(value);
                case UnitToolsThermalExpansionUnit.PerCelsius:
                    return UnitToolsMetricThermalExpansion.PerCelsiusToPerKelvin(value);
                case UnitToolsThermalExpansionUnit.PerFahrenheit:
                    return UnitToolsImperialThermalExpansion.PerFahrenheitToPerKelvin(value);
                case UnitToolsThermalExpansionUnit.MicrostrainPerKelvin:
                    return UnitToolsEngineeringThermalExpansion.MicrostrainPerKelvinToPerKelvin(value);
                case UnitToolsThermalExpansionUnit.PpmPerKelvin:
                    return UnitToolsEngineeringThermalExpansion.PpmPerKelvinToPerKelvin(value);
                case UnitToolsThermalExpansionUnit.MicrostrainPerCelsius:
                    return UnitToolsEngineeringThermalExpansion.MicrostrainPerCelsiusToPerKelvin(value);
                case UnitToolsThermalExpansionUnit.MicrostrainPerFahrenheit:
                    return UnitToolsEngineeringThermalExpansion.MicrostrainPerFahrenheitToPerKelvin(value);
                case UnitToolsThermalExpansionUnit.PpmPerCelsius:
                    return UnitToolsEngineeringThermalExpansion.PpmPerCelsiusToPerKelvin(value);
                case UnitToolsThermalExpansionUnit.PpmPerFahrenheit:
                    return UnitToolsEngineeringThermalExpansion.PpmPerFahrenheitToPerKelvin(value);
                case UnitToolsThermalExpansionUnit.PerRankine:
                    return UnitToolsImperialThermalExpansion.PerRankineToPerKelvin(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported thermal expansion unit.");
            }
        }

        public static double FromPerKelvin(double baseValue, UnitToolsThermalExpansionUnit to)
        {
            switch (to)
            {
                case UnitToolsThermalExpansionUnit.PerKelvin:
                    return UnitToolsMetricThermalExpansion.PerKelvinToPerKelvin(baseValue);
                case UnitToolsThermalExpansionUnit.PerCelsius:
                    return UnitToolsMetricThermalExpansion.PerKelvinToPerCelsius(baseValue);
                case UnitToolsThermalExpansionUnit.PerFahrenheit:
                    return UnitToolsImperialThermalExpansion.PerKelvinToPerFahrenheit(baseValue);
                case UnitToolsThermalExpansionUnit.MicrostrainPerKelvin:
                    return UnitToolsEngineeringThermalExpansion.PerKelvinToMicrostrainPerKelvin(baseValue);
                case UnitToolsThermalExpansionUnit.PpmPerKelvin:
                    return UnitToolsEngineeringThermalExpansion.PerKelvinToPpmPerKelvin(baseValue);
                case UnitToolsThermalExpansionUnit.MicrostrainPerCelsius:
                    return UnitToolsEngineeringThermalExpansion.PerKelvinToMicrostrainPerCelsius(baseValue);
                case UnitToolsThermalExpansionUnit.MicrostrainPerFahrenheit:
                    return UnitToolsEngineeringThermalExpansion.PerKelvinToMicrostrainPerFahrenheit(baseValue);
                case UnitToolsThermalExpansionUnit.PpmPerCelsius:
                    return UnitToolsEngineeringThermalExpansion.PerKelvinToPpmPerCelsius(baseValue);
                case UnitToolsThermalExpansionUnit.PpmPerFahrenheit:
                    return UnitToolsEngineeringThermalExpansion.PerKelvinToPpmPerFahrenheit(baseValue);
                case UnitToolsThermalExpansionUnit.PerRankine:
                    return UnitToolsImperialThermalExpansion.PerKelvinToPerRankine(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported thermal expansion unit.");
            }
        }

        public static string GetSymbol(UnitToolsThermalExpansionUnit unit)
        {
            switch (unit)
            {
                case UnitToolsThermalExpansionUnit.PerKelvin:
                    return "1/K";
                case UnitToolsThermalExpansionUnit.PerCelsius:
                    return "1/°C";
                case UnitToolsThermalExpansionUnit.PerFahrenheit:
                    return "1/°F";
                case UnitToolsThermalExpansionUnit.MicrostrainPerKelvin:
                    return "µε/K";
                case UnitToolsThermalExpansionUnit.PpmPerKelvin:
                    return "ppm/K";
                case UnitToolsThermalExpansionUnit.MicrostrainPerCelsius:
                    return "µε/°C";
                case UnitToolsThermalExpansionUnit.MicrostrainPerFahrenheit:
                    return "µε/°F";
                case UnitToolsThermalExpansionUnit.PpmPerCelsius:
                    return "ppm/°C";
                case UnitToolsThermalExpansionUnit.PpmPerFahrenheit:
                    return "ppm/°F";
                case UnitToolsThermalExpansionUnit.PerRankine:
                    return "1/°R";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsThermalExpansionUnit unit)
        {
            switch (unit)
            {
                case UnitToolsThermalExpansionUnit.PerKelvin:
                    return "Per Kelvin";
                case UnitToolsThermalExpansionUnit.PerCelsius:
                    return "Per Celsius";
                case UnitToolsThermalExpansionUnit.PerFahrenheit:
                    return "Per Fahrenheit";
                case UnitToolsThermalExpansionUnit.MicrostrainPerKelvin:
                    return "Microstrain Per Kelvin";
                case UnitToolsThermalExpansionUnit.PpmPerKelvin:
                    return "Ppm Per Kelvin";
                case UnitToolsThermalExpansionUnit.MicrostrainPerCelsius:
                    return "Microstrain Per Celsius";
                case UnitToolsThermalExpansionUnit.MicrostrainPerFahrenheit:
                    return "Microstrain Per Fahrenheit";
                case UnitToolsThermalExpansionUnit.PpmPerCelsius:
                    return "Ppm Per Celsius";
                case UnitToolsThermalExpansionUnit.PpmPerFahrenheit:
                    return "Ppm Per Fahrenheit";
                case UnitToolsThermalExpansionUnit.PerRankine:
                    return "Per Rankine";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsThermalExpansionUnit unit)
        {
            switch (unit)
            {
                case UnitToolsThermalExpansionUnit.PerKelvin:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalExpansionUnit.PerCelsius:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalExpansionUnit.PerFahrenheit:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsThermalExpansionUnit.MicrostrainPerKelvin:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsThermalExpansionUnit.PpmPerKelvin:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsThermalExpansionUnit.MicrostrainPerCelsius:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsThermalExpansionUnit.MicrostrainPerFahrenheit:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsThermalExpansionUnit.PpmPerCelsius:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsThermalExpansionUnit.PpmPerFahrenheit:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsThermalExpansionUnit.PerRankine:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsThermalExpansionUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsThermalExpansionUnit.PerKelvin, UnitToolsThermalExpansionUnit.PerCelsius };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsThermalExpansionUnit.PerFahrenheit, UnitToolsThermalExpansionUnit.PerRankine };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsThermalExpansionUnit.MicrostrainPerKelvin, UnitToolsThermalExpansionUnit.PpmPerKelvin, UnitToolsThermalExpansionUnit.MicrostrainPerCelsius, UnitToolsThermalExpansionUnit.MicrostrainPerFahrenheit, UnitToolsThermalExpansionUnit.PpmPerCelsius, UnitToolsThermalExpansionUnit.PpmPerFahrenheit };
                default:
                    return new[] { UnitToolsThermalExpansionUnit.PerKelvin, UnitToolsThermalExpansionUnit.PerCelsius, UnitToolsThermalExpansionUnit.PerFahrenheit, UnitToolsThermalExpansionUnit.MicrostrainPerKelvin, UnitToolsThermalExpansionUnit.PpmPerKelvin, UnitToolsThermalExpansionUnit.MicrostrainPerCelsius, UnitToolsThermalExpansionUnit.MicrostrainPerFahrenheit, UnitToolsThermalExpansionUnit.PpmPerCelsius, UnitToolsThermalExpansionUnit.PpmPerFahrenheit, UnitToolsThermalExpansionUnit.PerRankine };
            }
        }
    }
}
