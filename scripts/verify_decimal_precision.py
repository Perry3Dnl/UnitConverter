#!/usr/bin/env python3
from pathlib import Path
import re
import sys

ROOT = Path(__file__).resolve().parents[1]
SOURCE = ROOT / "src" / "UnitConverter"
files = sorted(SOURCE.glob("*/UnitConverter*Extensions.cs"))
errors = []

if len(files) != 98:
    errors.append(f"Expected decimal extensions for 98 families, found {len(files)}.")

legacy = re.compile(r"\(decimal\).*Convert\(\(double\)value,\s*from,\s*to\)")
for path in files:
    text = path.read_text(encoding="utf-8")
    if "public static decimal Convert(this decimal value" not in text:
        errors.append(f"{path.relative_to(ROOT)} has no decimal Convert extension.")
    if legacy.search(text) or "Convert((double)value, from, to)" in text:
        errors.append(f"{path.relative_to(ROOT)} still routes decimal input through double.")
    if "UnitConverterExact.Convert(value, from, to)" not in text:
        errors.append(f"{path.relative_to(ROOT)} does not use UnitConverterExact for decimal conversion.")

if errors:
    print("Decimal precision verification failed:", file=sys.stderr)
    for error in errors:
        print(" - " + error, file=sys.stderr)
    raise SystemExit(1)

print(f"Verified {len(files)} family extension files use decimal-native conversion.")
