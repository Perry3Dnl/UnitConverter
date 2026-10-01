# Packaging

The package ID is `RealisticPhysics.UnitConversion`, targeting `netstandard2.0`. The initial standalone candidate version is `2.0.0-preview.1`, defined in `Directory.Build.props`.

## Create the package

With the .NET 10 SDK installed, run from the repository root:

```sh
dotnet restore UnitConverter.sln
dotnet build UnitConverter.sln --configuration Release --no-restore
dotnet test tests/RealisticPhysics.UnitConversion.Tests/RealisticPhysics.UnitConversion.Tests.csproj --configuration Release --no-build
dotnet pack src/RealisticPhysics.UnitConversion/RealisticPhysics.UnitConversion.csproj --configuration Release --no-build --output artifacts/packages
python scripts/verify_package.py artifacts/packages
```

Use a clean `artifacts/packages` directory when changing versions; verification requires exactly one candidate package.

Output includes the `.nupkg` for installation and `.snupkg` for debug symbols. The installable package contains the conversion DLL and README, with no Unity assemblies, editor tools, test dependencies, or scenes. Only the library project is packable.

## Candidate versus publication

The workflow builds downloadable package artifacts. It does not push to nuget.org or a package registry.

Before a public release, choose the project license and add matching package license metadata; the original source did not include a license. Also confirm ownership or availability of the intended NuGet package ID. No license has been assigned automatically during migration.

## References

- [.NET library targeting guidance](https://learn.microsoft.com/en-us/dotnet/standard/library-guidance/cross-platform-targeting)
- [Create a NuGet package with the .NET CLI](https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli)
