# Core Troubleshooting

## Scripts Do Not Compile

Check that these files exist:

```text
Assets/RealisticPhysics/Core/Runtime/RealisticPhysics.Core.asmdef
Assets/RealisticPhysics/Core/Editor/RealisticPhysics.Core.Editor.asmdef
```

Check that Core has not been moved or renamed.

## Settings Menu Does Not Work

Product settings menus use Core editor utilities.

Check that this file exists:

```text
Assets/RealisticPhysics/Core/Editor/Settings/RealisticPhysicsSettingsUtility.cs
```

If the file is missing, reimport the package.

## Build Error Mentions UnityEditor

A runtime script may be referencing editor-only code.

Core runtime code should live under:

```text
Assets/RealisticPhysics/Core/Runtime
```

Core editor code should live under:

```text
Assets/RealisticPhysics/Core/Editor
```

Only editor assemblies should reference `UnityEditor`.

## Duplicate Core Folders

There should be one Core folder:

```text
Assets/RealisticPhysics/Core
```

If another Core copy exists elsewhere, remove the duplicate after backing up the project.
