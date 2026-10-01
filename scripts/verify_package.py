"""Check the package payload and run the console sample against the packed DLL."""

from pathlib import Path
import json
import os
import shutil
import subprocess
import sys
import tempfile
import xml.etree.ElementTree as ET
import zipfile

root = Path(__file__).resolve().parents[1]
feed = Path(sys.argv[1] if len(sys.argv) > 1 else root / "artifacts/packages").resolve()
packages = list(feed.glob("UnitConverter.*.nupkg"))
if len(packages) != 1:
    raise SystemExit("Expected exactly one UnitConverter .nupkg in " + str(feed))

with zipfile.ZipFile(packages[0]) as archive:
    names = archive.namelist()
    assert "lib/netstandard2.0/UnitConverter.dll" in names
    assert "README.md" in names
    assert [name for name in names if name.endswith(".dll")] == [
        "lib/netstandard2.0/UnitConverter.dll"
    ], "Only the conversion assembly belongs in the package"
    forbidden = ("UnityEngine", "UnityEditor", "RealisticPhysics.Core", "NUnit", "nunit")
    assert not any(part in name for name in names for part in forbidden)
    assert not any(name.endswith((".unity", ".unitypackage", ".meta", ".asmdef", ".cs")) for name in names)
    specification = ET.fromstring(archive.read(next(name for name in names if name.endswith(".nuspec"))))
    namespace = {"n": specification.tag.split("}")[0][1:]}
    metadata = specification.find("n:metadata", namespace)
    package_id = metadata.findtext("n:id", namespaces=namespace)
    version = metadata.findtext("n:version", namespaces=namespace)
    assert package_id == "UnitConverter"
    dependencies = metadata.findall(".//n:dependency", namespace)
    assert all(dependency.attrib["id"] == "NETStandard.Library" for dependency in dependencies)
    assert metadata.findtext("n:readme", namespaces=namespace) == "README.md"

with tempfile.TemporaryDirectory(prefix="unitconverter-package-") as temporary:
    consumer = Path(temporary)
    environment = dict(os.environ)
    # An empty cache ensures this run consumes this build's package.
    environment["NUGET_PACKAGES"] = str(consumer / "packages")
    (consumer / "global.json").write_text((root / "global.json").read_text())
    (consumer / "NuGet.Config").write_text(
        '<configuration><packageSources><clear /></packageSources></configuration>')
    project = ET.Element("Project", Sdk="Microsoft.NET.Sdk")
    properties = ET.SubElement(project, "PropertyGroup")
    ET.SubElement(properties, "OutputType").text = "Exe"
    ET.SubElement(properties, "TargetFramework").text = "net10.0"
    ET.SubElement(properties, "ImplicitUsings").text = "disable"
    ET.SubElement(properties, "Nullable").text = "disable"
    items = ET.SubElement(project, "ItemGroup")
    ET.SubElement(items, "PackageReference", Include=package_id, Version=version)
    ET.ElementTree(project).write(consumer / "Consumer.csproj", encoding="utf-8", xml_declaration=True)
    shutil.copyfile(root / "samples/UnitConverter.Demo/Program.cs", consumer / "Program.cs")
    subprocess.run(["dotnet", "restore", "Consumer.csproj", "--source", str(feed)], cwd=consumer, env=environment, check=True)
    assets = json.loads((consumer / "obj/project.assets.json").read_text())
    assert assets["libraries"][package_id + "/" + version]["type"] == "package"
    subprocess.run(["dotnet", "run", "--project", "Consumer.csproj", "--configuration", "Release", "--no-restore"], cwd=consumer, env=environment, check=True)

print("Verified package:", packages[0].name)
