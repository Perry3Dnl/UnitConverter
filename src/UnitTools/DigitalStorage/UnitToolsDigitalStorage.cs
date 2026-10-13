namespace UnitTools.DigitalStorage
{
    using UnitTools.DigitalStorage.Digital;

    public enum UnitToolsDigitalStorageUnit
    {
        Bit = 0,
        Nibble = 1,
        Byte = 2,
        Kilobit = 3,
        Kilobyte = 4,
        Megabit = 5,
        Megabyte = 6,
        Gigabit = 7,
        Gigabyte = 8,
        Terabit = 9,
        Terabyte = 10,
        Petabyte = 11,
        Kibibit = 12,
        Kibibyte = 13,
        Mebibit = 14,
        Mebibyte = 15,
        Gibibit = 16,
        Gibibyte = 17,
        Tebibyte = 18,
        Pebibyte = 19,
    }

    public static class UnitToolsDigitalStorage
    {
        public static double Convert(double value, UnitToolsDigitalStorageUnit from, UnitToolsDigitalStorageUnit to)
        {
            double baseValue = ToByte(value, from);
            return FromByte(baseValue, to);
        }

        public static double ToByte(double value, UnitToolsDigitalStorageUnit from)
        {
            switch (from)
            {
                case UnitToolsDigitalStorageUnit.Bit:
                    return UnitToolsDigitalDigitalStorage.BitToByte(value);
                case UnitToolsDigitalStorageUnit.Nibble:
                    return UnitToolsDigitalDigitalStorage.NibbleToByte(value);
                case UnitToolsDigitalStorageUnit.Byte:
                    return UnitToolsDigitalDigitalStorage.ByteToByte(value);
                case UnitToolsDigitalStorageUnit.Kilobit:
                    return UnitToolsDigitalDigitalStorage.KilobitToByte(value);
                case UnitToolsDigitalStorageUnit.Kilobyte:
                    return UnitToolsDigitalDigitalStorage.KilobyteToByte(value);
                case UnitToolsDigitalStorageUnit.Megabit:
                    return UnitToolsDigitalDigitalStorage.MegabitToByte(value);
                case UnitToolsDigitalStorageUnit.Megabyte:
                    return UnitToolsDigitalDigitalStorage.MegabyteToByte(value);
                case UnitToolsDigitalStorageUnit.Gigabit:
                    return UnitToolsDigitalDigitalStorage.GigabitToByte(value);
                case UnitToolsDigitalStorageUnit.Gigabyte:
                    return UnitToolsDigitalDigitalStorage.GigabyteToByte(value);
                case UnitToolsDigitalStorageUnit.Terabit:
                    return UnitToolsDigitalDigitalStorage.TerabitToByte(value);
                case UnitToolsDigitalStorageUnit.Terabyte:
                    return UnitToolsDigitalDigitalStorage.TerabyteToByte(value);
                case UnitToolsDigitalStorageUnit.Petabyte:
                    return UnitToolsDigitalDigitalStorage.PetabyteToByte(value);
                case UnitToolsDigitalStorageUnit.Kibibit:
                    return UnitToolsDigitalDigitalStorage.KibibitToByte(value);
                case UnitToolsDigitalStorageUnit.Kibibyte:
                    return UnitToolsDigitalDigitalStorage.KibibyteToByte(value);
                case UnitToolsDigitalStorageUnit.Mebibit:
                    return UnitToolsDigitalDigitalStorage.MebibitToByte(value);
                case UnitToolsDigitalStorageUnit.Mebibyte:
                    return UnitToolsDigitalDigitalStorage.MebibyteToByte(value);
                case UnitToolsDigitalStorageUnit.Gibibit:
                    return UnitToolsDigitalDigitalStorage.GibibitToByte(value);
                case UnitToolsDigitalStorageUnit.Gibibyte:
                    return UnitToolsDigitalDigitalStorage.GibibyteToByte(value);
                case UnitToolsDigitalStorageUnit.Tebibyte:
                    return UnitToolsDigitalDigitalStorage.TebibyteToByte(value);
                case UnitToolsDigitalStorageUnit.Pebibyte:
                    return UnitToolsDigitalDigitalStorage.PebibyteToByte(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported digital storage unit.");
            }
        }

        public static double FromByte(double baseValue, UnitToolsDigitalStorageUnit to)
        {
            switch (to)
            {
                case UnitToolsDigitalStorageUnit.Bit:
                    return UnitToolsDigitalDigitalStorage.ByteToBit(baseValue);
                case UnitToolsDigitalStorageUnit.Nibble:
                    return UnitToolsDigitalDigitalStorage.ByteToNibble(baseValue);
                case UnitToolsDigitalStorageUnit.Byte:
                    return UnitToolsDigitalDigitalStorage.ByteToByte(baseValue);
                case UnitToolsDigitalStorageUnit.Kilobit:
                    return UnitToolsDigitalDigitalStorage.ByteToKilobit(baseValue);
                case UnitToolsDigitalStorageUnit.Kilobyte:
                    return UnitToolsDigitalDigitalStorage.ByteToKilobyte(baseValue);
                case UnitToolsDigitalStorageUnit.Megabit:
                    return UnitToolsDigitalDigitalStorage.ByteToMegabit(baseValue);
                case UnitToolsDigitalStorageUnit.Megabyte:
                    return UnitToolsDigitalDigitalStorage.ByteToMegabyte(baseValue);
                case UnitToolsDigitalStorageUnit.Gigabit:
                    return UnitToolsDigitalDigitalStorage.ByteToGigabit(baseValue);
                case UnitToolsDigitalStorageUnit.Gigabyte:
                    return UnitToolsDigitalDigitalStorage.ByteToGigabyte(baseValue);
                case UnitToolsDigitalStorageUnit.Terabit:
                    return UnitToolsDigitalDigitalStorage.ByteToTerabit(baseValue);
                case UnitToolsDigitalStorageUnit.Terabyte:
                    return UnitToolsDigitalDigitalStorage.ByteToTerabyte(baseValue);
                case UnitToolsDigitalStorageUnit.Petabyte:
                    return UnitToolsDigitalDigitalStorage.ByteToPetabyte(baseValue);
                case UnitToolsDigitalStorageUnit.Kibibit:
                    return UnitToolsDigitalDigitalStorage.ByteToKibibit(baseValue);
                case UnitToolsDigitalStorageUnit.Kibibyte:
                    return UnitToolsDigitalDigitalStorage.ByteToKibibyte(baseValue);
                case UnitToolsDigitalStorageUnit.Mebibit:
                    return UnitToolsDigitalDigitalStorage.ByteToMebibit(baseValue);
                case UnitToolsDigitalStorageUnit.Mebibyte:
                    return UnitToolsDigitalDigitalStorage.ByteToMebibyte(baseValue);
                case UnitToolsDigitalStorageUnit.Gibibit:
                    return UnitToolsDigitalDigitalStorage.ByteToGibibit(baseValue);
                case UnitToolsDigitalStorageUnit.Gibibyte:
                    return UnitToolsDigitalDigitalStorage.ByteToGibibyte(baseValue);
                case UnitToolsDigitalStorageUnit.Tebibyte:
                    return UnitToolsDigitalDigitalStorage.ByteToTebibyte(baseValue);
                case UnitToolsDigitalStorageUnit.Pebibyte:
                    return UnitToolsDigitalDigitalStorage.ByteToPebibyte(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported digital storage unit.");
            }
        }

        public static string GetSymbol(UnitToolsDigitalStorageUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDigitalStorageUnit.Bit:
                    return "b";
                case UnitToolsDigitalStorageUnit.Nibble:
                    return "nibble";
                case UnitToolsDigitalStorageUnit.Byte:
                    return "B";
                case UnitToolsDigitalStorageUnit.Kilobit:
                    return "kb";
                case UnitToolsDigitalStorageUnit.Kilobyte:
                    return "KB";
                case UnitToolsDigitalStorageUnit.Megabit:
                    return "Mb";
                case UnitToolsDigitalStorageUnit.Megabyte:
                    return "MB";
                case UnitToolsDigitalStorageUnit.Gigabit:
                    return "Gb";
                case UnitToolsDigitalStorageUnit.Gigabyte:
                    return "GB";
                case UnitToolsDigitalStorageUnit.Terabit:
                    return "Tb";
                case UnitToolsDigitalStorageUnit.Terabyte:
                    return "TB";
                case UnitToolsDigitalStorageUnit.Petabyte:
                    return "PB";
                case UnitToolsDigitalStorageUnit.Kibibit:
                    return "Kib";
                case UnitToolsDigitalStorageUnit.Kibibyte:
                    return "KiB";
                case UnitToolsDigitalStorageUnit.Mebibit:
                    return "Mib";
                case UnitToolsDigitalStorageUnit.Mebibyte:
                    return "MiB";
                case UnitToolsDigitalStorageUnit.Gibibit:
                    return "Gib";
                case UnitToolsDigitalStorageUnit.Gibibyte:
                    return "GiB";
                case UnitToolsDigitalStorageUnit.Tebibyte:
                    return "TiB";
                case UnitToolsDigitalStorageUnit.Pebibyte:
                    return "PiB";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsDigitalStorageUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDigitalStorageUnit.Bit:
                    return "bit";
                case UnitToolsDigitalStorageUnit.Nibble:
                    return "nibble";
                case UnitToolsDigitalStorageUnit.Byte:
                    return "byte";
                case UnitToolsDigitalStorageUnit.Kilobit:
                    return "kilobit";
                case UnitToolsDigitalStorageUnit.Kilobyte:
                    return "kilobyte";
                case UnitToolsDigitalStorageUnit.Megabit:
                    return "megabit";
                case UnitToolsDigitalStorageUnit.Megabyte:
                    return "megabyte";
                case UnitToolsDigitalStorageUnit.Gigabit:
                    return "gigabit";
                case UnitToolsDigitalStorageUnit.Gigabyte:
                    return "gigabyte";
                case UnitToolsDigitalStorageUnit.Terabit:
                    return "terabit";
                case UnitToolsDigitalStorageUnit.Terabyte:
                    return "terabyte";
                case UnitToolsDigitalStorageUnit.Petabyte:
                    return "petabyte";
                case UnitToolsDigitalStorageUnit.Kibibit:
                    return "kibibit";
                case UnitToolsDigitalStorageUnit.Kibibyte:
                    return "kibibyte";
                case UnitToolsDigitalStorageUnit.Mebibit:
                    return "mebibit";
                case UnitToolsDigitalStorageUnit.Mebibyte:
                    return "mebibyte";
                case UnitToolsDigitalStorageUnit.Gibibit:
                    return "gibibit";
                case UnitToolsDigitalStorageUnit.Gibibyte:
                    return "gibibyte";
                case UnitToolsDigitalStorageUnit.Tebibyte:
                    return "tebibyte";
                case UnitToolsDigitalStorageUnit.Pebibyte:
                    return "pebibyte";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsDigitalStorageUnit unit)
        {
            switch (unit)
            {
                case UnitToolsDigitalStorageUnit.Bit:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Nibble:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Byte:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Kilobit:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Kilobyte:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Megabit:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Megabyte:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Gigabit:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Gigabyte:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Terabit:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Terabyte:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Petabyte:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Kibibit:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Kibibyte:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Mebibit:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Mebibyte:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Gibibit:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Gibibyte:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Tebibyte:
                    return UnitToolsUnitSystem.Digital;
                case UnitToolsDigitalStorageUnit.Pebibyte:
                    return UnitToolsUnitSystem.Digital;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsDigitalStorageUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Digital:
                    return new[] { UnitToolsDigitalStorageUnit.Bit, UnitToolsDigitalStorageUnit.Nibble, UnitToolsDigitalStorageUnit.Byte, UnitToolsDigitalStorageUnit.Kilobit, UnitToolsDigitalStorageUnit.Kilobyte, UnitToolsDigitalStorageUnit.Megabit, UnitToolsDigitalStorageUnit.Megabyte, UnitToolsDigitalStorageUnit.Gigabit, UnitToolsDigitalStorageUnit.Gigabyte, UnitToolsDigitalStorageUnit.Terabit, UnitToolsDigitalStorageUnit.Terabyte, UnitToolsDigitalStorageUnit.Petabyte, UnitToolsDigitalStorageUnit.Kibibit, UnitToolsDigitalStorageUnit.Kibibyte, UnitToolsDigitalStorageUnit.Mebibit, UnitToolsDigitalStorageUnit.Mebibyte, UnitToolsDigitalStorageUnit.Gibibit, UnitToolsDigitalStorageUnit.Gibibyte, UnitToolsDigitalStorageUnit.Tebibyte, UnitToolsDigitalStorageUnit.Pebibyte };
                default:
                    return new[] { UnitToolsDigitalStorageUnit.Bit, UnitToolsDigitalStorageUnit.Nibble, UnitToolsDigitalStorageUnit.Byte, UnitToolsDigitalStorageUnit.Kilobit, UnitToolsDigitalStorageUnit.Kilobyte, UnitToolsDigitalStorageUnit.Megabit, UnitToolsDigitalStorageUnit.Megabyte, UnitToolsDigitalStorageUnit.Gigabit, UnitToolsDigitalStorageUnit.Gigabyte, UnitToolsDigitalStorageUnit.Terabit, UnitToolsDigitalStorageUnit.Terabyte, UnitToolsDigitalStorageUnit.Petabyte, UnitToolsDigitalStorageUnit.Kibibit, UnitToolsDigitalStorageUnit.Kibibyte, UnitToolsDigitalStorageUnit.Mebibit, UnitToolsDigitalStorageUnit.Mebibyte, UnitToolsDigitalStorageUnit.Gibibit, UnitToolsDigitalStorageUnit.Gibibyte, UnitToolsDigitalStorageUnit.Tebibyte, UnitToolsDigitalStorageUnit.Pebibyte };
            }
        }
    }
}
