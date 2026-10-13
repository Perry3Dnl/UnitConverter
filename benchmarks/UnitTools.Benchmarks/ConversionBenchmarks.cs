using BenchmarkDotNet.Attributes;
using UnitTools.Length;
using UnitTools.Length.Metric;
using UnitTools.Quantities;

namespace UnitTools.Benchmarks;

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
        => UnitToolsMetricLength.CentimeterToMeter(_doubleValue);

    [Benchmark]
    [BenchmarkCategory("Conversion", "Double", "Routed")]
    public double RoutedDouble()
        => UnitToolsLength.Convert(
            _doubleValue,
            UnitToolsLengthUnit.Centimeter,
            UnitToolsLengthUnit.Meter);

    [Benchmark]
    [BenchmarkCategory("Conversion", "Decimal", "Exact")]
    public decimal ExactDecimal()
        => global::UnitTools.UnitToolsExact.Convert(
            _decimalValue,
            UnitToolsLengthUnit.Centimeter,
            UnitToolsLengthUnit.Meter);

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
            .From(_decimalValue, UnitToolsLengthUnit.Centimeter)
            .As(UnitToolsLengthUnit.Meter);
}
