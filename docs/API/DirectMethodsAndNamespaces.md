# Direct Methods and Namespaces

Each unit family can also have direct converter classes grouped by unit system.

This is useful when a developer wants very clear method names and namespace auto-complete.

## Length Metric

```csharp
using UnitTools.Length.Metric;

double meters = UnitToolsMetricLength.CentimeterToMeter(12.5);
double millimeters = UnitToolsMetricLength.MeterToMillimeter(meters);
```

## Length Imperial

```csharp
using UnitTools.Length.Imperial;

double meters = UnitToolsImperialLength.FootToMeter(10);
double feet = UnitToolsImperialLength.MeterToFoot(meters);
```

## Volume US vs UK

US and UK Imperial volume units are separate because some names are shared but values differ.

```csharp
using UnitTools.Volume.ImperialUS;
using UnitTools.Volume.ImperialUK;

double usGallonLiters = UnitToolsImperialUSVolume.GallonToLiter(1);
double ukGallonLiters = UnitToolsImperialUKVolume.GallonToLiter(1);
```

## Namespace Convention

```text
UnitTools.Length.Metric
UnitTools.Length.Imperial
UnitTools.Length.Survey
UnitTools.Length.Nautical
UnitTools.Volume.ImperialUS
UnitTools.Volume.ImperialUK
UnitTools.Mass.Troy
```

## Product Rule

The direct API may be large, but namespacing keeps it selectable. Developers import only the systems they want.
