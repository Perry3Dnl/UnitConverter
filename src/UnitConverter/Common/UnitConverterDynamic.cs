namespace UnitConverter
{
    using System;
    using System.Globalization;
    using UnitConverter.Catalog;

    public static class UnitConverterDynamic
    {

        public static double Convert(
            string input,
            string toUnit)
        {
            UnitConverterDynamicResult result = TryConvert(input, toUnit);

            if (!result.Success)
            {
                throw new FormatException(result.ErrorMessage);
            }

            return result.Value;
        }

        public static UnitConverterDynamicResult TryConvert(
            string input,
            string toUnit)
        {
            return TryConvert(
                input,
                toUnit,
                CultureInfo.InvariantCulture);
        }

        public static UnitConverterDynamicResult TryConvert(
            string input,
            string toUnit,
            IFormatProvider formatProvider)
        {
            UnitConverterDetectionResult detection =
                UnitConverterDetector.Detect(
                    input,
                    formatProvider ?? CultureInfo.InvariantCulture);

            if (detection.Status == UnitConverterDetectionStatus.Unknown)
            {
                return UnitConverterDynamicResult.Fail(
                    default(UnitConverterFamily),
                    detection.Error,
                    detection.ErrorMessage);
            }

            if (detection.Status == UnitConverterDetectionStatus.Resolved)
            {
                UnitConverterUnitCandidate candidate = detection.Candidate;
                return TryConvertDetectedCandidate(
                    detection.Value,
                    candidate,
                    toUnit);
            }

            UnitConverterUnitCandidate selected = null;

            foreach (UnitConverterUnitCandidate candidate in detection.Candidates)
            {
                object ignored;
                if (candidate.Family.ResolveUnit(
                    toUnit,
                    out ignored) == UnitConverterUnitResolution.Resolved)
                {
                    if (selected != null)
                    {
                        return UnitConverterDynamicResult.Fail(
                            default(UnitConverterFamily),
                            UnitConverterError.AmbiguousUnit,
                            "The source unit '" + detection.UnitText +
                            "' remains ambiguous for target unit '" + toUnit + "'.");
                    }

                    selected = candidate;
                }
            }

            if (selected == null)
            {
                return UnitConverterDynamicResult.Fail(
                    default(UnitConverterFamily),
                    UnitConverterError.AmbiguousUnit,
                    "The source unit '" + detection.UnitText +
                    "' is ambiguous across " + detection.Candidates.Count + " candidates.");
            }

            return TryConvertDetectedCandidate(
                detection.Value,
                selected,
                toUnit);
        }

        public static double Convert(
            double value,
            UnitConverterFamily family,
            string fromUnit,
            string toUnit)
        {
            UnitConverterDynamicResult result =
                TryConvert(value, family, fromUnit, toUnit);

            if (!result.Success)
            {
                throw new ArgumentException(result.ErrorMessage);
            }

            return result.Value;
        }

        public static double Convert(
            string input,
            UnitConverterFamily family,
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
            UnitConverterFamily family,
            string toUnit,
            IFormatProvider formatProvider)
        {
            UnitConverterDynamicResult result =
                TryConvert(input, family, toUnit, formatProvider);

            if (!result.Success)
            {
                throw new FormatException(result.ErrorMessage);
            }

            return result.Value;
        }

        public static UnitConverterDynamicResult TryConvert(
            double value,
            UnitConverterFamily family,
            string fromUnit,
            string toUnit)
        {
            UnitConverterFamilyDescriptor descriptor;
            if (!UnitConverterCatalog.TryGetFamily(family, out descriptor))
            {
                return UnitConverterDynamicResult.Fail(
                    family,
                    UnitConverterError.UnknownFamily,
                    "The unit family '" + family + "' is not registered.");
            }

            object fromBuiltIn;
            UnitConverterUnitResolution fromBuiltInResolution =
                descriptor.ResolveUnit(fromUnit, out fromBuiltIn);
            UnitConverterCustomUnit fromCustom;
            UnitConverterUnitResolution fromCustomResolution =
                UnitConverterCustomUnits.Resolve(family, fromUnit, out fromCustom);

            object toBuiltIn;
            UnitConverterUnitResolution toBuiltInResolution =
                descriptor.ResolveUnit(toUnit, out toBuiltIn);
            UnitConverterCustomUnit toCustom;
            UnitConverterUnitResolution toCustomResolution =
                UnitConverterCustomUnits.Resolve(family, toUnit, out toCustom);

            UnitConverterDynamicResult fromFailure =
                GetEndpointFailure(
                    descriptor,
                    family,
                    fromUnit,
                    fromBuiltInResolution,
                    fromCustomResolution,
                    "source");

            if (!fromFailure.Success &&
                fromFailure.Error != UnitConverterError.None)
            {
                return fromFailure;
            }

            UnitConverterDynamicResult toFailure =
                GetEndpointFailure(
                    descriptor,
                    family,
                    toUnit,
                    toBuiltInResolution,
                    toCustomResolution,
                    "target");

            if (!toFailure.Success &&
                toFailure.Error != UnitConverterError.None)
            {
                return toFailure;
            }

            bool sourceIsBuiltIn =
                fromBuiltInResolution == UnitConverterUnitResolution.Resolved;
            bool targetIsBuiltIn =
                toBuiltInResolution == UnitConverterUnitResolution.Resolved;

            try
            {
                double converted;
                UnitConverterUnitDescriptor fromDescriptor = null;
                UnitConverterUnitDescriptor toDescriptor = null;

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
                    converted = UnitConverterCustomUnits.Convert(
                        value,
                        family,
                        fromUnit,
                        toUnit);

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
                }

                return UnitConverterDynamicResult.Ok(
                    converted,
                    family,
                    fromDescriptor,
                    toDescriptor,
                    sourceIsBuiltIn ? null : fromCustom,
                    targetIsBuiltIn ? null : toCustom);
            }
            catch (Exception exception)
            {
                return UnitConverterDynamicResult.Fail(
                    family,
                    UnitConverterError.ConversionFailed,
                    exception.Message);
            }
        }

        public static UnitConverterDynamicResult TryConvert(
            string input,
            UnitConverterFamily family,
            string toUnit)
        {
            return TryConvert(
                input,
                family,
                toUnit,
                CultureInfo.InvariantCulture);
        }

        public static UnitConverterDynamicResult TryConvert(
            string input,
            UnitConverterFamily family,
            string toUnit,
            IFormatProvider formatProvider)
        {
            UnitConverterFamilyDescriptor descriptor;
            if (!UnitConverterCatalog.TryGetFamily(family, out descriptor))
            {
                return UnitConverterDynamicResult.Fail(
                    family,
                    UnitConverterError.UnknownFamily,
                    "The unit family '" + family + "' is not registered.");
            }

            double value;
            string fromUnit;
            UnitConverterError splitError;

            if (!UnitConverterParser.TrySplitValueAndUnit(
                input,
                formatProvider ?? CultureInfo.InvariantCulture,
                out value,
                out fromUnit,
                out splitError))
            {
                return UnitConverterDynamicResult.Fail(
                    family,
                    splitError,
                    splitError == UnitConverterError.MissingUnit
                        ? "The input does not contain a source unit."
                        : "The numeric value could not be parsed.");
            }

            return TryConvert(value, family, fromUnit, toUnit);
        }

        public static UnitConverterDynamicResult TryConvert(
            double value,
            string familyName,
            string fromUnit,
            string toUnit)
        {
            UnitConverterFamilyDescriptor descriptor;
            if (!UnitConverterCatalog.TryGetFamily(familyName, out descriptor))
            {
                return UnitConverterDynamicResult.Fail(
                    default(UnitConverterFamily),
                    UnitConverterError.UnknownFamily,
                    "The unit family '" + familyName + "' is not registered.");
            }

            return TryConvert(value, descriptor.Family, fromUnit, toUnit);
        }

        public static UnitConverterDynamicResult TryConvert(
            string input,
            string familyName,
            string toUnit)
        {
            UnitConverterFamilyDescriptor descriptor;
            if (!UnitConverterCatalog.TryGetFamily(familyName, out descriptor))
            {
                return UnitConverterDynamicResult.Fail(
                    default(UnitConverterFamily),
                    UnitConverterError.UnknownFamily,
                    "The unit family '" + familyName + "' is not registered.");
            }

            return TryConvert(input, descriptor.Family, toUnit);
        }


        private static UnitConverterDynamicResult TryConvertDetectedCandidate(
            double value,
            UnitConverterUnitCandidate candidate,
            string toUnit)
        {
            object target;
            UnitConverterUnitResolution resolution =
                candidate.Family.ResolveUnit(toUnit, out target);

            if (resolution == UnitConverterUnitResolution.Ambiguous)
            {
                return UnitConverterDynamicResult.Fail(
                    candidate.Family.Family,
                    UnitConverterError.AmbiguousUnit,
                    "The target unit '" + toUnit + "' is ambiguous in " +
                    candidate.Family.Name + ".");
            }

            if (resolution == UnitConverterUnitResolution.Unknown)
            {
                return UnitConverterDynamicResult.Fail(
                    candidate.Family.Family,
                    UnitConverterError.WrongUnitFamily,
                    "The target unit '" + toUnit + "' does not belong to " +
                    candidate.Family.Name + ".");
            }

            try
            {
                double converted = candidate.Family.Convert(
                    value,
                    candidate.Unit.Unit,
                    target);

                return UnitConverterDynamicResult.Ok(
                    converted,
                    candidate.Family.Family,
                    candidate.Unit,
                    FindUnitDescriptor(candidate.Family, target));
            }
            catch (Exception exception)
            {
                return UnitConverterDynamicResult.Fail(
                    candidate.Family.Family,
                    UnitConverterError.ConversionFailed,
                    exception.Message);
            }
        }

        private static UnitConverterDynamicResult GetEndpointFailure(
            UnitConverterFamilyDescriptor descriptor,
            UnitConverterFamily family,
            string unitText,
            UnitConverterUnitResolution builtInResolution,
            UnitConverterUnitResolution customResolution,
            string role)
        {
            if (builtInResolution == UnitConverterUnitResolution.Ambiguous ||
                customResolution == UnitConverterUnitResolution.Ambiguous)
            {
                return UnitConverterDynamicResult.Fail(
                    family,
                    UnitConverterError.AmbiguousUnit,
                    "The " + role + " unit '" + unitText +
                    "' is ambiguous in " + descriptor.Name + ".");
            }

            bool builtIn =
                builtInResolution == UnitConverterUnitResolution.Resolved;
            bool custom =
                customResolution == UnitConverterUnitResolution.Resolved;

            if (builtIn && custom)
            {
                return UnitConverterDynamicResult.Fail(
                    family,
                    UnitConverterError.AmbiguousUnit,
                    "The " + role + " unit '" + unitText +
                    "' matches both a built-in and a custom unit in " +
                    descriptor.Name + ".");
            }

            if (builtIn || custom)
            {
                return default(UnitConverterDynamicResult);
            }

            if (ExistsInAnotherFamily(descriptor, unitText))
            {
                return UnitConverterDynamicResult.Fail(
                    family,
                    UnitConverterError.WrongUnitFamily,
                    "The " + role + " unit '" + unitText +
                    "' does not belong to " + descriptor.Name + ".");
            }

            return UnitConverterDynamicResult.Fail(
                family,
                UnitConverterError.UnknownUnit,
                "The " + role + " unit '" + unitText +
                "' is not recognized.");
        }

        private static UnitConverterDynamicResult GetUnitFailure(
            UnitConverterFamilyDescriptor descriptor,
            UnitConverterFamily family,
            string unitText,
            UnitConverterUnitResolution resolution,
            string role)
        {
            if (resolution == UnitConverterUnitResolution.Resolved)
            {
                return default(UnitConverterDynamicResult);
            }

            if (resolution == UnitConverterUnitResolution.Ambiguous)
            {
                return UnitConverterDynamicResult.Fail(
                    family,
                    UnitConverterError.AmbiguousUnit,
                    "The " + role + " unit '" + unitText + "' is ambiguous in " + descriptor.Name + ".");
            }

            if (ExistsInAnotherFamily(descriptor, unitText))
            {
                return UnitConverterDynamicResult.Fail(
                    family,
                    UnitConverterError.WrongUnitFamily,
                    "The " + role + " unit '" + unitText + "' does not belong to " + descriptor.Name + ".");
            }

            return UnitConverterDynamicResult.Fail(
                family,
                UnitConverterError.UnknownUnit,
                "The " + role + " unit '" + unitText + "' is not recognized.");
        }

        private static bool ExistsInAnotherFamily(
            UnitConverterFamilyDescriptor requestedFamily,
            string unitText)
        {
            foreach (UnitConverterFamilyDescriptor family in UnitConverterCatalog.GetFamilies())
            {
                if (family.Family == requestedFamily.Family)
                {
                    continue;
                }

                object ignored;
                if (family.ResolveUnit(unitText, out ignored) != UnitConverterUnitResolution.Unknown)
                {
                    return true;
                }
            }

            return false;
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
    }
}
