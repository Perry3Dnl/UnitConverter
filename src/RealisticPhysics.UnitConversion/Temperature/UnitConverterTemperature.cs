namespace RealisticPhysics.UnitConversion.Temperature
{
    public enum UnitConverterTemperatureUnit
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

    public static class UnitConverterTemperature
    {
        public static double Convert(double value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
        {
            double kelvin = ToKelvin(value, from);
            return FromKelvin(kelvin, to);
        }

        public static double ToKelvin(double value, UnitConverterTemperatureUnit from)
        {
            switch (from)
            {
                case UnitConverterTemperatureUnit.Kelvin: return KelvinToKelvin(value);
                case UnitConverterTemperatureUnit.Celsius: return CelsiusToKelvin(value);
                case UnitConverterTemperatureUnit.Fahrenheit: return FahrenheitToKelvin(value);
                case UnitConverterTemperatureUnit.Rankine: return RankineToKelvin(value);
                case UnitConverterTemperatureUnit.Delisle: return DelisleToKelvin(value);
                case UnitConverterTemperatureUnit.Newton: return NewtonToKelvin(value);
                case UnitConverterTemperatureUnit.Reaumur: return ReaumurToKelvin(value);
                case UnitConverterTemperatureUnit.Romer: return RomerToKelvin(value);
                case UnitConverterTemperatureUnit.Millikelvin: return MillikelvinToKelvin(value);
                case UnitConverterTemperatureUnit.Microkelvin: return MicrokelvinToKelvin(value);
                case UnitConverterTemperatureUnit.Nanokelvin: return NanokelvinToKelvin(value);
                case UnitConverterTemperatureUnit.Kilokelvin: return KilokelvinToKelvin(value);
                case UnitConverterTemperatureUnit.Megakelvin: return MegakelvinToKelvin(value);
                case UnitConverterTemperatureUnit.Gigakelvin: return GigakelvinToKelvin(value);
                case UnitConverterTemperatureUnit.PlanckTemperature: return PlanckTemperatureToKelvin(value);
                case UnitConverterTemperatureUnit.ElectronVoltTemperature: return ElectronVoltTemperatureToKelvin(value);
                case UnitConverterTemperatureUnit.MillielectronVoltTemperature: return MillielectronVoltTemperatureToKelvin(value);
                case UnitConverterTemperatureUnit.KiloelectronVoltTemperature: return KiloelectronVoltTemperatureToKelvin(value);
                default: throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported temperature unit.");
            }
        }

        public static double FromKelvin(double kelvin, UnitConverterTemperatureUnit to)
        {
            switch (to)
            {
                case UnitConverterTemperatureUnit.Kelvin: return KelvinToKelvin(kelvin);
                case UnitConverterTemperatureUnit.Celsius: return KelvinToCelsius(kelvin);
                case UnitConverterTemperatureUnit.Fahrenheit: return KelvinToFahrenheit(kelvin);
                case UnitConverterTemperatureUnit.Rankine: return KelvinToRankine(kelvin);
                case UnitConverterTemperatureUnit.Delisle: return KelvinToDelisle(kelvin);
                case UnitConverterTemperatureUnit.Newton: return KelvinToNewton(kelvin);
                case UnitConverterTemperatureUnit.Reaumur: return KelvinToReaumur(kelvin);
                case UnitConverterTemperatureUnit.Romer: return KelvinToRomer(kelvin);
                case UnitConverterTemperatureUnit.Millikelvin: return KelvinToMillikelvin(kelvin);
                case UnitConverterTemperatureUnit.Microkelvin: return KelvinToMicrokelvin(kelvin);
                case UnitConverterTemperatureUnit.Nanokelvin: return KelvinToNanokelvin(kelvin);
                case UnitConverterTemperatureUnit.Kilokelvin: return KelvinToKilokelvin(kelvin);
                case UnitConverterTemperatureUnit.Megakelvin: return KelvinToMegakelvin(kelvin);
                case UnitConverterTemperatureUnit.Gigakelvin: return KelvinToGigakelvin(kelvin);
                case UnitConverterTemperatureUnit.PlanckTemperature: return KelvinToPlanckTemperature(kelvin);
                case UnitConverterTemperatureUnit.ElectronVoltTemperature: return KelvinToElectronVoltTemperature(kelvin);
                case UnitConverterTemperatureUnit.MillielectronVoltTemperature: return KelvinToMillielectronVoltTemperature(kelvin);
                case UnitConverterTemperatureUnit.KiloelectronVoltTemperature: return KelvinToKiloelectronVoltTemperature(kelvin);
                default: throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported temperature unit.");
            }
        }

        public static UnitConverterConversionResult TryConvert(double value, UnitConverterTemperatureUnit from, UnitConverterTemperatureUnit to)
        {
            try { return UnitConverterConversionResult.Ok(Convert(value, from, to)); }
            catch (System.Exception exception) { return UnitConverterConversionResult.Fail(exception.Message); }
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

        public static string GetSymbol(UnitConverterTemperatureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTemperatureUnit.Kelvin: return "K";
                case UnitConverterTemperatureUnit.Celsius: return "°C";
                case UnitConverterTemperatureUnit.Fahrenheit: return "°F";
                case UnitConverterTemperatureUnit.Rankine: return "°R";
                case UnitConverterTemperatureUnit.Delisle: return "°De";
                case UnitConverterTemperatureUnit.Newton: return "°N";
                case UnitConverterTemperatureUnit.Reaumur: return "°Ré";
                case UnitConverterTemperatureUnit.Romer: return "°Rø";
                case UnitConverterTemperatureUnit.Millikelvin: return "mK";
                case UnitConverterTemperatureUnit.Microkelvin: return "µK";
                case UnitConverterTemperatureUnit.Nanokelvin: return "nK";
                case UnitConverterTemperatureUnit.Kilokelvin: return "kK";
                case UnitConverterTemperatureUnit.Megakelvin: return "MK";
                case UnitConverterTemperatureUnit.Gigakelvin: return "GK";
                case UnitConverterTemperatureUnit.PlanckTemperature: return "TP";
                case UnitConverterTemperatureUnit.ElectronVoltTemperature: return "eV/kB";
                case UnitConverterTemperatureUnit.MillielectronVoltTemperature: return "meV/kB";
                case UnitConverterTemperatureUnit.KiloelectronVoltTemperature: return "keV/kB";
                default: return "?";
            }
        }

        public static string GetDisplayName(UnitConverterTemperatureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTemperatureUnit.Kelvin: return "Kelvin";
                case UnitConverterTemperatureUnit.Celsius: return "Celsius";
                case UnitConverterTemperatureUnit.Fahrenheit: return "Fahrenheit";
                case UnitConverterTemperatureUnit.Rankine: return "Rankine";
                case UnitConverterTemperatureUnit.Delisle: return "Delisle";
                case UnitConverterTemperatureUnit.Newton: return "Newton";
                case UnitConverterTemperatureUnit.Reaumur: return "Réaumur";
                case UnitConverterTemperatureUnit.Romer: return "Rømer";
                case UnitConverterTemperatureUnit.Millikelvin: return "Millikelvin";
                case UnitConverterTemperatureUnit.Microkelvin: return "Microkelvin";
                case UnitConverterTemperatureUnit.Nanokelvin: return "Nanokelvin";
                case UnitConverterTemperatureUnit.Kilokelvin: return "Kilokelvin";
                case UnitConverterTemperatureUnit.Megakelvin: return "Megakelvin";
                case UnitConverterTemperatureUnit.Gigakelvin: return "Gigakelvin";
                case UnitConverterTemperatureUnit.PlanckTemperature: return "Planck Temperature";
                case UnitConverterTemperatureUnit.ElectronVoltTemperature: return "Electron Volt Temperature";
                case UnitConverterTemperatureUnit.MillielectronVoltTemperature: return "Millielectron Volt Temperature";
                case UnitConverterTemperatureUnit.KiloelectronVoltTemperature: return "Kiloelectron Volt Temperature";
                default: return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterTemperatureUnit unit)
        {
            switch (unit)
            {
                case UnitConverterTemperatureUnit.Kelvin: return UnitConverterUnitSystem.Metric;
                case UnitConverterTemperatureUnit.Celsius: return UnitConverterUnitSystem.Metric;
                case UnitConverterTemperatureUnit.Fahrenheit: return UnitConverterUnitSystem.Imperial;
                case UnitConverterTemperatureUnit.Rankine: return UnitConverterUnitSystem.Imperial;
                case UnitConverterTemperatureUnit.Delisle: return UnitConverterUnitSystem.Historical;
                case UnitConverterTemperatureUnit.Newton: return UnitConverterUnitSystem.Historical;
                case UnitConverterTemperatureUnit.Reaumur: return UnitConverterUnitSystem.Historical;
                case UnitConverterTemperatureUnit.Romer: return UnitConverterUnitSystem.Historical;
                case UnitConverterTemperatureUnit.Millikelvin: return UnitConverterUnitSystem.Metric;
                case UnitConverterTemperatureUnit.Microkelvin: return UnitConverterUnitSystem.Metric;
                case UnitConverterTemperatureUnit.Nanokelvin: return UnitConverterUnitSystem.Metric;
                case UnitConverterTemperatureUnit.Kilokelvin: return UnitConverterUnitSystem.Metric;
                case UnitConverterTemperatureUnit.Megakelvin: return UnitConverterUnitSystem.Metric;
                case UnitConverterTemperatureUnit.Gigakelvin: return UnitConverterUnitSystem.Metric;
                case UnitConverterTemperatureUnit.PlanckTemperature: return UnitConverterUnitSystem.Scientific;
                case UnitConverterTemperatureUnit.ElectronVoltTemperature: return UnitConverterUnitSystem.Scientific;
                case UnitConverterTemperatureUnit.MillielectronVoltTemperature: return UnitConverterUnitSystem.Scientific;
                case UnitConverterTemperatureUnit.KiloelectronVoltTemperature: return UnitConverterUnitSystem.Scientific;
                default: return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterTemperatureUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterTemperatureUnit.Kelvin, UnitConverterTemperatureUnit.Celsius, UnitConverterTemperatureUnit.Millikelvin, UnitConverterTemperatureUnit.Microkelvin, UnitConverterTemperatureUnit.Nanokelvin, UnitConverterTemperatureUnit.Kilokelvin, UnitConverterTemperatureUnit.Megakelvin, UnitConverterTemperatureUnit.Gigakelvin };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterTemperatureUnit.Fahrenheit, UnitConverterTemperatureUnit.Rankine };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterTemperatureUnit.Delisle, UnitConverterTemperatureUnit.Newton, UnitConverterTemperatureUnit.Reaumur, UnitConverterTemperatureUnit.Romer };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterTemperatureUnit.PlanckTemperature, UnitConverterTemperatureUnit.ElectronVoltTemperature, UnitConverterTemperatureUnit.MillielectronVoltTemperature, UnitConverterTemperatureUnit.KiloelectronVoltTemperature };
                default:
                    return new[] { UnitConverterTemperatureUnit.Kelvin, UnitConverterTemperatureUnit.Celsius, UnitConverterTemperatureUnit.Fahrenheit, UnitConverterTemperatureUnit.Rankine, UnitConverterTemperatureUnit.Delisle, UnitConverterTemperatureUnit.Newton, UnitConverterTemperatureUnit.Reaumur, UnitConverterTemperatureUnit.Romer, UnitConverterTemperatureUnit.Millikelvin, UnitConverterTemperatureUnit.Microkelvin, UnitConverterTemperatureUnit.Nanokelvin, UnitConverterTemperatureUnit.Kilokelvin, UnitConverterTemperatureUnit.Megakelvin, UnitConverterTemperatureUnit.Gigakelvin, UnitConverterTemperatureUnit.PlanckTemperature, UnitConverterTemperatureUnit.ElectronVoltTemperature, UnitConverterTemperatureUnit.MillielectronVoltTemperature, UnitConverterTemperatureUnit.KiloelectronVoltTemperature };
            }
        }
    }
}
