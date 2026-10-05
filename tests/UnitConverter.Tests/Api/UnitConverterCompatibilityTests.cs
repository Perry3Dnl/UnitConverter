namespace UnitConverter.Tests
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text.Json;
    using NUnit.Framework;
    using UnitConverter.Length;

    public sealed class UnitConverterCompatibilityTests
    {
        [Test]
        public void PreviewOneEnumIdsAndPublicMethodSignaturesRemainAvailable()
        {
            var assembly = typeof(UnitConverterLength).Assembly;
            using (var baseline = JsonDocument.Parse(File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "legacy-api.json"))))
            {
                foreach (var family in baseline.RootElement.GetProperty("families").EnumerateArray())
                {
                    string name = family.GetProperty("name").GetString();
                    var type = assembly.GetType("UnitConverter." + name + ".UnitConverter" + name + "Unit", true);
                    foreach (var unit in family.GetProperty("units").EnumerateArray())
                        Assert.AreEqual(unit.GetProperty("id").GetInt32(), Convert.ToInt32(Enum.Parse(type, unit.GetProperty("name").GetString())), name);
                }
                foreach (var signature in baseline.RootElement.GetProperty("signatures").EnumerateArray())
                {
                    var type = assembly.GetType(signature[0].GetString(), true);
                    string methodName = signature[2].GetString();
                    var args = signature[3].GetString().Split(',').Where(x => x.Trim().Length > 0)
                        .Select(x => x.Trim().Replace("this ", "").Replace("out ", "").Split(' ')[0]).ToArray();
                    var candidates = type.GetMethods(BindingFlags.Public | BindingFlags.Static).Where(m => m.Name == methodName);
                    Assert.IsTrue(candidates.Any(m => m.GetParameters().Select(p => ShortName(p.ParameterType)).SequenceEqual(args)
                        && ShortName(m.ReturnType) == signature[1].GetString()), signature.ToString());
                }
            }
        }

        private static string ShortName(Type type)
        {
            if (type.IsByRef) return ShortName(type.GetElementType());
            if (type.IsArray) return ShortName(type.GetElementType()) + "[]";
            switch (type.FullName)
            {
                case "System.Double": return "double"; case "System.Single": return "float";
                case "System.Decimal": return "decimal"; case "System.String": return "string";
                case "System.Boolean": return "bool"; case "System.Byte": return "byte";
                case "System.SByte": return "sbyte"; case "System.Int16": return "short";
                case "System.UInt16": return "ushort"; case "System.Int32": return "int";
                case "System.UInt32": return "uint"; case "System.Int64": return "long";
                case "System.UInt64": return "ulong"; default: return type.Name;
            }
        }
    }
}
