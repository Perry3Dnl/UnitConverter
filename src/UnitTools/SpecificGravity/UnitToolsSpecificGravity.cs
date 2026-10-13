namespace UnitTools.SpecificGravity
{
    using UnitTools.SpecificGravity.Common;
    using UnitTools.SpecificGravity.Engineering;

    public enum UnitToolsSpecificGravityUnit
    {
        Ratio = 0,
        SpecificGravity = 1,
        RelativeDensity = 2,
        Percent = 3,
        PerMille = 4,
        Ppm = 5,
        Ppb = 6,
        Ppt = 7,
        BasisPoint = 8,
        PerTenThousand = 9,
        APIGravity = 10,
        BaumeLight = 11,
        BaumeHeavy = 12,
        Twaddell = 13,
    }

    public static class UnitToolsSpecificGravity
    {
        public static double Convert(double value, UnitToolsSpecificGravityUnit from, UnitToolsSpecificGravityUnit to)
        {
            double baseValue = ToRatio(value, from);
            return FromRatio(baseValue, to);
        }

        public static double ToRatio(double value, UnitToolsSpecificGravityUnit from)
        {
            switch (from)
            {
                case UnitToolsSpecificGravityUnit.Ratio:
                    return UnitToolsCommonSpecificGravity.RatioToRatio(value);
                case UnitToolsSpecificGravityUnit.SpecificGravity:
                    return UnitToolsCommonSpecificGravity.SpecificGravityToRatio(value);
                case UnitToolsSpecificGravityUnit.RelativeDensity:
                    return UnitToolsCommonSpecificGravity.RelativeDensityToRatio(value);
                case UnitToolsSpecificGravityUnit.Percent:
                    return UnitToolsCommonSpecificGravity.PercentToRatio(value);
                case UnitToolsSpecificGravityUnit.PerMille:
                    return UnitToolsCommonSpecificGravity.PerMilleToRatio(value);
                case UnitToolsSpecificGravityUnit.Ppm:
                    return UnitToolsCommonSpecificGravity.PpmToRatio(value);
                case UnitToolsSpecificGravityUnit.Ppb:
                    return UnitToolsCommonSpecificGravity.PpbToRatio(value);
                case UnitToolsSpecificGravityUnit.Ppt:
                    return UnitToolsCommonSpecificGravity.PptToRatio(value);
                case UnitToolsSpecificGravityUnit.BasisPoint:
                    return UnitToolsCommonSpecificGravity.BasisPointToRatio(value);
                case UnitToolsSpecificGravityUnit.PerTenThousand:
                    return UnitToolsCommonSpecificGravity.PerTenThousandToRatio(value);
                case UnitToolsSpecificGravityUnit.APIGravity:
                    return UnitToolsEngineeringSpecificGravity.APIGravityToRatio(value);
                case UnitToolsSpecificGravityUnit.BaumeLight:
                    return UnitToolsEngineeringSpecificGravity.BaumeLightToRatio(value);
                case UnitToolsSpecificGravityUnit.BaumeHeavy:
                    return UnitToolsEngineeringSpecificGravity.BaumeHeavyToRatio(value);
                case UnitToolsSpecificGravityUnit.Twaddell:
                    return UnitToolsEngineeringSpecificGravity.TwaddellToRatio(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported specific gravity unit.");
            }
        }

        public static double FromRatio(double baseValue, UnitToolsSpecificGravityUnit to)
        {
            switch (to)
            {
                case UnitToolsSpecificGravityUnit.Ratio:
                    return UnitToolsCommonSpecificGravity.RatioToRatio(baseValue);
                case UnitToolsSpecificGravityUnit.SpecificGravity:
                    return UnitToolsCommonSpecificGravity.RatioToSpecificGravity(baseValue);
                case UnitToolsSpecificGravityUnit.RelativeDensity:
                    return UnitToolsCommonSpecificGravity.RatioToRelativeDensity(baseValue);
                case UnitToolsSpecificGravityUnit.Percent:
                    return UnitToolsCommonSpecificGravity.RatioToPercent(baseValue);
                case UnitToolsSpecificGravityUnit.PerMille:
                    return UnitToolsCommonSpecificGravity.RatioToPerMille(baseValue);
                case UnitToolsSpecificGravityUnit.Ppm:
                    return UnitToolsCommonSpecificGravity.RatioToPpm(baseValue);
                case UnitToolsSpecificGravityUnit.Ppb:
                    return UnitToolsCommonSpecificGravity.RatioToPpb(baseValue);
                case UnitToolsSpecificGravityUnit.Ppt:
                    return UnitToolsCommonSpecificGravity.RatioToPpt(baseValue);
                case UnitToolsSpecificGravityUnit.BasisPoint:
                    return UnitToolsCommonSpecificGravity.RatioToBasisPoint(baseValue);
                case UnitToolsSpecificGravityUnit.PerTenThousand:
                    return UnitToolsCommonSpecificGravity.RatioToPerTenThousand(baseValue);
                case UnitToolsSpecificGravityUnit.APIGravity:
                    return UnitToolsEngineeringSpecificGravity.RatioToAPIGravity(baseValue);
                case UnitToolsSpecificGravityUnit.BaumeLight:
                    return UnitToolsEngineeringSpecificGravity.RatioToBaumeLight(baseValue);
                case UnitToolsSpecificGravityUnit.BaumeHeavy:
                    return UnitToolsEngineeringSpecificGravity.RatioToBaumeHeavy(baseValue);
                case UnitToolsSpecificGravityUnit.Twaddell:
                    return UnitToolsEngineeringSpecificGravity.RatioToTwaddell(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported specific gravity unit.");
            }
        }

        public static string GetSymbol(UnitToolsSpecificGravityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpecificGravityUnit.Ratio:
                    return "ratio";
                case UnitToolsSpecificGravityUnit.SpecificGravity:
                    return "SG";
                case UnitToolsSpecificGravityUnit.RelativeDensity:
                    return "RD";
                case UnitToolsSpecificGravityUnit.Percent:
                    return "%";
                case UnitToolsSpecificGravityUnit.PerMille:
                    return "‰";
                case UnitToolsSpecificGravityUnit.Ppm:
                    return "ppm";
                case UnitToolsSpecificGravityUnit.Ppb:
                    return "ppb";
                case UnitToolsSpecificGravityUnit.Ppt:
                    return "ppt";
                case UnitToolsSpecificGravityUnit.BasisPoint:
                    return "bp";
                case UnitToolsSpecificGravityUnit.PerTenThousand:
                    return "‱";
                case UnitToolsSpecificGravityUnit.APIGravity:
                    return "°API";
                case UnitToolsSpecificGravityUnit.BaumeLight:
                    return "°Bé light";
                case UnitToolsSpecificGravityUnit.BaumeHeavy:
                    return "°Bé heavy";
                case UnitToolsSpecificGravityUnit.Twaddell:
                    return "°Tw";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsSpecificGravityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpecificGravityUnit.Ratio:
                    return "Ratio";
                case UnitToolsSpecificGravityUnit.SpecificGravity:
                    return "Specific Gravity";
                case UnitToolsSpecificGravityUnit.RelativeDensity:
                    return "Relative Density";
                case UnitToolsSpecificGravityUnit.Percent:
                    return "Percent";
                case UnitToolsSpecificGravityUnit.PerMille:
                    return "Per Mille";
                case UnitToolsSpecificGravityUnit.Ppm:
                    return "Parts Per Million";
                case UnitToolsSpecificGravityUnit.Ppb:
                    return "Parts Per Billion";
                case UnitToolsSpecificGravityUnit.Ppt:
                    return "Parts Per Trillion";
                case UnitToolsSpecificGravityUnit.BasisPoint:
                    return "Basis Point";
                case UnitToolsSpecificGravityUnit.PerTenThousand:
                    return "Per Ten Thousand";
                case UnitToolsSpecificGravityUnit.APIGravity:
                    return "API Gravity";
                case UnitToolsSpecificGravityUnit.BaumeLight:
                    return "Baumé Light";
                case UnitToolsSpecificGravityUnit.BaumeHeavy:
                    return "Baumé Heavy";
                case UnitToolsSpecificGravityUnit.Twaddell:
                    return "Twaddell";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsSpecificGravityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSpecificGravityUnit.Ratio:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsSpecificGravityUnit.SpecificGravity:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsSpecificGravityUnit.RelativeDensity:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsSpecificGravityUnit.Percent:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsSpecificGravityUnit.PerMille:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsSpecificGravityUnit.Ppm:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsSpecificGravityUnit.Ppb:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsSpecificGravityUnit.Ppt:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsSpecificGravityUnit.BasisPoint:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsSpecificGravityUnit.PerTenThousand:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsSpecificGravityUnit.APIGravity:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsSpecificGravityUnit.BaumeLight:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsSpecificGravityUnit.BaumeHeavy:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsSpecificGravityUnit.Twaddell:
                    return UnitToolsUnitSystem.Engineering;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsSpecificGravityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsSpecificGravityUnit.Ratio, UnitToolsSpecificGravityUnit.SpecificGravity, UnitToolsSpecificGravityUnit.RelativeDensity, UnitToolsSpecificGravityUnit.Percent, UnitToolsSpecificGravityUnit.PerMille, UnitToolsSpecificGravityUnit.Ppm, UnitToolsSpecificGravityUnit.Ppb, UnitToolsSpecificGravityUnit.Ppt, UnitToolsSpecificGravityUnit.BasisPoint, UnitToolsSpecificGravityUnit.PerTenThousand };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsSpecificGravityUnit.APIGravity, UnitToolsSpecificGravityUnit.BaumeLight, UnitToolsSpecificGravityUnit.BaumeHeavy, UnitToolsSpecificGravityUnit.Twaddell };
                default:
                    return new[] { UnitToolsSpecificGravityUnit.Ratio, UnitToolsSpecificGravityUnit.SpecificGravity, UnitToolsSpecificGravityUnit.RelativeDensity, UnitToolsSpecificGravityUnit.Percent, UnitToolsSpecificGravityUnit.PerMille, UnitToolsSpecificGravityUnit.Ppm, UnitToolsSpecificGravityUnit.Ppb, UnitToolsSpecificGravityUnit.Ppt, UnitToolsSpecificGravityUnit.BasisPoint, UnitToolsSpecificGravityUnit.PerTenThousand, UnitToolsSpecificGravityUnit.APIGravity, UnitToolsSpecificGravityUnit.BaumeLight, UnitToolsSpecificGravityUnit.BaumeHeavy, UnitToolsSpecificGravityUnit.Twaddell };
            }
        }
    }
}
