# Editor Utilities

Core contains shared editor utilities used by installed RealisticPhysics products.

## Settings Utility

Location:

```text
Assets/RealisticPhysics/Core/Editor/Settings/RealisticPhysicsSettingsUtility.cs
```

Typical responsibilities:

- ensure folders exist
- find settings assets by type
- create missing settings assets
- select and ping assets in the Project window

These utilities are Editor-only and are not included in builds.

## Runtime Safety

Core runtime scripts must not depend on editor scripts.

Runtime scripts live under:

```text
Assets/RealisticPhysics/Core/Runtime
```

Editor scripts live under:

```text
Assets/RealisticPhysics/Core/Editor
```

This split helps prevent build errors caused by accidental `UnityEditor` references in runtime code.
