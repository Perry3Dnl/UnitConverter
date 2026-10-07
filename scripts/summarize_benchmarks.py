#!/usr/bin/env python3
"""Create compact BenchmarkDotNet summaries and README badge assets."""

from __future__ import annotations

import argparse
import csv
import html
import json
import re
from pathlib import Path


BADGES = {
    "RoutedDouble": ("routed double", "routed-double.svg", False),
    "NamedQuantityDecimal": ("named decimal", "named-decimal.svg", False),
    "SpanParseLength": ("span parse", "span-parse.svg", True),
    "SpanFormatLength": ("span format", "span-format.svg", True),
    "ExactDecimal": ("exact decimal", "exact-decimal.svg", True),
}


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
            "Allocation changes are generally the stronger regression signal.",
            "",
        ]
    )
    return "\n".join(lines)


def compact_mean(value: str) -> str:
    value = value.replace("μs", "µs").strip()
    value = re.sub(r"\s+", " ", value)
    return value


def compact_alloc(value: str) -> str:
    value = value.strip()
    if not value or value == "-":
        return "0 B"
    return re.sub(r"\s+", " ", value)


def badge_svg(label: str, value: str, color: str) -> str:
    label_width = max(58, int(len(label) * 6.2 + 18))
    value_width = max(62, int(len(value) * 6.2 + 18))
    total = label_width + value_width
    label_x = label_width / 2
    value_x = label_width + value_width / 2
    aria = html.escape(f"{label}: {value}", quote=True)
    label_text = html.escape(label)
    value_text = html.escape(value)
    return f"""<svg xmlns="http://www.w3.org/2000/svg" width="{total}" height="20" role="img" aria-label="{aria}">
  <title>{aria}</title>
  <linearGradient id="s" x2="0" y2="100%">
    <stop offset="0" stop-color="#bbb" stop-opacity=".1"/>
    <stop offset="1" stop-opacity=".1"/>
  </linearGradient>
  <clipPath id="r"><rect width="{total}" height="20" rx="3" fill="#fff"/></clipPath>
  <g clip-path="url(#r)">
    <rect width="{label_width}" height="20" fill="#555"/>
    <rect x="{label_width}" width="{value_width}" height="20" fill="{color}"/>
    <rect width="{total}" height="20" fill="url(#s)"/>
  </g>
  <g fill="#fff" text-anchor="middle" font-family="Verdana,DejaVu Sans,sans-serif" font-size="11">
    <text x="{label_x}" y="15" fill="#010101" fill-opacity=".3">{label_text}</text>
    <text x="{label_x}" y="14">{label_text}</text>
    <text x="{value_x}" y="15" fill="#010101" fill-opacity=".3">{value_text}</text>
    <text x="{value_x}" y="14">{value_text}</text>
  </g>
</svg>
"""


def write_badges(rows: list[dict[str, str]], output_dir: Path) -> None:
    by_method = {row["method"]: row for row in rows}
    output_dir.mkdir(parents=True, exist_ok=True)

    for method, (label, filename, include_alloc) in BADGES.items():
        row = by_method.get(method)
        if row is None:
            raise SystemExit(f"Missing benchmark required for badge: {method}")

        mean = compact_mean(row["mean"] or "n/a")
        allocated = compact_alloc(row["allocated"])
        value = f"{mean}/op"
        if include_alloc:
            value += f" | {allocated}"

        zero_alloc = allocated in {"0 B", "0.000 B"}
        color = "#4c1" if zero_alloc else "#007ec6"
        (output_dir / filename).write_text(
            badge_svg(label, value, color),
            encoding="utf-8",
        )


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument("results_dir", type=Path)
    parser.add_argument("output_dir", type=Path)
    parser.add_argument("--badges", type=Path)
    parser.add_argument("--latest-json", type=Path)
    args = parser.parse_args()

    rows = normalize(load_rows(args.results_dir))
    args.output_dir.mkdir(parents=True, exist_ok=True)

    payload = {"benchmarks": rows}
    (args.output_dir / "summary.json").write_text(
        json.dumps(payload, indent=2) + "\n",
        encoding="utf-8",
    )
    (args.output_dir / "summary.md").write_text(
        render_markdown(rows),
        encoding="utf-8",
    )

    if args.latest_json is not None:
        args.latest_json.parent.mkdir(parents=True, exist_ok=True)
        args.latest_json.write_text(
            json.dumps(payload, indent=2) + "\n",
            encoding="utf-8",
        )

    if args.badges is not None:
        write_badges(rows, args.badges)

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
