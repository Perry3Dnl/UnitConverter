namespace UnitConverter.ApiSurface
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Loader;
    using System.Text;

    internal static class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.Error.WriteLine("Usage: UnitConverter.ApiSurface <output> <label=assembly> [...]");
                return 2;
            }

            string output = Path.GetFullPath(args[0]);
            var sections = new List<string>();

            for (int index = 1; index < args.Length; index++)
            {
                int separator = args[index].IndexOf('=');
                if (separator <= 0 || separator == args[index].Length - 1)
                {
                    Console.Error.WriteLine("Expected label=assembly: " + args[index]);
                    return 2;
                }

                string label = args[index].Substring(0, separator);
                string assemblyPath = Path.GetFullPath(args[index].Substring(separator + 1));
                sections.Add(RenderAssembly(label, assemblyPath));
            }

            string text = string.Join(Environment.NewLine, sections) + Environment.NewLine;
            Directory.CreateDirectory(Path.GetDirectoryName(output));

            if (File.Exists(output) &&
                string.Equals(File.ReadAllText(output), text, StringComparison.Ordinal))
            {
                Console.WriteLine("Public API baseline is current: " + output);
                return 0;
            }

            if (string.Equals(
                Environment.GetEnvironmentVariable("UNITCONVERTER_API_CHECK"),
                "1",
                StringComparison.Ordinal))
            {
                Console.Error.WriteLine("Public API surface changed.");
                Console.Error.WriteLine("Regenerate intentionally with: python scripts/generate_public_api.py");
                return 1;
            }

            File.WriteAllText(output, text);
            Console.WriteLine("Wrote public API baseline: " + output);
            return 0;
        }

        private static string RenderAssembly(string label, string assemblyPath)
        {
            var context = new SnapshotLoadContext(assemblyPath);
            try
            {
                Assembly assembly = context.LoadFromAssemblyPath(assemblyPath);
                var lines = new List<string>
                {
                    "# " + label,
                    "Assembly: " + assembly.GetName().Name,
                };

                foreach (Type type in assembly.GetExportedTypes()
                    .OrderBy(TypeName, StringComparer.Ordinal))
                {
                    lines.Add(RenderType(type));

                    if (type.IsEnum)
                    {
                        foreach (string name in Enum.GetNames(type))
                        {
                            object raw = Enum.Parse(type, name);
                            lines.Add("  enum " + name + " = " +
                                Convert.ToString(raw, CultureInfo.InvariantCulture));
                        }
                        continue;
                    }

                    const BindingFlags flags =
                        BindingFlags.Public |
                        BindingFlags.Instance |
                        BindingFlags.Static |
                        BindingFlags.DeclaredOnly;

                    foreach (ConstructorInfo ctor in type.GetConstructors(flags)
                        .OrderBy(RenderConstructor, StringComparer.Ordinal))
                    {
                        lines.Add("  " + RenderConstructor(ctor));
                    }

                    foreach (PropertyInfo property in type.GetProperties(flags)
                        .OrderBy(RenderProperty, StringComparer.Ordinal))
                    {
                        lines.Add("  " + RenderProperty(property));
                    }

                    foreach (FieldInfo field in type.GetFields(flags)
                        .Where(field => !field.IsSpecialName)
                        .OrderBy(RenderField, StringComparer.Ordinal))
                    {
                        lines.Add("  " + RenderField(field));
                    }

                    foreach (MethodInfo method in type.GetMethods(flags)
                        .Where(method => !method.IsSpecialName)
                        .OrderBy(RenderMethod, StringComparer.Ordinal))
                    {
                        lines.Add("  " + RenderMethod(method));
                    }
                }

                return string.Join(Environment.NewLine, lines);
            }
            finally
            {
                context.Unload();
            }
        }

        private static string RenderType(Type type)
        {
            string kind = type.IsEnum ? "enum" :
                type.IsValueType ? "struct" :
                type.IsInterface ? "interface" :
                type.IsClass ? "class" : "type";

            var builder = new StringBuilder();
            builder.Append(kind).Append(' ').Append(TypeName(type));

            Type baseType = type.BaseType;
            bool hasBase =
                baseType != null &&
                baseType != typeof(object) &&
                baseType != typeof(ValueType) &&
                baseType != typeof(Enum);

            if (hasBase)
            {
                builder.Append(" : ").Append(TypeName(baseType));
            }

            Type[] interfaces = type.GetInterfaces()
                .Where(i => i.IsPublic || i.IsNestedPublic)
                .OrderBy(TypeName, StringComparer.Ordinal)
                .ToArray();

            if (interfaces.Length > 0)
            {
                builder.Append(hasBase ? ", " : " : ");
                builder.Append(string.Join(", ", interfaces.Select(TypeName)));
            }

            if (type.IsGenericTypeDefinition)
            {
                AppendGenericConstraints(builder, type.GetGenericArguments());
            }

            return builder.ToString();
        }

        private static string RenderConstructor(ConstructorInfo ctor)
        {
            return "ctor(" + string.Join(", ", ctor.GetParameters().Select(RenderParameter)) + ")";
        }

        private static string RenderProperty(PropertyInfo property)
        {
            string access = (property.GetMethod != null ? "get;" : "") +
                (property.SetMethod != null ? " set;" : "");
            return "property " + TypeName(property.PropertyType) + " " +
                property.Name + " { " + access.Trim() + " }";
        }

        private static string RenderField(FieldInfo field)
        {
            string modifier = field.IsLiteral ? "const " :
                field.IsInitOnly ? "readonly " : "";
            return "field " + modifier + TypeName(field.FieldType) + " " + field.Name;
        }

        private static string RenderMethod(MethodInfo method)
        {
            var builder = new StringBuilder();
            builder.Append("method ");
            if (method.IsStatic)
            {
                builder.Append("static ");
            }

            builder.Append(TypeName(method.ReturnType))
                .Append(' ')
                .Append(method.Name);

            if (method.IsGenericMethodDefinition)
            {
                Type[] arguments = method.GetGenericArguments();
                builder.Append('<')
                    .Append(string.Join(", ", arguments.Select(a => a.Name)))
                    .Append('>');
                AppendGenericConstraints(builder, arguments);
            }

            builder.Append('(')
                .Append(string.Join(", ", method.GetParameters().Select(RenderParameter)))
                .Append(')');
            return builder.ToString();
        }

        private static void AppendGenericConstraints(
            StringBuilder builder,
            IEnumerable<Type> arguments)
        {
            foreach (Type argument in arguments)
            {
                string constraints = RenderGenericConstraints(argument);
                if (constraints.Length > 0)
                {
                    builder.Append(" where ")
                        .Append(argument.Name)
                        .Append(" : ")
                        .Append(constraints);
                }
            }
        }

        private static string RenderParameter(ParameterInfo parameter)
        {
            string modifier = parameter.IsOut ? "out " :
                parameter.ParameterType.IsByRef ? "ref " : "";
            Type type = parameter.ParameterType.IsByRef
                ? parameter.ParameterType.GetElementType()
                : parameter.ParameterType;

            string result = modifier + TypeName(type) + " " + parameter.Name;
            if (parameter.HasDefaultValue)
            {
                result += " = " + FormatDefault(parameter.DefaultValue);
            }
            return result;
        }

        private static string FormatDefault(object value)
        {
            if (value == null)
            {
                return "null";
            }
            if (value is string)
            {
                return "string:" +
                    Convert.ToBase64String(
                        Encoding.UTF8.GetBytes((string)value));
            }
            if (value is char)
            {
                return "char:" + ((int)(char)value).ToString(CultureInfo.InvariantCulture);
            }
            if (value is bool)
            {
                return (bool)value ? "true" : "false";
            }
            if (value.GetType().IsEnum)
            {
                return TypeName(value.GetType()) + "." + value;
            }
            return Convert.ToString(value, CultureInfo.InvariantCulture);
        }

        private static string RenderGenericConstraints(Type argument)
        {
            var constraints = new List<string>();
            GenericParameterAttributes attributes = argument.GenericParameterAttributes;
            GenericParameterAttributes special =
                attributes & GenericParameterAttributes.SpecialConstraintMask;

            if ((special & GenericParameterAttributes.ReferenceTypeConstraint) != 0)
            {
                constraints.Add("class");
            }
            if ((special & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0)
            {
                constraints.Add("struct");
            }

            constraints.AddRange(
                argument.GetGenericParameterConstraints()
                    .Where(type => type != typeof(ValueType))
                    .Select(TypeName)
                    .OrderBy(name => name, StringComparer.Ordinal));

            if ((special & GenericParameterAttributes.DefaultConstructorConstraint) != 0 &&
                (special & GenericParameterAttributes.NotNullableValueTypeConstraint) == 0)
            {
                constraints.Add("new()");
            }

            return string.Join(", ", constraints);
        }

        private static string TypeName(Type type)
        {
            if (type == null)
            {
                return "<null>";
            }
            if (type.IsByRef)
            {
                return TypeName(type.GetElementType()) + "&";
            }
            if (type.IsArray)
            {
                return TypeName(type.GetElementType()) + "[]";
            }
            if (type.IsGenericParameter)
            {
                return type.Name;
            }
            if (!type.IsGenericType)
            {
                return type.FullName ?? type.Name;
            }

            string name = type.GetGenericTypeDefinition().FullName;
            int tick = name.IndexOf((char)96);
            if (tick >= 0)
            {
                name = name.Substring(0, tick);
            }

            return name + "<" +
                string.Join(", ", type.GetGenericArguments().Select(TypeName)) + ">";
        }

        private sealed class SnapshotLoadContext : AssemblyLoadContext
        {
            private readonly string _directory;

            public SnapshotLoadContext(string assemblyPath)
                : base(isCollectible: true)
            {
                _directory = Path.GetDirectoryName(assemblyPath);
            }

            protected override Assembly Load(AssemblyName assemblyName)
            {
                string candidate = Path.Combine(_directory, assemblyName.Name + ".dll");
                return File.Exists(candidate)
                    ? LoadFromAssemblyPath(candidate)
                    : null;
            }
        }
    }
}
