"""Generate static alias metadata from unit enums plus curated definitions.

The runtime library stays dependency-free and does not guess aliases. This script performs
normalization at development/build time and emits ordinary C# source.
"""

from pathlib import Path
import argparse
import json
import re
import sys

ROOT = Path(__file__).resolve().parents[1]
FAMILY_ENUM = ROOT / "src/UnitConverter/Catalog/UnitConverterFamily.cs"
DEFINITIONS = ROOT / "definitions/unit-aliases.json"
OUTPUT_DIR = ROOT / "src/UnitConverter/Catalog"
DISPATCHER = OUTPUT_DIR / "UnitConverterAliases.Generated.cs"
CHUNK_SIZE = 25

PLURALS = {
    "acre": "acres",
    "ampere": "amperes",
    "angstrom": "angstroms",
    "atmosphere": "atmospheres",
    "bar": "bars",
    "barn": "barns",
    "becquerel": "becquerels",
    "bit": "bits",
    "byte": "bytes",
    "calorie": "calories",
    "candela": "candelas",
    "carat": "carats",
    "century": "centuries",
    "coulomb": "coulombs",
    "cycle": "cycles",
    "day": "days",
    "decade": "decades",
    "degree": "degrees",
    "dyne": "dynes",
    "electronvolt": "electronvolts",
    "farad": "farads",
    "foot": "feet",
    "fortnight": "fortnights",
    "gallon": "gallons",
    "gauss": "gauss",
    "gram": "grams",
    "gray": "grays",
    "hectare": "hectares",
    "henry": "henries",
    "hertz": "hertz",
    "hour": "hours",
    "inch": "inches",
    "joule": "joules",
    "katal": "katals",
    "kelvin": "kelvins",
    "knot": "knots",
    "liter": "liters",
    "litre": "litres",
    "lumen": "lumens",
    "lux": "lux",
    "meter": "meters",
    "metre": "metres",
    "mile": "miles",
    "minute": "minutes",
    "mole": "moles",
    "newton": "newtons",
    "ohm": "ohms",
    "ounce": "ounces",
    "parsec": "parsecs",
    "pascal": "pascals",
    "pint": "pints",
    "pound": "pounds",
    "quart": "quarts",
    "radian": "radians",
    "revolution": "revolutions",
    "second": "seconds",
    "siemens": "siemens",
    "stone": "stones",
    "tesla": "teslas",
    "ton": "tons",
    "tonne": "tonnes",
    "torr": "torr",
    "turn": "turns",
    "volt": "volts",
    "watt": "watts",
    "weber": "webers",
    "week": "weeks",
    "yard": "yards",
    "year": "years",
}

def enum_body(text, enum_name):
    match = re.search(
        r"public\s+enum\s+" + re.escape(enum_name) + r"\s*\{([\s\S]*?)\n\s*\}",
        text,
    )
    if not match:
        raise RuntimeError("Could not find enum " + enum_name)
    return match.group(1)

def enum_members(text, enum_name):
    body = enum_body(text, enum_name)
    result = []
    for raw_line in body.splitlines():
        line = raw_line.split("//", 1)[0].strip()
        if not line:
            continue
        match = re.match(r"([A-Za-z_][A-Za-z0-9_]*)\s*(?:=\s*[^,]+)?\s*,?$", line)
        if match:
            result.append(match.group(1))
    return result

def humanize(name):
    text = re.sub(r"([A-Z]+)([A-Z][a-z])", r"\1 \2", name)
    text = re.sub(r"([a-z0-9])([A-Z])", r"\1 \2", text)
    text = text.replace("_", " ")
    return " ".join(text.split()).lower()

def british_spelling(text):
    words = []
    changed = False
    for word in text.split(" "):
        replacement = word
        if word.endswith("meters"):
            replacement = word[:-6] + "metres"
        elif word.endswith("meter"):
            replacement = word[:-5] + "metre"
        elif word.endswith("liters"):
            replacement = word[:-6] + "litres"
        elif word.endswith("liter"):
            replacement = word[:-5] + "litre"
        if replacement != word:
            changed = True
        words.append(replacement)
    return " ".join(words) if changed else None

def pluralize_word(word):
    return PLURALS.get(word)

def pluralize_phrase(text):
    words = text.split(" ")
    if not words:
        return None

    if words[0] == "degree" and len(words) > 1:
        copy = list(words)
        copy[0] = "degrees"
        return " ".join(copy)

    stop = words.index("per") if "per" in words else len(words)
    for index in range(stop - 1, -1, -1):
        plural = pluralize_word(words[index])
        if plural:
            copy = list(words)
            copy[index] = plural
            return " ".join(copy)

    if stop == len(words):
        for index in range(len(words) - 1, -1, -1):
            plural = pluralize_word(words[index])
            if plural:
                copy = list(words)
                copy[index] = plural
                return " ".join(copy)

    return None

def add_unique(items, value):
    if value and value not in items:
        items.append(value)

def generated_aliases(unit_name, curated):
    aliases = []
    human = humanize(unit_name)
    add_unique(aliases, human)

    british = british_spelling(human)
    add_unique(aliases, british)

    plural = pluralize_phrase(human)
    add_unique(aliases, plural)
    if plural:
        add_unique(aliases, british_spelling(plural))

    for alias in curated:
        add_unique(aliases, alias)

    return aliases

def csharp_string(value):
    return '"' + value.replace("\\", "\\\\").replace('"', '\\"') + '"'

def read_model():
    family_text = FAMILY_ENUM.read_text(encoding="utf-8")
    families = enum_members(family_text, "UnitConverterFamily")
    definitions = json.loads(DEFINITIONS.read_text(encoding="utf-8"))
    overrides = definitions.get("aliases", {})

    model = {}
    for family in families:
        path = ROOT / "src/UnitConverter" / family / ("UnitConverter" + family + ".cs")
        if not path.exists():
            raise RuntimeError("Missing converter source for " + family + ": " + str(path))
        text = path.read_text(encoding="utf-8")
        units = enum_members(text, "UnitConverter" + family + "Unit")
        family_overrides = overrides.get(family, {})
        unknown = sorted(set(family_overrides) - set(units))
        if unknown:
            raise RuntimeError(
                "Alias definitions reference unknown " + family + " units: " + ", ".join(unknown)
            )

        entries = {}
        for unit in units:
            entries[unit] = generated_aliases(unit, family_overrides.get(unit, []))
        model[family] = entries

    unknown_families = sorted(set(overrides) - set(families))
    if unknown_families:
        raise RuntimeError(
            "Alias definitions reference unknown families: " + ", ".join(unknown_families)
        )
    return model

def render_unit_values(model):
    lines = [
        "// <auto-generated />",
        "// Generated by scripts/generate_aliases.py. Do not edit by hand.",
        "namespace UnitConverter.Catalog",
        "{",
        "    using System;",
        "",
        "    internal static class UnitConverterUnitValues",
        "    {",
        "        public static TUnit[] GetValues<TUnit>()",
        "            where TUnit : struct",
        "        {",
        "            Type type = typeof(TUnit);",
    ]
    for family, units in model.items():
        enum_type = "UnitConverter." + family + ".UnitConverter" + family + "Unit"
        lines.extend([
            "",
            "            if (type == typeof(" + enum_type + "))",
            "            {",
            "                return (TUnit[])(object)new " + enum_type + "[]",
            "                {",
        ])
        for unit in units.keys():
            lines.append("                    " + enum_type + "." + unit + ",")
        lines.extend([
            "                };",
            "            }",
        ])
    lines.extend([
        "",
        "            throw new NotSupportedException(",
        "                \"No generated unit values are registered for \" + type.FullName + \".\");",
        "        }",
        "    }",
        "}",
        "",
    ])
    return "\n".join(lines)

def render_dispatcher(chunk_count):
    lines = [
        "// <auto-generated />",
        "// Generated by scripts/generate_aliases.py. Do not edit by hand.",
        "namespace UnitConverter.Catalog",
        "{",
        "    internal static partial class UnitConverterAliases",
        "    {",
        "        public static string[] GetAliases(UnitConverterFamily family, string unitName)",
        "        {",
    ]
    for index in range(1, chunk_count + 1):
        assignment = (
            "            string[] result = GetAliasesPart1(family, unitName);"
            if index == 1
            else "            result = GetAliasesPart" + str(index) + "(family, unitName);"
        )
        lines.extend([
            assignment,
            "            if (result != null)",
            "            {",
            "                return result;",
            "            }",
        ])
    lines.extend([
        "            return null;",
        "        }",
        "    }",
        "}",
        "",
    ])
    return "\n".join(lines)

def render_chunk(families, index):
    lines = [
        "// <auto-generated />",
        "// Generated by scripts/generate_aliases.py. Do not edit by hand.",
        "namespace UnitConverter.Catalog",
        "{",
        "    internal static partial class UnitConverterAliases",
        "    {",
        "        private static string[] GetAliasesPart" + str(index) + "(",
        "            UnitConverterFamily family,",
        "            string unitName)",
        "        {",
        "            switch (family)",
        "            {",
    ]
    for family, units in families:
        lines.append("                case UnitConverterFamily." + family + ":")
        lines.append("                    switch (unitName)")
        lines.append("                    {")
        for unit, aliases in units.items():
            if not aliases:
                continue
            rendered = ", ".join(csharp_string(alias) for alias in aliases)
            lines.append('                        case "' + unit + '":')
            lines.append("                            return new[] { " + rendered + " };")
        lines.append("                        default:")
        lines.append("                            return null;")
        lines.append("                    }")
    lines.extend([
        "                default:",
        "                    return null;",
        "            }",
        "        }",
        "    }",
        "}",
        "",
    ])
    return "\n".join(lines)

def rendered_files(model):
    family_items = list(model.items())
    chunks = [
        family_items[index:index + CHUNK_SIZE]
        for index in range(0, len(family_items), CHUNK_SIZE)
    ]
    files = {
        DISPATCHER: render_dispatcher(len(chunks)),
        OUTPUT_DIR / "UnitConverterUnitValues.Generated.cs": render_unit_values(model),
    }
    for index, chunk in enumerate(chunks, 1):
        path = OUTPUT_DIR / ("UnitConverterAliases.Generated." + str(index) + ".cs")
        files[path] = render_chunk(chunk, index)
    return files

def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("--check", action="store_true")
    args = parser.parse_args()

    files = rendered_files(read_model())
    if args.check:
        stale = [
            path for path, output in files.items()
            if not path.exists() or path.read_text(encoding="utf-8") != output
        ]
        if stale:
            print(
                "Generated alias source is out of date: " +
                ", ".join(str(path.relative_to(ROOT)) for path in stale) +
                ". Run: python scripts/generate_aliases.py",
                file=sys.stderr,
            )
            return 1
        print("Generated alias source is up to date.")
        return 0

    for path, output in files.items():
        path.write_text(output, encoding="utf-8")
        print("Generated", path.relative_to(ROOT))
    return 0

if __name__ == "__main__":
    raise SystemExit(main())
