namespace UnitTools
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using UnitTools.Catalog;

    public enum UnitToolsDetectionStatus
    {
        Unknown = 0,
        Resolved = 1,
        Ambiguous = 2,
    }

    public sealed class UnitToolsUnitCandidate
    {
        internal UnitToolsUnitCandidate(
            UnitToolsFamilyDescriptor family,
            UnitToolsUnitDescriptor unit)
        {
            Family = family;
            Unit = unit;
        }

        internal UnitToolsUnitCandidate(UnitToolsCustomUnit customUnit)
        {
            CustomUnit = customUnit ?? throw new ArgumentNullException(nameof(customUnit));
            Family = customUnit.Family;
        }

        public UnitToolsFamilyDescriptor Family { get; }
        public UnitToolsUnitDescriptor Unit { get; }
        public UnitToolsCustomUnit CustomUnit { get; }
        public bool IsCustom => CustomUnit != null;
        public UnitToolsDimensions Dimensions =>
            IsCustom ? CustomUnit.Dimensions : Unit.Dimensions;
        public string Symbol =>
            IsCustom ? CustomUnit.Symbol : Unit.Symbol;
        public string Name =>
            IsCustom ? CustomUnit.Name : Unit.Name;
    }

    public readonly struct UnitToolsDetectionResult
    {
        private static readonly UnitToolsUnitCandidate[] EmptyCandidates =
            Array.Empty<UnitToolsUnitCandidate>();

        private UnitToolsDetectionResult(
            UnitToolsDetectionStatus status,
            double value,
            string unitText,
            IReadOnlyList<UnitToolsUnitCandidate> candidates,
            UnitToolsError error,
            string errorMessage)
        {
            Status = status;
            Value = value;
            UnitText = unitText;
            Candidates = candidates ?? EmptyCandidates;
            Error = error;
            ErrorMessage = errorMessage;
        }

        public bool Success => Status == UnitToolsDetectionStatus.Resolved;
        public UnitToolsDetectionStatus Status { get; }
        public double Value { get; }
        public string UnitText { get; }
        public IReadOnlyList<UnitToolsUnitCandidate> Candidates { get; }
        public UnitToolsError Error { get; }
        public string ErrorMessage { get; }

        public UnitToolsUnitCandidate Candidate =>
            Success && Candidates.Count == 1 ? Candidates[0] : null;

        internal static UnitToolsDetectionResult Resolved(
            double value,
            string unitText,
            IReadOnlyList<UnitToolsUnitCandidate> candidates)
        {
            return new UnitToolsDetectionResult(
                UnitToolsDetectionStatus.Resolved,
                value,
                unitText,
                candidates,
                UnitToolsError.None,
                null);
        }

        internal static UnitToolsDetectionResult Ambiguous(
            double value,
            string unitText,
            IReadOnlyList<UnitToolsUnitCandidate> candidates)
        {
            return new UnitToolsDetectionResult(
                UnitToolsDetectionStatus.Ambiguous,
                value,
                unitText,
                candidates,
                UnitToolsError.AmbiguousUnit,
                "The unit '" + unitText + "' matches multiple units or families.");
        }

        internal static UnitToolsDetectionResult Fail(
            UnitToolsError error,
            string errorMessage)
        {
            return new UnitToolsDetectionResult(
                UnitToolsDetectionStatus.Unknown,
                0d,
                null,
                EmptyCandidates,
                error,
                errorMessage);
        }
    }

    public static class UnitToolsDetector
    {
        private static readonly UnitToolsUnitCandidate[] EmptyCandidates =
            Array.Empty<UnitToolsUnitCandidate>();
        private static readonly Dictionary<string, IReadOnlyList<UnitToolsUnitCandidate>> ExactBuiltInCandidates;
        private static readonly Dictionary<string, IReadOnlyList<UnitToolsUnitCandidate>> IgnoreCaseBuiltInCandidates;

        static UnitToolsDetector()
        {
            Dictionary<string, IReadOnlyList<UnitToolsUnitCandidate>> exact;
            Dictionary<string, IReadOnlyList<UnitToolsUnitCandidate>> ignoreCase;
            BuildBuiltInCandidateIndexes(out exact, out ignoreCase);
            ExactBuiltInCandidates = exact;
            IgnoreCaseBuiltInCandidates = ignoreCase;
        }

        public static UnitToolsDetectionResult Detect(string input)
        {
            return Detect(input, CultureInfo.InvariantCulture);
        }

        public static UnitToolsDetectionResult Detect(
            string input,
            IFormatProvider formatProvider)
        {
            double value;
            string unitText;
            UnitToolsError splitError;

            if (!UnitToolsParser.TrySplitValueAndUnit(
                input,
                formatProvider ?? CultureInfo.InvariantCulture,
                out value,
                out unitText,
                out splitError))
            {
                return UnitToolsDetectionResult.Fail(
                    splitError,
                    splitError == UnitToolsError.MissingUnit
                        ? "The input does not contain a unit."
                        : "The numeric value could not be parsed.");
            }

            return DetectUnit(
                value,
                unitText,
                formatProvider ?? CultureInfo.InvariantCulture);
        }

        public static UnitToolsDetectionResult DetectUnit(string unitText)
        {
            return DetectUnit(
                unitText,
                CultureInfo.InvariantCulture);
        }

        public static UnitToolsDetectionResult DetectUnit(
            string unitText,
            IFormatProvider formatProvider)
        {
            return DetectUnit(
                0d,
                unitText,
                formatProvider ?? CultureInfo.InvariantCulture);
        }

        private static UnitToolsDetectionResult DetectUnit(
            double value,
            string unitText,
            IFormatProvider formatProvider)
        {
            if (string.IsNullOrWhiteSpace(unitText))
            {
                return UnitToolsDetectionResult.Fail(
                    UnitToolsError.MissingUnit,
                    "The input does not contain a unit.");
            }

            string candidateText = unitText.Trim();

            IReadOnlyList<UnitToolsUnitCandidate> exact =
                GetCandidates(
                    ExactBuiltInCandidates,
                    candidateText,
                    StringComparison.Ordinal);

            if (exact.Count > 0)
            {
                return FinalizeCandidatesWithLocalization(
                    value,
                    candidateText,
                    exact,
                    formatProvider);
            }

            IReadOnlyList<UnitToolsUnitCandidate> ignoreCase =
                GetCandidates(
                    IgnoreCaseBuiltInCandidates,
                    candidateText,
                    StringComparison.OrdinalIgnoreCase);

            if (ignoreCase.Count > 0)
            {
                return FinalizeCandidatesWithLocalization(
                    value,
                    candidateText,
                    ignoreCase,
                    formatProvider);
            }

            bool localizedAmbiguous;
            IReadOnlyList<UnitToolsUnitCandidate> localized =
                GetLocalizedCandidates(
                    candidateText,
                    formatProvider,
                    out localizedAmbiguous);

            if (localizedAmbiguous || localized.Count > 1)
            {
                return UnitToolsDetectionResult.Ambiguous(
                    value,
                    candidateText,
                    localized);
            }

            if (localized.Count == 1)
            {
                return UnitToolsDetectionResult.Resolved(
                    value,
                    candidateText,
                    localized);
            }

            return UnitToolsDetectionResult.Fail(
                UnitToolsError.UnknownUnit,
                "The unit '" + candidateText + "' is not recognized.");
        }

        private static UnitToolsDetectionResult FinalizeCandidatesWithLocalization(
            double value,
            string text,
            IReadOnlyList<UnitToolsUnitCandidate> primary,
            IFormatProvider formatProvider)
        {
            bool hasBuiltIn = false;
            for (int index = 0; index < primary.Count; index++)
            {
                if (!primary[index].IsCustom)
                {
                    hasBuiltIn = true;
                    break;
                }
            }

            // Invariant built-in aliases keep their existing precedence. A custom-only
            // match, however, must still be checked against culture-specific built-ins.
            if (hasBuiltIn)
            {
                return primary.Count == 1
                    ? UnitToolsDetectionResult.Resolved(value, text, primary)
                    : UnitToolsDetectionResult.Ambiguous(value, text, primary);
            }

            bool localizedAmbiguous;
            IReadOnlyList<UnitToolsUnitCandidate> localized =
                GetLocalizedCandidates(
                    text,
                    formatProvider,
                    out localizedAmbiguous);

            if (localized.Count == 0 && !localizedAmbiguous)
            {
                return primary.Count == 1
                    ? UnitToolsDetectionResult.Resolved(value, text, primary)
                    : UnitToolsDetectionResult.Ambiguous(value, text, primary);
            }

            var combined =
                new List<UnitToolsUnitCandidate>(
                    primary.Count + localized.Count);

            for (int index = 0; index < primary.Count; index++)
            {
                combined.Add(primary[index]);
            }

            for (int index = 0; index < localized.Count; index++)
            {
                combined.Add(localized[index]);
            }

            IReadOnlyList<UnitToolsUnitCandidate> result =
                combined.AsReadOnly();

            return UnitToolsDetectionResult.Ambiguous(
                value,
                text,
                result);
        }

        private static IReadOnlyList<UnitToolsUnitCandidate> GetLocalizedCandidates(
            string text,
            IFormatProvider formatProvider,
            out bool ambiguous)
        {
            ambiguous = false;
            var matches = new List<UnitToolsUnitCandidate>();

            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                object resolved;
                UnitToolsUnitResolution resolution =
                    UnitToolsLocalization.ResolveUnit(
                        family.UnitType,
                        text,
                        formatProvider,
                        out resolved);

                if (resolution == UnitToolsUnitResolution.Ambiguous)
                {
                    ambiguous = true;
                    continue;
                }

                if (resolution != UnitToolsUnitResolution.Resolved)
                {
                    continue;
                }

                UnitToolsUnitDescriptor descriptor =
                    FindUnitDescriptor(family, resolved);
                if (descriptor == null)
                {
                    continue;
                }

                bool alreadyAdded = false;
                foreach (UnitToolsUnitCandidate existing in matches)
                {
                    if (existing.Family.Family == family.Family &&
                        object.Equals(existing.Unit.Unit, descriptor.Unit))
                    {
                        alreadyAdded = true;
                        break;
                    }
                }

                if (!alreadyAdded)
                {
                    matches.Add(
                        new UnitToolsUnitCandidate(
                            family,
                            descriptor));
                }
            }

            return matches.Count == 0
                ? EmptyCandidates
                : matches.AsReadOnly();
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

        private static IReadOnlyList<UnitToolsUnitCandidate> GetCandidates(
            Dictionary<string, IReadOnlyList<UnitToolsUnitCandidate>> builtInIndex,
            string text,
            StringComparison customComparison)
        {
            IReadOnlyList<UnitToolsUnitCandidate> builtIn;
            if (!builtInIndex.TryGetValue(text, out builtIn))
            {
                builtIn = EmptyCandidates;
            }

            if (!UnitToolsCustomUnits.HasUnits)
            {
                return builtIn;
            }

            var matches = new List<UnitToolsUnitCandidate>(
                builtIn.Count + 1);
            foreach (UnitToolsUnitCandidate candidate in builtIn)
            {
                matches.Add(candidate);
            }
            UnitToolsCustomUnits.AppendMatchingCandidates(
                text,
                customComparison,
                matches);

            return matches.Count == 0
                ? EmptyCandidates
                : matches.AsReadOnly();
        }

        private static void BuildBuiltInCandidateIndexes(
            out Dictionary<string, IReadOnlyList<UnitToolsUnitCandidate>> exact,
            out Dictionary<string, IReadOnlyList<UnitToolsUnitCandidate>> ignoreCase)
        {
            var exactBuilders =
                new Dictionary<string, List<UnitToolsUnitCandidate>>(
                    StringComparer.Ordinal);
            var ignoreCaseBuilders =
                new Dictionary<string, List<UnitToolsUnitCandidate>>(
                    StringComparer.OrdinalIgnoreCase);

            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                foreach (UnitToolsUnitDescriptor unit in family.Units)
                {
                    var candidate =
                        new UnitToolsUnitCandidate(family, unit);

                    foreach (string alias in unit.AliasStorage)
                    {
                        if (string.IsNullOrWhiteSpace(alias))
                        {
                            continue;
                        }

                        AddCandidate(exactBuilders, alias, candidate);
                        AddCandidate(ignoreCaseBuilders, alias, candidate);
                    }
                }
            }

            exact = FreezeIndex(exactBuilders);
            ignoreCase = FreezeIndex(ignoreCaseBuilders);
        }

        private static void AddCandidate(
            Dictionary<string, List<UnitToolsUnitCandidate>> index,
            string alias,
            UnitToolsUnitCandidate candidate)
        {
            List<UnitToolsUnitCandidate> candidates;
            if (!index.TryGetValue(alias, out candidates))
            {
                candidates = new List<UnitToolsUnitCandidate>();
                index.Add(alias, candidates);
            }

            if (!candidates.Contains(candidate))
            {
                candidates.Add(candidate);
            }
        }

        private static Dictionary<string, IReadOnlyList<UnitToolsUnitCandidate>> FreezeIndex(
            Dictionary<string, List<UnitToolsUnitCandidate>> builders)
        {
            var result =
                new Dictionary<string, IReadOnlyList<UnitToolsUnitCandidate>>(
                    builders.Count,
                    builders.Comparer);

            foreach (KeyValuePair<string, List<UnitToolsUnitCandidate>> pair in builders)
            {
                result.Add(pair.Key, pair.Value.AsReadOnly());
            }

            return result;
        }
    }
}
