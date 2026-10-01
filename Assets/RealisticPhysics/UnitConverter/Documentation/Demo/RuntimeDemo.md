# UnitConverter Runtime Demo

The UnitConverter runtime demo is a code-generated sample scene that shows how the runtime conversion API can be used without requiring extra image assets, prefabs, custom fonts, or TextMeshPro.

## Location

`Assets/RealisticPhysics/UnitConverter/Demo/Scenes/UnitConverterRuntimeDemo.unity`

## Opening the demo

Use:

`Tools > RealisticPhysics > UnitConverter > Open Runtime Demo Scene`

or create/recreate it with:

`Tools > RealisticPhysics > UnitConverter > Create Runtime Demo Scene`

## What the demo shows

The demo contains four main sections:

- **Overview**: Explains the package purpose, settings asset workflow, runtime/editor separation, conversion coverage, testing, and code-generated demo setup.
- **Runtime API**: Shows larger copyable multi-line code examples for static APIs, extension methods, direct methods, base-unit helpers, namespaces, and numeric extension support.
- **Conversion Tables**: Lists every shipped conversion family and every supported unit in each family.
- **Inspector Integration**: Shows examples of the supported optional inspector overrides.

## Conversion Tables

The Conversion Tables section lists all shipped conversion families and shows live base-unit conversion values for every supported unit in the selected family.

This makes the demo match the package coverage more clearly:

- 37 conversion families
- 392 supported units
- 6,000+ compatible conversion paths

## No additional visual assets

The demo UI is generated entirely from code. It does not require logo images, textures, prefabs, custom fonts, or TextMeshPro.
## 1.0.5 demo refinements

The demo was refined so each tab has a clearer purpose:

- **Overview** summarizes the demo and package coverage without duplicating tab navigation.
- **Runtime API** shows example usage styles developers can use in code.
- **Conversion Tables** lists every shipped conversion family and supported unit.
- **Inspector Integration** shows examples of the Unity inspector overrides supported by UnitConverter.


## Catalog metadata

Base-unit metadata is read from `UnitConverterCatalog`, so the demo does not need its own manual base-unit switch for the shipped conversion families.






## 1.1.2 coverage

The runtime demo reads family and unit data from the runtime catalog and converter enums.

Current package coverage:

- 97 conversion families
- 1619 supported units
- 37,963 compatible paths including same-unit conversions
- 36,344 compatible paths excluding same-unit conversions
