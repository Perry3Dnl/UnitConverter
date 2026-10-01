# Electrical Examples

## Voltage

```csharp
using RealisticPhysics.UnitConversion.Voltage;

double volts = UnitConverterVoltage.Convert(
    12,
    UnitConverterVoltageUnit.Volt,
    UnitConverterVoltageUnit.Millivolt);
```

## Current

```csharp
using RealisticPhysics.UnitConversion.Current;

double amps = UnitConverterCurrent.Convert(
    500,
    UnitConverterCurrentUnit.Milliampere,
    UnitConverterCurrentUnit.Ampere);
```

## Power

```csharp
using RealisticPhysics.UnitConversion.Power;

double watts = UnitConverterPower.Convert(
    1,
    UnitConverterPowerUnit.Kilowatt,
    UnitConverterPowerUnit.Watt);
```

## Resistance

```csharp
using RealisticPhysics.UnitConversion.ElectricResistance;

double ohms = UnitConverterElectricResistance.Convert(
    2.2,
    UnitConverterElectricResistanceUnit.Kiloohm,
    UnitConverterElectricResistanceUnit.Ohm);
```
