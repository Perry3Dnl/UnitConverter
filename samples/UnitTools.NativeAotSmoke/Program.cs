using System;
using UnitTools;
using UnitTools.Catalog;
using UnitTools.Length;
using UnitTools.Numbers;

public static class Program
{
    public static void Main()
    {
        double meters = UnitToolsLength.Convert(
            1.8d,
            UnitToolsLengthUnit.Kilometer,
            UnitToolsLengthUnit.Meter);

        Require(Math.Abs(meters - 1800d) < 1e-12d, "static conversion");

        double parsed = UnitToolsParser.Convert(
            "1.8 km",
            UnitToolsLengthUnit.Meter);

        Require(Math.Abs(parsed - 1800d) < 1e-12d, "parser");

        UnitToolsDetectionResult detected =
            UnitToolsDetector.Detect("2 light-year");

        Require(detected.Success, "global detection");
        Require(
            detected.Candidate.Family.Family == UnitToolsFamily.Length,
            "detected family");

        double speed = UnitToolsComposite.Convert(
            36d,
            "km/h",
            "m/s");

        Require(Math.Abs(speed - 10d) < 1e-12d, "composite conversion");

        UnitToolsCustomUnit custom =
            UnitToolsCustomUnits.RegisterLinear(
                UnitToolsFamily.Length,
                "AotLength",
                "aotLength",
                "Meter",
                2d);

        double customMeters =
            UnitToolsDynamic.Convert(
                "3 aotLength",
                "Meter");

        Require(Math.Abs(customMeters - 6d) < 1e-12d, "custom unit");

        var typed =
            new UnitValue<UnitToolsLengthUnit>(
                1.8d,
                UnitToolsLengthUnit.Kilometer);

        Require(
            Math.Abs(typed.As(UnitToolsLengthUnit.Meter) - 1800d) < 1e-12d,
            "typed value");

        UnitToolsUnitDescriptor kilometer =
            UnitToolsCatalog
                .GetFamily(UnitToolsFamily.Length)
                .Units[(int)UnitToolsLengthUnit.Kilometer];

        Require(kilometer.Provenance != null, "provenance");
        ArbitraryScaleNumber huge =
            ArbitraryScaleNumber.Parse("1 ginozillion");

        Require(
            huge.ToScientific() == "1e10000",
            "arbitrary-scale number");

        GeneratedNumberScalePosition generated =
            GeneratedNumberNames.Parse("ginozillion");

        Require(
            generated.Layer == 2 &&
            generated.Magnitude == 4 &&
            generated.Coefficient == 1,
            "generated number name");
        var tinyPosition =
            new GeneratedNumberScalePosition(
                GeneratedNumberScaleDirection.Tiny,
                2,
                4,
                1);

        string tinyName =
            GeneratedNumberNames.GetName(
                tinyPosition);

        Require(
            tinyName == "ginuzillion",
            "generated tiny number name");

        ArbitraryScaleNumber tiny =
            ArbitraryScaleNumber.Parse(
                "1 " + tinyName);

        Require(
            tiny.ToScientific() == "1e-10000",
            "generated tiny number scale");


    }

    private static void Require(bool condition, string name)
    {
        if (!condition)
        {
            throw new InvalidOperationException(
                "NativeAOT smoke test failed: " + name);
        }
    }
}
