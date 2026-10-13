# Conversion provenance

UnitTools exposes provenance through every `UnitToolsUnitDescriptor.Provenance`.

The goal is to make the origin and audit state of conversion definitions inspectable without
pretending that a broad standards reference proves every individual numerical factor.

## Provenance statuses

| Status | Meaning |
| --- | --- |
| `LegacyMigrated` | The definition was migrated from the 1.1.3 conversion core and has not yet been assigned an authoritative external reference. |
| `StandardsReferenced` | The family/unit is covered by the SI/NIST reference set used during catalogue auditing. This does not by itself assert that the individual factor has completed an exactness audit. |
| `FundamentalConstantReferenced` | The definition depends on a fundamental-constant reference set, currently CODATA 2022 where applicable. |
| `NominalDefinitionReferenced` | The definition uses or is associated with an authoritative nominal conversion definition, such as IAU nominal astronomical constants where applicable. |

Consumers can distinguish these states:

```csharp
UnitToolsUnitDescriptor meter =
    UnitToolsCatalog
        .GetFamily(UnitToolsFamily.Length)
        .Units.First(unit => unit.Name == "Meter");

foreach (UnitToolsProvenanceSource source in meter.Provenance.Sources)
{
    Console.WriteLine(source.Id);
    Console.WriteLine(source.Title);
    Console.WriteLine(source.Organization);
    Console.WriteLine(source.Reference);
}
```

## Reference sets

The current catalogue records these authoritative reference sets:

- **BIPM SI Brochure, 9th edition** — International System of Units definitions and SI usage.
- **NIST SP 811** — SI usage and commonly used conversion guidance.
- **CODATA 2022 recommended values** — fundamental physical constants and associated conversion factors.
- **IAU 2015 Resolution B3** — nominal solar and planetary conversion constants.

The original UnitTools 1.1.3 conversion core remains the explicit provenance source for
definitions that have not yet completed an external-source audit.

## Audit policy

A provenance source answers **where a definition should be checked**. It is not automatically
an exactness claim.

Before changing a unit to a stronger audited status, validation should establish:

1. the authoritative source and edition;
2. the exact numerical definition or recommended value;
3. whether the value is exact, conventional, nominal, derived, or experimentally measured;
4. the transformation direction and offset semantics;
5. regression coverage against the authoritative value.

This policy is intentionally conservative so downstream engineering users can distinguish
migrated compatibility behavior from externally audited definitions.
