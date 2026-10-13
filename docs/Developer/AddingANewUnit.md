# Adding a New Unit

This guide describes the static-code path for adding a unit to an existing family.

Example: adding a new length unit.

## 1. Add the enum value

Open:

```text
src/UnitTools/Length/UnitToolsLength.cs
```

Add the new value to `UnitToolsLengthUnit`.

## 2. Add direct conversion methods

Choose the correct unit-system namespace.

Example:

```text
src/UnitTools/Length/Historical/UnitToolsHistoricalLength.cs
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

In `UnitToolsLength.ToMeter`, add a switch case that calls the direct method.

## 4. Route it in FromMeter

In `UnitToolsLength.FromMeter`, add the reverse switch case.

## 5. Test both APIs

```csharp
UnitToolsLength.Convert(1, UnitToolsLengthUnit.NewUnit, UnitToolsLengthUnit.Meter);
```

And:

```csharp
UnitToolsHistoricalLength.NewUnitToMeter(1);
```

## Rule

Always convert through the family base unit. Do not add direct unit-to-unit pairs for every possible combination.
