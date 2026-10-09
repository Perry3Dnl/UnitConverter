using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using UnitConverter;
using UnitConverter.SystemTextJson;

internal static class Program
{
    private const string BaselineRelativePath = "docs/api/public-api-baseline.txt";

    public static int Main(string[] args)
    {
        string root = FindRepositoryRoot();
        string baselinePath = Path.Combine(root, BaselineRelativePath);
        string current = RenderSnapshot();

        if (args.Length == 1 && args[0] == "--stats")
        {
            Console.WriteLine(RenderStats());
            return 0;
        }

        if (args.Length == 1 && args[0] == "--write")
        {
            Directory.CreateDirectory(Path.GetDirectoryName(baselinePath));
            File.WriteAllText(baselinePath, current, new UTF8Encoding(false));
            Console.WriteLine("Wrote " + BaselineRelativePath);
            return 0;
        }

        if (!File.Exists(baselinePath))
        {
            Console.Error.WriteLine("Missing API baseline. Run with --write.");
            return 1;
        }

        string expected = File.ReadAllText(baselinePath);
        if (string.Equals(expected, current, StringComparison.Ordinal))
        {
            Console.WriteLine("Public API baseline is unchanged.");
            return 0;
        }

        var expectedLines = new HashSet<string>(expected.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries), StringComparer.Ordinal);
        var currentLines = new HashSet<string>(current.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries), StringComparer.Ordinal);
        Console.Error.WriteLine("Public API baseline changed.");
        foreach (string line in expectedLines.Except(currentLines).OrderBy(x => x, StringComparer.Ordinal)) Console.Error.WriteLine("- " + line);
        foreach (string line in currentLines.Except(expectedLines).OrderBy(x => x, StringComparer.Ordinal)) Console.Error.WriteLine("+ " + line);
        Console.Error.WriteLine("If intentional, regenerate with: dotnet run --project tools/UnitConverter.ApiCompat -- --write");
        return 1;
    }

    private static string RenderStats()
    {
        var families = UnitConverter.Catalog.UnitConverterCatalog.GetFamilies();
        int unitCount = 0;
        long directedPairs = 0;
        int acceptedAliasCount = 0;

        foreach (UnitConverter.Catalog.UnitConverterFamilyDescriptor family in families)
        {
            int count = family.Units.Count;
            unitCount += count;
            directedPairs += (long)count * (count - 1);

            foreach (UnitConverter.Catalog.UnitConverterUnitDescriptor unit in family.Units)
            {
                acceptedAliasCount += unit.Aliases.Length;
            }
        }

        Assembly core = typeof(UnitConverterParser).Assembly;
        Type[] exportedTypes = core.GetExportedTypes();

        int publicMethods = 0;
        int publicConstructors = 0;
        int publicProperties = 0;

        BindingFlags flags =
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.DeclaredOnly;

        foreach (Type type in exportedTypes)
        {
            publicMethods += type.GetMethods(flags).Count(method => !method.IsSpecialName);
            publicConstructors += type.GetConstructors(flags).Length;
            publicProperties += type.GetProperties(flags).Length;
        }

        var lines = new[]
        {
            "families=" + families.Length,
            "units=" + unitCount,
            "accepted_aliases=" + acceptedAliasCount,
            "directed_non_identity_pairs=" + directedPairs,
            "exported_types=" + exportedTypes.Length,
            "public_methods=" + publicMethods,
            "public_constructors=" + publicConstructors,
            "public_properties=" + publicProperties,
        };

        return string.Join(Environment.NewLine, lines);
    }

    private static string RenderSnapshot()
    {
        Assembly[] assemblies = { typeof(UnitConverterParser).Assembly, typeof(UnitConverterJson).Assembly };
        var lines = new List<string>
        {
            "# UnitConverter public API fingerprints v1",
            "# Format: assembly|type|sha256(public canonical signature set)",
        };

        foreach (Assembly assembly in assemblies.OrderBy(x => x.GetName().Name, StringComparer.Ordinal))
        {
            foreach (Type type in assembly.GetExportedTypes().OrderBy(x => x.FullName, StringComparer.Ordinal))
                lines.Add(assembly.GetName().Name + "|" + TypeName(type) + "|" + Sha256(RenderType(type)));
        }

        return string.Join(Environment.NewLine, lines) + Environment.NewLine;
    }

    private static string RenderType(Type type)
    {
        var lines = new List<string>();
        lines.Add("TYPE " + TypeName(type) + " " + TypeFlags(type));

        if (type.IsGenericTypeDefinition)
            foreach (Type arg in type.GetGenericArguments()) lines.Add("GENERIC " + arg.Name + " " + GenericConstraints(arg));

        if (type.IsEnum)
            foreach (string name in Enum.GetNames(type)) lines.Add("ENUM " + name + "=" + Convert.ToUInt64(Enum.Parse(type, name)));

        BindingFlags flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
        foreach (ConstructorInfo ctor in type.GetConstructors(flags).OrderBy(Signature, StringComparer.Ordinal)) lines.Add("CTOR " + Signature(ctor));
        foreach (MethodInfo method in type.GetMethods(flags).Where(m => !m.IsSpecialName).OrderBy(Signature, StringComparer.Ordinal)) lines.Add("METHOD " + Signature(method));
        foreach (PropertyInfo property in type.GetProperties(flags).OrderBy(p => p.Name, StringComparer.Ordinal)) lines.Add("PROPERTY " + PropertySignature(property));
        foreach (FieldInfo field in type.GetFields(flags).OrderBy(f => f.Name, StringComparer.Ordinal)) lines.Add("FIELD " + FieldSignature(field));
        foreach (EventInfo ev in type.GetEvents(flags).OrderBy(e => e.Name, StringComparer.Ordinal)) lines.Add("EVENT " + ev.Name + ":" + TypeName(ev.EventHandlerType));
        return string.Join("\n", lines);
    }

    private static string TypeFlags(Type type)
    {
        return (type.IsValueType ? "struct" : type.IsInterface ? "interface" : type.IsEnum ? "enum" : "class") +
            (type.IsSealed ? " sealed" : "") + (type.IsAbstract ? " abstract" : "");
    }

    private static string Signature(MethodBase method)
    {
        MethodInfo info = method as MethodInfo;
        string generic = "";
        if (info != null && info.IsGenericMethodDefinition)
            generic = "<" + string.Join(",", info.GetGenericArguments().Select(a => a.Name + ":" + GenericConstraints(a))) + ">";
        string parameters = string.Join(",", method.GetParameters().Select(ParameterSignature));
        string result = info == null ? "" : TypeName(info.ReturnType) + " ";
        return result + method.Name + generic + "(" + parameters + ")";
    }

    private static string ParameterSignature(ParameterInfo parameter)
    {
        string prefix = parameter.IsOut ? "out " : parameter.ParameterType.IsByRef ? "ref " : "";
        Type type = parameter.ParameterType.IsByRef ? parameter.ParameterType.GetElementType() : parameter.ParameterType;
        return prefix + TypeName(type) + " " + parameter.Name;
    }

    private static string PropertySignature(PropertyInfo property)
    {
        string accessors = (property.GetMethod != null && property.GetMethod.IsPublic ? "get;" : "") +
            (property.SetMethod != null && property.SetMethod.IsPublic ? "set;" : "");
        string indexes = string.Join(",", property.GetIndexParameters().Select(ParameterSignature));
        return TypeName(property.PropertyType) + " " + property.Name + (indexes.Length == 0 ? "" : "[" + indexes + "]") + " {" + accessors + "}";
    }

    private static string FieldSignature(FieldInfo field)
    {
        string flags = field.IsLiteral ? " const" : field.IsInitOnly ? " readonly" : "";
        string value = field.IsLiteral ? "=" + Convert.ToString(field.GetRawConstantValue(), System.Globalization.CultureInfo.InvariantCulture) : "";
        return TypeName(field.FieldType) + " " + field.Name + flags + value;
    }

    private static string GenericConstraints(Type argument)
    {
        var parts = new List<string>();
        GenericParameterAttributes attrs = argument.GenericParameterAttributes;
        if ((attrs & GenericParameterAttributes.ReferenceTypeConstraint) != 0) parts.Add("class");
        if ((attrs & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0) parts.Add("struct");
        if ((attrs & GenericParameterAttributes.DefaultConstructorConstraint) != 0) parts.Add("new()");
        parts.AddRange(argument.GetGenericParameterConstraints().Select(TypeName).OrderBy(x => x, StringComparer.Ordinal));
        return string.Join("&", parts);
    }

    private static string TypeName(Type type)
    {
        if (type == null) return "";
        if (type.IsByRef) return TypeName(type.GetElementType()) + "&";
        if (type.IsArray) return TypeName(type.GetElementType()) + "[]";
        if (type.IsGenericParameter) return type.Name;
        if (!type.IsGenericType) return type.FullName ?? type.Name;
        string name = type.GetGenericTypeDefinition().FullName;
        int tick = name.IndexOf('`');
        if (tick >= 0) name = name.Substring(0, tick);
        return name + "<" + string.Join(",", type.GetGenericArguments().Select(TypeName)) + ">";
    }

    private static string Sha256(string value)
    {
        using (SHA256 sha = SHA256.Create())
        {
            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(value));
            var builder = new StringBuilder(hash.Length * 2);
            foreach (byte b in hash) builder.Append(b.ToString("x2"));
            return builder.ToString();
        }
    }

    private static string FindRepositoryRoot()
    {
        DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
        while (directory != null)
        {
            if (File.Exists(Path.Combine(directory.FullName, "UnitConverter.sln"))) return directory.FullName;
            directory = directory.Parent;
        }
        throw new InvalidOperationException("Repository root not found.");
    }
}
