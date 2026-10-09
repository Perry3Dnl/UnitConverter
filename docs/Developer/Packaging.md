# Packaging

The core package ID is `UnitConverter`, targeting `netstandard2.0` and `net8.0`. The optional companion packages are `UnitConverter.SystemTextJson` and `UnitConverter.Analyzers`, both targeting `netstandard2.0`. The current public-release candidate is `2.0.0-preview.2`, defined centrally in `Directory.Build.props`.

## Create the package

With the .NET 10 SDK installed, run from the repository root:

```sh
dotnet restore UnitConverter.sln
dotnet build UnitConverter.sln --configuration Release --no-restore
dotnet test tests/UnitConverter.Tests/UnitConverter.Tests.csproj --configuration Release --no-build
dotnet pack src/UnitConverter/UnitConverter.csproj --configuration Release --no-build --output artifacts/packages
dotnet pack src/UnitConverter.SystemTextJson/UnitConverter.SystemTextJson.csproj --configuration Release --no-build --output artifacts/packages
dotnet pack src/UnitConverter.Analyzers/UnitConverter.Analyzers.csproj --configuration Release --no-build --output artifacts/packages
python scripts/verify_package.py artifacts/packages
```

Use a clean `artifacts/packages` directory when changing versions; verification requires exactly one candidate package.

Output includes the `.nupkg` for installation and `.snupkg` for debug symbols. The installable packages contain their assemblies, README, `LICENSE.md`, and `NOTICE`, with no Unity assemblies, editor tools, test dependencies, or scenes.

## Candidate versus publication

The workflow builds downloadable package artifacts. It does not push to nuget.org or a package registry.

The packages use a custom license file because the project is licensed under Apache License 2.0 subject to the Commons Clause License Condition v1.0. NuGet package metadata points to `LICENSE.md`, and both `LICENSE.md` and `NOTICE` are included at the package root. This is a source-available license, not an OSI-approved open-source license.

Before publication, confirm ownership or availability of the intended NuGet package IDs.


## NuGet publication

Publication is intentionally separate from the normal build workflow. `.github/workflows/publish-nuget.yml` is manual-only and first reruns generated-source checks, the public API compatibility baseline, the full test suite, package verification, and the clean consumer matrix. Only the second job receives GitHub OIDC permission.

The workflow uses NuGet Trusted Publishing through `NuGet/login@v1`; no long-lived NuGet API key is stored in the repository.

Before the first publish:

1. Confirm that the intended IDs `UnitConverter`, `UnitConverter.SystemTextJson`, and `UnitConverter.Analyzers` are available to or already owned by the intended NuGet.org account. The repository does not assume ID ownership.
2. On NuGet.org, create a Trusted Publishing policy for this GitHub repository and workflow file `publish-nuget.yml`.
3. Configure the policy with GitHub environment `nuget-release`.
4. Create the matching GitHub environment `nuget-release`; required reviewers are recommended so a manual dispatch still needs human approval.
5. Run **Publish NuGet release** manually, provide the NuGet.org username that owns the policy, and type exactly `publish` in the confirmation input.
6. After the first successful publish, verify package README rendering, license presentation, symbols, dependency metadata, target frameworks, and ownership directly on nuget.org.

For a private GitHub repository, NuGet.org can initially show a Trusted Publishing policy as temporarily active until the first successful publish associates the immutable GitHub owner/repository identifiers.

The publication workflow uses `--skip-duplicate`, but a version should still be treated as immutable once published. Change the central version in `Directory.Build.props` for every subsequent release.

## Release checklist

Before publishing a preview or stable release:

- `main` CI is green, including the public API fingerprint gate.
- Performance regression CI is green.
- `python scripts/verify_package.py artifacts/packages` passes the netstandard2.0 compile consumer and net8.0/net10.0 run consumers.
- `docs/LocalizationCoverage.md` accurately distinguishes complete and partial locale families.
- Release notes and README describe the exact version being published.
- Package IDs and NuGet.org ownership are verified.
- The repository/project URL is intentionally accessible at the level expected for public package consumers.
- Package icon/branding is reviewed if an icon is going to be used; do not block correctness on branding.
- The GitHub `nuget-release` environment and NuGet Trusted Publishing policy match `publish-nuget.yml`.

## References

- [.NET library targeting guidance](https://learn.microsoft.com/en-us/dotnet/standard/library-guidance/cross-platform-targeting)
- [Create a NuGet package with the .NET CLI](https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli)