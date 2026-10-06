namespace UnitConverter
{
    using System;
    using System.Collections.Generic;
    using UnitConverter.Catalog;

    public sealed class UnitConverterCustomUnit
    {
        internal UnitConverterCustomUnit(
            UnitConverterFamilyDescriptor family,
            string name,
            string symbol,
            string displayName,
            string[] aliases,
            object referenceUnit,
            UnitConverterDimensions dimensions,
            double scaleToReference,
            double offsetToReference)
        {
            Family = family ?? throw new ArgumentNullException(nameof(family));
            Name = name;
            Symbol = symbol;
            DisplayName = displayName;
            Aliases = aliases ?? new string[0];
            ReferenceUnit = referenceUnit;
            Dimensions = dimensions;
            ScaleToReference = scaleToReference;
            OffsetToReference = offsetToReference;
        }

        public UnitConverterFamilyDescriptor Family { get; }
        public string Name { get; }
        public string Symbol { get; }
        public string DisplayName { get; }
        public IReadOnlyList<string> Aliases { get; }
        public UnitConverterDimensions Dimensions { get; }
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

    public static class UnitConverterCustomUnits
    {
        private static readonly object Sync = new object();
        private static readonly Dictionary<UnitConverterFamily, List<UnitConverterCustomUnit>> UnitsByFamily =
            new Dictionary<UnitConverterFamily, List<UnitConverterCustomUnit>>();

        public static UnitConverterCustomUnit RegisterLinear(
            UnitConverterFamily family,
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

        public static UnitConverterCustomUnit RegisterAffine(
            UnitConverterFamily family,
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

            UnitConverterFamilyDescriptor descriptor =
                UnitConverterCatalog.GetFamily(family);

            object reference;
            UnitConverterUnitResolution referenceResolution =
                descriptor.ResolveUnit(referenceUnit, out reference);

            if (referenceResolution != UnitConverterUnitResolution.Resolved)
            {
                throw new ArgumentException(
                    "The reference unit '" + referenceUnit +
                    "' is not a unique built-in unit in " + descriptor.Name + ".",
                    nameof(referenceUnit));
            }

            UnitConverterUnitDescriptor referenceDescriptor =
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

                var custom = new UnitConverterCustomUnit(
                    descriptor,
                    name.Trim(),
                    string.IsNullOrWhiteSpace(symbol) ? null : symbol.Trim(),
                    string.IsNullOrWhiteSpace(displayName) ? name.Trim() : displayName.Trim(),
                    acceptedAliases,
                    reference,
                    referenceDescriptor.Dimensions,
                    scaleToReference,
                    offsetToReference);

                List<UnitConverterCustomUnit> list;
                if (!UnitsByFamily.TryGetValue(family, out list))
                {
                    list = new List<UnitConverterCustomUnit>();
                    UnitsByFamily.Add(family, list);
                }

                list.Add(custom);
                return custom;
            }
        }

        public static bool Unregister(UnitConverterCustomUnit unit)
        {
            if (unit == null)
            {
                return false;
            }

            lock (Sync)
            {
                List<UnitConverterCustomUnit> list;
                return UnitsByFamily.TryGetValue(unit.Family.Family, out list) &&
                    list.Remove(unit);
            }
        }

        public static void Clear()
        {
            lock (Sync)
            {
                UnitsByFamily.Clear();
            }
        }

        public static IReadOnlyList<UnitConverterCustomUnit> GetUnits()
        {
            lock (Sync)
            {
                var result = new List<UnitConverterCustomUnit>();

                foreach (List<UnitConverterCustomUnit> units in UnitsByFamily.Values)
                {
                    result.AddRange(units);
                }

                return result.ToArray();
            }
        }

        public static IReadOnlyList<UnitConverterCustomUnit> GetUnits(
            UnitConverterFamily family)
        {
            lock (Sync)
            {
                List<UnitConverterCustomUnit> units;
                return UnitsByFamily.TryGetValue(family, out units)
                    ? units.ToArray()
                    : new UnitConverterCustomUnit[0];
            }
        }

        public static bool TryResolve(
            UnitConverterFamily family,
            string text,
            out UnitConverterCustomUnit unit)
        {
            return Resolve(family, text, out unit) ==
                UnitConverterUnitResolution.Resolved;
        }

        public static UnitConverterUnitResolution Resolve(
            UnitConverterFamily family,
            string text,
            out UnitConverterCustomUnit unit)
        {
            unit = null;

            if (string.IsNullOrWhiteSpace(text))
            {
                return UnitConverterUnitResolution.Unknown;
            }

            UnitConverterCustomUnit exact = null;
            UnitConverterCustomUnit insensitive = null;
            bool exactAmbiguous = false;
            bool insensitiveAmbiguous = false;
            string candidate = text.Trim();

            lock (Sync)
            {
                List<UnitConverterCustomUnit> units;
                if (!UnitsByFamily.TryGetValue(family, out units))
                {
                    return UnitConverterUnitResolution.Unknown;
                }

                foreach (UnitConverterCustomUnit custom in units)
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
                return UnitConverterUnitResolution.Ambiguous;
            }

            if (exact != null)
            {
                unit = exact;
                return UnitConverterUnitResolution.Resolved;
            }

            if (insensitiveAmbiguous)
            {
                return UnitConverterUnitResolution.Ambiguous;
            }

            if (insensitive != null)
            {
                unit = insensitive;
                return UnitConverterUnitResolution.Resolved;
            }

            return UnitConverterUnitResolution.Unknown;
        }

        public static double Convert(
            double value,
            UnitConverterCustomUnit from,
            UnitConverterCustomUnit to)
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
            UnitConverterCustomUnit from,
            string toBuiltInUnit)
        {
            if (from == null)
            {
                throw new ArgumentNullException(nameof(from));
            }

            object target;
            UnitConverterUnitResolution resolution =
                from.Family.ResolveUnit(toBuiltInUnit, out target);

            if (resolution != UnitConverterUnitResolution.Resolved)
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
            UnitConverterFamily family,
            string fromBuiltInUnit,
            UnitConverterCustomUnit to)
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
            UnitConverterUnitResolution resolution =
                to.Family.ResolveUnit(fromBuiltInUnit, out source);

            if (resolution != UnitConverterUnitResolution.Resolved)
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
            UnitConverterFamily family,
            string fromUnit,
            string toUnit)
        {
            UnitConverterFamilyDescriptor descriptor =
                UnitConverterCatalog.GetFamily(family);

            object fromBuiltIn;
            UnitConverterUnitResolution fromBuiltInResolution =
                descriptor.ResolveUnit(fromUnit, out fromBuiltIn);
            UnitConverterCustomUnit fromCustom;
            UnitConverterUnitResolution fromCustomResolution =
                Resolve(family, fromUnit, out fromCustom);

            object toBuiltIn;
            UnitConverterUnitResolution toBuiltInResolution =
                descriptor.ResolveUnit(toUnit, out toBuiltIn);
            UnitConverterCustomUnit toCustom;
            UnitConverterUnitResolution toCustomResolution =
                Resolve(family, toUnit, out toCustom);

            if (fromBuiltInResolution == UnitConverterUnitResolution.Ambiguous ||
                fromCustomResolution == UnitConverterUnitResolution.Ambiguous ||
                toBuiltInResolution == UnitConverterUnitResolution.Ambiguous ||
                toCustomResolution == UnitConverterUnitResolution.Ambiguous)
            {
                throw new ArgumentException("A custom-unit conversion endpoint is ambiguous.");
            }

            bool hasFromBuiltIn =
                fromBuiltInResolution == UnitConverterUnitResolution.Resolved;
            bool hasFromCustom =
                fromCustomResolution == UnitConverterUnitResolution.Resolved;
            bool hasToBuiltIn =
                toBuiltInResolution == UnitConverterUnitResolution.Resolved;
            bool hasToCustom =
                toCustomResolution == UnitConverterUnitResolution.Resolved;

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
            UnitConverterFamilyDescriptor family,
            UnitConverterFamily familyId,
            string alias)
        {
            object ignored;
            if (family.ResolveUnit(alias, out ignored) !=
                UnitConverterUnitResolution.Unknown)
            {
                throw new InvalidOperationException(
                    "The alias '" + alias +
                    "' conflicts with a built-in unit in " + family.Name + ".");
            }

            List<UnitConverterCustomUnit> existing;
            if (!UnitsByFamily.TryGetValue(familyId, out existing))
            {
                return;
            }

            foreach (UnitConverterCustomUnit custom in existing)
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

        private static UnitConverterUnitDescriptor FindUnitDescriptor(
            UnitConverterFamilyDescriptor family,
            object unit)
        {
            foreach (UnitConverterUnitDescriptor descriptor in family.Units)
            {
                if (object.Equals(descriptor.Unit, unit))
                {
                    return descriptor;
                }
            }

            return null;
        }

        private static void EnsureSameFamily(
            UnitConverterFamilyDescriptor left,
            UnitConverterFamilyDescriptor right)
        {
            if (left.Family != right.Family)
            {
                throw new ArgumentException(
                    "Custom units must belong to the same unit family.");
            }
        }
    }
}
