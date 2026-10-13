using System;
using System.Globalization;
using UnitTools.Catalog;
using UnitTools.FuelEconomy;
using UnitTools.Length;
using UnitTools.Length.Metric;
using UnitTools.Mass;
using UnitTools.Temperature;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("UnitTools: " + UnitToolsCatalog.GetFamilyNames().Length + " conversion families");

        Show("12.5 cm in mm", 125d, UnitToolsLength.Convert(
            12.5d, UnitToolsLengthUnit.Centimeter, UnitToolsLengthUnit.Millimeter));

        double centimeters = 12.5d;
        Show("Extension: 12.5 cm in mm", 125d, centimeters.Convert(
            UnitToolsLengthUnit.Centimeter, UnitToolsLengthUnit.Millimeter));

        Show("Direct method: 12.5 cm in m", 0.125d,
            UnitToolsMetricLength.CentimeterToMeter(12.5d));

        int pounds = 1;
        Show("Integer extension: 1 lb in kg", 0.45359237d, pounds.Convert(
            UnitToolsMassUnit.Pound, UnitToolsMassUnit.Kilogram));

        Show("100 Celsius in Fahrenheit", 212d, UnitToolsTemperature.Convert(
            100d, UnitToolsTemperatureUnit.Celsius, UnitToolsTemperatureUnit.Fahrenheit));

        Show("5 L/100 km in km/L", 20d, UnitToolsFuelEconomy.Convert(
            5d, UnitToolsFuelEconomyUnit.LiterPer100Kilometer, UnitToolsFuelEconomyUnit.KilometerPerLiter));
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
