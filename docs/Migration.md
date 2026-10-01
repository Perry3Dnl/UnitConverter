# Migration from the Unity package

Version `2.0.0-preview.1` extracts the conversion core from Unity package `1.1.3` into a standalone NuGet project. The major preview version reflects removal of the Unity integration.

## Preserved

- All 496 portable runtime source files, unchanged.
- All 97 conversion families and 1,632 unit entries, including aliases.
- `RealisticPhysics.UnitConversion` assembly name and existing public namespaces.
- Enum names and numeric values, static methods, direct methods, extensions, and metadata.
- Existing conversion factors and source-unit -> base-unit -> target-unit flow.
- The 100 conversion test files and their assertions, with only the helper namespace adjusted for the new test project.

The family and unit-system folder hierarchy now lives under `src/RealisticPhysics.UnitConversion`.

## Removed

- `UnitConverterSettings` and its ScriptableObject-based settings workflow.
- Unity editor menus, custom inspectors, and field drawers.
- Unity scene and MonoBehaviour demo. A console sample now demonstrates the core APIs.
- `RealisticPhysics.Core` runtime/editor support, which the converter core never referenced.
- Unity `.meta`, `.asmdef`, `.unity`, and `.unitypackage` files.
- Documentation for Unity-only editor workflows.

The original package is preserved in [the 1.1.3 import commit](https://github.com/Perry3Dnl/UnitConverter/tree/332369313b1a428a66432e811c542562efa24e40).

## Existing behavior retained

This migration changes packaging and integration, not conversion semantics:

- `decimal` extensions still pass through `double`; they do not provide decimal-preserving arithmetic.
- `TryConvert` remains a temperature-family API.
- `UnitConverterFamily` retains its existing subset of family names. Use `UnitConverterCatalog.GetFamilyNames()` for the complete catalog.
- `PixelPerUnityUnit` remains a legacy numeric alias with one unit interpreted as one metre. It neither references Unity nor reads a project scale.
- Existing test tolerances are unchanged. Passing the suite is a migration regression check, not a new accuracy benchmark.

## Using the new package

Replace references to copied conversion source or the old conversion DLL with the new package reference. Keep the existing converter `using` statements and calls. Remove code that accesses Unity settings or editor integration.

Do not compile the old converter source alongside the NuGet DLL, as it defines the same types. No Unity installation is required to build or use this library.
