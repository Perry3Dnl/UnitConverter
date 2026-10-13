using BenchmarkDotNet.Running;
using UnitTools.Benchmarks;

BenchmarkSwitcher
    .FromAssembly(typeof(ConversionBenchmarks).Assembly)
    .Run(args);
