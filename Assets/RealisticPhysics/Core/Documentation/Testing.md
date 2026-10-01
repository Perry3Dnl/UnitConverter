# RealisticPhysics Testing

RealisticPhysics uses Unity's built-in Test Framework for package tests.

Core includes shared test helpers and EditMode tests for framework-level behavior. Individual assets, such as UnitConverter, add their own EditMode tests for asset-specific logic.

Run tests from:

`Window > General > Test Runner > EditMode > Run All`

The test assemblies are kept separate so each package can test its own functionality while still sharing common RealisticPhysics test utilities.
