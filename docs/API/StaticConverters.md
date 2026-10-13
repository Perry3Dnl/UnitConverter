# Static Converter API

Every quantity family has a router class. The router converts through one canonical base unit.

Examples:

```text
Length      centimeter -> meter -> millimeter
Mass        pound -> kilogram -> gram
Power       horsepower -> watt -> kilowatt
Temperature Fahrenheit -> kelvin -> Celsius
```

## Pattern

```csharp
UnitToolsFamily.Convert(value, fromUnit, toUnit);
```

## Length Example

```csharp
using UnitTools.Length;

double result = UnitToolsLength.Convert(
    12.5,
    UnitToolsLengthUnit.Centimeter,
    UnitToolsLengthUnit.Millimeter);
```

## Mass Example

```csharp
using UnitTools.Mass;

double kilograms = UnitToolsMass.Convert(
    150,
    UnitToolsMassUnit.Pound,
    UnitToolsMassUnit.Kilogram);
```

## Power Example

```csharp
using UnitTools.Power;

double kilowatts = UnitToolsPower.Convert(
    5,
    UnitToolsPowerUnit.HorsepowerMechanical,
    UnitToolsPowerUnit.Kilowatt);
```

## Incompatible Units

Do not convert across families with the router API. Length units use `UnitToolsLengthUnit`, power units use `UnitToolsPowerUnit`, and so on. This prevents mistakes like meter-to-watt at compile time.
