"""Validate UnitTools NuGet identity without changing legacy C# APIs.

The public namespaces/assemblies currently remain UnitConverter during migration.
Package IDs, versions, title and documentation links must consistently use UnitTools.
"""

from pathlib import Path
import xml.etree.ElementTree as ET

ROOT = Path(__file__).resolve().parents[1]
VERSION = ET.parse(ROOT / "Directory.Build.props").findtext(".//Version")
if not VERSION:
    raise SystemExit("Missing shared Version in Directory.Build.props")

projects = {
    "UnitTools": "src/UnitConverter/UnitConverter.csproj",
    "UnitTools.SystemTextJson": "src/UnitConverter.SystemTextJson/UnitConverter.SystemTextJson.csproj",
    "UnitTools.Analyzers": "src/UnitConverter.Analyzers/UnitConverter.Analyzers.csproj",
}

for package_id, relative_path in projects.items():
    project = ET.parse(ROOT / relative_path).getroot()
    def prop(name):
        return project.findtext(".//PropertyGroup/" + name)

    assert prop("PackageId") == package_id, (relative_path, "PackageId")
    assert prop("Title") == package_id, (relative_path, "Title")
    assert not prop("Version"), (relative_path, "unexpected local Version override")
    assert prop("PackageReadmeFile") == "README.NUGET.md", relative_path
    assert prop("PackageIcon") == "unitconverter.png", relative_path
    assert prop("PackageProjectUrl") == "https://github.com/Perry3Dnl/UnitTools", relative_path
    assert prop("RepositoryUrl") == "https://github.com/Perry3Dnl/UnitTools", relative_path

    items = project.findall(".//None")
    packaged_files = {
        item.get("Include"): item.get("Pack")
        for item in items
        if item.get("PackagePath") == "/"
    }
    assert packaged_files.get("../../README.NUGET.md") == "true", relative_path
    assert packaged_files.get("../../assets/unitconverter.png") == "true", relative_path

    # Only the JSON companion has a project dependency on the conversion core.
    project_refs = [ref.get("Include", "") for ref in project.findall(".//ProjectReference")]
    if package_id.endswith(".SystemTextJson"):
        assert "../UnitConverter/UnitConverter.csproj" in project_refs

readme = (ROOT / "README.NUGET.md").read_text(encoding="utf-8")
assert f"currently **{VERSION}**" in readme, "NuGet README version differs from shared Version"
assert "dotnet add package UnitTools" in readme
for package_id in projects:
    assert package_id in readme, f"NuGet README missing {package_id}"
assert "github.com/Perry3Dnl/UnitConverter" not in readme

print(f"All three UnitTools package identities match version {VERSION}.")
