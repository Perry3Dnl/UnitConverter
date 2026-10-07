#!/usr/bin/env python3
"""Create compact BenchmarkDotNet summaries from default CSV reports."""

from __future__ import annotations

import argparse
import csv
import json
from pathlib import Path


def load_rows(results_dir: Path) -> list[dict[str, str]]:
    rows: list[dict[str, str]] = []
    for path in sorted(results_dir.glob("*-report.csv")):
        with path.open(encoding="utf-8-sig", newline="") as handle:
            for row in csv.DictReader(handle):
                row["_report"] = path.name
                rows.append(row)
    if not rows:
        raise SystemExit(f"No BenchmarkDotNet CSV reports found in {results_dir}")
    return rows


def first(row: dict[str, str], *names: str) -> str:
    for name in names:
        value = row.get(name)
        if value is not None and value.strip():
            return value.strip()
    return ""


def normalize(rows: list[dict[str, str]]) -> list[dict[str, str]]:
    normalized: list[dict[str, str]] = []
    for row in rows:
        normalized.append(
            {
                "type": first(row, "Type", "Class"),
                "method": first(row, "Method"),
                "mean": first(row, "Mean"),
                "error": first(row, "Error"),
                "stddev": first(row, "StdDev"),
                "allocated": first(row, "Allocated"),
                "report": row["_report"],
            }
        )
    return normalized


def render_markdown(rows: list[dict[str, str]]) -> str:
    lines = [
        "# UnitConverter benchmark summary",
        "",
        "| Benchmark | Mean | Allocated |",
        "| --- | ---: | ---: |",
    ]
    for row in rows:
        name = f"{row['type']}.{row['method']}" if row["type"] else row["method"]
        lines.append(
            f"| `{name}` | {row['mean'] or 'n/a'} | {row['allocated'] or 'n/a'} |"
        )
    lines.extend(
        [
            "",
            "Numbers are measurements from the current BenchmarkDotNet run, not API guarantees.",
            "Hosted GitHub runner variance is expected; use release-to-release trends rather than tiny absolute differences.",
            "",
        ]
    )
    return "\n".join(lines)


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument("results_dir", type=Path)
    parser.add_argument("output_dir", type=Path)
    args = parser.parse_args()

    rows = normalize(load_rows(args.results_dir))
    args.output_dir.mkdir(parents=True, exist_ok=True)

    (args.output_dir / "summary.json").write_text(
        json.dumps({"benchmarks": rows}, indent=2) + "\n",
        encoding="utf-8",
    )
    (args.output_dir / "summary.md").write_text(
        render_markdown(rows),
        encoding="utf-8",
    )
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
