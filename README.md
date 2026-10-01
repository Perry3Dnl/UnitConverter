# UnitConverter

RealisticPhysics UnitConverter is a Unity unit conversion package with runtime converters, numeric extension methods, editor inspector overrides, a demo scene, and Edit Mode tests.

Current package version: **1.1.3**.

## Install in Unity

Download [UnitConverter6.unitypackage](UnityPackages/UnitConverter6.unitypackage), then import it with **Assets > Import Package > Custom Package** in your Unity project.

Alternatively, copy `Assets/RealisticPhysics` and `Assets/RealisticPhysics.meta` from this repository into your project's `Assets` folder. Preserve the included `.meta` files so Unity asset references remain intact. Both `Core` and `UnitConverter` are required for the Unity integration.

This repository contains the exported Unity asset package. It does not include a Unity project's `ProjectSettings` or package manifest, and it is not yet packaged for NuGet or Unity Package Manager.

## Usage

```csharp
using RealisticPhysics.UnitConversion.Length;

double millimeters = UnitConverterLength.Convert(
    12.5,
    UnitConverterLengthUnit.Centimeter,
    UnitConverterLengthUnit.Millimeter);
```

Open **Tools > RealisticPhysics > UnitConverter > Open Settings** to configure the Unity inspector integration.

## Repository contents

| Path | Contents |
| --- | --- |
| `Assets/RealisticPhysics/Core` | Shared runtime and editor support |
| `Assets/RealisticPhysics/UnitConverter/Runtime` | Conversion APIs, extensions, metadata, and Unity settings |
| `Assets/RealisticPhysics/UnitConverter/Editor` | Settings UI and inspector overrides |
| `Assets/RealisticPhysics/UnitConverter/Tests` | Unity Edit Mode tests |
| `Assets/RealisticPhysics/UnitConverter/Demo` | Runtime demo and demo scene tools |
| `Assets/RealisticPhysics/UnitConverter/Documentation` | Usage guides, API reference, and developer notes |
| `UnityPackages/UnitConverter6.unitypackage` | Original importable package |

## Documentation

- [Documentation index](Assets/RealisticPhysics/UnitConverter/Documentation/README.md)
- [Getting started](Assets/RealisticPhysics/UnitConverter/Documentation/GettingStarted.md)
- [Supported families and units](Assets/RealisticPhysics/UnitConverter/Documentation/API/SupportedFamiliesAndUnits.md)
- [Inspector overrides](Assets/RealisticPhysics/UnitConverter/Documentation/Editor/InspectorOverrides.md)
- [Runtime demo](Assets/RealisticPhysics/UnitConverter/Documentation/Demo/RuntimeDemo.md)

## Tests

After importing the package into a Unity project with the Unity Test Framework installed, run the included **Edit Mode** tests from Unity's Test Runner.
