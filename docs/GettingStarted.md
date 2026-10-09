# Getting started

UnitConverter lets you choose between direct numeric conversion, fluent numeric extensions, value-plus-unit wrappers, strongly typed quantities, and runtime/dynamic conversion. They all use the same catalog and conversion definitions; choose the surface that best fits the code you are writing.

## Build and install

From the repository root:

```sh
dotnet restore UnitConverter.sln
dotnet build UnitConverter.sln --configuration Release --no-restore
dotnet test tests/UnitConverter.Tests/UnitConverter.Tests.csproj --configuration Release --no-build
dotnet pack src/UnitConverter/UnitConverter.csproj --configuration Release --no-build --output artifacts/packages
```

The package candidate is not yet published to nuget.org. Install a local build into an existing application using the absolute package output directory:

```sh
dotnet add package UnitConverter --version 2.0.0-preview.2 --source /absolute/path/to/UnitConverter/artifacts/packages
```

Alternatively, add a project reference to `src/UnitConverter/UnitConverter.csproj` during development.

## Choose an API style

```csharp
using UnitConverter;
using UnitConverter.Length;
using UnitConverter.Quantities;

// Direct numeric route.
double millimeters = UnitConverterLength.Convert(
    12.5,
    UnitConverterLengthUnit.Centimeter,
    UnitConverterLengthUnit.Millimeter);

// Fluent numeric route.
double metres = 4d.Convert(
    UnitConverterLengthUnit.Kilometer,
    UnitConverterLengthUnit.Meter);

// Keep the unit with the value.
var distance = new UnitValue<UnitConverterLengthUnit>(
    4d,
    UnitConverterLengthUnit.Kilometer)
    .To(UnitConverterLengthUnit.Meter);

// Compile-time dimensional safety.
Length<decimal> typed = Length<decimal>.FromKilometres(4m);
```

Each family has its own unit enum and a stable catalog base unit. The numeric APIs remain first-class; typed quantities are an additional safety level, not a replacement.

## Use extensions or direct methods

```csharp
using UnitConverter.Length;
using UnitConverter.Length.Metric;

double value = 12.5;
double millimeters = value.Convert(
    UnitConverterLengthUnit.Centimeter,
    UnitConverterLengthUnit.Millimeter);
double meters = UnitConverterMetricLength.CentimeterToMeter(value);
```

The conversion API and numeric behavior match the original 1.1.3 core. Read the [migration notes](Migration.md) for compatibility details and existing limitations.

## Explore the sample

```sh
dotnet run --project samples/UnitConverter.Demo --configuration Release
```

The console sample demonstrates static, extension, and direct APIs, plus temperature offsets and reciprocal fuel-economy conversions.
