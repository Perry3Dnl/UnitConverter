namespace UnitConverter.Catalog
{
    public static class UnitConverterCatalog
    {
        public static string[] GetFamilyNames()
        {
            return new[]
            {
                "Acceleration",
                "ActivityConcentration",
                "AmountOfSubstance",
                "Angle",
                "AngularAcceleration",
                "AngularMomentum",
                "AngularVelocity",
                "Area",
                "AreaDensity",
                "Capacitance",
                "ChargeDensity",
                "Compressibility",
                "Conductance",
                "Current",
                "CurrentDensity",
                "DataRate",
                "Density",
                "DiffusionCoefficient",
                "DigitalStorage",
                "DoseRate",
                "DynamicPressure",
                "DynamicViscosity",
                "ElectricCharge",
                "ElectricFieldStrength",
                "ElectricFlux",
                "ElectricFluxDensity",
                "ElectricResistance",
                "ElectricalConductivity",
                "ElectricalResistivity",
                "Energy",
                "EnergyDensity",
                "ExposureRate",
                "Force",
                "ForcePerLength",
                "FrameRate",
                "Frequency",
                "FuelEconomy",
                "HeatTransferCoefficient",
                "HydraulicPermeability",
                "Illuminance",
                "Impulse",
                "Inductance",
                "Irradiance",
                "Jerk",
                "KinematicViscosity",
                "Length",
                "LinearDensity",
                "Luminance",
                "LuminousEfficacy",
                "LuminousEnergy",
                "LuminousExposure",
                "LuminousFlux",
                "LuminousIntensity",
                "MagneticField",
                "MagneticFlux",
                "MagneticPermeability",
                "MagnetizingFieldStrength",
                "Mass",
                "MassConcentration",
                "MassFlowRate",
                "MassFlux",
                "MolarConcentration",
                "MolarMass",
                "MomentOfInertia",
                "Momentum",
                "ParticleFluence",
                "ParticleFlux",
                "Permittivity",
                "PixelDensity",
                "Power",
                "PowerDensity",
                "Pressure",
                "PressureGradient",
                "Radiance",
                "RadiationDose",
                "RadiationExposure",
                "Radioactivity",
                "Snap",
                "SpecificGravity",
                "SpecificHeatCapacity",
                "SpecificVolume",
                "SpecificWeight",
                "Speed",
                "SurfaceTension",
                "Temperature",
                "ThermalConductivity",
                "ThermalDiffusivity",
                "ThermalExpansion",
                "Time",
                "Torque",
                "TorquePerAngle",
                "VaporPressure",
                "Voltage",
                "Volume",
                "VolumetricFlowRate",
                "VolumetricFlux",
                "Yank",
            };
        }

        public static string GetBaseUnitName(string familyName)
        {
            switch (familyName)
            {
                case "Acceleration":
                    return "MeterPerSecondSquared";
                case "ActivityConcentration":
                    return "BecquerelPerCubicMeter";
                case "AmountOfSubstance":
                    return "Mole";
                case "Angle":
                    return "Degree";
                case "AngularAcceleration":
                    return "RadianPerSecondSquared";
                case "AngularMomentum":
                    return "KilogramSquareMeterPerSecond";
                case "AngularVelocity":
                    return "RadianPerSecond";
                case "Area":
                    return "SquareMeter";
                case "AreaDensity":
                    return "KilogramPerSquareMeter";
                case "Capacitance":
                    return "Farad";
                case "ChargeDensity":
                    return "CoulombPerCubicMeter";
                case "Compressibility":
                    return "PerPascal";
                case "Conductance":
                    return "Siemens";
                case "Current":
                    return "Ampere";
                case "CurrentDensity":
                    return "AmperePerSquareMeter";
                case "DataRate":
                    return "BitPerSecond";
                case "Density":
                    return "KilogramPerCubicMeter";
                case "DiffusionCoefficient":
                    return "SquareMeterPerSecond";
                case "DigitalStorage":
                    return "Byte";
                case "DoseRate":
                    return "GrayPerSecond";
                case "DynamicPressure":
                    return "Pascal";
                case "DynamicViscosity":
                    return "PascalSecond";
                case "ElectricCharge":
                    return "Coulomb";
                case "ElectricFieldStrength":
                    return "VoltPerMeter";
                case "ElectricFlux":
                    return "VoltMeter";
                case "ElectricFluxDensity":
                    return "CoulombPerSquareMeter";
                case "ElectricResistance":
                    return "Ohm";
                case "ElectricalConductivity":
                    return "SiemensPerMeter";
                case "ElectricalResistivity":
                    return "OhmMeter";
                case "Energy":
                    return "Joule";
                case "EnergyDensity":
                    return "JoulePerCubicMeter";
                case "ExposureRate":
                    return "CoulombPerKilogramSecond";
                case "Force":
                    return "Newton";
                case "ForcePerLength":
                    return "NewtonPerMeter";
                case "FrameRate":
                    return "FramePerSecond";
                case "Frequency":
                    return "Hertz";
                case "FuelEconomy":
                    return "KilometerPerLiter";
                case "HeatTransferCoefficient":
                    return "WattPerSquareMeterKelvin";
                case "HydraulicPermeability":
                    return "SquareMeter";
                case "Illuminance":
                    return "Lux";
                case "Impulse":
                    return "NewtonSecond";
                case "Inductance":
                    return "Henry";
                case "Irradiance":
                    return "WattPerSquareMeter";
                case "Jerk":
                    return "MeterPerSecondCubed";
                case "KinematicViscosity":
                    return "SquareMeterPerSecond";
                case "Length":
                    return "Meter";
                case "LinearDensity":
                    return "KilogramPerMeter";
                case "Luminance":
                    return "CandelaPerSquareMeter";
                case "LuminousEfficacy":
                    return "LumenPerWatt";
                case "LuminousEnergy":
                    return "LumenSecond";
                case "LuminousExposure":
                    return "LuxSecond";
                case "LuminousFlux":
                    return "Lumen";
                case "LuminousIntensity":
                    return "Candela";
                case "MagneticField":
                    return "Tesla";
                case "MagneticFlux":
                    return "Weber";
                case "MagneticPermeability":
                    return "HenryPerMeter";
                case "MagnetizingFieldStrength":
                    return "AmperePerMeter";
                case "Mass":
                    return "Kilogram";
                case "MassConcentration":
                    return "KilogramPerCubicMeter";
                case "MassFlowRate":
                    return "KilogramPerSecond";
                case "MassFlux":
                    return "KilogramPerSquareMeterSecond";
                case "MolarConcentration":
                    return "MolePerCubicMeter";
                case "MolarMass":
                    return "KilogramPerMole";
                case "MomentOfInertia":
                    return "KilogramSquareMeter";
                case "Momentum":
                    return "KilogramMeterPerSecond";
                case "ParticleFluence":
                    return "ParticlePerSquareMeter";
                case "ParticleFlux":
                    return "ParticlePerSquareMeterSecond";
                case "Permittivity":
                    return "FaradPerMeter";
                case "PixelDensity":
                    return "PixelPerMeter";
                case "Power":
                    return "Watt";
                case "PowerDensity":
                    return "WattPerCubicMeter";
                case "Pressure":
                    return "Pascal";
                case "PressureGradient":
                    return "PascalPerMeter";
                case "Radiance":
                    return "WattPerSteradianSquareMeter";
                case "RadiationDose":
                    return "Gray";
                case "RadiationExposure":
                    return "CoulombPerKilogram";
                case "Radioactivity":
                    return "Becquerel";
                case "Snap":
                    return "MeterPerSecondFourth";
                case "SpecificGravity":
                    return "Ratio";
                case "SpecificHeatCapacity":
                    return "JoulePerKilogramKelvin";
                case "SpecificVolume":
                    return "CubicMeterPerKilogram";
                case "SpecificWeight":
                    return "NewtonPerCubicMeter";
                case "Speed":
                    return "MeterPerSecond";
                case "SurfaceTension":
                    return "NewtonPerMeter";
                case "Temperature":
                    return "Kelvin";
                case "ThermalConductivity":
                    return "WattPerMeterKelvin";
                case "ThermalDiffusivity":
                    return "SquareMeterPerSecond";
                case "ThermalExpansion":
                    return "PerKelvin";
                case "Time":
                    return "Second";
                case "Torque":
                    return "NewtonMeter";
                case "TorquePerAngle":
                    return "NewtonMeterPerRadian";
                case "VaporPressure":
                    return "Pascal";
                case "Voltage":
                    return "Volt";
                case "Volume":
                    return "Liter";
                case "VolumetricFlowRate":
                    return "CubicMeterPerSecond";
                case "VolumetricFlux":
                    return "MeterPerSecond";
                case "Yank":
                    return "NewtonPerSecond";
                default:
                    return string.Empty;
            }
        }

        public static bool TryGetBaseUnitName(string familyName, out string baseUnitName)
        {
            baseUnitName = GetBaseUnitName(familyName);
            return !string.IsNullOrEmpty(baseUnitName);
        }
    }
}
