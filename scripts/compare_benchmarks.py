#!/usr/bin/env python3
"""Compare BenchmarkDotNet compact summaries against a reference baseline."""

from __future__ import annotations

import argparse
import json
import math
import re
from pathlib import Path


TIME_UNITS_NS = {
    "ns": 1.0,
    "us": 1_000.0,
    "µs": 1_000.0,
    "μs": 1_000.0,
    "ms": 1_000_000.0,
    "s": 1_000_000_000.0,
}

ALLOC_UNITS_B = {
    "B": 1.0,
    "KB": 1024.0,
    "MB": 1024.0 * 1024.0,
    "GB": 1024.0 * 1024.0 * 1024.0,
}


def load(path: Path) -> dict[str, dict[str, str]]:
    payload = json.loads(path.read_text(encoding="utf-8"))
    rows = payload.get("benchmarks")
    if not isinstance(rows, list):
        raise SystemExit(f"{path} does not contain a 'benchmarks' list")

    result: dict[str, dict[str, str]] = {}
    for row in rows:
        if not isinstance(row, dict):
            continue
        method = str(row.get("method", "")).strip()
        if method:
            result[method] = {str(k): str(v) for k, v in row.items()}
    return result


def parse_number(text: str) -> float:
    return float(text.replace(",", "").strip())


def parse_time_ns(text: str) -> float | None:
    text = text.strip()
    if not text or text == "-":
        return None

    match = re.fullmatch(
        r"([0-9][0-9,]*(?:\.[0-9]+)?)\s*(ns|us|µs|μs|ms|s)",
        text,
    )
    if match is None:
        return None

    return parse_number(match.group(1)) * TIME_UNITS_NS[match.group(2)]


def parse_alloc_bytes(text: str) -> float | None:
    text = text.strip()
    if not text or text == "-":
        return 0.0

    match = re.fullmatch(
        r"([0-9][0-9,]*(?:\.[0-9]+)?)\s*(B|KB|MB|GB)",
        text,
    )
    if match is None:
        return None

    return parse_number(match.group(1)) * ALLOC_UNITS_B[match.group(2)]


def format_percent(value: float | None) -> str:
    if value is None or not math.isfinite(value):
        return "n/a"

    sign = "+" if value > 0 else ""
    return f"{sign}{value:.1f}%"


def format_bytes_delta(value: float | None) -> str:
    if value is None or not math.isfinite(value):
        return "n/a"

    rounded = int(round(value))
    sign = "+" if rounded > 0 else ""
    return f"{sign}{rounded} B"


def compare(
    reference: dict[str, dict[str, str]],
    current: dict[str, dict[str, str]],
    timing_warning_percent: float,
) -> list[dict[str, object]]:
    rows: list[dict[str, object]] = []

    for method in sorted(set(reference) | set(current)):
        before = reference.get(method)
        after = current.get(method)

        if before is None:
            rows.append(
                {
                    "method": method,
                    "status": "new",
                    "reference_mean": "",
                    "current_mean": after.get("mean", "") if after else "",
                    "timing_change_percent": None,
                    "reference_allocated": "",
                    "current_allocated": after.get("allocated", "") if after else "",
                    "allocation_delta_bytes": None,
                }
            )
            continue

        if after is None:
            rows.append(
                {
                    "method": method,
                    "status": "missing",
                    "reference_mean": before.get("mean", ""),
                    "current_mean": "",
                    "timing_change_percent": None,
                    "reference_allocated": before.get("allocated", ""),
                    "current_allocated": "",
                    "allocation_delta_bytes": None,
                }
            )
            continue

        before_ns = parse_time_ns(before.get("mean", ""))
        after_ns = parse_time_ns(after.get("mean", ""))
        timing_change = None
        if before_ns is not None and after_ns is not None and before_ns > 0:
            timing_change = (after_ns - before_ns) / before_ns * 100.0

        before_alloc = parse_alloc_bytes(before.get("allocated", ""))
        after_alloc = parse_alloc_bytes(after.get("allocated", ""))
        allocation_delta = None
        allocation_regression = False
        if before_alloc is not None and after_alloc is not None:
            allocation_delta = after_alloc - before_alloc
            allocation_regression = allocation_delta > 0.5

        timing_warning = (
            timing_change is not None
            and timing_change >= timing_warning_percent
        )

        if allocation_regression:
            status = "allocation-regression"
        elif timing_warning:
            status = "timing-warning"
        elif timing_change is not None and timing_change <= -timing_warning_percent:
            status = "improved"
        else:
            status = "stable"

        rows.append(
            {
                "method": method,
                "status": status,
                "reference_mean": before.get("mean", ""),
                "current_mean": after.get("mean", ""),
                "timing_change_percent": timing_change,
                "reference_allocated": before.get("allocated", ""),
                "current_allocated": after.get("allocated", ""),
                "allocation_delta_bytes": allocation_delta,
            }
        )

    return rows


def render_markdown(
    rows: list[dict[str, object]],
    timing_warning_percent: float,
) -> str:
    lines = [
        "# Benchmark regression comparison",
        "",
        (
            f"Timing changes of **{timing_warning_percent:g}% or more** are reported as "
            "warnings only. Allocation increases are treated as regressions when strict "
            "mode is enabled."
        ),
        "",
        "| Benchmark | Status | Mean (reference → current) | Timing Δ | Allocated (reference → current) | Allocation Δ |",
        "| --- | --- | ---: | ---: | ---: | ---: |",
    ]

    for row in rows:
        lines.append(
            "| `{method}` | {status} | {before_mean} → {after_mean} | {timing} | "
            "{before_alloc} → {after_alloc} | {alloc_delta} |".format(
                method=row["method"],
                status=row["status"],
                before_mean=row["reference_mean"] or "n/a",
                after_mean=row["current_mean"] or "n/a",
                timing=format_percent(row["timing_change_percent"]),
                before_alloc=row["reference_allocated"] or "n/a",
                after_alloc=row["current_allocated"] or "n/a",
                alloc_delta=format_bytes_delta(row["allocation_delta_bytes"]),
            )
        )

    lines.extend(
        [
            "",
            "GitHub-hosted runner timings are noisy; timing warnings are signals for review, not hard CI failures.",
            "",
        ]
    )
    return "\n".join(lines)


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument("reference_json", type=Path)
    parser.add_argument("current_json", type=Path)
    parser.add_argument("output_dir", type=Path)
    parser.add_argument("--timing-warning-percent", type=float, default=15.0)
    parser.add_argument("--fail-on-allocation-regression", action="store_true")
    parser.add_argument("--fail-on-missing", action="store_true")
    args = parser.parse_args()

    reference = load(args.reference_json)
    current = load(args.current_json)
    rows = compare(reference, current, args.timing_warning_percent)

    allocation_regressions = [
        row for row in rows if row["status"] == "allocation-regression"
    ]
    missing = [row for row in rows if row["status"] == "missing"]

    args.output_dir.mkdir(parents=True, exist_ok=True)
    payload = {
        "timing_warning_percent": args.timing_warning_percent,
        "comparisons": rows,
        "allocation_regressions": [row["method"] for row in allocation_regressions],
        "missing_benchmarks": [row["method"] for row in missing],
    }
    (args.output_dir / "comparison.json").write_text(
        json.dumps(payload, indent=2) + "\n",
        encoding="utf-8",
    )
    (args.output_dir / "comparison.md").write_text(
        render_markdown(rows, args.timing_warning_percent),
        encoding="utf-8",
    )

    blocking: list[str] = []
    if args.fail_on_allocation_regression:
        for row in allocation_regressions:
            blocking.append(
                f"{row['method']}: allocations increased from "
                f"{row['reference_allocated'] or 'n/a'} to "
                f"{row['current_allocated'] or 'n/a'}"
            )

    if args.fail_on_missing:
        for row in missing:
            blocking.append(f"{row['method']}: benchmark missing from current run")

    if blocking:
        print("Benchmark regression check failed:")
        for failure in blocking:
            print(f"- {failure}")
        return 2

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
