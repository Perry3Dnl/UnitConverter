using BenchmarkDotNet.Running;
using UnitConverter.Benchmarks;

BenchmarkRunner.Run<ConversionBenchmarks>();
BenchmarkRunner.Run<TextAndDynamicBenchmarks>();
