# Extension Method API

UnitTools includes extension methods for common numeric value types.

Supported input types:

```text
double
float
decimal
byte
sbyte
short
ushort
int
uint
long
ulong
```

## Pattern

```csharp
value.Convert(fromUnit, toUnit);
```

## Example

```csharp
using UnitTools.Length;

double value = 12.5;

double millimeters = value.Convert(
    UnitToolsLengthUnit.Centimeter,
    UnitToolsLengthUnit.Millimeter);
```

## Return Types

- `double` input returns `double`
- `float` input returns `float`
- `decimal` input returns `decimal`
- integral inputs return `double`

Integral overloads return `double` because conversions often produce fractional values.

## Notes

Extension methods are only visible when the matching namespace is imported.

```csharp
using UnitTools.Length;
```

This keeps the API from polluting projects that do not use UnitTools.
