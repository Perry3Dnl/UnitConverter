namespace RealisticPhysics.UnitConversion.ThermalExpansion
{
    using RealisticPhysics.UnitConversion.ThermalExpansion.Metric;
    using RealisticPhysics.UnitConversion.ThermalExpansion.Imperial;
    using RealisticPhysics.UnitConversion.ThermalExpansion.Engineering;

    public enum UnitConverterThermalExpansionUnit
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

    public static class UnitConverterThermalExpansion
    {
        public static double Convert(double value, UnitConverterThermalExpansionUnit from, UnitConverterThermalExpansionUnit to)
        {
            double baseValue = ToPerKelvin(value, from);
            return FromPerKelvin(baseValue, to);
        }

        public static double ToPerKelvin(double value, UnitConverterThermalExpansionUnit from)
        {
            switch (from)
            {
                case UnitConverterThermalExpansionUnit.PerKelvin:
                    return UnitConverterMetricThermalExpansion.PerKelvinToPerKelvin(value);
                case UnitConverterThermalExpansionUnit.PerCelsius:
                    return UnitConverterMetricThermalExpansion.PerCelsiusToPerKelvin(value);
                case UnitConverterThermalExpansionUnit.PerFahrenheit:
                    return UnitConverterImperialThermalExpansion.PerFahrenheitToPerKelvin(value);
                case UnitConverterThermalExpansionUnit.MicrostrainPerKelvin:
                    return UnitConverterEngineeringThermalExpansion.MicrostrainPerKelvinToPerKelvin(value);
                case UnitConverterThermalExpansionUnit.PpmPerKelvin:
                    return UnitConverterEngineeringThermalExpansion.PpmPerKelvinToPerKelvin(value);
                case UnitConverterThermalExpansionUnit.MicrostrainPerCelsius:
                    return UnitConverterEngineeringThermalExpansion.MicrostrainPerCelsiusToPerKelvin(value);
                case UnitConverterThermalExpansionUnit.MicrostrainPerFahrenheit:
                    return UnitConverterEngineeringThermalExpansion.MicrostrainPerFahrenheitToPerKelvin(value);
                case UnitConverterThermalExpansionUnit.PpmPerCelsius:
                    return UnitConverterEngineeringThermalExpansion.PpmPerCelsiusToPerKelvin(value);
                case UnitConverterThermalExpansionUnit.PpmPerFahrenheit:
                    return UnitConverterEngineeringThermalExpansion.PpmPerFahrenheitToPerKelvin(value);
                case UnitConverterThermalExpansionUnit.PerRankine:
                    return UnitConverterImperialThermalExpansion.PerRankineToPerKelvin(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported thermal expansion unit.");
            }
        }

        public static double FromPerKelvin(double baseValue, UnitConverterThermalExpansionUnit to)
        {
            switch (to)
            {
                case UnitConverterThermalExpansionUnit.PerKelvin:
                    return UnitConverterMetricThermalExpansion.PerKelvinToPerKelvin(baseValue);
                case UnitConverterThermalExpansionUnit.PerCelsius:
                    return UnitConverterMetricThermalExpansion.PerKelvinToPerCelsius(baseValue);
                case UnitConverterThermalExpansionUnit.PerFahrenheit:
                    return UnitConverterImperialThermalExpansion.PerKelvinToPerFahrenheit(baseValue);
                case UnitConverterThermalExpansionUnit.MicrostrainPerKelvin:
                    return UnitConverterEngineeringThermalExpansion.PerKelvinToMicrostrainPerKelvin(baseValue);
                case UnitConverterThermalExpansionUnit.PpmPerKelvin:
                    return UnitConverterEngineeringThermalExpansion.PerKelvinToPpmPerKelvin(baseValue);
                case UnitConverterThermalExpansionUnit.MicrostrainPerCelsius:
                    return UnitConverterEngineeringThermalExpansion.PerKelvinToMicrostrainPerCelsius(baseValue);
                case UnitConverterThermalExpansionUnit.MicrostrainPerFahrenheit:
                    return UnitConverterEngineeringThermalExpansion.PerKelvinToMicrostrainPerFahrenheit(baseValue);
                case UnitConverterThermalExpansionUnit.PpmPerCelsius:
                    return UnitConverterEngineeringThermalExpansion.PerKelvinToPpmPerCelsius(baseValue);
                case UnitConverterThermalExpansionUnit.PpmPerFahrenheit:
                    return UnitConverterEngineeringThermalExpansion.PerKelvinToPpmPerFahrenheit(baseValue);
                case UnitConverterThermalExpansionUnit.PerRankine:
                    return UnitConverterImperialThermalExpansion.PerKelvinToPerRankine(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported thermal expansion unit.");
            }
        }

        public static string GetSymbol(UnitConverterThermalExpansionUnit unit)
        {
            switch (unit)
            {
                case UnitConverterThermalExpansionUnit.PerKelvin:
                    return "1/K";
                case UnitConverterThermalExpansionUnit.PerCelsius:
                    return "1/°C";
                case UnitConverterThermalExpansionUnit.PerFahrenheit:
                    return "1/°F";
                case UnitConverterThermalExpansionUnit.MicrostrainPerKelvin:
                    return "µε/K";
                case UnitConverterThermalExpansionUnit.PpmPerKelvin:
                    return "ppm/K";
                case UnitConverterThermalExpansionUnit.MicrostrainPerCelsius:
                    return "µε/°C";
                case UnitConverterThermalExpansionUnit.MicrostrainPerFahrenheit:
                    return "µε/°F";
                case UnitConverterThermalExpansionUnit.PpmPerCelsius:
                    return "ppm/°C";
                case UnitConverterThermalExpansionUnit.PpmPerFahrenheit:
                    return "ppm/°F";
                case UnitConverterThermalExpansionUnit.PerRankine:
                    return "1/°R";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterThermalExpansionUnit unit)
        {
            switch (unit)
            {
                case UnitConverterThermalExpansionUnit.PerKelvin:
                    return "Per Kelvin";
                case UnitConverterThermalExpansionUnit.PerCelsius:
                    return "Per Celsius";
                case UnitConverterThermalExpansionUnit.PerFahrenheit:
                    return "Per Fahrenheit";
                case UnitConverterThermalExpansionUnit.MicrostrainPerKelvin:
                    return "Microstrain Per Kelvin";
                case UnitConverterThermalExpansionUnit.PpmPerKelvin:
                    return "Ppm Per Kelvin";
                case UnitConverterThermalExpansionUnit.MicrostrainPerCelsius:
                    return "Microstrain Per Celsius";
                case UnitConverterThermalExpansionUnit.MicrostrainPerFahrenheit:
                    return "Microstrain Per Fahrenheit";
                case UnitConverterThermalExpansionUnit.PpmPerCelsius:
                    return "Ppm Per Celsius";
                case UnitConverterThermalExpansionUnit.PpmPerFahrenheit:
                    return "Ppm Per Fahrenheit";
                case UnitConverterThermalExpansionUnit.PerRankine:
                    return "Per Rankine";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterThermalExpansionUnit unit)
        {
            switch (unit)
            {
                case UnitConverterThermalExpansionUnit.PerKelvin:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalExpansionUnit.PerCelsius:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalExpansionUnit.PerFahrenheit:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterThermalExpansionUnit.MicrostrainPerKelvin:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterThermalExpansionUnit.PpmPerKelvin:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterThermalExpansionUnit.MicrostrainPerCelsius:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterThermalExpansionUnit.MicrostrainPerFahrenheit:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterThermalExpansionUnit.PpmPerCelsius:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterThermalExpansionUnit.PpmPerFahrenheit:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterThermalExpansionUnit.PerRankine:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterThermalExpansionUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterThermalExpansionUnit.PerKelvin, UnitConverterThermalExpansionUnit.PerCelsius };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterThermalExpansionUnit.PerFahrenheit, UnitConverterThermalExpansionUnit.PerRankine };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterThermalExpansionUnit.MicrostrainPerKelvin, UnitConverterThermalExpansionUnit.PpmPerKelvin, UnitConverterThermalExpansionUnit.MicrostrainPerCelsius, UnitConverterThermalExpansionUnit.MicrostrainPerFahrenheit, UnitConverterThermalExpansionUnit.PpmPerCelsius, UnitConverterThermalExpansionUnit.PpmPerFahrenheit };
                default:
                    return new[] { UnitConverterThermalExpansionUnit.PerKelvin, UnitConverterThermalExpansionUnit.PerCelsius, UnitConverterThermalExpansionUnit.PerFahrenheit, UnitConverterThermalExpansionUnit.MicrostrainPerKelvin, UnitConverterThermalExpansionUnit.PpmPerKelvin, UnitConverterThermalExpansionUnit.MicrostrainPerCelsius, UnitConverterThermalExpansionUnit.MicrostrainPerFahrenheit, UnitConverterThermalExpansionUnit.PpmPerCelsius, UnitConverterThermalExpansionUnit.PpmPerFahrenheit, UnitConverterThermalExpansionUnit.PerRankine };
            }
        }
    }
}
