"""Check package payloads and consume the release packages in a clean console project."""

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

build_properties = ET.parse(root / "Directory.Build.props").getroot()
expected_version = build_properties.findtext(".//Version")
if not expected_version:
    raise SystemExit("Directory.Build.props must define a package Version")

packages = {
    path.name: path
    for path in feed.glob("*.nupkg")
    if not path.name.endswith(".symbols.nupkg")
}

expected_package_names = {
    "core": "UnitConverter." + expected_version + ".nupkg",
    "json": "UnitConverter.SystemTextJson." + expected_version + ".nupkg",
    "analyzers": "UnitConverter.Analyzers." + expected_version + ".nupkg",
}

missing = [
    name for name in expected_package_names.values()
    if name not in packages
]
if missing:
    raise SystemExit("Missing expected package(s): " + ", ".join(missing))

core_package = packages[expected_package_names["core"]]
json_package = packages[expected_package_names["json"]]
analyzer_package = packages[expected_package_names["analyzers"]]

def read_metadata(package):
    with zipfile.ZipFile(package) as archive:
        names = archive.namelist()
        specification = ET.fromstring(
            archive.read(next(name for name in names if name.endswith(".nuspec"))))
        namespace = {"n": specification.tag.split("}")[0][1:]}
        metadata = specification.find("n:metadata", namespace)
        return archive, names, metadata, namespace

with zipfile.ZipFile(core_package) as archive:
    names = archive.namelist()
    assert "lib/netstandard2.0/UnitConverter.dll" in names
    assert "README.md" in names
    assert "LICENSE.md" in names
    assert "NOTICE" in names
    assert sorted(name for name in names if name.endswith(".dll")) == [
        "lib/net8.0/UnitConverter.dll",
        "lib/netstandard2.0/UnitConverter.dll",
    ], "Only the conversion assembly and supported target-framework assets belong in the core package"
    forbidden = ("UnityEngine", "UnityEditor", "RealisticPhysics.Core", "NUnit", "nunit")
    assert not any(part in name for name in names for part in forbidden)
    assert not any(name.endswith((".unity", ".unitypackage", ".meta", ".asmdef", ".cs")) for name in names)
    specification = ET.fromstring(
        archive.read(next(name for name in names if name.endswith(".nuspec"))))
    namespace = {"n": specification.tag.split("}")[0][1:]}
    metadata = specification.find("n:metadata", namespace)
    core_id = metadata.findtext("n:id", namespaces=namespace)
    core_version = metadata.findtext("n:version", namespaces=namespace)
    assert core_id == "UnitConverter"
    assert core_version == expected_version
    assert metadata.findtext("n:title", namespaces=namespace) == "UnitConverter"
    assert metadata.findtext("n:releaseNotes", namespaces=namespace)
    assert metadata.findtext("n:copyright", namespaces=namespace) == "Copyright © 2026 Perry3Dnl"
    dependencies = metadata.findall(".//n:dependency", namespace)
    assert all(dependency.attrib["id"] == "NETStandard.Library" for dependency in dependencies)
    assert metadata.findtext("n:readme", namespaces=namespace) == "README.md"
    license_element = metadata.find("n:license", namespace)
    assert license_element is not None
    assert license_element.attrib.get("type") == "file"
    assert license_element.text == "LICENSE.md"

with zipfile.ZipFile(json_package) as archive:
    names = archive.namelist()
    assert "lib/netstandard2.0/UnitConverter.SystemTextJson.dll" in names
    assert "README.md" in names
    assert "LICENSE.md" in names
    assert "NOTICE" in names
    specification = ET.fromstring(
        archive.read(next(name for name in names if name.endswith(".nuspec"))))
    namespace = {"n": specification.tag.split("}")[0][1:]}
    metadata = specification.find("n:metadata", namespace)
    json_id = metadata.findtext("n:id", namespaces=namespace)
    json_version = metadata.findtext("n:version", namespaces=namespace)
    assert json_id == "UnitConverter.SystemTextJson"
    assert json_version == expected_version
    assert metadata.findtext("n:title", namespaces=namespace) == "UnitConverter.SystemTextJson"
    assert metadata.findtext("n:releaseNotes", namespaces=namespace)
    assert metadata.findtext("n:copyright", namespaces=namespace) == "Copyright © 2026 Perry3Dnl"
    dependency_ids = {
        dependency.attrib["id"]
        for dependency in metadata.findall(".//n:dependency", namespace)
    }
    assert "UnitConverter" in dependency_ids
    assert "System.Text.Json" in dependency_ids
    assert metadata.findtext("n:readme", namespaces=namespace) == "README.md"
    license_element = metadata.find("n:license", namespace)
    assert license_element is not None
    assert license_element.attrib.get("type") == "file"
    assert license_element.text == "LICENSE.md"

with zipfile.ZipFile(analyzer_package) as archive:
    names = archive.namelist()
    assert "analyzers/dotnet/cs/UnitConverter.Analyzers.dll" in names
    assert "README.md" in names
    assert "LICENSE.md" in names
    assert "NOTICE" in names
    assert not any(name.startswith("lib/") and name.endswith(".dll") for name in names)
    specification = ET.fromstring(
        archive.read(next(name for name in names if name.endswith(".nuspec"))))
    namespace = {"n": specification.tag.split("}")[0][1:]}
    metadata = specification.find("n:metadata", namespace)
    analyzer_id = metadata.findtext("n:id", namespaces=namespace)
    analyzer_version = metadata.findtext("n:version", namespaces=namespace)
    assert analyzer_id == "UnitConverter.Analyzers"
    assert analyzer_version == expected_version
    assert metadata.findtext("n:title", namespaces=namespace) == "UnitConverter.Analyzers"
    assert metadata.findtext("n:readme", namespaces=namespace) == "README.md"
    license_element = metadata.find("n:license", namespace)
    assert license_element is not None
    assert license_element.attrib.get("type") == "file"
    assert license_element.text == "LICENSE.md"

with tempfile.TemporaryDirectory(prefix="unitconverter-package-") as temporary:
    consumer = Path(temporary)
    environment = dict(os.environ)
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
    ET.SubElement(items, "PackageReference", Include=core_id, Version=core_version)
    ET.SubElement(items, "PackageReference", Include=json_id, Version=json_version)
    analyzer_reference = ET.SubElement(
        items,
        "PackageReference",
        Include=analyzer_id,
        Version=analyzer_version)
    analyzer_reference.set("PrivateAssets", "all")
    ET.ElementTree(project).write(
        consumer / "Consumer.csproj",
        encoding="utf-8",
        xml_declaration=True)

    program = r'''using System;
using System.Text.Json;
using UnitConverter;
using UnitConverter.Length;
using UnitConverter.SystemTextJson;

public static class Program
{
    public static void Main()
    {
        double meters = UnitConverterLength.Convert(
            1.8,
            UnitConverterLengthUnit.Kilometer,
            UnitConverterLengthUnit.Meter);

        if (Math.Abs(meters - 1800d) > 1e-12d)
        {
            throw new Exception("Core conversion package failed.");
        }

        var value = new UnitValue<UnitConverterLengthUnit>(
            1.8,
            UnitConverterLengthUnit.Kilometer);
        var options = new JsonSerializerOptions().AddUnitConverter();
        string json = JsonSerializer.Serialize(value, options);
        UnitValue<UnitConverterLengthUnit> restored =
            JsonSerializer.Deserialize<UnitValue<UnitConverterLengthUnit>>(json, options);

        if (!restored.Equals(value))
        {
            throw new Exception("JSON companion package failed.");
        }
    }
}
'''
    (consumer / "Program.cs").write_text(program)

    subprocess.run(
        ["dotnet", "restore", "Consumer.csproj", "--source", str(feed)],
        cwd=consumer,
        env=environment,
        check=True)

    assets = json.loads((consumer / "obj/project.assets.json").read_text())
    assert assets["libraries"][core_id + "/" + core_version]["type"] == "package"
    assert assets["libraries"][json_id + "/" + json_version]["type"] == "package"
    assert assets["libraries"][analyzer_id + "/" + analyzer_version]["type"] == "package"

    subprocess.run(
        ["dotnet", "run", "--project", "Consumer.csproj",
         "--configuration", "Release", "--no-restore"],
        cwd=consumer,
        env=environment,
        check=True)

print("Verified packages:", core_package.name, json_package.name, "and", analyzer_package.name)