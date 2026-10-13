namespace UnitTools.MagneticField
{
    using UnitTools.MagneticField.Metric;
    using UnitTools.MagneticField.Common;
    using UnitTools.MagneticField.Scientific;

    public enum UnitToolsMagneticFieldUnit
    {
        Nanotesla = 0,
        Microtesla = 1,
        Millitesla = 2,
        Tesla = 3,
        Gauss = 4,
        Picotesla = 5,
        Kilotesla = 6,
        Megatesla = 7,
        Gamma = 8,
        LinePerSquareCentimeter = 9,
        Microgauss = 10,
        Milligauss = 11,
        Kilogauss = 12,
        Megagauss = 13,
        OerstedVacuumEquivalent = 14,
    }

    public static class UnitToolsMagneticField
    {
        public static double Convert(double value, UnitToolsMagneticFieldUnit from, UnitToolsMagneticFieldUnit to)
        {
            double baseValue = ToTesla(value, from);
            return FromTesla(baseValue, to);
        }

        public static double ToTesla(double value, UnitToolsMagneticFieldUnit from)
        {
            switch (from)
            {
                case UnitToolsMagneticFieldUnit.Nanotesla:
                    return UnitToolsMetricMagneticField.NanoteslaToTesla(value);
                case UnitToolsMagneticFieldUnit.Microtesla:
                    return UnitToolsMetricMagneticField.MicroteslaToTesla(value);
                case UnitToolsMagneticFieldUnit.Millitesla:
                    return UnitToolsMetricMagneticField.MilliteslaToTesla(value);
                case UnitToolsMagneticFieldUnit.Tesla:
                    return UnitToolsMetricMagneticField.TeslaToTesla(value);
                case UnitToolsMagneticFieldUnit.Gauss:
                    return UnitToolsCommonMagneticField.GaussToTesla(value);
                case UnitToolsMagneticFieldUnit.Picotesla:
                    return UnitToolsMetricMagneticField.PicoteslaToTesla(value);
                case UnitToolsMagneticFieldUnit.Kilotesla:
                    return UnitToolsMetricMagneticField.KiloteslaToTesla(value);
                case UnitToolsMagneticFieldUnit.Megatesla:
                    return UnitToolsMetricMagneticField.MegateslaToTesla(value);
                case UnitToolsMagneticFieldUnit.Gamma:
                    return UnitToolsScientificMagneticField.GammaToTesla(value);
                case UnitToolsMagneticFieldUnit.LinePerSquareCentimeter:
                    return UnitToolsScientificMagneticField.LinePerSquareCentimeterToTesla(value);
                case UnitToolsMagneticFieldUnit.Microgauss:
                    return UnitToolsScientificMagneticField.MicrogaussToTesla(value);
                case UnitToolsMagneticFieldUnit.Milligauss:
                    return UnitToolsScientificMagneticField.MilligaussToTesla(value);
                case UnitToolsMagneticFieldUnit.Kilogauss:
                    return UnitToolsScientificMagneticField.KilogaussToTesla(value);
                case UnitToolsMagneticFieldUnit.Megagauss:
                    return UnitToolsScientificMagneticField.MegagaussToTesla(value);
                case UnitToolsMagneticFieldUnit.OerstedVacuumEquivalent:
                    return UnitToolsScientificMagneticField.OerstedVacuumEquivalentToTesla(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported magnetic field unit.");
            }
        }

        public static double FromTesla(double baseValue, UnitToolsMagneticFieldUnit to)
        {
            switch (to)
            {
                case UnitToolsMagneticFieldUnit.Nanotesla:
                    return UnitToolsMetricMagneticField.TeslaToNanotesla(baseValue);
                case UnitToolsMagneticFieldUnit.Microtesla:
                    return UnitToolsMetricMagneticField.TeslaToMicrotesla(baseValue);
                case UnitToolsMagneticFieldUnit.Millitesla:
                    return UnitToolsMetricMagneticField.TeslaToMillitesla(baseValue);
                case UnitToolsMagneticFieldUnit.Tesla:
                    return UnitToolsMetricMagneticField.TeslaToTesla(baseValue);
                case UnitToolsMagneticFieldUnit.Gauss:
                    return UnitToolsCommonMagneticField.TeslaToGauss(baseValue);
                case UnitToolsMagneticFieldUnit.Picotesla:
                    return UnitToolsMetricMagneticField.TeslaToPicotesla(baseValue);
                case UnitToolsMagneticFieldUnit.Kilotesla:
                    return UnitToolsMetricMagneticField.TeslaToKilotesla(baseValue);
                case UnitToolsMagneticFieldUnit.Megatesla:
                    return UnitToolsMetricMagneticField.TeslaToMegatesla(baseValue);
                case UnitToolsMagneticFieldUnit.Gamma:
                    return UnitToolsScientificMagneticField.TeslaToGamma(baseValue);
                case UnitToolsMagneticFieldUnit.LinePerSquareCentimeter:
                    return UnitToolsScientificMagneticField.TeslaToLinePerSquareCentimeter(baseValue);
                case UnitToolsMagneticFieldUnit.Microgauss:
                    return UnitToolsScientificMagneticField.TeslaToMicrogauss(baseValue);
                case UnitToolsMagneticFieldUnit.Milligauss:
                    return UnitToolsScientificMagneticField.TeslaToMilligauss(baseValue);
                case UnitToolsMagneticFieldUnit.Kilogauss:
                    return UnitToolsScientificMagneticField.TeslaToKilogauss(baseValue);
                case UnitToolsMagneticFieldUnit.Megagauss:
                    return UnitToolsScientificMagneticField.TeslaToMegagauss(baseValue);
                case UnitToolsMagneticFieldUnit.OerstedVacuumEquivalent:
                    return UnitToolsScientificMagneticField.TeslaToOerstedVacuumEquivalent(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported magnetic field unit.");
            }
        }

        public static string GetSymbol(UnitToolsMagneticFieldUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMagneticFieldUnit.Nanotesla:
                    return "nT";
                case UnitToolsMagneticFieldUnit.Microtesla:
                    return "µT";
                case UnitToolsMagneticFieldUnit.Millitesla:
                    return "mT";
                case UnitToolsMagneticFieldUnit.Tesla:
                    return "T";
                case UnitToolsMagneticFieldUnit.Gauss:
                    return "G";
                case UnitToolsMagneticFieldUnit.Picotesla:
                    return "pT";
                case UnitToolsMagneticFieldUnit.Kilotesla:
                    return "kT";
                case UnitToolsMagneticFieldUnit.Megatesla:
                    return "MT";
                case UnitToolsMagneticFieldUnit.Gamma:
                    return "γ";
                case UnitToolsMagneticFieldUnit.LinePerSquareCentimeter:
                    return "line/cm²";
                case UnitToolsMagneticFieldUnit.Microgauss:
                    return "µG";
                case UnitToolsMagneticFieldUnit.Milligauss:
                    return "mG";
                case UnitToolsMagneticFieldUnit.Kilogauss:
                    return "kG";
                case UnitToolsMagneticFieldUnit.Megagauss:
                    return "MG";
                case UnitToolsMagneticFieldUnit.OerstedVacuumEquivalent:
                    return "Oe eq";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsMagneticFieldUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMagneticFieldUnit.Nanotesla:
                    return "nanotesla";
                case UnitToolsMagneticFieldUnit.Microtesla:
                    return "microtesla";
                case UnitToolsMagneticFieldUnit.Millitesla:
                    return "millitesla";
                case UnitToolsMagneticFieldUnit.Tesla:
                    return "tesla";
                case UnitToolsMagneticFieldUnit.Gauss:
                    return "gauss";
                case UnitToolsMagneticFieldUnit.Picotesla:
                    return "Picotesla";
                case UnitToolsMagneticFieldUnit.Kilotesla:
                    return "Kilotesla";
                case UnitToolsMagneticFieldUnit.Megatesla:
                    return "Megatesla";
                case UnitToolsMagneticFieldUnit.Gamma:
                    return "Gamma";
                case UnitToolsMagneticFieldUnit.LinePerSquareCentimeter:
                    return "Line Per Square Centimeter";
                case UnitToolsMagneticFieldUnit.Microgauss:
                    return "Microgauss";
                case UnitToolsMagneticFieldUnit.Milligauss:
                    return "Milligauss";
                case UnitToolsMagneticFieldUnit.Kilogauss:
                    return "Kilogauss";
                case UnitToolsMagneticFieldUnit.Megagauss:
                    return "Megagauss";
                case UnitToolsMagneticFieldUnit.OerstedVacuumEquivalent:
                    return "Oersted Vacuum Equivalent";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsMagneticFieldUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMagneticFieldUnit.Nanotesla:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFieldUnit.Microtesla:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFieldUnit.Millitesla:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFieldUnit.Tesla:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFieldUnit.Gauss:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsMagneticFieldUnit.Picotesla:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFieldUnit.Kilotesla:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFieldUnit.Megatesla:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMagneticFieldUnit.Gamma:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMagneticFieldUnit.LinePerSquareCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMagneticFieldUnit.Microgauss:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMagneticFieldUnit.Milligauss:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMagneticFieldUnit.Kilogauss:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMagneticFieldUnit.Megagauss:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsMagneticFieldUnit.OerstedVacuumEquivalent:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsMagneticFieldUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsMagneticFieldUnit.Nanotesla, UnitToolsMagneticFieldUnit.Microtesla, UnitToolsMagneticFieldUnit.Millitesla, UnitToolsMagneticFieldUnit.Tesla, UnitToolsMagneticFieldUnit.Picotesla, UnitToolsMagneticFieldUnit.Kilotesla, UnitToolsMagneticFieldUnit.Megatesla };
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsMagneticFieldUnit.Gauss };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsMagneticFieldUnit.Gamma, UnitToolsMagneticFieldUnit.LinePerSquareCentimeter, UnitToolsMagneticFieldUnit.Microgauss, UnitToolsMagneticFieldUnit.Milligauss, UnitToolsMagneticFieldUnit.Kilogauss, UnitToolsMagneticFieldUnit.Megagauss, UnitToolsMagneticFieldUnit.OerstedVacuumEquivalent };
                default:
                    return new[] { UnitToolsMagneticFieldUnit.Nanotesla, UnitToolsMagneticFieldUnit.Microtesla, UnitToolsMagneticFieldUnit.Millitesla, UnitToolsMagneticFieldUnit.Tesla, UnitToolsMagneticFieldUnit.Gauss, UnitToolsMagneticFieldUnit.Picotesla, UnitToolsMagneticFieldUnit.Kilotesla, UnitToolsMagneticFieldUnit.Megatesla, UnitToolsMagneticFieldUnit.Gamma, UnitToolsMagneticFieldUnit.LinePerSquareCentimeter, UnitToolsMagneticFieldUnit.Microgauss, UnitToolsMagneticFieldUnit.Milligauss, UnitToolsMagneticFieldUnit.Kilogauss, UnitToolsMagneticFieldUnit.Megagauss, UnitToolsMagneticFieldUnit.OerstedVacuumEquivalent };
            }
        }
    }
}
