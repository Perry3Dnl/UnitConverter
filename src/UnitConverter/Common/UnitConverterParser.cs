namespace UnitConverter
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Reflection;

    /// <summary>
    /// Parses text values such as "1.8 km" into the existing UnitConverter unit enums
    /// and can route parsed values through the existing Convert methods.
    /// </summary>
    public static class UnitConverterParser
    {
        public static bool TryParse<TUnit>(string input, out double value, out TUnit unit)
            where TUnit : struct
        {
            return TryParse(input, CultureInfo.InvariantCulture, out value, out unit);
        }

        public static bool TryParse<TUnit>(string input, IFormatProvider formatProvider, out double value, out TUnit unit)
            where TUnit : struct
        {
            value = 0d;
            unit = default(TUnit);

            if (!typeof(TUnit).IsEnum || string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            string text = input.Trim();
            double parsedValue;
            string unitText;

            if (!TrySplitValueAndUnit(text, formatProvider ?? CultureInfo.InvariantCulture, out parsedValue, out unitText))
            {
                return false;
            }

            TUnit parsedUnit;
            if (!UnitMetadata<TUnit>.TryResolve(unitText, out parsedUnit))
            {
                return false;
            }

            value = parsedValue;
            unit = parsedUnit;
            return true;
        }

        public static UnitConverterParsedValue<TUnit> Parse<TUnit>(string input)
            where TUnit : struct
        {
            return Parse<TUnit>(input, CultureInfo.InvariantCulture);
        }

        public static UnitConverterParsedValue<TUnit> Parse<TUnit>(string input, IFormatProvider formatProvider)
            where TUnit : struct
        {
            double value;
            TUnit unit;

            if (!TryParse(input, formatProvider, out value, out unit))
            {
                throw new FormatException("The value could not be parsed as " + typeof(TUnit).Name + ".");
            }

            return new UnitConverterParsedValue<TUnit>(value, unit);
        }

        public static double Convert<TUnit>(string input, TUnit to)
            where TUnit : struct
        {
            return Convert(input, to, CultureInfo.InvariantCulture);
        }

        public static double Convert<TUnit>(string input, TUnit to, IFormatProvider formatProvider)
            where TUnit : struct
        {
            UnitConverterParsedValue<TUnit> parsed = Parse<TUnit>(input, formatProvider);
            return UnitMetadata<TUnit>.Convert(parsed.Value, parsed.Unit, to);
        }

        public static UnitConverterConversionResult TryConvert<TUnit>(string input, TUnit to)
            where TUnit : struct
        {
            try
            {
                return UnitConverterConversionResult.Ok(Convert(input, to));
            }
            catch (Exception exception)
            {
                return UnitConverterConversionResult.Fail(exception.Message);
            }
        }

        private static bool TrySplitValueAndUnit(
            string text,
            IFormatProvider formatProvider,
            out double value,
            out string unitText)
        {
            value = 0d;
            unitText = null;

            for (int splitIndex = text.Length - 1; splitIndex > 0; splitIndex--)
            {
                string numberPart = text.Substring(0, splitIndex).TrimEnd();
                string candidateUnit = text.Substring(splitIndex).Trim();

                if (candidateUnit.Length == 0)
                {
                    continue;
                }

                double candidateValue;
                if (double.TryParse(
                    numberPart,
                    NumberStyles.Float,
                    formatProvider,
                    out candidateValue))
                {
                    value = candidateValue;
                    unitText = candidateUnit;
                    return true;
                }
            }

            return false;
        }

        private static class UnitMetadata<TUnit>
            where TUnit : struct
        {
            private static readonly Type UnitType = typeof(TUnit);
            private static readonly Type ConverterType = FindConverterType();
            private static readonly MethodInfo GetSymbolMethod = FindMetadataMethod("GetSymbol");
            private static readonly MethodInfo GetDisplayNameMethod = FindMetadataMethod("GetDisplayName");
            private static readonly MethodInfo ConvertMethod = FindConvertMethod();

            private static readonly Dictionary<string, TUnit> ExactAliases = BuildExactAliases();
            private static readonly Dictionary<string, TUnit> IgnoreCaseAliases = BuildIgnoreCaseAliases();

            public static bool TryResolve(string text, out TUnit unit)
            {
                string candidate = text.Trim();

                if (ExactAliases.TryGetValue(candidate, out unit))
                {
                    return true;
                }

                return IgnoreCaseAliases.TryGetValue(candidate, out unit);
            }

            public static double Convert(double value, TUnit from, TUnit to)
            {
                if (ConvertMethod == null)
                {
                    throw new NotSupportedException(
                        "No compatible Convert method was found for " + UnitType.FullName + ".");
                }

                object result = ConvertMethod.Invoke(null, new object[] { value, from, to });
                return (double)result;
            }

            private static Dictionary<string, TUnit> BuildExactAliases()
            {
                var aliases = new Dictionary<string, TUnit>(StringComparer.Ordinal);

                foreach (object rawUnit in Enum.GetValues(UnitType))
                {
                    TUnit unit = (TUnit)rawUnit;
                    AddExactAlias(aliases, unit.ToString(), unit);

                    string symbol = InvokeStringMetadata(GetSymbolMethod, unit);
                    AddExactAlias(aliases, symbol, unit);

                    string displayName = InvokeStringMetadata(GetDisplayNameMethod, unit);
                    AddExactAlias(aliases, displayName, unit);
                }

                return aliases;
            }

            private static Dictionary<string, TUnit> BuildIgnoreCaseAliases()
            {
                var candidates = new Dictionary<string, TUnit>(StringComparer.OrdinalIgnoreCase);
                var ambiguous = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                foreach (object rawUnit in Enum.GetValues(UnitType))
                {
                    TUnit unit = (TUnit)rawUnit;

                    AddIgnoreCaseAlias(candidates, ambiguous, unit.ToString(), unit);

                    string displayName = InvokeStringMetadata(GetDisplayNameMethod, unit);
                    AddIgnoreCaseAlias(candidates, ambiguous, displayName, unit);
                    AddRegularPluralAlias(candidates, ambiguous, displayName, unit);

                    // Symbols are allowed as case-insensitive fallbacks only when that spelling
                    // maps to exactly one unit. This preserves distinctions such as mm vs Mm.
                    string symbol = InvokeStringMetadata(GetSymbolMethod, unit);
                    AddIgnoreCaseAlias(candidates, ambiguous, symbol, unit);
                }

                foreach (string key in ambiguous)
                {
                    candidates.Remove(key);
                }

                return candidates;
            }

            private static void AddExactAlias(Dictionary<string, TUnit> aliases, string alias, TUnit unit)
            {
                if (!string.IsNullOrWhiteSpace(alias) && !aliases.ContainsKey(alias))
                {
                    aliases.Add(alias.Trim(), unit);
                }
            }

            private static void AddIgnoreCaseAlias(
                Dictionary<string, TUnit> aliases,
                HashSet<string> ambiguous,
                string alias,
                TUnit unit)
            {
                if (string.IsNullOrWhiteSpace(alias))
                {
                    return;
                }

                string key = alias.Trim();
                TUnit existing;

                if (aliases.TryGetValue(key, out existing))
                {
                    if (!EqualityComparer<TUnit>.Default.Equals(existing, unit))
                    {
                        ambiguous.Add(key);
                    }

                    return;
                }

                aliases.Add(key, unit);
            }

            private static void AddRegularPluralAlias(
                Dictionary<string, TUnit> aliases,
                HashSet<string> ambiguous,
                string displayName,
                TUnit unit)
            {
                if (string.IsNullOrWhiteSpace(displayName))
                {
                    return;
                }

                string value = displayName.Trim();
                if (value.EndsWith("s", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                AddIgnoreCaseAlias(aliases, ambiguous, value + "s", unit);
            }

            private static string InvokeStringMetadata(MethodInfo method, TUnit unit)
            {
                if (method == null)
                {
                    return null;
                }

                return method.Invoke(null, new object[] { unit }) as string;
            }

            private static Type FindConverterType()
            {
                string unitTypeName = UnitType.Name;
                const string prefix = "UnitConverter";
                const string suffix = "Unit";

                if (!unitTypeName.StartsWith(prefix, StringComparison.Ordinal) ||
                    !unitTypeName.EndsWith(suffix, StringComparison.Ordinal))
                {
                    return null;
                }

                string familyName = unitTypeName.Substring(
                    prefix.Length,
                    unitTypeName.Length - prefix.Length - suffix.Length);

                string converterTypeName = UnitType.Namespace + ".UnitConverter" + familyName;
                return UnitType.Assembly.GetType(converterTypeName, false);
            }

            private static MethodInfo FindMetadataMethod(string methodName)
            {
                if (ConverterType == null)
                {
                    return null;
                }

                return ConverterType.GetMethod(
                    methodName,
                    BindingFlags.Public | BindingFlags.Static,
                    null,
                    new[] { UnitType },
                    null);
            }

            private static MethodInfo FindConvertMethod()
            {
                if (ConverterType == null)
                {
                    return null;
                }

                return ConverterType.GetMethod(
                    "Convert",
                    BindingFlags.Public | BindingFlags.Static,
                    null,
                    new[] { typeof(double), UnitType, UnitType },
                    null);
            }
        }
    }

    /// <summary>
    /// A parsed numeric value together with the unit that was present in the source text.
    /// </summary>
    public readonly struct UnitConverterParsedValue<TUnit>
        where TUnit : struct
    {
        public UnitConverterParsedValue(double value, TUnit unit)
        {
            Value = value;
            Unit = unit;
        }

        public double Value { get; }

        public TUnit Unit { get; }

        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture) + " " + Unit;
        }
    }
}
