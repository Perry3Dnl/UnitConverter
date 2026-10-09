# Culture and localization

UnitConverter separates numeric culture from unit vocabulary.

Numeric parsing and formatting accepts `IFormatProvider`, so decimal separators, group separators, scientific notation, and other supported numeric conventions follow the caller's culture. Localization v1 adds culture-aware unit display names and parsing aliases without changing stable symbols or enum names.

## Culture-aware parsing

```csharp
using System.Globalization;
using UnitConverter;
using UnitConverter.Length;

CultureInfo dutch = CultureInfo.GetCultureInfo("nl-NL");

UnitConverterParsedValue<UnitConverterLengthUnit> parsed =
    UnitConverterParser.Parse<UnitConverterLengthUnit>(
        "1,5 mijl",
        dutch);
```

The parser first resolves the normal catalog aliases. If no catalog unit is found, it checks localized aliases for the supplied culture and then its parent culture. For example, `nl-NL` falls back to `nl`.

Localized aliases are never applied to invariant parsing unless they were explicitly registered for the invariant culture.

## Culture-aware display names

Symbols remain stable across cultures:

```csharp
UnitConverterFormatter.Format(
    1.5,
    UnitConverterLengthUnit.Kilometer,
    "0.0",
    dutch,
    UnitConverterUnitFormat.Symbol);
// 1,5 km
```

Display names can be localized:

```csharp
UnitConverterFormatter.Format(
    1.5,
    UnitConverterLengthUnit.Mile,
    "0.0",
    dutch,
    UnitConverterUnitFormat.DisplayName);
// 1,5 mijl
```

`EnumName` also remains invariant. This makes symbols and enum names appropriate for logs, protocols and serialization while localized display names can be used for user-facing text.

## Registering additional vocabulary

The localization table is extensible at runtime:

```csharp
CultureInfo french = CultureInfo.GetCultureInfo("fr-FR");

UnitConverterLocalization.Register(
    french,
    UnitConverterLengthUnit.Mile,
    "mille",
    "mille",
    "milles");
```

Registration does not modify the generated unit catalog or conversion factors. If two localized aliases collide inside the same culture and unit family, the alias is marked ambiguous rather than guessed.

## Built-in scope

Built-in localization data is definition-driven. `definitions/unit-localization.json` is validated against the real family/unit enums and `scripts/generate_localization.py` emits checked-in dependency-free C#. CI rejects stale or invalid generated output. The current Dutch built-in vocabulary contains 85 localized unit entries across 13 commonly used families, with parent-culture fallback from `nl-NL` to `nl`.

`UnitConverterLocalization.GetSupportedCultures<TUnit>()` exposes built-in or runtime-registered cultures for a family, while `TryGetDisplayName` allows callers to query localized display metadata without formatting a value. Additional locales can be expanded incrementally without changing converter implementations or adding runtime package dependencies.
## Localization coverage

Built-in locale data is tracked explicitly rather than described as all-or-nothing. `docs/LocalizationCoverage.md` is generated from the locale definitions and catalog enums. A family is marked **complete** only when every registered unit in that family has an explicit locale entry; otherwise it remains **partial**.

The current Dutch locale has complete coverage for Angle, Area, Energy, Force, Frequency, Power, Pressure, Speed, Temperature, and Time. Length, Mass, and Volume remain intentionally marked partial until every unit in those larger catalogs has been reviewed.

CI validates both the generated runtime registrations and the coverage report, so adding a unit to a family marked complete requires adding its locale entry in the same change.
