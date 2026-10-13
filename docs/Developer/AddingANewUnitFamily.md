# Adding a New Unit Family

A unit family is a quantity type such as Length, Mass, Power, or Pressure.

Each family should have:

```text
src/UnitTools/[Family]/UnitTools[Family].cs
src/UnitTools/[Family]/UnitTools[Family]Extensions.cs
src/UnitTools/[Family]/[System]/UnitTools[System][Family].cs
```

## Required Pieces

### 1. Enum

```csharp
public enum UnitToolsExampleUnit
{
    BaseUnit,
    OtherUnit
}
```

### 2. Router class

```csharp
public static class UnitToolsExample
{
    public static double Convert(double value, UnitToolsExampleUnit from, UnitToolsExampleUnit to)
    {
        double baseValue = ToBase(value, from);
        return FromBase(baseValue, to);
    }
}
```

### 3. Direct method class

```csharp
public static class UnitToolsMetricExample
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

Update `UnitToolsCatalog` and the supported-family documentation. Add known-value, from-base, and round-trip tests under `tests/UnitTools.Tests`. Update the coverage counts in `UnitToolsAssemblyTests` when deliberately expanding the supported set.

Run the NUnit suite and package installation check described in [Testing](Testing.md).
