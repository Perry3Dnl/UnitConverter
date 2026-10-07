"""Generate catalog-complete named quantities for the original 98-family catalog.

The 17 established named quantities are augmented without breaking their existing friendly API.
The remaining 80 uniform legacy families receive first-class named quantity structs.
Fuel economy remains deliberately split into FuelEfficiency<T> and FuelConsumption<T>.
"""

from pathlib import Path
import argparse
import json
import re
import sys

ROOT = Path(__file__).resolve().parents[1]
DESCRIPTORS = ROOT / "src/UnitConverter/Catalog/UnitConverterDescriptors.cs"
UNIT_VALUES = ROOT / "src/UnitConverter/Catalog/UnitConverterUnitValues.Generated.cs"
QUANTITY_API = ROOT / "definitions/quantity-api.json"
OUTPUT_DIR = ROOT / "src/UnitConverter/Quantities/GeneratedLegacy"
PARSING_OUTPUT = ROOT / "src/UnitConverter/Quantities/QuantityParsing.cs"
FORMATTING_OUTPUT = ROOT / "src/UnitConverter/Quantities/QuantityFormattingExtensions.cs"

INLINE_PARSING_TYPES = {"Length", "Time", "Speed"}

def humanize(name):
    text = re.sub(r"([A-Z]+)([A-Z][a-z])", r"\1 \2", name)
    text = re.sub(r"([a-z0-9])([A-Z])", r"\1 \2", text)
    return " ".join(text.split())

def parse_model():
    descriptors = DESCRIPTORS.read_text(encoding="utf-8")
    unit_values = UNIT_VALUES.read_text(encoding="utf-8")
    quantity_api = json.loads(QUANTITY_API.read_text(encoding="utf-8"))
    existing_by_folder = {
        family["enumNamespace"].split(".")[-1]: family
        for family in quantity_api["families"].values()
    }

    pattern = re.compile(
        r'Create<UnitConverter\.([A-Za-z0-9_]+)\.(UnitConverter[A-Za-z0-9_]+Unit)>'
        r'\(UnitConverterFamily\.([A-Za-z0-9_]+),\s*"([^"]+)",\s*"([^"]+)",\s*'
        r'UnitConverter\.\1\.(UnitConverter[A-Za-z0-9_]+)\.GetSymbol'
    )

    families = []
    for match in pattern.finditer(descriptors):
        folder, enum_type, family, name, base_unit, converter = match.groups()
        if family == "FuelEconomy":
            continue

        full_enum = f"UnitConverter.{folder}.{enum_type}"
        marker = f"if (type == typeof({full_enum}))"
        index = unit_values.find(marker)
        if index < 0:
            raise RuntimeError(f"Missing generated unit values for {full_enum}")

        array_index = unit_values.find(f"new {full_enum}[]", index)
        start = unit_values.find("{", array_index)
        end = unit_values.find("};", start)
        block = unit_values[start:end]
        member_pattern = re.compile(re.escape(full_enum) + r"\.([A-Za-z0-9_]+),")
        units = member_pattern.findall(block)
        if not units:
            raise RuntimeError(f"No units parsed for {full_enum}")

        existing = existing_by_folder.get(folder)
        type_name = existing["type"] if existing else family
        families.append({
            "folder": folder,
            "enumType": enum_type,
            "family": family,
            "name": name,
            "baseUnit": base_unit,
            "converter": converter,
            "type": type_name,
            "units": units,
            "existing": existing,
        })

    if len(families) != 97:
        raise RuntimeError(f"Expected 97 legacy named/special quantity families after FuelEconomy split, got {len(families)}")
    return families

def enum_type(family):
    return f"global::UnitConverter.{family['folder']}.{family['enumType']}"

def converter_type(family):
    return f"global::UnitConverter.{family['folder']}.{family['converter']}"

def render_resolver(family, indent="        "):
    e = enum_type(family)
    c = converter_type(family)
    lines = [
        f"{indent}internal static bool TryResolveCatalogUnit(ReadOnlySpan<char> text, out {e} unit)",
        f"{indent}{{",
        f"{indent}    bool found = false;",
        f"{indent}    {e} candidate = default;",
    ]
    for unit in family["units"]:
        lines.extend([
            f"{indent}    if (text.Equals({c}.GetSymbol({e}.{unit}).AsSpan(), StringComparison.Ordinal))",
            f"{indent}    {{",
            f"{indent}        if (found && candidate != {e}.{unit})",
            f"{indent}        {{",
            f"{indent}            unit = default;",
            f"{indent}            return false;",
            f"{indent}        }}",
            f"{indent}        candidate = {e}.{unit};",
            f"{indent}        found = true;",
            f"{indent}    }}",
        ])
    lines.extend([
        f"{indent}    if (found)",
        f"{indent}    {{",
        f"{indent}        unit = candidate;",
        f"{indent}        return true;",
        f"{indent}    }}",
    ])
    for unit in family["units"]:
        lines.extend([
            f'{indent}    if (text.Equals("{unit}".AsSpan(), StringComparison.OrdinalIgnoreCase))',
            f"{indent}    {{",
            f"{indent}        unit = {e}.{unit};",
            f"{indent}        return true;",
            f"{indent}    }}",
        ])
    lines.extend([
        f"{indent}    unit = default;",
        f"{indent}    return false;",
        f"{indent}}}",
    ])
    return lines

def render_full(family):
    name = family["type"]
    e = enum_type(family)
    c = converter_type(family)
    base = family["baseUnit"]
    lines = [
        "// <auto-generated />",
        "// Generated by scripts/generate_legacy_named_quantities.py. Do not edit by hand.",
        "#if NET8_0_OR_GREATER",
        "using System;",
        "using System.Numerics;",
        "",
        "namespace UnitConverter.Quantities",
        "{",
        f"    /// <summary>Strongly typed {humanize(name)} quantity backed by the catalog base unit.</summary>",
        f"    public readonly partial struct {name}<T> :",
        f"        IEquatable<{name}<T>>,",
        f"        IComparable<{name}<T>>,",
        "        IFormattable,",
        "        ISpanFormattable,",
        f"        IParsable<{name}<T>>,",
        f"        ISpanParsable<{name}<T>>",
        "        where T : IFloatingPoint<T>",
        "    {",
        f"        private static readonly {e} BaseUnit = {e}.{base};",
        f"        private static readonly string BaseSymbol = {c}.GetSymbol(BaseUnit);",
        "        private readonly T _baseValue;",
        "",
        f"        private {name}(T baseValue) => _baseValue = baseValue;",
        "",
    ]
    for unit in family["units"]:
        if unit == base:
            lines.append(f"        public T {unit} => _baseValue;")
        else:
            lines.append(f"        public T {unit} => UnitConverterNumeric.Convert(_baseValue, BaseUnit, {e}.{unit});")

    lines.append("")
    for unit in family["units"]:
        if unit == base:
            lines.append(f"        public static {name}<T> From{unit}(T value) => new {name}<T>(value);")
        else:
            lines.append(
                f"        public static {name}<T> From{unit}(T value) => "
                f"new {name}<T>(UnitConverterNumeric.Convert(value, {e}.{unit}, BaseUnit));"
            )

    lines.extend([
        "",
        f"        public static {name}<T> From(T value, {e} unit)",
        f"            => new {name}<T>(UnitConverterNumeric.Convert(value, unit, BaseUnit));",
        "",
        f"        public T In({e} unit)",
        "            => UnitConverterNumeric.Convert(_baseValue, BaseUnit, unit);",
        "",
    ])
    lines.extend(render_resolver(family))
    lines.extend([
        "",
        f"        public static {name}<T> operator +({name}<T> left, {name}<T> right) => new {name}<T>(left._baseValue + right._baseValue);",
        f"        public static {name}<T> operator -({name}<T> left, {name}<T> right) => new {name}<T>(left._baseValue - right._baseValue);",
        f"        public static {name}<T> operator -({name}<T> value) => new {name}<T>(-value._baseValue);",
        f"        public static {name}<T> operator *({name}<T> quantity, T scalar) => new {name}<T>(quantity._baseValue * scalar);",
        f"        public static {name}<T> operator *(T scalar, {name}<T> quantity) => quantity * scalar;",
        f"        public static {name}<T> operator /({name}<T> quantity, T scalar) => new {name}<T>(quantity._baseValue / scalar);",
        f"        public static T operator /({name}<T> left, {name}<T> right) => left._baseValue / right._baseValue;",
        "",
        f"        public static bool operator ==({name}<T> left, {name}<T> right) => left.Equals(right);",
        f"        public static bool operator !=({name}<T> left, {name}<T> right) => !left.Equals(right);",
        f"        public static bool operator <({name}<T> left, {name}<T> right) => left._baseValue < right._baseValue;",
        f"        public static bool operator >({name}<T> left, {name}<T> right) => left._baseValue > right._baseValue;",
        f"        public static bool operator <=({name}<T> left, {name}<T> right) => left._baseValue <= right._baseValue;",
        f"        public static bool operator >=({name}<T> left, {name}<T> right) => left._baseValue >= right._baseValue;",
        "",
        f"        public bool Equals({name}<T> other) => _baseValue == other._baseValue;",
        f"        public override bool Equals(object obj) => obj is {name}<T> other && Equals(other);",
        "        public override int GetHashCode() => _baseValue.GetHashCode();",
        f"        public int CompareTo({name}<T> other) => _baseValue.CompareTo(other._baseValue);",
        "",
        "        public override string ToString() => ToString(null, null);",
        "        public string ToString(string format, IFormatProvider formatProvider)",
        '            => _baseValue.ToString(format, formatProvider) + " " + BaseSymbol;',
        "",
        "        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)",
        "        {",
        "            charsWritten = 0;",
        "            ReadOnlySpan<char> symbol = BaseSymbol.AsSpan();",
        "            int suffixLength = 1 + symbol.Length;",
        "            if (destination.Length <= suffixLength)",
        "                return false;",
        "            Span<char> valueDestination = destination.Slice(0, destination.Length - suffixLength);",
        "            if (!_baseValue.TryFormat(valueDestination, out int valueChars, format, provider))",
        "                return false;",
        "            destination[valueChars] = ' ';",
        "            symbol.CopyTo(destination.Slice(valueChars + 1));",
        "            charsWritten = valueChars + suffixLength;",
        "            return true;",
        "        }",
        "",
        f"        public static {name}<T> Parse(string s, IFormatProvider provider) => Parse(s.AsSpan(), provider);",
        f"        public static {name}<T> Parse(ReadOnlySpan<char> s, IFormatProvider provider)",
        "        {",
        f"            if (!TryParse(s, provider, out {name}<T> result))",
        f'                throw new FormatException("Input was not a valid {humanize(name).lower()} quantity.");',
        "            return result;",
        "        }",
        f"        public static bool TryParse(string s, IFormatProvider provider, out {name}<T> result) => TryParse(s.AsSpan(), provider, out result);",
        f"        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out {name}<T> result)",
        "        {",
        "            result = default;",
        "            if (!QuantityText.TryParseValueAndUnit(s, provider, out T value, out ReadOnlySpan<char> unitText))",
        "                return false;",
        f"            if (!TryResolveCatalogUnit(unitText, out {e} unit))",
        "                return false;",
        "            result = From(value, unit);",
        "            return true;",
        "        }",
        "    }",
        "",
        f"    public static class {name}Methods",
        "    {",
    ])
    for unit in family["units"]:
        lines.extend([
            f"        public static {name}<T> From{unit}<T>(T value) where T : IFloatingPoint<T> => {name}<T>.From{unit}(value);",
            f"        public static T To{unit}<T>(this {name}<T> quantity) where T : IFloatingPoint<T> => quantity.{unit};",
            "",
        ])
    lines.extend([
        f"        public static {name}<T> From<T>(T value, {e} unit) where T : IFloatingPoint<T> => {name}<T>.From(value, unit);",
        f"        public static T In<T>(this {name}<T> quantity, {e} unit) where T : IFloatingPoint<T> => quantity.In(unit);",
        f"        public static T Convert<T>(T value, {e} from, {e} to) where T : IFloatingPoint<T> => From(value, from).In(to);",
        "    }",
        "}",
        "#endif",
        "",
    ])
    return "\n".join(lines)

def existing_names(config):
    properties = {unit["name"] for unit in config["units"]}
    factories = {unit["factory"] for unit in config["units"]}
    helper_from = set(factories)
    helper_to = {"To" + unit["name"] for unit in config["units"]}
    for alias in config.get("aliases", []):
        properties.add(alias["name"])
        properties.add(alias.get("property", alias["name"]))
        factories.add(alias["factory"])
        helper_from.add(alias["factory"])
        helper_to.add("To" + alias["name"])
    return properties, factories, helper_from, helper_to

def render_augmentation(family):
    config = family["existing"]
    name = family["type"]
    e = enum_type(family)
    base = family["baseUnit"]
    base_entry = next((unit for unit in config["units"] if unit["enumMember"] == base), None)
    if base_entry is None:
        raise RuntimeError(f"{name} quantity API does not expose its base unit {base}")
    base_property = base_entry["name"]
    base_factory = base_entry["factory"]
    properties, factories, helper_from, helper_to = existing_names(config)

    lines = [
        "// <auto-generated />",
        "// Generated by scripts/generate_legacy_named_quantities.py. Do not edit by hand.",
        "#if NET8_0_OR_GREATER",
        "using System;",
        "using System.Numerics;",
        "",
        "namespace UnitConverter.Quantities",
        "{",
        f"    public readonly partial struct {name}<T> where T : IFloatingPoint<T>",
        "    {",
        f"        private static readonly {e} FullCatalogBaseUnit = {e}.{base};",
        "",
        f"        public static {name}<T> From(T value, {e} unit)",
        f"            => {base_factory}(UnitConverterNumeric.Convert(value, unit, FullCatalogBaseUnit));",
        "",
        f"        public T In({e} unit)",
        f"            => UnitConverterNumeric.Convert({base_property}, FullCatalogBaseUnit, unit);",
        "",
    ]
    for unit in family["units"]:
        if unit not in properties:
            lines.append(f"        public T {unit} => In({e}.{unit});")
    if any(unit not in properties for unit in family["units"]):
        lines.append("")
    for unit in family["units"]:
        method = "From" + unit
        if method not in factories:
            lines.append(f"        public static {name}<T> {method}(T value) => From(value, {e}.{unit});")
    lines.append("")
    lines.extend(render_resolver(family))
    lines.extend([
        "    }",
        "",
        f"    public static partial class {name}Methods",
        "    {",
    ])
    for unit in family["units"]:
        method = "From" + unit
        if method not in helper_from:
            lines.append(f"        public static {name}<T> {method}<T>(T value) where T : IFloatingPoint<T> => {name}<T>.{method}(value);")
        to_method = "To" + unit
        if to_method not in helper_to:
            lines.append(f"        public static T {to_method}<T>(this {name}<T> quantity) where T : IFloatingPoint<T> => quantity.{unit};")
        if method not in helper_from or to_method not in helper_to:
            lines.append("")
    lines.extend([
        "    }",
        "}",
        "#endif",
        "",
    ])
    return "\n".join(lines)

def render_existing_parsing(families):
    lines = [
        "// <auto-generated />",
        "// Generated by scripts/generate_legacy_named_quantities.py. Do not edit by hand.",
        "#if NET8_0_OR_GREATER",
        "using System;",
        "using System.Numerics;",
        "",
        "namespace UnitConverter.Quantities",
        "{",
    ]
    for family in families:
        name = family["type"]
        if name in INLINE_PARSING_TYPES:
            continue
        e = enum_type(family)
        lines.extend([
            f"    public readonly partial struct {name}<T> : IParsable<{name}<T>>, ISpanParsable<{name}<T>> where T : IFloatingPoint<T>",
            "    {",
            f"        public static {name}<T> Parse(string s, IFormatProvider provider) => Parse(s.AsSpan(), provider);",
            f"        public static {name}<T> Parse(ReadOnlySpan<char> s, IFormatProvider provider)",
            "        {",
            f"            if (!TryParse(s, provider, out {name}<T> result))",
            f'                throw new FormatException("Input was not a valid {humanize(name).lower()} quantity.");',
            "            return result;",
            "        }",
            f"        public static bool TryParse(string s, IFormatProvider provider, out {name}<T> result) => TryParse(s.AsSpan(), provider, out result);",
            f"        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out {name}<T> result)",
            "        {",
            "            result = default;",
            "            if (!QuantityText.TryParseValueAndUnit(s, provider, out T value, out ReadOnlySpan<char> unitText))",
            "                return false;",
            f"            if (!TryResolveCatalogUnit(unitText, out {e} unit))",
            "                return false;",
            "            result = From(value, unit);",
            "            return true;",
            "        }",
            "    }",
            "",
        ])
    lines.extend(["}", "#endif", ""])
    return "\n".join(lines)

def render_existing_formatting(families):
    lines = [
        "// <auto-generated />",
        "// Generated by scripts/generate_legacy_named_quantities.py. Do not edit by hand.",
        "#if NET8_0_OR_GREATER",
        "using System;",
        "using System.Numerics;",
        "",
        "namespace UnitConverter.Quantities",
        "{",
        "    public static class QuantityFormattingExtensions",
        "    {",
    ]
    for family in families:
        name = family["type"]
        if name in INLINE_PARSING_TYPES:
            continue
        e = enum_type(family)
        c = converter_type(family)
        lines.extend([
            f"        public static bool TryFormatWithUnit<T>(this {name}<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>",
            "        {",
            f"            if (!{name}<T>.TryResolveCatalogUnit(unit, out {e} resolved))",
            "            {",
            "                charsWritten = 0;",
            "                return false;",
            "            }",
            f"            return QuantityText.TryFormat(quantity.In(resolved), {c}.GetSymbol(resolved).AsSpan(), destination, out charsWritten, format, provider);",
            "        }",
            "",
        ])
    lines.extend(["    }", "}", "#endif", ""])
    return "\n".join(lines)

def rendered_files():
    families = parse_model()
    files = {}
    existing = []
    for family in families:
        if family["existing"]:
            existing.append(family)
            files[OUTPUT_DIR / (family["family"] + ".Existing.Generated.cs")] = render_augmentation(family)
        else:
            files[OUTPUT_DIR / (family["family"] + ".Generated.cs")] = render_full(family)
    files[PARSING_OUTPUT] = render_existing_parsing(existing)
    files[FORMATTING_OUTPUT] = render_existing_formatting(existing)
    return files

def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("--check", action="store_true")
    args = parser.parse_args()
    files = rendered_files()

    expected_generated = {path for path in files if path.parent == OUTPUT_DIR}
    if args.check:
        actual_generated = set(OUTPUT_DIR.glob("*.Generated.cs")) if OUTPUT_DIR.exists() else set()
        stale = [path for path, output in files.items() if not path.exists() or path.read_text(encoding="utf-8") != output]
        if actual_generated != expected_generated or stale:
            print("Generated legacy named quantity surface is out of date. Run scripts/generate_legacy_named_quantities.py", file=sys.stderr)
            for path in stale:
                print("  stale:", path.relative_to(ROOT), file=sys.stderr)
            return 1
        print("Generated legacy named quantity surface is up to date.")
        return 0

    OUTPUT_DIR.mkdir(parents=True, exist_ok=True)
    for stale in OUTPUT_DIR.glob("*.Generated.cs"):
        if stale not in expected_generated:
            stale.unlink()
    for path, output in files.items():
        path.parent.mkdir(parents=True, exist_ok=True)
        path.write_text(output, encoding="utf-8")
        print("Generated", path.relative_to(ROOT))
    return 0

if __name__ == "__main__":
    raise SystemExit(main())
