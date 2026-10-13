namespace UnitTools
{
    using System;
    using System.Collections.Generic;
    using UnitTools.Catalog;

    public sealed class UnitToolsCustomUnit
    {
        internal UnitToolsCustomUnit(
            UnitToolsFamilyDescriptor family,
            string name,
            string symbol,
            string displayName,
            string[] aliases,
            object referenceUnit,
            UnitToolsDimensions dimensions,
            double scaleToReference,
            double offsetToReference)
        {
            Family = family ?? throw new ArgumentNullException(nameof(family));
            Name = name;
            Symbol = symbol;
            DisplayName = displayName;
            string[] aliasSnapshot =
                aliases == null
                    ? new string[0]
                    : (string[])aliases.Clone();
            Aliases = Array.AsReadOnly(aliasSnapshot);
            ReferenceUnit = referenceUnit;
            Dimensions = dimensions;
            ScaleToReference = scaleToReference;
            OffsetToReference = offsetToReference;
        }

        public UnitToolsFamilyDescriptor Family { get; }
        public string Name { get; }
        public string Symbol { get; }
        public string DisplayName { get; }
        public IReadOnlyList<string> Aliases { get; }
        public UnitToolsDimensions Dimensions { get; }
        public double ScaleToReference { get; }
        public double OffsetToReference { get; }
        internal object ReferenceUnit { get; }

        public double ToReference(double value)
        {
            return (value * ScaleToReference) + OffsetToReference;
        }

        public double FromReference(double value)
        {
            return (value - OffsetToReference) / ScaleToReference;
        }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(Symbol) ? Name : Symbol;
        }
    }

    public static class UnitToolsCustomUnits
    {
        private static readonly object Sync = new object();
        private static readonly Dictionary<UnitToolsFamily, List<UnitToolsCustomUnit>> UnitsByFamily =
            new Dictionary<UnitToolsFamily, List<UnitToolsCustomUnit>>();
        private static volatile int UnitCount;

        internal static bool HasUnits => UnitCount != 0;

        public static UnitToolsCustomUnit RegisterLinear(
            UnitToolsFamily family,
            string name,
            string symbol,
            string referenceUnit,
            double scaleToReference,
            params string[] aliases)
        {
            return RegisterAffine(
                family,
                name,
                symbol,
                name,
                referenceUnit,
                scaleToReference,
                0d,
                aliases);
        }

        public static UnitToolsCustomUnit RegisterAffine(
            UnitToolsFamily family,
            string name,
            string symbol,
            string displayName,
            string referenceUnit,
            double scaleToReference,
            double offsetToReference,
            params string[] aliases)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("A custom unit name is required.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(referenceUnit))
            {
                throw new ArgumentException("A reference unit is required.", nameof(referenceUnit));
            }

            if (double.IsNaN(scaleToReference) ||
                double.IsInfinity(scaleToReference) ||
                scaleToReference == 0d)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(scaleToReference),
                    scaleToReference,
                    "The scale must be finite and non-zero.");
            }

            if (double.IsNaN(offsetToReference) ||
                double.IsInfinity(offsetToReference))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(offsetToReference),
                    offsetToReference,
                    "The offset must be finite.");
            }

            UnitToolsFamilyDescriptor descriptor =
                UnitToolsCatalog.GetFamily(family);

            object reference;
            UnitToolsUnitResolution referenceResolution =
                descriptor.ResolveUnit(referenceUnit, out reference);

            if (referenceResolution != UnitToolsUnitResolution.Resolved)
            {
                throw new ArgumentException(
                    "The reference unit '" + referenceUnit +
                    "' is not a unique built-in unit in " + descriptor.Name + ".",
                    nameof(referenceUnit));
            }

            UnitToolsUnitDescriptor referenceDescriptor =
                FindUnitDescriptor(descriptor, reference);

            if (referenceDescriptor == null)
            {
                throw new InvalidOperationException(
                    "The reference unit descriptor could not be found.");
            }

            string[] acceptedAliases = BuildAliases(
                name,
                symbol,
                displayName,
                aliases);

            lock (Sync)
            {
                foreach (string alias in acceptedAliases)
                {
                    EnsureAliasAvailable(descriptor, family, alias);
                }

                var custom = new UnitToolsCustomUnit(
                    descriptor,
                    name.Trim(),
                    string.IsNullOrWhiteSpace(symbol) ? null : symbol.Trim(),
                    string.IsNullOrWhiteSpace(displayName) ? name.Trim() : displayName.Trim(),
                    acceptedAliases,
                    reference,
                    referenceDescriptor.Dimensions,
                    scaleToReference,
                    offsetToReference);

                List<UnitToolsCustomUnit> list;
                if (!UnitsByFamily.TryGetValue(family, out list))
                {
                    list = new List<UnitToolsCustomUnit>();
                    UnitsByFamily.Add(family, list);
                }

                list.Add(custom);
                UnitCount++;
                return custom;
            }
        }

        public static bool Unregister(UnitToolsCustomUnit unit)
        {
            if (unit == null)
            {
                return false;
            }

            lock (Sync)
            {
                List<UnitToolsCustomUnit> list;
                if (!UnitsByFamily.TryGetValue(unit.Family.Family, out list) ||
                    !list.Remove(unit))
                {
                    return false;
                }

                UnitCount--;
                if (list.Count == 0)
                {
                    UnitsByFamily.Remove(unit.Family.Family);
                }

                return true;
            }
        }

        public static void Clear()
        {
            lock (Sync)
            {
                UnitsByFamily.Clear();
                UnitCount = 0;
            }
        }

        public static IReadOnlyList<UnitToolsCustomUnit> GetUnits()
        {
            lock (Sync)
            {
                var result = new List<UnitToolsCustomUnit>();

                foreach (List<UnitToolsCustomUnit> units in UnitsByFamily.Values)
                {
                    result.AddRange(units);
                }

                return result.ToArray();
            }
        }

        public static IReadOnlyList<UnitToolsCustomUnit> GetUnits(
            UnitToolsFamily family)
        {
            lock (Sync)
            {
                List<UnitToolsCustomUnit> units;
                return UnitsByFamily.TryGetValue(family, out units)
                    ? units.ToArray()
                    : new UnitToolsCustomUnit[0];
            }
        }

        internal static void AppendMatchingCandidates(
            string text,
            StringComparison comparison,
            List<UnitToolsUnitCandidate> matches)
        {
            if (matches == null)
            {
                throw new ArgumentNullException(nameof(matches));
            }

            lock (Sync)
            {
                foreach (List<UnitToolsCustomUnit> units in UnitsByFamily.Values)
                {
                    foreach (UnitToolsCustomUnit custom in units)
                    {
                        foreach (string alias in custom.Aliases)
                        {
                            if (string.Equals(alias, text, comparison))
                            {
                                matches.Add(new UnitToolsUnitCandidate(custom));
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static bool TryResolve(
            UnitToolsFamily family,
            string text,
            out UnitToolsCustomUnit unit)
        {
            return Resolve(family, text, out unit) ==
                UnitToolsUnitResolution.Resolved;
        }

        public static UnitToolsUnitResolution Resolve(
            UnitToolsFamily family,
            string text,
            out UnitToolsCustomUnit unit)
        {
            unit = null;

            if (string.IsNullOrWhiteSpace(text))
            {
                return UnitToolsUnitResolution.Unknown;
            }

            UnitToolsCustomUnit exact = null;
            UnitToolsCustomUnit insensitive = null;
            bool exactAmbiguous = false;
            bool insensitiveAmbiguous = false;
            string candidate = text.Trim();

            lock (Sync)
            {
                List<UnitToolsCustomUnit> units;
                if (!UnitsByFamily.TryGetValue(family, out units))
                {
                    return UnitToolsUnitResolution.Unknown;
                }

                foreach (UnitToolsCustomUnit custom in units)
                {
                    foreach (string alias in custom.Aliases)
                    {
                        if (string.Equals(alias, candidate, StringComparison.Ordinal))
                        {
                            if (exact != null && !object.ReferenceEquals(exact, custom))
                            {
                                exactAmbiguous = true;
                            }
                            else
                            {
                                exact = custom;
                            }
                        }

                        if (string.Equals(alias, candidate, StringComparison.OrdinalIgnoreCase))
                        {
                            if (insensitive != null && !object.ReferenceEquals(insensitive, custom))
                            {
                                insensitiveAmbiguous = true;
                            }
                            else
                            {
                                insensitive = custom;
                            }
                        }
                    }
                }
            }

            if (exactAmbiguous)
            {
                return UnitToolsUnitResolution.Ambiguous;
            }

            if (exact != null)
            {
                unit = exact;
                return UnitToolsUnitResolution.Resolved;
            }

            if (insensitiveAmbiguous)
            {
                return UnitToolsUnitResolution.Ambiguous;
            }

            if (insensitive != null)
            {
                unit = insensitive;
                return UnitToolsUnitResolution.Resolved;
            }

            return UnitToolsUnitResolution.Unknown;
        }

        public static double Convert(
            double value,
            UnitToolsCustomUnit from,
            UnitToolsCustomUnit to)
        {
            if (from == null)
            {
                throw new ArgumentNullException(nameof(from));
            }

            if (to == null)
            {
                throw new ArgumentNullException(nameof(to));
            }

            EnsureSameFamily(from.Family, to.Family);

            double referenceValue = from.ToReference(value);
            double convertedReference = from.Family.Convert(
                referenceValue,
                from.ReferenceUnit,
                to.ReferenceUnit);

            return to.FromReference(convertedReference);
        }

        public static double Convert(
            double value,
            UnitToolsCustomUnit from,
            string toBuiltInUnit)
        {
            if (from == null)
            {
                throw new ArgumentNullException(nameof(from));
            }

            object target;
            UnitToolsUnitResolution resolution =
                from.Family.ResolveUnit(toBuiltInUnit, out target);

            if (resolution != UnitToolsUnitResolution.Resolved)
            {
                throw new ArgumentException(
                    "The target built-in unit '" + toBuiltInUnit +
                    "' is not uniquely resolved in " + from.Family.Name + ".",
                    nameof(toBuiltInUnit));
            }

            return from.Family.Convert(
                from.ToReference(value),
                from.ReferenceUnit,
                target);
        }

        public static double Convert(
            double value,
            UnitToolsFamily family,
            string fromBuiltInUnit,
            UnitToolsCustomUnit to)
        {
            if (to == null)
            {
                throw new ArgumentNullException(nameof(to));
            }

            if (to.Family.Family != family)
            {
                throw new ArgumentException(
                    "The custom target unit belongs to a different family.",
                    nameof(to));
            }

            object source;
            UnitToolsUnitResolution resolution =
                to.Family.ResolveUnit(fromBuiltInUnit, out source);

            if (resolution != UnitToolsUnitResolution.Resolved)
            {
                throw new ArgumentException(
                    "The source built-in unit '" + fromBuiltInUnit +
                    "' is not uniquely resolved in " + to.Family.Name + ".",
                    nameof(fromBuiltInUnit));
            }

            double referenceValue =
                to.Family.Convert(value, source, to.ReferenceUnit);

            return to.FromReference(referenceValue);
        }

        public static double Convert(
            double value,
            UnitToolsFamily family,
            string fromUnit,
            string toUnit)
        {
            UnitToolsFamilyDescriptor descriptor =
                UnitToolsCatalog.GetFamily(family);

            object fromBuiltIn;
            UnitToolsUnitResolution fromBuiltInResolution =
                descriptor.ResolveUnit(fromUnit, out fromBuiltIn);
            UnitToolsCustomUnit fromCustom;
            UnitToolsUnitResolution fromCustomResolution =
                Resolve(family, fromUnit, out fromCustom);

            object toBuiltIn;
            UnitToolsUnitResolution toBuiltInResolution =
                descriptor.ResolveUnit(toUnit, out toBuiltIn);
            UnitToolsCustomUnit toCustom;
            UnitToolsUnitResolution toCustomResolution =
                Resolve(family, toUnit, out toCustom);

            if (fromBuiltInResolution == UnitToolsUnitResolution.Ambiguous ||
                fromCustomResolution == UnitToolsUnitResolution.Ambiguous ||
                toBuiltInResolution == UnitToolsUnitResolution.Ambiguous ||
                toCustomResolution == UnitToolsUnitResolution.Ambiguous)
            {
                throw new ArgumentException("A custom-unit conversion endpoint is ambiguous.");
            }

            bool hasFromBuiltIn =
                fromBuiltInResolution == UnitToolsUnitResolution.Resolved;
            bool hasFromCustom =
                fromCustomResolution == UnitToolsUnitResolution.Resolved;
            bool hasToBuiltIn =
                toBuiltInResolution == UnitToolsUnitResolution.Resolved;
            bool hasToCustom =
                toCustomResolution == UnitToolsUnitResolution.Resolved;

            if (hasFromBuiltIn == hasFromCustom)
            {
                throw new ArgumentException(
                    "The source unit '" + fromUnit + "' is not uniquely resolved.");
            }

            if (hasToBuiltIn == hasToCustom)
            {
                throw new ArgumentException(
                    "The target unit '" + toUnit + "' is not uniquely resolved.");
            }

            if (hasFromBuiltIn && hasToBuiltIn)
            {
                return descriptor.Convert(value, fromBuiltIn, toBuiltIn);
            }

            if (hasFromCustom && hasToBuiltIn)
            {
                return descriptor.Convert(
                    fromCustom.ToReference(value),
                    fromCustom.ReferenceUnit,
                    toBuiltIn);
            }

            if (hasFromBuiltIn && hasToCustom)
            {
                double referenceValue =
                    descriptor.Convert(
                        value,
                        fromBuiltIn,
                        toCustom.ReferenceUnit);

                return toCustom.FromReference(referenceValue);
            }

            double fromReference = fromCustom.ToReference(value);
            double toReference = descriptor.Convert(
                fromReference,
                fromCustom.ReferenceUnit,
                toCustom.ReferenceUnit);

            return toCustom.FromReference(toReference);
        }

        private static string[] BuildAliases(
            string name,
            string symbol,
            string displayName,
            string[] aliases)
        {
            var result = new List<string>();
            AddAlias(result, name);
            AddAlias(result, symbol);
            AddAlias(result, displayName);

            if (aliases != null)
            {
                foreach (string alias in aliases)
                {
                    AddAlias(result, alias);
                }
            }

            return result.ToArray();
        }

        private static void AddAlias(List<string> aliases, string alias)
        {
            if (string.IsNullOrWhiteSpace(alias))
            {
                return;
            }

            string candidate = alias.Trim();
            if (!aliases.Contains(candidate))
            {
                aliases.Add(candidate);
            }
        }

        private static void EnsureAliasAvailable(
            UnitToolsFamilyDescriptor family,
            UnitToolsFamily familyId,
            string alias)
        {
            object ignored;
            if (family.ResolveUnit(alias, out ignored) !=
                UnitToolsUnitResolution.Unknown)
            {
                throw new InvalidOperationException(
                    "The alias '" + alias +
                    "' conflicts with a built-in unit in " + family.Name + ".");
            }

            List<UnitToolsCustomUnit> existing;
            if (!UnitsByFamily.TryGetValue(familyId, out existing))
            {
                return;
            }

            foreach (UnitToolsCustomUnit custom in existing)
            {
                foreach (string existingAlias in custom.Aliases)
                {
                    if (string.Equals(
                        existingAlias,
                        alias,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        throw new InvalidOperationException(
                            "The alias '" + alias +
                            "' conflicts with custom unit " + custom.Name + ".");
                    }
                }
            }
        }

        private static UnitToolsUnitDescriptor FindUnitDescriptor(
            UnitToolsFamilyDescriptor family,
            object unit)
        {
            UnitToolsUnitDescriptor descriptor;
            return family.TryGetUnit(unit, out descriptor)
                ? descriptor
                : null;
        }

        private static void EnsureSameFamily(
            UnitToolsFamilyDescriptor left,
            UnitToolsFamilyDescriptor right)
        {
            if (left.Family != right.Family)
            {
                throw new ArgumentException(
                    "Custom units must belong to the same unit family.");
            }
        }
    }
}
