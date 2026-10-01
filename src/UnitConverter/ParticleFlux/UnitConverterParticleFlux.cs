namespace UnitConverter.ParticleFlux
{
    using UnitConverter.ParticleFlux.Scientific;

    public enum UnitConverterParticleFluxUnit
    {
        ParticlePerSquareMeterSecond = 0,
        ParticlePerSquareCentimeterSecond = 1,
        ParticlePerSquareMillimeterSecond = 2,
        ParticlePerSquareMeterMinute = 3,
        ParticlePerSquareMeterHour = 4,
        ParticlePerSquareFootSecond = 5,
        ParticlePerSquareInchSecond = 6,
        NeutronPerSquareCentimeterSecond = 7,
        PhotonPerSquareCentimeterSecond = 8,
        ProtonPerSquareCentimeterSecond = 9,
        ElectronPerSquareCentimeterSecond = 10,
        NeutronPerSquareMeterSecond = 11,
        PhotonPerSquareMeterSecond = 12,
        ParticlePerSquareCentimeterMinute = 13,
        ParticlePerSquareCentimeterHour = 14,
    }

    public static class UnitConverterParticleFlux
    {
        public static double Convert(double value, UnitConverterParticleFluxUnit from, UnitConverterParticleFluxUnit to)
        {
            double baseValue = ToParticlePerSquareMeterSecond(value, from);
            return FromParticlePerSquareMeterSecond(baseValue, to);
        }

        public static double ToParticlePerSquareMeterSecond(double value, UnitConverterParticleFluxUnit from)
        {
            switch (from)
            {
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareCentimeterSecondToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.ParticlePerSquareMillimeterSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMillimeterSecondToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterMinute:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterMinuteToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterHour:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterHourToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.ParticlePerSquareFootSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareFootSecondToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.ParticlePerSquareInchSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareInchSecondToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.NeutronPerSquareCentimeterSecond:
                    return UnitConverterScientificParticleFlux.NeutronPerSquareCentimeterSecondToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.PhotonPerSquareCentimeterSecond:
                    return UnitConverterScientificParticleFlux.PhotonPerSquareCentimeterSecondToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.ProtonPerSquareCentimeterSecond:
                    return UnitConverterScientificParticleFlux.ProtonPerSquareCentimeterSecondToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.ElectronPerSquareCentimeterSecond:
                    return UnitConverterScientificParticleFlux.ElectronPerSquareCentimeterSecondToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.NeutronPerSquareMeterSecond:
                    return UnitConverterScientificParticleFlux.NeutronPerSquareMeterSecondToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.PhotonPerSquareMeterSecond:
                    return UnitConverterScientificParticleFlux.PhotonPerSquareMeterSecondToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterMinute:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareCentimeterMinuteToParticlePerSquareMeterSecond(value);
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterHour:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareCentimeterHourToParticlePerSquareMeterSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported particle flux unit.");
            }
        }

        public static double FromParticlePerSquareMeterSecond(double baseValue, UnitConverterParticleFluxUnit to)
        {
            switch (to)
            {
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareMeterSecond(baseValue);
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareCentimeterSecond(baseValue);
                case UnitConverterParticleFluxUnit.ParticlePerSquareMillimeterSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareMillimeterSecond(baseValue);
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterMinute:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareMeterMinute(baseValue);
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterHour:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareMeterHour(baseValue);
                case UnitConverterParticleFluxUnit.ParticlePerSquareFootSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareFootSecond(baseValue);
                case UnitConverterParticleFluxUnit.ParticlePerSquareInchSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareInchSecond(baseValue);
                case UnitConverterParticleFluxUnit.NeutronPerSquareCentimeterSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToNeutronPerSquareCentimeterSecond(baseValue);
                case UnitConverterParticleFluxUnit.PhotonPerSquareCentimeterSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToPhotonPerSquareCentimeterSecond(baseValue);
                case UnitConverterParticleFluxUnit.ProtonPerSquareCentimeterSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToProtonPerSquareCentimeterSecond(baseValue);
                case UnitConverterParticleFluxUnit.ElectronPerSquareCentimeterSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToElectronPerSquareCentimeterSecond(baseValue);
                case UnitConverterParticleFluxUnit.NeutronPerSquareMeterSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToNeutronPerSquareMeterSecond(baseValue);
                case UnitConverterParticleFluxUnit.PhotonPerSquareMeterSecond:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToPhotonPerSquareMeterSecond(baseValue);
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterMinute:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareCentimeterMinute(baseValue);
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterHour:
                    return UnitConverterScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareCentimeterHour(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported particle flux unit.");
            }
        }

        public static string GetSymbol(UnitConverterParticleFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterSecond:
                    return "1/(m²·s)";
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterSecond:
                    return "1/(cm²·s)";
                case UnitConverterParticleFluxUnit.ParticlePerSquareMillimeterSecond:
                    return "1/(mm²·s)";
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterMinute:
                    return "1/(m²·min)";
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterHour:
                    return "1/(m²·h)";
                case UnitConverterParticleFluxUnit.ParticlePerSquareFootSecond:
                    return "1/(ft²·s)";
                case UnitConverterParticleFluxUnit.ParticlePerSquareInchSecond:
                    return "1/(in²·s)";
                case UnitConverterParticleFluxUnit.NeutronPerSquareCentimeterSecond:
                    return "n/(cm²·s)";
                case UnitConverterParticleFluxUnit.PhotonPerSquareCentimeterSecond:
                    return "ph/(cm²·s)";
                case UnitConverterParticleFluxUnit.ProtonPerSquareCentimeterSecond:
                    return "p/(cm²·s)";
                case UnitConverterParticleFluxUnit.ElectronPerSquareCentimeterSecond:
                    return "e⁻/(cm²·s)";
                case UnitConverterParticleFluxUnit.NeutronPerSquareMeterSecond:
                    return "n/(m²·s)";
                case UnitConverterParticleFluxUnit.PhotonPerSquareMeterSecond:
                    return "ph/(m²·s)";
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterMinute:
                    return "1/(cm²·min)";
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterHour:
                    return "1/(cm²·h)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterParticleFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterSecond:
                    return "Particle Per Square Meter Second";
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterSecond:
                    return "Particle Per Square Centimeter Second";
                case UnitConverterParticleFluxUnit.ParticlePerSquareMillimeterSecond:
                    return "Particle Per Square Millimeter Second";
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterMinute:
                    return "Particle Per Square Meter Minute";
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterHour:
                    return "Particle Per Square Meter Hour";
                case UnitConverterParticleFluxUnit.ParticlePerSquareFootSecond:
                    return "Particle Per Square Foot Second";
                case UnitConverterParticleFluxUnit.ParticlePerSquareInchSecond:
                    return "Particle Per Square Inch Second";
                case UnitConverterParticleFluxUnit.NeutronPerSquareCentimeterSecond:
                    return "Neutron Per Square Centimeter Second";
                case UnitConverterParticleFluxUnit.PhotonPerSquareCentimeterSecond:
                    return "Photon Per Square Centimeter Second";
                case UnitConverterParticleFluxUnit.ProtonPerSquareCentimeterSecond:
                    return "Proton Per Square Centimeter Second";
                case UnitConverterParticleFluxUnit.ElectronPerSquareCentimeterSecond:
                    return "Electron Per Square Centimeter Second";
                case UnitConverterParticleFluxUnit.NeutronPerSquareMeterSecond:
                    return "Neutron Per Square Meter Second";
                case UnitConverterParticleFluxUnit.PhotonPerSquareMeterSecond:
                    return "Photon Per Square Meter Second";
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterMinute:
                    return "Particle Per Square Centimeter Minute";
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterHour:
                    return "Particle Per Square Centimeter Hour";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterParticleFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.ParticlePerSquareMillimeterSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterMinute:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.ParticlePerSquareMeterHour:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.ParticlePerSquareFootSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.ParticlePerSquareInchSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.NeutronPerSquareCentimeterSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.PhotonPerSquareCentimeterSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.ProtonPerSquareCentimeterSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.ElectronPerSquareCentimeterSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.NeutronPerSquareMeterSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.PhotonPerSquareMeterSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterMinute:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterHour:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterParticleFluxUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterParticleFluxUnit.ParticlePerSquareMeterSecond, UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterSecond, UnitConverterParticleFluxUnit.ParticlePerSquareMillimeterSecond, UnitConverterParticleFluxUnit.ParticlePerSquareMeterMinute, UnitConverterParticleFluxUnit.ParticlePerSquareMeterHour, UnitConverterParticleFluxUnit.ParticlePerSquareFootSecond, UnitConverterParticleFluxUnit.ParticlePerSquareInchSecond, UnitConverterParticleFluxUnit.NeutronPerSquareCentimeterSecond, UnitConverterParticleFluxUnit.PhotonPerSquareCentimeterSecond, UnitConverterParticleFluxUnit.ProtonPerSquareCentimeterSecond, UnitConverterParticleFluxUnit.ElectronPerSquareCentimeterSecond, UnitConverterParticleFluxUnit.NeutronPerSquareMeterSecond, UnitConverterParticleFluxUnit.PhotonPerSquareMeterSecond, UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterMinute, UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterHour };
                default:
                    return new[] { UnitConverterParticleFluxUnit.ParticlePerSquareMeterSecond, UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterSecond, UnitConverterParticleFluxUnit.ParticlePerSquareMillimeterSecond, UnitConverterParticleFluxUnit.ParticlePerSquareMeterMinute, UnitConverterParticleFluxUnit.ParticlePerSquareMeterHour, UnitConverterParticleFluxUnit.ParticlePerSquareFootSecond, UnitConverterParticleFluxUnit.ParticlePerSquareInchSecond, UnitConverterParticleFluxUnit.NeutronPerSquareCentimeterSecond, UnitConverterParticleFluxUnit.PhotonPerSquareCentimeterSecond, UnitConverterParticleFluxUnit.ProtonPerSquareCentimeterSecond, UnitConverterParticleFluxUnit.ElectronPerSquareCentimeterSecond, UnitConverterParticleFluxUnit.NeutronPerSquareMeterSecond, UnitConverterParticleFluxUnit.PhotonPerSquareMeterSecond, UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterMinute, UnitConverterParticleFluxUnit.ParticlePerSquareCentimeterHour };
            }
        }
    }
}
