# Troubleshooting

This page covers common setup and usage issues you may run into while working with UnitConverter in Unity.

## Extension Method Does Not Appear

Make sure you have imported the namespace for the conversion family you want to use.

For example, Length extension methods require:

```csharp
using RealisticPhysics.UnitConversion.Length;
```

Extension methods are organized by conversion family. For example, Length methods are available from the Length namespace, while Power methods are available from the Power namespace.

If an extension method still does not appear, check that:

* The package has finished compiling in Unity.
* The script is inside an assembly that can reference UnitConverter.
* You are using a supported numeric type for the extension method.

## I Cannot Convert Meters to Watts

This is expected behavior.

UnitConverter only converts between units that belong to the same conversion family. A meter is a Length unit, while a watt is a Power unit, so they cannot be converted into each other.

Use matching unit families when converting values.

Example:

```text
Meter -> Centimeter
Watt -> Kilowatt
Second -> Minute
Kilogram -> Pound
```

## Transform Inspector Looks Wrong

If the Transform inspector does not look the way you expect, open the UnitConverter settings:

```text
Tools > RealisticPhysics > UnitConverter > Open Settings
```

Then disable the Transform override.

If the issue continues, another editor tool or inspector customization package may also be overriding the Transform inspector. Try disabling other editor extensions temporarily to check for conflicts.

## Rigidbody or Collider Overrides Are Not Active

Some inspector overrides are disabled by default so they do not change your editor workflow unless you enable them.

Open the UnitConverter settings and enable the Rigidbody or Collider overrides you want to use.

```text
Tools > RealisticPhysics > UnitConverter > Open Settings
```

After changing the setting, select the object again to refresh the inspector.

## I Changed a Setting but Nothing Changed

Unity may not refresh the inspector immediately after a settings change.

Try one of the following:

* Select a different GameObject, then select the original object again.
* Close and reopen the Inspector window.
* Recompile scripts if Unity is waiting for a compile refresh.
* Restart Unity if the editor is not updating correctly.

## Results Are Slightly Rounded

Most UnitConverter math uses `double` for precision.

If you use a `float`-returning extension method, the final result is cast back to `float`. This means the value is limited by normal `float` precision.

For the best precision, use `double` conversions where possible.

Example:

```csharp
using RealisticPhysics.UnitConversion.Length;

public class Example
{
    public double ConvertWithDouble()
    {
        return UnitConverterLength.Convert(
            1.23456789,
            UnitConverterLengthUnit.Meter,
            UnitConverterLengthUnit.Centimeter);
    }
}
```

## Conversion Result Is Not What I Expected

Check that the input value and units are in the correct order.

The general pattern is:

```text
Convert(value, fromUnit, toUnit)
```

For example:

```csharp
UnitConverterLength.Convert(
    1.5,
    UnitConverterLengthUnit.Meter,
    UnitConverterLengthUnit.Centimeter);
```

This converts from meters to centimeters, not from centimeters to meters.

## Script Does Not Compile After Import

If Unity reports compile errors after import, try the following:

* Let Unity finish importing and compiling all scripts.
* Check that the package folders were imported completely.
* Make sure your project uses a compatible Unity version.
* Check whether another package has a namespace or assembly conflict.

If the issue points to a specific script or missing type, review the error message in the Unity Console and confirm that the required namespace is imported.
