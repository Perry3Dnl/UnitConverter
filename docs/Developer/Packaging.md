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

Normal CI builds downloadable package artifacts and never publishes them. A separate manual workflow, `.github/workflows/release-nuget.yml`, performs the same build/test/API/package-consumer validation and defaults to validation-only mode.

Publishing requires an explicit workflow dispatch with `publish=true`. The publish job is restricted to the `nuget-release` GitHub environment and uses nuget.org Trusted Publishing/OIDC rather than a long-lived API key. Configure the corresponding nuget.org trusted-publishing policy for repository owner `Perry3Dnl`, repository `UnitConverter`, workflow file `release-nuget.yml`, and environment `nuget-release`. The workflow input `nuget_user` is the nuget.org profile/user name, not an email address.

Before the first live publish, confirm ownership or availability of all three intended package IDs: `UnitConverter`, `UnitConverter.SystemTextJson`, and `UnitConverter.Analyzers`.

The packages use a custom license file because the project is licensed under Apache License 2.0 subject to the Commons Clause License Condition v1.0. NuGet package metadata points to `LICENSE.md`, and both `LICENSE.md` and `NOTICE` are included at the package root. This is a source-available license, not an OSI-approved open-source license.


## References

- [.NET library targeting guidance](https://learn.microsoft.com/en-us/dotnet/standard/library-guidance/cross-platform-targeting)
- [Create a NuGet package with the .NET CLI](https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli)
- [NuGet.org Trusted Publishing](https://learn.microsoft.com/en-us/nuget/nuget-org/trusted-publishing)