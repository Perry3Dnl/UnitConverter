using System;
using UnitConverter;
using UnitConverter.Catalog;
using UnitConverter.Length;

public static class Program
{
    public static void Main()
    {
        double meters = UnitConverterLength.Convert(
            1.8d,
            UnitConverterLengthUnit.Kilometer,
            UnitConverterLengthUnit.Meter);

        Require(Math.Abs(meters - 1800d) < 1e-12d, "static conversion");

        double parsed = UnitConverterParser.Convert(
            "1.8 km",
            UnitConverterLengthUnit.Meter);

        Require(Math.Abs(parsed - 1800d) < 1e-12d, "parser");

        UnitConverterDetectionResult detected =
            UnitConverterDetector.Detect("2 light-year");

        Require(detected.Success, "global detection");
        Require(
            detected.Candidate.Family.Family == UnitConverterFamily.Length,
            "detected family");

        double speed = UnitConverterComposite.Convert(
            36d,
            "km/h",
            "m/s");

        Require(Math.Abs(speed - 10d) < 1e-12d, "composite conversion");

        UnitConverterCustomUnit custom =
            UnitConverterCustomUnits.RegisterLinear(
                UnitConverterFamily.Length,
                "AotLength",
                "aotLength",
                "Meter",
                2d);

        double customMeters =
            UnitConverterDynamic.Convert(
                "3 aotLength",
                "Meter");

        Require(Math.Abs(customMeters - 6d) < 1e-12d, "custom unit");

        var typed =
            new UnitValue<UnitConverterLengthUnit>(
                1.8d,
                UnitConverterLengthUnit.Kilometer);

        Require(
            Math.Abs(typed.As(UnitConverterLengthUnit.Meter) - 1800d) < 1e-12d,
            "typed value");

        UnitConverterUnitDescriptor kilometer =
            UnitConverterCatalog
                .GetFamily(UnitConverterFamily.Length)
                .Units[(int)UnitConverterLengthUnit.Kilometer];

        Require(kilometer.Provenance != null, "provenance");
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
