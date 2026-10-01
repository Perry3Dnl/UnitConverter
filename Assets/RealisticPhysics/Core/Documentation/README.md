# RealisticPhysics Core

RealisticPhysics Core is the shared framework included with RealisticPhysics products.

It provides the common foundation used by the package, including:

- shared settings asset base classes
- shared editor settings utilities
- shared suite version information
- consistent folder conventions
- runtime/editor assembly separation

For normal users, Core is mostly invisible. It should remain installed because package tools and settings workflows depend on it.

## Important

Do not delete or move this folder:

```text
Assets/RealisticPhysics/Core
```

Do not rename the Core assembly definition files:

```text
RealisticPhysics.Core
RealisticPhysics.Core.Editor
```

Changing these names or paths can break package scripts, inspectors, and settings tools.

## Included Documentation

```text
GettingStarted.md
FolderStructure.md
Settings/SettingsWorkflow.md
Editor/EditorUtilities.md
Maintenance/SafeUpdateNotes.md
Troubleshooting.md
Changelog.md
```

This documentation explains how Core behaves inside an installed RealisticPhysics product. It intentionally does not describe internal publisher-only steps for creating new RealisticPhysics products.
