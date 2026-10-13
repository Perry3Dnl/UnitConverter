namespace UnitTools
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using UnitTools.Catalog;

    /// <summary>
    /// Optional culture-aware unit names and parsing aliases.
    /// Symbols and enum names remain invariant; localization only affects display names
    /// and aliases resolved with an explicit format provider.
    /// </summary>
    public static class UnitToolsLocalization
    {
        private static readonly object Sync = new object();
        private static readonly Dictionary<Type, Dictionary<string, CultureTable>> Tables =
            new Dictionary<Type, Dictionary<string, CultureTable>>();

        static UnitToolsLocalization()
        {
            UnitToolsBuiltInLocalization.RegisterAll();
        }

        public static void Register<TUnit>(
            CultureInfo culture,
            TUnit unit,
            string displayName,
            params string[] aliases)
            where TUnit : struct
        {
            if (culture == null)
            {
                throw new ArgumentNullException(nameof(culture));
            }

            if (!typeof(TUnit).IsEnum)
            {
                throw new ArgumentException("TUnit must be a unit enum.", nameof(unit));
            }

            UnitToolsFamilyDescriptor<TUnit> family;
            if (!UnitToolsCatalog.TryGetFamily(out family) || !family.TryGetUnit(unit, out _))
            {
                throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported unit.");
            }

            ValidateAgainstInvariantCatalog(family, unit, displayName);
            if (aliases != null)
            {
                for (int index = 0; index < aliases.Length; index++)
                {
                    ValidateAgainstInvariantCatalog(family, unit, aliases[index]);
                }
            }

            string cultureName = NormalizeCultureName(culture);
            lock (Sync)
            {
                Dictionary<string, CultureTable> byCulture;
                if (!Tables.TryGetValue(typeof(TUnit), out byCulture))
                {
                    byCulture = new Dictionary<string, CultureTable>(StringComparer.OrdinalIgnoreCase);
                    Tables.Add(typeof(TUnit), byCulture);
                }

                CultureTable table;
                if (!byCulture.TryGetValue(cultureName, out table))
                {
                    table = new CultureTable();
                    byCulture.Add(cultureName, table);
                }

                table.DisplayNames[unit] = displayName;

                if (aliases != null)
                {
                    for (int index = 0; index < aliases.Length; index++)
                    {
                        AddAlias(table, aliases[index], unit);
                    }
                }

                if (!string.IsNullOrWhiteSpace(displayName))
                {
                    AddAlias(table, displayName, unit);
                }
            }
        }

        public static bool TryGetDisplayName<TUnit>(
            TUnit unit,
            IFormatProvider formatProvider,
            out string displayName)
            where TUnit : struct
        {
            CultureInfo culture = GetCulture(formatProvider);
            lock (Sync)
            {
                return TryGetDisplayName(typeof(TUnit), unit, culture, out displayName);
            }
        }

        public static CultureInfo[] GetSupportedCultures<TUnit>()
            where TUnit : struct
        {
            lock (Sync)
            {
                Dictionary<string, CultureTable> byCulture;
                if (!Tables.TryGetValue(typeof(TUnit), out byCulture))
                {
                    return new CultureInfo[0];
                }

                var result = new List<CultureInfo>();
                foreach (string name in byCulture.Keys)
                {
                    result.Add(string.IsNullOrEmpty(name)
                        ? CultureInfo.InvariantCulture
                        : CultureInfo.GetCultureInfo(name));
                }

                result.Sort((left, right) =>
                    StringComparer.OrdinalIgnoreCase.Compare(left.Name, right.Name));
                return result.ToArray();
            }
        }

        public static string GetDisplayName<TUnit>(
            TUnit unit,
            IFormatProvider formatProvider,
            string fallback)
            where TUnit : struct
        {
            CultureInfo culture = GetCulture(formatProvider);
            lock (Sync)
            {
                string value;
                if (TryGetDisplayName(typeof(TUnit), unit, culture, out value))
                {
                    return value;
                }
            }

            return fallback;
        }

        public static UnitToolsUnitResolution ResolveUnit<TUnit>(
            string text,
            IFormatProvider formatProvider,
            out TUnit unit)
            where TUnit : struct
        {
            unit = default(TUnit);
            if (string.IsNullOrWhiteSpace(text))
            {
                return UnitToolsUnitResolution.Unknown;
            }

            CultureInfo culture = GetCulture(formatProvider);
            lock (Sync)
            {
                return ResolveUnitLocked(text.Trim(), culture, out unit);
            }
        }

        internal static UnitToolsUnitResolution ResolveUnit(
            Type unitType,
            string text,
            IFormatProvider formatProvider,
            out object unit)
        {
            unit = null;
            if (unitType == null || string.IsNullOrWhiteSpace(text))
            {
                return UnitToolsUnitResolution.Unknown;
            }

            CultureInfo culture = GetCulture(formatProvider);
            lock (Sync)
            {
                Dictionary<string, CultureTable> byCulture;
                if (!Tables.TryGetValue(unitType, out byCulture))
                {
                    return UnitToolsUnitResolution.Unknown;
                }

                string candidate = text.Trim();
                foreach (string cultureName in EnumerateCultureFallbacks(culture))
                {
                    CultureTable table;
                    if (!byCulture.TryGetValue(cultureName, out table))
                    {
                        continue;
                    }

                    if (table.AmbiguousAliases.Contains(candidate))
                    {
                        return UnitToolsUnitResolution.Ambiguous;
                    }

                    if (table.Aliases.TryGetValue(candidate, out unit))
                    {
                        return UnitToolsUnitResolution.Resolved;
                    }
                }
            }

            return UnitToolsUnitResolution.Unknown;
        }

        private static UnitToolsUnitResolution ResolveUnitLocked<TUnit>(
            string text,
            CultureInfo culture,
            out TUnit unit)
            where TUnit : struct
        {
            unit = default(TUnit);
            Dictionary<string, CultureTable> byCulture;
            if (!Tables.TryGetValue(typeof(TUnit), out byCulture))
            {
                return UnitToolsUnitResolution.Unknown;
            }

            foreach (string cultureName in EnumerateCultureFallbacks(culture))
            {
                CultureTable table;
                if (!byCulture.TryGetValue(cultureName, out table))
                {
                    continue;
                }

                if (table.AmbiguousAliases.Contains(text))
                {
                    return UnitToolsUnitResolution.Ambiguous;
                }

                object resolved;
                if (table.Aliases.TryGetValue(text, out resolved))
                {
                    unit = (TUnit)resolved;
                    return UnitToolsUnitResolution.Resolved;
                }
            }

            return UnitToolsUnitResolution.Unknown;
        }

        private static bool TryGetDisplayName(
            Type unitType,
            object unit,
            CultureInfo culture,
            out string displayName)
        {
            displayName = null;
            Dictionary<string, CultureTable> byCulture;
            if (!Tables.TryGetValue(unitType, out byCulture))
            {
                return false;
            }

            foreach (string cultureName in EnumerateCultureFallbacks(culture))
            {
                CultureTable table;
                if (byCulture.TryGetValue(cultureName, out table) &&
                    table.DisplayNames.TryGetValue(unit, out displayName))
                {
                    return true;
                }
            }

            return false;
        }

        private static IEnumerable<string> EnumerateCultureFallbacks(CultureInfo culture)
        {
            CultureInfo current = culture ?? CultureInfo.InvariantCulture;
            while (current != null && !string.IsNullOrEmpty(current.Name))
            {
                yield return current.Name;
                current = current.Parent;
            }

            yield return string.Empty;
        }

        private static CultureInfo GetCulture(IFormatProvider formatProvider)
        {
            return formatProvider as CultureInfo ??
                (formatProvider == null
                    ? CultureInfo.InvariantCulture
                    : formatProvider.GetFormat(typeof(CultureInfo)) as CultureInfo) ??
                CultureInfo.InvariantCulture;
        }

        private static string NormalizeCultureName(CultureInfo culture)
        {
            return culture == CultureInfo.InvariantCulture ? string.Empty : culture.Name;
        }

        private static void ValidateAgainstInvariantCatalog<TUnit>(
            UnitToolsFamilyDescriptor<TUnit> family,
            TUnit unit,
            string alias)
            where TUnit : struct
        {
            if (string.IsNullOrWhiteSpace(alias))
            {
                return;
            }

            TUnit builtIn;
            UnitToolsUnitResolution resolution =
                family.ResolveUnit(alias, out builtIn);

            if (resolution == UnitToolsUnitResolution.Unknown)
            {
                return;
            }

            if (resolution == UnitToolsUnitResolution.Resolved &&
                EqualityComparer<TUnit>.Default.Equals(builtIn, unit))
            {
                return;
            }

            throw new InvalidOperationException(
                "The localized alias '" + alias.Trim() +
                "' conflicts with an invariant unit alias in " +
                family.Name + ".");
        }

        private static void AddAlias<TUnit>(CultureTable table, string alias, TUnit unit)
            where TUnit : struct
        {
            if (string.IsNullOrWhiteSpace(alias))
            {
                return;
            }

            string normalized = alias.Trim();
            if (table.AmbiguousAliases.Contains(normalized))
            {
                return;
            }

            object existing;
            if (table.Aliases.TryGetValue(normalized, out existing))
            {
                if (!EqualityComparer<TUnit>.Default.Equals((TUnit)existing, unit))
                {
                    table.Aliases.Remove(normalized);
                    table.AmbiguousAliases.Add(normalized);
                }

                return;
            }

            table.Aliases.Add(normalized, unit);
        }

        private sealed class CultureTable
        {
            public CultureTable()
            {
                DisplayNames = new Dictionary<object, string>();
                Aliases = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
                AmbiguousAliases = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            }

            public Dictionary<object, string> DisplayNames { get; }
            public Dictionary<string, object> Aliases { get; }
            public HashSet<string> AmbiguousAliases { get; }
        }
    }
}