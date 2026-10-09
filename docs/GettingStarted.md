# Getting started

The library targets .NET Standard 2.0. Building the repository and running its tests or console sample requires the .NET 10 SDK selected by `global.json`.

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

## Pick the level of unit safety you need

The simplest API keeps values as ordinary numbers:

```csharp
using UnitConverter.Length;

double metres = UnitConverterLength.Convert(
    4d,
    UnitConverterLengthUnit.Kilometer,
    UnitConverterLengthUnit.Meter);

double centimetres = 4d
    .Convert(UnitConverterLengthUnit.Kilometer, UnitConverterLengthUnit.Meter)
    .Convert(UnitConverterLengthUnit.Meter, UnitConverterLengthUnit.Centimeter);
```

When retaining unit state is useful, use `UnitValue<TUnit>`:

```csharp
var distance = new UnitValue<UnitConverterLengthUnit>(
    4d,
    UnitConverterLengthUnit.Kilometer);

double metres = distance
    .To(UnitConverterLengthUnit.Meter)
    .Value;
```

On .NET 8+, use named quantities when compile-time dimensional safety matters:

```csharp
using UnitConverter.Quantities;

Length<decimal> distance = Length<decimal>.FromKilometres(4m);
Speed<decimal> speed = distance / Time<decimal>.FromSeconds(20m);
```

For runtime unit text, use `UnitConverterDynamic`; for decimal-native conversion use `UnitConverterExact`. These APIs are complementary rather than replacements for one another.

## Convert a value

```csharp
using UnitConverter.Length;

double millimeters = UnitConverterLength.Convert(
    12.5,
    UnitConverterLengthUnit.Centimeter,
    UnitConverterLengthUnit.Millimeter);
```

Each family has its own unit enum and converts through a family base unit. Length converts through metres; temperature converts through kelvin. Choose source and destination units from the same family.

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
