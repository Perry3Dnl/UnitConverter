namespace UnitConverter.DigitalStorage
{
    using UnitConverter.DigitalStorage.Digital;

    public enum UnitConverterDigitalStorageUnit
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

    public static class UnitConverterDigitalStorage
    {
        public static double Convert(double value, UnitConverterDigitalStorageUnit from, UnitConverterDigitalStorageUnit to)
        {
            double baseValue = ToByte(value, from);
            return FromByte(baseValue, to);
        }

        public static double ToByte(double value, UnitConverterDigitalStorageUnit from)
        {
            switch (from)
            {
                case UnitConverterDigitalStorageUnit.Bit:
                    return UnitConverterDigitalDigitalStorage.BitToByte(value);
                case UnitConverterDigitalStorageUnit.Nibble:
                    return UnitConverterDigitalDigitalStorage.NibbleToByte(value);
                case UnitConverterDigitalStorageUnit.Byte:
                    return UnitConverterDigitalDigitalStorage.ByteToByte(value);
                case UnitConverterDigitalStorageUnit.Kilobit:
                    return UnitConverterDigitalDigitalStorage.KilobitToByte(value);
                case UnitConverterDigitalStorageUnit.Kilobyte:
                    return UnitConverterDigitalDigitalStorage.KilobyteToByte(value);
                case UnitConverterDigitalStorageUnit.Megabit:
                    return UnitConverterDigitalDigitalStorage.MegabitToByte(value);
                case UnitConverterDigitalStorageUnit.Megabyte:
                    return UnitConverterDigitalDigitalStorage.MegabyteToByte(value);
                case UnitConverterDigitalStorageUnit.Gigabit:
                    return UnitConverterDigitalDigitalStorage.GigabitToByte(value);
                case UnitConverterDigitalStorageUnit.Gigabyte:
                    return UnitConverterDigitalDigitalStorage.GigabyteToByte(value);
                case UnitConverterDigitalStorageUnit.Terabit:
                    return UnitConverterDigitalDigitalStorage.TerabitToByte(value);
                case UnitConverterDigitalStorageUnit.Terabyte:
                    return UnitConverterDigitalDigitalStorage.TerabyteToByte(value);
                case UnitConverterDigitalStorageUnit.Petabyte:
                    return UnitConverterDigitalDigitalStorage.PetabyteToByte(value);
                case UnitConverterDigitalStorageUnit.Kibibit:
                    return UnitConverterDigitalDigitalStorage.KibibitToByte(value);
                case UnitConverterDigitalStorageUnit.Kibibyte:
                    return UnitConverterDigitalDigitalStorage.KibibyteToByte(value);
                case UnitConverterDigitalStorageUnit.Mebibit:
                    return UnitConverterDigitalDigitalStorage.MebibitToByte(value);
                case UnitConverterDigitalStorageUnit.Mebibyte:
                    return UnitConverterDigitalDigitalStorage.MebibyteToByte(value);
                case UnitConverterDigitalStorageUnit.Gibibit:
                    return UnitConverterDigitalDigitalStorage.GibibitToByte(value);
                case UnitConverterDigitalStorageUnit.Gibibyte:
                    return UnitConverterDigitalDigitalStorage.GibibyteToByte(value);
                case UnitConverterDigitalStorageUnit.Tebibyte:
                    return UnitConverterDigitalDigitalStorage.TebibyteToByte(value);
                case UnitConverterDigitalStorageUnit.Pebibyte:
                    return UnitConverterDigitalDigitalStorage.PebibyteToByte(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported digital storage unit.");
            }
        }

        public static double FromByte(double baseValue, UnitConverterDigitalStorageUnit to)
        {
            switch (to)
            {
                case UnitConverterDigitalStorageUnit.Bit:
                    return UnitConverterDigitalDigitalStorage.ByteToBit(baseValue);
                case UnitConverterDigitalStorageUnit.Nibble:
                    return UnitConverterDigitalDigitalStorage.ByteToNibble(baseValue);
                case UnitConverterDigitalStorageUnit.Byte:
                    return UnitConverterDigitalDigitalStorage.ByteToByte(baseValue);
                case UnitConverterDigitalStorageUnit.Kilobit:
                    return UnitConverterDigitalDigitalStorage.ByteToKilobit(baseValue);
                case UnitConverterDigitalStorageUnit.Kilobyte:
                    return UnitConverterDigitalDigitalStorage.ByteToKilobyte(baseValue);
                case UnitConverterDigitalStorageUnit.Megabit:
                    return UnitConverterDigitalDigitalStorage.ByteToMegabit(baseValue);
                case UnitConverterDigitalStorageUnit.Megabyte:
                    return UnitConverterDigitalDigitalStorage.ByteToMegabyte(baseValue);
                case UnitConverterDigitalStorageUnit.Gigabit:
                    return UnitConverterDigitalDigitalStorage.ByteToGigabit(baseValue);
                case UnitConverterDigitalStorageUnit.Gigabyte:
                    return UnitConverterDigitalDigitalStorage.ByteToGigabyte(baseValue);
                case UnitConverterDigitalStorageUnit.Terabit:
                    return UnitConverterDigitalDigitalStorage.ByteToTerabit(baseValue);
                case UnitConverterDigitalStorageUnit.Terabyte:
                    return UnitConverterDigitalDigitalStorage.ByteToTerabyte(baseValue);
                case UnitConverterDigitalStorageUnit.Petabyte:
                    return UnitConverterDigitalDigitalStorage.ByteToPetabyte(baseValue);
                case UnitConverterDigitalStorageUnit.Kibibit:
                    return UnitConverterDigitalDigitalStorage.ByteToKibibit(baseValue);
                case UnitConverterDigitalStorageUnit.Kibibyte:
                    return UnitConverterDigitalDigitalStorage.ByteToKibibyte(baseValue);
                case UnitConverterDigitalStorageUnit.Mebibit:
                    return UnitConverterDigitalDigitalStorage.ByteToMebibit(baseValue);
                case UnitConverterDigitalStorageUnit.Mebibyte:
                    return UnitConverterDigitalDigitalStorage.ByteToMebibyte(baseValue);
                case UnitConverterDigitalStorageUnit.Gibibit:
                    return UnitConverterDigitalDigitalStorage.ByteToGibibit(baseValue);
                case UnitConverterDigitalStorageUnit.Gibibyte:
                    return UnitConverterDigitalDigitalStorage.ByteToGibibyte(baseValue);
                case UnitConverterDigitalStorageUnit.Tebibyte:
                    return UnitConverterDigitalDigitalStorage.ByteToTebibyte(baseValue);
                case UnitConverterDigitalStorageUnit.Pebibyte:
                    return UnitConverterDigitalDigitalStorage.ByteToPebibyte(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported digital storage unit.");
            }
        }

        public static string GetSymbol(UnitConverterDigitalStorageUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDigitalStorageUnit.Bit:
                    return "b";
                case UnitConverterDigitalStorageUnit.Nibble:
                    return "nibble";
                case UnitConverterDigitalStorageUnit.Byte:
                    return "B";
                case UnitConverterDigitalStorageUnit.Kilobit:
                    return "kb";
                case UnitConverterDigitalStorageUnit.Kilobyte:
                    return "KB";
                case UnitConverterDigitalStorageUnit.Megabit:
                    return "Mb";
                case UnitConverterDigitalStorageUnit.Megabyte:
                    return "MB";
                case UnitConverterDigitalStorageUnit.Gigabit:
                    return "Gb";
                case UnitConverterDigitalStorageUnit.Gigabyte:
                    return "GB";
                case UnitConverterDigitalStorageUnit.Terabit:
                    return "Tb";
                case UnitConverterDigitalStorageUnit.Terabyte:
                    return "TB";
                case UnitConverterDigitalStorageUnit.Petabyte:
                    return "PB";
                case UnitConverterDigitalStorageUnit.Kibibit:
                    return "Kib";
                case UnitConverterDigitalStorageUnit.Kibibyte:
                    return "KiB";
                case UnitConverterDigitalStorageUnit.Mebibit:
                    return "Mib";
                case UnitConverterDigitalStorageUnit.Mebibyte:
                    return "MiB";
                case UnitConverterDigitalStorageUnit.Gibibit:
                    return "Gib";
                case UnitConverterDigitalStorageUnit.Gibibyte:
                    return "GiB";
                case UnitConverterDigitalStorageUnit.Tebibyte:
                    return "TiB";
                case UnitConverterDigitalStorageUnit.Pebibyte:
                    return "PiB";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterDigitalStorageUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDigitalStorageUnit.Bit:
                    return "bit";
                case UnitConverterDigitalStorageUnit.Nibble:
                    return "nibble";
                case UnitConverterDigitalStorageUnit.Byte:
                    return "byte";
                case UnitConverterDigitalStorageUnit.Kilobit:
                    return "kilobit";
                case UnitConverterDigitalStorageUnit.Kilobyte:
                    return "kilobyte";
                case UnitConverterDigitalStorageUnit.Megabit:
                    return "megabit";
                case UnitConverterDigitalStorageUnit.Megabyte:
                    return "megabyte";
                case UnitConverterDigitalStorageUnit.Gigabit:
                    return "gigabit";
                case UnitConverterDigitalStorageUnit.Gigabyte:
                    return "gigabyte";
                case UnitConverterDigitalStorageUnit.Terabit:
                    return "terabit";
                case UnitConverterDigitalStorageUnit.Terabyte:
                    return "terabyte";
                case UnitConverterDigitalStorageUnit.Petabyte:
                    return "petabyte";
                case UnitConverterDigitalStorageUnit.Kibibit:
                    return "kibibit";
                case UnitConverterDigitalStorageUnit.Kibibyte:
                    return "kibibyte";
                case UnitConverterDigitalStorageUnit.Mebibit:
                    return "mebibit";
                case UnitConverterDigitalStorageUnit.Mebibyte:
                    return "mebibyte";
                case UnitConverterDigitalStorageUnit.Gibibit:
                    return "gibibit";
                case UnitConverterDigitalStorageUnit.Gibibyte:
                    return "gibibyte";
                case UnitConverterDigitalStorageUnit.Tebibyte:
                    return "tebibyte";
                case UnitConverterDigitalStorageUnit.Pebibyte:
                    return "pebibyte";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterDigitalStorageUnit unit)
        {
            switch (unit)
            {
                case UnitConverterDigitalStorageUnit.Bit:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Nibble:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Byte:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Kilobit:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Kilobyte:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Megabit:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Megabyte:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Gigabit:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Gigabyte:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Terabit:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Terabyte:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Petabyte:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Kibibit:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Kibibyte:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Mebibit:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Mebibyte:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Gibibit:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Gibibyte:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Tebibyte:
                    return UnitConverterUnitSystem.Digital;
                case UnitConverterDigitalStorageUnit.Pebibyte:
                    return UnitConverterUnitSystem.Digital;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterDigitalStorageUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Digital:
                    return new[] { UnitConverterDigitalStorageUnit.Bit, UnitConverterDigitalStorageUnit.Nibble, UnitConverterDigitalStorageUnit.Byte, UnitConverterDigitalStorageUnit.Kilobit, UnitConverterDigitalStorageUnit.Kilobyte, UnitConverterDigitalStorageUnit.Megabit, UnitConverterDigitalStorageUnit.Megabyte, UnitConverterDigitalStorageUnit.Gigabit, UnitConverterDigitalStorageUnit.Gigabyte, UnitConverterDigitalStorageUnit.Terabit, UnitConverterDigitalStorageUnit.Terabyte, UnitConverterDigitalStorageUnit.Petabyte, UnitConverterDigitalStorageUnit.Kibibit, UnitConverterDigitalStorageUnit.Kibibyte, UnitConverterDigitalStorageUnit.Mebibit, UnitConverterDigitalStorageUnit.Mebibyte, UnitConverterDigitalStorageUnit.Gibibit, UnitConverterDigitalStorageUnit.Gibibyte, UnitConverterDigitalStorageUnit.Tebibyte, UnitConverterDigitalStorageUnit.Pebibyte };
                default:
                    return new[] { UnitConverterDigitalStorageUnit.Bit, UnitConverterDigitalStorageUnit.Nibble, UnitConverterDigitalStorageUnit.Byte, UnitConverterDigitalStorageUnit.Kilobit, UnitConverterDigitalStorageUnit.Kilobyte, UnitConverterDigitalStorageUnit.Megabit, UnitConverterDigitalStorageUnit.Megabyte, UnitConverterDigitalStorageUnit.Gigabit, UnitConverterDigitalStorageUnit.Gigabyte, UnitConverterDigitalStorageUnit.Terabit, UnitConverterDigitalStorageUnit.Terabyte, UnitConverterDigitalStorageUnit.Petabyte, UnitConverterDigitalStorageUnit.Kibibit, UnitConverterDigitalStorageUnit.Kibibyte, UnitConverterDigitalStorageUnit.Mebibit, UnitConverterDigitalStorageUnit.Mebibyte, UnitConverterDigitalStorageUnit.Gibibit, UnitConverterDigitalStorageUnit.Gibibyte, UnitConverterDigitalStorageUnit.Tebibyte, UnitConverterDigitalStorageUnit.Pebibyte };
            }
        }
    }
}
