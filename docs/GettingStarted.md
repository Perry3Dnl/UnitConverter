# Getting started

UnitTools lets you choose between direct numeric conversion, fluent numeric extensions, value-plus-unit wrappers, strongly typed quantities, and runtime/dynamic conversion. They all use the same catalog and conversion definitions; choose the surface that best fits the code you are writing.

## Build and install

From the repository root:

```sh
dotnet restore UnitTools.sln
dotnet build UnitTools.sln --configuration Release --no-restore
dotnet test tests/UnitTools.Tests/UnitTools.Tests.csproj --configuration Release --no-build
dotnet pack src/UnitTools/UnitTools.csproj --configuration Release --no-build --output artifacts/packages
```

The package candidate is not yet published to nuget.org. Install a local build into an existing application using the absolute package output directory:

```sh
dotnet add package UnitTools --version 2.0.0-preview.2 --source /absolute/path/to/UnitTools/artifacts/packages
```

Alternatively, add a project reference to `src/UnitTools/UnitTools.csproj` during development.

## Choose an API style

```csharp
using UnitTools;
using UnitTools.Length;
using UnitTools.Quantities;

// Direct numeric route.
double millimeters = UnitToolsLength.Convert(
    12.5,
    UnitToolsLengthUnit.Centimeter,
    UnitToolsLengthUnit.Millimeter);

// Fluent numeric route.
double metres = 4d.Convert(
    UnitToolsLengthUnit.Kilometer,
    UnitToolsLengthUnit.Meter);

// Keep the unit with the value.
var distance = new UnitValue<UnitToolsLengthUnit>(
    4d,
    UnitToolsLengthUnit.Kilometer)
    .To(UnitToolsLengthUnit.Meter);

// Compile-time dimensional safety.
Length<decimal> typed = Length<decimal>.FromKilometres(4m);
```

Each family has its own unit enum and a stable catalog base unit. The numeric APIs remain first-class; typed quantities are an additional safety level, not a replacement.

## Use extensions or direct methods

```csharp
using UnitTools.Length;
using UnitTools.Length.Metric;

double value = 12.5;
double millimeters = value.Convert(
    UnitToolsLengthUnit.Centimeter,
    UnitToolsLengthUnit.Millimeter);
double meters = UnitToolsMetricLength.CentimeterToMeter(value);
```

The conversion API and numeric behavior match the original 1.1.3 core. Read the [migration notes](Migration.md) for compatibility details and existing limitations.

## Explore the sample

```sh
dotnet run --project samples/UnitTools.Demo --configuration Release
```

The console sample demonstrates static, extension, and direct APIs, plus temperature offsets and reciprocal fuel-economy conversions.
