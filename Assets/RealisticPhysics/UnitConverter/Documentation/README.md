# RealisticPhysics UnitConverter

UnitConverter is a Unity unit conversion package for runtime code, editor tools, gameplay systems, simulations, calculators, and inspector-driven workflows.

It includes a large unit conversion API, generated direct converter methods, numeric extension methods, supported-unit metadata, and optional Unity inspector unit-display overrides.

## What You Can Do

Use UnitConverter to:

* Convert between supported units in runtime code.
* Use clear static converter APIs for each conversion family.
* Use extension methods for readable value-based conversions.
* Use direct methods with auto-complete-friendly names.
* Browse supported conversion families and units.
* Enable optional Unity inspector overrides for unit display workflows.
* Use the included runtime demo to explore available conversions.

## Package Location

After import, UnitConverter is available under:

```text
Assets/RealisticPhysics/Core
Assets/RealisticPhysics/UnitConverter
```

The package includes the shared `RealisticPhysics.Core` layer required by RealisticPhysics tools.

## Open Settings

Open the UnitConverter settings from Unity:

```text
Tools > RealisticPhysics > UnitConverter > Open Settings
```

If the settings asset does not exist yet, UnitConverter creates it automatically at:

```text
Assets/RealisticPhysics/UnitConverter/Settings/UnitConverterSettings.asset
```

Use the settings asset to configure UnitConverter editor behavior and optional inspector overrides.

## Documentation Index

### Start Here

* [Getting Started](GettingStarted.md)
* [Settings](Editor/Settings.md)
* [Inspector Overrides](Editor/InspectorOverrides.md)
* [Troubleshooting](Troubleshooting.md)

### API Usage

* [Static Converter API](API/StaticConverters.md)
* [Extension Method API](API/ExtensionMethods.md)
* [Direct Methods and Namespaces](API/DirectMethodsAndNamespaces.md)
* [Supported Families and Units](API/SupportedFamiliesAndUnits.md)

### Examples

* [Length Examples](Examples/LengthExamples.md)
* [Electrical Examples](Examples/ElectricalExamples.md)
* [Unity Inspector Examples](Examples/UnityInspectorExamples.md)
* [Runtime Demo](Demo/RuntimeDemo.md)

### Advanced Developer Notes

* [Adding a New Unit](Developer/AddingANewUnit.md)
* [Adding a New Unit Family](Developer/AddingANewUnitFamily.md)

## API Styles

UnitConverter supports three main runtime API styles.

### Static Router API

Use the static router API when the source or target unit may be selected at runtime, stored in a variable, or chosen from a UI.

```csharp
using RealisticPhysics.UnitConversion.Length;

double millimeters = UnitConverterLength.Convert(
    12.5,
    UnitConverterLengthUnit.Centimeter,
    UnitConverterLengthUnit.Millimeter);
```

### Extension Method API

Use extension methods when you want readable value-based conversion code.

```csharp
using RealisticPhysics.UnitConversion.Length;

double value = 12.5;

double millimeters = value.Convert(
    UnitConverterLengthUnit.Centimeter,
    UnitConverterLengthUnit.Millimeter);
```

### Direct Method API

Use direct methods when you already know the exact units and want clear method names with editor auto-complete support.

```csharp
using RealisticPhysics.UnitConversion.Length.Metric;

double meters = UnitConverterMetricLength.CentimeterToMeter(12.5);
```

## How Conversions Work

Conversions are handled within matching conversion families.

For example, Length units can convert to other Length units:

```text
centimeter -> meter -> millimeter
```

A Length unit cannot be converted into a Power unit, so conversions such as meter to watt are intentionally not supported.

## Runtime and Editor Notes

* Runtime converters can be used from normal C# code and do not require Unity scenes or components.
* Inspector overrides are editor-only and controlled through the UnitConverter settings asset.
* The Transform override is enabled by default.
* Other built-in inspector overrides are included but disabled by default.
* Integral extension overloads return `double` so fractional conversion results are not lost.
* For best precision, use `double` conversions where possible.

## Recommended First Step

Start with the Getting Started guide, then open the runtime demo to browse supported conversion families and example conversions.

* [Getting Started](GettingStarted.md)
* [Runtime Demo](Demo/RuntimeDemo.md)

## Version

Current UnitConverter version: 1.1.3
