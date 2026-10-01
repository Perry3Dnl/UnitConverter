# Electrical Examples

## Voltage

```csharp
using UnitConverter.Voltage;

double volts = UnitConverterVoltage.Convert(
    12,
    UnitConverterVoltageUnit.Volt,
    UnitConverterVoltageUnit.Millivolt);
```

## Current

```csharp
using UnitConverter.Current;

double amps = UnitConverterCurrent.Convert(
    500,
    UnitConverterCurrentUnit.Milliampere,
    UnitConverterCurrentUnit.Ampere);
```

## Power

```csharp
using UnitConverter.Power;

double watts = UnitConverterPower.Convert(
    1,
    UnitConverterPowerUnit.Kilowatt,
    UnitConverterPowerUnit.Watt);
```

## Resistance

```csharp
using UnitConverter.ElectricResistance;

double ohms = UnitConverterElectricResistance.Convert(
    2.2,
    UnitConverterElectricResistanceUnit.Kiloohm,
    UnitConverterElectricResistanceUnit.Ohm);
```
