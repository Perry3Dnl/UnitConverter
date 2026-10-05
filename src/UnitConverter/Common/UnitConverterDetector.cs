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
            Candidates = candidates ?? new UnitConverterUnitCandidate[0];
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
            UnitConverterUnitCandidate candidate)
        {
            return new UnitConverterDetectionResult(
                UnitConverterDetectionStatus.Resolved,
                value,
                unitText,
                new[] { candidate },
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
                null,
                error,
                errorMessage);
        }
    }

    public static class UnitConverterDetector
    {
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

            UnitConverterUnitCandidate[] exact = FindCandidates(
                candidateText,
                StringComparison.Ordinal);

            if (exact.Length == 1)
            {
                return UnitConverterDetectionResult.Resolved(
                    value,
                    candidateText,
                    exact[0]);
            }

            if (exact.Length > 1)
            {
                return UnitConverterDetectionResult.Ambiguous(
                    value,
                    candidateText,
                    exact);
            }

            UnitConverterUnitCandidate[] ignoreCase = FindCandidates(
                candidateText,
                StringComparison.OrdinalIgnoreCase);

            if (ignoreCase.Length == 1)
            {
                return UnitConverterDetectionResult.Resolved(
                    value,
                    candidateText,
                    ignoreCase[0]);
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

        private static UnitConverterUnitCandidate[] FindCandidates(
            string text,
            StringComparison comparison)
        {
            var matches = new List<UnitConverterUnitCandidate>();

            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                foreach (UnitConverterUnitDescriptor unit in family.Units)
                {
                    if (MatchesAlias(unit, text, comparison))
                    {
                        matches.Add(new UnitConverterUnitCandidate(family, unit));
                    }
                }
            }

            foreach (UnitConverterCustomUnit custom in UnitConverterCustomUnits.GetUnits())
            {
                if (MatchesAlias(custom, text, comparison))
                {
                    matches.Add(new UnitConverterUnitCandidate(custom));
                }
            }

            return matches.ToArray();
        }

        private static bool MatchesAlias(
            UnitConverterCustomUnit unit,
            string text,
            StringComparison comparison)
        {
            foreach (string alias in unit.Aliases)
            {
                if (string.Equals(alias, text, comparison))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool MatchesAlias(
            UnitConverterUnitDescriptor unit,
            string text,
            StringComparison comparison)
        {
            foreach (string alias in unit.Aliases)
            {
                if (string.Equals(alias, text, comparison))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
