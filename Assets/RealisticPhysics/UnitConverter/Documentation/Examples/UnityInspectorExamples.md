# Unity Inspector Examples

## Transform Position

If Transform position unit is set to centimeters, a stored Unity position of `1.5` is displayed as `150 cm`.

The stored Transform value remains Unity-native. UnitConverter only changes the editor display and edit flow.

## Rigidbody Mass

If Rigidbody override is enabled and mass unit is set to pounds, the inspector can display Rigidbody mass in pounds while storing the Unity value as kilograms.

## Colliders

Collider radius, height, and size values can be displayed in the selected length unit.

Examples:

```text
SphereCollider.radius
CapsuleCollider.radius
CapsuleCollider.height
BoxCollider.size
CharacterController.radius
CharacterController.height
```

## Camera

Camera near/far clip planes can use length units. Field of view should normally remain degrees.

## Light

Light range can use length units. Intensity handling should be treated carefully because render pipeline behavior differs.
