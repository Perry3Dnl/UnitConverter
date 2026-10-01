# Getting Started with RealisticPhysics Core

RealisticPhysics Core is installed automatically as part of this package.

You normally do not need to interact with Core directly. The product-specific tools, settings files, and inspectors use Core behind the scenes.

## What Core Does

Core provides shared infrastructure for RealisticPhysics packages:

- base classes for settings assets
- editor utilities for finding and creating settings files
- suite version information
- common asset path handling
- runtime/editor separation through assembly definitions

## What You Should Not Do

Avoid these changes unless you know exactly why they are needed:

```text
Moving Assets/RealisticPhysics/Core
Renaming RealisticPhysics.Core.asmdef
Renaming RealisticPhysics.Core.Editor.asmdef
Deleting Core runtime scripts
Deleting Core editor scripts
```

If something is accidentally moved or deleted, reimport the package to restore the expected structure.

## Where Product Settings Are Stored

Each installed RealisticPhysics product owns its own settings folder inside its own product folder.

Example:

```text
Assets/RealisticPhysics/UnitConverter/Settings/UnitConverterSettings.asset
```

Core provides the shared creation/opening workflow, but the product owns its own settings file.
