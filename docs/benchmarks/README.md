# Performance benchmarks

UnitConverter uses BenchmarkDotNet for repeatable microbenchmarks of the public conversion paths.

The benchmark project is intentionally separate from the runtime solution so BenchmarkDotNet remains a development-only dependency. The core `UnitConverter` package stays free of third-party runtime dependencies.

## Covered paths

The initial baseline measures direct legacy `double`, routed `double`, exact/rational `decimal`, named quantities, `UnitQuantity<T,TUnit>`, span parsing/formatting, catalog lookup, dynamic conversion, and composite conversion/expression parsing.

Run locally:

```sh
dotnet run --project benchmarks/UnitConverter.Benchmarks/UnitConverter.Benchmarks.csproj --configuration Release
python scripts/summarize_benchmarks.py BenchmarkDotNet.Artifacts/results artifacts/benchmarks
```

GitHub Actions uploads the raw BenchmarkDotNet reports plus a compact `summary.md` and `summary.json`.

Hosted-runner timings vary. Treat published numbers as a release-comparison baseline, not absolute latency guarantees. Allocation changes are generally more stable than tiny timing differences.

## Latest baseline

The latest checked-in baseline is recorded in [BASELINE.md](BASELINE.md). README performance badges are updated from that same measured run. The initial baseline was captured from GitHub Actions run `37611558045` on the fully typed 150-family API.
