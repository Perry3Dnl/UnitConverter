namespace UnitConverter.DataRate
{
    using UnitConverter.DataRate.Digital;

    public enum UnitConverterDataRateUnit
    {
        BitPerSecond = 0,
        BytePerSecond = 1,
        KilobitPerSecond = 2,
        KilobytePerSecond = 3,
        MegabitPerSecond = 4,
        MegabytePerSecond = 5,
        GigabitPerSecond = 6,
        GigabytePerSecond = 7,
        KibibitPerSecond = 8,
        KibibytePerSecond = 9,
        MebibitPerSecond = 10,
        MebibytePerSecond = 11,
        GibibitPerSecond = 12,
        GibibytePerSecond = 13,
    }

    public static class UnitConverterDataRate
    {
        public static double Convert(double value, UnitConverterDataRateUnit from, UnitConverterDataRateUnit to)
        {
            double baseValue = ToBitPerSecond(value, from);
            return FromBitPerSecond(baseValue, to);
        }

        public static double ToBitPerSecond(double value, UnitConverterDataRateUnit from)
        {
            switch (from)
            {
                case UnitConverterDataRateUnit.BitPerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToBitPerSecond(value);
                case UnitConverterDataRateUnit.BytePerSecond:
                    return UnitConverterDigitalDataRate.BytePerSecondToBitPerSecond(value);
                case UnitConverterDataRateUnit.KilobitPerSecond:
                    return UnitConverterDigitalDataRate.KilobitPerSecondToBitPerSecond(value);
                case UnitConverterDataRateUnit.KilobytePerSecond:
                    return UnitConverterDigitalDataRate.KilobytePerSecondToBitPerSecond(value);
                case UnitConverterDataRateUnit.MegabitPerSecond:
                    return UnitConverterDigitalDataRate.MegabitPerSecondToBitPerSecond(value);
                case UnitConverterDataRateUnit.MegabytePerSecond:
                    return UnitConverterDigitalDataRate.MegabytePerSecondToBitPerSecond(value);
                case UnitConverterDataRateUnit.GigabitPerSecond:
                    return UnitConverterDigitalDataRate.GigabitPerSecondToBitPerSecond(value);
                case UnitConverterDataRateUnit.GigabytePerSecond:
                    return UnitConverterDigitalDataRate.GigabytePerSecondToBitPerSecond(value);
                case UnitConverterDataRateUnit.KibibitPerSecond:
                    return UnitConverterDigitalDataRate.KibibitPerSecondToBitPerSecond(value);
                case UnitConverterDataRateUnit.KibibytePerSecond:
                    return UnitConverterDigitalDataRate.KibibytePerSecondToBitPerSecond(value);
                case UnitConverterDataRateUnit.MebibitPerSecond:
                    return UnitConverterDigitalDataRate.MebibitPerSecondToBitPerSecond(value);
                case UnitConverterDataRateUnit.MebibytePerSecond:
                    return UnitConverterDigitalDataRate.MebibytePerSecondToBitPerSecond(value);
                case UnitConverterDataRateUnit.GibibitPerSecond:
                    return UnitConverterDigitalDataRate.GibibitPerSecondToBitPerSecond(value);
                case UnitConverterDataRateUnit.GibibytePerSecond:
                    return UnitConverterDigitalDataRate.GibibytePerSecondToBitPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported data rate unit.");
            }
        }

        public static double FromBitPerSecond(double baseValue, UnitConverterDataRateUnit to)
        {
            switch (to)
            {
                case UnitConverterDataRateUnit.BitPerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToBitPerSecond(baseValue);
                case UnitConverterDataRateUnit.BytePerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToBytePerSecond(baseValue);
                case UnitConverterDataRateUnit.KilobitPerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToKilobitPerSecond(baseValue);
                case UnitConverterDataRateUnit.KilobytePerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToKilobytePerSecond(baseValue);
                case UnitConverterDataRateUnit.MegabitPerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToMegabitPerSecond(baseValue);
                case UnitConverterDataRateUnit.MegabytePerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToMegabytePerSecond(baseValue);
                case UnitConverterDataRateUnit.GigabitPerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToGigabitPerSecond(baseValue);
                case UnitConverterDataRateUnit.GigabytePerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToGigabytePerSecond(baseValue);
                case UnitConverterDataRateUnit.KibibitPerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToKibibitPerSecond(baseValue);
                case UnitConverterDataRateUnit.KibibytePerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToKibibytePerSecond(baseValue);
                case UnitConverterDataRateUnit.MebibitPerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToMebibitPerSecond(baseValue);
                case UnitConverterDataRateUnit.MebibytePerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToMebibytePerSecond(baseValue);
                case UnitConverterDataRateUnit.GibibitPerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToGibibitPerSecond(baseValue);
                case UnitConverterDataRateUnit.GibibytePerSecond:
                    return UnitConverterDigitalDataRate.BitPerSecondToGibibytePerSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported data rate unit.");
            }
        }

        public static string GetSymbol(UnitConverterDataRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDataRateUnit.BitPerSecond:
                    return "bps";
                case UnitConverterDataRateUnit.BytePerSecond:
                    return "B/s";
                case UnitConverterDataRateUnit.KilobitPerSecond:
                    return "kbps";
                case UnitConverterDataRateUnit.KilobytePerSecond:
                    return "KB/s";
                case UnitConverterDataRateUnit.MegabitPerSecond:
                    return "Mbps";
                case UnitConverterDataRateUnit.MegabytePerSecond:
                    return "MB/s";
                case UnitConverterDataRateUnit.GigabitPerSecond:
                    return "Gbps";
                case UnitConverterDataRateUnit.GigabytePerSecond:
                    return "GB/s";
                case UnitConverterDataRateUnit.KibibitPerSecond:
                    return "Kibps";
                case UnitConverterDataRateUnit.KibibytePerSecond:
                    return "KiB/s";
                case UnitConverterDataRateUnit.MebibitPerSecond:
                    return "Mibps";
                case UnitConverterDataRateUnit.MebibytePerSecond:
                    return "MiB/s";
                case UnitConverterDataRateUnit.GibibitPerSecond:
                    return "Gibps";
                case UnitConverterDataRateUnit.GibibytePerSecond:
                    return "GiB/s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterDataRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDataRateUnit.BitPerSecond:
                    return "bit per second";
                case UnitConverterDataRateUnit.BytePerSecond:
                    return "byte per second";
                case UnitConverterDataRateUnit.KilobitPerSecond:
                    return "kilobit per second";
                case UnitConverterDataRateUnit.KilobytePerSecond:
                    return "kilobyte per second";
                case UnitConverterDataRateUnit.MegabitPerSecond:
                    return "megabit per second";
                case UnitConverterDataRateUnit.MegabytePerSecond:
                    return "megabyte per second";
                case UnitConverterDataRateUnit.GigabitPerSecond:
                    return "gigabit per second";
                case UnitConverterDataRateUnit.GigabytePerSecond:
                    return "gigabyte per second";
                case UnitConverterDataRateUnit.KibibitPerSecond:
                    return "kibibit per second";
                case UnitConverterDataRateUnit.KibibytePerSecond:
                    return "kibibyte per second";
                case UnitConverterDataRateUnit.MebibitPerSecond:
                    return "mebibit per second";
                case UnitConverterDataRateUnit.MebibytePerSecond:
                    return "mebibyte per second";
                case UnitConverterDataRateUnit.GibibitPerSecond:
                    return "gibibit per second";
                case UnitConverterDataRateUnit.GibibytePerSecond:
                    return "gibibyte per second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterDataRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDataRateUnit.BitPerSecond:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDataRateUnit.BytePerSecond:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDataRateUnit.KilobitPerSecond:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDataRateUnit.KilobytePerSecond:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDataRateUnit.MegabitPerSecond:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDataRateUnit.MegabytePerSecond:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDataRateUnit.GigabitPerSecond:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDataRateUnit.GigabytePerSecond:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDataRateUnit.KibibitPerSecond:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDataRateUnit.KibibytePerSecond:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDataRateUnit.MebibitPerSecond:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDataRateUnit.MebibytePerSecond:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDataRateUnit.GibibitPerSecond:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDataRateUnit.GibibytePerSecond:
                    return UnitConverterUnitSystem.Digital;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterDataRateUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Digital:
                    return new[] { UnitConverterDataRateUnit.BitPerSecond, UnitConverterDataRateUnit.BytePerSecond, UnitConverterDataRateUnit.KilobitPerSecond, UnitConverterDataRateUnit.KilobytePerSecond, UnitConverterDataRateUnit.MegabitPerSecond, UnitConverterDataRateUnit.MegabytePerSecond, UnitConverterDataRateUnit.GigabitPerSecond, UnitConverterDataRateUnit.GigabytePerSecond, UnitConverterDataRateUnit.KibibitPerSecond, UnitConverterDataRateUnit.KibibytePerSecond, UnitConverterDataRateUnit.MebibitPerSecond, UnitConverterDataRateUnit.MebibytePerSecond, UnitConverterDataRateUnit.GibibitPerSecond, UnitConverterDataRateUnit.GibibytePerSecond };
                default:
                    return new[] { UnitConverterDataRateUnit.BitPerSecond, UnitConverterDataRateUnit.BytePerSecond, UnitConverterDataRateUnit.KilobitPerSecond, UnitConverterDataRateUnit.KilobytePerSecond, UnitConverterDataRateUnit.MegabitPerSecond, UnitConverterDataRateUnit.MegabytePerSecond, UnitConverterDataRateUnit.GigabitPerSecond, UnitConverterDataRateUnit.GigabytePerSecond, UnitConverterDataRateUnit.KibibitPerSecond, UnitConverterDataRateUnit.KibibytePerSecond, UnitConverterDataRateUnit.MebibitPerSecond, UnitConverterDataRateUnit.MebibytePerSecond, UnitConverterDataRateUnit.GibibitPerSecond, UnitConverterDataRateUnit.GibibytePerSecond };
            }
        }
    }
}
