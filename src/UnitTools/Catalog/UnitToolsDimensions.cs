namespace UnitTools.Catalog
{
    using System;

    /// <summary>
    /// Exponents for the physical base dimensions used by UnitTools.
    /// Angles and counts are dimensionless. Information is tracked separately
    /// so digital storage and data rate do not collapse into ordinary dimensionless/time quantities.
    /// </summary>
    public readonly struct UnitToolsDimensions : IEquatable<UnitToolsDimensions>
    {
        public UnitToolsDimensions(
            int mass,
            int length,
            int time,
            int electricCurrent,
            int temperature,
            int amountOfSubstance,
            int luminousIntensity,
            int information)
        {
            Mass = mass;
            Length = length;
            Time = time;
            ElectricCurrent = electricCurrent;
            Temperature = temperature;
            AmountOfSubstance = amountOfSubstance;
            LuminousIntensity = luminousIntensity;
            Information = information;
        }

        public int Mass { get; }
        public int Length { get; }
        public int Time { get; }
        public int ElectricCurrent { get; }
        public int Temperature { get; }
        public int AmountOfSubstance { get; }
        public int LuminousIntensity { get; }
        public int Information { get; }

        public bool IsDimensionless =>
            Mass == 0 &&
            Length == 0 &&
            Time == 0 &&
            ElectricCurrent == 0 &&
            Temperature == 0 &&
            AmountOfSubstance == 0 &&
            LuminousIntensity == 0 &&
            Information == 0;

        public static UnitToolsDimensions Dimensionless =>
            new UnitToolsDimensions(0, 0, 0, 0, 0, 0, 0, 0);

        public UnitToolsDimensions Multiply(UnitToolsDimensions other)
        {
            return new UnitToolsDimensions(
                Mass + other.Mass,
                Length + other.Length,
                Time + other.Time,
                ElectricCurrent + other.ElectricCurrent,
                Temperature + other.Temperature,
                AmountOfSubstance + other.AmountOfSubstance,
                LuminousIntensity + other.LuminousIntensity,
                Information + other.Information);
        }

        public UnitToolsDimensions Divide(UnitToolsDimensions other)
        {
            return new UnitToolsDimensions(
                Mass - other.Mass,
                Length - other.Length,
                Time - other.Time,
                ElectricCurrent - other.ElectricCurrent,
                Temperature - other.Temperature,
                AmountOfSubstance - other.AmountOfSubstance,
                LuminousIntensity - other.LuminousIntensity,
                Information - other.Information);
        }

        public UnitToolsDimensions Pow(int exponent)
        {
            return new UnitToolsDimensions(
                Mass * exponent,
                Length * exponent,
                Time * exponent,
                ElectricCurrent * exponent,
                Temperature * exponent,
                AmountOfSubstance * exponent,
                LuminousIntensity * exponent,
                Information * exponent);
        }

        public bool Equals(UnitToolsDimensions other)
        {
            return Mass == other.Mass &&
                Length == other.Length &&
                Time == other.Time &&
                ElectricCurrent == other.ElectricCurrent &&
                Temperature == other.Temperature &&
                AmountOfSubstance == other.AmountOfSubstance &&
                LuminousIntensity == other.LuminousIntensity &&
                Information == other.Information;
        }

        public override bool Equals(object obj)
        {
            return obj is UnitToolsDimensions && Equals((UnitToolsDimensions)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = Mass;
                hash = (hash * 397) ^ Length;
                hash = (hash * 397) ^ Time;
                hash = (hash * 397) ^ ElectricCurrent;
                hash = (hash * 397) ^ Temperature;
                hash = (hash * 397) ^ AmountOfSubstance;
                hash = (hash * 397) ^ LuminousIntensity;
                hash = (hash * 397) ^ Information;
                return hash;
            }
        }

        public static bool operator ==(UnitToolsDimensions left, UnitToolsDimensions right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(UnitToolsDimensions left, UnitToolsDimensions right)
        {
            return !left.Equals(right);
        }

        internal static UnitToolsDimensions ForFamily(UnitToolsFamily family)
        {
            switch (family)
            {
                case UnitToolsFamily.Acceleration: return D(0, 1, -2);
                case UnitToolsFamily.ActivityConcentration: return D(0, -3, -1);
                case UnitToolsFamily.AmountOfSubstance: return D(0, 0, 0, 0, 0, 1);
                case UnitToolsFamily.Angle: return Dimensionless;
                case UnitToolsFamily.AngularAcceleration: return D(0, 0, -2);
                case UnitToolsFamily.AngularMomentum: return D(1, 2, -1);
                case UnitToolsFamily.AngularVelocity: return D(0, 0, -1);
                case UnitToolsFamily.Area: return D(0, 2, 0);
                case UnitToolsFamily.AreaDensity: return D(1, -2, 0);
                case UnitToolsFamily.Capacitance: return D(-1, -2, 4, 2);
                case UnitToolsFamily.ChargeDensity: return D(0, -3, 1, 1);
                case UnitToolsFamily.Compressibility: return D(-1, 1, 2);
                case UnitToolsFamily.Conductance: return D(-1, -2, 3, 2);
                case UnitToolsFamily.Current: return D(0, 0, 0, 1);
                case UnitToolsFamily.CurrentDensity: return D(0, -2, 0, 1);
                case UnitToolsFamily.DataRate: return D(0, 0, -1, 0, 0, 0, 0, 1);
                case UnitToolsFamily.Density: return D(1, -3, 0);
                case UnitToolsFamily.DiffusionCoefficient: return D(0, 2, -1);
                case UnitToolsFamily.DigitalStorage: return D(0, 0, 0, 0, 0, 0, 0, 1);
                case UnitToolsFamily.DoseRate: return D(0, 2, -3);
                case UnitToolsFamily.DynamicPressure: return D(1, -1, -2);
                case UnitToolsFamily.DynamicViscosity: return D(1, -1, -1);
                case UnitToolsFamily.ElectricCharge: return D(0, 0, 1, 1);
                case UnitToolsFamily.ElectricFieldStrength: return D(1, 1, -3, -1);
                case UnitToolsFamily.ElectricFlux: return D(1, 3, -3, -1);
                case UnitToolsFamily.ElectricFluxDensity: return D(0, -2, 1, 1);
                case UnitToolsFamily.ElectricResistance: return D(1, 2, -3, -2);
                case UnitToolsFamily.ElectricalConductivity: return D(-1, -3, 3, 2);
                case UnitToolsFamily.ElectricalResistivity: return D(1, 3, -3, -2);
                case UnitToolsFamily.Energy: return D(1, 2, -2);
                case UnitToolsFamily.EnergyDensity: return D(1, -1, -2);
                case UnitToolsFamily.ExposureRate: return D(-1, 0, 0, 1);
                case UnitToolsFamily.Force: return D(1, 1, -2);
                case UnitToolsFamily.ForcePerLength: return D(1, 0, -2);
                case UnitToolsFamily.FrameRate: return D(0, 0, -1);
                case UnitToolsFamily.Frequency: return D(0, 0, -1);
                case UnitToolsFamily.FuelEconomy: return D(0, -2, 0);
                case UnitToolsFamily.HeatTransferCoefficient: return D(1, 0, -3, 0, -1);
                case UnitToolsFamily.HydraulicPermeability: return D(0, 2, 0);
                case UnitToolsFamily.Illuminance: return D(0, -2, 0, 0, 0, 0, 1);
                case UnitToolsFamily.Impulse: return D(1, 1, -1);
                case UnitToolsFamily.Inductance: return D(1, 2, -2, -2);
                case UnitToolsFamily.Irradiance: return D(1, 0, -3);
                case UnitToolsFamily.Jerk: return D(0, 1, -3);
                case UnitToolsFamily.KinematicViscosity: return D(0, 2, -1);
                case UnitToolsFamily.Length: return D(0, 1, 0);
                case UnitToolsFamily.LinearDensity: return D(1, -1, 0);
                case UnitToolsFamily.Luminance: return D(0, -2, 0, 0, 0, 0, 1);
                case UnitToolsFamily.LuminousEfficacy: return D(-1, -2, 3, 0, 0, 0, 1);
                case UnitToolsFamily.LuminousEnergy: return D(0, 0, 1, 0, 0, 0, 1);
                case UnitToolsFamily.LuminousExposure: return D(0, -2, 1, 0, 0, 0, 1);
                case UnitToolsFamily.LuminousFlux: return D(0, 0, 0, 0, 0, 0, 1);
                case UnitToolsFamily.LuminousIntensity: return D(0, 0, 0, 0, 0, 0, 1);
                case UnitToolsFamily.MagneticField: return D(1, 0, -2, -1);
                case UnitToolsFamily.MagneticFlux: return D(1, 2, -2, -1);
                case UnitToolsFamily.MagneticPermeability: return D(1, 1, -2, -2);
                case UnitToolsFamily.MagnetizingFieldStrength: return D(0, -1, 0, 1);
                case UnitToolsFamily.Mass: return D(1, 0, 0);
                case UnitToolsFamily.MassConcentration: return D(1, -3, 0);
                case UnitToolsFamily.MassFlowRate: return D(1, 0, -1);
                case UnitToolsFamily.MassFlux: return D(1, -2, -1);
                case UnitToolsFamily.MolarConcentration: return D(0, -3, 0, 0, 0, 1);
                case UnitToolsFamily.MolarMass: return D(1, 0, 0, 0, 0, -1);
                case UnitToolsFamily.MomentOfInertia: return D(1, 2, 0);
                case UnitToolsFamily.Momentum: return D(1, 1, -1);
                case UnitToolsFamily.ParticleFluence: return D(0, -2, 0);
                case UnitToolsFamily.ParticleFlux: return D(0, -2, -1);
                case UnitToolsFamily.Permittivity: return D(-1, -3, 4, 2);
                case UnitToolsFamily.PixelDensity: return D(0, -1, 0);
                case UnitToolsFamily.Power: return D(1, 2, -3);
                case UnitToolsFamily.PowerDensity: return D(1, -1, -3);
                case UnitToolsFamily.Pressure: return D(1, -1, -2);
                case UnitToolsFamily.PressureGradient: return D(1, -2, -2);
                case UnitToolsFamily.Radiance: return D(1, 0, -3);
                case UnitToolsFamily.RadiationDose: return D(0, 2, -2);
                case UnitToolsFamily.RadiationExposure: return D(-1, 0, 1, 1);
                case UnitToolsFamily.Radioactivity: return D(0, 0, -1);
                case UnitToolsFamily.Snap: return D(0, 1, -4);
                case UnitToolsFamily.SpecificGravity: return Dimensionless;
                case UnitToolsFamily.SpecificHeatCapacity: return D(0, 2, -2, 0, -1);
                case UnitToolsFamily.SpecificVolume: return D(-1, 3, 0);
                case UnitToolsFamily.SpecificWeight: return D(1, -2, -2);
                case UnitToolsFamily.Speed: return D(0, 1, -1);
                case UnitToolsFamily.SurfaceTension: return D(1, 0, -2);
                case UnitToolsFamily.Temperature: return D(0, 0, 0, 0, 1);
                case UnitToolsFamily.ThermalConductivity: return D(1, 1, -3, 0, -1);
                case UnitToolsFamily.ThermalDiffusivity: return D(0, 2, -1);
                case UnitToolsFamily.ThermalExpansion: return D(0, 0, 0, 0, -1);
                case UnitToolsFamily.Time: return D(0, 0, 1);
                case UnitToolsFamily.Torque: return D(1, 2, -2);
                case UnitToolsFamily.TorquePerAngle: return D(1, 2, -2);
                case UnitToolsFamily.VaporPressure: return D(1, -1, -2);
                case UnitToolsFamily.Voltage: return D(1, 2, -3, -1);
                case UnitToolsFamily.Volume: return D(0, 3, 0);
                case UnitToolsFamily.VolumetricFlowRate: return D(0, 3, -1);
                case UnitToolsFamily.VolumetricFlux: return D(0, 1, -1);
                case UnitToolsFamily.Yank: return D(1, 1, -3);
                case UnitToolsFamily.TemperatureDelta: return D(0, 0, 0, 0, 1);
                case UnitToolsFamily.Stress: return D(1, -1, -2);
                case UnitToolsFamily.Strain: return D(0, 0, 0);
                case UnitToolsFamily.StrainRate: return D(0, 0, -1);
                case UnitToolsFamily.YoungModulus: return D(1, -1, -2);
                case UnitToolsFamily.ShearModulus: return D(1, -1, -2);
                case UnitToolsFamily.BulkModulus: return D(1, -1, -2);
                case UnitToolsFamily.Compliance: return D(-1, 1, 2);
                case UnitToolsFamily.SpringConstant: return D(1, 0, -2);
                case UnitToolsFamily.FlexuralRigidity: return D(1, 3, -2);
                case UnitToolsFamily.DampingCoefficient: return D(1, 0, -1);
                case UnitToolsFamily.MechanicalMobility: return D(-1, 0, 1);
                case UnitToolsFamily.SectionModulus: return D(0, 3, 0);
                case UnitToolsFamily.AreaMomentOfInertia: return D(0, 4, 0);
                case UnitToolsFamily.HeatCapacity: return D(1, 2, -2, 0, -1);
                case UnitToolsFamily.ThermalResistance: return D(-1, -2, 3, 0, 1);
                case UnitToolsFamily.ThermalConductance: return D(1, 2, -3, 0, -1);
                case UnitToolsFamily.ThermalResistivity: return D(-1, -1, 3, 0, 1);
                case UnitToolsFamily.Entropy: return D(1, 2, -2, 0, -1);
                case UnitToolsFamily.SpecificEntropy: return D(0, 2, -2, 0, -1);
                case UnitToolsFamily.MolarEntropy: return D(1, 2, -2, 0, -1, -1);
                case UnitToolsFamily.SpecificEnergy: return D(0, 2, -2);
                case UnitToolsFamily.SpecificEnthalpy: return D(0, 2, -2);
                case UnitToolsFamily.MolarEnergy: return D(1, 2, -2, 0, 0, -1);
                case UnitToolsFamily.MolarHeatCapacity: return D(1, 2, -2, 0, -1, -1);
                case UnitToolsFamily.VolumetricHeatCapacity: return D(1, -1, -2, 0, -1);
                case UnitToolsFamily.HeatFluxDensity: return D(1, 0, -3);
                case UnitToolsFamily.AngularFrequency: return D(0, 0, -1);
                case UnitToolsFamily.Wavenumber: return D(0, -1, 0);
                case UnitToolsFamily.LinearChargeDensity: return D(0, -1, 1, 1);
                case UnitToolsFamily.SurfaceChargeDensity: return D(0, -2, 1, 1);
                case UnitToolsFamily.ElectricDipoleMoment: return D(0, 1, 1, 1);
                case UnitToolsFamily.MagneticDipoleMoment: return D(0, 2, 0, 1);
                case UnitToolsFamily.MagneticReluctance: return D(-1, -2, 2, 2);
                case UnitToolsFamily.Elastance: return D(1, 2, -4, -2);
                case UnitToolsFamily.Impedance: return D(1, 2, -3, -2);
                case UnitToolsFamily.Reactance: return D(1, 2, -3, -2);
                case UnitToolsFamily.ElectricSusceptibility: return D(0, 0, 0);
                case UnitToolsFamily.MagneticSusceptibility: return D(0, 0, 0);
                case UnitToolsFamily.MagneticVectorPotential: return D(1, 1, -2, -1);
                case UnitToolsFamily.CatalyticActivity: return D(0, 0, -1, 0, 0, 1);
                case UnitToolsFamily.CatalyticActivityConcentration: return D(0, -3, -1, 0, 0, 1);
                case UnitToolsFamily.Molality: return D(-1, 0, 0, 0, 0, 1);
                case UnitToolsFamily.MoleFraction: return D(0, 0, 0);
                case UnitToolsFamily.MassFraction: return D(0, 0, 0);
                case UnitToolsFamily.VolumeFraction: return D(0, 0, 0);
                case UnitToolsFamily.Osmolarity: return D(0, -3, 0, 0, 0, 1);
                case UnitToolsFamily.Osmolality: return D(-1, 0, 0, 0, 0, 1);
                case UnitToolsFamily.AmountFlowRate: return D(0, 0, -1, 0, 0, 1);
                case UnitToolsFamily.MolarVolume: return D(0, 3, 0, 0, 0, -1);
                case UnitToolsFamily.Permeability: return D(0, 2, 0);
                case UnitToolsFamily.Porosity: return D(0, 0, 0);
                case UnitToolsFamily.SpecificSurfaceArea: return D(-1, 2, 0);
                default:
                    throw new ArgumentOutOfRangeException(nameof(family), family, "No dimensional metadata is registered.");
            }
        }


        internal static UnitToolsDimensions ForFuelEconomyUnit(
            UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit unit)
        {
            switch (unit)
            {
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.KilometerPerLiter:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.MilePerUSGallon:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.MilePerImperialGallon:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.MilePerLiter:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.NauticalMilePerUSGallon:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.MeterPerLiter:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.KilometerPerUSGallon:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.KilometerPerImperialGallon:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.NauticalMilePerImperialGallon:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.KilometerPerMilliliter:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.MeterPerMilliliter:
                    return D(0, -2, 0);

                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.LiterPer100Kilometer:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.LiterPerKilometer:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.LiterPerMile:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.USGallonPerMile:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.ImperialGallonPerMile:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.MilliliterPerKilometer:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.LiterPer10Kilometer:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.LiterPer100Mile:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.USGallonPer100Mile:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.ImperialGallonPer100Mile:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.USGallonPer100Kilometer:
                case UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit.ImperialGallonPer100Kilometer:
                    return D(0, 2, 0);

                default:
                    throw new ArgumentOutOfRangeException(nameof(unit), unit, "No dimensional metadata is registered.");
            }
        }

        private static UnitToolsDimensions D(
            int mass,
            int length,
            int time,
            int electricCurrent = 0,
            int temperature = 0,
            int amountOfSubstance = 0,
            int luminousIntensity = 0,
            int information = 0)
        {
            return new UnitToolsDimensions(
                mass,
                length,
                time,
                electricCurrent,
                temperature,
                amountOfSubstance,
                luminousIntensity,
                information);
        }
    }
}
