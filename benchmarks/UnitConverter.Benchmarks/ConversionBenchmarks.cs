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
    public double DirectDouble()
        => UnitConverterMetricLength.CentimeterToMeter(_doubleValue);

    [Benchmark]
    public double RoutedDouble()
        => UnitConverterLength.Convert(
            _doubleValue,
            UnitConverterLengthUnit.Centimeter,
            UnitConverterLengthUnit.Meter);

    [Benchmark]
    public decimal ExactDecimal()
        => global::UnitConverter.UnitConverterExact.Convert(
            _decimalValue,
            UnitConverterLengthUnit.Centimeter,
            UnitConverterLengthUnit.Meter);

    [Benchmark]
    public decimal NamedQuantityDecimal()
        => Length<decimal>
            .FromCentimetres(_decimalValue)
            .Metres;

    [Benchmark]
    public decimal UnitQuantityDecimal()
        => UnitQuantity
            .From(_decimalValue, UnitConverterLengthUnit.Centimeter)
            .As(UnitConverterLengthUnit.Meter);
}
