# Direct Methods and Namespaces

Each unit family can also have direct converter classes grouped by unit system.

This is useful when a developer wants very clear method names and namespace auto-complete.

## Length Metric

```csharp
using UnitConverter.Length.Metric;

double meters = UnitConverterMetricLength.CentimeterToMeter(12.5);
double millimeters = UnitConverterMetricLength.MeterToMillimeter(meters);
```

## Length Imperial

```csharp
using UnitConverter.Length.Imperial;

double meters = UnitConverterImperialLength.FootToMeter(10);
double feet = UnitConverterImperialLength.MeterToFoot(meters);
```

## Volume US vs UK

US and UK Imperial volume units are separate because some names are shared but values differ.

```csharp
using UnitConverter.Volume.ImperialUS;
using UnitConverter.Volume.ImperialUK;

double usGallonLiters = UnitConverterImperialUSVolume.GallonToLiter(1);
double ukGallonLiters = UnitConverterImperialUKVolume.GallonToLiter(1);
```

## Namespace Convention

```text
UnitConverter.Length.Metric
UnitConverter.Length.Imperial
UnitConverter.Length.Survey
UnitConverter.Length.Nautical
UnitConverter.Volume.ImperialUS
UnitConverter.Volume.ImperialUK
UnitConverter.Mass.Troy
```

## Product Rule

The direct API may be large, but namespacing keeps it selectable. Developers import only the systems they want.
