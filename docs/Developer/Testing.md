# Testing

Run the tests with the .NET 10 SDK:

```sh
dotnet test tests/UnitTools.Tests/UnitTools.Tests.csproj --configuration Release
```

The original 100 conversion test files cover known to-base/from-base values, round trips, reflection smoke checks, and numeric extensions. The shared assertion helper now belongs to the test project. NUnit 3 is retained so its existing assertions can run unchanged.

Additional assembly checks verify that no Unity or shared Core dependency remains and that all original families and unit entries are present.

The original absolute and relative tolerances are preserved. Some very small expected values have permissive absolute tolerances; passing these tests alone does not prove numerical accuracy for every conversion.

## Package installation check

After a Release build and `dotnet pack`, run:

```sh
python scripts/verify_package.py artifacts/packages
```

This requires Python 3 and the .NET 10 SDK. The script inspects the archive, checks that only the conversion assembly is shipped, and installs it from the local feed into a temporary console project with a fresh package cache. It then runs static, direct, extension, temperature, and reciprocal-conversion examples against the package.

GitHub Actions performs both the NUnit suite and the package check, and saves test results and package artifacts.
