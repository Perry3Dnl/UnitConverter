namespace UnitTools.ElectricCharge
{
    using UnitTools.ElectricCharge.Metric;
    using UnitTools.ElectricCharge.Engineering;
    using UnitTools.ElectricCharge.Scientific;

    public enum UnitToolsElectricChargeUnit
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

    public static class UnitToolsElectricCharge
    {
        public static double Convert(double value, UnitToolsElectricChargeUnit from, UnitToolsElectricChargeUnit to)
        {
            double baseValue = ToCoulomb(value, from);
            return FromCoulomb(baseValue, to);
        }

        public static double ToCoulomb(double value, UnitToolsElectricChargeUnit from)
        {
            switch (from)
            {
                case UnitToolsElectricChargeUnit.Nanocoulomb:
                    return UnitToolsMetricElectricCharge.NanocoulombToCoulomb(value);
                case UnitToolsElectricChargeUnit.Microcoulomb:
                    return UnitToolsMetricElectricCharge.MicrocoulombToCoulomb(value);
                case UnitToolsElectricChargeUnit.Millicoulomb:
                    return UnitToolsMetricElectricCharge.MillicoulombToCoulomb(value);
                case UnitToolsElectricChargeUnit.Coulomb:
                    return UnitToolsMetricElectricCharge.CoulombToCoulomb(value);
                case UnitToolsElectricChargeUnit.Kilocoulomb:
                    return UnitToolsMetricElectricCharge.KilocoulombToCoulomb(value);
                case UnitToolsElectricChargeUnit.AmpereHour:
                    return UnitToolsEngineeringElectricCharge.AmpereHourToCoulomb(value);
                case UnitToolsElectricChargeUnit.MilliampereHour:
                    return UnitToolsEngineeringElectricCharge.MilliampereHourToCoulomb(value);
                case UnitToolsElectricChargeUnit.Faraday:
                    return UnitToolsScientificElectricCharge.FaradayToCoulomb(value);
                case UnitToolsElectricChargeUnit.ElementaryCharge:
                    return UnitToolsScientificElectricCharge.ElementaryChargeToCoulomb(value);
                case UnitToolsElectricChargeUnit.Femtocoulomb:
                    return UnitToolsMetricElectricCharge.FemtocoulombToCoulomb(value);
                case UnitToolsElectricChargeUnit.Picocoulomb:
                    return UnitToolsMetricElectricCharge.PicocoulombToCoulomb(value);
                case UnitToolsElectricChargeUnit.Megacoulomb:
                    return UnitToolsMetricElectricCharge.MegacoulombToCoulomb(value);
                case UnitToolsElectricChargeUnit.Gigacoulomb:
                    return UnitToolsMetricElectricCharge.GigacoulombToCoulomb(value);
                case UnitToolsElectricChargeUnit.Statcoulomb:
                    return UnitToolsScientificElectricCharge.StatcoulombToCoulomb(value);
                case UnitToolsElectricChargeUnit.Franklin:
                    return UnitToolsScientificElectricCharge.FranklinToCoulomb(value);
                case UnitToolsElectricChargeUnit.Abcoulomb:
                    return UnitToolsScientificElectricCharge.AbcoulombToCoulomb(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported electric charge unit.");
            }
        }

        public static double FromCoulomb(double baseValue, UnitToolsElectricChargeUnit to)
        {
            switch (to)
            {
                case UnitToolsElectricChargeUnit.Nanocoulomb:
                    return UnitToolsMetricElectricCharge.CoulombToNanocoulomb(baseValue);
                case UnitToolsElectricChargeUnit.Microcoulomb:
                    return UnitToolsMetricElectricCharge.CoulombToMicrocoulomb(baseValue);
                case UnitToolsElectricChargeUnit.Millicoulomb:
                    return UnitToolsMetricElectricCharge.CoulombToMillicoulomb(baseValue);
                case UnitToolsElectricChargeUnit.Coulomb:
                    return UnitToolsMetricElectricCharge.CoulombToCoulomb(baseValue);
                case UnitToolsElectricChargeUnit.Kilocoulomb:
                    return UnitToolsMetricElectricCharge.CoulombToKilocoulomb(baseValue);
                case UnitToolsElectricChargeUnit.AmpereHour:
                    return UnitToolsEngineeringElectricCharge.CoulombToAmpereHour(baseValue);
                case UnitToolsElectricChargeUnit.MilliampereHour:
                    return UnitToolsEngineeringElectricCharge.CoulombToMilliampereHour(baseValue);
                case UnitToolsElectricChargeUnit.Faraday:
                    return UnitToolsScientificElectricCharge.CoulombToFaraday(baseValue);
                case UnitToolsElectricChargeUnit.ElementaryCharge:
                    return UnitToolsScientificElectricCharge.CoulombToElementaryCharge(baseValue);
                case UnitToolsElectricChargeUnit.Femtocoulomb:
                    return UnitToolsMetricElectricCharge.CoulombToFemtocoulomb(baseValue);
                case UnitToolsElectricChargeUnit.Picocoulomb:
                    return UnitToolsMetricElectricCharge.CoulombToPicocoulomb(baseValue);
                case UnitToolsElectricChargeUnit.Megacoulomb:
                    return UnitToolsMetricElectricCharge.CoulombToMegacoulomb(baseValue);
                case UnitToolsElectricChargeUnit.Gigacoulomb:
                    return UnitToolsMetricElectricCharge.CoulombToGigacoulomb(baseValue);
                case UnitToolsElectricChargeUnit.Statcoulomb:
                    return UnitToolsScientificElectricCharge.CoulombToStatcoulomb(baseValue);
                case UnitToolsElectricChargeUnit.Franklin:
                    return UnitToolsScientificElectricCharge.CoulombToFranklin(baseValue);
                case UnitToolsElectricChargeUnit.Abcoulomb:
                    return UnitToolsScientificElectricCharge.CoulombToAbcoulomb(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported electric charge unit.");
            }
        }

        public static string GetSymbol(UnitToolsElectricChargeUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricChargeUnit.Nanocoulomb:
                    return "nC";
                case UnitToolsElectricChargeUnit.Microcoulomb:
                    return "µC";
                case UnitToolsElectricChargeUnit.Millicoulomb:
                    return "mC";
                case UnitToolsElectricChargeUnit.Coulomb:
                    return "C";
                case UnitToolsElectricChargeUnit.Kilocoulomb:
                    return "kC";
                case UnitToolsElectricChargeUnit.AmpereHour:
                    return "Ah";
                case UnitToolsElectricChargeUnit.MilliampereHour:
                    return "mAh";
                case UnitToolsElectricChargeUnit.Faraday:
                    return "Fdy";
                case UnitToolsElectricChargeUnit.ElementaryCharge:
                    return "e";
                case UnitToolsElectricChargeUnit.Femtocoulomb:
                    return "fC";
                case UnitToolsElectricChargeUnit.Picocoulomb:
                    return "pC";
                case UnitToolsElectricChargeUnit.Megacoulomb:
                    return "MC";
                case UnitToolsElectricChargeUnit.Gigacoulomb:
                    return "GC";
                case UnitToolsElectricChargeUnit.Statcoulomb:
                    return "statC";
                case UnitToolsElectricChargeUnit.Franklin:
                    return "Fr";
                case UnitToolsElectricChargeUnit.Abcoulomb:
                    return "abC";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsElectricChargeUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricChargeUnit.Nanocoulomb:
                    return "nanocoulomb";
                case UnitToolsElectricChargeUnit.Microcoulomb:
                    return "microcoulomb";
                case UnitToolsElectricChargeUnit.Millicoulomb:
                    return "millicoulomb";
                case UnitToolsElectricChargeUnit.Coulomb:
                    return "coulomb";
                case UnitToolsElectricChargeUnit.Kilocoulomb:
                    return "kilocoulomb";
                case UnitToolsElectricChargeUnit.AmpereHour:
                    return "ampere-hour";
                case UnitToolsElectricChargeUnit.MilliampereHour:
                    return "milliampere-hour";
                case UnitToolsElectricChargeUnit.Faraday:
                    return "faraday";
                case UnitToolsElectricChargeUnit.ElementaryCharge:
                    return "elementary charge";
                case UnitToolsElectricChargeUnit.Femtocoulomb:
                    return "Femtocoulomb";
                case UnitToolsElectricChargeUnit.Picocoulomb:
                    return "Picocoulomb";
                case UnitToolsElectricChargeUnit.Megacoulomb:
                    return "Megacoulomb";
                case UnitToolsElectricChargeUnit.Gigacoulomb:
                    return "Gigacoulomb";
                case UnitToolsElectricChargeUnit.Statcoulomb:
                    return "Statcoulomb";
                case UnitToolsElectricChargeUnit.Franklin:
                    return "Franklin";
                case UnitToolsElectricChargeUnit.Abcoulomb:
                    return "Abcoulomb";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsElectricChargeUnit unit)
        {
            switch (unit)
            {
                case UnitToolsElectricChargeUnit.Nanocoulomb:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricChargeUnit.Microcoulomb:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricChargeUnit.Millicoulomb:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricChargeUnit.Coulomb:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricChargeUnit.Kilocoulomb:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricChargeUnit.AmpereHour:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsElectricChargeUnit.MilliampereHour:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsElectricChargeUnit.Faraday:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsElectricChargeUnit.ElementaryCharge:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsElectricChargeUnit.Femtocoulomb:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricChargeUnit.Picocoulomb:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricChargeUnit.Megacoulomb:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricChargeUnit.Gigacoulomb:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsElectricChargeUnit.Statcoulomb:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsElectricChargeUnit.Franklin:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsElectricChargeUnit.Abcoulomb:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsElectricChargeUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsElectricChargeUnit.Nanocoulomb, UnitToolsElectricChargeUnit.Microcoulomb, UnitToolsElectricChargeUnit.Millicoulomb, UnitToolsElectricChargeUnit.Coulomb, UnitToolsElectricChargeUnit.Kilocoulomb, UnitToolsElectricChargeUnit.Femtocoulomb, UnitToolsElectricChargeUnit.Picocoulomb, UnitToolsElectricChargeUnit.Megacoulomb, UnitToolsElectricChargeUnit.Gigacoulomb };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsElectricChargeUnit.AmpereHour, UnitToolsElectricChargeUnit.MilliampereHour };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsElectricChargeUnit.Faraday, UnitToolsElectricChargeUnit.ElementaryCharge, UnitToolsElectricChargeUnit.Statcoulomb, UnitToolsElectricChargeUnit.Franklin, UnitToolsElectricChargeUnit.Abcoulomb };
                default:
                    return new[] { UnitToolsElectricChargeUnit.Nanocoulomb, UnitToolsElectricChargeUnit.Microcoulomb, UnitToolsElectricChargeUnit.Millicoulomb, UnitToolsElectricChargeUnit.Coulomb, UnitToolsElectricChargeUnit.Kilocoulomb, UnitToolsElectricChargeUnit.AmpereHour, UnitToolsElectricChargeUnit.MilliampereHour, UnitToolsElectricChargeUnit.Faraday, UnitToolsElectricChargeUnit.ElementaryCharge, UnitToolsElectricChargeUnit.Femtocoulomb, UnitToolsElectricChargeUnit.Picocoulomb, UnitToolsElectricChargeUnit.Megacoulomb, UnitToolsElectricChargeUnit.Gigacoulomb, UnitToolsElectricChargeUnit.Statcoulomb, UnitToolsElectricChargeUnit.Franklin, UnitToolsElectricChargeUnit.Abcoulomb };
            }
        }
    }
}
