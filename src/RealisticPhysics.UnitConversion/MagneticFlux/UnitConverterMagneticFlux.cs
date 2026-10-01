namespace RealisticPhysics.UnitConversion.MagneticFlux
{
    using RealisticPhysics.UnitConversion.MagneticFlux.Metric;
    using RealisticPhysics.UnitConversion.MagneticFlux.Common;
    using RealisticPhysics.UnitConversion.MagneticFlux.Scientific;

    public enum UnitConverterMagneticFluxUnit
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

    public static class UnitConverterMagneticFlux
    {
        public static double Convert(double value, UnitConverterMagneticFluxUnit from, UnitConverterMagneticFluxUnit to)
        {
            double baseValue = ToWeber(value, from);
            return FromWeber(baseValue, to);
        }

        public static double ToWeber(double value, UnitConverterMagneticFluxUnit from)
        {
            switch (from)
            {
                case UnitConverterMagneticFluxUnit.Nanoweber:
                    return UnitConverterMetricMagneticFlux.NanoweberToWeber(value);
                case UnitConverterMagneticFluxUnit.Microweber:
                    return UnitConverterMetricMagneticFlux.MicroweberToWeber(value);
                case UnitConverterMagneticFluxUnit.Milliweber:
                    return UnitConverterMetricMagneticFlux.MilliweberToWeber(value);
                case UnitConverterMagneticFluxUnit.Weber:
                    return UnitConverterMetricMagneticFlux.WeberToWeber(value);
                case UnitConverterMagneticFluxUnit.Maxwell:
                    return UnitConverterCommonMagneticFlux.MaxwellToWeber(value);
                case UnitConverterMagneticFluxUnit.Picoweber:
                    return UnitConverterMetricMagneticFlux.PicoweberToWeber(value);
                case UnitConverterMagneticFluxUnit.Femtoweber:
                    return UnitConverterMetricMagneticFlux.FemtoweberToWeber(value);
                case UnitConverterMagneticFluxUnit.Kiloweber:
                    return UnitConverterMetricMagneticFlux.KiloweberToWeber(value);
                case UnitConverterMagneticFluxUnit.Megaweber:
                    return UnitConverterMetricMagneticFlux.MegaweberToWeber(value);
                case UnitConverterMagneticFluxUnit.UnitPole:
                    return UnitConverterScientificMagneticFlux.UnitPoleToWeber(value);
                case UnitConverterMagneticFluxUnit.Attoweber:
                    return UnitConverterMetricMagneticFlux.AttoweberToWeber(value);
                case UnitConverterMagneticFluxUnit.Kilomaxwell:
                    return UnitConverterScientificMagneticFlux.KilomaxwellToWeber(value);
                case UnitConverterMagneticFluxUnit.Megamaxwell:
                    return UnitConverterScientificMagneticFlux.MegamaxwellToWeber(value);
                case UnitConverterMagneticFluxUnit.Line:
                    return UnitConverterScientificMagneticFlux.LineToWeber(value);
                case UnitConverterMagneticFluxUnit.VoltSecond:
                    return UnitConverterMetricMagneticFlux.VoltSecondToWeber(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported magnetic flux unit.");
            }
        }

        public static double FromWeber(double baseValue, UnitConverterMagneticFluxUnit to)
        {
            switch (to)
            {
                case UnitConverterMagneticFluxUnit.Nanoweber:
                    return UnitConverterMetricMagneticFlux.WeberToNanoweber(baseValue);
                case UnitConverterMagneticFluxUnit.Microweber:
                    return UnitConverterMetricMagneticFlux.WeberToMicroweber(baseValue);
                case UnitConverterMagneticFluxUnit.Milliweber:
                    return UnitConverterMetricMagneticFlux.WeberToMilliweber(baseValue);
                case UnitConverterMagneticFluxUnit.Weber:
                    return UnitConverterMetricMagneticFlux.WeberToWeber(baseValue);
                case UnitConverterMagneticFluxUnit.Maxwell:
                    return UnitConverterCommonMagneticFlux.WeberToMaxwell(baseValue);
                case UnitConverterMagneticFluxUnit.Picoweber:
                    return UnitConverterMetricMagneticFlux.WeberToPicoweber(baseValue);
                case UnitConverterMagneticFluxUnit.Femtoweber:
                    return UnitConverterMetricMagneticFlux.WeberToFemtoweber(baseValue);
                case UnitConverterMagneticFluxUnit.Kiloweber:
                    return UnitConverterMetricMagneticFlux.WeberToKiloweber(baseValue);
                case UnitConverterMagneticFluxUnit.Megaweber:
                    return UnitConverterMetricMagneticFlux.WeberToMegaweber(baseValue);
                case UnitConverterMagneticFluxUnit.UnitPole:
                    return UnitConverterScientificMagneticFlux.WeberToUnitPole(baseValue);
                case UnitConverterMagneticFluxUnit.Attoweber:
                    return UnitConverterMetricMagneticFlux.WeberToAttoweber(baseValue);
                case UnitConverterMagneticFluxUnit.Kilomaxwell:
                    return UnitConverterScientificMagneticFlux.WeberToKilomaxwell(baseValue);
                case UnitConverterMagneticFluxUnit.Megamaxwell:
                    return UnitConverterScientificMagneticFlux.WeberToMegamaxwell(baseValue);
                case UnitConverterMagneticFluxUnit.Line:
                    return UnitConverterScientificMagneticFlux.WeberToLine(baseValue);
                case UnitConverterMagneticFluxUnit.VoltSecond:
                    return UnitConverterMetricMagneticFlux.WeberToVoltSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported magnetic flux unit.");
            }
        }

        public static string GetSymbol(UnitConverterMagneticFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMagneticFluxUnit.Nanoweber:
                    return "nWb";
                case UnitConverterMagneticFluxUnit.Microweber:
                    return "µWb";
                case UnitConverterMagneticFluxUnit.Milliweber:
                    return "mWb";
                case UnitConverterMagneticFluxUnit.Weber:
                    return "Wb";
                case UnitConverterMagneticFluxUnit.Maxwell:
                    return "Mx";
                case UnitConverterMagneticFluxUnit.Picoweber:
                    return "pWb";
                case UnitConverterMagneticFluxUnit.Femtoweber:
                    return "fWb";
                case UnitConverterMagneticFluxUnit.Kiloweber:
                    return "kWb";
                case UnitConverterMagneticFluxUnit.Megaweber:
                    return "MWb";
                case UnitConverterMagneticFluxUnit.UnitPole:
                    return "unit pole";
                case UnitConverterMagneticFluxUnit.Attoweber:
                    return "aWb";
                case UnitConverterMagneticFluxUnit.Kilomaxwell:
                    return "kMx";
                case UnitConverterMagneticFluxUnit.Megamaxwell:
                    return "MMx";
                case UnitConverterMagneticFluxUnit.Line:
                    return "line";
                case UnitConverterMagneticFluxUnit.VoltSecond:
                    return "V·s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterMagneticFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMagneticFluxUnit.Nanoweber:
                    return "nanoweber";
                case UnitConverterMagneticFluxUnit.Microweber:
                    return "microweber";
                case UnitConverterMagneticFluxUnit.Milliweber:
                    return "milliweber";
                case UnitConverterMagneticFluxUnit.Weber:
                    return "weber";
                case UnitConverterMagneticFluxUnit.Maxwell:
                    return "maxwell";
                case UnitConverterMagneticFluxUnit.Picoweber:
                    return "Picoweber";
                case UnitConverterMagneticFluxUnit.Femtoweber:
                    return "Femtoweber";
                case UnitConverterMagneticFluxUnit.Kiloweber:
                    return "Kiloweber";
                case UnitConverterMagneticFluxUnit.Megaweber:
                    return "Megaweber";
                case UnitConverterMagneticFluxUnit.UnitPole:
                    return "Unit Pole";
                case UnitConverterMagneticFluxUnit.Attoweber:
                    return "Attoweber";
                case UnitConverterMagneticFluxUnit.Kilomaxwell:
                    return "Kilomaxwell";
                case UnitConverterMagneticFluxUnit.Megamaxwell:
                    return "Megamaxwell";
                case UnitConverterMagneticFluxUnit.Line:
                    return "Line";
                case UnitConverterMagneticFluxUnit.VoltSecond:
                    return "Volt Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterMagneticFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMagneticFluxUnit.Nanoweber:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFluxUnit.Microweber:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFluxUnit.Milliweber:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFluxUnit.Weber:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFluxUnit.Maxwell:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterMagneticFluxUnit.Picoweber:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFluxUnit.Femtoweber:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFluxUnit.Kiloweber:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFluxUnit.Megaweber:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFluxUnit.UnitPole:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMagneticFluxUnit.Attoweber:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFluxUnit.Kilomaxwell:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMagneticFluxUnit.Megamaxwell:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMagneticFluxUnit.Line:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMagneticFluxUnit.VoltSecond:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterMagneticFluxUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterMagneticFluxUnit.Nanoweber, UnitConverterMagneticFluxUnit.Microweber, UnitConverterMagneticFluxUnit.Milliweber, UnitConverterMagneticFluxUnit.Weber, UnitConverterMagneticFluxUnit.Picoweber, UnitConverterMagneticFluxUnit.Femtoweber, UnitConverterMagneticFluxUnit.Kiloweber, UnitConverterMagneticFluxUnit.Megaweber, UnitConverterMagneticFluxUnit.Attoweber, UnitConverterMagneticFluxUnit.VoltSecond };
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterMagneticFluxUnit.Maxwell };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterMagneticFluxUnit.UnitPole, UnitConverterMagneticFluxUnit.Kilomaxwell, UnitConverterMagneticFluxUnit.Megamaxwell, UnitConverterMagneticFluxUnit.Line };
                default:
                    return new[] { UnitConverterMagneticFluxUnit.Nanoweber, UnitConverterMagneticFluxUnit.Microweber, UnitConverterMagneticFluxUnit.Milliweber, UnitConverterMagneticFluxUnit.Weber, UnitConverterMagneticFluxUnit.Maxwell, UnitConverterMagneticFluxUnit.Picoweber, UnitConverterMagneticFluxUnit.Femtoweber, UnitConverterMagneticFluxUnit.Kiloweber, UnitConverterMagneticFluxUnit.Megaweber, UnitConverterMagneticFluxUnit.UnitPole, UnitConverterMagneticFluxUnit.Attoweber, UnitConverterMagneticFluxUnit.Kilomaxwell, UnitConverterMagneticFluxUnit.Megamaxwell, UnitConverterMagneticFluxUnit.Line, UnitConverterMagneticFluxUnit.VoltSecond };
            }
        }
    }
}
