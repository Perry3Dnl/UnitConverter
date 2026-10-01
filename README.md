# RealisticPhysics UnitConverter

A standalone .NET unit conversion library with **97 conversion families** and **1,632 unit entries**, including aliases. It provides static converters, direct conversion methods, numeric extensions, and unit metadata without Unity dependencies.

The package candidate is **`RealisticPhysics.UnitConversion` `2.0.0-preview.1`**, targeting **.NET Standard 2.0**. This repository prepares the package; it has not been published to nuget.org.

## Build, test and create a package

Install the [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0), then run these commands from the repository root:

```sh
dotnet restore UnitConverter.sln
dotnet build UnitConverter.sln --configuration Release --no-restore
dotnet test tests/RealisticPhysics.UnitConversion.Tests/RealisticPhysics.UnitConversion.Tests.csproj --configuration Release --no-build
dotnet pack src/RealisticPhysics.UnitConversion/RealisticPhysics.UnitConversion.csproj --configuration Release --no-build --output artifacts/packages
```

The `.nupkg` and `.snupkg` are written to `artifacts/packages`. The SDK is a build requirement; consumers need a runtime compatible with .NET Standard 2.0.

Install the candidate into an existing application using the absolute path to that directory:

```sh
dotnet add package RealisticPhysics.UnitConversion --version 2.0.0-preview.1 --source /absolute/path/to/UnitConverter/artifacts/packages
```

GitHub Actions also builds the solution, runs the NUnit suite, creates the packages, and tests installation into a clean console application. Successful runs expose a `nuget-packages` artifact.

## Use the existing API

```csharp
using RealisticPhysics.UnitConversion.Length;
using RealisticPhysics.UnitConversion.Length.Metric;

// Static router: source unit -> family base unit -> target unit.
double millimeters = UnitConverterLength.Convert(
    12.5,
    UnitConverterLengthUnit.Centimeter,
    UnitConverterLengthUnit.Millimeter);

// Numeric extension: the same converter and arithmetic.
double centimeters = 12.5;
double alsoMillimeters = centimeters.Convert(
    UnitConverterLengthUnit.Centimeter,
    UnitConverterLengthUnit.Millimeter);

// Direct method for a known conversion.
double meters = UnitConverterMetricLength.CentimeterToMeter(12.5);
```

Names, enum values, conversion factors, overloads, and the base-unit conversion flow are preserved from version 1.1.3. Integral extensions continue to return `double`; existing `decimal` overloads still calculate through `double`. The legacy `PixelPerUnityUnit` entry remains a numeric compatibility alias with its original one-unit-equals-one-metre convention.

## Repository layout

| Path | Contents |
| --- | --- |
| `src/RealisticPhysics.UnitConversion` | Conversion library, retaining the family and unit-system folders |
| `tests/RealisticPhysics.UnitConversion.Tests` | Migrated NUnit tests and assembly checks |
| `samples/UnitConverter.Demo` | Console examples of the existing APIs |
| `docs` | API guides, supported units, migration notes, and developer documentation |
| `scripts/verify_package.py` | Package inspection and installation check |

Run the sample with:

```sh
dotnet run --project samples/UnitConverter.Demo --configuration Release
```

## Documentation

- [Getting started](docs/GettingStarted.md)
- [Documentation index](docs/README.md)
- [Supported families and units](docs/API/SupportedFamiliesAndUnits.md)
- [Migration from the Unity package](docs/Migration.md)
- [Testing](docs/Developer/Testing.md)
- [Packaging](docs/Developer/Packaging.md)

Unity inspectors, settings assets, scenes, assembly definitions, metadata files, and the shared Unity Core layer have been removed. The original Unity package remains available in [the 1.1.3 import commit](https://github.com/Perry3Dnl/UnitConverter/tree/332369313b1a428a66432e811c542562efa24e40).
