namespace UnitTools.ParticleFlux
{
    using UnitTools.ParticleFlux.Scientific;

    public enum UnitToolsParticleFluxUnit
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

    public static class UnitToolsParticleFlux
    {
        public static double Convert(double value, UnitToolsParticleFluxUnit from, UnitToolsParticleFluxUnit to)
        {
            double baseValue = ToParticlePerSquareMeterSecond(value, from);
            return FromParticlePerSquareMeterSecond(baseValue, to);
        }

        public static double ToParticlePerSquareMeterSecond(double value, UnitToolsParticleFluxUnit from)
        {
            switch (from)
            {
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareCentimeterSecondToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.ParticlePerSquareMillimeterSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMillimeterSecondToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterMinute:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterMinuteToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterHour:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterHourToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.ParticlePerSquareFootSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareFootSecondToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.ParticlePerSquareInchSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareInchSecondToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.NeutronPerSquareCentimeterSecond:
                    return UnitToolsScientificParticleFlux.NeutronPerSquareCentimeterSecondToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.PhotonPerSquareCentimeterSecond:
                    return UnitToolsScientificParticleFlux.PhotonPerSquareCentimeterSecondToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.ProtonPerSquareCentimeterSecond:
                    return UnitToolsScientificParticleFlux.ProtonPerSquareCentimeterSecondToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.ElectronPerSquareCentimeterSecond:
                    return UnitToolsScientificParticleFlux.ElectronPerSquareCentimeterSecondToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.NeutronPerSquareMeterSecond:
                    return UnitToolsScientificParticleFlux.NeutronPerSquareMeterSecondToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.PhotonPerSquareMeterSecond:
                    return UnitToolsScientificParticleFlux.PhotonPerSquareMeterSecondToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterMinute:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareCentimeterMinuteToParticlePerSquareMeterSecond(value);
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterHour:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareCentimeterHourToParticlePerSquareMeterSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported particle flux unit.");
            }
        }

        public static double FromParticlePerSquareMeterSecond(double baseValue, UnitToolsParticleFluxUnit to)
        {
            switch (to)
            {
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareMeterSecond(baseValue);
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareCentimeterSecond(baseValue);
                case UnitToolsParticleFluxUnit.ParticlePerSquareMillimeterSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareMillimeterSecond(baseValue);
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterMinute:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareMeterMinute(baseValue);
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterHour:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareMeterHour(baseValue);
                case UnitToolsParticleFluxUnit.ParticlePerSquareFootSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareFootSecond(baseValue);
                case UnitToolsParticleFluxUnit.ParticlePerSquareInchSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareInchSecond(baseValue);
                case UnitToolsParticleFluxUnit.NeutronPerSquareCentimeterSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToNeutronPerSquareCentimeterSecond(baseValue);
                case UnitToolsParticleFluxUnit.PhotonPerSquareCentimeterSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToPhotonPerSquareCentimeterSecond(baseValue);
                case UnitToolsParticleFluxUnit.ProtonPerSquareCentimeterSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToProtonPerSquareCentimeterSecond(baseValue);
                case UnitToolsParticleFluxUnit.ElectronPerSquareCentimeterSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToElectronPerSquareCentimeterSecond(baseValue);
                case UnitToolsParticleFluxUnit.NeutronPerSquareMeterSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToNeutronPerSquareMeterSecond(baseValue);
                case UnitToolsParticleFluxUnit.PhotonPerSquareMeterSecond:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToPhotonPerSquareMeterSecond(baseValue);
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterMinute:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareCentimeterMinute(baseValue);
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterHour:
                    return UnitToolsScientificParticleFlux.ParticlePerSquareMeterSecondToParticlePerSquareCentimeterHour(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported particle flux unit.");
            }
        }

        public static string GetSymbol(UnitToolsParticleFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterSecond:
                    return "1/(m²·s)";
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterSecond:
                    return "1/(cm²·s)";
                case UnitToolsParticleFluxUnit.ParticlePerSquareMillimeterSecond:
                    return "1/(mm²·s)";
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterMinute:
                    return "1/(m²·min)";
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterHour:
                    return "1/(m²·h)";
                case UnitToolsParticleFluxUnit.ParticlePerSquareFootSecond:
                    return "1/(ft²·s)";
                case UnitToolsParticleFluxUnit.ParticlePerSquareInchSecond:
                    return "1/(in²·s)";
                case UnitToolsParticleFluxUnit.NeutronPerSquareCentimeterSecond:
                    return "n/(cm²·s)";
                case UnitToolsParticleFluxUnit.PhotonPerSquareCentimeterSecond:
                    return "ph/(cm²·s)";
                case UnitToolsParticleFluxUnit.ProtonPerSquareCentimeterSecond:
                    return "p/(cm²·s)";
                case UnitToolsParticleFluxUnit.ElectronPerSquareCentimeterSecond:
                    return "e⁻/(cm²·s)";
                case UnitToolsParticleFluxUnit.NeutronPerSquareMeterSecond:
                    return "n/(m²·s)";
                case UnitToolsParticleFluxUnit.PhotonPerSquareMeterSecond:
                    return "ph/(m²·s)";
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterMinute:
                    return "1/(cm²·min)";
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterHour:
                    return "1/(cm²·h)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsParticleFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterSecond:
                    return "Particle Per Square Meter Second";
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterSecond:
                    return "Particle Per Square Centimeter Second";
                case UnitToolsParticleFluxUnit.ParticlePerSquareMillimeterSecond:
                    return "Particle Per Square Millimeter Second";
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterMinute:
                    return "Particle Per Square Meter Minute";
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterHour:
                    return "Particle Per Square Meter Hour";
                case UnitToolsParticleFluxUnit.ParticlePerSquareFootSecond:
                    return "Particle Per Square Foot Second";
                case UnitToolsParticleFluxUnit.ParticlePerSquareInchSecond:
                    return "Particle Per Square Inch Second";
                case UnitToolsParticleFluxUnit.NeutronPerSquareCentimeterSecond:
                    return "Neutron Per Square Centimeter Second";
                case UnitToolsParticleFluxUnit.PhotonPerSquareCentimeterSecond:
                    return "Photon Per Square Centimeter Second";
                case UnitToolsParticleFluxUnit.ProtonPerSquareCentimeterSecond:
                    return "Proton Per Square Centimeter Second";
                case UnitToolsParticleFluxUnit.ElectronPerSquareCentimeterSecond:
                    return "Electron Per Square Centimeter Second";
                case UnitToolsParticleFluxUnit.NeutronPerSquareMeterSecond:
                    return "Neutron Per Square Meter Second";
                case UnitToolsParticleFluxUnit.PhotonPerSquareMeterSecond:
                    return "Photon Per Square Meter Second";
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterMinute:
                    return "Particle Per Square Centimeter Minute";
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterHour:
                    return "Particle Per Square Centimeter Hour";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsParticleFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.ParticlePerSquareMillimeterSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterMinute:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.ParticlePerSquareMeterHour:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.ParticlePerSquareFootSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.ParticlePerSquareInchSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.NeutronPerSquareCentimeterSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.PhotonPerSquareCentimeterSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.ProtonPerSquareCentimeterSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.ElectronPerSquareCentimeterSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.NeutronPerSquareMeterSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.PhotonPerSquareMeterSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterMinute:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterHour:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsParticleFluxUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsParticleFluxUnit.ParticlePerSquareMeterSecond, UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterSecond, UnitToolsParticleFluxUnit.ParticlePerSquareMillimeterSecond, UnitToolsParticleFluxUnit.ParticlePerSquareMeterMinute, UnitToolsParticleFluxUnit.ParticlePerSquareMeterHour, UnitToolsParticleFluxUnit.ParticlePerSquareFootSecond, UnitToolsParticleFluxUnit.ParticlePerSquareInchSecond, UnitToolsParticleFluxUnit.NeutronPerSquareCentimeterSecond, UnitToolsParticleFluxUnit.PhotonPerSquareCentimeterSecond, UnitToolsParticleFluxUnit.ProtonPerSquareCentimeterSecond, UnitToolsParticleFluxUnit.ElectronPerSquareCentimeterSecond, UnitToolsParticleFluxUnit.NeutronPerSquareMeterSecond, UnitToolsParticleFluxUnit.PhotonPerSquareMeterSecond, UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterMinute, UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterHour };
                default:
                    return new[] { UnitToolsParticleFluxUnit.ParticlePerSquareMeterSecond, UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterSecond, UnitToolsParticleFluxUnit.ParticlePerSquareMillimeterSecond, UnitToolsParticleFluxUnit.ParticlePerSquareMeterMinute, UnitToolsParticleFluxUnit.ParticlePerSquareMeterHour, UnitToolsParticleFluxUnit.ParticlePerSquareFootSecond, UnitToolsParticleFluxUnit.ParticlePerSquareInchSecond, UnitToolsParticleFluxUnit.NeutronPerSquareCentimeterSecond, UnitToolsParticleFluxUnit.PhotonPerSquareCentimeterSecond, UnitToolsParticleFluxUnit.ProtonPerSquareCentimeterSecond, UnitToolsParticleFluxUnit.ElectronPerSquareCentimeterSecond, UnitToolsParticleFluxUnit.NeutronPerSquareMeterSecond, UnitToolsParticleFluxUnit.PhotonPerSquareMeterSecond, UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterMinute, UnitToolsParticleFluxUnit.ParticlePerSquareCentimeterHour };
            }
        }
    }
}
