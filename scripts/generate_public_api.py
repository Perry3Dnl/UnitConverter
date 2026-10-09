"""Generate or verify the checked-in public API surface baseline."""

from __future__ import annotations

import argparse
import os
from pathlib import Path
import subprocess
import sys

ROOT = Path(__file__).resolve().parents[1]
OUTPUT = ROOT / "docs" / "api" / "PublicApi.txt"
TOOL = ROOT / "tools" / "UnitConverter.ApiSurface" / "UnitConverter.ApiSurface.csproj"

ASSEMBLIES = [
    ("UnitConverter/netstandard2.0", ROOT / "src" / "UnitConverter" / "bin" / "Release" / "netstandard2.0" / "UnitConverter.dll"),
    ("UnitConverter/net8.0", ROOT / "src" / "UnitConverter" / "bin" / "Release" / "net8.0" / "UnitConverter.dll"),
    ("UnitConverter.SystemTextJson/netstandard2.0", ROOT / "src" / "UnitConverter.SystemTextJson" / "bin" / "Release" / "netstandard2.0" / "UnitConverter.SystemTextJson.dll"),
]


def run(command: list[str], env: dict[str, str] | None = None) -> None:
    subprocess.run(command, cwd=ROOT, env=env, check=True)


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument("--check", action="store_true")
    parser.add_argument("--no-build", action="store_true")
    args = parser.parse_args()

    if not args.no_build:
        run(["dotnet", "build", "src/UnitConverter/UnitConverter.csproj", "-c", "Release"])
        run(["dotnet", "build", "src/UnitConverter.SystemTextJson/UnitConverter.SystemTextJson.csproj", "-c", "Release"])
        run(["dotnet", "build", str(TOOL), "-c", "Release"])

    missing = [str(path.relative_to(ROOT)) for _, path in ASSEMBLIES if not path.exists()]
    if missing:
        print("Missing built assemblies: " + ", ".join(missing), file=sys.stderr)
        return 2

    command = [
        "dotnet",
        "run",
        "--project",
        str(TOOL),
        "-c",
        "Release",
        "--no-build",
        "--",
        str(OUTPUT),
    ]
    command.extend(f"{label}={path}" for label, path in ASSEMBLIES)

    env = os.environ.copy()
    if args.check:
        env["UNITCONVERTER_API_CHECK"] = "1"

    run(command, env=env)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
