# Benchmark baseline — typed 150-family API

Captured on **2026-10-07** from commit `c2366cde208bd2453f1e8fd92e22bebf20df2431` by GitHub Actions run `37611558045`.

Environment: BenchmarkDotNet **0.15.8**, Ubuntu **24.04.5 LTS**, AMD EPYC 7763 3.24 GHz, .NET SDK **10.0.401**, .NET **10.0.12**, X64 RyuJIT x86-64-v3. The job requested three warmup iterations and eight measurement iterations.

| Benchmark | Mean | Allocated |
| --- | ---: | ---: |
| Direct double | below measurable harness overhead | 0 B |
| Routed double | 2.4289 ns | 0 B |
| Exact decimal | 605.3082 ns | 96 B |
| Named quantity decimal | 36.3218 ns | 0 B |
| Universal `UnitQuantity` decimal | 663.6867 ns | 96 B |
| Span parse — Length | 863.064 ns | 0 B |
| Span format — Length | 823.742 ns | 0 B |
| Catalog lookup | 2.807 ns | 0 B |
| Dynamic family conversion | 105.986 ns | 48 B |
| Dynamic auto-detected conversion | 44,974.918 ns | 6,560 B |
| Composite conversion | 174,029.233 ns | 27,648 B |
| Composite expression parse | 132,391.465 ns | 20,840 B |

`DirectDouble` was faster than BenchmarkDotNet's measured invocation overhead after overhead subtraction, so the report rounded it to `0.0000 ns`. It is deliberately recorded as **below measurable harness overhead** rather than advertised as a zero-cost operation.

## What this baseline tells us

The direct/routed numeric paths and catalog lookup are already allocation-free. The named decimal Length path is also allocation-free.

The first concrete optimization targets are now measurable:

- remove or reduce the **96 B/op** currently allocated by the generic exact-decimal and `UnitQuantity<decimal,...>` routes;
- preserve **0 B** span parsing and formatting while reducing their sub-microsecond latency;
- reduce allocations in family-scoped dynamic conversion;
- treat auto-detection and composite parsing/conversion as the high-cost parsing paths, where caching and lookup structure changes can have meaningful impact.

These are release-comparison measurements, not API performance guarantees. Hosted GitHub runners vary between runs, so small timing differences should not be treated as regressions without repeated evidence. Allocation changes are generally the stronger signal.

Raw BenchmarkDotNet CSV/Markdown/HTML reports and the generated compact summary are published by the `Performance Benchmarks` workflow.
