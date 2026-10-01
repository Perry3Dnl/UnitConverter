# UnitConverter Settings

UnitConverter has one main settings asset. It belongs to the UnitConverter package folder, not to the suite root.

```text
Assets/RealisticPhysics/UnitConverter/Settings/UnitConverterSettings.asset
```

Open or create it from:

```text
Tools > RealisticPhysics > UnitConverter > Open Settings
```

## What Settings Control

The settings asset controls editor behavior, not the core conversion math.

Typical settings include:

```text
Enable Unity inspector overrides
Override Transform inspector
Override Rigidbody inspector
Override Collider inspectors
Override Camera inspector
Override Light inspector
Override AudioSource inspector
Preferred Transform position unit
Preferred Collider length unit
Preferred Rigidbody mass unit
Preferred Camera clip-plane unit
Preferred Light range unit
Preferred Audio distance unit
```

## Recommended Defaults

Recommended default behavior:

```text
Transform override: enabled
Other built-in inspector overrides: disabled
Master override switch: enabled
Transform position unit: meter
```

This keeps the package useful immediately while reducing conflict risk with other Unity editor extensions.
