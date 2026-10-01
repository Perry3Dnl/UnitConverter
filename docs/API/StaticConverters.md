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
UnitConverterFamily.Convert(value, fromUnit, toUnit);
```

## Length Example

```csharp
using RealisticPhysics.UnitConversion.Length;

double result = UnitConverterLength.Convert(
    12.5,
    UnitConverterLengthUnit.Centimeter,
    UnitConverterLengthUnit.Millimeter);
```

## Mass Example

```csharp
using RealisticPhysics.UnitConversion.Mass;

double kilograms = UnitConverterMass.Convert(
    150,
    UnitConverterMassUnit.Pound,
    UnitConverterMassUnit.Kilogram);
```

## Power Example

```csharp
using RealisticPhysics.UnitConversion.Power;

double kilowatts = UnitConverterPower.Convert(
    5,
    UnitConverterPowerUnit.HorsepowerMechanical,
    UnitConverterPowerUnit.Kilowatt);
```

## Incompatible Units

Do not convert across families with the router API. Length units use `UnitConverterLengthUnit`, power units use `UnitConverterPowerUnit`, and so on. This prevents mistakes like meter-to-watt at compile time.
