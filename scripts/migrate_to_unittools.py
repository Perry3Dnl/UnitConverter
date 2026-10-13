#!/usr/bin/env python3
"""One-time, all-tracked-files UnitConverter -> UnitTools source migration.

Run only on a dedicated migration branch. Rebuild all generated artifacts,
refresh the public API baseline, and run CI before merging.
"""
from pathlib import Path
import subprocess

ROOT = Path(__file__).resolve().parents[1]
def git(*args):
    return subprocess.check_output(["git", *args], cwd=ROOT)

tracked = [Path(p.decode()) for p in git("ls-files", "-z").split(b"\0") if p]
changes = 0
renamed = 0
for relative in sorted(tracked, key=lambda p: (len(p.parts), len(str(p))), reverse=True):
    # The GitHub Actions token cannot push modifications to workflow files.
    # Update those separately through the authorized GitHub connector after PR creation.
    if relative.parts[:2] == (".github", "workflows"):
        continue
    original = ROOT / relative
    if not original.is_file():
        continue
    raw = original.read_bytes()
    try:
        content = raw.decode("utf-8")
    except UnicodeDecodeError:
        content = None

    if content is not None:
        updated = (content.replace("UnitConverter", "UnitTools")
                          .replace("unitconverter", "unittools")
                          .replace("UNITCONVERTER", "UNITTOOLS"))
        if updated != content:
            original.write_bytes(updated.encode("utf-8"))
            changes += 1

    new_relative = Path(str(relative).replace("UnitConverter", "UnitTools")
                                     .replace("unitconverter", "unittools")
                                     .replace("UNITCONVERTER", "UNITTOOLS"))
    if new_relative != relative:
        target = ROOT / new_relative
        if target.exists():
            raise SystemExit(f"Rename destination already exists: {new_relative}")
        target.parent.mkdir(parents=True, exist_ok=True)
        subprocess.check_call(["git", "mv", str(relative), str(new_relative)], cwd=ROOT)
        renamed += 1

print(f"Rewritten {changes} tracked text files; renamed {renamed} tracked files.")
print("Next: regenerate sources and API baseline, then run full CI and review diff.")
