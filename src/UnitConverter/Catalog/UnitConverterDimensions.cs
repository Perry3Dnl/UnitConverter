namespace UnitConverter.Catalog
{
    using System;

    /// <summary>
    /// Exponents for the physical base dimensions used by UnitConverter.
    /// Angles and counts are dimensionless. Information is tracked separately
    /// so digital storage and data rate do not collapse into ordinary dimensionless/time quantities.
    /// </summary>
    public readonly struct UnitConverterDimensions : IEquatable<UnitConverterDimensions>
    {
        public UnitConverterDimensions(
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

        public static UnitConverterDimensions Dimensionless =>
            new UnitConverterDimensions(0, 0, 0, 0, 0, 0, 0, 0);

        public UnitConverterDimensions Multiply(UnitConverterDimensions other)
        {
            return new UnitConverterDimensions(
                Mass + other.Mass,
                Length + other.Length,
                Time + other.Time,
                ElectricCurrent + other.ElectricCurrent,
                Temperature + other.Temperature,
                AmountOfSubstance + other.AmountOfSubstance,
                LuminousIntensity + other.LuminousIntensity,
                Information + other.Information);
        }

        public UnitConverterDimensions Divide(UnitConverterDimensions other)
        {
            return new UnitConverterDimensions(
                Mass - other.Mass,
                Length - other.Length,
                Time - other.Time,
                ElectricCurrent - other.ElectricCurrent,
                Temperature - other.Temperature,
                AmountOfSubstance - other.AmountOfSubstance,
                LuminousIntensity - other.LuminousIntensity,
                Information - other.Information);
        }

        public UnitConverterDimensions Pow(int exponent)
        {
            return new UnitConverterDimensions(
                Mass * exponent,
                Length * exponent,
                Time * exponent,
                ElectricCurrent * exponent,
                Temperature * exponent,
                AmountOfSubstance * exponent,
                LuminousIntensity * exponent,
                Information * exponent);
        }

        public bool Equals(UnitConverterDimensions other)
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
            return obj is UnitConverterDimensions && Equals((UnitConverterDimensions)obj);
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

        public static bool operator ==(UnitConverterDimensions left, UnitConverterDimensions right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(UnitConverterDimensions left, UnitConverterDimensions right)
        {
            return !left.Equals(right);
        }

        internal static UnitConverterDimensions ForFamily(UnitConverterFamily family)
        {
            switch (family)
            {
                case UnitConverterFamily.Acceleration: return D(0, 1, -2);
                case UnitConverterFamily.ActivityConcentration: return D(0, -3, -1);
                case UnitConverterFamily.AmountOfSubstance: return D(0, 0, 0, 0, 0, 1);
                case UnitConverterFamily.Angle: return Dimensionless;
                case UnitConverterFamily.AngularAcceleration: return D(0, 0, -2);
                case UnitConverterFamily.AngularMomentum: return D(1, 2, -1);
                case UnitConverterFamily.AngularVelocity: return D(0, 0, -1);
                case UnitConverterFamily.Area: return D(0, 2, 0);
                case UnitConverterFamily.AreaDensity: return D(1, -2, 0);
                case UnitConverterFamily.Capacitance: return D(-1, -2, 4, 2);
                case UnitConverterFamily.ChargeDensity: return D(0, -3, 1, 1);
                case UnitConverterFamily.Compressibility: return D(-1, 1, 2);
                case UnitConverterFamily.Conductance: return D(-1, -2, 3, 2);
                case UnitConverterFamily.Current: return D(0, 0, 0, 1);
                case UnitConverterFamily.CurrentDensity: return D(0, -2, 0, 1);
                case UnitConverterFamily.DataRate: return D(0, 0, -1, 0, 0, 0, 0, 1);
                case UnitConverterFamily.Density: return D(1, -3, 0);
                case UnitConverterFamily.DiffusionCoefficient: return D(0, 2, -1);
                case UnitConverterFamily.DigitalStorage: return D(0, 0, 0, 0, 0, 0, 0, 1);
                case UnitConverterFamily.DoseRate: return D(0, 2, -3);
                case UnitConverterFamily.DynamicPressure: return D(1, -1, -2);
                case UnitConverterFamily.DynamicViscosity: return D(1, -1, -1);
                case UnitConverterFamily.ElectricCharge: return D(0, 0, 1, 1);
                case UnitConverterFamily.ElectricFieldStrength: return D(1, 1, -3, -1);
                case UnitConverterFamily.ElectricFlux: return D(1, 3, -3, -1);
                case UnitConverterFamily.ElectricFluxDensity: return D(0, -2, 1, 1);
                case UnitConverterFamily.ElectricResistance: return D(1, 2, -3, -2);
                case UnitConverterFamily.ElectricalConductivity: return D(-1, -3, 3, 2);
                case UnitConverterFamily.ElectricalResistivity: return D(1, 3, -3, -2);
                case UnitConverterFamily.Energy: return D(1, 2, -2);
                case UnitConverterFamily.EnergyDensity: return D(1, -1, -2);
                case UnitConverterFamily.ExposureRate: return D(-1, 0, 0, 1);
                case UnitConverterFamily.Force: return D(1, 1, -2);
                case UnitConverterFamily.ForcePerLength: return D(1, 0, -2);
                case UnitConverterFamily.FrameRate: return D(0, 0, -1);
                case UnitConverterFamily.Frequency: return D(0, 0, -1);
                case UnitConverterFamily.FuelEconomy: return D(0, -2, 0);
                case UnitConverterFamily.HeatTransferCoefficient: return D(1, 0, -3, 0, -1);
                case UnitConverterFamily.HydraulicPermeability: return D(0, 2, 0);
                case UnitConverterFamily.Illuminance: return D(0, -2, 0, 0, 0, 0, 1);
                case UnitConverterFamily.Impulse: return D(1, 1, -1);
                case UnitConverterFamily.Inductance: return D(1, 2, -2, -2);
                case UnitConverterFamily.Irradiance: return D(1, 0, -3);
                case UnitConverterFamily.Jerk: return D(0, 1, -3);
                case UnitConverterFamily.KinematicViscosity: return D(0, 2, -1);
                case UnitConverterFamily.Length: return D(0, 1, 0);
                case UnitConverterFamily.LinearDensity: return D(1, -1, 0);
                case UnitConverterFamily.Luminance: return D(0, -2, 0, 0, 0, 0, 1);
                case UnitConverterFamily.LuminousEfficacy: return D(-1, -2, 3, 0, 0, 0, 1);
                case UnitConverterFamily.LuminousEnergy: return D(0, 0, 1, 0, 0, 0, 1);
                case UnitConverterFamily.LuminousExposure: return D(0, -2, 1, 0, 0, 0, 1);
                case UnitConverterFamily.LuminousFlux: return D(0, 0, 0, 0, 0, 0, 1);
                case UnitConverterFamily.LuminousIntensity: return D(0, 0, 0, 0, 0, 0, 1);
                case UnitConverterFamily.MagneticField: return D(1, 0, -2, -1);
                case UnitConverterFamily.MagneticFlux: return D(1, 2, -2, -1);
                case UnitConverterFamily.MagneticPermeability: return D(1, 1, -2, -2);
                case UnitConverterFamily.MagnetizingFieldStrength: return D(0, -1, 0, 1);
                case UnitConverterFamily.Mass: return D(1, 0, 0);
                case UnitConverterFamily.MassConcentration: return D(1, -3, 0);
                case UnitConverterFamily.MassFlowRate: return D(1, 0, -1);
                case UnitConverterFamily.MassFlux: return D(1, -2, -1);
                case UnitConverterFamily.MolarConcentration: return D(0, -3, 0, 0, 0, 1);
                case UnitConverterFamily.MolarMass: return D(1, 0, 0, 0, 0, -1);
                case UnitConverterFamily.MomentOfInertia: return D(1, 2, 0);
                case UnitConverterFamily.Momentum: return D(1, 1, -1);
                case UnitConverterFamily.ParticleFluence: return D(0, -2, 0);
                case UnitConverterFamily.ParticleFlux: return D(0, -2, -1);
                case UnitConverterFamily.Permittivity: return D(-1, -3, 4, 2);
                case UnitConverterFamily.PixelDensity: return D(0, -1, 0);
                case UnitConverterFamily.Power: return D(1, 2, -3);
                case UnitConverterFamily.PowerDensity: return D(1, -1, -3);
                case UnitConverterFamily.Pressure: return D(1, -1, -2);
                case UnitConverterFamily.PressureGradient: return D(1, -2, -2);
                case UnitConverterFamily.Radiance: return D(1, 0, -3);
                case UnitConverterFamily.RadiationDose: return D(0, 2, -2);
                case UnitConverterFamily.RadiationExposure: return D(-1, 0, 1, 1);
                case UnitConverterFamily.Radioactivity: return D(0, 0, -1);
                case UnitConverterFamily.Snap: return D(0, 1, -4);
                case UnitConverterFamily.SpecificGravity: return Dimensionless;
                case UnitConverterFamily.SpecificHeatCapacity: return D(0, 2, -2, 0, -1);
                case UnitConverterFamily.SpecificVolume: return D(-1, 3, 0);
                case UnitConverterFamily.SpecificWeight: return D(1, -2, -2);
                case UnitConverterFamily.Speed: return D(0, 1, -1);
                case UnitConverterFamily.SurfaceTension: return D(1, 0, -2);
                case UnitConverterFamily.Temperature: return D(0, 0, 0, 0, 1);
                case UnitConverterFamily.ThermalConductivity: return D(1, 1, -3, 0, -1);
                case UnitConverterFamily.ThermalDiffusivity: return D(0, 2, -1);
                case UnitConverterFamily.ThermalExpansion: return D(0, 0, 0, 0, -1);
                case UnitConverterFamily.Time: return D(0, 0, 1);
                case UnitConverterFamily.Torque: return D(1, 2, -2);
                case UnitConverterFamily.TorquePerAngle: return D(1, 2, -2);
                case UnitConverterFamily.VaporPressure: return D(1, -1, -2);
                case UnitConverterFamily.Voltage: return D(1, 2, -3, -1);
                case UnitConverterFamily.Volume: return D(0, 3, 0);
                case UnitConverterFamily.VolumetricFlowRate: return D(0, 3, -1);
                case UnitConverterFamily.VolumetricFlux: return D(0, 1, -1);
                case UnitConverterFamily.Yank: return D(1, 1, -3);
                case UnitConverterFamily.TemperatureDelta: return D(0, 0, 0, 0, 1);
                case UnitConverterFamily.Stress: return D(1, -1, -2);
                case UnitConverterFamily.Strain: return D(0, 0, 0);
                case UnitConverterFamily.StrainRate: return D(0, 0, -1);
                case UnitConverterFamily.YoungModulus: return D(1, -1, -2);
                case UnitConverterFamily.ShearModulus: return D(1, -1, -2);
                case UnitConverterFamily.BulkModulus: return D(1, -1, -2);
                case UnitConverterFamily.Compliance: return D(-1, 1, 2);
                case UnitConverterFamily.SpringConstant: return D(1, 0, -2);
                case UnitConverterFamily.FlexuralRigidity: return D(1, 3, -2);
                case UnitConverterFamily.DampingCoefficient: return D(1, 0, -1);
                case UnitConverterFamily.MechanicalMobility: return D(-1, 0, 1);
                case UnitConverterFamily.SectionModulus: return D(0, 3, 0);
                case UnitConverterFamily.AreaMomentOfInertia: return D(0, 4, 0);
                case UnitConverterFamily.HeatCapacity: return D(1, 2, -2, 0, -1);
                case UnitConverterFamily.ThermalResistance: return D(-1, -2, 3, 0, 1);
                case UnitConverterFamily.ThermalConductance: return D(1, 2, -3, 0, -1);
                case UnitConverterFamily.ThermalResistivity: return D(-1, -1, 3, 0, 1);
                case UnitConverterFamily.Entropy: return D(1, 2, -2, 0, -1);
                case UnitConverterFamily.SpecificEntropy: return D(0, 2, -2, 0, -1);
                case UnitConverterFamily.MolarEntropy: return D(1, 2, -2, 0, -1, -1);
                case UnitConverterFamily.SpecificEnergy: return D(0, 2, -2);
                case UnitConverterFamily.SpecificEnthalpy: return D(0, 2, -2);
                case UnitConverterFamily.MolarEnergy: return D(1, 2, -2, 0, 0, -1);
                case UnitConverterFamily.MolarHeatCapacity: return D(1, 2, -2, 0, -1, -1);
                case UnitConverterFamily.VolumetricHeatCapacity: return D(1, -1, -2, 0, -1);
                case UnitConverterFamily.HeatFluxDensity: return D(1, 0, -3);
                case UnitConverterFamily.AngularFrequency: return D(0, 0, -1);
                case UnitConverterFamily.Wavenumber: return D(0, -1, 0);
                case UnitConverterFamily.LinearChargeDensity: return D(0, -1, 1, 1);
                case UnitConverterFamily.SurfaceChargeDensity: return D(0, -2, 1, 1);
                case UnitConverterFamily.ElectricDipoleMoment: return D(0, 1, 1, 1);
                case UnitConverterFamily.MagneticDipoleMoment: return D(0, 2, 0, 1);
                case UnitConverterFamily.MagneticReluctance: return D(-1, -2, 2, 2);
                case UnitConverterFamily.Elastance: return D(1, 2, -4, -2);
                case UnitConverterFamily.Impedance: return D(1, 2, -3, -2);
                case UnitConverterFamily.Reactance: return D(1, 2, -3, -2);
                case UnitConverterFamily.ElectricSusceptibility: return D(0, 0, 0);
                case UnitConverterFamily.MagneticSusceptibility: return D(0, 0, 0);
                case UnitConverterFamily.MagneticVectorPotential: return D(1, 1, -2, -1);
                case UnitConverterFamily.CatalyticActivity: return D(0, 0, -1, 0, 0, 1);
                case UnitConverterFamily.CatalyticActivityConcentration: return D(0, -3, -1, 0, 0, 1);
                case UnitConverterFamily.Molality: return D(-1, 0, 0, 0, 0, 1);
                case UnitConverterFamily.MoleFraction: return D(0, 0, 0);
                case UnitConverterFamily.MassFraction: return D(0, 0, 0);
                case UnitConverterFamily.VolumeFraction: return D(0, 0, 0);
                case UnitConverterFamily.Osmolarity: return D(0, -3, 0, 0, 0, 1);
                case UnitConverterFamily.Osmolality: return D(-1, 0, 0, 0, 0, 1);
                case UnitConverterFamily.AmountFlowRate: return D(0, 0, -1, 0, 0, 1);
                case UnitConverterFamily.MolarVolume: return D(0, 3, 0, 0, 0, -1);
                case UnitConverterFamily.Permeability: return D(0, 2, 0);
                case UnitConverterFamily.Porosity: return D(0, 0, 0);
                case UnitConverterFamily.SpecificSurfaceArea: return D(-1, 2, 0);
                default:
                    throw new ArgumentOutOfRangeException(nameof(family), family, "No dimensional metadata is registered.");
            }
        }


        internal static UnitConverterDimensions ForFuelEconomyUnit(
            UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit unit)
        {
            switch (unit)
            {
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.KilometerPerLiter:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.MilePerUSGallon:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.MilePerImperialGallon:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.MilePerLiter:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.NauticalMilePerUSGallon:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.MeterPerLiter:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.KilometerPerUSGallon:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.KilometerPerImperialGallon:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.NauticalMilePerImperialGallon:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.KilometerPerMilliliter:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.MeterPerMilliliter:
                    return D(0, -2, 0);

                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.LiterPer100Kilometer:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.LiterPerKilometer:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.LiterPerMile:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.USGallonPerMile:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.ImperialGallonPerMile:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.MilliliterPerKilometer:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.LiterPer10Kilometer:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.LiterPer100Mile:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.USGallonPer100Mile:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.ImperialGallonPer100Mile:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.USGallonPer100Kilometer:
                case UnitConverter.FuelEconomy.UnitConverterFuelEconomyUnit.ImperialGallonPer100Kilometer:
                    return D(0, 2, 0);

                default:
                    throw new ArgumentOutOfRangeException(nameof(unit), unit, "No dimensional metadata is registered.");
            }
        }

        private static UnitConverterDimensions D(
            int mass,
            int length,
            int time,
            int electricCurrent = 0,
            int temperature = 0,
            int amountOfSubstance = 0,
            int luminousIntensity = 0,
            int information = 0)
        {
            return new UnitConverterDimensions(
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
