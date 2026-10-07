using BenchmarkDotNet.Attributes;
using UnitConverter.Length;
using UnitConverter.Length.Metric;
using UnitConverter.Quantities;

namespace UnitConverter.Benchmarks;

[MemoryDiagnoser]
[SimpleJob(warmupCount: 3, iterationCount: 8)]
public class ConversionBenchmarks
{
    private const double DoubleValue = 123.456d;
    private const decimal DecimalValue = 123.456m;

    [Benchmark(Baseline = true)]
    public double DirectDouble()
        => UnitConverterMetricLength.CentimeterToMeter(DoubleValue);

    [Benchmark]
    public double RoutedDouble()
        => UnitConverterLength.Convert(
            DoubleValue,
            UnitConverterLengthUnit.Centimeter,
            UnitConverterLengthUnit.Meter);

    [Benchmark]
    public decimal ExactDecimal()
        => global::UnitConverter.UnitConverterExact.Convert(
            DecimalValue,
            UnitConverterLengthUnit.Centimeter,
            UnitConverterLengthUnit.Meter);

    [Benchmark]
    public decimal NamedQuantityDecimal()
        => Length<decimal>
            .FromCentimetres(DecimalValue)
            .Metres;

    [Benchmark]
    public decimal UnitQuantityDecimal()
        => UnitQuantity
            .From(DecimalValue, UnitConverterLengthUnit.Centimeter)
            .As(UnitConverterLengthUnit.Meter);
}
