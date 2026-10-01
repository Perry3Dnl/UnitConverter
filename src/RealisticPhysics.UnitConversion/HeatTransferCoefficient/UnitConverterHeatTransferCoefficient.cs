namespace RealisticPhysics.UnitConversion.HeatTransferCoefficient
{
    using RealisticPhysics.UnitConversion.HeatTransferCoefficient.Metric;
    using RealisticPhysics.UnitConversion.HeatTransferCoefficient.Imperial;

    public enum UnitConverterHeatTransferCoefficientUnit
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

    public static class UnitConverterHeatTransferCoefficient
    {
        public static double Convert(double value, UnitConverterHeatTransferCoefficientUnit from, UnitConverterHeatTransferCoefficientUnit to)
        {
            double baseValue = ToWattPerSquareMeterKelvin(value, from);
            return FromWattPerSquareMeterKelvin(baseValue, to);
        }

        public static double ToWattPerSquareMeterKelvin(double value, UnitConverterHeatTransferCoefficientUnit from)
        {
            switch (from)
            {
                case UnitConverterHeatTransferCoefficientUnit.WattPerSquareMeterKelvin:
                    return UnitConverterMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToWattPerSquareMeterKelvin(value);
                case UnitConverterHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin:
                    return UnitConverterMetricHeatTransferCoefficient.KilowattPerSquareMeterKelvinToWattPerSquareMeterKelvin(value);
                case UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius:
                    return UnitConverterMetricHeatTransferCoefficient.CaloriePerSecondSquareCentimeterCelsiusToWattPerSquareMeterKelvin(value);
                case UnitConverterHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius:
                    return UnitConverterMetricHeatTransferCoefficient.KilocaloriePerHourSquareMeterCelsiusToWattPerSquareMeterKelvin(value);
                case UnitConverterHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit:
                    return UnitConverterImperialHeatTransferCoefficient.BtuPerHourSquareFootFahrenheitToWattPerSquareMeterKelvin(value);
                case UnitConverterHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin:
                    return UnitConverterMetricHeatTransferCoefficient.WattPerSquareMillimeterKelvinToWattPerSquareMeterKelvin(value);
                case UnitConverterHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin:
                    return UnitConverterMetricHeatTransferCoefficient.MilliwattPerSquareMeterKelvinToWattPerSquareMeterKelvin(value);
                case UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius:
                    return UnitConverterMetricHeatTransferCoefficient.CaloriePerSecondSquareMeterCelsiusToWattPerSquareMeterKelvin(value);
                case UnitConverterHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit:
                    return UnitConverterImperialHeatTransferCoefficient.BtuPerSecondSquareFootFahrenheitToWattPerSquareMeterKelvin(value);
                case UnitConverterHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit:
                    return UnitConverterImperialHeatTransferCoefficient.BtuPerMinuteSquareFootFahrenheitToWattPerSquareMeterKelvin(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported heat transfer coefficient unit.");
            }
        }

        public static double FromWattPerSquareMeterKelvin(double baseValue, UnitConverterHeatTransferCoefficientUnit to)
        {
            switch (to)
            {
                case UnitConverterHeatTransferCoefficientUnit.WattPerSquareMeterKelvin:
                    return UnitConverterMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToWattPerSquareMeterKelvin(baseValue);
                case UnitConverterHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin:
                    return UnitConverterMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToKilowattPerSquareMeterKelvin(baseValue);
                case UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius:
                    return UnitConverterMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToCaloriePerSecondSquareCentimeterCelsius(baseValue);
                case UnitConverterHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius:
                    return UnitConverterMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToKilocaloriePerHourSquareMeterCelsius(baseValue);
                case UnitConverterHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit:
                    return UnitConverterImperialHeatTransferCoefficient.WattPerSquareMeterKelvinToBtuPerHourSquareFootFahrenheit(baseValue);
                case UnitConverterHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin:
                    return UnitConverterMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToWattPerSquareMillimeterKelvin(baseValue);
                case UnitConverterHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin:
                    return UnitConverterMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToMilliwattPerSquareMeterKelvin(baseValue);
                case UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius:
                    return UnitConverterMetricHeatTransferCoefficient.WattPerSquareMeterKelvinToCaloriePerSecondSquareMeterCelsius(baseValue);
                case UnitConverterHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit:
                    return UnitConverterImperialHeatTransferCoefficient.WattPerSquareMeterKelvinToBtuPerSecondSquareFootFahrenheit(baseValue);
                case UnitConverterHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit:
                    return UnitConverterImperialHeatTransferCoefficient.WattPerSquareMeterKelvinToBtuPerMinuteSquareFootFahrenheit(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported heat transfer coefficient unit.");
            }
        }

        public static string GetSymbol(UnitConverterHeatTransferCoefficientUnit unit)
        {
            switch (unit)
            {
                case UnitConverterHeatTransferCoefficientUnit.WattPerSquareMeterKelvin:
                    return "W/(m²·K)";
                case UnitConverterHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin:
                    return "kW/(m²·K)";
                case UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius:
                    return "cal/(s·cm²·°C)";
                case UnitConverterHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius:
                    return "kcal/(h·m²·°C)";
                case UnitConverterHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit:
                    return "BTU/(h·ft²·°F)";
                case UnitConverterHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin:
                    return "W/(mm²·K)";
                case UnitConverterHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin:
                    return "mW/(m²·K)";
                case UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius:
                    return "cal/(s·m²·°C)";
                case UnitConverterHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit:
                    return "BTU/(s·ft²·°F)";
                case UnitConverterHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit:
                    return "BTU/(min·ft²·°F)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterHeatTransferCoefficientUnit unit)
        {
            switch (unit)
            {
                case UnitConverterHeatTransferCoefficientUnit.WattPerSquareMeterKelvin:
                    return "Watt Per Square Meter Kelvin";
                case UnitConverterHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin:
                    return "Kilowatt Per Square Meter Kelvin";
                case UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius:
                    return "Calorie Per Second Square Centimeter Celsius";
                case UnitConverterHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius:
                    return "Kilocalorie Per Hour Square Meter Celsius";
                case UnitConverterHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit:
                    return "Btu Per Hour Square Foot Fahrenheit";
                case UnitConverterHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin:
                    return "Watt Per Square Millimeter Kelvin";
                case UnitConverterHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin:
                    return "Milliwatt Per Square Meter Kelvin";
                case UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius:
                    return "Calorie Per Second Square Meter Celsius";
                case UnitConverterHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit:
                    return "Btu Per Second Square Foot Fahrenheit";
                case UnitConverterHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit:
                    return "Btu Per Minute Square Foot Fahrenheit";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterHeatTransferCoefficientUnit unit)
        {
            switch (unit)
            {
                case UnitConverterHeatTransferCoefficientUnit.WattPerSquareMeterKelvin:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterHeatTransferCoefficientUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterHeatTransferCoefficientUnit.WattPerSquareMeterKelvin, UnitConverterHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin, UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius, UnitConverterHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius, UnitConverterHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin, UnitConverterHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin, UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit, UnitConverterHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit, UnitConverterHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit };
                default:
                    return new[] { UnitConverterHeatTransferCoefficientUnit.WattPerSquareMeterKelvin, UnitConverterHeatTransferCoefficientUnit.KilowattPerSquareMeterKelvin, UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareCentimeterCelsius, UnitConverterHeatTransferCoefficientUnit.KilocaloriePerHourSquareMeterCelsius, UnitConverterHeatTransferCoefficientUnit.BtuPerHourSquareFootFahrenheit, UnitConverterHeatTransferCoefficientUnit.WattPerSquareMillimeterKelvin, UnitConverterHeatTransferCoefficientUnit.MilliwattPerSquareMeterKelvin, UnitConverterHeatTransferCoefficientUnit.CaloriePerSecondSquareMeterCelsius, UnitConverterHeatTransferCoefficientUnit.BtuPerSecondSquareFootFahrenheit, UnitConverterHeatTransferCoefficientUnit.BtuPerMinuteSquareFootFahrenheit };
            }
        }
    }
}
