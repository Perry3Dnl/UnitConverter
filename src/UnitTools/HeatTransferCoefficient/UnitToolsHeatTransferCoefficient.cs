namespace UnitTools.HeatTransferCoefficient
{
    using UnitTools.HeatTransferCoefficient.Metric;
    using UnitTools.HeatTransferCoefficient.Imperial;

    public enum UnitToolsHeatTransferCoefficientUnit
    {
        WattPerSquareMeterKelvin = 0,
        KilowattPerSquareMeterKelvin = 1,
        CaloriePerSecondSquareCentimeterCelsius = 2,
        KilocaloriePerHourSquareMeterCelsius = 3,
        BtuPerHourSquareFootFahrenheit = 4,
        WattPerSquareMillimeterKelvin = 5,
        MilliwattPerSquareMeterKelvin = 6,
        CaloriePerSecondSquareMeterCelsius = 7,
        BtuPerSecondSquareFootFahrenheit = 8,
        BtuPerMinuteSquareFootFahrenheit = 9,
    }

    public static class UnitToolsHeatTransferCoefficient
    {
        public static double Convert(double value, UnitToolsHeatTransferCoefficientUnit from, UnitToolsHeatTransferCoefficientUnit to)
        {
            double baseValue = ToWattPerSquareMeterKelvin(value, from);
            return FromWattPerSquareMeterKelvin(baseValue, to);
        }

        public static double ToWattPerSquareMeterKelvin(double value, UnitToolsHeatTransferCoefficientUnit from)
        {
            switch (from)
            {
                case UnitToolsHeatTransferCoefficientUnit.WattPerSquareMeterKelvin:
                    return UnitToolsMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToWattPerSquareMeterKelvin(value);
                case UnitToolsHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin:
                    return UnitToolsMetricHeatTransferCoefficient.KilowattPerSquareMeterKelvinToWattPerSquareMeterKelvin(value);
                case UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius:
                    return UnitToolsMetricHeatTransferCoefficient.CaloriePerSecondSquareCentimeterCelsiusToWattPerSquareMeterKelvin(value);
                case UnitToolsHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius:
                    return UnitToolsMetricHeatTransferCoefficient.KilocaloriePerHourSquareMeterCelsiusToWattPerSquareMeterKelvin(value);
                case UnitToolsHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit:
                    return UnitToolsImperialHeatTransferCoefficient.BtuPerHourSquareFootFahrenheitToWattPerSquareMeterKelvin(value);
                case UnitToolsHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin:
                    return UnitToolsMetricHeatTransferCoefficient.WattPerSquareMillimeterKelvinToWattPerSquareMeterKelvin(value);
                case UnitToolsHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin:
                    return UnitToolsMetricHeatTransferCoefficient.MilliwattPerSquareMeterKelvinToWattPerSquareMeterKelvin(value);
                case UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius:
                    return UnitToolsMetricHeatTransferCoefficient.CaloriePerSecondSquareMeterCelsiusToWattPerSquareMeterKelvin(value);
                case UnitToolsHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit:
                    return UnitToolsImperialHeatTransferCoefficient.BtuPerSecondSquareFootFahrenheitToWattPerSquareMeterKelvin(value);
                case UnitToolsHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit:
                    return UnitToolsImperialHeatTransferCoefficient.BtuPerMinuteSquareFootFahrenheitToWattPerSquareMeterKelvin(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported heat transfer coefficient unit.");
            }
        }

        public static double FromWattPerSquareMeterKelvin(double baseValue, UnitToolsHeatTransferCoefficientUnit to)
        {
            switch (to)
            {
                case UnitToolsHeatTransferCoefficientUnit.WattPerSquareMeterKelvin:
                    return UnitToolsMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToWattPerSquareMeterKelvin(baseValue);
                case UnitToolsHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin:
                    return UnitToolsMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToKilowattPerSquareMeterKelvin(baseValue);
                case UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius:
                    return UnitToolsMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToCaloriePerSecondSquareCentimeterCelsius(baseValue);
                case UnitToolsHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius:
                    return UnitToolsMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToKilocaloriePerHourSquareMeterCelsius(baseValue);
                case UnitToolsHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit:
                    return UnitToolsImperialHeatTransferCoefficient.WattPerSquareMeterKelvinToBtuPerHourSquareFootFahrenheit(baseValue);
                case UnitToolsHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin:
                    return UnitToolsMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToWattPerSquareMillimeterKelvin(baseValue);
                case UnitToolsHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin:
                    return UnitToolsMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToMilliwattPerSquareMeterKelvin(baseValue);
                case UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius:
                    return UnitToolsMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToCaloriePerSecondSquareMeterCelsius(baseValue);
                case UnitToolsHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit:
                    return UnitToolsImperialHeatTransferCoefficient.WattPerSquareMeterKelvinToBtuPerSecondSquareFootFahrenheit(baseValue);
                case UnitToolsHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit:
                    return UnitToolsImperialHeatTransferCoefficient.WattPerSquareMeterKelvinToBtuPerMinuteSquareFootFahrenheit(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported heat transfer coefficient unit.");
            }
        }

        public static string GetSymbol(UnitToolsHeatTransferCoefficientUnit unit)
        {
            switch (unit)
            {
                case UnitToolsHeatTransferCoefficientUnit.WattPerSquareMeterKelvin:
                    return "W/(m²·K)";
                case UnitToolsHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin:
                    return "kW/(m²·K)";
                case UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius:
                    return "cal/(s·cm²·°C)";
                case UnitToolsHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius:
                    return "kcal/(h·m²·°C)";
                case UnitToolsHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit:
                    return "BTU/(h·ft²·°F)";
                case UnitToolsHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin:
                    return "W/(mm²·K)";
                case UnitToolsHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin:
                    return "mW/(m²·K)";
                case UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius:
                    return "cal/(s·m²·°C)";
                case UnitToolsHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit:
                    return "BTU/(s·ft²·°F)";
                case UnitToolsHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit:
                    return "BTU/(min·ft²·°F)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsHeatTransferCoefficientUnit unit)
        {
            switch (unit)
            {
                case UnitToolsHeatTransferCoefficientUnit.WattPerSquareMeterKelvin:
                    return "Watt Per Square Meter Kelvin";
                case UnitToolsHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin:
                    return "Kilowatt Per Square Meter Kelvin";
                case UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius:
                    return "Calorie Per Second Square Centimeter Celsius";
                case UnitToolsHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius:
                    return "Kilocalorie Per Hour Square Meter Celsius";
                case UnitToolsHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit:
                    return "Btu Per Hour Square Foot Fahrenheit";
                case UnitToolsHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin:
                    return "Watt Per Square Millimeter Kelvin";
                case UnitToolsHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin:
                    return "Milliwatt Per Square Meter Kelvin";
                case UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius:
                    return "Calorie Per Second Square Meter Celsius";
                case UnitToolsHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit:
                    return "Btu Per Second Square Foot Fahrenheit";
                case UnitToolsHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit:
                    return "Btu Per Minute Square Foot Fahrenheit";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsHeatTransferCoefficientUnit unit)
        {
            switch (unit)
            {
                case UnitToolsHeatTransferCoefficientUnit.WattPerSquareMeterKelvin:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsHeatTransferCoefficientUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsHeatTransferCoefficientUnit.WattPerSquareMeterKelvin, UnitToolsHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin, UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius, UnitToolsHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius, UnitToolsHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin, UnitToolsHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin, UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit, UnitToolsHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit, UnitToolsHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit };
                default:
                    return new[] { UnitToolsHeatTransferCoefficientUnit.WattPerSquareMeterKelvin, UnitToolsHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin, UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius, UnitToolsHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius, UnitToolsHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit, UnitToolsHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin, UnitToolsHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin, UnitToolsHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius, UnitToolsHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit, UnitToolsHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit };
            }
        }
    }
}
