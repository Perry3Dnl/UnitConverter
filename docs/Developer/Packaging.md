# Packaging

Release v1.0.1: synchronized three-package patch release with NuGet gallery README and immutable v1.0.0 tag.

The core package ID is `UnitTools`, targeting `netstandard2.0` and `net8.0`. The optional companion packages are `UnitTools.SystemTextJson` and `UnitTools.Analyzers`, both targeting `netstandard2.0`. The current public-release candidate is `1.0.1`, defined centrally in `Directory.Build.props`.

## Create the package

With the .NET 10 SDK installed, run from the repository root:

```sh
dotnet restore UnitTools.sln
dotnet build UnitTools.sln --configuration Release --no-restore
dotnet test tests/UnitTools.Tests/UnitTools.Tests.csproj --configuration Release --no-build
dotnet pack src/UnitTools/UnitTools.csproj --configuration Release --no-build --output artifacts/packages
dotnet pack src/UnitTools.SystemTextJson/UnitTools.SystemTextJson.csproj --configuration Release --no-build --output artifacts/packages
dotnet pack src/UnitTools.Analyzers/UnitTools.Analyzers.csproj --configuration Release --no-build --output artifacts/packages
python scripts/verify_package.py artifacts/packages
```

Use a clean `artifacts/packages` directory when changing versions; verification requires exactly one candidate package.

Output includes the `.nupkg` for installation and `.snupkg` for debug symbols. The installable packages contain their assemblies, README, `LICENSE.md`, and `NOTICE`, with no Unity assemblies, editor tools, test dependencies, or scenes.

## Candidate versus publication

The workflow builds downloadable package artifacts. It does not push to nuget.org or a package registry.

The packages use a custom license file because the project is licensed under Apache License 2.0 subject to the Commons Clause License Condition v1.0. NuGet package metadata points to `LICENSE.md`, and both `LICENSE.md` and `NOTICE` are included at the package root. This is a source-available license, not an OSI-approved open-source license.

Before publication, confirm ownership or availability of the intended NuGet package IDs.


## NuGet publication — Unclaimable-style tagged workflow

The workflow `.github/workflows/publish-nuget.yml` runs package validation on pushes, pull requests and manual dispatches. It publishes **only a validated version tag** matching the central `Directory.Build.props` version and pointing at the current `main` commit.

To publish `1.0.1`:

1. Confirm all main CI checks and package validation are green.
2. Configure GitHub Actions secret `NUGET_USER` to the owning NuGet.org username (not an email or API key).
3. Configure the NuGet Trusted Publishing policy for owner `Perry3Dnl`, repository `UnitTools`, workflow `publish-nuget.yml`, and GitHub environment `nuget-release`. Create the matching GitHub environment.
4. Push a dedicated commit to `main` whose message begins with **`Release v1.0.1`**. After validation succeeds, the workflow creates `v1.0.1` and dispatches a tagged workflow run.
5. That tagged run validates the version/tag and all release gates again, publishes the three packages and available symbol packages using short-lived OIDC credentials, then creates a GitHub Release with all packages and `SHA256SUMS.txt`.

The release commit is the only automatic publishing trigger on `main`. Manually dispatching the workflow on `main` performs validation only. Publishing is restricted to a version tag. Do not reuse a published version or move an existing release tag.

GitHub Actions can also be manually dispatched on an existing correct version tag for recovery. The first NuGet publication requires the package IDs to be available or owned by the NuGet account; a public GitHub repository does not confer NuGet package ownership.

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
## Package README files

GitHub renders the repository-root `README.md`. NuGet displays the separately maintained `README.NUGET.md`, declared through `<PackageReadmeFile>README.NUGET.md</PackageReadmeFile>` and embedded in each of the three packages. Keep links in the NuGet version absolute, because relative repository links and benchmark badge assets are not guaranteed to resolve in NuGet's gallery. The package verification script checks that all three packages embed the exact NuGet README and declare it in their nuspec metadata.
