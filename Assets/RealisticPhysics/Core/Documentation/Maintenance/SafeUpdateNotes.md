# Safe Update Notes

RealisticPhysics products include Core so they can work as standalone packages.

When updating a RealisticPhysics package, keep this structure stable:

```text
Assets/RealisticPhysics/Core
Assets/RealisticPhysics/Core/Runtime/RealisticPhysics.Core.asmdef
Assets/RealisticPhysics/Core/Editor/RealisticPhysics.Core.Editor.asmdef
```

## Safe Changes

Usually safe:

- adding new helper methods
- adding new documentation
- adding optional editor utilities
- adding non-breaking fields or methods

## Risky Changes

Use caution with:

- renaming namespaces
- renaming assembly definitions
- moving Core folders
- removing public classes
- changing serialized field names

These changes can break existing projects that already imported a RealisticPhysics package.

## Reimporting

If Core files are missing or damaged, reimport the latest package version.
