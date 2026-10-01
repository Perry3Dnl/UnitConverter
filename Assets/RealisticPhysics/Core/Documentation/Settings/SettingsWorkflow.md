# Settings Workflow

RealisticPhysics Core provides a shared settings asset workflow.

The important idea is:

```text
Core manages the process.
The product owns the settings file.
```

## Product-Owned Settings

Each product stores its settings inside its own product folder.

Example:

```text
Assets/RealisticPhysics/UnitConverter/Settings/UnitConverterSettings.asset
```

This keeps product settings close to the product that owns them.

## Core Utility

Core provides editor helpers for common actions:

- create a settings folder if missing
- find an existing settings asset
- create a settings asset if missing
- select and ping a settings asset in the Project window

The utility is located here:

```text
Assets/RealisticPhysics/Core/Editor/Settings/RealisticPhysicsSettingsUtility.cs
```

## Base Settings Class

Product settings inherit from:

```csharp
RealisticPhysicsSettingsAsset
```

This gives settings assets a consistent base type and shared reset/default hooks.

## Resetting Settings

Settings assets may expose a reset option in their inspector.

Resetting a product settings file should only reset that product's settings. It should not modify Core files.
