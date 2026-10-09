# Changelog

## 2.0.0-preview.2 — release-readiness candidate

- Promote the standalone package candidate to `2.0.0-preview.2`.
- Keep the catalog at 150 conversion families and 1,858 unit entries including aliases.
- Add catalog-wide strongly typed quantities, reviewed dimensional arithmetic, compile-time family isolation, and modern generic numeric interfaces on .NET 8+.
- Route decimal conversion through the exact reduced-rational engine, including exact affine temperature handling and reciprocal fuel-economy transforms.
- Add span-based parsing and formatting with allocation-free hot paths for typed quantities.
- Optimize global dynamic unit detection with cached built-in alias indexes while preserving exact-case and custom-unit ambiguity semantics.
- Optimize composite expression parsing/conversion with a bounded built-in expression cache while preserving runtime custom-unit behavior.
- Integrate arbitrary-scale number conversion and deterministic generated number naming into the core package.
- Add runtime custom units, composite expressions, dynamic family detection, metadata, and the `UnitConverter.SystemTextJson` companion package.
- Validate clean NuGet consumption, NativeAOT core usage, NativeAOT JSON usage, deterministic generated code, and BenchmarkDotNet allocation regressions in CI.
- Add Apache License 2.0 subject to Commons Clause License Condition v1.0, with `LICENSE.md` and `NOTICE` embedded in both NuGet packages.
- Add culture-aware localized unit display names and parse aliases with explicit `IFormatProvider` semantics, parent-culture fallback, invariant symbols, and runtime vocabulary registration.
- Add the optional `UnitConverter.Analyzers` package. `UC0002` guides compile-time-known dynamic string conversions toward typed or family-specific APIs while preserving dynamic conversion as a supported escape hatch.
- Refresh NuGet descriptions, tags, release notes, README performance data, and packaging documentation for the public preview.

## 2.0.0-preview.1 — standalone .NET package

- Move the 496 portable runtime files to an SDK-style .NET Standard 2.0 library, changing only namespace references in the converter code.
- Use `UnitConverter` as the package ID, assembly name, and root namespace.
- Preserve converter class/method names, enum values, conversion constants, and base-unit routing.
- Migrate conversion tests to a .NET 10 NUnit project.
- Remove Unity settings, editor integration, shared Core, scenes, metadata, and import archives.
- Add NuGet metadata, a console sample, build/test/pack automation, and updated documentation.
- See [Migration](Migration.md) for retained behavior and legacy aliases.
- Add a shared reduced-rational conversion engine and route all 150 family `decimal` extension surfaces through decimal-native conversion without converting the input through `double`.
- Add exact affine decimal transforms for absolute temperature and exact reciprocal decimal transforms for fuel economy.
- Add `UnitQuantity<T, TUnit>` for compile-time family isolation across every uniform-dimension catalog family while preserving the existing named derived-quantity arithmetic.
- Split typed fuel economy into `FuelEfficiency<T>` and `FuelConsumption<T>` so reciprocal dimensions remain distinct at compile time.
- Add CI verification that rejects future decimal-extension regressions back to `double`.
- Expand the catalog from 98 to 150 families with 52 generated mechanical/materials, thermal, electrical/magnetic/wave, and chemistry/process families (208 additional units).
- Add explicit reduced-rational scale metadata for generated families so decimal conversion does not infer their scale through `double`.
- Add first-class named generic quantity structs across the complete 150-family catalog. The 80 previously unnamed legacy families receive generated structs, the 17 established named families gain catalog-complete unit properties/factories and parsing, and fuel economy remains split into reciprocal-safe `FuelEfficiency<T>` / `FuelConsumption<T>` types.
- Add reviewed derived operators for mechanical, electrical, thermal-flux, charge-density, and specific-property quantities while keeping generated unit surfaces separate from hand-reviewed physical relations.
- Add deterministic generation and CI coverage for the legacy named-quantity surface, including every registered unit, modern parsing/formatting interfaces, full enum-based indirect conversion, and backward-compatible friendly APIs.

## Historical Unity releases

The entries below describe the original Unity package. Unity-specific features mentioned here are not part of the standalone package.

# UnitConverter Changelog

## 1.1.3

- Added a focused initial store-release coverage polish pass.
- Added 13 additional Length units.
- Increased shipped coverage to 97 conversion families and 1,632 supported units.
- Increased compatible conversion coverage to 40,160 paths including same-unit conversions, and 38,528 paths excluding same-unit conversions.
- Reached the 40,000+ compatible conversion paths milestone for store-page marketing.
- Updated Length known-value EditMode tests.
- Updated supported unit documentation.
- No new conversion families.
- No breaking API changes.

## 1.1.2

- Expanded existing conversion tables without adding new conversion families.
- Added more units to motion, mechanical, electrical, pressure, fluid, radiation, light, rendering, developer utility, and common engineering tables.
- Added formula-based handling inside the existing Fuel Economy and Specific Gravity families while keeping the same public API shape.
- Expanded Temperature with additional absolute and scientific temperature units.
- Corrected reciprocal fuel economy conversions, including liters per 100 kilometers, liters per kilometer, and gallons per distance.
- Regenerated direct converter classes to avoid duplicate base-to-base direct methods.
- Kept the family count unchanged at 97 conversion families.
- Increased shipped coverage to 1,619 supported units.
- Increased compatible conversion coverage to 37,963 paths including same-unit conversions, and 36,344 paths excluding same-unit conversions.
- Updated known-value EditMode tests, including non-1 input cases for formula-based conversions.
- Updated supported unit documentation.
- No breaking API changes.

## 1.1.1

- Expanded existing conversion tables with additional metric, imperial, scientific, engineering, rare, and workflow-specific units.
- Improved depth of thinner conversion tables added in 1.1.0.
- Added more units to motion, fluid, thermal, material, electrical, magnetic, light, radiation, and utility families.
- Kept the family count unchanged at 97 conversion families.
- Increased shipped coverage to 1,418 supported units.
- Increased compatible conversion coverage to 30,902 paths including same-unit conversions, and 29,484 paths excluding same-unit conversions.
- Updated known-value EditMode tests for all expanded families.
- Updated supported unit documentation.
- No new conversion families.
- No breaking API changes.

## 1.1.0

- Added a major conversion-family expansion focused on physics, materials, fluids, thermal data, electrical fields, light, radiation, and developer utility workflows.
- Added 60 new conversion families.
- Increased shipped coverage to 97 conversion families and 1,005 supported units.
- Increased compatible conversion coverage to 22,359 paths including same-unit conversions, and 21,354 paths excluding same-unit conversions.
- Added generated direct converter classes, extension methods, catalog entries, base-unit metadata, and known-value EditMode tests for the new families.
- No breaking API changes.

## 1.0.10

- Expanded conversion tables with rare, scientific, engineering, astronomical, historical, cooking, survey, and extended physics units.
- Increased shipped coverage to 37 conversion families and 682 supported units.
- Increased compatible conversion coverage to 20,552 paths including same-unit conversions, and 19,870 paths excluding same-unit conversions.
- Added expanded known-value EditMode tests for the updated families.
- Updated conversion table documentation.
- No breaking API changes.

## 1.0.9

- Added 15 new conversion families focused on physics, flow, electrical, magnetic, light, and radiation workflows.
- Added Density, Dynamic Viscosity, Kinematic Viscosity, Volumetric Flow Rate, Mass Flow Rate, Angular Velocity, Angular Acceleration, Capacitance, Inductance, Conductance, Magnetic Field, Magnetic Flux, Illuminance, Radioactivity, and Radiation Dose.
- Added runtime converter classes, unit enums, namespace-specific direct converter classes, extension methods, symbols, display names, unit-system metadata, and catalog base-unit metadata for the new families.
- Added per-family known-value EditMode tests for the new conversion families.
- Updated supported coverage to 37 conversion families, 392 supported units, and 6,330 compatible paths including same-unit conversions.
- Updated generated supported-units documentation.

## 1.0.8

- Added base-unit metadata to the UnitConverter runtime catalog.
- Updated the runtime demo to use catalog base-unit metadata instead of maintaining a separate base-unit switch.
- Fixed Runtime API demo code examples by using escaped newline strings so the demo script compiles correctly.
- No conversion math changes.

## 1.0.7

- Expanded the UnitConverter runtime demo Overview section with more package, settings, runtime, editor, conversion coverage, testing, and demo information.
- Made Runtime API examples larger and easier to read.
- Updated Runtime API examples to use larger multi-line input-style code boxes.
- Added additional runtime API examples for base-unit output methods, organized namespaces, and numeric extension support.
- No runtime conversion API changes.

## 1.0.6

- Refined the code-generated UnitConverter runtime demo.
- Updated the Overview section to focus on the UnitConverter settings asset workflow.
- Updated the Runtime API page with larger copyable code examples inside text input-style boxes.
- Updated the Inspector Integration page to focus on supported inspector override examples.
- Increased runtime demo text size for readability.
- Reduced highlighted text styling so emphasis is reserved mainly for navigation and active UI elements.
- No runtime conversion API changes.

## 1.0.5

- Refined the UnitConverter runtime demo UI.
- Simplified the Overview tab so it no longer duplicates the main tab navigation.
- Expanded the Runtime API tab with concrete developer usage examples.
- Expanded the Inspector Integration tab with examples of supported inspector overrides.
- Kept the Conversion Tables tab from 1.0.4 for browsing every shipped conversion family and supported unit.
- No runtime conversion API changes.

## 1.0.4

- Improved the code-generated UnitConverter runtime demo.
- Reworked the demo navigation so overview cards open meaningful sections.
- Added a full Conversion Tables view listing every shipped conversion family.
- Added live base-unit conversion tables for all supported units in each family.
- Updated the demo header to show family count, supported unit count, and compatible conversion path count.
- Kept the demo fully code-generated with no image assets, prefabs, custom fonts, or TextMeshPro dependency.

## 1.0.3

- Added a code-generated UnitConverter runtime demo.
- Added a demo scene at `Assets/RealisticPhysics/UnitConverter/Demo/Scenes/UnitConverterRuntimeDemo.unity`.
- Added runtime demo UI tabs for overview, length, mass, electrical, energy, pressure, temperature, digital, and speed conversions.
- Added editor menu items to open or recreate the runtime demo scene.
- Added demo documentation.
- Kept the demo UI fully generated from code with no image assets, prefabs, fonts, or TextMeshPro dependency.

## 1.0.2

- Expanded UnitConverter known-value test coverage.
- Added per-family known-value test files for all shipped conversion families.
- Added base-unit checks for every supported out-of-the-box unit.
- Added from-base checks for every supported out-of-the-box unit.
- Added round-trip checks from unit to base unit and back.
- Kept broad reflection smoke tests for all compatible conversion paths.

## 1.0.1

- Added Unity Test Framework EditMode tests for UnitConverter.
- Added known-value conversion tests for key unit families.
- Added extension-method API tests.
- Added reflection-based smoke tests that check self-conversions and round-trip conversions across converter families.
- Added UnitConverter testing documentation.
- Updated package version tracking to RealisticPhysics suite version 1.0.1.

## 1.0.0

- Added the first stable UnitConverter runtime conversion API.
- Added static converter classes.
- Added direct unit-specific conversion methods.
- Added extension methods for common numeric value types.
- Added 22 conversion families.
- Added 285 supported units.
- Added 5,000+ compatible conversion paths.
- Added optional Unity inspector overrides.
- Added UnitConverter settings asset workflow.
- Added UnitConverter documentation.

## 0.9.0

- Prepared the first stable release candidate for UnitConverter.
- Finalized the initial public API shape for runtime conversions, direct converters, extension methods, and inspector overrides.
- Locked the first 22 planned conversion families for the 1.0.0 release.
- Completed the first full documentation pass for supported families, units, symbols, and usage examples.
- Added final validation passes for generated converter classes and supported unit metadata.
- Added release-readiness checks for package structure, assembly definitions, namespaces, and sample layout.
- No breaking API changes planned after this milestone.

## 0.8.0

- Added the first broad conversion-table expansion pass.
- Added additional metric, imperial, scientific, digital, speed, pressure, energy, volume, area, and temperature units.
- Added symbol and display-name metadata for supported units.
- Added unit-system metadata for metric, imperial, scientific, digital, and common-use unit groups.
- Added catalog lookups for supported families and available units.
- Improved conversion consistency by standardizing base-unit selection across all families.
- Added early known-value tests for the most common conversions.

## 0.7.0

- Added generated direct converter classes for each supported conversion family.
- Added namespace-specific converter organization for cleaner developer usage.
- Added direct unit-to-unit methods for common conversion paths.
- Added generation rules for converter class names, method names, enum names, symbols, and display names.
- Added generation validation to detect duplicate method names and invalid unit identifiers.
- Improved generated code formatting for readability and source-control diffs.
- Added early smoke tests for generated converter output.

## 0.6.0

- Added numeric extension methods for common value types.
- Added fluent conversion helpers for runtime use.
- Added overload coverage for `float`, `double`, and `decimal` workflows where supported.
- Added early round-trip checks for extension-method conversions.
- Improved conversion precision handling for very small and very large values.
- Standardized rounding expectations across test fixtures.
- Added early examples for direct converters and extension-based usage.

## 0.5.0

- Added the first Unity inspector override workflow.
- Added UnitConverter settings asset support.
- Added serialized configuration for preferred units and display behavior.
- Added editor-side helpers for selecting supported units by conversion family.
- Added validation for unsupported unit selections.
- Added early inspector integration examples.
- Improved package folder layout for runtime, editor, generated code, tests, and documentation.

## 0.4.0

- Added the first runtime catalog prototype.
- Added family metadata, unit metadata, base-unit references, and supported conversion lookup data.
- Added internal registration for conversion families and their supported units.
- Added early runtime lookup methods for checking whether a conversion path is supported.
- Added initial catalog tests for family registration and unit availability.
- Improved internal naming consistency across conversion families and unit enums.

## 0.3.0

- Added the first conversion family prototypes.
- Added early support for Length, Mass, Time, Area, Volume, Temperature, Speed, Force, Energy, Power, Pressure, Digital Storage, Angle, Frequency, and Data Rate.
- Added base-unit conversion rules for prototype families.
- Added early direct conversion checks against known reference values.
- Added support for same-unit conversions.
- Added early round-trip tests from unit to base unit and back.

## 0.2.0

- Added the initial UnitConverter runtime architecture.
- Added the base converter pattern used by later generated converter classes.
- Added internal conversion-factor handling for linear unit conversions.
- Added early formula-conversion support for non-linear families such as Temperature.
- Added the first unit enum prototypes.
- Added early test scaffolding for conversion correctness.
- Added package namespace and assembly-definition structure.

## 0.1.0

- Started the UnitConverter package.
- Added the initial project folder structure under the RealisticPhysics suite.
- Added the first runtime namespace and package metadata.
- Added early design notes for conversion families, unit enums, direct converters, and extension methods.
- Added the first prototype conversion methods for basic Length and Mass workflows.
- Added early documentation placeholders for runtime usage, inspector integration, and supported units.