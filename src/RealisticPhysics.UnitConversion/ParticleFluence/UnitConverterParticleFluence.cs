namespace RealisticPhysics.UnitConversion.ParticleFluence
{
    using RealisticPhysics.UnitConversion.ParticleFluence.Scientific;

    public enum UnitConverterParticleFluenceUnit
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

    public static class UnitConverterParticleFluence
    {
        public static double Convert(double value, UnitConverterParticleFluenceUnit from, UnitConverterParticleFluenceUnit to)
        {
            double baseValue = ToParticlePerSquareMeter(value, from);
            return FromParticlePerSquareMeter(baseValue, to);
        }

        public static double ToParticlePerSquareMeter(double value, UnitConverterParticleFluenceUnit from)
        {
            switch (from)
            {
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMeter:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareMeter(value);
                case UnitConverterParticleFluenceUnit.ParticlePerSquareCentimeter:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareCentimeterToParticlePerSquareMeter(value);
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMillimeter:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMillimeterToParticlePerSquareMeter(value);
                case UnitConverterParticleFluenceUnit.ParticlePerSquareFoot:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareFootToParticlePerSquareMeter(value);
                case UnitConverterParticleFluenceUnit.ParticlePerSquareInch:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareInchToParticlePerSquareMeter(value);
                case UnitConverterParticleFluenceUnit.NeutronPerSquareCentimeter:
                    return UnitConverterScientificParticleFluence.NeutronPerSquareCentimeterToParticlePerSquareMeter(value);
                case UnitConverterParticleFluenceUnit.PhotonPerSquareCentimeter:
                    return UnitConverterScientificParticleFluence.PhotonPerSquareCentimeterToParticlePerSquareMeter(value);
                case UnitConverterParticleFluenceUnit.ParticlePerBarn:
                    return UnitConverterScientificParticleFluence.ParticlePerBarnToParticlePerSquareMeter(value);
                case UnitConverterParticleFluenceUnit.ProtonPerSquareCentimeter:
                    return UnitConverterScientificParticleFluence.ProtonPerSquareCentimeterToParticlePerSquareMeter(value);
                case UnitConverterParticleFluenceUnit.ElectronPerSquareCentimeter:
                    return UnitConverterScientificParticleFluence.ElectronPerSquareCentimeterToParticlePerSquareMeter(value);
                case UnitConverterParticleFluenceUnit.NeutronPerSquareMeter:
                    return UnitConverterScientificParticleFluence.NeutronPerSquareMeterToParticlePerSquareMeter(value);
                case UnitConverterParticleFluenceUnit.PhotonPerSquareMeter:
                    return UnitConverterScientificParticleFluence.PhotonPerSquareMeterToParticlePerSquareMeter(value);
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMicrometer:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMicrometerToParticlePerSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported particle fluence unit.");
            }
        }

        public static double FromParticlePerSquareMeter(double baseValue, UnitConverterParticleFluenceUnit to)
        {
            switch (to)
            {
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMeter:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareMeter(baseValue);
                case UnitConverterParticleFluenceUnit.ParticlePerSquareCentimeter:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareCentimeter(baseValue);
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMillimeter:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareMillimeter(baseValue);
                case UnitConverterParticleFluenceUnit.ParticlePerSquareFoot:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareFoot(baseValue);
                case UnitConverterParticleFluenceUnit.ParticlePerSquareInch:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareInch(baseValue);
                case UnitConverterParticleFluenceUnit.NeutronPerSquareCentimeter:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToNeutronPerSquareCentimeter(baseValue);
                case UnitConverterParticleFluenceUnit.PhotonPerSquareCentimeter:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToPhotonPerSquareCentimeter(baseValue);
                case UnitConverterParticleFluenceUnit.ParticlePerBarn:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToParticlePerBarn(baseValue);
                case UnitConverterParticleFluenceUnit.ProtonPerSquareCentimeter:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToProtonPerSquareCentimeter(baseValue);
                case UnitConverterParticleFluenceUnit.ElectronPerSquareCentimeter:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToElectronPerSquareCentimeter(baseValue);
                case UnitConverterParticleFluenceUnit.NeutronPerSquareMeter:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToNeutronPerSquareMeter(baseValue);
                case UnitConverterParticleFluenceUnit.PhotonPerSquareMeter:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToPhotonPerSquareMeter(baseValue);
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMicrometer:
                    return UnitConverterScientificParticleFluence.ParticlePerSquareMeterToParticlePerSquareMicrometer(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported particle fluence unit.");
            }
        }

        public static string GetSymbol(UnitConverterParticleFluenceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMeter:
                    return "1/m²";
                case UnitConverterParticleFluenceUnit.ParticlePerSquareCentimeter:
                    return "1/cm²";
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMillimeter:
                    return "1/mm²";
                case UnitConverterParticleFluenceUnit.ParticlePerSquareFoot:
                    return "1/ft²";
                case UnitConverterParticleFluenceUnit.ParticlePerSquareInch:
                    return "1/in²";
                case UnitConverterParticleFluenceUnit.NeutronPerSquareCentimeter:
                    return "n/cm²";
                case UnitConverterParticleFluenceUnit.PhotonPerSquareCentimeter:
                    return "ph/cm²";
                case UnitConverterParticleFluenceUnit.ParticlePerBarn:
                    return "1/b";
                case UnitConverterParticleFluenceUnit.ProtonPerSquareCentimeter:
                    return "p/cm²";
                case UnitConverterParticleFluenceUnit.ElectronPerSquareCentimeter:
                    return "e⁻/cm²";
                case UnitConverterParticleFluenceUnit.NeutronPerSquareMeter:
                    return "n/m²";
                case UnitConverterParticleFluenceUnit.PhotonPerSquareMeter:
                    return "ph/m²";
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMicrometer:
                    return "1/µm²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterParticleFluenceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMeter:
                    return "Particle Per Square Meter";
                case UnitConverterParticleFluenceUnit.ParticlePerSquareCentimeter:
                    return "Particle Per Square Centimeter";
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMillimeter:
                    return "Particle Per Square Millimeter";
                case UnitConverterParticleFluenceUnit.ParticlePerSquareFoot:
                    return "Particle Per Square Foot";
                case UnitConverterParticleFluenceUnit.ParticlePerSquareInch:
                    return "Particle Per Square Inch";
                case UnitConverterParticleFluenceUnit.NeutronPerSquareCentimeter:
                    return "Neutron Per Square Centimeter";
                case UnitConverterParticleFluenceUnit.PhotonPerSquareCentimeter:
                    return "Photon Per Square Centimeter";
                case UnitConverterParticleFluenceUnit.ParticlePerBarn:
                    return "Particle Per Barn";
                case UnitConverterParticleFluenceUnit.ProtonPerSquareCentimeter:
                    return "Proton Per Square Centimeter";
                case UnitConverterParticleFluenceUnit.ElectronPerSquareCentimeter:
                    return "Electron Per Square Centimeter";
                case UnitConverterParticleFluenceUnit.NeutronPerSquareMeter:
                    return "Neutron Per Square Meter";
                case UnitConverterParticleFluenceUnit.PhotonPerSquareMeter:
                    return "Photon Per Square Meter";
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMicrometer:
                    return "Particle Per Square Micrometer";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterParticleFluenceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluenceUnit.ParticlePerSquareCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMillimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluenceUnit.ParticlePerSquareFoot:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluenceUnit.ParticlePerSquareInch:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluenceUnit.NeutronPerSquareCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluenceUnit.PhotonPerSquareCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluenceUnit.ParticlePerBarn:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluenceUnit.ProtonPerSquareCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluenceUnit.ElectronPerSquareCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluenceUnit.NeutronPerSquareMeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluenceUnit.PhotonPerSquareMeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterParticleFluenceUnit.ParticlePerSquareMicrometer:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterParticleFluenceUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterParticleFluenceUnit.ParticlePerSquareMeter, UnitConverterParticleFluenceUnit.ParticlePerSquareCentimeter, UnitConverterParticleFluenceUnit.ParticlePerSquareMillimeter, UnitConverterParticleFluenceUnit.ParticlePerSquareFoot, UnitConverterParticleFluenceUnit.ParticlePerSquareInch, UnitConverterParticleFluenceUnit.NeutronPerSquareCentimeter, UnitConverterParticleFluenceUnit.PhotonPerSquareCentimeter, UnitConverterParticleFluenceUnit.ParticlePerBarn, UnitConverterParticleFluenceUnit.ProtonPerSquareCentimeter, UnitConverterParticleFluenceUnit.ElectronPerSquareCentimeter, UnitConverterParticleFluenceUnit.NeutronPerSquareMeter, UnitConverterParticleFluenceUnit.PhotonPerSquareMeter, UnitConverterParticleFluenceUnit.ParticlePerSquareMicrometer };
                default:
                    return new[] { UnitConverterParticleFluenceUnit.ParticlePerSquareMeter, UnitConverterParticleFluenceUnit.ParticlePerSquareCentimeter, UnitConverterParticleFluenceUnit.ParticlePerSquareMillimeter, UnitConverterParticleFluenceUnit.ParticlePerSquareFoot, UnitConverterParticleFluenceUnit.ParticlePerSquareInch, UnitConverterParticleFluenceUnit.NeutronPerSquareCentimeter, UnitConverterParticleFluenceUnit.PhotonPerSquareCentimeter, UnitConverterParticleFluenceUnit.ParticlePerBarn, UnitConverterParticleFluenceUnit.ProtonPerSquareCentimeter, UnitConverterParticleFluenceUnit.ElectronPerSquareCentimeter, UnitConverterParticleFluenceUnit.NeutronPerSquareMeter, UnitConverterParticleFluenceUnit.PhotonPerSquareMeter, UnitConverterParticleFluenceUnit.ParticlePerSquareMicrometer };
            }
        }
    }
}
