# Core Folder Structure

Expected Core folder layout:

```text
Assets/RealisticPhysics/Core
├── Runtime
│   ├── RealisticPhysics.Core.asmdef
│   ├── RealisticPhysicsSuiteVersion.cs
│   └── Settings
│       ├── RealisticPhysicsAssetBase.cs
│       └── RealisticPhysicsSettingsAsset.cs
│
├── Editor
│   ├── RealisticPhysics.Core.Editor.asmdef
│   └── Settings
│       └── RealisticPhysicsSettingsUtility.cs
│
└── Documentation
```

## Runtime

Runtime contains code that can be used in builds.

It must not use `UnityEditor`.

## Editor

Editor contains Unity Editor-only utilities.

It can use `UnityEditor` and is not included in player builds.

## Documentation

Documentation contains user-facing notes for the installed Core framework.

It should explain how to safely use and maintain the installed package, not internal product-development workflows.
