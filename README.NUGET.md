# UnitConverter

**High-performance .NET unit conversions — straightforward numeric APIs, strongly typed quantities, and precise calculations.**

[GitHub repository](https://github.com/Perry3Dnl/UnitConverter) · [Documentation](https://github.com/Perry3Dnl/UnitConverter/tree/main/docs) · [Release notes](https://github.com/Perry3Dnl/UnitConverter/blob/main/docs/Changelog.md)

UnitConverter includes **150 conversion families**, **1,858 registered units**, and **39,458 directed non-identity conversions** within compatible families. Choose direct numeric conversion, fluent extensions, typed quantities, exact decimal/rational conversion, dynamic parsing, or custom unit definitions. The core library has no third-party runtime package dependencies.

## Packages

| NuGet package | Purpose |
| --- | --- |
| `UnitConverter` | Full conversion engine and quantity APIs |
| `UnitConverter.SystemTextJson` | Optional `System.Text.Json` support for typed unit values |
| `UnitConverter.Analyzers` | Optional Roslyn compile-time guidance |

All three packages ship with the **same version**, starting at **1.0.0**. Install only the parts you need.

## Installation

```bash
dotnet add package UnitConverter
```

For JSON integration or analyzer diagnostics, install the matching companion package in addition to the core package.

## Quick start

```csharp
using UnitConverter;
using UnitConverter.Length;
using UnitConverter.Quantities;

// Numeric conversion: 4 km -> 4000 m.
double meters = UnitConverterLength.Convert(
    4d,
    UnitConverterLengthUnit.Kilometer,
    UnitConverterLengthUnit.Meter);

// Fluent numeric conversion.
double fluentMeters = 4d.Convert(
    UnitConverterLengthUnit.Kilometer,
    UnitConverterLengthUnit.Meter);

// Keep the unit attached to a value.
double wrappedMeters = new UnitValue<UnitConverterLengthUnit>(
    4d, UnitConverterLengthUnit.Kilometer)
    .To(UnitConverterLengthUnit.Meter).Value;

// Compile-time dimensional safety.
Length<decimal> distance = Length<decimal>.FromKilometres(4m);
decimal typedMeters = distance.Metres;
```

### Parsing, exact arithmetic, and composite units

```csharp
double speed = UnitConverterDynamic.Convert("36 km/h", "m/s");
decimal exact = UnitConverterExact.Convert(
    1m, UnitConverterLengthUnit.Inch, UnitConverterLengthUnit.Foot);
double energy = UnitConverterComposite.Convert(1d, "N*m", "J");
```

## Compatibility and design

- Core: .NET Standard 2.0 and .NET 8.
- JSON and analyzer companions: .NET Standard 2.0.
- Standalone core without third-party runtime dependencies.
- Exact decimal/rational paths, span-based parsing/formatting, localization, composite units, and arbitrary-scale number naming.
- Release validation includes tests, API compatibility checks, NativeAOT smoke tests, and clean NuGet consumers.

## Documentation and license

For complete APIs, sample programs, benchmarking, and supported families, visit the [GitHub README](https://github.com/Perry3Dnl/UnitConverter#readme).

**License:** Apache License 2.0 with Commons Clause v1.0. Redistribution is subject to the Commons Clause restriction on selling the software itself. Review the [full license](https://github.com/Perry3Dnl/UnitConverter/blob/main/LICENSE.md) before redistribution.
