# Performance benchmarks

UnitConverter uses BenchmarkDotNet for repeatable performance and allocation measurements. The benchmark project is intentionally separate from the normal solution build so BenchmarkDotNet is never a runtime or package dependency of `UnitConverter`.

## Run the complete suite

```sh
dotnet run --project benchmarks/UnitConverter.Benchmarks/UnitConverter.Benchmarks.csproj -c Release -- --filter "*"
```

The checked-in benchmark project uses three warmup iterations and eight measurement iterations per benchmark.

## Run focused profiles

Benchmark methods are categorized so optimization work can run only the relevant paths.

```sh
# Numeric conversion and typed quantity paths
dotnet run --project benchmarks/UnitConverter.Benchmarks/UnitConverter.Benchmarks.csproj -c Release -- --anyCategories Conversion

# Span parsing and formatting only
dotnet run --project benchmarks/UnitConverter.Benchmarks/UnitConverter.Benchmarks.csproj -c Release -- --anyCategories Span

# Dynamic conversion only
dotnet run --project benchmarks/UnitConverter.Benchmarks/UnitConverter.Benchmarks.csproj -c Release -- --anyCategories Dynamic

# Composite expression paths
dotnet run --project benchmarks/UnitConverter.Benchmarks/UnitConverter.Benchmarks.csproj -c Release -- --anyCategories Composite
```

Standard BenchmarkDotNet filters also work:

```sh
dotnet run --project benchmarks/UnitConverter.Benchmarks/UnitConverter.Benchmarks.csproj -c Release -- --filter "*ConversionBenchmarks*"
```

## Covered paths

The suite measures representative hot paths for:

- direct legacy `double` conversion;
- routed family `double` conversion;
- exact/rational `decimal` conversion;
- named strongly typed quantities;
- universal `UnitQuantity<T,TUnit>`;
- span parsing;
- span formatting;
- catalog lookup;
- family-scoped dynamic conversion;
- auto-detected dynamic conversion;
- composite conversion;
- composite expression parsing.

All benchmark classes use BenchmarkDotNet's `MemoryDiagnoser`, so allocated bytes per operation are tracked alongside timing.

## Publishing results and badges

The `Performance Benchmarks` workflow uploads the raw BenchmarkDotNet CSV, Markdown and HTML reports together with a compact JSON/Markdown summary and a regression comparison against the previously checked-in successful `main` result.

On a successful push to `main`, the workflow also regenerates:

- `docs/benchmarks/latest.json`;
- `docs/benchmarks/badges/routed-double.svg`;
- `docs/benchmarks/badges/named-decimal.svg`;
- `docs/benchmarks/badges/span-parse.svg`;
- `docs/benchmarks/badges/span-format.svg`;
- `docs/benchmarks/badges/exact-decimal.svg`.

Only those generated result assets are committed by the workflow. The commit uses `[skip ci]`, and changes under `docs/benchmarks` do not retrigger the benchmark workflow.

The README badges therefore show the latest successful `main` measurement rather than a manually copied value. If the regression check fails, the previous successful badge set remains in place.

## Regression comparison

Before a new run overwrites `docs/benchmarks/latest.json`, the workflow copies the existing file as its reference baseline. `scripts/compare_benchmarks.py` then compares every benchmark method in the current run with that reference.

The CI policy deliberately distinguishes deterministic allocation changes from noisy hosted-runner timing:

- an allocation increase is a blocking regression;
- a benchmark that disappears from the current full run is blocking;
- a timing increase of **15% or more** is reported as a warning in the GitHub job summary, but does **not** fail CI;
- timing improvements of **15% or more** are highlighted as improvements;
- new benchmarks are reported without failing the run.

The comparison produces `artifacts/benchmarks/comparison.md` and `comparison.json`, both of which are included in the benchmark artifact even when the strict allocation check fails.

You can run the same comparison locally after generating a current summary:

```sh
python scripts/compare_benchmarks.py \
  docs/benchmarks/latest.json \
  artifacts/benchmarks/summary.json \
  artifacts/benchmarks/comparison \
  --timing-warning-percent 15 \
  --fail-on-allocation-regression \
  --fail-on-missing
```

## Interpreting regressions

GitHub-hosted runner latency varies. A small timing change on one run is not a release blocker by itself.

Use these signals in order:

1. **Allocations.** A change from 0 B to an allocation, or any increase in a previously allocating hot path, is treated as a concrete regression by CI.
2. **Large timing changes.** A 15% or larger increase is surfaced immediately for investigation, but remains non-blocking until it is reproduced.
3. **Repeated trends.** Prefer several measurements over reacting to one noisy hosted-runner result.
4. **Release baselines.** Record important release measurements in [BASELINE.md](BASELINE.md) with runner/runtime details.

For very small operations, BenchmarkDotNet can report a result at or below harness overhead. Do not advertise such a result as literal zero execution cost.

## Current optimization targets

The first 150-family baseline identified these high-value targets:

- exact decimal conversion currently allocates;
- universal `UnitQuantity<decimal,TUnit>` inherits that exact-decimal allocation;
- family-scoped dynamic conversion has a small allocation;
- auto-detection and composite expression paths are substantially more expensive and allocate considerably more than the typed/direct paths;
- span parsing and formatting are already allocation-free and should remain that way during latency optimization.
