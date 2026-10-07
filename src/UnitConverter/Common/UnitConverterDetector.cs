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
            UnitConverterUnitCandidate[] candidates,
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
            UnitConverterUnitCandidate[] candidates)
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
            UnitConverterUnitCandidate[] candidates)
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
        private static readonly Dictionary<string, UnitConverterUnitCandidate[]> ExactBuiltInCandidates;
        private static readonly Dictionary<string, UnitConverterUnitCandidate[]> IgnoreCaseBuiltInCandidates;

        static UnitConverterDetector()
        {
            BuildBuiltInCandidateIndexes(
                out ExactBuiltInCandidates,
                out IgnoreCaseBuiltInCandidates);
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

            return DetectUnit(value, unitText);
        }

        public static UnitConverterDetectionResult DetectUnit(string unitText)
        {
            return DetectUnit(0d, unitText);
        }

        private static UnitConverterDetectionResult DetectUnit(
            double value,
            string unitText)
        {
            if (string.IsNullOrWhiteSpace(unitText))
            {
                return UnitConverterDetectionResult.Fail(
                    UnitConverterError.MissingUnit,
                    "The input does not contain a unit.");
            }

            string candidateText = unitText.Trim();

            UnitConverterUnitCandidate[] exact =
                GetCandidates(
                    ExactBuiltInCandidates,
                    candidateText,
                    StringComparison.Ordinal);

            if (exact.Length == 1)
            {
                return UnitConverterDetectionResult.Resolved(
                    value,
                    candidateText,
                    exact);
            }

            if (exact.Length > 1)
            {
                return UnitConverterDetectionResult.Ambiguous(
                    value,
                    candidateText,
                    exact);
            }

            UnitConverterUnitCandidate[] ignoreCase =
                GetCandidates(
                    IgnoreCaseBuiltInCandidates,
                    candidateText,
                    StringComparison.OrdinalIgnoreCase);

            if (ignoreCase.Length == 1)
            {
                return UnitConverterDetectionResult.Resolved(
                    value,
                    candidateText,
                    ignoreCase);
            }

            if (ignoreCase.Length > 1)
            {
                return UnitConverterDetectionResult.Ambiguous(
                    value,
                    candidateText,
                    ignoreCase);
            }

            return UnitConverterDetectionResult.Fail(
                UnitConverterError.UnknownUnit,
                "The unit '" + candidateText + "' is not recognized.");
        }

        private static UnitConverterUnitCandidate[] GetCandidates(
            Dictionary<string, UnitConverterUnitCandidate[]> builtInIndex,
            string text,
            StringComparison customComparison)
        {
            UnitConverterUnitCandidate[] builtIn;
            if (!builtInIndex.TryGetValue(text, out builtIn))
            {
                builtIn = EmptyCandidates;
            }

            if (!UnitConverterCustomUnits.HasUnits)
            {
                return builtIn;
            }

            var matches = new List<UnitConverterUnitCandidate>(
                builtIn.Length + 1);
            matches.AddRange(builtIn);
            UnitConverterCustomUnits.AppendMatchingCandidates(
                text,
                customComparison,
                matches);

            return matches.Count == 0
                ? EmptyCandidates
                : matches.ToArray();
        }

        private static void BuildBuiltInCandidateIndexes(
            out Dictionary<string, UnitConverterUnitCandidate[]> exact,
            out Dictionary<string, UnitConverterUnitCandidate[]> ignoreCase)
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

                    foreach (string alias in unit.Aliases)
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

        private static Dictionary<string, UnitConverterUnitCandidate[]> FreezeIndex(
            Dictionary<string, List<UnitConverterUnitCandidate>> builders)
        {
            var result =
                new Dictionary<string, UnitConverterUnitCandidate[]>(
                    builders.Count,
                    builders.Comparer);

            foreach (KeyValuePair<string, List<UnitConverterUnitCandidate>> pair in builders)
            {
                result.Add(pair.Key, pair.Value.ToArray());
            }

            return result;
        }
    }
}
