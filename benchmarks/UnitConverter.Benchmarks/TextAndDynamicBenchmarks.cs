using System.Globalization;
using BenchmarkDotNet.Attributes;
using UnitConverter.Catalog;
using UnitConverter.Length;
using UnitConverter.Quantities;

namespace UnitConverter.Benchmarks;

[MemoryDiagnoser]
[SimpleJob(warmupCount: 3, iterationCount: 8)]
public class TextAndDynamicBenchmarks
{
    private static readonly CultureInfo Invariant = CultureInfo.InvariantCulture;
    private static readonly CultureInfo Dutch = CultureInfo.GetCultureInfo("nl-NL");
    private readonly Length<decimal> _length = Length<decimal>.FromMetres(123.456m);
    private readonly global::UnitConverter.UnitValue<UnitConverterLengthUnit> _unitValue =
        new global::UnitConverter.UnitValue<UnitConverterLengthUnit>(
            123.456d,
            UnitConverterLengthUnit.Centimeter);

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
    public global::UnitConverter.UnitConverterParsedValue<UnitConverterLengthUnit> LocalizedParseLength()
        => global::UnitConverter.UnitConverterParser.Parse<UnitConverterLengthUnit>(
            "1,5 mijl",
            Dutch);

    [Benchmark]
    [BenchmarkCategory("Conversion", "UnitValue")]
    public double UnitValueConvertLength()
        => _unitValue
            .To(UnitConverterLengthUnit.Meter)
            .Value;

    [Benchmark]
    [BenchmarkCategory("Dynamic", "Localization")]
    public double LocalizedDynamicConvert()
        => global::UnitConverter.UnitConverterDynamic.Convert(
            "1,5 mijl",
            UnitConverterFamily.Length,
            "voet",
            Dutch);

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
