namespace UnitConverter.SpecificGravity
{
    using UnitConverter.SpecificGravity.Common;
    using UnitConverter.SpecificGravity.Engineering;

    public enum UnitConverterSpecificGravityUnit
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

    public static class UnitConverterSpecificGravity
    {
        public static double Convert(double value, UnitConverterSpecificGravityUnit from, UnitConverterSpecificGravityUnit to)
        {
            double baseValue = ToRatio(value, from);
            return FromRatio(baseValue, to);
        }

        public static double ToRatio(double value, UnitConverterSpecificGravityUnit from)
        {
            switch (from)
            {
                case UnitConverterSpecificGravityUnit.Ratio:
                    return UnitConverterCommonSpecificGravity.RatioToRatio(value);
                case UnitConverterSpecificGravityUnit.SpecificGravity:
                    return UnitConverterCommonSpecificGravity.SpecificGravityToRatio(value);
                case UnitConverterSpecificGravityUnit.RelativeDensity:
                    return UnitConverterCommonSpecificGravity.RelativeDensityToRatio(value);
                case UnitConverterSpecificGravityUnit.Percent:
                    return UnitConverterCommonSpecificGravity.PercentToRatio(value);
                case UnitConverterSpecificGravityUnit.PerMille:
                    return UnitConverterCommonSpecificGravity.PerMilleToRatio(value);
                case UnitConverterSpecificGravityUnit.Ppm:
                    return UnitConverterCommonSpecificGravity.PpmToRatio(value);
                case UnitConverterSpecificGravityUnit.Ppb:
                    return UnitConverterCommonSpecificGravity.PpbToRatio(value);
                case UnitConverterSpecificGravityUnit.Ppt:
                    return UnitConverterCommonSpecificGravity.PptToRatio(value);
                case UnitConverterSpecificGravityUnit.BasisPoint:
                    return UnitConverterCommonSpecificGravity.BasisPointToRatio(value);
                case UnitConverterSpecificGravityUnit.PerTenThousand:
                    return UnitConverterCommonSpecificGravity.PerTenThousandToRatio(value);
                case UnitConverterSpecificGravityUnit.APIGravity:
                    return UnitConverterEngineeringSpecificGravity.APIGravityToRatio(value);
                case UnitConverterSpecificGravityUnit.BaumeLight:
                    return UnitConverterEngineeringSpecificGravity.BaumeLightToRatio(value);
                case UnitConverterSpecificGravityUnit.BaumeHeavy:
                    return UnitConverterEngineeringSpecificGravity.BaumeHeavyToRatio(value);
                case UnitConverterSpecificGravityUnit.Twaddell:
                    return UnitConverterEngineeringSpecificGravity.TwaddellToRatio(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported specific gravity unit.");
            }
        }

        public static double FromRatio(double baseValue, UnitConverterSpecificGravityUnit to)
        {
            switch (to)
            {
                case UnitConverterSpecificGravityUnit.Ratio:
                    return UnitConverterCommonSpecificGravity.RatioToRatio(baseValue);
                case UnitConverterSpecificGravityUnit.SpecificGravity:
                    return UnitConverterCommonSpecificGravity.RatioToSpecificGravity(baseValue);
                case UnitConverterSpecificGravityUnit.RelativeDensity:
                    return UnitConverterCommonSpecificGravity.RatioToRelativeDensity(baseValue);
                case UnitConverterSpecificGravityUnit.Percent:
                    return UnitConverterCommonSpecificGravity.RatioToPercent(baseValue);
                case UnitConverterSpecificGravityUnit.PerMille:
                    return UnitConverterCommonSpecificGravity.RatioToPerMille(baseValue);
                case UnitConverterSpecificGravityUnit.Ppm:
                    return UnitConverterCommonSpecificGravity.RatioToPpm(baseValue);
                case UnitConverterSpecificGravityUnit.Ppb:
                    return UnitConverterCommonSpecificGravity.RatioToPpb(baseValue);
                case UnitConverterSpecificGravityUnit.Ppt:
                    return UnitConverterCommonSpecificGravity.RatioToPpt(baseValue);
                case UnitConverterSpecificGravityUnit.BasisPoint:
                    return UnitConverterCommonSpecificGravity.RatioToBasisPoint(baseValue);
                case UnitConverterSpecificGravityUnit.PerTenThousand:
                    return UnitConverterCommonSpecificGravity.RatioToPerTenThousand(baseValue);
                case UnitConverterSpecificGravityUnit.APIGravity:
                    return UnitConverterEngineeringSpecificGravity.RatioToAPIGravity(baseValue);
                case UnitConverterSpecificGravityUnit.BaumeLight:
                    return UnitConverterEngineeringSpecificGravity.RatioToBaumeLight(baseValue);
                case UnitConverterSpecificGravityUnit.BaumeHeavy:
                    return UnitConverterEngineeringSpecificGravity.RatioToBaumeHeavy(baseValue);
                case UnitConverterSpecificGravityUnit.Twaddell:
                    return UnitConverterEngineeringSpecificGravity.RatioToTwaddell(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported specific gravity unit.");
            }
        }

        public static string GetSymbol(UnitConverterSpecificGravityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpecificGravityUnit.Ratio:
                    return "ratio";
                case UnitConverterSpecificGravityUnit.SpecificGravity:
                    return "SG";
                case UnitConverterSpecificGravityUnit.RelativeDensity:
                    return "RD";
                case UnitConverterSpecificGravityUnit.Percent:
                    return "%";
                case UnitConverterSpecificGravityUnit.PerMille:
                    return "‰";
                case UnitConverterSpecificGravityUnit.Ppm:
                    return "ppm";
                case UnitConverterSpecificGravityUnit.Ppb:
                    return "ppb";
                case UnitConverterSpecificGravityUnit.Ppt:
                    return "ppt";
                case UnitConverterSpecificGravityUnit.BasisPoint:
                    return "bp";
                case UnitConverterSpecificGravityUnit.PerTenThousand:
                    return "‱";
                case UnitConverterSpecificGravityUnit.APIGravity:
                    return "°API";
                case UnitConverterSpecificGravityUnit.BaumeLight:
                    return "°Bé light";
                case UnitConverterSpecificGravityUnit.BaumeHeavy:
                    return "°Bé heavy";
                case UnitConverterSpecificGravityUnit.Twaddell:
                    return "°Tw";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterSpecificGravityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpecificGravityUnit.Ratio:
                    return "Ratio";
                case UnitConverterSpecificGravityUnit.SpecificGravity:
                    return "Specific Gravity";
                case UnitConverterSpecificGravityUnit.RelativeDensity:
                    return "Relative Density";
                case UnitConverterSpecificGravityUnit.Percent:
                    return "Percent";
                case UnitConverterSpecificGravityUnit.PerMille:
                    return "Per Mille";
                case UnitConverterSpecificGravityUnit.Ppm:
                    return "Parts Per Million";
                case UnitConverterSpecificGravityUnit.Ppb:
                    return "Parts Per Billion";
                case UnitConverterSpecificGravityUnit.Ppt:
                    return "Parts Per Trillion";
                case UnitConverterSpecificGravityUnit.BasisPoint:
                    return "Basis Point";
                case UnitConverterSpecificGravityUnit.PerTenThousand:
                    return "Per Ten Thousand";
                case UnitConverterSpecificGravityUnit.APIGravity:
                    return "API Gravity";
                case UnitConverterSpecificGravityUnit.BaumeLight:
                    return "Baumé Light";
                case UnitConverterSpecificGravityUnit.BaumeHeavy:
                    return "Baumé Heavy";
                case UnitConverterSpecificGravityUnit.Twaddell:
                    return "Twaddell";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterSpecificGravityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterSpecificGravityUnit.Ratio:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterSpecificGravityUnit.SpecificGravity:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterSpecificGravityUnit.RelativeDensity:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterSpecificGravityUnit.Percent:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterSpecificGravityUnit.PerMille:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterSpecificGravityUnit.Ppm:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterSpecificGravityUnit.Ppb:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterSpecificGravityUnit.Ppt:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterSpecificGravityUnit.BasisPoint:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterSpecificGravityUnit.PerTenThousand:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterSpecificGravityUnit.APIGravity:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterSpecificGravityUnit.BaumeLight:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterSpecificGravityUnit.BaumeHeavy:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterSpecificGravityUnit.Twaddell:
                    return UnitConverterUnitSystem.Engineering;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterSpecificGravityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterSpecificGravityUnit.Ratio, UnitConverterSpecificGravityUnit.SpecificGravity, UnitConverterSpecificGravityUnit.RelativeDensity, UnitConverterSpecificGravityUnit.Percent, UnitConverterSpecificGravityUnit.PerMille, UnitConverterSpecificGravityUnit.Ppm, UnitConverterSpecificGravityUnit.Ppb, UnitConverterSpecificGravityUnit.Ppt, UnitConverterSpecificGravityUnit.BasisPoint, UnitConverterSpecificGravityUnit.PerTenThousand };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterSpecificGravityUnit.APIGravity, UnitConverterSpecificGravityUnit.BaumeLight, UnitConverterSpecificGravityUnit.BaumeHeavy, UnitConverterSpecificGravityUnit.Twaddell };
                default:
                    return new[] { UnitConverterSpecificGravityUnit.Ratio, UnitConverterSpecificGravityUnit.SpecificGravity, UnitConverterSpecificGravityUnit.RelativeDensity, UnitConverterSpecificGravityUnit.Percent, UnitConverterSpecificGravityUnit.PerMille, UnitConverterSpecificGravityUnit.Ppm, UnitConverterSpecificGravityUnit.Ppb, UnitConverterSpecificGravityUnit.Ppt, UnitConverterSpecificGravityUnit.BasisPoint, UnitConverterSpecificGravityUnit.PerTenThousand, UnitConverterSpecificGravityUnit.APIGravity, UnitConverterSpecificGravityUnit.BaumeLight, UnitConverterSpecificGravityUnit.BaumeHeavy, UnitConverterSpecificGravityUnit.Twaddell };
            }
        }
    }
}
