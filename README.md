# UnitConverter

[![build](https://github.com/Perry3Dnl/UnitConverter/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/Perry3Dnl/UnitConverter/actions/workflows/ci.yml)
[![benchmarks](https://github.com/Perry3Dnl/UnitConverter/actions/workflows/benchmarks.yml/badge.svg?branch=main)](https://github.com/Perry3Dnl/UnitConverter/actions/workflows/benchmarks.yml)
[![routed double](https://img.shields.io/badge/routed%20double-2.43%20ns%2Fop-brightgreen.svg)](docs/benchmarks/BASELINE.md)
[![named decimal](https://img.shields.io/badge/named%20decimal-36.3%20ns%2Fop-brightgreen.svg)](docs/benchmarks/BASELINE.md)
[![span parse](https://img.shields.io/badge/span%20parse-863%20ns%20%7C%200%20B-blue.svg)](docs/benchmarks/BASELINE.md)
[![span format](https://img.shields.io/badge/span%20format-824%20ns%20%7C%200%20B-blue.svg)](docs/benchmarks/BASELINE.md)
[![exact decimal](https://img.shields.io/badge/exact%20decimal-605%20ns%20%7C%2096%20B-blue.svg)](docs/benchmarks/BASELINE.md)

A standalone .NET unit conversion library with **150 conversion families** and **1,858 unit entries**, including aliases. It provides static converters, direct conversion methods, numeric extensions, and unit metadata without Unity dependencies.

The package candidate is **`UnitConverter` `2.0.0-preview.1`**, targeting **.NET Standard 2.0**. This repository prepares the package; it has not been published to nuget.org.

## Performance baseline

UnitConverter has a dedicated BenchmarkDotNet suite covering direct/routed conversion, exact decimal arithmetic, named and universal quantities, span parsing/formatting, catalog lookup, dynamic conversion, and composite expressions.

The current GitHub-hosted baseline includes **2.43 ns / 0 B** for routed `double`, **36.3 ns / 0 B** for named `decimal`, **863 ns / 0 B** for span parsing, and **824 ns / 0 B** for span formatting. Exact decimal currently measures **605 ns / 96 B**, giving the optimization pass a concrete allocation target.

See [the full benchmark baseline](docs/benchmarks/BASELINE.md) for all measurements and runner details. Hosted-runner timings vary; badges represent the checked-in baseline, not an absolute latency guarantee.

## Build, test and create a package

Install the [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0), then run these commands from the repository root:

```sh
dotnet restore UnitConverter.sln
dotnet build UnitConverter.sln --configuration Release --no-restore
dotnet test tests/UnitConverter.Tests/UnitConverter.Tests.csproj --configuration Release --no-build
dotnet pack src/UnitConverter/UnitConverter.csproj --configuration Release --no-build --output artifacts/packages
```

The `.nupkg` and `.snupkg` are written to `artifacts/packages`. The SDK is a build requirement; consumers need a runtime compatible with .NET Standard 2.0.

Install the candidate into an existing application using the absolute path to that directory:

```sh
dotnet add package UnitConverter --version 2.0.0-preview.1 --source /absolute/path/to/UnitConverter/artifacts/packages
```

GitHub Actions also builds the solution, runs the NUnit suite, creates the packages, and tests installation into a clean console application. Successful runs expose a `nuget-packages` artifact. CI also publishes and executes NativeAOT smoke consumers for the core APIs and the System.Text.Json companion; AOT builds treat trimming/dynamic-code warnings as errors.

## Use the existing API

```csharp
using UnitConverter.Length;
using UnitConverter.Length.Metric;

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

The root namespace is now `UnitConverter`. Converter class names, existing enum values, conversion factors, overloads, and the base-unit conversion flow are preserved from version 1.1.3. Higher-level APIs are additive: strings can be parsed and formatted through the shared catalog, and `UnitValue<TUnit>` can retain a unit when that is useful without replacing the numeric API.

```csharp
double miles = UnitConverterParser.Convert("1.8 km", UnitConverterLengthUnit.Mile);

var distance = new UnitValue<UnitConverterLengthUnit>(1.8, UnitConverterLengthUnit.Kilometer);
string text = distance.ToString(); // "1.8 km"
```

`TemperatureDelta` is a separate family from absolute `Temperature`, so temperature differences use scale factors without absolute-temperature offsets.

Runtime family detection is also available when the caller does not know the family in advance:

```csharp
UnitConverterDetectionResult detected = UnitConverterDetector.Detect("2 light-year");

// Or convert directly when the detected family is unambiguous.
double meters = UnitConverterDynamic.Convert("2 light-year", "m");
```

Global detection returns explicit candidates for ambiguous symbols instead of guessing. Family and unit descriptors also expose physical dimensions, including a separate information dimension for digital storage/data rate. Dimensions can be multiplied, divided, and raised to integer powers for future dimensional-analysis APIs. Fuel economy is modeled with unit-specific reciprocal dimensions because `km/L` and `L/100 km` are physically reciprocal representations.

Aliases are definition-driven. Curated vocabulary lives in `definitions/unit-aliases.json`; `scripts/generate_aliases.py` combines those overrides with safe generated human forms for all 150 families and 1,858 unit entries, then emits checked-in static C#. CI verifies the generated files are current, so consumers do not need Python and the runtime remains dependency-free.

Composite unit expressions are supported through the dimensional metadata:

```csharp
double metersPerSecond = UnitConverterComposite.Convert(
    36,
    "km/h",
    "m/s"); // 10

double joules = UnitConverterComposite.Convert(
    1,
    "N*m",
    "J"); // 1

UnitConverterUnitExpression expression =
    UnitConverterExpressionParser.Parse("kg*m/s^2");
```

The expression parser supports multiplication, division, parentheses, integer powers, superscript `²`/`³`, and middle-dot notation. Ambiguous symbols remain explicit when parsed alone. When a complete conversion provides enough dimensional context, ambiguity can be resolved safely; for example `h` can mean hour or Planck constant, but `km/h -> m/s` has only one dimensionally compatible interpretation.

### Custom units

Runtime custom units can be registered without modifying the built-in enums or generated catalogue:

```csharp
UnitConverterCustomUnit perryLength =
    UnitConverterCustomUnits.RegisterLinear(
        UnitConverterFamily.Length,
        "PerryLength",
        "perryLength",
        "Meter",
        1.7018);

double meters = UnitConverterDynamic.Convert(
    "2 perryLength",
    "Meter");
```

Affine units are also supported when a scale and offset are required:

```csharp
UnitConverterCustomUnit customTemperature =
    UnitConverterCustomUnits.RegisterAffine(
        UnitConverterFamily.Temperature,
        "CustomTemperature",
        "°X",
        "Custom temperature",
        "Celsius",
        2.0,
        10.0);
```

Custom aliases cannot shadow built-in aliases in the same family. Registered units participate in family-specific dynamic conversion and global detection. Linear custom units can also participate in composite expressions; affine custom units are rejected as multiplicative expression factors because offsets are not representable by a pure scale expression.

### Arbitrary-scale number conversion

UnitConverter now also includes the former Ginor number-conversion engine under `UnitConverter.Numbers`. It handles exact sparse base-10 values whose exponents can be far beyond conventional CLR numeric ranges:

```csharp
using UnitConverter.Numbers;

ArbitraryScaleNumber huge =
    ArbitraryScaleNumber.Parse("1e100000000000000000000");

Console.WriteLine(huge.ToScientific());
// 1e100000000000000000000
```

Named-scale conversion uses the same straightforward conversion style:

```csharp
ArbitraryScaleNumber billions =
    NumberScaleConverter.Convert(
        "500 million",
        "billion");

Console.WriteLine(billions.ToScientific());
// 5e-1

ArbitraryScaleNumber micros =
    NumberScaleConverter.Convert(
        "1 milli",
        "micro");

Console.WriteLine(micros.ToScientific());
// 1e3
```

The scale catalogue is symmetric around `10^0`. In addition to conventional large names, it includes SI prefixes from `deci` through `quecto` for small values and `deca` through `quetta` for large values.

The integrated generated-name grammar retains Ginor's deterministic naming model and now works in both exponent directions. `ginozillion` is the large generated scale at layer 2, magnitude 4 and coefficient 1, corresponding to `10^10000`. Its tiny counterpart uses the same reversible address with the tiny direction and deterministically becomes `ginuzillion`, corresponding to `10^-10000`:

```csharp
ArbitraryScaleNumber ginozillion =
    ArbitraryScaleNumber.Parse("1 ginozillion");

ArbitraryScaleNumber ginuzillion =
    ArbitraryScaleNumber.Parse("1 ginuzillion");

GeneratedNumberScalePosition large =
    GeneratedNumberNames.Parse("ginozillion");

GeneratedNumberScalePosition tiny =
    GeneratedNumberNames.Parse("ginuzillion");

// large.Direction == GeneratedNumberScaleDirection.Large
// tiny.Direction  == GeneratedNumberScaleDirection.Tiny
```

Generated names are reversible addresses:

```csharp
var position = new GeneratedNumberScalePosition(
    layer: 3,
    magnitude: 27,
    coefficient: 7);

string name = GeneratedNumberNames.GetName(position);
GeneratedNumberScalePosition restored =
    GeneratedNumberNames.Parse(name);
```

The folded Ginor naming model is preserved as well:

```csharp
var address = new GeneratedNumberNameAddress(
    new GeneratedNumberScalePosition(2, 4, 1),
    foldDepth: 1);

string foldedName = GeneratedNumberNames.GetName(address);
GeneratedNumberNameAddress restoredAddress =
    GeneratedNumberNames.ParseAddress(foldedName);

string symbolic = restoredAddress.ToSymbolicExpression();
// 10^(10^(10^4))
```

The number subsystem also exposes `ArbitraryScaleMath`, exact sparse addition/subtraction/multiplication, non-negative integer powers, checked conversion to `double`, `decimal`, and `BigInteger`, and the registered conventional scale catalogue from one through googol plus generated scales.

This functionality is part of the dependency-free core package; existing unit-conversion APIs remain unchanged.

### System.Text.Json serialization

Serialization support is kept out of the dependency-free core package. Install the companion package `UnitConverter.SystemTextJson` and register its converter factory:

```csharp
using System.Text.Json;
using UnitConverter.SystemTextJson;

var options = new JsonSerializerOptions()
    .AddUnitConverter();

var distance = new UnitValue<UnitConverterLengthUnit>(
    1.8,
    UnitConverterLengthUnit.Kilometer);

string json = JsonSerializer.Serialize(distance, options);
// {"value":1.8,"unit":"Kilometer"}

UnitValue<UnitConverterLengthUnit> restored =
    JsonSerializer.Deserialize<UnitValue<UnitConverterLengthUnit>>(
        json,
        options);
```

Deserialization accepts the catalogue's aliases as unit values, while serialization writes the stable enum name. The companion package depends on `System.Text.Json`; the `UnitConverter` core package remains free of third-party runtime dependencies.


### Exact decimal and strongly typed quantities

Decimal extension conversions now stay on a decimal-native path. Linear conversion factors are composed as reduced rational numbers before they are applied, so conversions such as inch-to-foot and extreme SI-prefix ratios do not need a `decimal -> double -> decimal` round trip or an underflow-prone intermediate base value.

```csharp
using UnitConverter;
using UnitConverter.Length;

decimal feet = 1m.Convert(
    UnitConverterLengthUnit.Inch,
    UnitConverterLengthUnit.Foot); // rational factor is exactly 1/12 before decimal rounding

decimal tinyRatio = UnitConverterExact.Convert(
    1m,
    UnitConverterLengthUnit.Quectometer,
    UnitConverterLengthUnit.Rontometer); // 0.001m
```

On .NET 8 or later, `UnitQuantity<T, TUnit>` provides a strongly typed wrapper for every catalog family with uniform physical dimensions. The unit enum is part of the CLR type, so unrelated families cannot be mixed by addition, subtraction, comparison, or assignment.

```csharp
using UnitConverter.Quantities;
using UnitConverter.Torque;

var torque = UnitQuantity.From(
    12.5m,
    UnitConverterTorqueUnit.NewtonMeter);

var doubled = torque + torque;
decimal value = doubled.As(UnitConverterTorqueUnit.NewtonMeter);
```

The named quantity layer now covers the complete 150-family catalog on .NET 8+. Every uniform family has a first-class named generic type with a property and `From<Unit>` factory for every registered unit, enum-based `From/In/Convert`, generic arithmetic, comparisons, span parsing, and span formatting. The original named types such as `Length<T>`, `Time<T>`, `Pressure<T>`, and `Voltage<T>` retain their existing friendly names while also exposing the rest of their catalog units. Fuel economy remains intentionally represented by the two reciprocal-safe types `FuelEfficiency<T>` and `FuelConsumption<T>`.

```csharp
using UnitConverter.Quantities;

Stress<decimal> stress =
    YoungModulus<decimal>.FromGigapascal(200m) *
    Strain<decimal>.FromMicrostrain(500m);

decimal megapascals = stress.Megapascal; // 100m

Impedance<decimal> impedance = Impedance<decimal>.Parse(
    "50 Ω",
    CultureInfo.InvariantCulture);

Voltage<decimal> voltage =
    impedance * ElectricCurrent<decimal>.FromAmperes(2m);
```

The established named quantities such as `Length<T>`, `Time<T>`, `Speed<T>`, `Force<T>`, and `Energy<T>` continue to provide derived arithmetic such as length/time -> speed and force*length -> energy. The additional engineering types retain the reviewed relations including stress*area -> force, modulus*strain -> stress, spring-constant*length -> force, heat-flux-density*area -> power, and impedance*current -> voltage. Catalog-wide generation is guarded in CI so adding or changing a legacy unit cannot silently leave the named typed surface behind.

Integral extensions continue to return `double` to preserve fractional results. Decimal extensions use the shared exact/rational conversion engine. The legacy `PixelPerUnityUnit` entry remains a numeric compatibility alias with its original one-unit-equals-one-metre convention.

## Repository layout

| Path | Contents |
| --- | --- |
| `src/UnitConverter` | Conversion library, retaining the family and unit-system folders |
| `tests/UnitConverter.Tests` | Migrated NUnit tests and assembly checks |
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
- [Conversion provenance](docs/Provenance.md)
- [Packaging](docs/Developer/Packaging.md)

Unity inspectors, settings assets, scenes, assembly definitions, metadata files, and the shared Unity Core layer have been removed. The original Unity package remains available in [the 1.1.3 import commit](https://github.com/Perry3Dnl/UnitConverter/tree/332369313b1a428a66432e811c542562efa24e40).
