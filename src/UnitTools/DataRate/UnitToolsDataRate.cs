namespace UnitTools.DataRate
{
    using UnitTools.DataRate.Digital;

    public enum UnitToolsDataRateUnit
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

    public static class UnitToolsDataRate
    {
        public static double Convert(double value, UnitToolsDataRateUnit from, UnitToolsDataRateUnit to)
        {
            double baseValue = ToBitPerSecond(value, from);
            return FromBitPerSecond(baseValue, to);
        }

        public static double ToBitPerSecond(double value, UnitToolsDataRateUnit from)
        {
            switch (from)
            {
                case UnitToolsDataRateUnit.BitPerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToBitPerSecond(value);
                case UnitToolsDataRateUnit.BytePerSecond:
                    return UnitToolsDigitalDataRate.BytePerSecondToBitPerSecond(value);
                case UnitToolsDataRateUnit.KilobitPerSecond:
                    return UnitToolsDigitalDataRate.KilobitPerSecondToBitPerSecond(value);
                case UnitToolsDataRateUnit.KilobytePerSecond:
                    return UnitToolsDigitalDataRate.KilobytePerSecondToBitPerSecond(value);
                case UnitToolsDataRateUnit.MegabitPerSecond:
                    return UnitToolsDigitalDataRate.MegabitPerSecondToBitPerSecond(value);
                case UnitToolsDataRateUnit.MegabytePerSecond:
                    return UnitToolsDigitalDataRate.MegabytePerSecondToBitPerSecond(value);
                case UnitToolsDataRateUnit.GigabitPerSecond:
                    return UnitToolsDigitalDataRate.GigabitPerSecondToBitPerSecond(value);
                case UnitToolsDataRateUnit.GigabytePerSecond:
                    return UnitToolsDigitalDataRate.GigabytePerSecondToBitPerSecond(value);
                case UnitToolsDataRateUnit.KibibitPerSecond:
                    return UnitToolsDigitalDataRate.KibibitPerSecondToBitPerSecond(value);
                case UnitToolsDataRateUnit.KibibytePerSecond:
                    return UnitToolsDigitalDataRate.KibibytePerSecondToBitPerSecond(value);
                case UnitToolsDataRateUnit.MebibitPerSecond:
                    return UnitToolsDigitalDataRate.MebibitPerSecondToBitPerSecond(value);
                case UnitToolsDataRateUnit.MebibytePerSecond:
                    return UnitToolsDigitalDataRate.MebibytePerSecondToBitPerSecond(value);
                case UnitToolsDataRateUnit.GibibitPerSecond:
                    return UnitToolsDigitalDataRate.GibibitPerSecondToBitPerSecond(value);
                case UnitToolsDataRateUnit.GibibytePerSecond:
                    return UnitToolsDigitalDataRate.GibibytePerSecondToBitPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported data rate unit.");
            }
        }

        public static double FromBitPerSecond(double baseValue, UnitToolsDataRateUnit to)
        {
            switch (to)
            {
                case UnitToolsDataRateUnit.BitPerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToBitPerSecond(baseValue);
                case UnitToolsDataRateUnit.BytePerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToBytePerSecond(baseValue);
                case UnitToolsDataRateUnit.KilobitPerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToKilobitPerSecond(baseValue);
                case UnitToolsDataRateUnit.KilobytePerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToKilobytePerSecond(baseValue);
                case UnitToolsDataRateUnit.MegabitPerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToMegabitPerSecond(baseValue);
                case UnitToolsDataRateUnit.MegabytePerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToMegabytePerSecond(baseValue);
                case UnitToolsDataRateUnit.GigabitPerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToGigabitPerSecond(baseValue);
                case UnitToolsDataRateUnit.GigabytePerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToGigabytePerSecond(baseValue);
                case UnitToolsDataRateUnit.KibibitPerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToKibibitPerSecond(baseValue);
                case UnitToolsDataRateUnit.KibibytePerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToKibibytePerSecond(baseValue);
                case UnitToolsDataRateUnit.MebibitPerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToMebibitPerSecond(baseValue);
                case UnitToolsDataRateUnit.MebibytePerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToMebibytePerSecond(baseValue);
                case UnitToolsDataRateUnit.GibibitPerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToGibibitPerSecond(baseValue);
                case UnitToolsDataRateUnit.GibibytePerSecond:
                    return UnitToolsDigitalDataRate.BitPerSecondToGibibytePerSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported data rate unit.");
            }
        }

        public static string GetSymbol(UnitToolsDataRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDataRateUnit.BitPerSecond:
                    return "bps";
                case UnitToolsDataRateUnit.BytePerSecond:
                    return "B/s";
                case UnitToolsDataRateUnit.KilobitPerSecond:
                    return "kbps";
                case UnitToolsDataRateUnit.KilobytePerSecond:
                    return "KB/s";
                case UnitToolsDataRateUnit.MegabitPerSecond:
                    return "Mbps";
                case UnitToolsDataRateUnit.MegabytePerSecond:
                    return "MB/s";
                case UnitToolsDataRateUnit.GigabitPerSecond:
                    return "Gbps";
                case UnitToolsDataRateUnit.GigabytePerSecond:
                    return "GB/s";
                case UnitToolsDataRateUnit.KibibitPerSecond:
                    return "Kibps";
                case UnitToolsDataRateUnit.KibibytePerSecond:
                    return "KiB/s";
                case UnitToolsDataRateUnit.MebibitPerSecond:
                    return "Mibps";
                case UnitToolsDataRateUnit.MebibytePerSecond:
                    return "MiB/s";
                case UnitToolsDataRateUnit.GibibitPerSecond:
                    return "Gibps";
                case UnitToolsDataRateUnit.GibibytePerSecond:
                    return "GiB/s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsDataRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDataRateUnit.BitPerSecond:
                    return "bit per second";
                case UnitToolsDataRateUnit.BytePerSecond:
                    return "byte per second";
                case UnitToolsDataRateUnit.KilobitPerSecond:
                    return "kilobit per second";
                case UnitToolsDataRateUnit.KilobytePerSecond:
                    return "kilobyte per second";
                case UnitToolsDataRateUnit.MegabitPerSecond:
                    return "megabit per second";
                case UnitToolsDataRateUnit.MegabytePerSecond:
                    return "megabyte per second";
                case UnitToolsDataRateUnit.GigabitPerSecond:
                    return "gigabit per second";
                case UnitToolsDataRateUnit.GigabytePerSecond:
                    return "gigabyte per second";
                case UnitToolsDataRateUnit.KibibitPerSecond:
                    return "kibibit per second";
                case UnitToolsDataRateUnit.KibibytePerSecond:
                    return "kibibyte per second";
                case UnitToolsDataRateUnit.MebibitPerSecond:
                    return "mebibit per second";
                case UnitToolsDataRateUnit.MebibytePerSecond:
                    return "mebibyte per second";
                case UnitToolsDataRateUnit.GibibitPerSecond:
                    return "gibibit per second";
                case UnitToolsDataRateUnit.GibibytePerSecond:
                    return "gibibyte per second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsDataRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDataRateUnit.BitPerSecond:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDataRateUnit.BytePerSecond:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDataRateUnit.KilobitPerSecond:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDataRateUnit.KilobytePerSecond:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDataRateUnit.MegabitPerSecond:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDataRateUnit.MegabytePerSecond:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDataRateUnit.GigabitPerSecond:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDataRateUnit.GigabytePerSecond:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDataRateUnit.KibibitPerSecond:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDataRateUnit.KibibytePerSecond:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDataRateUnit.MebibitPerSecond:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDataRateUnit.MebibytePerSecond:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDataRateUnit.GibibitPerSecond:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDataRateUnit.GibibytePerSecond:
                    return UnitToolsUnitSystem.Digital;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsDataRateUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Digital:
                    return new[] { UnitToolsDataRateUnit.BitPerSecond, UnitToolsDataRateUnit.BytePerSecond, UnitToolsDataRateUnit.KilobitPerSecond, UnitToolsDataRateUnit.KilobytePerSecond, UnitToolsDataRateUnit.MegabitPerSecond, UnitToolsDataRateUnit.MegabytePerSecond, UnitToolsDataRateUnit.GigabitPerSecond, UnitToolsDataRateUnit.GigabytePerSecond, UnitToolsDataRateUnit.KibibitPerSecond, UnitToolsDataRateUnit.KibibytePerSecond, UnitToolsDataRateUnit.MebibitPerSecond, UnitToolsDataRateUnit.MebibytePerSecond, UnitToolsDataRateUnit.GibibitPerSecond, UnitToolsDataRateUnit.GibibytePerSecond };
                default:
                    return new[] { UnitToolsDataRateUnit.BitPerSecond, UnitToolsDataRateUnit.BytePerSecond, UnitToolsDataRateUnit.KilobitPerSecond, UnitToolsDataRateUnit.KilobytePerSecond, UnitToolsDataRateUnit.MegabitPerSecond, UnitToolsDataRateUnit.MegabytePerSecond, UnitToolsDataRateUnit.GigabitPerSecond, UnitToolsDataRateUnit.GigabytePerSecond, UnitToolsDataRateUnit.KibibitPerSecond, UnitToolsDataRateUnit.KibibytePerSecond, UnitToolsDataRateUnit.MebibitPerSecond, UnitToolsDataRateUnit.MebibytePerSecond, UnitToolsDataRateUnit.GibibitPerSecond, UnitToolsDataRateUnit.GibibytePerSecond };
            }
        }
    }
}
