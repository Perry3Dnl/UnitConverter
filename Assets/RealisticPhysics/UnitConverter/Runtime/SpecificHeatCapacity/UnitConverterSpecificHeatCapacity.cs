namespace RealisticPhysics.UnitConversion.SpecificHeatCapacity
{
    using RealisticPhysics.UnitConversion.SpecificHeatCapacity.Metric;
    using RealisticPhysics.UnitConversion.SpecificHeatCapacity.Imperial;

    public enum UnitConverterSpecificHeatCapacityUnit
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

    public static class UnitConverterSpecificHeatCapacity
    {
        public static double Convert(double value, UnitConverterSpecificHeatCapacityUnit from, UnitConverterSpecificHeatCapacityUnit to)
        {
            double baseValue = ToJoulePerKilogramKelvin(value, from);
            return FromJoulePerKilogramKelvin(baseValue, to);
        }

        public static double ToJoulePerKilogramKelvin(double value, UnitConverterSpecificHeatCapacityUnit from)
        {
            switch (from)
            {
                case UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramKelvin:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerKilogramKelvinToJoulePerKilogramKelvin(value);
                case UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin:
                    return UnitConverterMetricSpecificHeatCapacity.KilojoulePerKilogramKelvinToJoulePerKilogramKelvin(value);
                case UnitConverterSpecificHeatCapacityUnit.JoulePerGramKelvin:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerGramKelvinToJoulePerKilogramKelvin(value);
                case UnitConverterSpecificHeatCapacityUnit.CaloriePerGramCelsius:
                    return UnitConverterMetricSpecificHeatCapacity.CaloriePerGramCelsiusToJoulePerKilogramKelvin(value);
                case UnitConverterSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius:
                    return UnitConverterMetricSpecificHeatCapacity.KilocaloriePerKilogramCelsiusToJoulePerKilogramKelvin(value);
                case UnitConverterSpecificHeatCapacityUnit.BtuPerPoundFahrenheit:
                    return UnitConverterImperialSpecificHeatCapacity.BtuPerPoundFahrenheitToJoulePerKilogramKelvin(value);
                case UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramCelsius:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerKilogramCelsiusToJoulePerKilogramKelvin(value);
                case UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius:
                    return UnitConverterMetricSpecificHeatCapacity.KilojoulePerKilogramCelsiusToJoulePerKilogramKelvin(value);
                case UnitConverterSpecificHeatCapacityUnit.JoulePerGramCelsius:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerGramCelsiusToJoulePerKilogramKelvin(value);
                case UnitConverterSpecificHeatCapacityUnit.CaloriePerGramKelvin:
                    return UnitConverterMetricSpecificHeatCapacity.CaloriePerGramKelvinToJoulePerKilogramKelvin(value);
                case UnitConverterSpecificHeatCapacityUnit.KilocaloriePerGramCelsius:
                    return UnitConverterMetricSpecificHeatCapacity.KilocaloriePerGramCelsiusToJoulePerKilogramKelvin(value);
                case UnitConverterSpecificHeatCapacityUnit.BtuPerPoundRankine:
                    return UnitConverterImperialSpecificHeatCapacity.BtuPerPoundRankineToJoulePerKilogramKelvin(value);
                case UnitConverterSpecificHeatCapacityUnit.BtuPerSlugFahrenheit:
                    return UnitConverterImperialSpecificHeatCapacity.BtuPerSlugFahrenheitToJoulePerKilogramKelvin(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported specific heat capacity unit.");
            }
        }

        public static double FromJoulePerKilogramKelvin(double baseValue, UnitConverterSpecificHeatCapacityUnit to)
        {
            switch (to)
            {
                case UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramKelvin:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerKilogramKelvinToJoulePerKilogramKelvin(baseValue);
                case UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerKilogramKelvinToKilojoulePerKilogramKelvin(baseValue);
                case UnitConverterSpecificHeatCapacityUnit.JoulePerGramKelvin:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerKilogramKelvinToJoulePerGramKelvin(baseValue);
                case UnitConverterSpecificHeatCapacityUnit.CaloriePerGramCelsius:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerKilogramKelvinToCaloriePerGramCelsius(baseValue);
                case UnitConverterSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerKilogramKelvinToKilocaloriePerKilogramCelsius(baseValue);
                case UnitConverterSpecificHeatCapacityUnit.BtuPerPoundFahrenheit:
                    return UnitConverterImperialSpecificHeatCapacity.JoulePerKilogramKelvinToBtuPerPoundFahrenheit(baseValue);
                case UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramCelsius:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerKilogramKelvinToJoulePerKilogramCelsius(baseValue);
                case UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerKilogramKelvinToKilojoulePerKilogramCelsius(baseValue);
                case UnitConverterSpecificHeatCapacityUnit.JoulePerGramCelsius:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerKilogramKelvinToJoulePerGramCelsius(baseValue);
                case UnitConverterSpecificHeatCapacityUnit.CaloriePerGramKelvin:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerKilogramKelvinToCaloriePerGramKelvin(baseValue);
                case UnitConverterSpecificHeatCapacityUnit.KilocaloriePerGramCelsius:
                    return UnitConverterMetricSpecificHeatCapacity.JoulePerKilogramKelvinToKilocaloriePerGramCelsius(baseValue);
                case UnitConverterSpecificHeatCapacityUnit.BtuPerPoundRankine:
                    return UnitConverterImperialSpecificHeatCapacity.JoulePerKilogramKelvinToBtuPerPoundRankine(baseValue);
                case UnitConverterSpecificHeatCapacityUnit.BtuPerSlugFahrenheit:
                    return UnitConverterImperialSpecificHeatCapacity.JoulePerKilogramKelvinToBtuPerSlugFahrenheit(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported specific heat capacity unit.");
            }
        }

        public static string GetSymbol(UnitConverterSpecificHeatCapacityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramKelvin:
                    return "J/(kg·K)";
                case UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin:
                    return "kJ/(kg·K)";
                case UnitConverterSpecificHeatCapacityUnit.JoulePerGramKelvin:
                    return "J/(g·K)";
                case UnitConverterSpecificHeatCapacityUnit.CaloriePerGramCelsius:
                    return "cal/(g·°C)";
                case UnitConverterSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius:
                    return "kcal/(kg·°C)";
                case UnitConverterSpecificHeatCapacityUnit.BtuPerPoundFahrenheit:
                    return "BTU/(lb·°F)";
                case UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramCelsius:
                    return "J/(kg·°C)";
                case UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius:
                    return "kJ/(kg·°C)";
                case UnitConverterSpecificHeatCapacityUnit.JoulePerGramCelsius:
                    return "J/(g·°C)";
                case UnitConverterSpecificHeatCapacityUnit.CaloriePerGramKelvin:
                    return "cal/(g·K)";
                case UnitConverterSpecificHeatCapacityUnit.KilocaloriePerGramCelsius:
                    return "kcal/(g·°C)";
                case UnitConverterSpecificHeatCapacityUnit.BtuPerPoundRankine:
                    return "BTU/(lb·°R)";
                case UnitConverterSpecificHeatCapacityUnit.BtuPerSlugFahrenheit:
                    return "BTU/(slug·°F)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterSpecificHeatCapacityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramKelvin:
                    return "Joule Per Kilogram Kelvin";
                case UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin:
                    return "Kilojoule Per Kilogram Kelvin";
                case UnitConverterSpecificHeatCapacityUnit.JoulePerGramKelvin:
                    return "Joule Per Gram Kelvin";
                case UnitConverterSpecificHeatCapacityUnit.CaloriePerGramCelsius:
                    return "Calorie Per Gram Celsius";
                case UnitConverterSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius:
                    return "Kilocalorie Per Kilogram Celsius";
                case UnitConverterSpecificHeatCapacityUnit.BtuPerPoundFahrenheit:
                    return "Btu Per Pound Fahrenheit";
                case UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramCelsius:
                    return "Joule Per Kilogram Celsius";
                case UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius:
                    return "Kilojoule Per Kilogram Celsius";
                case UnitConverterSpecificHeatCapacityUnit.JoulePerGramCelsius:
                    return "Joule Per Gram Celsius";
                case UnitConverterSpecificHeatCapacityUnit.CaloriePerGramKelvin:
                    return "Calorie Per Gram Kelvin";
                case UnitConverterSpecificHeatCapacityUnit.KilocaloriePerGramCelsius:
                    return "Kilocalorie Per Gram Celsius";
                case UnitConverterSpecificHeatCapacityUnit.BtuPerPoundRankine:
                    return "Btu Per Pound Rankine";
                case UnitConverterSpecificHeatCapacityUnit.BtuPerSlugFahrenheit:
                    return "Btu Per Slug Fahrenheit";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterSpecificHeatCapacityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramKelvin:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificHeatCapacityUnit.JoulePerGramKelvin:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificHeatCapacityUnit.CaloriePerGramCelsius:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificHeatCapacityUnit.BtuPerPoundFahrenheit:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramCelsius:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificHeatCapacityUnit.JoulePerGramCelsius:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificHeatCapacityUnit.CaloriePerGramKelvin:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificHeatCapacityUnit.KilocaloriePerGramCelsius:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterSpecificHeatCapacityUnit.BtuPerPoundRankine:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterSpecificHeatCapacityUnit.BtuPerSlugFahrenheit:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterSpecificHeatCapacityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramKelvin, UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin, UnitConverterSpecificHeatCapacityUnit.JoulePerGramKelvin, UnitConverterSpecificHeatCapacityUnit.CaloriePerGramCelsius, UnitConverterSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius, UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramCelsius, UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius, UnitConverterSpecificHeatCapacityUnit.JoulePerGramCelsius, UnitConverterSpecificHeatCapacityUnit.CaloriePerGramKelvin, UnitConverterSpecificHeatCapacityUnit.KilocaloriePerGramCelsius };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterSpecificHeatCapacityUnit.BtuPerPoundFahrenheit, UnitConverterSpecificHeatCapacityUnit.BtuPerPoundRankine, UnitConverterSpecificHeatCapacityUnit.BtuPerSlugFahrenheit };
                default:
                    return new[] { UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramKelvin, UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramKelvin, UnitConverterSpecificHeatCapacityUnit.JoulePerGramKelvin, UnitConverterSpecificHeatCapacityUnit.CaloriePerGramCelsius, UnitConverterSpecificHeatCapacityUnit.KilocaloriePerKilogramCelsius, UnitConverterSpecificHeatCapacityUnit.BtuPerPoundFahrenheit, UnitConverterSpecificHeatCapacityUnit.JoulePerKilogramCelsius, UnitConverterSpecificHeatCapacityUnit.KilojoulePerKilogramCelsius, UnitConverterSpecificHeatCapacityUnit.JoulePerGramCelsius, UnitConverterSpecificHeatCapacityUnit.CaloriePerGramKelvin, UnitConverterSpecificHeatCapacityUnit.KilocaloriePerGramCelsius, UnitConverterSpecificHeatCapacityUnit.BtuPerPoundRankine, UnitConverterSpecificHeatCapacityUnit.BtuPerSlugFahrenheit };
            }
        }
    }
}
