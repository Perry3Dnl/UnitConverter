using BenchmarkDotNet.Attributes;
using UnitConverter.Length;
using UnitConverter.Length.Metric;
using UnitConverter.Quantities;

namespace UnitConverter.Benchmarks;

[MemoryDiagnoser]
[SimpleJob(warmupCount: 3, iterationCount: 8)]
public class ConversionBenchmarks
{
    private double _doubleValue;
    private decimal _decimalValue;

    [GlobalSetup]
    public void Setup()
    {
        _doubleValue = 123.456d;
        _decimalValue = 123.456m;
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("Conversion", "Double", "Direct")]
    public double DirectDouble()
        => UnitConverterMetricLength.CentimeterToMeter(_doubleValue);

    [Benchmark]
    [BenchmarkCategory("Conversion", "Double", "Routed")]
    public double RoutedDouble()
        => UnitConverterLength.Convert(
            _doubleValue,
            UnitConverterLengthUnit.Centimeter,
            UnitConverterLengthUnit.Meter);

    [Benchmark]
    [BenchmarkCategory("Conversion", "Decimal", "Exact")]
    public decimal ExactDecimal()
        => global::UnitConverter.UnitConverterExact.Convert(
            _decimalValue,
            UnitConverterLengthUnit.Centimeter,
            UnitConverterLengthUnit.Meter);

    [Benchmark]
    [BenchmarkCategory("Conversion", "Decimal", "NamedQuantity")]
    public decimal NamedQuantityDecimal()
        => Length<decimal>
            .FromCentimetres(_decimalValue)
            .Metres;

    [Benchmark]
    [BenchmarkCategory("Conversion", "Decimal", "UnitQuantity")]
    public decimal UnitQuantityDecimal()
        => UnitQuantity
            .From(_decimalValue, UnitConverterLengthUnit.Centimeter)
            .As(UnitConverterLengthUnit.Meter);
}
