# Culture and localization

UnitConverter separates numeric culture from unit vocabulary.

Numeric parsing and formatting already accepts `IFormatProvider`, so decimal separators and other numeric conventions follow the caller's culture. Localization v1 adds culture-aware unit display names and parsing aliases without changing stable symbols or enum names.

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

Localization v1 includes a small curated Dutch vocabulary for common length and temperature units as the first built-in locale. The infrastructure is deliberately independent from the generated English alias catalog so additional locale definition files can be added incrementally without changing conversion code.
