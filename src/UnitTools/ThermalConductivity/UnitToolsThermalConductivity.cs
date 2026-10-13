namespace UnitTools.ThermalConductivity
{
    using UnitTools.ThermalConductivity.Metric;
    using UnitTools.ThermalConductivity.Imperial;

    public enum UnitToolsThermalConductivityUnit
    {
        WattPerMeterKelvin = 0,
        MilliwattPerMeterKelvin = 1,
        KilowattPerMeterKelvin = 2,
        CaloriePerSecondCentimeterCelsius = 3,
        BtuPerHourFootFahrenheit = 4,
        BtuInchPerHourSquareFootFahrenheit = 5,
        WattPerMillimeterKelvin = 6,
        WattPerInchFahrenheit = 7,
        BtuFootPerHourSquareFootFahrenheit = 8,
        CaloriePerSecondMeterCelsius = 9,
        KilocaloriePerSecondMeterCelsius = 10,
    }

    public static class UnitToolsThermalConductivity
    {
        public static double Convert(double value, UnitToolsThermalConductivityUnit from, UnitToolsThermalConductivityUnit to)
        {
            double baseValue = ToWattPerMeterKelvin(value, from);
            return FromWattPerMeterKelvin(baseValue, to);
        }

        public static double ToWattPerMeterKelvin(double value, UnitToolsThermalConductivityUnit from)
        {
            switch (from)
            {
                case UnitToolsThermalConductivityUnit.WattPerMeterKelvin:
                    return UnitToolsMetricThermalConductivity.WattPerMeterKelvinToWattPerMeterKelvin(value);
                case UnitToolsThermalConductivityUnit.MilliwattPerMeterKelvin:
                    return UnitToolsMetricThermalConductivity.MilliwattPerMeterKelvinToWattPerMeterKelvin(value);
                case UnitToolsThermalConductivityUnit.KilowattPerMeterKelvin:
                    return UnitToolsMetricThermalConductivity.KilowattPerMeterKelvinToWattPerMeterKelvin(value);
                case UnitToolsThermalConductivityUnit.CaloriePerSecondCentimeterCelsius:
                    return UnitToolsMetricThermalConductivity.CaloriePerSecondCentimeterCelsiusToWattPerMeterKelvin(value);
                case UnitToolsThermalConductivityUnit.BtuPerHourFootFahrenheit:
                    return UnitToolsImperialThermalConductivity.BtuPerHourFootFahrenheitToWattPerMeterKelvin(value);
                case UnitToolsThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit:
                    return UnitToolsImperialThermalConductivity.BtuInchPerHourSquareFootFahrenheitToWattPerMeterKelvin(value);
                case UnitToolsThermalConductivityUnit.WattPerMillimeterKelvin:
                    return UnitToolsMetricThermalConductivity.WattPerMillimeterKelvinToWattPerMeterKelvin(value);
                case UnitToolsThermalConductivityUnit.WattPerInchFahrenheit:
                    return UnitToolsImperialThermalConductivity.WattPerInchFahrenheitToWattPerMeterKelvin(value);
                case UnitToolsThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit:
                    return UnitToolsImperialThermalConductivity.BtuFootPerHourSquareFootFahrenheitToWattPerMeterKelvin(value);
                case UnitToolsThermalConductivityUnit.CaloriePerSecondMeterCelsius:
                    return UnitToolsMetricThermalConductivity.CaloriePerSecondMeterCelsiusToWattPerMeterKelvin(value);
                case UnitToolsThermalConductivityUnit.KilocaloriePerSecondMeterCelsius:
                    return UnitToolsMetricThermalConductivity.KilocaloriePerSecondMeterCelsiusToWattPerMeterKelvin(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported thermal conductivity unit.");
            }
        }

        public static double FromWattPerMeterKelvin(double baseValue, UnitToolsThermalConductivityUnit to)
        {
            switch (to)
            {
                case UnitToolsThermalConductivityUnit.WattPerMeterKelvin:
                    return UnitToolsMetricThermalConductivity.WattPerMeterKelvinToWattPerMeterKelvin(baseValue);
                case UnitToolsThermalConductivityUnit.MilliwattPerMeterKelvin:
                    return UnitToolsMetricThermalConductivity.WattPerMeterKelvinToMilliwattPerMeterKelvin(baseValue);
                case UnitToolsThermalConductivityUnit.KilowattPerMeterKelvin:
                    return UnitToolsMetricThermalConductivity.WattPerMeterKelvinToKilowattPerMeterKelvin(baseValue);
                case UnitToolsThermalConductivityUnit.CaloriePerSecondCentimeterCelsius:
                    return UnitToolsMetricThermalConductivity.WattPerMeterKelvinToCaloriePerSecondCentimeterCelsius(baseValue);
                case UnitToolsThermalConductivityUnit.BtuPerHourFootFahrenheit:
                    return UnitToolsImperialThermalConductivity.WattPerMeterKelvinToBtuPerHourFootFahrenheit(baseValue);
                case UnitToolsThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit:
                    return UnitToolsImperialThermalConductivity.WattPerMeterKelvinToBtuInchPerHourSquareFootFahrenheit(baseValue);
                case UnitToolsThermalConductivityUnit.WattPerMillimeterKelvin:
                    return UnitToolsMetricThermalConductivity.WattPerMeterKelvinToWattPerMillimeterKelvin(baseValue);
                case UnitToolsThermalConductivityUnit.WattPerInchFahrenheit:
                    return UnitToolsImperialThermalConductivity.WattPerMeterKelvinToWattPerInchFahrenheit(baseValue);
                case UnitToolsThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit:
                    return UnitToolsImperialThermalConductivity.WattPerMeterKelvinToBtuFootPerHourSquareFootFahrenheit(baseValue);
                case UnitToolsThermalConductivityUnit.CaloriePerSecondMeterCelsius:
                    return UnitToolsMetricThermalConductivity.WattPerMeterKelvinToCaloriePerSecondMeterCelsius(baseValue);
                case UnitToolsThermalConductivityUnit.KilocaloriePerSecondMeterCelsius:
                    return UnitToolsMetricThermalConductivity.WattPerMeterKelvinToKilocaloriePerSecondMeterCelsius(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported thermal conductivity unit.");
            }
        }

        public static string GetSymbol(UnitToolsThermalConductivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsThermalConductivityUnit.WattPerMeterKelvin:
                    return "W/(m·K)";
                case UnitToolsThermalConductivityUnit.MilliwattPerMeterKelvin:
                    return "mW/(m·K)";
                case UnitToolsThermalConductivityUnit.KilowattPerMeterKelvin:
                    return "kW/(m·K)";
                case UnitToolsThermalConductivityUnit.CaloriePerSecondCentimeterCelsius:
                    return "cal/(s·cm·°C)";
                case UnitToolsThermalConductivityUnit.BtuPerHourFootFahrenheit:
                    return "BTU/(h·ft·°F)";
                case UnitToolsThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit:
                    return "BTU·in/(h·ft²·°F)";
                case UnitToolsThermalConductivityUnit.WattPerMillimeterKelvin:
                    return "W/(mm·K)";
                case UnitToolsThermalConductivityUnit.WattPerInchFahrenheit:
                    return "W/(in·°F)";
                case UnitToolsThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit:
                    return "BTU·ft/(h·ft²·°F)";
                case UnitToolsThermalConductivityUnit.CaloriePerSecondMeterCelsius:
                    return "cal/(s·m·°C)";
                case UnitToolsThermalConductivityUnit.KilocaloriePerSecondMeterCelsius:
                    return "kcal/(s·m·°C)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsThermalConductivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsThermalConductivityUnit.WattPerMeterKelvin:
                    return "Watt Per Meter Kelvin";
                case UnitToolsThermalConductivityUnit.MilliwattPerMeterKelvin:
                    return "Milliwatt Per Meter Kelvin";
                case UnitToolsThermalConductivityUnit.KilowattPerMeterKelvin:
                    return "Kilowatt Per Meter Kelvin";
                case UnitToolsThermalConductivityUnit.CaloriePerSecondCentimeterCelsius:
                    return "Calorie Per Second Centimeter Celsius";
                case UnitToolsThermalConductivityUnit.BtuPerHourFootFahrenheit:
                    return "Btu Per Hour Foot Fahrenheit";
                case UnitToolsThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit:
                    return "Btu Inch Per Hour Square Foot Fahrenheit";
                case UnitToolsThermalConductivityUnit.WattPerMillimeterKelvin:
                    return "Watt Per Millimeter Kelvin";
                case UnitToolsThermalConductivityUnit.WattPerInchFahrenheit:
                    return "Watt Per Inch Fahrenheit";
                case UnitToolsThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit:
                    return "Btu Foot Per Hour Square Foot Fahrenheit";
                case UnitToolsThermalConductivityUnit.CaloriePerSecondMeterCelsius:
                    return "Calorie Per Second Meter Celsius";
                case UnitToolsThermalConductivityUnit.KilocaloriePerSecondMeterCelsius:
                    return "Kilocalorie Per Second Meter Celsius";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsThermalConductivityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsThermalConductivityUnit.WattPerMeterKelvin:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalConductivityUnit.MilliwattPerMeterKelvin:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalConductivityUnit.KilowattPerMeterKelvin:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalConductivityUnit.CaloriePerSecondCentimeterCelsius:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalConductivityUnit.BtuPerHourFootFahrenheit:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsThermalConductivityUnit.WattPerMillimeterKelvin:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalConductivityUnit.WattPerInchFahrenheit:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsThermalConductivityUnit.CaloriePerSecondMeterCelsius:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsThermalConductivityUnit.KilocaloriePerSecondMeterCelsius:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsThermalConductivityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsThermalConductivityUnit.WattPerMeterKelvin, UnitToolsThermalConductivityUnit.MilliwattPerMeterKelvin, UnitToolsThermalConductivityUnit.KilowattPerMeterKelvin, UnitToolsThermalConductivityUnit.CaloriePerSecondCentimeterCelsius, UnitToolsThermalConductivityUnit.WattPerMillimeterKelvin, UnitToolsThermalConductivityUnit.CaloriePerSecondMeterCelsius, UnitToolsThermalConductivityUnit.KilocaloriePerSecondMeterCelsius };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsThermalConductivityUnit.BtuPerHourFootFahrenheit, UnitToolsThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit, UnitToolsThermalConductivityUnit.WattPerInchFahrenheit, UnitToolsThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit };
                default:
                    return new[] { UnitToolsThermalConductivityUnit.WattPerMeterKelvin, UnitToolsThermalConductivityUnit.MilliwattPerMeterKelvin, UnitToolsThermalConductivityUnit.KilowattPerMeterKelvin, UnitToolsThermalConductivityUnit.CaloriePerSecondCentimeterCelsius, UnitToolsThermalConductivityUnit.BtuPerHourFootFahrenheit, UnitToolsThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit, UnitToolsThermalConductivityUnit.WattPerMillimeterKelvin, UnitToolsThermalConductivityUnit.WattPerInchFahrenheit, UnitToolsThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit, UnitToolsThermalConductivityUnit.CaloriePerSecondMeterCelsius, UnitToolsThermalConductivityUnit.KilocaloriePerSecondMeterCelsius };
            }
        }
    }
}
