# UnitConverter Testing

UnitConverter includes Unity Test Framework EditMode tests.

The test suite includes:

- Known-value checks for every supported out-of-the-box unit against its base unit.
- From-base checks for every supported out-of-the-box unit.
- Round-trip checks from unit to base unit and back.
- Broad reflection smoke tests for compatible conversion paths.
- Extension method checks for supported numeric value types.

Run the tests from:

`Window > General > Test Runner > EditMode > Run All`

These tests are intended to verify that shipped conversion values remain stable when the package is updated.
