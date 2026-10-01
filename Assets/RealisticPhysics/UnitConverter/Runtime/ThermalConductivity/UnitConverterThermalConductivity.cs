namespace RealisticPhysics.UnitConversion.ThermalConductivity
{
    using RealisticPhysics.UnitConversion.ThermalConductivity.Metric;
    using RealisticPhysics.UnitConversion.ThermalConductivity.Imperial;

    public enum UnitConverterThermalConductivityUnit
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

    public static class UnitConverterThermalConductivity
    {
        public static double Convert(double value, UnitConverterThermalConductivityUnit from, UnitConverterThermalConductivityUnit to)
        {
            double baseValue = ToWattPerMeterKelvin(value, from);
            return FromWattPerMeterKelvin(baseValue, to);
        }

        public static double ToWattPerMeterKelvin(double value, UnitConverterThermalConductivityUnit from)
        {
            switch (from)
            {
                case UnitConverterThermalConductivityUnit.WattPerMeterKelvin:
                    return UnitConverterMetricThermalConductivity.WattPerMeterKelvinToWattPerMeterKelvin(value);
                case UnitConverterThermalConductivityUnit.MilliwattPerMeterKelvin:
                    return UnitConverterMetricThermalConductivity.MilliwattPerMeterKelvinToWattPerMeterKelvin(value);
                case UnitConverterThermalConductivityUnit.KilowattPerMeterKelvin:
                    return UnitConverterMetricThermalConductivity.KilowattPerMeterKelvinToWattPerMeterKelvin(value);
                case UnitConverterThermalConductivityUnit.CaloriePerSecondCentimeterCelsius:
                    return UnitConverterMetricThermalConductivity.CaloriePerSecondCentimeterCelsiusToWattPerMeterKelvin(value);
                case UnitConverterThermalConductivityUnit.BtuPerHourFootFahrenheit:
                    return UnitConverterImperialThermalConductivity.BtuPerHourFootFahrenheitToWattPerMeterKelvin(value);
                case UnitConverterThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit:
                    return UnitConverterImperialThermalConductivity.BtuInchPerHourSquareFootFahrenheitToWattPerMeterKelvin(value);
                case UnitConverterThermalConductivityUnit.WattPerMillimeterKelvin:
                    return UnitConverterMetricThermalConductivity.WattPerMillimeterKelvinToWattPerMeterKelvin(value);
                case UnitConverterThermalConductivityUnit.WattPerInchFahrenheit:
                    return UnitConverterImperialThermalConductivity.WattPerInchFahrenheitToWattPerMeterKelvin(value);
                case UnitConverterThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit:
                    return UnitConverterImperialThermalConductivity.BtuFootPerHourSquareFootFahrenheitToWattPerMeterKelvin(value);
                case UnitConverterThermalConductivityUnit.CaloriePerSecondMeterCelsius:
                    return UnitConverterMetricThermalConductivity.CaloriePerSecondMeterCelsiusToWattPerMeterKelvin(value);
                case UnitConverterThermalConductivityUnit.KilocaloriePerSecondMeterCelsius:
                    return UnitConverterMetricThermalConductivity.KilocaloriePerSecondMeterCelsiusToWattPerMeterKelvin(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported thermal conductivity unit.");
            }
        }

        public static double FromWattPerMeterKelvin(double baseValue, UnitConverterThermalConductivityUnit to)
        {
            switch (to)
            {
                case UnitConverterThermalConductivityUnit.WattPerMeterKelvin:
                    return UnitConverterMetricThermalConductivity.WattPerMeterKelvinToWattPerMeterKelvin(baseValue);
                case UnitConverterThermalConductivityUnit.MilliwattPerMeterKelvin:
                    return UnitConverterMetricThermalConductivity.WattPerMeterKelvinToMilliwattPerMeterKelvin(baseValue);
                case UnitConverterThermalConductivityUnit.KilowattPerMeterKelvin:
                    return UnitConverterMetricThermalConductivity.WattPerMeterKelvinToKilowattPerMeterKelvin(baseValue);
                case UnitConverterThermalConductivityUnit.CaloriePerSecondCentimeterCelsius:
                    return UnitConverterMetricThermalConductivity.WattPerMeterKelvinToCaloriePerSecondCentimeterCelsius(baseValue);
                case UnitConverterThermalConductivityUnit.BtuPerHourFootFahrenheit:
                    return UnitConverterImperialThermalConductivity.WattPerMeterKelvinToBtuPerHourFootFahrenheit(baseValue);
                case UnitConverterThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit:
                    return UnitConverterImperialThermalConductivity.WattPerMeterKelvinToBtuInchPerHourSquareFootFahrenheit(baseValue);
                case UnitConverterThermalConductivityUnit.WattPerMillimeterKelvin:
                    return UnitConverterMetricThermalConductivity.WattPerMeterKelvinToWattPerMillimeterKelvin(baseValue);
                case UnitConverterThermalConductivityUnit.WattPerInchFahrenheit:
                    return UnitConverterImperialThermalConductivity.WattPerMeterKelvinToWattPerInchFahrenheit(baseValue);
                case UnitConverterThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit:
                    return UnitConverterImperialThermalConductivity.WattPerMeterKelvinToBtuFootPerHourSquareFootFahrenheit(baseValue);
                case UnitConverterThermalConductivityUnit.CaloriePerSecondMeterCelsius:
                    return UnitConverterMetricThermalConductivity.WattPerMeterKelvinToCaloriePerSecondMeterCelsius(baseValue);
                case UnitConverterThermalConductivityUnit.KilocaloriePerSecondMeterCelsius:
                    return UnitConverterMetricThermalConductivity.WattPerMeterKelvinToKilocaloriePerSecondMeterCelsius(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported thermal conductivity unit.");
            }
        }

        public static string GetSymbol(UnitConverterThermalConductivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterThermalConductivityUnit.WattPerMeterKelvin:
                    return "W/(m·K)";
                case UnitConverterThermalConductivityUnit.MilliwattPerMeterKelvin:
                    return "mW/(m·K)";
                case UnitConverterThermalConductivityUnit.KilowattPerMeterKelvin:
                    return "kW/(m·K)";
                case UnitConverterThermalConductivityUnit.CaloriePerSecondCentimeterCelsius:
                    return "cal/(s·cm·°C)";
                case UnitConverterThermalConductivityUnit.BtuPerHourFootFahrenheit:
                    return "BTU/(h·ft·°F)";
                case UnitConverterThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit:
                    return "BTU·in/(h·ft²·°F)";
                case UnitConverterThermalConductivityUnit.WattPerMillimeterKelvin:
                    return "W/(mm·K)";
                case UnitConverterThermalConductivityUnit.WattPerInchFahrenheit:
                    return "W/(in·°F)";
                case UnitConverterThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit:
                    return "BTU·ft/(h·ft²·°F)";
                case UnitConverterThermalConductivityUnit.CaloriePerSecondMeterCelsius:
                    return "cal/(s·m·°C)";
                case UnitConverterThermalConductivityUnit.KilocaloriePerSecondMeterCelsius:
                    return "kcal/(s·m·°C)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterThermalConductivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterThermalConductivityUnit.WattPerMeterKelvin:
                    return "Watt Per Meter Kelvin";
                case UnitConverterThermalConductivityUnit.MilliwattPerMeterKelvin:
                    return "Milliwatt Per Meter Kelvin";
                case UnitConverterThermalConductivityUnit.KilowattPerMeterKelvin:
                    return "Kilowatt Per Meter Kelvin";
                case UnitConverterThermalConductivityUnit.CaloriePerSecondCentimeterCelsius:
                    return "Calorie Per Second Centimeter Celsius";
                case UnitConverterThermalConductivityUnit.BtuPerHourFootFahrenheit:
                    return "Btu Per Hour Foot Fahrenheit";
                case UnitConverterThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit:
                    return "Btu Inch Per Hour Square Foot Fahrenheit";
                case UnitConverterThermalConductivityUnit.WattPerMillimeterKelvin:
                    return "Watt Per Millimeter Kelvin";
                case UnitConverterThermalConductivityUnit.WattPerInchFahrenheit:
                    return "Watt Per Inch Fahrenheit";
                case UnitConverterThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit:
                    return "Btu Foot Per Hour Square Foot Fahrenheit";
                case UnitConverterThermalConductivityUnit.CaloriePerSecondMeterCelsius:
                    return "Calorie Per Second Meter Celsius";
                case UnitConverterThermalConductivityUnit.KilocaloriePerSecondMeterCelsius:
                    return "Kilocalorie Per Second Meter Celsius";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterThermalConductivityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterThermalConductivityUnit.WattPerMeterKelvin:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalConductivityUnit.MilliwattPerMeterKelvin:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalConductivityUnit.KilowattPerMeterKelvin:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalConductivityUnit.CaloriePerSecondCentimeterCelsius:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalConductivityUnit.BtuPerHourFootFahrenheit:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterThermalConductivityUnit.WattPerMillimeterKelvin:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalConductivityUnit.WattPerInchFahrenheit:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterThermalConductivityUnit.CaloriePerSecondMeterCelsius:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterThermalConductivityUnit.KilocaloriePerSecondMeterCelsius:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterThermalConductivityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterThermalConductivityUnit.WattPerMeterKelvin, UnitConverterThermalConductivityUnit.MilliwattPerMeterKelvin, UnitConverterThermalConductivityUnit.KilowattPerMeterKelvin, UnitConverterThermalConductivityUnit.CaloriePerSecondCentimeterCelsius, UnitConverterThermalConductivityUnit.WattPerMillimeterKelvin, UnitConverterThermalConductivityUnit.CaloriePerSecondMeterCelsius, UnitConverterThermalConductivityUnit.KilocaloriePerSecondMeterCelsius };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterThermalConductivityUnit.BtuPerHourFootFahrenheit, UnitConverterThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit, UnitConverterThermalConductivityUnit.WattPerInchFahrenheit, UnitConverterThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit };
                default:
                    return new[] { UnitConverterThermalConductivityUnit.WattPerMeterKelvin, UnitConverterThermalConductivityUnit.MilliwattPerMeterKelvin, UnitConverterThermalConductivityUnit.KilowattPerMeterKelvin, UnitConverterThermalConductivityUnit.CaloriePerSecondCentimeterCelsius, UnitConverterThermalConductivityUnit.BtuPerHourFootFahrenheit, UnitConverterThermalConductivityUnit.BtuInchPerHourSquareFootFahrenheit, UnitConverterThermalConductivityUnit.WattPerMillimeterKelvin, UnitConverterThermalConductivityUnit.WattPerInchFahrenheit, UnitConverterThermalConductivityUnit.BtuFootPerHourSquareFootFahrenheit, UnitConverterThermalConductivityUnit.CaloriePerSecondMeterCelsius, UnitConverterThermalConductivityUnit.KilocaloriePerSecondMeterCelsius };
            }
        }
    }
}
