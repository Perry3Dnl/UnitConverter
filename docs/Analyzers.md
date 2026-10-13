# UnitTools analyzers

`UnitTools.Analyzers` is an optional Roslyn analyzer package. It does not change runtime behavior and the core `UnitTools` package remains dependency-free.

The analyzer philosophy is guidance rather than restriction: direct numeric converters, family converters, extensions and strongly typed quantities are all supported first-class APIs. Diagnostics are reserved for cases where code uses an escape hatch while the compiler can see enough information to recommend a safer form.

## UC0002 — compile-time-known dynamic conversion

```csharp
double meters = UnitToolsDynamic.Convert("2 km", "m");
```

When both arguments are compile-time string constants, `UC0002` warns that a family-specific or strongly typed API can preserve more compile-time safety.

Equivalent supported alternatives include:

```csharp
double meters = UnitToolsLength.Convert(
    2,
    UnitToolsLengthUnit.Kilometer,
    UnitToolsLengthUnit.Meter);

Length<double> distance = Length<double>.FromKilometers(2);
```

Dynamic conversion remains supported. It is the correct API when units or families are genuinely runtime data:

```csharp
double result = UnitToolsDynamic.Convert(userInput, requestedUnit);
```

Because those arguments are not compile-time constants, `UC0002` is not reported.

## Suppression

Diagnostics use standard Roslyn configuration and can be changed or disabled through `.editorconfig`, `#pragma warning`, or project warning settings. The analyzer package is optional and has no runtime dependency.
