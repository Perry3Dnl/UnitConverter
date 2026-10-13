namespace UnitTools.TemperatureDelta
{
    public enum UnitToolsTemperatureDeltaUnit
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

    public static class UnitToolsTemperatureDelta
    {
        public static double Convert(
            double value,
            UnitToolsTemperatureDeltaUnit from,
            UnitToolsTemperatureDeltaUnit to)
        {
            double kelvin = ToKelvin(value, from);
            return FromKelvin(kelvin, to);
        }

        public static double ToKelvin(double value, UnitToolsTemperatureDeltaUnit from)
        {
            switch (from)
            {
                case UnitToolsTemperatureDeltaUnit.Kelvin:
                case UnitToolsTemperatureDeltaUnit.Celsius:
                    return value;
                case UnitToolsTemperatureDeltaUnit.Fahrenheit:
                case UnitToolsTemperatureDeltaUnit.Rankine:
                    return value * 5d / 9d;
                case UnitToolsTemperatureDeltaUnit.Delisle:
                    return value * -2d / 3d;
                case UnitToolsTemperatureDeltaUnit.Newton:
                    return value * 100d / 33d;
                case UnitToolsTemperatureDeltaUnit.Reaumur:
                    return value * 5d / 4d;
                case UnitToolsTemperatureDeltaUnit.Romer:
                    return value * 40d / 21d;
                case UnitToolsTemperatureDeltaUnit.Millikelvin:
                    return value * 0.001d;
                case UnitToolsTemperatureDeltaUnit.Microkelvin:
                    return value * 0.000001d;
                case UnitToolsTemperatureDeltaUnit.Nanokelvin:
                    return value * 0.000000001d;
                case UnitToolsTemperatureDeltaUnit.Kilokelvin:
                    return value * 1000d;
                case UnitToolsTemperatureDeltaUnit.Megakelvin:
                    return value * 1000000d;
                case UnitToolsTemperatureDeltaUnit.Gigakelvin:
                    return value * 1000000000d;
                case UnitToolsTemperatureDeltaUnit.PlanckTemperature:
                    return value * 1.416784e32d;
                case UnitToolsTemperatureDeltaUnit.ElectronVoltTemperature:
                    return value * 11604.518121550082d;
                case UnitToolsTemperatureDeltaUnit.MillielectronVoltTemperature:
                    return value * 11.604518121550082d;
                case UnitToolsTemperatureDeltaUnit.KiloelectronVoltTemperature:
                    return value * 11604518.121550081d;
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported temperature-delta unit.");
            }
        }

        public static double FromKelvin(double kelvin, UnitToolsTemperatureDeltaUnit to)
        {
            switch (to)
            {
                case UnitToolsTemperatureDeltaUnit.Kelvin:
                case UnitToolsTemperatureDeltaUnit.Celsius:
                    return kelvin;
                case UnitToolsTemperatureDeltaUnit.Fahrenheit:
                case UnitToolsTemperatureDeltaUnit.Rankine:
                    return kelvin * 9d / 5d;
                case UnitToolsTemperatureDeltaUnit.Delisle:
                    return kelvin * -3d / 2d;
                case UnitToolsTemperatureDeltaUnit.Newton:
                    return kelvin * 33d / 100d;
                case UnitToolsTemperatureDeltaUnit.Reaumur:
                    return kelvin * 4d / 5d;
                case UnitToolsTemperatureDeltaUnit.Romer:
                    return kelvin * 21d / 40d;
                case UnitToolsTemperatureDeltaUnit.Millikelvin:
                    return kelvin / 0.001d;
                case UnitToolsTemperatureDeltaUnit.Microkelvin:
                    return kelvin / 0.000001d;
                case UnitToolsTemperatureDeltaUnit.Nanokelvin:
                    return kelvin / 0.000000001d;
                case UnitToolsTemperatureDeltaUnit.Kilokelvin:
                    return kelvin / 1000d;
                case UnitToolsTemperatureDeltaUnit.Megakelvin:
                    return kelvin / 1000000d;
                case UnitToolsTemperatureDeltaUnit.Gigakelvin:
                    return kelvin / 1000000000d;
                case UnitToolsTemperatureDeltaUnit.PlanckTemperature:
                    return kelvin / 1.416784e32d;
                case UnitToolsTemperatureDeltaUnit.ElectronVoltTemperature:
                    return kelvin / 11604.518121550082d;
                case UnitToolsTemperatureDeltaUnit.MillielectronVoltTemperature:
                    return kelvin / 11.604518121550082d;
                case UnitToolsTemperatureDeltaUnit.KiloelectronVoltTemperature:
                    return kelvin / 11604518.121550081d;
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported temperature-delta unit.");
            }
        }

        public static UnitToolsConversionResult TryConvert(
            double value,
            UnitToolsTemperatureDeltaUnit from,
            UnitToolsTemperatureDeltaUnit to)
        {
            try
            {
                return UnitToolsConversionResult.Ok(Convert(value, from, to));
            }
            catch (System.Exception exception)
            {
                return UnitToolsConversionResult.Fail(exception.Message);
            }
        }

        public static string GetSymbol(UnitToolsTemperatureDeltaUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTemperatureDeltaUnit.Kelvin: return "ΔK";
                case UnitToolsTemperatureDeltaUnit.Celsius: return "Δ°C";
                case UnitToolsTemperatureDeltaUnit.Fahrenheit: return "Δ°F";
                case UnitToolsTemperatureDeltaUnit.Rankine: return "Δ°R";
                case UnitToolsTemperatureDeltaUnit.Delisle: return "Δ°De";
                case UnitToolsTemperatureDeltaUnit.Newton: return "Δ°N";
                case UnitToolsTemperatureDeltaUnit.Reaumur: return "Δ°Ré";
                case UnitToolsTemperatureDeltaUnit.Romer: return "Δ°Rø";
                case UnitToolsTemperatureDeltaUnit.Millikelvin: return "ΔmK";
                case UnitToolsTemperatureDeltaUnit.Microkelvin: return "ΔµK";
                case UnitToolsTemperatureDeltaUnit.Nanokelvin: return "ΔnK";
                case UnitToolsTemperatureDeltaUnit.Kilokelvin: return "ΔkK";
                case UnitToolsTemperatureDeltaUnit.Megakelvin: return "ΔMK";
                case UnitToolsTemperatureDeltaUnit.Gigakelvin: return "ΔGK";
                case UnitToolsTemperatureDeltaUnit.PlanckTemperature: return "ΔTP";
                case UnitToolsTemperatureDeltaUnit.ElectronVoltTemperature: return "ΔeV/kB";
                case UnitToolsTemperatureDeltaUnit.MillielectronVoltTemperature: return "ΔmeV/kB";
                case UnitToolsTemperatureDeltaUnit.KiloelectronVoltTemperature: return "ΔkeV/kB";
                default: return "?";
            }
        }

        public static string GetDisplayName(UnitToolsTemperatureDeltaUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTemperatureDeltaUnit.Kelvin: return "Kelvin difference";
                case UnitToolsTemperatureDeltaUnit.Celsius: return "Celsius difference";
                case UnitToolsTemperatureDeltaUnit.Fahrenheit: return "Fahrenheit difference";
                case UnitToolsTemperatureDeltaUnit.Rankine: return "Rankine difference";
                case UnitToolsTemperatureDeltaUnit.Delisle: return "Delisle difference";
                case UnitToolsTemperatureDeltaUnit.Newton: return "Newton difference";
                case UnitToolsTemperatureDeltaUnit.Reaumur: return "Reaumur difference";
                case UnitToolsTemperatureDeltaUnit.Romer: return "Romer difference";
                case UnitToolsTemperatureDeltaUnit.Millikelvin: return "millikelvin difference";
                case UnitToolsTemperatureDeltaUnit.Microkelvin: return "microkelvin difference";
                case UnitToolsTemperatureDeltaUnit.Nanokelvin: return "nanokelvin difference";
                case UnitToolsTemperatureDeltaUnit.Kilokelvin: return "kilokelvin difference";
                case UnitToolsTemperatureDeltaUnit.Megakelvin: return "megakelvin difference";
                case UnitToolsTemperatureDeltaUnit.Gigakelvin: return "gigakelvin difference";
                case UnitToolsTemperatureDeltaUnit.PlanckTemperature: return "Planck temperature difference";
                case UnitToolsTemperatureDeltaUnit.ElectronVoltTemperature: return "electron-volt temperature difference";
                case UnitToolsTemperatureDeltaUnit.MillielectronVoltTemperature: return "millielectron-volt temperature difference";
                case UnitToolsTemperatureDeltaUnit.KiloelectronVoltTemperature: return "kiloelectron-volt temperature difference";
                default: return unit.ToString();
            }
        }
    }
}
