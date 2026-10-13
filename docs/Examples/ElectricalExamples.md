# Electrical Examples

## Voltage

```csharp
using UnitTools.Voltage;

double volts = UnitToolsVoltage.Convert(
    12,
    UnitToolsVoltageUnit.Volt,
    UnitToolsVoltageUnit.Millivolt);
```

## Current

```csharp
using UnitTools.Current;

double amps = UnitToolsCurrent.Convert(
    500,
    UnitToolsCurrentUnit.Milliampere,
    UnitToolsCurrentUnit.Ampere);
```

## Power

```csharp
using UnitTools.Power;

double watts = UnitToolsPower.Convert(
    1,
    UnitToolsPowerUnit.Kilowatt,
    UnitToolsPowerUnit.Watt);
```

## Resistance

```csharp
using UnitTools.ElectricResistance;

double ohms = UnitToolsElectricResistance.Convert(
    2.2,
    UnitToolsElectricResistanceUnit.Kiloohm,
    UnitToolsElectricResistanceUnit.Ohm);
```
