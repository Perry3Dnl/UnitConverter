using BenchmarkDotNet.Running;
using UnitConverter.Benchmarks;

BenchmarkSwitcher
    .FromAssembly(typeof(ConversionBenchmarks).Assembly)
    .Run(args);
