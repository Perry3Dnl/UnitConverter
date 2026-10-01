# Adding a New Unit Family

A unit family is a quantity type such as Length, Mass, Power, or Pressure.

Each family should have:

```text
Runtime/[Family]/UnitConverter[Family].cs
Runtime/[Family]/UnitConverter[Family]Extensions.cs
Runtime/[Family]/[System]/UnitConverter[System][Family].cs
```

## Required Pieces

### 1. Enum

```csharp
public enum UnitConverterExampleUnit
{
    BaseUnit,
    OtherUnit
}
```

### 2. Router class

```csharp
public static class UnitConverterExample
{
    public static double Convert(double value, UnitConverterExampleUnit from, UnitConverterExampleUnit to)
    {
        double baseValue = ToBase(value, from);
        return FromBase(baseValue, to);
    }
}
```

### 3. Direct method class

```csharp
public static class UnitConverterMetricExample
{
    public static double OtherUnitToBaseUnit(double value)
    {
        return value * 10d;
    }
}
```

### 4. Extension methods

Add extension overloads for common value types.

### 5. Editor integration, if needed

Only add Unity inspector fields if Unity has a native value matching the quantity.

Example: length maps well to Transform position and collider size. Power does not map cleanly to Transform.
