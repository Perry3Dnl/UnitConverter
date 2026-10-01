# Unity Inspector Overrides

UnitConverter can optionally replace or enhance selected Unity built-in inspectors.

The design rule is:

```text
Unity stores native values.
UnitConverter displays and edits converted values.
Edited values are converted back before being stored.
```

## Transform

Transform position is stored in Unity units. UnitConverter treats that value as meters for display conversion.

Example:

```text
Stored value: 2.5
Display unit: centimeter
Inspector displays: 250 cm
```

If the user edits the display value back to `100 cm`, Unity stores `1.0`.

## Supported Override Targets

Included editor overrides:

```text
Transform
Rigidbody
BoxCollider
SphereCollider
CapsuleCollider
CharacterController
Camera
Light
AudioSource
```

Transform is enabled by default. Others are disabled until enabled in settings.

## Why Overrides Are Optional

Unity built-in inspector overrides can conflict with other editor tools that also override the same components. The settings asset includes switches so users can disable individual overrides or the whole override system.
