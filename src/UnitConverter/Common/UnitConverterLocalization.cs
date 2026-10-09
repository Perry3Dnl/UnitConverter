namespace UnitConverter
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using UnitConverter.Catalog;
    using UnitConverter.Length;
    using UnitConverter.Temperature;

    /// <summary>
    /// Optional culture-aware unit names and parsing aliases.
    /// Symbols and enum names remain invariant; localization only affects display names
    /// and aliases resolved with an explicit format provider.
    /// </summary>
    public static class UnitConverterLocalization
    {
        private static readonly object Sync = new object();
        private static readonly Dictionary<Type, Dictionary<string, CultureTable>> Tables =
            new Dictionary<Type, Dictionary<string, CultureTable>>();

        static UnitConverterLocalization()
        {
            Register(
                CultureInfo.GetCultureInfo("nl"),
                UnitConverterLengthUnit.Meter,
                "meter",
                "meter", "meters");
            Register(
                CultureInfo.GetCultureInfo("nl"),
                UnitConverterLengthUnit.Kilometer,
                "kilometer",
                "kilometer", "kilometers");
            Register(
                CultureInfo.GetCultureInfo("nl"),
                UnitConverterLengthUnit.Centimeter,
                "centimeter",
                "centimeter", "centimeters");
            Register(
                CultureInfo.GetCultureInfo("nl"),
                UnitConverterLengthUnit.Millimeter,
                "millimeter",
                "millimeter", "millimeters");
            Register(
                CultureInfo.GetCultureInfo("nl"),
                UnitConverterLengthUnit.Mile,
                "mijl",
                "mijl", "mijlen");
            Register(
                CultureInfo.GetCultureInfo("nl"),
                UnitConverterLengthUnit.Foot,
                "voet",
                "voet", "voeten");
            Register(
                CultureInfo.GetCultureInfo("nl"),
                UnitConverterTemperatureUnit.Celsius,
                "graad Celsius",
                "graad Celsius", "graden Celsius");
            Register(
                CultureInfo.GetCultureInfo("nl"),
                UnitConverterTemperatureUnit.Fahrenheit,
                "graad Fahrenheit",
                "graad Fahrenheit", "graden Fahrenheit");
            Register(
                CultureInfo.GetCultureInfo("nl"),
                UnitConverterTemperatureUnit.Kelvin,
                "kelvin",
                "kelvin");
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

            UnitConverterFamilyDescriptor<TUnit> family;
            if (!UnitConverterCatalog.TryGetFamily(out family) || !family.TryGetUnit(unit, out _))
            {
                throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported unit.");
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

        public static UnitConverterUnitResolution ResolveUnit<TUnit>(
            string text,
            IFormatProvider formatProvider,
            out TUnit unit)
            where TUnit : struct
        {
            unit = default(TUnit);
            if (string.IsNullOrWhiteSpace(text))
            {
                return UnitConverterUnitResolution.Unknown;
            }

            CultureInfo culture = GetCulture(formatProvider);
            lock (Sync)
            {
                return ResolveUnitLocked(text.Trim(), culture, out unit);
            }
        }

        private static UnitConverterUnitResolution ResolveUnitLocked<TUnit>(
            string text,
            CultureInfo culture,
            out TUnit unit)
            where TUnit : struct
        {
            unit = default(TUnit);
            Dictionary<string, CultureTable> byCulture;
            if (!Tables.TryGetValue(typeof(TUnit), out byCulture))
            {
                return UnitConverterUnitResolution.Unknown;
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
                    return UnitConverterUnitResolution.Ambiguous;
                }

                object resolved;
                if (table.Aliases.TryGetValue(text, out resolved))
                {
                    unit = (TUnit)resolved;
                    return UnitConverterUnitResolution.Resolved;
                }
            }

            return UnitConverterUnitResolution.Unknown;
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
