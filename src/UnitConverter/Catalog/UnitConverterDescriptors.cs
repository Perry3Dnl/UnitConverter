namespace UnitConverter.Catalog
{
    using System;
    using System.Collections.Generic;

    public sealed class UnitConverterUnitDescriptor
    {
        internal UnitConverterUnitDescriptor(
            object unit,
            string name,
            string symbol,
            string displayName,
            string[] aliases)
        {
            Unit = unit;
            Name = name;
            Symbol = symbol;
            DisplayName = displayName;
            Aliases = aliases ?? new string[0];
        }

        public object Unit { get; }
        public string Name { get; }
        public string Symbol { get; }
        public string DisplayName { get; }
        public string[] Aliases { get; }
    }

    public abstract class UnitConverterFamilyDescriptor
    {
        protected UnitConverterFamilyDescriptor(
            UnitConverterFamily family,
            string name,
            string baseUnitName)
        {
            Family = family;
            Name = name;
            BaseUnitName = baseUnitName;
        }

        public UnitConverterFamily Family { get; }
        public string Name { get; }
        public string BaseUnitName { get; }
        public abstract Type UnitType { get; }
        public abstract IReadOnlyList<UnitConverterUnitDescriptor> Units { get; }

        internal abstract bool TryResolveUnitObject(string text, out object unit);
        internal abstract double ConvertObject(double value, object from, object to);
    }

    public sealed class UnitConverterFamilyDescriptor<TUnit> : UnitConverterFamilyDescriptor
        where TUnit : struct
    {
        private readonly Func<double, TUnit, TUnit, double> _convert;
        private readonly UnitConverterUnitDescriptor[] _units;
        private readonly Dictionary<string, TUnit> _exactAliases;
        private readonly Dictionary<string, TUnit> _ignoreCaseAliases;

        internal UnitConverterFamilyDescriptor(
            UnitConverterFamily family,
            string name,
            string baseUnitName,
            Func<TUnit, string> getSymbol,
            Func<TUnit, string> getDisplayName,
            Func<double, TUnit, TUnit, double> convert,
            Func<TUnit, string[]> getAliases)
            : base(family, name, baseUnitName)
        {
            if (!typeof(TUnit).IsEnum)
            {
                throw new InvalidOperationException(typeof(TUnit).FullName + " must be an enum.");
            }

            _convert = convert ?? throw new ArgumentNullException(nameof(convert));
            _exactAliases = new Dictionary<string, TUnit>(StringComparer.Ordinal);
            _ignoreCaseAliases = new Dictionary<string, TUnit>(StringComparer.OrdinalIgnoreCase);

            var ambiguousIgnoreCaseAliases = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var units = new List<UnitConverterUnitDescriptor>();

            foreach (object rawUnit in Enum.GetValues(typeof(TUnit)))
            {
                TUnit unit = (TUnit)rawUnit;
                string enumName = unit.ToString();
                string symbol = getSymbol == null ? null : getSymbol(unit);
                string displayName = getDisplayName == null ? null : getDisplayName(unit);
                string[] additionalAliases = getAliases == null ? null : getAliases(unit);

                string[] acceptedAliases = BuildAcceptedAliases(
                    enumName,
                    symbol,
                    displayName,
                    additionalAliases);

                units.Add(new UnitConverterUnitDescriptor(
                    unit,
                    enumName,
                    symbol,
                    displayName,
                    acceptedAliases));

                AddExact(_exactAliases, enumName, unit);
                AddExact(_exactAliases, symbol, unit);
                AddExact(_exactAliases, displayName, unit);

                AddIgnoreCase(_ignoreCaseAliases, ambiguousIgnoreCaseAliases, enumName, unit);
                AddIgnoreCase(_ignoreCaseAliases, ambiguousIgnoreCaseAliases, symbol, unit);
                AddIgnoreCase(_ignoreCaseAliases, ambiguousIgnoreCaseAliases, displayName, unit);

                if (additionalAliases != null)
                {
                    foreach (string alias in additionalAliases)
                    {
                        AddExact(_exactAliases, alias, unit);
                        AddIgnoreCase(_ignoreCaseAliases, ambiguousIgnoreCaseAliases, alias, unit);
                    }
                }
            }

            foreach (string ambiguousAlias in ambiguousIgnoreCaseAliases)
            {
                _ignoreCaseAliases.Remove(ambiguousAlias);
            }

            _units = units.ToArray();
        }

        public override Type UnitType => typeof(TUnit);
        public override IReadOnlyList<UnitConverterUnitDescriptor> Units => _units;

        public bool TryResolveUnit(string text, out TUnit unit)
        {
            unit = default(TUnit);

            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            string candidate = text.Trim();

            if (_exactAliases.TryGetValue(candidate, out unit))
            {
                return true;
            }

            return _ignoreCaseAliases.TryGetValue(candidate, out unit);
        }

        public double Convert(double value, TUnit from, TUnit to)
        {
            return _convert(value, from, to);
        }

        internal override bool TryResolveUnitObject(string text, out object unit)
        {
            TUnit typedUnit;
            bool success = TryResolveUnit(text, out typedUnit);
            unit = success ? (object)typedUnit : null;
            return success;
        }

        internal override double ConvertObject(double value, object from, object to)
        {
            return _convert(value, (TUnit)from, (TUnit)to);
        }

        private static string[] BuildAcceptedAliases(
            string enumName,
            string symbol,
            string displayName,
            string[] additionalAliases)
        {
            var aliases = new List<string>();
            AddAliasToList(aliases, enumName);
            AddAliasToList(aliases, symbol);
            AddAliasToList(aliases, displayName);

            if (additionalAliases != null)
            {
                foreach (string alias in additionalAliases)
                {
                    AddAliasToList(aliases, alias);
                }
            }

            return aliases.ToArray();
        }

        private static void AddAliasToList(List<string> aliases, string alias)
        {
            if (string.IsNullOrWhiteSpace(alias))
            {
                return;
            }

            string candidate = alias.Trim();
            if (!aliases.Contains(candidate))
            {
                aliases.Add(candidate);
            }
        }

        private static void AddExact(
            Dictionary<string, TUnit> aliases,
            string alias,
            TUnit unit)
        {
            if (string.IsNullOrWhiteSpace(alias))
            {
                return;
            }

            string candidate = alias.Trim();
            if (!aliases.ContainsKey(candidate))
            {
                aliases.Add(candidate, unit);
            }
        }

        private static void AddIgnoreCase(
            Dictionary<string, TUnit> aliases,
            HashSet<string> ambiguous,
            string alias,
            TUnit unit)
        {
            if (string.IsNullOrWhiteSpace(alias))
            {
                return;
            }

            string candidate = alias.Trim();
            TUnit existing;

            if (aliases.TryGetValue(candidate, out existing))
            {
                if (!EqualityComparer<TUnit>.Default.Equals(existing, unit))
                {
                    ambiguous.Add(candidate);
                }

                return;
            }

            aliases.Add(candidate, unit);
        }
    }

    public static partial class UnitConverterCatalog
    {
        private static readonly UnitConverterFamilyDescriptor[] FamilyDescriptors =
        {
                Create(UnitConverterFamily.Acceleration, "Acceleration", "MeterPerSecondSquared", UnitConverter.Acceleration.UnitConverterAcceleration.GetSymbol, UnitConverter.Acceleration.UnitConverterAcceleration.GetDisplayName, UnitConverter.Acceleration.UnitConverterAcceleration.Convert),
                Create(UnitConverterFamily.ActivityConcentration, "ActivityConcentration", "BecquerelPerCubicMeter", UnitConverter.ActivityConcentration.UnitConverterActivityConcentration.GetSymbol, UnitConverter.ActivityConcentration.UnitConverterActivityConcentration.GetDisplayName, UnitConverter.ActivityConcentration.UnitConverterActivityConcentration.Convert),
                Create(UnitConverterFamily.AmountOfSubstance, "AmountOfSubstance", "Mole", UnitConverter.AmountOfSubstance.UnitConverterAmountOfSubstance.GetSymbol, UnitConverter.AmountOfSubstance.UnitConverterAmountOfSubstance.GetDisplayName, UnitConverter.AmountOfSubstance.UnitConverterAmountOfSubstance.Convert),
                Create(UnitConverterFamily.Angle, "Angle", "Degree", UnitConverter.Angle.UnitConverterAngle.GetSymbol, UnitConverter.Angle.UnitConverterAngle.GetDisplayName, UnitConverter.Angle.UnitConverterAngle.Convert),
                Create(UnitConverterFamily.AngularAcceleration, "AngularAcceleration", "RadianPerSecondSquared", UnitConverter.AngularAcceleration.UnitConverterAngularAcceleration.GetSymbol, UnitConverter.AngularAcceleration.UnitConverterAngularAcceleration.GetDisplayName, UnitConverter.AngularAcceleration.UnitConverterAngularAcceleration.Convert),
                Create(UnitConverterFamily.AngularMomentum, "AngularMomentum", "KilogramSquareMeterPerSecond", UnitConverter.AngularMomentum.UnitConverterAngularMomentum.GetSymbol, UnitConverter.AngularMomentum.UnitConverterAngularMomentum.GetDisplayName, UnitConverter.AngularMomentum.UnitConverterAngularMomentum.Convert),
                Create(UnitConverterFamily.AngularVelocity, "AngularVelocity", "RadianPerSecond", UnitConverter.AngularVelocity.UnitConverterAngularVelocity.GetSymbol, UnitConverter.AngularVelocity.UnitConverterAngularVelocity.GetDisplayName, UnitConverter.AngularVelocity.UnitConverterAngularVelocity.Convert),
                Create(UnitConverterFamily.Area, "Area", "SquareMeter", UnitConverter.Area.UnitConverterArea.GetSymbol, UnitConverter.Area.UnitConverterArea.GetDisplayName, UnitConverter.Area.UnitConverterArea.Convert),
                Create(UnitConverterFamily.AreaDensity, "AreaDensity", "KilogramPerSquareMeter", UnitConverter.AreaDensity.UnitConverterAreaDensity.GetSymbol, UnitConverter.AreaDensity.UnitConverterAreaDensity.GetDisplayName, UnitConverter.AreaDensity.UnitConverterAreaDensity.Convert),
                Create(UnitConverterFamily.Capacitance, "Capacitance", "Farad", UnitConverter.Capacitance.UnitConverterCapacitance.GetSymbol, UnitConverter.Capacitance.UnitConverterCapacitance.GetDisplayName, UnitConverter.Capacitance.UnitConverterCapacitance.Convert),
                Create(UnitConverterFamily.ChargeDensity, "ChargeDensity", "CoulombPerCubicMeter", UnitConverter.ChargeDensity.UnitConverterChargeDensity.GetSymbol, UnitConverter.ChargeDensity.UnitConverterChargeDensity.GetDisplayName, UnitConverter.ChargeDensity.UnitConverterChargeDensity.Convert),
                Create(UnitConverterFamily.Compressibility, "Compressibility", "PerPascal", UnitConverter.Compressibility.UnitConverterCompressibility.GetSymbol, UnitConverter.Compressibility.UnitConverterCompressibility.GetDisplayName, UnitConverter.Compressibility.UnitConverterCompressibility.Convert),
                Create(UnitConverterFamily.Conductance, "Conductance", "Siemens", UnitConverter.Conductance.UnitConverterConductance.GetSymbol, UnitConverter.Conductance.UnitConverterConductance.GetDisplayName, UnitConverter.Conductance.UnitConverterConductance.Convert),
                Create(UnitConverterFamily.Current, "Current", "Ampere", UnitConverter.Current.UnitConverterCurrent.GetSymbol, UnitConverter.Current.UnitConverterCurrent.GetDisplayName, UnitConverter.Current.UnitConverterCurrent.Convert),
                Create(UnitConverterFamily.CurrentDensity, "CurrentDensity", "AmperePerSquareMeter", UnitConverter.CurrentDensity.UnitConverterCurrentDensity.GetSymbol, UnitConverter.CurrentDensity.UnitConverterCurrentDensity.GetDisplayName, UnitConverter.CurrentDensity.UnitConverterCurrentDensity.Convert),
                Create(UnitConverterFamily.DataRate, "DataRate", "BitPerSecond", UnitConverter.DataRate.UnitConverterDataRate.GetSymbol, UnitConverter.DataRate.UnitConverterDataRate.GetDisplayName, UnitConverter.DataRate.UnitConverterDataRate.Convert),
                Create(UnitConverterFamily.Density, "Density", "KilogramPerCubicMeter", UnitConverter.Density.UnitConverterDensity.GetSymbol, UnitConverter.Density.UnitConverterDensity.GetDisplayName, UnitConverter.Density.UnitConverterDensity.Convert),
                Create(UnitConverterFamily.DiffusionCoefficient, "DiffusionCoefficient", "SquareMeterPerSecond", UnitConverter.DiffusionCoefficient.UnitConverterDiffusionCoefficient.GetSymbol, UnitConverter.DiffusionCoefficient.UnitConverterDiffusionCoefficient.GetDisplayName, UnitConverter.DiffusionCoefficient.UnitConverterDiffusionCoefficient.Convert),
                Create(UnitConverterFamily.DigitalStorage, "DigitalStorage", "Byte", UnitConverter.DigitalStorage.UnitConverterDigitalStorage.GetSymbol, UnitConverter.DigitalStorage.UnitConverterDigitalStorage.GetDisplayName, UnitConverter.DigitalStorage.UnitConverterDigitalStorage.Convert),
                Create(UnitConverterFamily.DoseRate, "DoseRate", "GrayPerSecond", UnitConverter.DoseRate.UnitConverterDoseRate.GetSymbol, UnitConverter.DoseRate.UnitConverterDoseRate.GetDisplayName, UnitConverter.DoseRate.UnitConverterDoseRate.Convert),
                Create(UnitConverterFamily.DynamicPressure, "DynamicPressure", "Pascal", UnitConverter.DynamicPressure.UnitConverterDynamicPressure.GetSymbol, UnitConverter.DynamicPressure.UnitConverterDynamicPressure.GetDisplayName, UnitConverter.DynamicPressure.UnitConverterDynamicPressure.Convert),
                Create(UnitConverterFamily.DynamicViscosity, "DynamicViscosity", "PascalSecond", UnitConverter.DynamicViscosity.UnitConverterDynamicViscosity.GetSymbol, UnitConverter.DynamicViscosity.UnitConverterDynamicViscosity.GetDisplayName, UnitConverter.DynamicViscosity.UnitConverterDynamicViscosity.Convert),
                Create(UnitConverterFamily.ElectricCharge, "ElectricCharge", "Coulomb", UnitConverter.ElectricCharge.UnitConverterElectricCharge.GetSymbol, UnitConverter.ElectricCharge.UnitConverterElectricCharge.GetDisplayName, UnitConverter.ElectricCharge.UnitConverterElectricCharge.Convert),
                Create(UnitConverterFamily.ElectricFieldStrength, "ElectricFieldStrength", "VoltPerMeter", UnitConverter.ElectricFieldStrength.UnitConverterElectricFieldStrength.GetSymbol, UnitConverter.ElectricFieldStrength.UnitConverterElectricFieldStrength.GetDisplayName, UnitConverter.ElectricFieldStrength.UnitConverterElectricFieldStrength.Convert),
                Create(UnitConverterFamily.ElectricFlux, "ElectricFlux", "VoltMeter", UnitConverter.ElectricFlux.UnitConverterElectricFlux.GetSymbol, UnitConverter.ElectricFlux.UnitConverterElectricFlux.GetDisplayName, UnitConverter.ElectricFlux.UnitConverterElectricFlux.Convert),
                Create(UnitConverterFamily.ElectricFluxDensity, "ElectricFluxDensity", "CoulombPerSquareMeter", UnitConverter.ElectricFluxDensity.UnitConverterElectricFluxDensity.GetSymbol, UnitConverter.ElectricFluxDensity.UnitConverterElectricFluxDensity.GetDisplayName, UnitConverter.ElectricFluxDensity.UnitConverterElectricFluxDensity.Convert),
                Create(UnitConverterFamily.ElectricResistance, "ElectricResistance", "Ohm", UnitConverter.ElectricResistance.UnitConverterElectricResistance.GetSymbol, UnitConverter.ElectricResistance.UnitConverterElectricResistance.GetDisplayName, UnitConverter.ElectricResistance.UnitConverterElectricResistance.Convert),
                Create(UnitConverterFamily.ElectricalConductivity, "ElectricalConductivity", "SiemensPerMeter", UnitConverter.ElectricalConductivity.UnitConverterElectricalConductivity.GetSymbol, UnitConverter.ElectricalConductivity.UnitConverterElectricalConductivity.GetDisplayName, UnitConverter.ElectricalConductivity.UnitConverterElectricalConductivity.Convert),
                Create(UnitConverterFamily.ElectricalResistivity, "ElectricalResistivity", "OhmMeter", UnitConverter.ElectricalResistivity.UnitConverterElectricalResistivity.GetSymbol, UnitConverter.ElectricalResistivity.UnitConverterElectricalResistivity.GetDisplayName, UnitConverter.ElectricalResistivity.UnitConverterElectricalResistivity.Convert),
                Create(UnitConverterFamily.Energy, "Energy", "Joule", UnitConverter.Energy.UnitConverterEnergy.GetSymbol, UnitConverter.Energy.UnitConverterEnergy.GetDisplayName, UnitConverter.Energy.UnitConverterEnergy.Convert),
                Create(UnitConverterFamily.EnergyDensity, "EnergyDensity", "JoulePerCubicMeter", UnitConverter.EnergyDensity.UnitConverterEnergyDensity.GetSymbol, UnitConverter.EnergyDensity.UnitConverterEnergyDensity.GetDisplayName, UnitConverter.EnergyDensity.UnitConverterEnergyDensity.Convert),
                Create(UnitConverterFamily.ExposureRate, "ExposureRate", "CoulombPerKilogramSecond", UnitConverter.ExposureRate.UnitConverterExposureRate.GetSymbol, UnitConverter.ExposureRate.UnitConverterExposureRate.GetDisplayName, UnitConverter.ExposureRate.UnitConverterExposureRate.Convert),
                Create(UnitConverterFamily.Force, "Force", "Newton", UnitConverter.Force.UnitConverterForce.GetSymbol, UnitConverter.Force.UnitConverterForce.GetDisplayName, UnitConverter.Force.UnitConverterForce.Convert),
                Create(UnitConverterFamily.ForcePerLength, "ForcePerLength", "NewtonPerMeter", UnitConverter.ForcePerLength.UnitConverterForcePerLength.GetSymbol, UnitConverter.ForcePerLength.UnitConverterForcePerLength.GetDisplayName, UnitConverter.ForcePerLength.UnitConverterForcePerLength.Convert),
                Create(UnitConverterFamily.FrameRate, "FrameRate", "FramePerSecond", UnitConverter.FrameRate.UnitConverterFrameRate.GetSymbol, UnitConverter.FrameRate.UnitConverterFrameRate.GetDisplayName, UnitConverter.FrameRate.UnitConverterFrameRate.Convert),
                Create(UnitConverterFamily.Frequency, "Frequency", "Hertz", UnitConverter.Frequency.UnitConverterFrequency.GetSymbol, UnitConverter.Frequency.UnitConverterFrequency.GetDisplayName, UnitConverter.Frequency.UnitConverterFrequency.Convert),
                Create(UnitConverterFamily.FuelEconomy, "FuelEconomy", "KilometerPerLiter", UnitConverter.FuelEconomy.UnitConverterFuelEconomy.GetSymbol, UnitConverter.FuelEconomy.UnitConverterFuelEconomy.GetDisplayName, UnitConverter.FuelEconomy.UnitConverterFuelEconomy.Convert),
                Create(UnitConverterFamily.HeatTransferCoefficient, "HeatTransferCoefficient", "WattPerSquareMeterKelvin", UnitConverter.HeatTransferCoefficient.UnitConverterHeatTransferCoefficient.GetSymbol, UnitConverter.HeatTransferCoefficient.UnitConverterHeatTransferCoefficient.GetDisplayName, UnitConverter.HeatTransferCoefficient.UnitConverterHeatTransferCoefficient.Convert),
                Create(UnitConverterFamily.HydraulicPermeability, "HydraulicPermeability", "SquareMeter", UnitConverter.HydraulicPermeability.UnitConverterHydraulicPermeability.GetSymbol, UnitConverter.HydraulicPermeability.UnitConverterHydraulicPermeability.GetDisplayName, UnitConverter.HydraulicPermeability.UnitConverterHydraulicPermeability.Convert),
                Create(UnitConverterFamily.Illuminance, "Illuminance", "Lux", UnitConverter.Illuminance.UnitConverterIlluminance.GetSymbol, UnitConverter.Illuminance.UnitConverterIlluminance.GetDisplayName, UnitConverter.Illuminance.UnitConverterIlluminance.Convert),
                Create(UnitConverterFamily.Impulse, "Impulse", "NewtonSecond", UnitConverter.Impulse.UnitConverterImpulse.GetSymbol, UnitConverter.Impulse.UnitConverterImpulse.GetDisplayName, UnitConverter.Impulse.UnitConverterImpulse.Convert),
                Create(UnitConverterFamily.Inductance, "Inductance", "Henry", UnitConverter.Inductance.UnitConverterInductance.GetSymbol, UnitConverter.Inductance.UnitConverterInductance.GetDisplayName, UnitConverter.Inductance.UnitConverterInductance.Convert),
                Create(UnitConverterFamily.Irradiance, "Irradiance", "WattPerSquareMeter", UnitConverter.Irradiance.UnitConverterIrradiance.GetSymbol, UnitConverter.Irradiance.UnitConverterIrradiance.GetDisplayName, UnitConverter.Irradiance.UnitConverterIrradiance.Convert),
                Create(UnitConverterFamily.Jerk, "Jerk", "MeterPerSecondCubed", UnitConverter.Jerk.UnitConverterJerk.GetSymbol, UnitConverter.Jerk.UnitConverterJerk.GetDisplayName, UnitConverter.Jerk.UnitConverterJerk.Convert),
                Create(UnitConverterFamily.KinematicViscosity, "KinematicViscosity", "SquareMeterPerSecond", UnitConverter.KinematicViscosity.UnitConverterKinematicViscosity.GetSymbol, UnitConverter.KinematicViscosity.UnitConverterKinematicViscosity.GetDisplayName, UnitConverter.KinematicViscosity.UnitConverterKinematicViscosity.Convert),
                Create(UnitConverterFamily.Length, "Length", "Meter", UnitConverter.Length.UnitConverterLength.GetSymbol, UnitConverter.Length.UnitConverterLength.GetDisplayName, UnitConverter.Length.UnitConverterLength.Convert, UnitConverterAliases.GetLengthAliases),
                Create(UnitConverterFamily.LinearDensity, "LinearDensity", "KilogramPerMeter", UnitConverter.LinearDensity.UnitConverterLinearDensity.GetSymbol, UnitConverter.LinearDensity.UnitConverterLinearDensity.GetDisplayName, UnitConverter.LinearDensity.UnitConverterLinearDensity.Convert),
                Create(UnitConverterFamily.Luminance, "Luminance", "CandelaPerSquareMeter", UnitConverter.Luminance.UnitConverterLuminance.GetSymbol, UnitConverter.Luminance.UnitConverterLuminance.GetDisplayName, UnitConverter.Luminance.UnitConverterLuminance.Convert),
                Create(UnitConverterFamily.LuminousEfficacy, "LuminousEfficacy", "LumenPerWatt", UnitConverter.LuminousEfficacy.UnitConverterLuminousEfficacy.GetSymbol, UnitConverter.LuminousEfficacy.UnitConverterLuminousEfficacy.GetDisplayName, UnitConverter.LuminousEfficacy.UnitConverterLuminousEfficacy.Convert),
                Create(UnitConverterFamily.LuminousEnergy, "LuminousEnergy", "LumenSecond", UnitConverter.LuminousEnergy.UnitConverterLuminousEnergy.GetSymbol, UnitConverter.LuminousEnergy.UnitConverterLuminousEnergy.GetDisplayName, UnitConverter.LuminousEnergy.UnitConverterLuminousEnergy.Convert),
                Create(UnitConverterFamily.LuminousExposure, "LuminousExposure", "LuxSecond", UnitConverter.LuminousExposure.UnitConverterLuminousExposure.GetSymbol, UnitConverter.LuminousExposure.UnitConverterLuminousExposure.GetDisplayName, UnitConverter.LuminousExposure.UnitConverterLuminousExposure.Convert),
                Create(UnitConverterFamily.LuminousFlux, "LuminousFlux", "Lumen", UnitConverter.LuminousFlux.UnitConverterLuminousFlux.GetSymbol, UnitConverter.LuminousFlux.UnitConverterLuminousFlux.GetDisplayName, UnitConverter.LuminousFlux.UnitConverterLuminousFlux.Convert),
                Create(UnitConverterFamily.LuminousIntensity, "LuminousIntensity", "Candela", UnitConverter.LuminousIntensity.UnitConverterLuminousIntensity.GetSymbol, UnitConverter.LuminousIntensity.UnitConverterLuminousIntensity.GetDisplayName, UnitConverter.LuminousIntensity.UnitConverterLuminousIntensity.Convert),
                Create(UnitConverterFamily.MagneticField, "MagneticField", "Tesla", UnitConverter.MagneticField.UnitConverterMagneticField.GetSymbol, UnitConverter.MagneticField.UnitConverterMagneticField.GetDisplayName, UnitConverter.MagneticField.UnitConverterMagneticField.Convert),
                Create(UnitConverterFamily.MagneticFlux, "MagneticFlux", "Weber", UnitConverter.MagneticFlux.UnitConverterMagneticFlux.GetSymbol, UnitConverter.MagneticFlux.UnitConverterMagneticFlux.GetDisplayName, UnitConverter.MagneticFlux.UnitConverterMagneticFlux.Convert),
                Create(UnitConverterFamily.MagneticPermeability, "MagneticPermeability", "HenryPerMeter", UnitConverter.MagneticPermeability.UnitConverterMagneticPermeability.GetSymbol, UnitConverter.MagneticPermeability.UnitConverterMagneticPermeability.GetDisplayName, UnitConverter.MagneticPermeability.UnitConverterMagneticPermeability.Convert),
                Create(UnitConverterFamily.MagnetizingFieldStrength, "MagnetizingFieldStrength", "AmperePerMeter", UnitConverter.MagnetizingFieldStrength.UnitConverterMagnetizingFieldStrength.GetSymbol, UnitConverter.MagnetizingFieldStrength.UnitConverterMagnetizingFieldStrength.GetDisplayName, UnitConverter.MagnetizingFieldStrength.UnitConverterMagnetizingFieldStrength.Convert),
                Create(UnitConverterFamily.Mass, "Mass", "Kilogram", UnitConverter.Mass.UnitConverterMass.GetSymbol, UnitConverter.Mass.UnitConverterMass.GetDisplayName, UnitConverter.Mass.UnitConverterMass.Convert),
                Create(UnitConverterFamily.MassConcentration, "MassConcentration", "KilogramPerCubicMeter", UnitConverter.MassConcentration.UnitConverterMassConcentration.GetSymbol, UnitConverter.MassConcentration.UnitConverterMassConcentration.GetDisplayName, UnitConverter.MassConcentration.UnitConverterMassConcentration.Convert),
                Create(UnitConverterFamily.MassFlowRate, "MassFlowRate", "KilogramPerSecond", UnitConverter.MassFlowRate.UnitConverterMassFlowRate.GetSymbol, UnitConverter.MassFlowRate.UnitConverterMassFlowRate.GetDisplayName, UnitConverter.MassFlowRate.UnitConverterMassFlowRate.Convert),
                Create(UnitConverterFamily.MassFlux, "MassFlux", "KilogramPerSquareMeterSecond", UnitConverter.MassFlux.UnitConverterMassFlux.GetSymbol, UnitConverter.MassFlux.UnitConverterMassFlux.GetDisplayName, UnitConverter.MassFlux.UnitConverterMassFlux.Convert),
                Create(UnitConverterFamily.MolarConcentration, "MolarConcentration", "MolePerCubicMeter", UnitConverter.MolarConcentration.UnitConverterMolarConcentration.GetSymbol, UnitConverter.MolarConcentration.UnitConverterMolarConcentration.GetDisplayName, UnitConverter.MolarConcentration.UnitConverterMolarConcentration.Convert),
                Create(UnitConverterFamily.MolarMass, "MolarMass", "KilogramPerMole", UnitConverter.MolarMass.UnitConverterMolarMass.GetSymbol, UnitConverter.MolarMass.UnitConverterMolarMass.GetDisplayName, UnitConverter.MolarMass.UnitConverterMolarMass.Convert),
                Create(UnitConverterFamily.MomentOfInertia, "MomentOfInertia", "KilogramSquareMeter", UnitConverter.MomentOfInertia.UnitConverterMomentOfInertia.GetSymbol, UnitConverter.MomentOfInertia.UnitConverterMomentOfInertia.GetDisplayName, UnitConverter.MomentOfInertia.UnitConverterMomentOfInertia.Convert),
                Create(UnitConverterFamily.Momentum, "Momentum", "KilogramMeterPerSecond", UnitConverter.Momentum.UnitConverterMomentum.GetSymbol, UnitConverter.Momentum.UnitConverterMomentum.GetDisplayName, UnitConverter.Momentum.UnitConverterMomentum.Convert),
                Create(UnitConverterFamily.ParticleFluence, "ParticleFluence", "ParticlePerSquareMeter", UnitConverter.ParticleFluence.UnitConverterParticleFluence.GetSymbol, UnitConverter.ParticleFluence.UnitConverterParticleFluence.GetDisplayName, UnitConverter.ParticleFluence.UnitConverterParticleFluence.Convert),
                Create(UnitConverterFamily.ParticleFlux, "ParticleFlux", "ParticlePerSquareMeterSecond", UnitConverter.ParticleFlux.UnitConverterParticleFlux.GetSymbol, UnitConverter.ParticleFlux.UnitConverterParticleFlux.GetDisplayName, UnitConverter.ParticleFlux.UnitConverterParticleFlux.Convert),
                Create(UnitConverterFamily.Permittivity, "Permittivity", "FaradPerMeter", UnitConverter.Permittivity.UnitConverterPermittivity.GetSymbol, UnitConverter.Permittivity.UnitConverterPermittivity.GetDisplayName, UnitConverter.Permittivity.UnitConverterPermittivity.Convert),
                Create(UnitConverterFamily.PixelDensity, "PixelDensity", "PixelPerMeter", UnitConverter.PixelDensity.UnitConverterPixelDensity.GetSymbol, UnitConverter.PixelDensity.UnitConverterPixelDensity.GetDisplayName, UnitConverter.PixelDensity.UnitConverterPixelDensity.Convert),
                Create(UnitConverterFamily.Power, "Power", "Watt", UnitConverter.Power.UnitConverterPower.GetSymbol, UnitConverter.Power.UnitConverterPower.GetDisplayName, UnitConverter.Power.UnitConverterPower.Convert),
                Create(UnitConverterFamily.PowerDensity, "PowerDensity", "WattPerCubicMeter", UnitConverter.PowerDensity.UnitConverterPowerDensity.GetSymbol, UnitConverter.PowerDensity.UnitConverterPowerDensity.GetDisplayName, UnitConverter.PowerDensity.UnitConverterPowerDensity.Convert),
                Create(UnitConverterFamily.Pressure, "Pressure", "Pascal", UnitConverter.Pressure.UnitConverterPressure.GetSymbol, UnitConverter.Pressure.UnitConverterPressure.GetDisplayName, UnitConverter.Pressure.UnitConverterPressure.Convert),
                Create(UnitConverterFamily.PressureGradient, "PressureGradient", "PascalPerMeter", UnitConverter.PressureGradient.UnitConverterPressureGradient.GetSymbol, UnitConverter.PressureGradient.UnitConverterPressureGradient.GetDisplayName, UnitConverter.PressureGradient.UnitConverterPressureGradient.Convert),
                Create(UnitConverterFamily.Radiance, "Radiance", "WattPerSteradianSquareMeter", UnitConverter.Radiance.UnitConverterRadiance.GetSymbol, UnitConverter.Radiance.UnitConverterRadiance.GetDisplayName, UnitConverter.Radiance.UnitConverterRadiance.Convert),
                Create(UnitConverterFamily.RadiationDose, "RadiationDose", "Gray", UnitConverter.RadiationDose.UnitConverterRadiationDose.GetSymbol, UnitConverter.RadiationDose.UnitConverterRadiationDose.GetDisplayName, UnitConverter.RadiationDose.UnitConverterRadiationDose.Convert),
                Create(UnitConverterFamily.RadiationExposure, "RadiationExposure", "CoulombPerKilogram", UnitConverter.RadiationExposure.UnitConverterRadiationExposure.GetSymbol, UnitConverter.RadiationExposure.UnitConverterRadiationExposure.GetDisplayName, UnitConverter.RadiationExposure.UnitConverterRadiationExposure.Convert),
                Create(UnitConverterFamily.Radioactivity, "Radioactivity", "Becquerel", UnitConverter.Radioactivity.UnitConverterRadioactivity.GetSymbol, UnitConverter.Radioactivity.UnitConverterRadioactivity.GetDisplayName, UnitConverter.Radioactivity.UnitConverterRadioactivity.Convert),
                Create(UnitConverterFamily.Snap, "Snap", "MeterPerSecondFourth", UnitConverter.Snap.UnitConverterSnap.GetSymbol, UnitConverter.Snap.UnitConverterSnap.GetDisplayName, UnitConverter.Snap.UnitConverterSnap.Convert),
                Create(UnitConverterFamily.SpecificGravity, "SpecificGravity", "Ratio", UnitConverter.SpecificGravity.UnitConverterSpecificGravity.GetSymbol, UnitConverter.SpecificGravity.UnitConverterSpecificGravity.GetDisplayName, UnitConverter.SpecificGravity.UnitConverterSpecificGravity.Convert),
                Create(UnitConverterFamily.SpecificHeatCapacity, "SpecificHeatCapacity", "JoulePerKilogramKelvin", UnitConverter.SpecificHeatCapacity.UnitConverterSpecificHeatCapacity.GetSymbol, UnitConverter.SpecificHeatCapacity.UnitConverterSpecificHeatCapacity.GetDisplayName, UnitConverter.SpecificHeatCapacity.UnitConverterSpecificHeatCapacity.Convert),
                Create(UnitConverterFamily.SpecificVolume, "SpecificVolume", "CubicMeterPerKilogram", UnitConverter.SpecificVolume.UnitConverterSpecificVolume.GetSymbol, UnitConverter.SpecificVolume.UnitConverterSpecificVolume.GetDisplayName, UnitConverter.SpecificVolume.UnitConverterSpecificVolume.Convert),
                Create(UnitConverterFamily.SpecificWeight, "SpecificWeight", "NewtonPerCubicMeter", UnitConverter.SpecificWeight.UnitConverterSpecificWeight.GetSymbol, UnitConverter.SpecificWeight.UnitConverterSpecificWeight.GetDisplayName, UnitConverter.SpecificWeight.UnitConverterSpecificWeight.Convert),
                Create(UnitConverterFamily.Speed, "Speed", "MeterPerSecond", UnitConverter.Speed.UnitConverterSpeed.GetSymbol, UnitConverter.Speed.UnitConverterSpeed.GetDisplayName, UnitConverter.Speed.UnitConverterSpeed.Convert),
                Create(UnitConverterFamily.SurfaceTension, "SurfaceTension", "NewtonPerMeter", UnitConverter.SurfaceTension.UnitConverterSurfaceTension.GetSymbol, UnitConverter.SurfaceTension.UnitConverterSurfaceTension.GetDisplayName, UnitConverter.SurfaceTension.UnitConverterSurfaceTension.Convert),
                Create(UnitConverterFamily.Temperature, "Temperature", "Kelvin", UnitConverter.Temperature.UnitConverterTemperature.GetSymbol, UnitConverter.Temperature.UnitConverterTemperature.GetDisplayName, UnitConverter.Temperature.UnitConverterTemperature.Convert, UnitConverterAliases.GetTemperatureAliases),
                Create(UnitConverterFamily.ThermalConductivity, "ThermalConductivity", "WattPerMeterKelvin", UnitConverter.ThermalConductivity.UnitConverterThermalConductivity.GetSymbol, UnitConverter.ThermalConductivity.UnitConverterThermalConductivity.GetDisplayName, UnitConverter.ThermalConductivity.UnitConverterThermalConductivity.Convert),
                Create(UnitConverterFamily.ThermalDiffusivity, "ThermalDiffusivity", "SquareMeterPerSecond", UnitConverter.ThermalDiffusivity.UnitConverterThermalDiffusivity.GetSymbol, UnitConverter.ThermalDiffusivity.UnitConverterThermalDiffusivity.GetDisplayName, UnitConverter.ThermalDiffusivity.UnitConverterThermalDiffusivity.Convert),
                Create(UnitConverterFamily.ThermalExpansion, "ThermalExpansion", "PerKelvin", UnitConverter.ThermalExpansion.UnitConverterThermalExpansion.GetSymbol, UnitConverter.ThermalExpansion.UnitConverterThermalExpansion.GetDisplayName, UnitConverter.ThermalExpansion.UnitConverterThermalExpansion.Convert),
                Create(UnitConverterFamily.Time, "Time", "Second", UnitConverter.Time.UnitConverterTime.GetSymbol, UnitConverter.Time.UnitConverterTime.GetDisplayName, UnitConverter.Time.UnitConverterTime.Convert),
                Create(UnitConverterFamily.Torque, "Torque", "NewtonMeter", UnitConverter.Torque.UnitConverterTorque.GetSymbol, UnitConverter.Torque.UnitConverterTorque.GetDisplayName, UnitConverter.Torque.UnitConverterTorque.Convert),
                Create(UnitConverterFamily.TorquePerAngle, "TorquePerAngle", "NewtonMeterPerRadian", UnitConverter.TorquePerAngle.UnitConverterTorquePerAngle.GetSymbol, UnitConverter.TorquePerAngle.UnitConverterTorquePerAngle.GetDisplayName, UnitConverter.TorquePerAngle.UnitConverterTorquePerAngle.Convert),
                Create(UnitConverterFamily.VaporPressure, "VaporPressure", "Pascal", UnitConverter.VaporPressure.UnitConverterVaporPressure.GetSymbol, UnitConverter.VaporPressure.UnitConverterVaporPressure.GetDisplayName, UnitConverter.VaporPressure.UnitConverterVaporPressure.Convert),
                Create(UnitConverterFamily.Voltage, "Voltage", "Volt", UnitConverter.Voltage.UnitConverterVoltage.GetSymbol, UnitConverter.Voltage.UnitConverterVoltage.GetDisplayName, UnitConverter.Voltage.UnitConverterVoltage.Convert),
                Create(UnitConverterFamily.Volume, "Volume", "Liter", UnitConverter.Volume.UnitConverterVolume.GetSymbol, UnitConverter.Volume.UnitConverterVolume.GetDisplayName, UnitConverter.Volume.UnitConverterVolume.Convert),
                Create(UnitConverterFamily.VolumetricFlowRate, "VolumetricFlowRate", "CubicMeterPerSecond", UnitConverter.VolumetricFlowRate.UnitConverterVolumetricFlowRate.GetSymbol, UnitConverter.VolumetricFlowRate.UnitConverterVolumetricFlowRate.GetDisplayName, UnitConverter.VolumetricFlowRate.UnitConverterVolumetricFlowRate.Convert),
                Create(UnitConverterFamily.VolumetricFlux, "VolumetricFlux", "MeterPerSecond", UnitConverter.VolumetricFlux.UnitConverterVolumetricFlux.GetSymbol, UnitConverter.VolumetricFlux.UnitConverterVolumetricFlux.GetDisplayName, UnitConverter.VolumetricFlux.UnitConverterVolumetricFlux.Convert),
                Create(UnitConverterFamily.Yank, "Yank", "NewtonPerSecond", UnitConverter.Yank.UnitConverterYank.GetSymbol, UnitConverter.Yank.UnitConverterYank.GetDisplayName, UnitConverter.Yank.UnitConverterYank.Convert),
        };

        private static readonly Dictionary<UnitConverterFamily, UnitConverterFamilyDescriptor> FamiliesById =
            BuildFamiliesById();

        private static readonly Dictionary<string, UnitConverterFamilyDescriptor> FamiliesByName =
            BuildFamiliesByName();

        private static readonly Dictionary<Type, UnitConverterFamilyDescriptor> FamiliesByUnitType =
            BuildFamiliesByUnitType();

        public static UnitConverterFamilyDescriptor[] GetFamilies()
        {
            return (UnitConverterFamilyDescriptor[])FamilyDescriptors.Clone();
        }

        public static UnitConverterFamilyDescriptor GetFamily(UnitConverterFamily family)
        {
            UnitConverterFamilyDescriptor descriptor;
            if (!FamiliesById.TryGetValue(family, out descriptor))
            {
                throw new ArgumentOutOfRangeException(nameof(family), family, "Unsupported unit family.");
            }

            return descriptor;
        }

        public static bool TryGetFamily(
            UnitConverterFamily family,
            out UnitConverterFamilyDescriptor descriptor)
        {
            return FamiliesById.TryGetValue(family, out descriptor);
        }

        public static bool TryGetFamily(
            string familyName,
            out UnitConverterFamilyDescriptor descriptor)
        {
            descriptor = null;

            if (string.IsNullOrWhiteSpace(familyName))
            {
                return false;
            }

            return FamiliesByName.TryGetValue(familyName.Trim(), out descriptor);
        }

        public static bool TryGetFamily<TUnit>(
            out UnitConverterFamilyDescriptor<TUnit> descriptor)
            where TUnit : struct
        {
            UnitConverterFamilyDescriptor rawDescriptor;
            if (FamiliesByUnitType.TryGetValue(typeof(TUnit), out rawDescriptor))
            {
                descriptor = rawDescriptor as UnitConverterFamilyDescriptor<TUnit>;
                return descriptor != null;
            }

            descriptor = null;
            return false;
        }

        private static UnitConverterFamilyDescriptor Create<TUnit>(
            UnitConverterFamily family,
            string name,
            string baseUnitName,
            Func<TUnit, string> getSymbol,
            Func<TUnit, string> getDisplayName,
            Func<double, TUnit, TUnit, double> convert,
            Func<TUnit, string[]> getAliases = null)
            where TUnit : struct
        {
            return new UnitConverterFamilyDescriptor<TUnit>(
                family,
                name,
                baseUnitName,
                getSymbol,
                getDisplayName,
                convert,
                getAliases);
        }

        private static Dictionary<UnitConverterFamily, UnitConverterFamilyDescriptor> BuildFamiliesById()
        {
            var result = new Dictionary<UnitConverterFamily, UnitConverterFamilyDescriptor>();

            foreach (UnitConverterFamilyDescriptor descriptor in FamilyDescriptors)
            {
                result.Add(descriptor.Family, descriptor);
            }

            return result;
        }

        private static Dictionary<string, UnitConverterFamilyDescriptor> BuildFamiliesByName()
        {
            var result = new Dictionary<string, UnitConverterFamilyDescriptor>(StringComparer.OrdinalIgnoreCase);

            foreach (UnitConverterFamilyDescriptor descriptor in FamilyDescriptors)
            {
                result.Add(descriptor.Name, descriptor);
            }

            return result;
        }

        private static Dictionary<Type, UnitConverterFamilyDescriptor> BuildFamiliesByUnitType()
        {
            var result = new Dictionary<Type, UnitConverterFamilyDescriptor>();

            foreach (UnitConverterFamilyDescriptor descriptor in FamilyDescriptors)
            {
                result.Add(descriptor.UnitType, descriptor);
            }

            return result;
        }
    }
}
