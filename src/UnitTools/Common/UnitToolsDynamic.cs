namespace UnitTools
{
    using System;
    using System.Globalization;
    using UnitTools.Catalog;

    /// <summary>
    /// Converts values when the unit family or unit text is known only at runtime.
    /// Prefer family-specific or strongly typed APIs when units are known at compile time.
    /// </summary>
    public static class UnitToolsDynamic
    {

        public static double Convert(
            string input,
            string toUnit)
        {
            UnitToolsDynamicResult result = TryConvert(input, toUnit);

            if (!result.Success)
            {
                throw new FormatException(result.ErrorMessage);
            }

            return result.Value;
        }

        public static UnitToolsDynamicResult TryConvert(
            string input,
            string toUnit)
        {
            return TryConvert(
                input,
                toUnit,
                CultureInfo.InvariantCulture);
        }

        public static UnitToolsDynamicResult TryConvert(
            string input,
            string toUnit,
            IFormatProvider formatProvider)
        {
            UnitToolsDetectionResult detection =
                UnitToolsDetector.Detect(
                    input,
                    formatProvider ?? CultureInfo.InvariantCulture);

            if (detection.Status == UnitToolsDetectionStatus.Unknown)
            {
                return UnitToolsDynamicResult.Fail(
                    default(UnitToolsFamily),
                    detection.Error,
                    detection.ErrorMessage);
            }

            if (detection.Status == UnitToolsDetectionStatus.Resolved)
            {
                UnitToolsUnitCandidate candidate = detection.Candidate;
                return TryConvertDetectedCandidate(
                    detection.Value,
                    candidate,
                    toUnit,
                    formatProvider ?? CultureInfo.InvariantCulture);
            }

            UnitToolsUnitCandidate selected = null;

            foreach (UnitToolsUnitCandidate candidate in detection.Candidates)
            {
                object ignored;
                UnitToolsCustomUnit ignoredCustom;
                bool builtInTarget =
                    ResolveBuiltInUnit(
                        candidate.Family,
                        toUnit,
                        formatProvider ?? CultureInfo.InvariantCulture,
                        out ignored) == UnitToolsUnitResolution.Resolved;
                bool customTarget =
                    UnitToolsCustomUnits.Resolve(
                        candidate.Family.Family,
                        toUnit,
                        out ignoredCustom) == UnitToolsUnitResolution.Resolved;

                if (builtInTarget || customTarget)
                {
                    if (selected != null)
                    {
                        return UnitToolsDynamicResult.Fail(
                            default(UnitToolsFamily),
                            UnitToolsError.AmbiguousUnit,
                            "The source unit '" + detection.UnitText +
                            "' remains ambiguous for target unit '" + toUnit + "'.");
                    }

                    selected = candidate;
                }
            }

            if (selected == null)
            {
                return UnitToolsDynamicResult.Fail(
                    default(UnitToolsFamily),
                    UnitToolsError.AmbiguousUnit,
                    "The source unit '" + detection.UnitText +
                    "' is ambiguous across " + detection.Candidates.Count + " candidates.");
            }

            return TryConvertDetectedCandidate(
                detection.Value,
                selected,
                toUnit,
                formatProvider ?? CultureInfo.InvariantCulture);
        }

        public static double Convert(
            double value,
            UnitToolsFamily family,
            string fromUnit,
            string toUnit)
        {
            UnitToolsDynamicResult result =
                TryConvert(value, family, fromUnit, toUnit);

            if (!result.Success)
            {
                throw new ArgumentException(result.ErrorMessage);
            }

            return result.Value;
        }

        public static double Convert(
            string input,
            UnitToolsFamily family,
            string toUnit)
        {
            return Convert(
                input,
                family,
                toUnit,
                CultureInfo.InvariantCulture);
        }

        public static double Convert(
            string input,
            UnitToolsFamily family,
            string toUnit,
            IFormatProvider formatProvider)
        {
            UnitToolsDynamicResult result =
                TryConvert(input, family, toUnit, formatProvider);

            if (!result.Success)
            {
                throw new FormatException(result.ErrorMessage);
            }

            return result.Value;
        }

        public static UnitToolsDynamicResult TryConvert(
            double value,
            UnitToolsFamily family,
            string fromUnit,
            string toUnit)
        {
            return TryConvert(
                value,
                family,
                fromUnit,
                toUnit,
                CultureInfo.InvariantCulture);
        }

        public static UnitToolsDynamicResult TryConvert(
            double value,
            UnitToolsFamily family,
            string fromUnit,
            string toUnit,
            IFormatProvider formatProvider)
        {
            UnitToolsFamilyDescriptor descriptor;
            if (!UnitToolsCatalog.TryGetFamily(family, out descriptor))
            {
                return UnitToolsDynamicResult.Fail(
                    family,
                    UnitToolsError.UnknownFamily,
                    "The unit family '" + family + "' is not registered.");
            }

            object fromBuiltIn;
            UnitToolsUnitResolution fromBuiltInResolution =
                ResolveBuiltInUnit(
                    descriptor,
                    fromUnit,
                    formatProvider,
                    out fromBuiltIn);
            UnitToolsCustomUnit fromCustom;
            UnitToolsUnitResolution fromCustomResolution =
                UnitToolsCustomUnits.Resolve(family, fromUnit, out fromCustom);

            object toBuiltIn;
            UnitToolsUnitResolution toBuiltInResolution =
                ResolveBuiltInUnit(
                    descriptor,
                    toUnit,
                    formatProvider,
                    out toBuiltIn);
            UnitToolsCustomUnit toCustom;
            UnitToolsUnitResolution toCustomResolution =
                UnitToolsCustomUnits.Resolve(family, toUnit, out toCustom);

            UnitToolsDynamicResult fromFailure =
                GetEndpointFailure(
                    descriptor,
                    family,
                    fromUnit,
                    fromBuiltInResolution,
                    fromCustomResolution,
                    "source",
                    formatProvider);

            if (!fromFailure.Success &&
                fromFailure.Error != UnitToolsError.None)
            {
                return fromFailure;
            }

            UnitToolsDynamicResult toFailure =
                GetEndpointFailure(
                    descriptor,
                    family,
                    toUnit,
                    toBuiltInResolution,
                    toCustomResolution,
                    "target",
                    formatProvider);

            if (!toFailure.Success &&
                toFailure.Error != UnitToolsError.None)
            {
                return toFailure;
            }

            bool sourceIsBuiltIn =
                fromBuiltInResolution == UnitToolsUnitResolution.Resolved;
            bool targetIsBuiltIn =
                toBuiltInResolution == UnitToolsUnitResolution.Resolved;

            try
            {
                double converted;
                UnitToolsUnitDescriptor fromDescriptor = null;
                UnitToolsUnitDescriptor toDescriptor = null;

                if (sourceIsBuiltIn && targetIsBuiltIn)
                {
                    converted = descriptor.Convert(
                        value,
                        fromBuiltIn,
                        toBuiltIn);
                    fromDescriptor =
                        FindUnitDescriptor(descriptor, fromBuiltIn);
                    toDescriptor =
                        FindUnitDescriptor(descriptor, toBuiltIn);
                }
                else
                {
                    if (sourceIsBuiltIn)
                    {
                        fromDescriptor =
                            FindUnitDescriptor(descriptor, fromBuiltIn);
                    }

                    if (targetIsBuiltIn)
                    {
                        toDescriptor =
                            FindUnitDescriptor(descriptor, toBuiltIn);
                    }

                    converted = UnitToolsCustomUnits.Convert(
                        value,
                        family,
                        sourceIsBuiltIn ? fromDescriptor.Name : fromUnit,
                        targetIsBuiltIn ? toDescriptor.Name : toUnit);
                }

                return UnitToolsDynamicResult.Ok(
                    converted,
                    family,
                    fromDescriptor,
                    toDescriptor,
                    sourceIsBuiltIn ? null : fromCustom,
                    targetIsBuiltIn ? null : toCustom);
            }
            catch (Exception exception)
            {
                return UnitToolsDynamicResult.Fail(
                    family,
                    UnitToolsError.ConversionFailed,
                    exception.Message);
            }
        }

        public static UnitToolsDynamicResult TryConvert(
            string input,
            UnitToolsFamily family,
            string toUnit)
        {
            return TryConvert(
                input,
                family,
                toUnit,
                CultureInfo.InvariantCulture);
        }

        public static UnitToolsDynamicResult TryConvert(
            string input,
            UnitToolsFamily family,
            string toUnit,
            IFormatProvider formatProvider)
        {
            UnitToolsFamilyDescriptor descriptor;
            if (!UnitToolsCatalog.TryGetFamily(family, out descriptor))
            {
                return UnitToolsDynamicResult.Fail(
                    family,
                    UnitToolsError.UnknownFamily,
                    "The unit family '" + family + "' is not registered.");
            }

            double value;
            string fromUnit;
            UnitToolsError splitError;

            if (!UnitToolsParser.TrySplitValueAndUnit(
                input,
                formatProvider ?? CultureInfo.InvariantCulture,
                out value,
                out fromUnit,
                out splitError))
            {
                return UnitToolsDynamicResult.Fail(
                    family,
                    splitError,
                    splitError == UnitToolsError.MissingUnit
                        ? "The input does not contain a source unit."
                        : "The numeric value could not be parsed.");
            }

            return TryConvert(value, family, fromUnit, toUnit, formatProvider ?? CultureInfo.InvariantCulture);
        }

        public static UnitToolsDynamicResult TryConvert(
            double value,
            string familyName,
            string fromUnit,
            string toUnit)
        {
            return TryConvert(
                value,
                familyName,
                fromUnit,
                toUnit,
                CultureInfo.InvariantCulture);
        }

        public static UnitToolsDynamicResult TryConvert(
            double value,
            string familyName,
            string fromUnit,
            string toUnit,
            IFormatProvider formatProvider)
        {
            UnitToolsFamilyDescriptor descriptor;
            if (!UnitToolsCatalog.TryGetFamily(familyName, out descriptor))
            {
                return UnitToolsDynamicResult.Fail(
                    default(UnitToolsFamily),
                    UnitToolsError.UnknownFamily,
                    "The unit family '" + familyName + "' is not registered.");
            }

            return TryConvert(
                value,
                descriptor.Family,
                fromUnit,
                toUnit,
                formatProvider ?? CultureInfo.InvariantCulture);
        }

        public static UnitToolsDynamicResult TryConvert(
            string input,
            string familyName,
            string toUnit)
        {
            return TryConvert(
                input,
                familyName,
                toUnit,
                CultureInfo.InvariantCulture);
        }

        public static UnitToolsDynamicResult TryConvert(
            string input,
            string familyName,
            string toUnit,
            IFormatProvider formatProvider)
        {
            UnitToolsFamilyDescriptor descriptor;
            if (!UnitToolsCatalog.TryGetFamily(familyName, out descriptor))
            {
                return UnitToolsDynamicResult.Fail(
                    default(UnitToolsFamily),
                    UnitToolsError.UnknownFamily,
                    "The unit family '" + familyName + "' is not registered.");
            }

            return TryConvert(
                input,
                descriptor.Family,
                toUnit,
                formatProvider ?? CultureInfo.InvariantCulture);
        }


        private static UnitToolsDynamicResult TryConvertDetectedCandidate(
            double value,
            UnitToolsUnitCandidate candidate,
            string toUnit,
            IFormatProvider formatProvider)
        {
            if (candidate.IsCustom)
            {
                return TryConvert(
                    value,
                    candidate.Family.Family,
                    candidate.CustomUnit.Name,
                    toUnit,
                    formatProvider);
            }

            UnitToolsCustomUnit customTarget;
            UnitToolsUnitResolution customResolution =
                UnitToolsCustomUnits.Resolve(
                    candidate.Family.Family,
                    toUnit,
                    out customTarget);

            if (customResolution == UnitToolsUnitResolution.Resolved)
            {
                return TryConvert(
                    value,
                    candidate.Family.Family,
                    candidate.Unit.Name,
                    toUnit,
                    formatProvider);
            }

            object target;
            UnitToolsUnitResolution resolution =
                ResolveBuiltInUnit(
                    candidate.Family,
                    toUnit,
                    formatProvider,
                    out target);

            if (resolution == UnitToolsUnitResolution.Ambiguous ||
                customResolution == UnitToolsUnitResolution.Ambiguous)
            {
                return UnitToolsDynamicResult.Fail(
                    candidate.Family.Family,
                    UnitToolsError.AmbiguousUnit,
                    "The target unit '" + toUnit + "' is ambiguous in " +
                    candidate.Family.Name + ".");
            }

            if (resolution == UnitToolsUnitResolution.Unknown)
            {
                return UnitToolsDynamicResult.Fail(
                    candidate.Family.Family,
                    UnitToolsError.WrongUnitFamily,
                    "The target unit '" + toUnit + "' does not belong to " +
                    candidate.Family.Name + ".");
            }

            try
            {
                double converted = candidate.Family.Convert(
                    value,
                    candidate.Unit.Unit,
                    target);

                return UnitToolsDynamicResult.Ok(
                    converted,
                    candidate.Family.Family,
                    candidate.Unit,
                    FindUnitDescriptor(candidate.Family, target));
            }
            catch (Exception exception)
            {
                return UnitToolsDynamicResult.Fail(
                    candidate.Family.Family,
                    UnitToolsError.ConversionFailed,
                    exception.Message);
            }
        }

        private static UnitToolsUnitResolution ResolveBuiltInUnit(
            UnitToolsFamilyDescriptor descriptor,
            string text,
            IFormatProvider formatProvider,
            out object unit)
        {
            UnitToolsUnitResolution resolution =
                descriptor.ResolveUnit(text, out unit);

            if (resolution != UnitToolsUnitResolution.Unknown)
            {
                return resolution;
            }

            return UnitToolsLocalization.ResolveUnit(
                descriptor.UnitType,
                text,
                formatProvider ?? CultureInfo.InvariantCulture,
                out unit);
        }

        private static UnitToolsDynamicResult GetEndpointFailure(
            UnitToolsFamilyDescriptor descriptor,
            UnitToolsFamily family,
            string unitText,
            UnitToolsUnitResolution builtInResolution,
            UnitToolsUnitResolution customResolution,
            string role,
            IFormatProvider formatProvider)
        {
            if (builtInResolution == UnitToolsUnitResolution.Ambiguous ||
                customResolution == UnitToolsUnitResolution.Ambiguous)
            {
                return UnitToolsDynamicResult.Fail(
                    family,
                    UnitToolsError.AmbiguousUnit,
                    "The " + role + " unit '" + unitText +
                    "' is ambiguous in " + descriptor.Name + ".");
            }

            bool builtIn =
                builtInResolution == UnitToolsUnitResolution.Resolved;
            bool custom =
                customResolution == UnitToolsUnitResolution.Resolved;

            if (builtIn && custom)
            {
                return UnitToolsDynamicResult.Fail(
                    family,
                    UnitToolsError.AmbiguousUnit,
                    "The " + role + " unit '" + unitText +
                    "' matches both a built-in and a custom unit in " +
                    descriptor.Name + ".");
            }

            if (builtIn || custom)
            {
                return default(UnitToolsDynamicResult);
            }

            if (ExistsInAnotherFamily(descriptor, unitText, formatProvider))
            {
                return UnitToolsDynamicResult.Fail(
                    family,
                    UnitToolsError.WrongUnitFamily,
                    "The " + role + " unit '" + unitText +
                    "' does not belong to " + descriptor.Name + ".");
            }

            return UnitToolsDynamicResult.Fail(
                family,
                UnitToolsError.UnknownUnit,
                "The " + role + " unit '" + unitText +
                "' is not recognized.");
        }

        private static UnitToolsDynamicResult GetUnitFailure(
            UnitToolsFamilyDescriptor descriptor,
            UnitToolsFamily family,
            string unitText,
            UnitToolsUnitResolution resolution,
            string role)
        {
            if (resolution == UnitToolsUnitResolution.Resolved)
            {
                return default(UnitToolsDynamicResult);
            }

            if (resolution == UnitToolsUnitResolution.Ambiguous)
            {
                return UnitToolsDynamicResult.Fail(
                    family,
                    UnitToolsError.AmbiguousUnit,
                    "The " + role + " unit '" + unitText + "' is ambiguous in " + descriptor.Name + ".");
            }

            if (ExistsInAnotherFamily(descriptor, unitText, CultureInfo.InvariantCulture))
            {
                return UnitToolsDynamicResult.Fail(
                    family,
                    UnitToolsError.WrongUnitFamily,
                    "The " + role + " unit '" + unitText + "' does not belong to " + descriptor.Name + ".");
            }

            return UnitToolsDynamicResult.Fail(
                family,
                UnitToolsError.UnknownUnit,
                "The " + role + " unit '" + unitText + "' is not recognized.");
        }

        private static bool ExistsInAnotherFamily(
            UnitToolsFamilyDescriptor requestedFamily,
            string unitText,
            IFormatProvider formatProvider)
        {
            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                if (family.Family == requestedFamily.Family)
                {
                    continue;
                }

                object ignored;
                if (ResolveBuiltInUnit(
                    family,
                    unitText,
                    formatProvider,
                    out ignored) != UnitToolsUnitResolution.Unknown)
                {
                    return true;
                }
            }

            return false;
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
    }
}
