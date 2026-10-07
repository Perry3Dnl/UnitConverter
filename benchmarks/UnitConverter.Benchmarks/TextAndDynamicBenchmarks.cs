using System.Globalization;
using BenchmarkDotNet.Attributes;
using UnitConverter.Catalog;
using UnitConverter.Quantities;

namespace UnitConverter.Benchmarks;

[MemoryDiagnoser]
[SimpleJob(warmupCount: 3, iterationCount: 8)]
public class TextAndDynamicBenchmarks
{
    private static readonly CultureInfo Invariant = CultureInfo.InvariantCulture;
    private readonly Length<decimal> _length = Length<decimal>.FromMetres(123.456m);

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
    [BenchmarkCategory("Catalog", "Lookup")]
    public UnitConverterFamilyDescriptor CatalogLookup()
        => UnitConverterCatalog.GetFamily(UnitConverterFamily.Length);

    [Benchmark]
    [BenchmarkCategory("Dynamic", "FamilyScoped")]
    public double DynamicFamilyConvert()
        => global::UnitConverter.UnitConverterDynamic.Convert(
            36d,
            UnitConverterFamily.Speed,
            "km/h",
            "m/s");

    [Benchmark]
    [BenchmarkCategory("Dynamic", "Detection")]
    public double DynamicDetectedConvert()
        => global::UnitConverter.UnitConverterDynamic.Convert(
            "36 km/h",
            "m/s");

    [Benchmark]
    [BenchmarkCategory("Composite", "Conversion")]
    public double CompositeConvert()
        => global::UnitConverter.UnitConverterComposite.Convert(
            36d,
            "km/h",
            "m/s");

    [Benchmark]
    [BenchmarkCategory("Composite", "Parsing")]
    public global::UnitConverter.UnitConverterUnitExpression CompositeParse()
        => global::UnitConverter.UnitConverterExpressionParser.Parse(
            "kg*m/s^2");
}
