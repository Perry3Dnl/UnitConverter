# Packaging

The package ID is `UnitConverter`, targeting `netstandard2.0`. The initial standalone candidate version is `2.0.0-preview.1`, defined in `Directory.Build.props`.

## Create the package

With the .NET 10 SDK installed, run from the repository root:

```sh
dotnet restore UnitConverter.sln
dotnet build UnitConverter.sln --configuration Release --no-restore
dotnet test tests/UnitConverter.Tests/UnitConverter.Tests.csproj --configuration Release --no-build
dotnet pack src/UnitConverter/UnitConverter.csproj --configuration Release --no-build --output artifacts/packages
python scripts/verify_package.py artifacts/packages
```

Use a clean `artifacts/packages` directory when changing versions; verification requires exactly one candidate package.

Output includes the `.nupkg` for installation and `.snupkg` for debug symbols. The installable packages contain their assemblies, README, `LICENSE.md`, and `NOTICE`, with no Unity assemblies, editor tools, test dependencies, or scenes.

## Candidate versus publication

The workflow builds downloadable package artifacts. It does not push to nuget.org or a package registry.

The packages use a custom license file because the project is licensed under Apache License 2.0 subject to the Commons Clause License Condition v1.0. NuGet package metadata points to `LICENSE.md`, and both `LICENSE.md` and `NOTICE` are included at the package root. This is a source-available license, not an OSI-approved open-source license.

Before publication, confirm ownership or availability of the intended NuGet package IDs.

## References

- [.NET library targeting guidance](https://learn.microsoft.com/en-us/dotnet/standard/library-guidance/cross-platform-targeting)
- [Create a NuGet package with the .NET CLI](https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli)
