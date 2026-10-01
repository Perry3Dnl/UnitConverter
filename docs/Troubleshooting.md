# Troubleshooting

## SDK not found

Install the .NET 10 SDK and run `dotnet --info`. The repository's `global.json` accepts a stable .NET 10 feature band at or above 10.0.100. A runtime-only installation cannot build projects.

## Package not found on nuget.org

This repository prepares a package candidate; it has not been published. Build with `dotnet pack` and install from the absolute `artifacts/packages` path, or download the package artifact from a successful GitHub Actions run.

## Missing namespace or type

Reference `RealisticPhysics.UnitConversion` and import the family namespace, such as `RealisticPhysics.UnitConversion.Length`. Direct methods live in the unit-system subnamespace. Unity settings and editor types are absent from the standalone library.

## Duplicate converter types

Remove old copied converter sources or DLLs when adding the NuGet reference. Both versions use the same public type names.

## Fractional or decimal results

Integral extensions return `double`. Keep that value rather than casting it back to an integer. Existing decimal overloads also calculate through `double`; a decimal return type does not imply decimal-preserving arithmetic.

## Unsupported units

Use the unit enum belonging to the selected family and avoid undefined enum values. Existing exception and temperature `TryConvert` behavior is unchanged.

## Test restore fails

The test project restores its test SDK, NUnit framework, and adapter from NuGet. Check feed connectivity, then run `dotnet restore UnitConverter.sln` before testing.
