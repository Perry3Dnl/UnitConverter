namespace UnitConverter.TemperatureDelta
{
    public enum UnitConverterTemperatureDeltaUnit
    {
        Kelvin = 0,
        Celsius = 1,
        Fahrenheit = 2,
        Rankine = 3,
        Delisle = 4,
        Newton = 5,
        Reaumur = 6,
        Romer = 7,
        Millikelvin = 8,
        Microkelvin = 9,
        Nanokelvin = 10,
        Kilokelvin = 11,
        Megakelvin = 12,
        Gigakelvin = 13,
        PlanckTemperature = 14,
        ElectronVoltTemperature = 15,
        MillielectronVoltTemperature = 16,
        KiloelectronVoltTemperature = 17,
    }

    public static class UnitConverterTemperatureDelta
    {
        public static double Convert(
            double value,
            UnitConverterTemperatureDeltaUnit from,
            UnitConverterTemperatureDeltaUnit to)
        {
            double kelvin = ToKelvin(value, from);
            return FromKelvin(kelvin, to);
        }

        public static double ToKelvin(double value, UnitConverterTemperatureDeltaUnit from)
        {
            switch (from)
            {
                case UnitConverterTemperatureDeltaUnit.Kelvin:
                case UnitConverterTemperatureDeltaUnit.Celsius:
                    return value;
                case UnitConverterTemperatureDeltaUnit.Fahrenheit:
                case UnitConverterTemperatureDeltaUnit.Rankine:
                    return value * 5d / 9d;
                case UnitConverterTemperatureDeltaUnit.Delisle:
                    return value * -2d / 3d;
                case UnitConverterTemperatureDeltaUnit.Newton:
                    return value * 100d / 33d;
                case UnitConverterTemperatureDeltaUnit.Reaumur:
                    return value * 5d / 4d;
                case UnitConverterTemperatureDeltaUnit.Romer:
                    return value * 40d / 21d;
                case UnitConverterTemperatureDeltaUnit.Millikelvin:
                    return value * 0.001d;
                case UnitConverterTemperatureDeltaUnit.Microkelvin:
                    return value * 0.000001d;
                case UnitConverterTemperatureDeltaUnit.Nanokelvin:
                    return value * 0.000000001d;
                case UnitConverterTemperatureDeltaUnit.Kilokelvin:
                    return value * 1000d;
                case UnitConverterTemperatureDeltaUnit.Megakelvin:
                    return value * 1000000d;
                case UnitConverterTemperatureDeltaUnit.Gigakelvin:
                    return value * 1000000000d;
                case UnitConverterTemperatureDeltaUnit.PlanckTemperature:
                    return value * 1.416784e32d;
                case UnitConverterTemperatureDeltaUnit.ElectronVoltTemperature:
                    return value * 11604.518121550082d;
                case UnitConverterTemperatureDeltaUnit.MillielectronVoltTemperature:
                    return value * 11.604518121550082d;
                case UnitConverterTemperatureDeltaUnit.KiloelectronVoltTemperature:
                    return value * 11604518.121550081d;
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported temperature-delta unit.");
            }
        }

        public static double FromKelvin(double kelvin, UnitConverterTemperatureDeltaUnit to)
        {
            switch (to)
            {
                case UnitConverterTemperatureDeltaUnit.Kelvin:
                case UnitConverterTemperatureDeltaUnit.Celsius:
                    return kelvin;
                case UnitConverterTemperatureDeltaUnit.Fahrenheit:
                case UnitConverterTemperatureDeltaUnit.Rankine:
                    return kelvin * 9d / 5d;
                case UnitConverterTemperatureDeltaUnit.Delisle:
                    return kelvin * -3d / 2d;
                case UnitConverterTemperatureDeltaUnit.Newton:
                    return kelvin * 33d / 100d;
                case UnitConverterTemperatureDeltaUnit.Reaumur:
                    return kelvin * 4d / 5d;
                case UnitConverterTemperatureDeltaUnit.Romer:
                    return kelvin * 21d / 40d;
                case UnitConverterTemperatureDeltaUnit.Millikelvin:
                    return kelvin / 0.001d;
                case UnitConverterTemperatureDeltaUnit.Microkelvin:
                    return kelvin / 0.000001d;
                case UnitConverterTemperatureDeltaUnit.Nanokelvin:
                    return kelvin / 0.000000001d;
                case UnitConverterTemperatureDeltaUnit.Kilokelvin:
                    return kelvin / 1000d;
                case UnitConverterTemperatureDeltaUnit.Megakelvin:
                    return kelvin / 1000000d;
                case UnitConverterTemperatureDeltaUnit.Gigakelvin:
                    return kelvin / 1000000000d;
                case UnitConverterTemperatureDeltaUnit.PlanckTemperature:
                    return kelvin / 1.416784e32d;
                case UnitConverterTemperatureDeltaUnit.ElectronVoltTemperature:
                    return kelvin / 11604.518121550082d;
                case UnitConverterTemperatureDeltaUnit.MillielectronVoltTemperature:
                    return kelvin / 11.604518121550082d;
                case UnitConverterTemperatureDeltaUnit.KiloelectronVoltTemperature:
                    return kelvin / 11604518.121550081d;
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported temperature-delta unit.");
            }
        }

        public static UnitConverterConversionResult TryConvert(
            double value,
            UnitConverterTemperatureDeltaUnit from,
            UnitConverterTemperatureDeltaUnit to)
        {
            try
            {
                return UnitConverterConversionResult.Ok(Convert(value, from, to));
            }
            catch (System.Exception exception)
            {
                return UnitConverterConversionResult.Fail(exception.Message);
            }
        }

        public static string GetSymbol(UnitConverterTemperatureDeltaUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTemperatureDeltaUnit.Kelvin: return "ΔK";
                case UnitConverterTemperatureDeltaUnit.Celsius: return "Δ°C";
                case UnitConverterTemperatureDeltaUnit.Fahrenheit: return "Δ°F";
                case UnitConverterTemperatureDeltaUnit.Rankine: return "Δ°R";
                case UnitConverterTemperatureDeltaUnit.Delisle: return "Δ°De";
                case UnitConverterTemperatureDeltaUnit.Newton: return "Δ°N";
                case UnitConverterTemperatureDeltaUnit.Reaumur: return "Δ°Ré";
                case UnitConverterTemperatureDeltaUnit.Romer: return "Δ°Rø";
                case UnitConverterTemperatureDeltaUnit.Millikelvin: return "ΔmK";
                case UnitConverterTemperatureDeltaUnit.Microkelvin: return "ΔµK";
                case UnitConverterTemperatureDeltaUnit.Nanokelvin: return "ΔnK";
                case UnitConverterTemperatureDeltaUnit.Kilokelvin: return "ΔkK";
                case UnitConverterTemperatureDeltaUnit.Megakelvin: return "ΔMK";
                case UnitConverterTemperatureDeltaUnit.Gigakelvin: return "ΔGK";
                case UnitConverterTemperatureDeltaUnit.PlanckTemperature: return "ΔTP";
                case UnitConverterTemperatureDeltaUnit.ElectronVoltTemperature: return "ΔeV/kB";
                case UnitConverterTemperatureDeltaUnit.MillielectronVoltTemperature: return "ΔmeV/kB";
                case UnitConverterTemperatureDeltaUnit.KiloelectronVoltTemperature: return "ΔkeV/kB";
                default: return "?";
            }
        }

        public static string GetDisplayName(UnitConverterTemperatureDeltaUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTemperatureDeltaUnit.Kelvin: return "Kelvin difference";
                case UnitConverterTemperatureDeltaUnit.Celsius: return "Celsius difference";
                case UnitConverterTemperatureDeltaUnit.Fahrenheit: return "Fahrenheit difference";
                case UnitConverterTemperatureDeltaUnit.Rankine: return "Rankine difference";
                case UnitConverterTemperatureDeltaUnit.Delisle: return "Delisle difference";
                case UnitConverterTemperatureDeltaUnit.Newton: return "Newton difference";
                case UnitConverterTemperatureDeltaUnit.Reaumur: return "Reaumur difference";
                case UnitConverterTemperatureDeltaUnit.Romer: return "Romer difference";
                case UnitConverterTemperatureDeltaUnit.Millikelvin: return "millikelvin difference";
                case UnitConverterTemperatureDeltaUnit.Microkelvin: return "microkelvin difference";
                case UnitConverterTemperatureDeltaUnit.Nanokelvin: return "nanokelvin difference";
                case UnitConverterTemperatureDeltaUnit.Kilokelvin: return "kilokelvin difference";
                case UnitConverterTemperatureDeltaUnit.Megakelvin: return "megakelvin difference";
                case UnitConverterTemperatureDeltaUnit.Gigakelvin: return "gigakelvin difference";
                case UnitConverterTemperatureDeltaUnit.PlanckTemperature: return "Planck temperature difference";
                case UnitConverterTemperatureDeltaUnit.ElectronVoltTemperature: return "electron-volt temperature difference";
                case UnitConverterTemperatureDeltaUnit.MillielectronVoltTemperature: return "millielectron-volt temperature difference";
                case UnitConverterTemperatureDeltaUnit.KiloelectronVoltTemperature: return "kiloelectron-volt temperature difference";
                default: return unit.ToString();
            }
        }
    }
}
