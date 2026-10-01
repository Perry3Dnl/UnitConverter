# Adding a New Unit

This guide describes the static-code path for adding a unit to an existing family.

Example: adding a new length unit.

## 1. Add the enum value

Open:

```text
src/UnitConverter/Length/UnitConverterLength.cs
```

Add the new value to `UnitConverterLengthUnit`.

## 2. Add direct conversion methods

Choose the correct unit-system namespace.

Example:

```text
src/UnitConverter/Length/Historical/UnitConverterHistoricalLength.cs
```

Add methods:

```csharp
public static double NewUnitToMeter(double value)
{
    return value * YOUR_MULTIPLIER_TO_METER;
}

public static double MeterToNewUnit(double meters)
{
    return meters / YOUR_MULTIPLIER_TO_METER;
}
```

## 3. Route it in ToMeter

In `UnitConverterLength.ToMeter`, add a switch case that calls the direct method.

## 4. Route it in FromMeter

In `UnitConverterLength.FromMeter`, add the reverse switch case.

## 5. Test both APIs

```csharp
UnitConverterLength.Convert(1, UnitConverterLengthUnit.NewUnit, UnitConverterLengthUnit.Meter);
```

And:

```csharp
UnitConverterHistoricalLength.NewUnitToMeter(1);
```

## Rule

Always convert through the family base unit. Do not add direct unit-to-unit pairs for every possible combination.
