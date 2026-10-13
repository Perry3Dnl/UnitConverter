namespace UnitTools.ParticleFluence
{
    using UnitTools.ParticleFluence.Scientific;

    public enum UnitToolsParticleFluenceUnit
    {
        ParticlePerSquareMeter = 0,
        ParticlePerSquareCentimeter = 1,
        ParticlePerSquareMillimeter = 2,
        ParticlePerSquareFoot = 3,
        ParticlePerSquareInch = 4,
        NeutronPerSquareCentimeter = 5,
        PhotonPerSquareCentimeter = 6,
        ParticlePerBarn = 7,
        ProtonPerSquareCentimeter = 8,
        ElectronPerSquareCentimeter = 9,
        NeutronPerSquareMeter = 10,
        PhotonPerSquareMeter = 11,
        ParticlePerSquareMicrometer = 12,
    }

    public static class UnitToolsParticleFluence
    {
        public static double Convert(double value, UnitToolsParticleFluenceUnit from, UnitToolsParticleFluenceUnit to)
        {
            double baseValue = ToParticlePerSquareMeter(value, from);
            return FromParticlePerSquareMeter(baseValue, to);
        }

        public static double ToParticlePerSquareMeter(double value, UnitToolsParticleFluenceUnit from)
        {
            switch (from)
            {
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMeter:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareMeter(value);
                case UnitToolsParticleFluenceUnit.ParticlePerSquareCentimeter:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareCentimeterToParticlePerSquareMeter(value);
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMillimeter:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMillimeterToParticlePerSquareMeter(value);
                case UnitToolsParticleFluenceUnit.ParticlePerSquareFoot:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareFootToParticlePerSquareMeter(value);
                case UnitToolsParticleFluenceUnit.ParticlePerSquareInch:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareInchToParticlePerSquareMeter(value);
                case UnitToolsParticleFluenceUnit.NeutronPerSquareCentimeter:
                    return UnitToolsScientificParticleFluence.NeutronPerSquareCentimeterToParticlePerSquareMeter(value);
                case UnitToolsParticleFluenceUnit.PhotonPerSquareCentimeter:
                    return UnitToolsScientificParticleFluence.PhotonPerSquareCentimeterToParticlePerSquareMeter(value);
                case UnitToolsParticleFluenceUnit.ParticlePerBarn:
                    return UnitToolsScientificParticleFluence.ParticlePerBarnToParticlePerSquareMeter(value);
                case UnitToolsParticleFluenceUnit.ProtonPerSquareCentimeter:
                    return UnitToolsScientificParticleFluence.ProtonPerSquareCentimeterToParticlePerSquareMeter(value);
                case UnitToolsParticleFluenceUnit.ElectronPerSquareCentimeter:
                    return UnitToolsScientificParticleFluence.ElectronPerSquareCentimeterToParticlePerSquareMeter(value);
                case UnitToolsParticleFluenceUnit.NeutronPerSquareMeter:
                    return UnitToolsScientificParticleFluence.NeutronPerSquareMeterToParticlePerSquareMeter(value);
                case UnitToolsParticleFluenceUnit.PhotonPerSquareMeter:
                    return UnitToolsScientificParticleFluence.PhotonPerSquareMeterToParticlePerSquareMeter(value);
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMicrometer:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMicrometerToParticlePerSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported particle fluence unit.");
            }
        }

        public static double FromParticlePerSquareMeter(double baseValue, UnitToolsParticleFluenceUnit to)
        {
            switch (to)
            {
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMeter:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareMeter(baseValue);
                case UnitToolsParticleFluenceUnit.ParticlePerSquareCentimeter:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareCentimeter(baseValue);
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMillimeter:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareMillimeter(baseValue);
                case UnitToolsParticleFluenceUnit.ParticlePerSquareFoot:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareFoot(baseValue);
                case UnitToolsParticleFluenceUnit.ParticlePerSquareInch:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareInch(baseValue);
                case UnitToolsParticleFluenceUnit.NeutronPerSquareCentimeter:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToNeutronPerSquareCentimeter(baseValue);
                case UnitToolsParticleFluenceUnit.PhotonPerSquareCentimeter:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToPhotonPerSquareCentimeter(baseValue);
                case UnitToolsParticleFluenceUnit.ParticlePerBarn:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToParticlePerBarn(baseValue);
                case UnitToolsParticleFluenceUnit.ProtonPerSquareCentimeter:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToProtonPerSquareCentimeter(baseValue);
                case UnitToolsParticleFluenceUnit.ElectronPerSquareCentimeter:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToElectronPerSquareCentimeter(baseValue);
                case UnitToolsParticleFluenceUnit.NeutronPerSquareMeter:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToNeutronPerSquareMeter(baseValue);
                case UnitToolsParticleFluenceUnit.PhotonPerSquareMeter:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToPhotonPerSquareMeter(baseValue);
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMicrometer:
                    return UnitToolsScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareMicrometer(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported particle fluence unit.");
            }
        }

        public static string GetSymbol(UnitToolsParticleFluenceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMeter:
                    return "1/m²";
                case UnitToolsParticleFluenceUnit.ParticlePerSquareCentimeter:
                    return "1/cm²";
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMillimeter:
                    return "1/mm²";
                case UnitToolsParticleFluenceUnit.ParticlePerSquareFoot:
                    return "1/ft²";
                case UnitToolsParticleFluenceUnit.ParticlePerSquareInch:
                    return "1/in²";
                case UnitToolsParticleFluenceUnit.NeutronPerSquareCentimeter:
                    return "n/cm²";
                case UnitToolsParticleFluenceUnit.PhotonPerSquareCentimeter:
                    return "ph/cm²";
                case UnitToolsParticleFluenceUnit.ParticlePerBarn:
                    return "1/b";
                case UnitToolsParticleFluenceUnit.ProtonPerSquareCentimeter:
                    return "p/cm²";
                case UnitToolsParticleFluenceUnit.ElectronPerSquareCentimeter:
                    return "e⁻/cm²";
                case UnitToolsParticleFluenceUnit.NeutronPerSquareMeter:
                    return "n/m²";
                case UnitToolsParticleFluenceUnit.PhotonPerSquareMeter:
                    return "ph/m²";
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMicrometer:
                    return "1/µm²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsParticleFluenceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMeter:
                    return "Particle Per Square Meter";
                case UnitToolsParticleFluenceUnit.ParticlePerSquareCentimeter:
                    return "Particle Per Square Centimeter";
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMillimeter:
                    return "Particle Per Square Millimeter";
                case UnitToolsParticleFluenceUnit.ParticlePerSquareFoot:
                    return "Particle Per Square Foot";
                case UnitToolsParticleFluenceUnit.ParticlePerSquareInch:
                    return "Particle Per Square Inch";
                case UnitToolsParticleFluenceUnit.NeutronPerSquareCentimeter:
                    return "Neutron Per Square Centimeter";
                case UnitToolsParticleFluenceUnit.PhotonPerSquareCentimeter:
                    return "Photon Per Square Centimeter";
                case UnitToolsParticleFluenceUnit.ParticlePerBarn:
                    return "Particle Per Barn";
                case UnitToolsParticleFluenceUnit.ProtonPerSquareCentimeter:
                    return "Proton Per Square Centimeter";
                case UnitToolsParticleFluenceUnit.ElectronPerSquareCentimeter:
                    return "Electron Per Square Centimeter";
                case UnitToolsParticleFluenceUnit.NeutronPerSquareMeter:
                    return "Neutron Per Square Meter";
                case UnitToolsParticleFluenceUnit.PhotonPerSquareMeter:
                    return "Photon Per Square Meter";
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMicrometer:
                    return "Particle Per Square Micrometer";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsParticleFluenceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluenceUnit.ParticlePerSquareCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMillimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluenceUnit.ParticlePerSquareFoot:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluenceUnit.ParticlePerSquareInch:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluenceUnit.NeutronPerSquareCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluenceUnit.PhotonPerSquareCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluenceUnit.ParticlePerBarn:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluenceUnit.ProtonPerSquareCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluenceUnit.ElectronPerSquareCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluenceUnit.NeutronPerSquareMeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluenceUnit.PhotonPerSquareMeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsParticleFluenceUnit.ParticlePerSquareMicrometer:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsParticleFluenceUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsParticleFluenceUnit.ParticlePerSquareMeter, UnitToolsParticleFluenceUnit.ParticlePerSquareCentimeter, UnitToolsParticleFluenceUnit.ParticlePerSquareMillimeter, UnitToolsParticleFluenceUnit.ParticlePerSquareFoot, UnitToolsParticleFluenceUnit.ParticlePerSquareInch, UnitToolsParticleFluenceUnit.NeutronPerSquareCentimeter, UnitToolsParticleFluenceUnit.PhotonPerSquareCentimeter, UnitToolsParticleFluenceUnit.ParticlePerBarn, UnitToolsParticleFluenceUnit.ProtonPerSquareCentimeter, UnitToolsParticleFluenceUnit.ElectronPerSquareCentimeter, UnitToolsParticleFluenceUnit.NeutronPerSquareMeter, UnitToolsParticleFluenceUnit.PhotonPerSquareMeter, UnitToolsParticleFluenceUnit.ParticlePerSquareMicrometer };
                default:
                    return new[] { UnitToolsParticleFluenceUnit.ParticlePerSquareMeter, UnitToolsParticleFluenceUnit.ParticlePerSquareCentimeter, UnitToolsParticleFluenceUnit.ParticlePerSquareMillimeter, UnitToolsParticleFluenceUnit.ParticlePerSquareFoot, UnitToolsParticleFluenceUnit.ParticlePerSquareInch, UnitToolsParticleFluenceUnit.NeutronPerSquareCentimeter, UnitToolsParticleFluenceUnit.PhotonPerSquareCentimeter, UnitToolsParticleFluenceUnit.ParticlePerBarn, UnitToolsParticleFluenceUnit.ProtonPerSquareCentimeter, UnitToolsParticleFluenceUnit.ElectronPerSquareCentimeter, UnitToolsParticleFluenceUnit.NeutronPerSquareMeter, UnitToolsParticleFluenceUnit.PhotonPerSquareMeter, UnitToolsParticleFluenceUnit.ParticlePerSquareMicrometer };
            }
        }
    }
}
