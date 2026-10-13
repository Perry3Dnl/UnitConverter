namespace UnitTools.SpecificHeatCapacity
{
    using UnitTools.SpecificHeatCapacity.Metric;
    using UnitTools.SpecificHeatCapacity.Imperial;

    public enum UnitToolsSpecificHeatCapacityUnit
    {
        JoulePerKilogramKelvin = 0,
        KilojoulePerKilogramKelvin = 1,
        JoulePerGramKelvin = 2,
        CaloriePerGramCelsius = 3,
        KilocaloriePerKilogramCelsius = 4,
        BtuPerPoundFahrenheit = 5,
        JoulePerKilogramCelsius = 6,
        KilojoulePerKilogramCelsius = 7,
        JoulePerGramCelsius = 8,
        CaloriePerGramKelvin = 9,
        KilocaloriePerGramCelsius = 10,
        BtuPerPoundRankine = 11,
        BtuPerSlugFahrenheit = 12,
    }

    public static class UnitToolsSpecificHeatCapacity
    {
        public static double Convert(double value, UnitToolsSpecificHeatCapacityUnit from, UnitToolsSpecificHeatCapacityUnit to)
        {
            double baseValue = ToJoulePerKilogramKelvin(value, from);
            return FromJoulePerKilogramKelvin(baseValue, to);
        }

        public static double ToJoulePerKilogramKelvin(double value, UnitToolsSpecificHeatCapacityUnit from)
        {
            switch (from)
            {
                case UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramKelvin:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerKilogramKelvinToJoulePerKilogramKelvin(value);
                case UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin:
                    return UnitToolsMetricSpecificHeatCapacity.KilojoulePerKilogramKelvinToJoulePerKilogramKelvin(value);
                case UnitToolsSpecificHeatCapacityUnit.JoulePerGramKelvin:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerGramKelvinToJoulePerKilogramKelvin(value);
                case UnitToolsSpecificHeatCapacityUnit.CaloriePerGramCelsius:
                    return UnitToolsMetricSpecificHeatCapacity.CaloriePerGramCelsiusToJoulePerKilogramKelvin(value);
                case UnitToolsSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius:
                    return UnitToolsMetricSpecificHeatCapacity.KilocaloriePerKilogramCelsiusToJoulePerKilogramKelvin(value);
                case UnitToolsSpecificHeatCapacityUnit.BtuPerPoundFahrenheit:
                    return UnitToolsImperialSpecificHeatCapacity.BtuPerPoundFahrenheitToJoulePerKilogramKelvin(value);
                case UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramCelsius:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerKilogramCelsiusToJoulePerKilogramKelvin(value);
                case UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius:
                    return UnitToolsMetricSpecificHeatCapacity.KilojoulePerKilogramCelsiusToJoulePerKilogramKelvin(value);
                case UnitToolsSpecificHeatCapacityUnit.JoulePerGramCelsius:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerGramCelsiusToJoulePerKilogramKelvin(value);
                case UnitToolsSpecificHeatCapacityUnit.CaloriePerGramKelvin:
                    return UnitToolsMetricSpecificHeatCapacity.CaloriePerGramKelvinToJoulePerKilogramKelvin(value);
                case UnitToolsSpecificHeatCapacityUnit.KilocaloriePerGramCelsius:
                    return UnitToolsMetricSpecificHeatCapacity.KilocaloriePerGramCelsiusToJoulePerKilogramKelvin(value);
                case UnitToolsSpecificHeatCapacityUnit.BtuPerPoundRankine:
                    return UnitToolsImperialSpecificHeatCapacity.BtuPerPoundRankineToJoulePerKilogramKelvin(value);
                case UnitToolsSpecificHeatCapacityUnit.BtuPerSlugFahrenheit:
                    return UnitToolsImperialSpecificHeatCapacity.BtuPerSlugFahrenheitToJoulePerKilogramKelvin(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported specific heat capacity unit.");
            }
        }

        public static double FromJoulePerKilogramKelvin(double baseValue, UnitToolsSpecificHeatCapacityUnit to)
        {
            switch (to)
            {
                case UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramKelvin:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerKilogramKelvinToJoulePerKilogramKelvin(baseValue);
                case UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerKilogramKelvinToKilojoulePerKilogramKelvin(baseValue);
                case UnitToolsSpecificHeatCapacityUnit.JoulePerGramKelvin:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerKilogramKelvinToJoulePerGramKelvin(baseValue);
                case UnitToolsSpecificHeatCapacityUnit.CaloriePerGramCelsius:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerKilogramKelvinToCaloriePerGramCelsius(baseValue);
                case UnitToolsSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerKilogramKelvinToKilocaloriePerKilogramCelsius(baseValue);
                case UnitToolsSpecificHeatCapacityUnit.BtuPerPoundFahrenheit:
                    return UnitToolsImperialSpecificHeatCapacity.JoulePerKilogramKelvinToBtuPerPoundFahrenheit(baseValue);
                case UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramCelsius:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerKilogramKelvinToJoulePerKilogramCelsius(baseValue);
                case UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerKilogramKelvinToKilojoulePerKilogramCelsius(baseValue);
                case UnitToolsSpecificHeatCapacityUnit.JoulePerGramCelsius:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerKilogramKelvinToJoulePerGramCelsius(baseValue);
                case UnitToolsSpecificHeatCapacityUnit.CaloriePerGramKelvin:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerKilogramKelvinToCaloriePerGramKelvin(baseValue);
                case UnitToolsSpecificHeatCapacityUnit.KilocaloriePerGramCelsius:
                    return UnitToolsMetricSpecificHeatCapacity.JoulePerKilogramKelvinToKilocaloriePerGramCelsius(baseValue);
                case UnitToolsSpecificHeatCapacityUnit.BtuPerPoundRankine:
                    return UnitToolsImperialSpecificHeatCapacity.JoulePerKilogramKelvinToBtuPerPoundRankine(baseValue);
                case UnitToolsSpecificHeatCapacityUnit.BtuPerSlugFahrenheit:
                    return UnitToolsImperialSpecificHeatCapacity.JoulePerKilogramKelvinToBtuPerSlugFahrenheit(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported specific heat capacity unit.");
            }
        }

        public static string GetSymbol(UnitToolsSpecificHeatCapacityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramKelvin:
                    return "J/(kg·K)";
                case UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin:
                    return "kJ/(kg·K)";
                case UnitToolsSpecificHeatCapacityUnit.JoulePerGramKelvin:
                    return "J/(g·K)";
                case UnitToolsSpecificHeatCapacityUnit.CaloriePerGramCelsius:
                    return "cal/(g·°C)";
                case UnitToolsSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius:
                    return "kcal/(kg·°C)";
                case UnitToolsSpecificHeatCapacityUnit.BtuPerPoundFahrenheit:
                    return "BTU/(lb·°F)";
                case UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramCelsius:
                    return "J/(kg·°C)";
                case UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius:
                    return "kJ/(kg·°C)";
                case UnitToolsSpecificHeatCapacityUnit.JoulePerGramCelsius:
                    return "J/(g·°C)";
                case UnitToolsSpecificHeatCapacityUnit.CaloriePerGramKelvin:
                    return "cal/(g·K)";
                case UnitToolsSpecificHeatCapacityUnit.KilocaloriePerGramCelsius:
                    return "kcal/(g·°C)";
                case UnitToolsSpecificHeatCapacityUnit.BtuPerPoundRankine:
                    return "BTU/(lb·°R)";
                case UnitToolsSpecificHeatCapacityUnit.BtuPerSlugFahrenheit:
                    return "BTU/(slug·°F)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsSpecificHeatCapacityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramKelvin:
                    return "Joule Per Kilogram Kelvin";
                case UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin:
                    return "Kilojoule Per Kilogram Kelvin";
                case UnitToolsSpecificHeatCapacityUnit.JoulePerGramKelvin:
                    return "Joule Per Gram Kelvin";
                case UnitToolsSpecificHeatCapacityUnit.CaloriePerGramCelsius:
                    return "Calorie Per Gram Celsius";
                case UnitToolsSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius:
                    return "Kilocalorie Per Kilogram Celsius";
                case UnitToolsSpecificHeatCapacityUnit.BtuPerPoundFahrenheit:
                    return "Btu Per Pound Fahrenheit";
                case UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramCelsius:
                    return "Joule Per Kilogram Celsius";
                case UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius:
                    return "Kilojoule Per Kilogram Celsius";
                case UnitToolsSpecificHeatCapacityUnit.JoulePerGramCelsius:
                    return "Joule Per Gram Celsius";
                case UnitToolsSpecificHeatCapacityUnit.CaloriePerGramKelvin:
                    return "Calorie Per Gram Kelvin";
                case UnitToolsSpecificHeatCapacityUnit.KilocaloriePerGramCelsius:
                    return "Kilocalorie Per Gram Celsius";
                case UnitToolsSpecificHeatCapacityUnit.BtuPerPoundRankine:
                    return "Btu Per Pound Rankine";
                case UnitToolsSpecificHeatCapacityUnit.BtuPerSlugFahrenheit:
                    return "Btu Per Slug Fahrenheit";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsSpecificHeatCapacityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramKelvin:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificHeatCapacityUnit.JoulePerGramKelvin:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificHeatCapacityUnit.CaloriePerGramCelsius:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificHeatCapacityUnit.BtuPerPoundFahrenheit:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramCelsius:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificHeatCapacityUnit.JoulePerGramCelsius:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificHeatCapacityUnit.CaloriePerGramKelvin:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificHeatCapacityUnit.KilocaloriePerGramCelsius:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSpecificHeatCapacityUnit.BtuPerPoundRankine:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSpecificHeatCapacityUnit.BtuPerSlugFahrenheit:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsSpecificHeatCapacityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramKelvin, UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin, UnitToolsSpecificHeatCapacityUnit.JoulePerGramKelvin, UnitToolsSpecificHeatCapacityUnit.CaloriePerGramCelsius, UnitToolsSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius, UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramCelsius, UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius, UnitToolsSpecificHeatCapacityUnit.JoulePerGramCelsius, UnitToolsSpecificHeatCapacityUnit.CaloriePerGramKelvin, UnitToolsSpecificHeatCapacityUnit.KilocaloriePerGramCelsius };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsSpecificHeatCapacityUnit.BtuPerPoundFahrenheit, UnitToolsSpecificHeatCapacityUnit.BtuPerPoundRankine, UnitToolsSpecificHeatCapacityUnit.BtuPerSlugFahrenheit };
                default:
                    return new[] { UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramKelvin, UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin, UnitToolsSpecificHeatCapacityUnit.JoulePerGramKelvin, UnitToolsSpecificHeatCapacityUnit.CaloriePerGramCelsius, UnitToolsSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius, UnitToolsSpecificHeatCapacityUnit.BtuPerPoundFahrenheit, UnitToolsSpecificHeatCapacityUnit.JoulePerKilogramCelsius, UnitToolsSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius, UnitToolsSpecificHeatCapacityUnit.JoulePerGramCelsius, UnitToolsSpecificHeatCapacityUnit.CaloriePerGramKelvin, UnitToolsSpecificHeatCapacityUnit.KilocaloriePerGramCelsius, UnitToolsSpecificHeatCapacityUnit.BtuPerPoundRankine, UnitToolsSpecificHeatCapacityUnit.BtuPerSlugFahrenheit };
            }
        }
    }
}
