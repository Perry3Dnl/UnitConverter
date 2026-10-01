# Length Examples

## Static Router

```csharp
using UnitConverter.Length;

double mm = UnitConverterLength.Convert(
    12.5,
    UnitConverterLengthUnit.Centimeter,
    UnitConverterLengthUnit.Millimeter);
```

## Extension Method

```csharp
using UnitConverter.Length;

double value = 12.5;

double mm = value.Convert(
    UnitConverterLengthUnit.Centimeter,
    UnitConverterLengthUnit.Millimeter);
```

## Direct Metric Method

```csharp
using UnitConverter.Length.Metric;

double meters = UnitConverterMetricLength.CentimeterToMeter(12.5);
```

## Imperial to Metric

```csharp
using UnitConverter.Length;

double meters = UnitConverterLength.Convert(
    6,
    UnitConverterLengthUnit.Foot,
    UnitConverterLengthUnit.Meter);
```
