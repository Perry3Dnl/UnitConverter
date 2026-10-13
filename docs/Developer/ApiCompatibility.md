# Public API compatibility

UnitTools keeps a checked-in fingerprint baseline for the public API of the core and `UnitTools.SystemTextJson` assemblies.

The compatibility tool lives in `tools/UnitTools.ApiCompat`. It reflects every exported type and builds a canonical signature set containing public constructors, methods, properties, fields, events, enum values, and generic constraints. Each type is stored as a SHA-256 fingerprint in `docs/api/public-api-baseline.txt`.

CI runs:

```sh
dotnet run --project tools/UnitTools.ApiCompat/UnitTools.ApiCompat.csproj --configuration Release -- --check
```

Any public API change fails the build, including additive members. This is intentionally stricter than binary-compatibility-only checking: preview API changes must be deliberate and reviewed.

When an API change is intentional:

1. Review whether the change is additive, source-breaking, or binary-breaking.
2. Update tests and migration/release notes as appropriate.
3. Regenerate the baseline:

```sh
dotnet run --project tools/UnitTools.ApiCompat/UnitTools.ApiCompat.csproj --configuration Release -- --write
```

4. Review the changed type fingerprints in the same pull request.

The tool is a build-time repository utility only. It is not shipped in the NuGet package and adds no runtime dependency.
