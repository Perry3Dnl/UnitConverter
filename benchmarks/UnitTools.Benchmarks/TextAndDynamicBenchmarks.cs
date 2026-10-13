using System.Globalization;
using BenchmarkDotNet.Attributes;
using UnitTools.Catalog;
using UnitTools.Length;
using UnitTools.Quantities;

namespace UnitTools.Benchmarks;

[MemoryDiagnoser]
[SimpleJob(warmupCount: 3, iterationCount: 8)]
public class TextAndDynamicBenchmarks
{
    private static readonly CultureInfo Invariant = CultureInfo.InvariantCulture;
    private static readonly CultureInfo Dutch = CultureInfo.GetCultureInfo("nl-NL");
    private readonly Length<decimal> _length = Length<decimal>.FromMetres(123.456m);
    private readonly global::UnitTools.UnitValue<UnitToolsLengthUnit> _unitValue =
        new global::UnitTools.UnitValue<UnitToolsLengthUnit>(
            123.456d,
            UnitToolsLengthUnit.Centimeter);

    [Benchmark]
    [BenchmarkCategory("Text", "Span", "Parsing")]
    public Length<decimal> SpanParseLength()
        => Length<decimal>.Parse(
            "123.456 cm".AsSpan(),
            Invariant);

    [Benchmark]
    [BenchmarkCategory("Text", "Span", "Formatting")]
    public int SpanFormatLength()
    {
        Span<char> buffer = stackalloc char[64];
        bool success = _length.TryFormat(
            buffer,
            out int written,
            "0.###".AsSpan(),
            Invariant,
            "cm".AsSpan());

        return success ? written : -1;
    }

    [Benchmark]
    [BenchmarkCategory("Text", "Localization", "Parsing")]
    public global::UnitTools.UnitToolsParsedValue<UnitToolsLengthUnit> LocalizedParseLength()
        => global::UnitTools.UnitToolsParser.Parse<UnitToolsLengthUnit>(
            "1,5 mijl",
            Dutch);

    [Benchmark]
    [BenchmarkCategory("Conversion", "UnitValue")]
    public double UnitValueConvertLength()
        => _unitValue
            .To(UnitToolsLengthUnit.Meter)
            .Value;

    [Benchmark]
    [BenchmarkCategory("Dynamic", "Localization")]
    public double LocalizedDynamicConvert()
        => global::UnitTools.UnitToolsDynamic.Convert(
            "1,5 mijl",
            UnitToolsFamily.Length,
            "voet",
            Dutch);

    [Benchmark]
    [BenchmarkCategory("Catalog", "Lookup")]
    public UnitToolsFamilyDescriptor CatalogLookup()
        => UnitToolsCatalog.GetFamily(UnitToolsFamily.Length);

    [Benchmark]
    [BenchmarkCategory("Dynamic", "FamilyScoped")]
    public double DynamicFamilyConvert()
        => global::UnitTools.UnitToolsDynamic.Convert(
            36d,
            UnitToolsFamily.Speed,
            "km/h",
            "m/s");

    [Benchmark]
    [BenchmarkCategory("Dynamic", "Detection")]
    public double DynamicDetectedConvert()
        => global::UnitTools.UnitToolsDynamic.Convert(
            "36 km/h",
            "m/s");

    [Benchmark]
    [BenchmarkCategory("Composite", "Conversion")]
    public double CompositeConvert()
        => global::UnitTools.UnitToolsComposite.Convert(
            36d,
            "km/h",
            "m/s");

    [Benchmark]
    [BenchmarkCategory("Composite", "Parsing")]
    public global::UnitTools.UnitToolsUnitExpression CompositeParse()
        => global::UnitTools.UnitToolsExpressionParser.Parse(
            "kg*m/s^2");
}
