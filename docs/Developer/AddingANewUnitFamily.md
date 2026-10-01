# Adding a New Unit Family

A unit family is a quantity type such as Length, Mass, Power, or Pressure.

Each family should have:

```text
src/RealisticPhysics.UnitConversion/[Family]/UnitConverter[Family].cs
src/RealisticPhysics.UnitConversion/[Family]/UnitConverter[Family]Extensions.cs
src/RealisticPhysics.UnitConversion/[Family]/[System]/UnitConverter[System][Family].cs
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

### 5. Catalog, documentation and tests

Update `UnitConverterCatalog` and the supported-family documentation. Add known-value, from-base, and round-trip tests under `tests/RealisticPhysics.UnitConversion.Tests`. Update the coverage counts in `UnitConverterAssemblyTests` when deliberately expanding the supported set.

Run the NUnit suite and package installation check described in [Testing](Testing.md).
