# Length Examples

## Static Router

```csharp
using UnitTools.Length;

double mm = UnitToolsLength.Convert(
    12.5,
    UnitToolsLengthUnit.Centimeter,
    UnitToolsLengthUnit.Millimeter);
```

## Extension Method

```csharp
using UnitTools.Length;

double value = 12.5;

double mm = value.Convert(
    UnitToolsLengthUnit.Centimeter,
    UnitToolsLengthUnit.Millimeter);
```

## Direct Metric Method

```csharp
using UnitTools.Length.Metric;

double meters = UnitToolsMetricLength.CentimeterToMeter(12.5);
```

## Imperial to Metric

```csharp
using UnitTools.Length;

double meters = UnitToolsLength.Convert(
    6,
    UnitToolsLengthUnit.Foot,
    UnitToolsLengthUnit.Meter);
```
