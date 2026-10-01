namespace RealisticPhysics.UnitConversion.MagneticField
{
    using RealisticPhysics.UnitConversion.MagneticField.Metric;
    using RealisticPhysics.UnitConversion.MagneticField.Common;
    using RealisticPhysics.UnitConversion.MagneticField.Scientific;

    public enum UnitConverterMagneticFieldUnit
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

    public static class UnitConverterMagneticField
    {
        public static double Convert(double value, UnitConverterMagneticFieldUnit from, UnitConverterMagneticFieldUnit to)
        {
            double baseValue = ToTesla(value, from);
            return FromTesla(baseValue, to);
        }

        public static double ToTesla(double value, UnitConverterMagneticFieldUnit from)
        {
            switch (from)
            {
                case UnitConverterMagneticFieldUnit.Nanotesla:
                    return UnitConverterMetricMagneticField.NanoteslaToTesla(value);
                case UnitConverterMagneticFieldUnit.Microtesla:
                    return UnitConverterMetricMagneticField.MicroteslaToTesla(value);
                case UnitConverterMagneticFieldUnit.Millitesla:
                    return UnitConverterMetricMagneticField.MilliteslaToTesla(value);
                case UnitConverterMagneticFieldUnit.Tesla:
                    return UnitConverterMetricMagneticField.TeslaToTesla(value);
                case UnitConverterMagneticFieldUnit.Gauss:
                    return UnitConverterCommonMagneticField.GaussToTesla(value);
                case UnitConverterMagneticFieldUnit.Picotesla:
                    return UnitConverterMetricMagneticField.PicoteslaToTesla(value);
                case UnitConverterMagneticFieldUnit.Kilotesla:
                    return UnitConverterMetricMagneticField.KiloteslaToTesla(value);
                case UnitConverterMagneticFieldUnit.Megatesla:
                    return UnitConverterMetricMagneticField.MegateslaToTesla(value);
                case UnitConverterMagneticFieldUnit.Gamma:
                    return UnitConverterScientificMagneticField.GammaToTesla(value);
                case UnitConverterMagneticFieldUnit.LinePerSquareCentimeter:
                    return UnitConverterScientificMagneticField.LinePerSquareCentimeterToTesla(value);
                case UnitConverterMagneticFieldUnit.Microgauss:
                    return UnitConverterScientificMagneticField.MicrogaussToTesla(value);
                case UnitConverterMagneticFieldUnit.Milligauss:
                    return UnitConverterScientificMagneticField.MilligaussToTesla(value);
                case UnitConverterMagneticFieldUnit.Kilogauss:
                    return UnitConverterScientificMagneticField.KilogaussToTesla(value);
                case UnitConverterMagneticFieldUnit.Megagauss:
                    return UnitConverterScientificMagneticField.MegagaussToTesla(value);
                case UnitConverterMagneticFieldUnit.OerstedVacuumEquivalent:
                    return UnitConverterScientificMagneticField.OerstedVacuumEquivalentToTesla(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported magnetic field unit.");
            }
        }

        public static double FromTesla(double baseValue, UnitConverterMagneticFieldUnit to)
        {
            switch (to)
            {
                case UnitConverterMagneticFieldUnit.Nanotesla:
                    return UnitConverterMetricMagneticField.TeslaToNanotesla(baseValue);
                case UnitConverterMagneticFieldUnit.Microtesla:
                    return UnitConverterMetricMagneticField.TeslaToMicrotesla(baseValue);
                case UnitConverterMagneticFieldUnit.Millitesla:
                    return UnitConverterMetricMagneticField.TeslaToMillitesla(baseValue);
                case UnitConverterMagneticFieldUnit.Tesla:
                    return UnitConverterMetricMagneticField.TeslaToTesla(baseValue);
                case UnitConverterMagneticFieldUnit.Gauss:
                    return UnitConverterCommonMagneticField.TeslaToGauss(baseValue);
                case UnitConverterMagneticFieldUnit.Picotesla:
                    return UnitConverterMetricMagneticField.TeslaToPicotesla(baseValue);
                case UnitConverterMagneticFieldUnit.Kilotesla:
                    return UnitConverterMetricMagneticField.TeslaToKilotesla(baseValue);
                case UnitConverterMagneticFieldUnit.Megatesla:
                    return UnitConverterMetricMagneticField.TeslaToMegatesla(baseValue);
                case UnitConverterMagneticFieldUnit.Gamma:
                    return UnitConverterScientificMagneticField.TeslaToGamma(baseValue);
                case UnitConverterMagneticFieldUnit.LinePerSquareCentimeter:
                    return UnitConverterScientificMagneticField.TeslaToLinePerSquareCentimeter(baseValue);
                case UnitConverterMagneticFieldUnit.Microgauss:
                    return UnitConverterScientificMagneticField.TeslaToMicrogauss(baseValue);
                case UnitConverterMagneticFieldUnit.Milligauss:
                    return UnitConverterScientificMagneticField.TeslaToMilligauss(baseValue);
                case UnitConverterMagneticFieldUnit.Kilogauss:
                    return UnitConverterScientificMagneticField.TeslaToKilogauss(baseValue);
                case UnitConverterMagneticFieldUnit.Megagauss:
                    return UnitConverterScientificMagneticField.TeslaToMegagauss(baseValue);
                case UnitConverterMagneticFieldUnit.OerstedVacuumEquivalent:
                    return UnitConverterScientificMagneticField.TeslaToOerstedVacuumEquivalent(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported magnetic field unit.");
            }
        }

        public static string GetSymbol(UnitConverterMagneticFieldUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMagneticFieldUnit.Nanotesla:
                    return "nT";
                case UnitConverterMagneticFieldUnit.Microtesla:
                    return "µT";
                case UnitConverterMagneticFieldUnit.Millitesla:
                    return "mT";
                case UnitConverterMagneticFieldUnit.Tesla:
                    return "T";
                case UnitConverterMagneticFieldUnit.Gauss:
                    return "G";
                case UnitConverterMagneticFieldUnit.Picotesla:
                    return "pT";
                case UnitConverterMagneticFieldUnit.Kilotesla:
                    return "kT";
                case UnitConverterMagneticFieldUnit.Megatesla:
                    return "MT";
                case UnitConverterMagneticFieldUnit.Gamma:
                    return "γ";
                case UnitConverterMagneticFieldUnit.LinePerSquareCentimeter:
                    return "line/cm²";
                case UnitConverterMagneticFieldUnit.Microgauss:
                    return "µG";
                case UnitConverterMagneticFieldUnit.Milligauss:
                    return "mG";
                case UnitConverterMagneticFieldUnit.Kilogauss:
                    return "kG";
                case UnitConverterMagneticFieldUnit.Megagauss:
                    return "MG";
                case UnitConverterMagneticFieldUnit.OerstedVacuumEquivalent:
                    return "Oe eq";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterMagneticFieldUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMagneticFieldUnit.Nanotesla:
                    return "nanotesla";
                case UnitConverterMagneticFieldUnit.Microtesla:
                    return "microtesla";
                case UnitConverterMagneticFieldUnit.Millitesla:
                    return "millitesla";
                case UnitConverterMagneticFieldUnit.Tesla:
                    return "tesla";
                case UnitConverterMagneticFieldUnit.Gauss:
                    return "gauss";
                case UnitConverterMagneticFieldUnit.Picotesla:
                    return "Picotesla";
                case UnitConverterMagneticFieldUnit.Kilotesla:
                    return "Kilotesla";
                case UnitConverterMagneticFieldUnit.Megatesla:
                    return "Megatesla";
                case UnitConverterMagneticFieldUnit.Gamma:
                    return "Gamma";
                case UnitConverterMagneticFieldUnit.LinePerSquareCentimeter:
                    return "Line Per Square Centimeter";
                case UnitConverterMagneticFieldUnit.Microgauss:
                    return "Microgauss";
                case UnitConverterMagneticFieldUnit.Milligauss:
                    return "Milligauss";
                case UnitConverterMagneticFieldUnit.Kilogauss:
                    return "Kilogauss";
                case UnitConverterMagneticFieldUnit.Megagauss:
                    return "Megagauss";
                case UnitConverterMagneticFieldUnit.OerstedVacuumEquivalent:
                    return "Oersted Vacuum Equivalent";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterMagneticFieldUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMagneticFieldUnit.Nanotesla:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFieldUnit.Microtesla:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFieldUnit.Millitesla:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFieldUnit.Tesla:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFieldUnit.Gauss:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterMagneticFieldUnit.Picotesla:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFieldUnit.Kilotesla:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFieldUnit.Megatesla:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMagneticFieldUnit.Gamma:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMagneticFieldUnit.LinePerSquareCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMagneticFieldUnit.Microgauss:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMagneticFieldUnit.Milligauss:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMagneticFieldUnit.Kilogauss:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMagneticFieldUnit.Megagauss:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterMagneticFieldUnit.OerstedVacuumEquivalent:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterMagneticFieldUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterMagneticFieldUnit.Nanotesla, UnitConverterMagneticFieldUnit.Microtesla, UnitConverterMagneticFieldUnit.Millitesla, UnitConverterMagneticFieldUnit.Tesla, UnitConverterMagneticFieldUnit.Picotesla, UnitConverterMagneticFieldUnit.Kilotesla, UnitConverterMagneticFieldUnit.Megatesla };
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterMagneticFieldUnit.Gauss };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterMagneticFieldUnit.Gamma, UnitConverterMagneticFieldUnit.LinePerSquareCentimeter, UnitConverterMagneticFieldUnit.Microgauss, UnitConverterMagneticFieldUnit.Milligauss, UnitConverterMagneticFieldUnit.Kilogauss, UnitConverterMagneticFieldUnit.Megagauss, UnitConverterMagneticFieldUnit.OerstedVacuumEquivalent };
                default:
                    return new[] { UnitConverterMagneticFieldUnit.Nanotesla, UnitConverterMagneticFieldUnit.Microtesla, UnitConverterMagneticFieldUnit.Millitesla, UnitConverterMagneticFieldUnit.Tesla, UnitConverterMagneticFieldUnit.Gauss, UnitConverterMagneticFieldUnit.Picotesla, UnitConverterMagneticFieldUnit.Kilotesla, UnitConverterMagneticFieldUnit.Megatesla, UnitConverterMagneticFieldUnit.Gamma, UnitConverterMagneticFieldUnit.LinePerSquareCentimeter, UnitConverterMagneticFieldUnit.Microgauss, UnitConverterMagneticFieldUnit.Milligauss, UnitConverterMagneticFieldUnit.Kilogauss, UnitConverterMagneticFieldUnit.Megagauss, UnitConverterMagneticFieldUnit.OerstedVacuumEquivalent };
            }
        }
    }
}
