# Migration from the Unity package

Version `2.0.0-preview.1` extracts the conversion core from Unity package `1.1.3` into a standalone NuGet project. The major preview version reflects removal of the Unity integration.

## Preserved

- All 496 portable runtime source files, with only namespace references renamed.
- All 97 conversion families and 1,632 unit entries, including aliases.
- Converter class names and the family/unit-system namespace hierarchy under the new `UnitConverter` root.
- Enum names and numeric values, static methods, direct methods, extensions, and metadata.
- Existing conversion factors and source-unit -> base-unit -> target-unit flow.
- The 100 conversion test files and their assertions, with namespaces and the test helper name adjusted for the standalone package.

The family and unit-system folder hierarchy now lives under `src/UnitConverter`.

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

The package ID, assembly name, and root namespace are all `UnitConverter`.

| Previous identity | Standalone identity |
| --- | --- |
| `RealisticPhysics.UnitConversion` assembly/root namespace | `UnitConverter` |
| `RealisticPhysics.UnitConversion.Length` | `UnitConverter.Length` |
| `RealisticPhysics.UnitConversion.Length.Metric` | `UnitConverter.Length.Metric` |
| `RealisticPhysics.UnitConversion.Catalog` | `UnitConverter.Catalog` |

Replace references to copied conversion source or the old conversion DLL with the new package reference. Replace `RealisticPhysics.UnitConversion` with `UnitConverter` in imports and fully qualified converter names. The converter calls themselves remain the same. Update any assembly-qualified type strings or reflection lookups that name the old assembly. Remove code that accesses Unity settings or editor integration.

Do not compile the old converter source alongside the NuGet DLL, as it defines the same types. No Unity installation is required to build or use this library.
