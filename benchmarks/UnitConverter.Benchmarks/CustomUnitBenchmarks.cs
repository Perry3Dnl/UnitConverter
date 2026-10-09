using BenchmarkDotNet.Attributes;
using UnitConverter.Catalog;

namespace UnitConverter.Benchmarks;

[MemoryDiagnoser]
[SimpleJob(warmupCount: 3, iterationCount: 8)]
public class CustomUnitBenchmarks
{
    [GlobalSetup]
    public void Setup()
    {
        global::UnitConverter.UnitConverterCustomUnits.Clear();
        global::UnitConverter.UnitConverterCustomUnits.RegisterLinear(
            UnitConverterFamily.Length,
            "BenchmarkLength",
            "benchLen",
            "Meter",
            2d);
    }

    [GlobalCleanup]
    public void Cleanup()
    {
        global::UnitConverter.UnitConverterCustomUnits.Clear();
    }

    [Benchmark]
    [BenchmarkCategory("Dynamic", "CustomUnit")]
    public double CustomUnitConvert()
        => global::UnitConverter.UnitConverterDynamic.Convert(
            12.5d,
            UnitConverterFamily.Length,
            "benchLen",
            "m");
}
