namespace UnitConverter
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using UnitConverter.Catalog;

    public enum UnitConverterDetectionStatus
    {
        Unknown = 0,
        Resolved = 1,
        Ambiguous = 2,
    }

    public sealed class UnitConverterUnitCandidate
    {
        internal UnitConverterUnitCandidate(
            UnitConverterFamilyDescriptor family,
            UnitConverterUnitDescriptor unit)
        {
            Family = family;
            Unit = unit;
        }

        internal UnitConverterUnitCandidate(UnitConverterCustomUnit customUnit)
        {
            CustomUnit = customUnit ?? throw new ArgumentNullException(nameof(customUnit));
            Family = customUnit.Family;
        }

        public UnitConverterFamilyDescriptor Family { get; }
        public UnitConverterUnitDescriptor Unit { get; }
        public UnitConverterCustomUnit CustomUnit { get; }
        public bool IsCustom => CustomUnit != null;
        public UnitConverterDimensions Dimensions =>
            IsCustom ? CustomUnit.Dimensions : Unit.Dimensions;
        public string Symbol =>
            IsCustom ? CustomUnit.Symbol : Unit.Symbol;
        public string Name =>
            IsCustom ? CustomUnit.Name : Unit.Name;
    }

    public readonly struct UnitConverterDetectionResult
    {
        private static readonly UnitConverterUnitCandidate[] EmptyCandidates =
            Array.Empty<UnitConverterUnitCandidate>();

        private UnitConverterDetectionResult(
            UnitConverterDetectionStatus status,
            double value,
            string unitText,
            IReadOnlyList<UnitConverterUnitCandidate> candidates,
            UnitConverterError error,
            string errorMessage)
        {
            Status = status;
            Value = value;
            UnitText = unitText;
            Candidates = candidates ?? EmptyCandidates;
            Error = error;
            ErrorMessage = errorMessage;
        }

        public bool Success => Status == UnitConverterDetectionStatus.Resolved;
        public UnitConverterDetectionStatus Status { get; }
        public double Value { get; }
        public string UnitText { get; }
        public IReadOnlyList<UnitConverterUnitCandidate> Candidates { get; }
        public UnitConverterError Error { get; }
        public string ErrorMessage { get; }

        public UnitConverterUnitCandidate Candidate =>
            Success && Candidates.Count == 1 ? Candidates[0] : null;

        internal static UnitConverterDetectionResult Resolved(
            double value,
            string unitText,
            IReadOnlyList<UnitConverterUnitCandidate> candidates)
        {
            return new UnitConverterDetectionResult(
                UnitConverterDetectionStatus.Resolved,
                value,
                unitText,
                candidates,
                UnitConverterError.None,
                null);
        }

        internal static UnitConverterDetectionResult Ambiguous(
            double value,
            string unitText,
            IReadOnlyList<UnitConverterUnitCandidate> candidates)
        {
            return new UnitConverterDetectionResult(
                UnitConverterDetectionStatus.Ambiguous,
                value,
                unitText,
                candidates,
                UnitConverterError.AmbiguousUnit,
                "The unit '" + unitText + "' matches multiple units or families.");
        }

        internal static UnitConverterDetectionResult Fail(
            UnitConverterError error,
            string errorMessage)
        {
            return new UnitConverterDetectionResult(
                UnitConverterDetectionStatus.Unknown,
                0d,
                null,
                EmptyCandidates,
                error,
                errorMessage);
        }
    }

    public static class UnitConverterDetector
    {
        private static readonly UnitConverterUnitCandidate[] EmptyCandidates =
            Array.Empty<UnitConverterUnitCandidate>();
        private static readonly Dictionary<string, IReadOnlyList<UnitConverterUnitCandidate>> ExactBuiltInCandidates;
        private static readonly Dictionary<string, IReadOnlyList<UnitConverterUnitCandidate>> IgnoreCaseBuiltInCandidates;

        static UnitConverterDetector()
        {
            Dictionary<string, IReadOnlyList<UnitConverterUnitCandidate>> exact;
            Dictionary<string, IReadOnlyList<UnitConverterUnitCandidate>> ignoreCase;
            BuildBuiltInCandidateIndexes(out exact, out ignoreCase);
            ExactBuiltInCandidates = exact;
            IgnoreCaseBuiltInCandidates = ignoreCase;
        }

        public static UnitConverterDetectionResult Detect(string input)
        {
            return Detect(input, CultureInfo.InvariantCulture);
        }

        public static UnitConverterDetectionResult Detect(
            string input,
            IFormatProvider formatProvider)
        {
            double value;
            string unitText;
            UnitConverterError splitError;

            if (!UnitConverterParser.TrySplitValueAndUnit(
                input,
                formatProvider ?? CultureInfo.InvariantCulture,
                out value,
                out unitText,
                out splitError))
            {
                return UnitConverterDetectionResult.Fail(
                    splitError,
                    splitError == UnitConverterError.MissingUnit
                        ? "The input does not contain a unit."
                        : "The numeric value could not be parsed.");
            }

            return DetectUnit(
                value,
                unitText,
                formatProvider ?? CultureInfo.InvariantCulture);
        }

        public static UnitConverterDetectionResult DetectUnit(string unitText)
        {
            return DetectUnit(
                unitText,
                CultureInfo.InvariantCulture);
        }

        public static UnitConverterDetectionResult DetectUnit(
            string unitText,
            IFormatProvider formatProvider)
        {
            return DetectUnit(
                0d,
                unitText,
                formatProvider ?? CultureInfo.InvariantCulture);
        }

        private static UnitConverterDetectionResult DetectUnit(
            double value,
            string unitText,
            IFormatProvider formatProvider)
        {
            if (string.IsNullOrWhiteSpace(unitText))
            {
                return UnitConverterDetectionResult.Fail(
                    UnitConverterError.MissingUnit,
                    "The input does not contain a unit.");
            }

            string candidateText = unitText.Trim();

            IReadOnlyList<UnitConverterUnitCandidate> exact =
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

            IReadOnlyList<UnitConverterUnitCandidate> ignoreCase =
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
            IReadOnlyList<UnitConverterUnitCandidate> localized =
                GetLocalizedCandidates(
                    candidateText,
                    formatProvider,
                    out localizedAmbiguous);

            if (localizedAmbiguous || localized.Count > 1)
            {
                return UnitConverterDetectionResult.Ambiguous(
                    value,
                    candidateText,
                    localized);
            }

            if (localized.Count == 1)
            {
                return UnitConverterDetectionResult.Resolved(
                    value,
                    candidateText,
                    localized);
            }

            return UnitConverterDetectionResult.Fail(
                UnitConverterError.UnknownUnit,
                "The unit '" + candidateText + "' is not recognized.");
        }

        private static UnitConverterDetectionResult FinalizeCandidatesWithLocalization(
            double value,
            string text,
            IReadOnlyList<UnitConverterUnitCandidate> primary,
            IFormatProvider formatProvider)
        {
            bool hasBuiltIn = false;
            foreach (UnitConverterUnitCandidate candidate in primary)
            {
                if (!candidate.IsCustom)
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
                    ? UnitConverterDetectionResult.Resolved(value, text, primary)
                    : UnitConverterDetectionResult.Ambiguous(value, text, primary);
            }

            bool localizedAmbiguous;
            IReadOnlyList<UnitConverterUnitCandidate> localized =
                GetLocalizedCandidates(
                    text,
                    formatProvider,
                    out localizedAmbiguous);

            if (localized.Count == 0 && !localizedAmbiguous)
            {
                return primary.Count == 1
                    ? UnitConverterDetectionResult.Resolved(value, text, primary)
                    : UnitConverterDetectionResult.Ambiguous(value, text, primary);
            }

            var combined =
                new List<UnitConverterUnitCandidate>(
                    primary.Count + localized.Count);

            foreach (UnitConverterUnitCandidate candidate in primary)
            {
                combined.Add(candidate);
            }

            foreach (UnitConverterUnitCandidate candidate in localized)
            {
                combined.Add(candidate);
            }

            IReadOnlyList<UnitConverterUnitCandidate> result =
                combined.AsReadOnly();

            return UnitConverterDetectionResult.Ambiguous(
                value,
                text,
                result);
        }

        private static IReadOnlyList<UnitConverterUnitCandidate> GetLocalizedCandidates(
            string text,
            IFormatProvider formatProvider,
            out bool ambiguous)
        {
            ambiguous = false;
            var matches = new List<UnitConverterUnitCandidate>();

            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                object resolved;
                UnitConverterUnitResolution resolution =
                    UnitConverterLocalization.ResolveUnit(
                        family.UnitType,
                        text,
                        formatProvider,
                        out resolved);

                if (resolution == UnitConverterUnitResolution.Ambiguous)
                {
                    ambiguous = true;
                    continue;
                }

                if (resolution != UnitConverterUnitResolution.Resolved)
                {
                    continue;
                }

                UnitConverterUnitDescriptor descriptor =
                    FindUnitDescriptor(family, resolved);
                if (descriptor == null)
                {
                    continue;
                }

                bool alreadyAdded = false;
                foreach (UnitConverterUnitCandidate existing in matches)
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
                        new UnitConverterUnitCandidate(
                            family,
                            descriptor));
                }
            }

            return matches.Count == 0
                ? EmptyCandidates
                : matches.AsReadOnly();
        }

        private static UnitConverterUnitDescriptor FindUnitDescriptor(
            UnitConverterFamilyDescriptor family,
            object unit)
        {
            UnitConverterUnitDescriptor descriptor;
            return family.TryGetUnit(unit, out descriptor)
                ? descriptor
                : null;
        }

        private static IReadOnlyList<UnitConverterUnitCandidate> GetCandidates(
            Dictionary<string, IReadOnlyList<UnitConverterUnitCandidate>> builtInIndex,
            string text,
            StringComparison customComparison)
        {
            IReadOnlyList<UnitConverterUnitCandidate> builtIn;
            if (!builtInIndex.TryGetValue(text, out builtIn))
            {
                builtIn = EmptyCandidates;
            }

            if (!UnitConverterCustomUnits.HasUnits)
            {
                return builtIn;
            }

            var matches = new List<UnitConverterUnitCandidate>(
                builtIn.Count + 1);
            foreach (UnitConverterUnitCandidate candidate in builtIn)
            {
                matches.Add(candidate);
            }
            UnitConverterCustomUnits.AppendMatchingCandidates(
                text,
                customComparison,
                matches);

            return matches.Count == 0
                ? EmptyCandidates
                : matches.AsReadOnly();
        }

        private static void BuildBuiltInCandidateIndexes(
            out Dictionary<string, IReadOnlyList<UnitConverterUnitCandidate>> exact,
            out Dictionary<string, IReadOnlyList<UnitConverterUnitCandidate>> ignoreCase)
        {
            var exactBuilders =
                new Dictionary<string, List<UnitConverterUnitCandidate>>(
                    StringComparer.Ordinal);
            var ignoreCaseBuilders =
                new Dictionary<string, List<UnitConverterUnitCandidate>>(
                    StringComparer.OrdinalIgnoreCase);

            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    var candidate =
                        new UnitConverterUnitCandidate(family, unit);

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
            Dictionary<string, List<UnitConverterUnitCandidate>> index,
            string alias,
            UnitConverterUnitCandidate candidate)
        {
            List<UnitConverterUnitCandidate> candidates;
            if (!index.TryGetValue(alias, out candidates))
            {
                candidates = new List<UnitConverterUnitCandidate>();
                index.Add(alias, candidates);
            }

            if (!candidates.Contains(candidate))
            {
                candidates.Add(candidate);
            }
        }

        private static Dictionary<string, IReadOnlyList<UnitConverterUnitCandidate>> FreezeIndex(
            Dictionary<string, List<UnitConverterUnitCandidate>> builders)
        {
            var result =
                new Dictionary<string, IReadOnlyList<UnitConverterUnitCandidate>>(
                    builders.Count,
                    builders.Comparer);

            foreach (KeyValuePair<string, List<UnitConverterUnitCandidate>> pair in builders)
            {
                result.Add(pair.Key, pair.Value.AsReadOnly());
            }

            return result;
        }
    }
}
