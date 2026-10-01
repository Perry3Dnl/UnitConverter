namespace UnitConverter.ElectricCharge
{
    using UnitConverter.ElectricCharge.Metric;
    using UnitConverter.ElectricCharge.Engineering;
    using UnitConverter.ElectricCharge.Scientific;

    public enum UnitConverterElectricChargeUnit
    {
        Nanocoulomb = 0,
        Microcoulomb = 1,
        Millicoulomb = 2,
        Coulomb = 3,
        Kilocoulomb = 4,
        AmpereHour = 5,
        MilliampereHour = 6,
        Faraday = 7,
        ElementaryCharge = 8,
        Femtocoulomb = 9,
        Picocoulomb = 10,
        Megacoulomb = 11,
        Gigacoulomb = 12,
        Statcoulomb = 13,
        Franklin = 14,
        Abcoulomb = 15,
    }

    public static class UnitConverterElectricCharge
    {
        public static double Convert(double value, UnitConverterElectricChargeUnit from, UnitConverterElectricChargeUnit to)
        {
            double baseValue = ToCoulomb(value, from);
            return FromCoulomb(baseValue, to);
        }

        public static double ToCoulomb(double value, UnitConverterElectricChargeUnit from)
        {
            switch (from)
            {
                case UnitConverterElectricChargeUnit.Nanocoulomb:
                    return UnitConverterMetricElectricCharge.NanocoulombToCoulomb(value);
                case UnitConverterElectricChargeUnit.Microcoulomb:
                    return UnitConverterMetricElectricCharge.MicrocoulombToCoulomb(value);
                case UnitConverterElectricChargeUnit.Millicoulomb:
                    return UnitConverterMetricElectricCharge.MillicoulombToCoulomb(value);
                case UnitConverterElectricChargeUnit.Coulomb:
                    return UnitConverterMetricElectricCharge.CoulombToCoulomb(value);
                case UnitConverterElectricChargeUnit.Kilocoulomb:
                    return UnitConverterMetricElectricCharge.KilocoulombToCoulomb(value);
                case UnitConverterElectricChargeUnit.AmpereHour:
                    return UnitConverterEngineeringElectricCharge.AmpereHourToCoulomb(value);
                case UnitConverterElectricChargeUnit.MilliampereHour:
                    return UnitConverterEngineeringElectricCharge.MilliampereHourToCoulomb(value);
                case UnitConverterElectricChargeUnit.Faraday:
                    return UnitConverterScientificElectricCharge.FaradayToCoulomb(value);
                case UnitConverterElectricChargeUnit.ElementaryCharge:
                    return UnitConverterScientificElectricCharge.ElementaryChargeToCoulomb(value);
                case UnitConverterElectricChargeUnit.Femtocoulomb:
                    return UnitConverterMetricElectricCharge.FemtocoulombToCoulomb(value);
                case UnitConverterElectricChargeUnit.Picocoulomb:
                    return UnitConverterMetricElectricCharge.PicocoulombToCoulomb(value);
                case UnitConverterElectricChargeUnit.Megacoulomb:
                    return UnitConverterMetricElectricCharge.MegacoulombToCoulomb(value);
                case UnitConverterElectricChargeUnit.Gigacoulomb:
                    return UnitConverterMetricElectricCharge.GigacoulombToCoulomb(value);
                case UnitConverterElectricChargeUnit.Statcoulomb:
                    return UnitConverterScientificElectricCharge.StatcoulombToCoulomb(value);
                case UnitConverterElectricChargeUnit.Franklin:
                    return UnitConverterScientificElectricCharge.FranklinToCoulomb(value);
                case UnitConverterElectricChargeUnit.Abcoulomb:
                    return UnitConverterScientificElectricCharge.AbcoulombToCoulomb(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electric charge unit.");
            }
        }

        public static double FromCoulomb(double baseValue, UnitConverterElectricChargeUnit to)
        {
            switch (to)
            {
                case UnitConverterElectricChargeUnit.Nanocoulomb:
                    return UnitConverterMetricElectricCharge.CoulombToNanocoulomb(baseValue);
                case UnitConverterElectricChargeUnit.Microcoulomb:
                    return UnitConverterMetricElectricCharge.CoulombToMicrocoulomb(baseValue);
                case UnitConverterElectricChargeUnit.Millicoulomb:
                    return UnitConverterMetricElectricCharge.CoulombToMillicoulomb(baseValue);
                case UnitConverterElectricChargeUnit.Coulomb:
                    return UnitConverterMetricElectricCharge.CoulombToCoulomb(baseValue);
                case UnitConverterElectricChargeUnit.Kilocoulomb:
                    return UnitConverterMetricElectricCharge.CoulombToKilocoulomb(baseValue);
                case UnitConverterElectricChargeUnit.AmpereHour:
                    return UnitConverterEngineeringElectricCharge.CoulombToAmpereHour(baseValue);
                case UnitConverterElectricChargeUnit.MilliampereHour:
                    return UnitConverterEngineeringElectricCharge.CoulombToMilliampereHour(baseValue);
                case UnitConverterElectricChargeUnit.Faraday:
                    return UnitConverterScientificElectricCharge.CoulombToFaraday(baseValue);
                case UnitConverterElectricChargeUnit.ElementaryCharge:
                    return UnitConverterScientificElectricCharge.CoulombToElementaryCharge(baseValue);
                case UnitConverterElectricChargeUnit.Femtocoulomb:
                    return UnitConverterMetricElectricCharge.CoulombToFemtocoulomb(baseValue);
                case UnitConverterElectricChargeUnit.Picocoulomb:
                    return UnitConverterMetricElectricCharge.CoulombToPicocoulomb(baseValue);
                case UnitConverterElectricChargeUnit.Megacoulomb:
                    return UnitConverterMetricElectricCharge.CoulombToMegacoulomb(baseValue);
                case UnitConverterElectricChargeUnit.Gigacoulomb:
                    return UnitConverterMetricElectricCharge.CoulombToGigacoulomb(baseValue);
                case UnitConverterElectricChargeUnit.Statcoulomb:
                    return UnitConverterScientificElectricCharge.CoulombToStatcoulomb(baseValue);
                case UnitConverterElectricChargeUnit.Franklin:
                    return UnitConverterScientificElectricCharge.CoulombToFranklin(baseValue);
                case UnitConverterElectricChargeUnit.Abcoulomb:
                    return UnitConverterScientificElectricCharge.CoulombToAbcoulomb(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electric charge unit.");
            }
        }

        public static string GetSymbol(UnitConverterElectricChargeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricChargeUnit.Nanocoulomb:
                    return "nC";
                case UnitConverterElectricChargeUnit.Microcoulomb:
                    return "µC";
                case UnitConverterElectricChargeUnit.Millicoulomb:
                    return "mC";
                case UnitConverterElectricChargeUnit.Coulomb:
                    return "C";
                case UnitConverterElectricChargeUnit.Kilocoulomb:
                    return "kC";
                case UnitConverterElectricChargeUnit.AmpereHour:
                    return "Ah";
                case UnitConverterElectricChargeUnit.MilliampereHour:
                    return "mAh";
                case UnitConverterElectricChargeUnit.Faraday:
                    return "Fdy";
                case UnitConverterElectricChargeUnit.ElementaryCharge:
                    return "e";
                case UnitConverterElectricChargeUnit.Femtocoulomb:
                    return "fC";
                case UnitConverterElectricChargeUnit.Picocoulomb:
                    return "pC";
                case UnitConverterElectricChargeUnit.Megacoulomb:
                    return "MC";
                case UnitConverterElectricChargeUnit.Gigacoulomb:
                    return "GC";
                case UnitConverterElectricChargeUnit.Statcoulomb:
                    return "statC";
                case UnitConverterElectricChargeUnit.Franklin:
                    return "Fr";
                case UnitConverterElectricChargeUnit.Abcoulomb:
                    return "abC";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterElectricChargeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricChargeUnit.Nanocoulomb:
                    return "nanocoulomb";
                case UnitConverterElectricChargeUnit.Microcoulomb:
                    return "microcoulomb";
                case UnitConverterElectricChargeUnit.Millicoulomb:
                    return "millicoulomb";
                case UnitConverterElectricChargeUnit.Coulomb:
                    return "coulomb";
                case UnitConverterElectricChargeUnit.Kilocoulomb:
                    return "kilocoulomb";
                case UnitConverterElectricChargeUnit.AmpereHour:
                    return "ampere-hour";
                case UnitConverterElectricChargeUnit.MilliampereHour:
                    return "milliampere-hour";
                case UnitConverterElectricChargeUnit.Faraday:
                    return "faraday";
                case UnitConverterElectricChargeUnit.ElementaryCharge:
                    return "elementary charge";
                case UnitConverterElectricChargeUnit.Femtocoulomb:
                    return "Femtocoulomb";
                case UnitConverterElectricChargeUnit.Picocoulomb:
                    return "Picocoulomb";
                case UnitConverterElectricChargeUnit.Megacoulomb:
                    return "Megacoulomb";
                case UnitConverterElectricChargeUnit.Gigacoulomb:
                    return "Gigacoulomb";
                case UnitConverterElectricChargeUnit.Statcoulomb:
                    return "Statcoulomb";
                case UnitConverterElectricChargeUnit.Franklin:
                    return "Franklin";
                case UnitConverterElectricChargeUnit.Abcoulomb:
                    return "Abcoulomb";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterElectricChargeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterElectricChargeUnit.Nanocoulomb:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricChargeUnit.Microcoulomb:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricChargeUnit.Millicoulomb:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricChargeUnit.Coulomb:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricChargeUnit.Kilocoulomb:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricChargeUnit.AmpereHour:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterElectricChargeUnit.MilliampereHour:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterElectricChargeUnit.Faraday:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterElectricChargeUnit.ElementaryCharge:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterElectricChargeUnit.Femtocoulomb:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricChargeUnit.Picocoulomb:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricChargeUnit.Megacoulomb:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricChargeUnit.Gigacoulomb:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterElectricChargeUnit.Statcoulomb:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterElectricChargeUnit.Franklin:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterElectricChargeUnit.Abcoulomb:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterElectricChargeUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterElectricChargeUnit.Nanocoulomb, UnitConverterElectricChargeUnit.Microcoulomb, UnitConverterElectricChargeUnit.Millicoulomb, UnitConverterElectricChargeUnit.Coulomb, UnitConverterElectricChargeUnit.Kilocoulomb, UnitConverterElectricChargeUnit.Femtocoulomb, UnitConverterElectricChargeUnit.Picocoulomb, UnitConverterElectricChargeUnit.Megacoulomb, UnitConverterElectricChargeUnit.Gigacoulomb };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterElectricChargeUnit.AmpereHour, UnitConverterElectricChargeUnit.MilliampereHour };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterElectricChargeUnit.Faraday, UnitConverterElectricChargeUnit.ElementaryCharge, UnitConverterElectricChargeUnit.Statcoulomb, UnitConverterElectricChargeUnit.Franklin, UnitConverterElectricChargeUnit.Abcoulomb };
                default:
                    return new[] { UnitConverterElectricChargeUnit.Nanocoulomb, UnitConverterElectricChargeUnit.Microcoulomb, UnitConverterElectricChargeUnit.Millicoulomb, UnitConverterElectricChargeUnit.Coulomb, UnitConverterElectricChargeUnit.Kilocoulomb, UnitConverterElectricChargeUnit.AmpereHour, UnitConverterElectricChargeUnit.MilliampereHour, UnitConverterElectricChargeUnit.Faraday, UnitConverterElectricChargeUnit.ElementaryCharge, UnitConverterElectricChargeUnit.Femtocoulomb, UnitConverterElectricChargeUnit.Picocoulomb, UnitConverterElectricChargeUnit.Megacoulomb, UnitConverterElectricChargeUnit.Gigacoulomb, UnitConverterElectricChargeUnit.Statcoulomb, UnitConverterElectricChargeUnit.Franklin, UnitConverterElectricChargeUnit.Abcoulomb };
            }
        }
    }
}
