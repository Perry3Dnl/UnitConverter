namespace UnitTools.Temperature
{
    public enum UnitToolsTemperatureUnit
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

    public static class UnitToolsTemperature
    {
        public static double Convert(double value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
        {
            double kelvin = ToKelvin(value, from);
            return FromKelvin(kelvin, to);
        }

        public static double ToKelvin(double value, UnitToolsTemperatureUnit from)
        {
            switch (from)
            {
                case UnitToolsTemperatureUnit.Kelvin: return KelvinToKelvin(value);
                case UnitToolsTemperatureUnit.Celsius: return CelsiusToKelvin(value);
                case UnitToolsTemperatureUnit.Fahrenheit: return FahrenheitToKelvin(value);
                case UnitToolsTemperatureUnit.Rankine: return RankineToKelvin(value);
                case UnitToolsTemperatureUnit.Delisle: return DelisleToKelvin(value);
                case UnitToolsTemperatureUnit.Newton: return NewtonToKelvin(value);
                case UnitToolsTemperatureUnit.Reaumur: return ReaumurToKelvin(value);
                case UnitToolsTemperatureUnit.Romer: return RomerToKelvin(value);
                case UnitToolsTemperatureUnit.Millikelvin: return MillikelvinToKelvin(value);
                case UnitToolsTemperatureUnit.Microkelvin: return MicrokelvinToKelvin(value);
                case UnitToolsTemperatureUnit.Nanokelvin: return NanokelvinToKelvin(value);
                case UnitToolsTemperatureUnit.Kilokelvin: return KilokelvinToKelvin(value);
                case UnitToolsTemperatureUnit.Megakelvin: return MegakelvinToKelvin(value);
                case UnitToolsTemperatureUnit.Gigakelvin: return GigakelvinToKelvin(value);
                case UnitToolsTemperatureUnit.PlanckTemperature: return PlanckTemperatureToKelvin(value);
                case UnitToolsTemperatureUnit.ElectronVoltTemperature: return ElectronVoltTemperatureToKelvin(value);
                case UnitToolsTemperatureUnit.MillielectronVoltTemperature: return MillielectronVoltTemperatureToKelvin(value);
                case UnitToolsTemperatureUnit.KiloelectronVoltTemperature: return KiloelectronVoltTemperatureToKelvin(value);
                default: throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported temperature unit.");
            }
        }

        public static double FromKelvin(double kelvin, UnitToolsTemperatureUnit to)
        {
            switch (to)
            {
                case UnitToolsTemperatureUnit.Kelvin: return KelvinToKelvin(kelvin);
                case UnitToolsTemperatureUnit.Celsius: return KelvinToCelsius(kelvin);
                case UnitToolsTemperatureUnit.Fahrenheit: return KelvinToFahrenheit(kelvin);
                case UnitToolsTemperatureUnit.Rankine: return KelvinToRankine(kelvin);
                case UnitToolsTemperatureUnit.Delisle: return KelvinToDelisle(kelvin);
                case UnitToolsTemperatureUnit.Newton: return KelvinToNewton(kelvin);
                case UnitToolsTemperatureUnit.Reaumur: return KelvinToReaumur(kelvin);
                case UnitToolsTemperatureUnit.Romer: return KelvinToRomer(kelvin);
                case UnitToolsTemperatureUnit.Millikelvin: return KelvinToMillikelvin(kelvin);
                case UnitToolsTemperatureUnit.Microkelvin: return KelvinToMicrokelvin(kelvin);
                case UnitToolsTemperatureUnit.Nanokelvin: return KelvinToNanokelvin(kelvin);
                case UnitToolsTemperatureUnit.Kilokelvin: return KelvinToKilokelvin(kelvin);
                case UnitToolsTemperatureUnit.Megakelvin: return KelvinToMegakelvin(kelvin);
                case UnitToolsTemperatureUnit.Gigakelvin: return KelvinToGigakelvin(kelvin);
                case UnitToolsTemperatureUnit.PlanckTemperature: return KelvinToPlanckTemperature(kelvin);
                case UnitToolsTemperatureUnit.ElectronVoltTemperature: return KelvinToElectronVoltTemperature(kelvin);
                case UnitToolsTemperatureUnit.MillielectronVoltTemperature: return KelvinToMillielectronVoltTemperature(kelvin);
                case UnitToolsTemperatureUnit.KiloelectronVoltTemperature: return KelvinToKiloelectronVoltTemperature(kelvin);
                default: throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported temperature unit.");
            }
        }

        public static UnitToolsConversionResult TryConvert(double value, UnitToolsTemperatureUnit from, UnitToolsTemperatureUnit to)
        {
            try { return UnitToolsConversionResult.Ok(Convert(value, from, to)); }
            catch (System.Exception exception) { return UnitToolsConversionResult.Fail(exception.Message); }
        }

        public static double KelvinToKelvin(double value)
        {
            return value;
        }

        public static double CelsiusToKelvin(double value)
        {
            return value + 273.15d;
        }

        public static double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15d;
        }

        public static double FahrenheitToKelvin(double value)
        {
            return (value + 459.67d) * 5d / 9d;
        }

        public static double KelvinToFahrenheit(double kelvin)
        {
            return kelvin * 9d / 5d - 459.67d;
        }

        public static double RankineToKelvin(double value)
        {
            return value * 5d / 9d;
        }

        public static double KelvinToRankine(double kelvin)
        {
            return kelvin * 9d / 5d;
        }

        public static double DelisleToKelvin(double value)
        {
            return 373.15d - value * 2d / 3d;
        }

        public static double KelvinToDelisle(double kelvin)
        {
            return (373.15d - kelvin) * 3d / 2d;
        }

        public static double NewtonToKelvin(double value)
        {
            return value * 100d / 33d + 273.15d;
        }

        public static double KelvinToNewton(double kelvin)
        {
            return (kelvin - 273.15d) * 33d / 100d;
        }

        public static double ReaumurToKelvin(double value)
        {
            return value * 5d / 4d + 273.15d;
        }

        public static double KelvinToReaumur(double kelvin)
        {
            return (kelvin - 273.15d) * 4d / 5d;
        }

        public static double RomerToKelvin(double value)
        {
            return (value - 7.5d) * 40d / 21d + 273.15d;
        }

        public static double KelvinToRomer(double kelvin)
        {
            return (kelvin - 273.15d) * 21d / 40d + 7.5d;
        }

        public static double MillikelvinToKelvin(double value)
        {
            return value * 0.001d;
        }

        public static double KelvinToMillikelvin(double kelvin)
        {
            return kelvin / 0.001d;
        }

        public static double MicrokelvinToKelvin(double value)
        {
            return value * 0.000001d;
        }

        public static double KelvinToMicrokelvin(double kelvin)
        {
            return kelvin / 0.000001d;
        }

        public static double NanokelvinToKelvin(double value)
        {
            return value * 0.000000001d;
        }

        public static double KelvinToNanokelvin(double kelvin)
        {
            return kelvin / 0.000000001d;
        }

        public static double KilokelvinToKelvin(double value)
        {
            return value * 1000d;
        }

        public static double KelvinToKilokelvin(double kelvin)
        {
            return kelvin / 1000d;
        }

        public static double MegakelvinToKelvin(double value)
        {
            return value * 1000000d;
        }

        public static double KelvinToMegakelvin(double kelvin)
        {
            return kelvin / 1000000d;
        }

        public static double GigakelvinToKelvin(double value)
        {
            return value * 1000000000d;
        }

        public static double KelvinToGigakelvin(double kelvin)
        {
            return kelvin / 1000000000d;
        }

        public static double PlanckTemperatureToKelvin(double value)
        {
            return value * 1.416784e32d;
        }

        public static double KelvinToPlanckTemperature(double kelvin)
        {
            return kelvin / 1.416784e32d;
        }

        public static double ElectronVoltTemperatureToKelvin(double value)
        {
            return value * 11604.518121550082d;
        }

        public static double KelvinToElectronVoltTemperature(double kelvin)
        {
            return kelvin / 11604.518121550082d;
        }

        public static double MillielectronVoltTemperatureToKelvin(double value)
        {
            return value * 11.604518121550082d;
        }

        public static double KelvinToMillielectronVoltTemperature(double kelvin)
        {
            return kelvin / 11.604518121550082d;
        }

        public static double KiloelectronVoltTemperatureToKelvin(double value)
        {
            return value * 11604518.121550081d;
        }

        public static double KelvinToKiloelectronVoltTemperature(double kelvin)
        {
            return kelvin / 11604518.121550081d;
        }

        public static string GetSymbol(UnitToolsTemperatureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTemperatureUnit.Kelvin: return "K";
                case UnitToolsTemperatureUnit.Celsius: return "°C";
                case UnitToolsTemperatureUnit.Fahrenheit: return "°F";
                case UnitToolsTemperatureUnit.Rankine: return "°R";
                case UnitToolsTemperatureUnit.Delisle: return "°De";
                case UnitToolsTemperatureUnit.Newton: return "°N";
                case UnitToolsTemperatureUnit.Reaumur: return "°Ré";
                case UnitToolsTemperatureUnit.Romer: return "°Rø";
                case UnitToolsTemperatureUnit.Millikelvin: return "mK";
                case UnitToolsTemperatureUnit.Microkelvin: return "µK";
                case UnitToolsTemperatureUnit.Nanokelvin: return "nK";
                case UnitToolsTemperatureUnit.Kilokelvin: return "kK";
                case UnitToolsTemperatureUnit.Megakelvin: return "MK";
                case UnitToolsTemperatureUnit.Gigakelvin: return "GK";
                case UnitToolsTemperatureUnit.PlanckTemperature: return "TP";
                case UnitToolsTemperatureUnit.ElectronVoltTemperature: return "eV/kB";
                case UnitToolsTemperatureUnit.MillielectronVoltTemperature: return "meV/kB";
                case UnitToolsTemperatureUnit.KiloelectronVoltTemperature: return "keV/kB";
                default: return "?";
            }
        }

        public static string GetDisplayName(UnitToolsTemperatureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTemperatureUnit.Kelvin: return "Kelvin";
                case UnitToolsTemperatureUnit.Celsius: return "Celsius";
                case UnitToolsTemperatureUnit.Fahrenheit: return "Fahrenheit";
                case UnitToolsTemperatureUnit.Rankine: return "Rankine";
                case UnitToolsTemperatureUnit.Delisle: return "Delisle";
                case UnitToolsTemperatureUnit.Newton: return "Newton";
                case UnitToolsTemperatureUnit.Reaumur: return "Réaumur";
                case UnitToolsTemperatureUnit.Romer: return "Rømer";
                case UnitToolsTemperatureUnit.Millikelvin: return "Millikelvin";
                case UnitToolsTemperatureUnit.Microkelvin: return "Microkelvin";
                case UnitToolsTemperatureUnit.Nanokelvin: return "Nanokelvin";
                case UnitToolsTemperatureUnit.Kilokelvin: return "Kilokelvin";
                case UnitToolsTemperatureUnit.Megakelvin: return "Megakelvin";
                case UnitToolsTemperatureUnit.Gigakelvin: return "Gigakelvin";
                case UnitToolsTemperatureUnit.PlanckTemperature: return "Planck Temperature";
                case UnitToolsTemperatureUnit.ElectronVoltTemperature: return "Electron Volt Temperature";
                case UnitToolsTemperatureUnit.MillielectronVoltTemperature: return "Millielectron Volt Temperature";
                case UnitToolsTemperatureUnit.KiloelectronVoltTemperature: return "Kiloelectron Volt Temperature";
                default: return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsTemperatureUnit unit)
        {
            switch (unit)
            {
                case UnitToolsTemperatureUnit.Kelvin: return UnitToolsUnitSystem.Metric;
                case UnitToolsTemperatureUnit.Celsius: return UnitToolsUnitSystem.Metric;
                case UnitToolsTemperatureUnit.Fahrenheit: return UnitToolsUnitSystem.Imperial;
                case UnitToolsTemperatureUnit.Rankine: return UnitToolsUnitSystem.Imperial;
                case UnitToolsTemperatureUnit.Delisle: return UnitToolsUnitSystem.Historical;
                case UnitToolsTemperatureUnit.Newton: return UnitToolsUnitSystem.Historical;
                case UnitToolsTemperatureUnit.Reaumur: return UnitToolsUnitSystem.Historical;
                case UnitToolsTemperatureUnit.Romer: return UnitToolsUnitSystem.Historical;
                case UnitToolsTemperatureUnit.Millikelvin: return UnitToolsUnitSystem.Metric;
                case UnitToolsTemperatureUnit.Microkelvin: return UnitToolsUnitSystem.Metric;
                case UnitToolsTemperatureUnit.Nanokelvin: return UnitToolsUnitSystem.Metric;
                case UnitToolsTemperatureUnit.Kilokelvin: return UnitToolsUnitSystem.Metric;
                case UnitToolsTemperatureUnit.Megakelvin: return UnitToolsUnitSystem.Metric;
                case UnitToolsTemperatureUnit.Gigakelvin: return UnitToolsUnitSystem.Metric;
                case UnitToolsTemperatureUnit.PlanckTemperature: return UnitToolsUnitSystem.Scientific;
                case UnitToolsTemperatureUnit.ElectronVoltTemperature: return UnitToolsUnitSystem.Scientific;
                case UnitToolsTemperatureUnit.MillielectronVoltTemperature: return UnitToolsUnitSystem.Scientific;
                case UnitToolsTemperatureUnit.KiloelectronVoltTemperature: return UnitToolsUnitSystem.Scientific;
                default: return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsTemperatureUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsTemperatureUnit.Kelvin, UnitToolsTemperatureUnit.Celsius, UnitToolsTemperatureUnit.Millikelvin, UnitToolsTemperatureUnit.Microkelvin, UnitToolsTemperatureUnit.Nanokelvin, UnitToolsTemperatureUnit.Kilokelvin, UnitToolsTemperatureUnit.Megakelvin, UnitToolsTemperatureUnit.Gigakelvin };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsTemperatureUnit.Fahrenheit, UnitToolsTemperatureUnit.Rankine };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsTemperatureUnit.Delisle, UnitToolsTemperatureUnit.Newton, UnitToolsTemperatureUnit.Reaumur, UnitToolsTemperatureUnit.Romer };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsTemperatureUnit.PlanckTemperature, UnitToolsTemperatureUnit.ElectronVoltTemperature, UnitToolsTemperatureUnit.MillielectronVoltTemperature, UnitToolsTemperatureUnit.KiloelectronVoltTemperature };
                default:
                    return new[] { UnitToolsTemperatureUnit.Kelvin, UnitToolsTemperatureUnit.Celsius, UnitToolsTemperatureUnit.Fahrenheit, UnitToolsTemperatureUnit.Rankine, UnitToolsTemperatureUnit.Delisle, UnitToolsTemperatureUnit.Newton, UnitToolsTemperatureUnit.Reaumur, UnitToolsTemperatureUnit.Romer, UnitToolsTemperatureUnit.Millikelvin, UnitToolsTemperatureUnit.Microkelvin, UnitToolsTemperatureUnit.Nanokelvin, UnitToolsTemperatureUnit.Kilokelvin, UnitToolsTemperatureUnit.Megakelvin, UnitToolsTemperatureUnit.Gigakelvin, UnitToolsTemperatureUnit.PlanckTemperature, UnitToolsTemperatureUnit.ElectronVoltTemperature, UnitToolsTemperatureUnit.MillielectronVoltTemperature, UnitToolsTemperatureUnit.KiloelectronVoltTemperature };
            }
        }
    }
}
