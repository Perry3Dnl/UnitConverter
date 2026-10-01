using System;
using System.Globalization;
using RealisticPhysics.UnitConversion.Catalog;
using RealisticPhysics.UnitConversion.FuelEconomy;
using RealisticPhysics.UnitConversion.Length;
using RealisticPhysics.UnitConversion.Length.Metric;
using RealisticPhysics.UnitConversion.Mass;
using RealisticPhysics.UnitConversion.Temperature;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("UnitConverter: " + UnitConverterCatalog.GetFamilyNames().Length + " conversion families");

        Show("12.5 cm in mm", 125d, UnitConverterLength.Convert(
            12.5d, UnitConverterLengthUnit.Centimeter, UnitConverterLengthUnit.Millimeter));

        double centimeters = 12.5d;
        Show("Extension: 12.5 cm in mm", 125d, centimeters.Convert(
            UnitConverterLengthUnit.Centimeter, UnitConverterLengthUnit.Millimeter));

        Show("Direct method: 12.5 cm in m", 0.125d,
            UnitConverterMetricLength.CentimeterToMeter(12.5d));

        int pounds = 1;
        Show("Integer extension: 1 lb in kg", 0.45359237d, pounds.Convert(
            UnitConverterMassUnit.Pound, UnitConverterMassUnit.Kilogram));

        Show("100 Celsius in Fahrenheit", 212d, UnitConverterTemperature.Convert(
            100d, UnitConverterTemperatureUnit.Celsius, UnitConverterTemperatureUnit.Fahrenheit));

        Show("5 L/100 km in km/L", 20d, UnitConverterFuelEconomy.Convert(
            5d, UnitConverterFuelEconomyUnit.LiterPer100Kilometer, UnitConverterFuelEconomyUnit.KilometerPerLiter));
    }

    private static void Show(string label, double expected, double actual)
    {
        if (double.IsNaN(actual) || double.IsInfinity(actual) || Math.Abs(expected - actual) > Math.Abs(expected) * 1e-12d)
        {
            throw new InvalidOperationException("Unexpected conversion result for " + label);
        }

        Console.WriteLine(label + ": " + actual.ToString("G17", CultureInfo.InvariantCulture));
    }
}
