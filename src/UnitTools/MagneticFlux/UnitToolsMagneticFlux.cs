namespace UnitTools.MagneticFlux
{
    using UnitTools.MagneticFlux.Metric;
    using UnitTools.MagneticFlux.Common;
    using UnitTools.MagneticFlux.Scientific;

    public enum UnitToolsMagneticFluxUnit
    {
        Nanoweber = 0,
        Microweber = 1,
        Milliweber = 2,
        Weber = 3,
        Maxwell = 4,
        Picoweber = 5,
        Femtoweber = 6,
        Kiloweber = 7,
        Megaweber = 8,
        UnitPole = 9,
        Attoweber = 10,
        Kilomaxwell = 11,
        Megamaxwell = 12,
        Line = 13,
        VoltSecond = 14,
    }

    public static class UnitToolsMagneticFlux
    {
        public static double Convert(double value, UnitToolsMagneticFluxUnit from, UnitToolsMagneticFluxUnit to)
        {
            double baseValue = ToWeber(value, from);
            return FromWeber(baseValue, to);
        }

        public static double ToWeber(double value, UnitToolsMagneticFluxUnit from)
        {
            switch (from)
            {
                case UnitToolsMagneticFluxUnit.Nanoweber:
                    return UnitToolsMetricMagneticFlux.NanoweberToWeber(value);
                case UnitToolsMagneticFluxUnit.Microweber:
                    return UnitToolsMetricMagneticFlux.MicroweberToWeber(value);
                case UnitToolsMagneticFluxUnit.Milliweber:
                    return UnitToolsMetricMagneticFlux.MilliweberToWeber(value);
                case UnitToolsMagneticFluxUnit.Weber:
                    return UnitToolsMetricMagneticFlux.WeberToWeber(value);
                case UnitToolsMagneticFluxUnit.Maxwell:
                    return UnitToolsCommonMagneticFlux.MaxwellToWeber(value);
                case UnitToolsMagneticFluxUnit.Picoweber:
                    return UnitToolsMetricMagneticFlux.PicoweberToWeber(value);
                case UnitToolsMagneticFluxUnit.Femtoweber:
                    return UnitToolsMetricMagneticFlux.FemtoweberToWeber(value);
                case UnitToolsMagneticFluxUnit.Kiloweber:
                    return UnitToolsMetricMagneticFlux.KiloweberToWeber(value);
                case UnitToolsMagneticFluxUnit.Megaweber:
                    return UnitToolsMetricMagneticFlux.MegaweberToWeber(value);
                case UnitToolsMagneticFluxUnit.UnitPole:
                    return UnitToolsScientificMagneticFlux.UnitPoleToWeber(value);
                case UnitToolsMagneticFluxUnit.Attoweber:
                    return UnitToolsMetricMagneticFlux.AttoweberToWeber(value);
                case UnitToolsMagneticFluxUnit.Kilomaxwell:
                    return UnitToolsScientificMagneticFlux.KilomaxwellToWeber(value);
                case UnitToolsMagneticFluxUnit.Megamaxwell:
                    return UnitToolsScientificMagneticFlux.MegamaxwellToWeber(value);
                case UnitToolsMagneticFluxUnit.Line:
                    return UnitToolsScientificMagneticFlux.LineToWeber(value);
                case UnitToolsMagneticFluxUnit.VoltSecond:
                    return UnitToolsMetricMagneticFlux.VoltSecondToWeber(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported magnetic flux unit.");
            }
        }

        public static double FromWeber(double baseValue, UnitToolsMagneticFluxUnit to)
        {
            switch (to)
            {
                case UnitToolsMagneticFluxUnit.Nanoweber:
                    return UnitToolsMetricMagneticFlux.WeberToNanoweber(baseValue);
                case UnitToolsMagneticFluxUnit.Microweber:
                    return UnitToolsMetricMagneticFlux.WeberToMicroweber(baseValue);
                case UnitToolsMagneticFluxUnit.Milliweber:
                    return UnitToolsMetricMagneticFlux.WeberToMilliweber(baseValue);
                case UnitToolsMagneticFluxUnit.Weber:
                    return UnitToolsMetricMagneticFlux.WeberToWeber(baseValue);
                case UnitToolsMagneticFluxUnit.Maxwell:
                    return UnitToolsCommonMagneticFlux.WeberToMaxwell(baseValue);
                case UnitToolsMagneticFluxUnit.Picoweber:
                    return UnitToolsMetricMagneticFlux.WeberToPicoweber(baseValue);
                case UnitToolsMagneticFluxUnit.Femtoweber:
                    return UnitToolsMetricMagneticFlux.WeberToFemtoweber(baseValue);
                case UnitToolsMagneticFluxUnit.Kiloweber:
                    return UnitToolsMetricMagneticFlux.WeberToKiloweber(baseValue);
                case UnitToolsMagneticFluxUnit.Megaweber:
                    return UnitToolsMetricMagneticFlux.WeberToMegaweber(baseValue);
                case UnitToolsMagneticFluxUnit.UnitPole:
                    return UnitToolsScientificMagneticFlux.WeberToUnitPole(baseValue);
                case UnitToolsMagneticFluxUnit.Attoweber:
                    return UnitToolsMetricMagneticFlux.WeberToAttoweber(baseValue);
                case UnitToolsMagneticFluxUnit.Kilomaxwell:
                    return UnitToolsScientificMagneticFlux.WeberToKilomaxwell(baseValue);
                case UnitToolsMagneticFluxUnit.Megamaxwell:
                    return UnitToolsScientificMagneticFlux.WeberToMegamaxwell(baseValue);
                case UnitToolsMagneticFluxUnit.Line:
                    return UnitToolsScientificMagneticFlux.WeberToLine(baseValue);
                case UnitToolsMagneticFluxUnit.VoltSecond:
                    return UnitToolsMetricMagneticFlux.WeberToVoltSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported magnetic flux unit.");
            }
        }

        public static string GetSymbol(UnitToolsMagneticFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMagneticFluxUnit.Nanoweber:
                    return "nWb";
                case UnitToolsMagneticFluxUnit.Microweber:
                    return "µWb";
                case UnitToolsMagneticFluxUnit.Milliweber:
                    return "mWb";
                case UnitToolsMagneticFluxUnit.Weber:
                    return "Wb";
                case UnitToolsMagneticFluxUnit.Maxwell:
                    return "Mx";
                case UnitToolsMagneticFluxUnit.Picoweber:
                    return "pWb";
                case UnitToolsMagneticFluxUnit.Femtoweber:
                    return "fWb";
                case UnitToolsMagneticFluxUnit.Kiloweber:
                    return "kWb";
                case UnitToolsMagneticFluxUnit.Megaweber:
                    return "MWb";
                case UnitToolsMagneticFluxUnit.UnitPole:
                    return "unit pole";
                case UnitToolsMagneticFluxUnit.Attoweber:
                    return "aWb";
                case UnitToolsMagneticFluxUnit.Kilomaxwell:
                    return "kMx";
                case UnitToolsMagneticFluxUnit.Megamaxwell:
                    return "MMx";
                case UnitToolsMagneticFluxUnit.Line:
                    return "line";
                case UnitToolsMagneticFluxUnit.VoltSecond:
                    return "V·s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsMagneticFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMagneticFluxUnit.Nanoweber:
                    return "nanoweber";
                case UnitToolsMagneticFluxUnit.Microweber:
                    return "microweber";
                case UnitToolsMagneticFluxUnit.Milliweber:
                    return "milliweber";
                case UnitToolsMagneticFluxUnit.Weber:
                    return "weber";
                case UnitToolsMagneticFluxUnit.Maxwell:
                    return "maxwell";
                case UnitToolsMagneticFluxUnit.Picoweber:
                    return "Picoweber";
                case UnitToolsMagneticFluxUnit.Femtoweber:
                    return "Femtoweber";
                case UnitToolsMagneticFluxUnit.Kiloweber:
                    return "Kiloweber";
                case UnitToolsMagneticFluxUnit.Megaweber:
                    return "Megaweber";
                case UnitToolsMagneticFluxUnit.UnitPole:
                    return "Unit Pole";
                case UnitToolsMagneticFluxUnit.Attoweber:
                    return "Attoweber";
                case UnitToolsMagneticFluxUnit.Kilomaxwell:
                    return "Kilomaxwell";
                case UnitToolsMagneticFluxUnit.Megamaxwell:
                    return "Megamaxwell";
                case UnitToolsMagneticFluxUnit.Line:
                    return "Line";
                case UnitToolsMagneticFluxUnit.VoltSecond:
                    return "Volt Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsMagneticFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMagneticFluxUnit.Nanoweber:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFluxUnit.Microweber:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFluxUnit.Milliweber:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFluxUnit.Weber:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFluxUnit.Maxwell:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsMagneticFluxUnit.Picoweber:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFluxUnit.Femtoweber:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFluxUnit.Kiloweber:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFluxUnit.Megaweber:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFluxUnit.UnitPole:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMagneticFluxUnit.Attoweber:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFluxUnit.Kilomaxwell:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMagneticFluxUnit.Megamaxwell:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMagneticFluxUnit.Line:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMagneticFluxUnit.VoltSecond:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsMagneticFluxUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsMagneticFluxUnit.Nanoweber, UnitToolsMagneticFluxUnit.Microweber, UnitToolsMagneticFluxUnit.Milliweber, UnitToolsMagneticFluxUnit.Weber, UnitToolsMagneticFluxUnit.Picoweber, UnitToolsMagneticFluxUnit.Femtoweber, UnitToolsMagneticFluxUnit.Kiloweber, UnitToolsMagneticFluxUnit.Megaweber, UnitToolsMagneticFluxUnit.Attoweber, UnitToolsMagneticFluxUnit.VoltSecond };
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsMagneticFluxUnit.Maxwell };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsMagneticFluxUnit.UnitPole, UnitToolsMagneticFluxUnit.Kilomaxwell, UnitToolsMagneticFluxUnit.Megamaxwell, UnitToolsMagneticFluxUnit.Line };
                default:
                    return new[] { UnitToolsMagneticFluxUnit.Nanoweber, UnitToolsMagneticFluxUnit.Microweber, UnitToolsMagneticFluxUnit.Milliweber, UnitToolsMagneticFluxUnit.Weber, UnitToolsMagneticFluxUnit.Maxwell, UnitToolsMagneticFluxUnit.Picoweber, UnitToolsMagneticFluxUnit.Femtoweber, UnitToolsMagneticFluxUnit.Kiloweber, UnitToolsMagneticFluxUnit.Megaweber, UnitToolsMagneticFluxUnit.UnitPole, UnitToolsMagneticFluxUnit.Attoweber, UnitToolsMagneticFluxUnit.Kilomaxwell, UnitToolsMagneticFluxUnit.Megamaxwell, UnitToolsMagneticFluxUnit.Line, UnitToolsMagneticFluxUnit.VoltSecond };
            }
        }
    }
}
