namespace UnitTools.Catalog
{
    using System;
    using System.Collections.Generic;

    public enum UnitToolsUnitResolution
    {
        Unknown = 0,
        Resolved = 1,
        Ambiguous = 2,
    }

    public sealed class UnitToolsUnitDescriptor
    {
        private readonly string[] _aliases;

        internal UnitToolsUnitDescriptor(
            object unit,
            string name,
            string symbol,
            string displayName,
            string[] aliases,
            UnitToolsDimensions dimensions,
            UnitToolsProvenance provenance)
        {
            Unit = unit;
            Name = name;
            Symbol = symbol;
            DisplayName = displayName;
            _aliases = aliases == null
                ? new string[0]
                : (string[])aliases.Clone();
            Dimensions = dimensions;
            Provenance = provenance ?? throw new ArgumentNullException(nameof(provenance));
        }

        public object Unit { get; }
        public string Name { get; }
        public string Symbol { get; }
        public string DisplayName { get; }
        public string[] Aliases => (string[])_aliases.Clone();
        internal string[] AliasStorage => _aliases;
        public UnitToolsDimensions Dimensions { get; }
        public UnitToolsProvenance Provenance { get; }
    }

    public abstract class UnitToolsFamilyDescriptor
    {
        protected UnitToolsFamilyDescriptor(
            UnitToolsFamily family,
            string name,
            string baseUnitName)
        {
            Family = family;
            Name = name;
            BaseUnitName = baseUnitName;
        }

        public UnitToolsFamily Family { get; }
        public string Name { get; }
        public string BaseUnitName { get; }
        public abstract UnitToolsDimensions Dimensions { get; }
        public abstract bool HasUniformDimensions { get; }
        public abstract Type UnitType { get; }
        public abstract IReadOnlyList<UnitToolsUnitDescriptor> Units { get; }

        public UnitToolsUnitDescriptor GetUnit(object unit)
        {
            UnitToolsUnitDescriptor descriptor;
            if (!TryGetUnit(unit, out descriptor))
            {
                throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported unit.");
            }

            return descriptor;
        }

        public virtual bool TryGetUnit(
            object unit,
            out UnitToolsUnitDescriptor descriptor)
        {
            foreach (UnitToolsUnitDescriptor candidate in Units)
            {
                if (object.Equals(candidate.Unit, unit))
                {
                    descriptor = candidate;
                    return true;
                }
            }

            descriptor = null;
            return false;
        }

        public abstract UnitToolsUnitResolution ResolveUnit(string text, out object unit);
        public abstract double Convert(double value, object from, object to);
    }

    public sealed class UnitToolsFamilyDescriptor<TUnit> : UnitToolsFamilyDescriptor
        where TUnit : struct
    {
        private readonly Func<double, TUnit, TUnit, double> _convert;
        private readonly Func<TUnit, global::UnitTools.UnitToolsRational> _getExactScale;
        private readonly UnitToolsUnitDescriptor[] _units;
        private readonly IReadOnlyList<UnitToolsUnitDescriptor> _readOnlyUnits;
        private readonly Dictionary<TUnit, UnitToolsUnitDescriptor> _unitsByValue;
        private readonly Dictionary<string, TUnit> _exactAliases;
        private readonly Dictionary<string, TUnit> _ignoreCaseAliases;
        private readonly HashSet<string> _ambiguousExactAliases;
        private readonly HashSet<string> _ambiguousIgnoreCaseAliases;
        private readonly UnitToolsDimensions _dimensions;
        private readonly bool _hasUniformDimensions;

        internal UnitToolsFamilyDescriptor(
            UnitToolsFamily family,
            string name,
            string baseUnitName,
            Func<TUnit, string> getSymbol,
            Func<TUnit, string> getDisplayName,
            Func<double, TUnit, TUnit, double> convert,
            Func<TUnit, string[]> getAliases,
            Func<TUnit, UnitToolsDimensions> getDimensions,
            Func<TUnit, global::UnitTools.UnitToolsRational> getExactScale)
            : base(family, name, baseUnitName)
        {
            if (!typeof(TUnit).IsEnum)
            {
                throw new InvalidOperationException(typeof(TUnit).FullName + " must be an enum.");
            }

            _convert = convert ?? throw new ArgumentNullException(nameof(convert));
            _getExactScale = getExactScale;
            _unitsByValue = new Dictionary<TUnit, UnitToolsUnitDescriptor>();
            _exactAliases = new Dictionary<string, TUnit>(StringComparer.Ordinal);
            _ignoreCaseAliases = new Dictionary<string, TUnit>(StringComparer.OrdinalIgnoreCase);
            _ambiguousExactAliases = new HashSet<string>(StringComparer.Ordinal);
            _ambiguousIgnoreCaseAliases = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var units = new List<UnitToolsUnitDescriptor>();
            UnitToolsDimensions? firstDimensions = null;
            bool uniformDimensions = true;

            foreach (TUnit unit in UnitToolsUnitValues.GetValues<TUnit>())
            {
                string enumName = unit.ToString();
                string symbol = getSymbol == null ? null : getSymbol(unit);
                string displayName = getDisplayName == null ? null : getDisplayName(unit);
                string[] additionalAliases = getAliases == null ? null : getAliases(unit);
                string[] generatedAliases = UnitToolsAliases.GetAliases(family, enumName);

                string[] acceptedAliases = BuildAcceptedAliases(
                    enumName,
                    symbol,
                    displayName,
                    generatedAliases,
                    additionalAliases,
                    UnitToolsAliasVariants.GetNotationVariants(symbol));

                UnitToolsDimensions unitDimensions =
                    getDimensions == null
                        ? UnitToolsDimensions.ForFamily(family)
                        : getDimensions(unit);

                if (!firstDimensions.HasValue)
                {
                    firstDimensions = unitDimensions;
                }
                else if (firstDimensions.Value != unitDimensions)
                {
                    uniformDimensions = false;
                }

                var unitDescriptor = new UnitToolsUnitDescriptor(
                    unit,
                    enumName,
                    symbol,
                    displayName,
                    acceptedAliases,
                    unitDimensions,
                    UnitToolsProvenanceCatalog.Get(family, enumName));

                units.Add(unitDescriptor);
                _unitsByValue.Add(unit, unitDescriptor);

                foreach (string alias in acceptedAliases)
                {
                    AddExact(_exactAliases, _ambiguousExactAliases, alias, unit);
                    AddIgnoreCase(_ignoreCaseAliases, _ambiguousIgnoreCaseAliases, alias, unit);
                }
            }

            foreach (string ambiguousAlias in _ambiguousExactAliases)
            {
                _exactAliases.Remove(ambiguousAlias);
            }

            foreach (string ambiguousAlias in _ambiguousIgnoreCaseAliases)
            {
                _ignoreCaseAliases.Remove(ambiguousAlias);
            }

            _units = units.ToArray();
            _readOnlyUnits = Array.AsReadOnly(_units);
            _dimensions = firstDimensions ?? UnitToolsDimensions.Dimensionless;
            _hasUniformDimensions = uniformDimensions;
        }

        public override UnitToolsDimensions Dimensions => _dimensions;
        public override bool HasUniformDimensions => _hasUniformDimensions;
        public override Type UnitType => typeof(TUnit);
        public override IReadOnlyList<UnitToolsUnitDescriptor> Units => _readOnlyUnits;

        public bool TryResolveUnit(string text, out TUnit unit)
        {
            return ResolveUnit(text, out unit) == UnitToolsUnitResolution.Resolved;
        }

        public UnitToolsUnitResolution ResolveUnit(string text, out TUnit unit)
        {
            unit = default(TUnit);

            if (string.IsNullOrWhiteSpace(text))
            {
                return UnitToolsUnitResolution.Unknown;
            }

            string candidate = text.Trim();

            if (_ambiguousExactAliases.Contains(candidate))
            {
                return UnitToolsUnitResolution.Ambiguous;
            }

            if (_exactAliases.TryGetValue(candidate, out unit))
            {
                return UnitToolsUnitResolution.Resolved;
            }

            if (_ambiguousIgnoreCaseAliases.Contains(candidate))
            {
                return UnitToolsUnitResolution.Ambiguous;
            }

            if (_ignoreCaseAliases.TryGetValue(candidate, out unit))
            {
                return UnitToolsUnitResolution.Resolved;
            }

            return UnitToolsUnitResolution.Unknown;
        }

        public double Convert(double value, TUnit from, TUnit to)
        {
            return _convert(value, from, to);
        }

        internal bool TryGetExactScale(
            TUnit unit,
            out global::UnitTools.UnitToolsRational scale)
        {
            if (_getExactScale == null)
            {
                scale = global::UnitTools.UnitToolsRational.Zero;
                return false;
            }

            GetUnit(unit);
            scale = _getExactScale(unit);
            return true;
        }

        public UnitToolsUnitDescriptor GetUnit(TUnit unit)
        {
            UnitToolsUnitDescriptor descriptor;
            if (!TryGetUnit(unit, out descriptor))
            {
                throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported unit.");
            }

            return descriptor;
        }

        public bool TryGetUnit(TUnit unit, out UnitToolsUnitDescriptor descriptor)
        {
            return _unitsByValue.TryGetValue(unit, out descriptor);
        }

        public override bool TryGetUnit(
            object unit,
            out UnitToolsUnitDescriptor descriptor)
        {
            if (unit is TUnit)
            {
                return _unitsByValue.TryGetValue((TUnit)unit, out descriptor);
            }

            descriptor = null;
            return false;
        }

        public override UnitToolsUnitResolution ResolveUnit(string text, out object unit)
        {
            TUnit typedUnit;
            UnitToolsUnitResolution resolution = ResolveUnit(text, out typedUnit);
            unit = resolution == UnitToolsUnitResolution.Resolved
                ? GetUnit(typedUnit).Unit
                : null;
            return resolution;
        }

        public override double Convert(double value, object from, object to)
        {
            return _convert(value, (TUnit)from, (TUnit)to);
        }

        private static string[] BuildAcceptedAliases(
            string enumName,
            string symbol,
            string displayName,
            string[] generatedAliases,
            string[] additionalAliases,
            string[] notationAliases)
        {
            var aliases = new List<string>();
            AddAliasToList(aliases, enumName);
            AddAliasToList(aliases, symbol);
            AddAliasToList(aliases, displayName);

            if (generatedAliases != null)
            {
                foreach (string alias in generatedAliases)
                {
                    AddAliasToList(aliases, alias);
                }
            }

            if (additionalAliases != null)
            {
                foreach (string alias in additionalAliases)
                {
                    AddAliasToList(aliases, alias);
                }
            }

            if (notationAliases != null)
            {
                foreach (string alias in notationAliases)
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

    public static partial class UnitToolsCatalog
    {
        private static readonly UnitToolsFamilyDescriptor[] CoreFamilyDescriptors =
        {
                Create<UnitTools.Acceleration.UnitToolsAccelerationUnit>(UnitToolsFamily.Acceleration, "Acceleration", "MeterPerSecondSquared", UnitTools.Acceleration.UnitToolsAcceleration.GetSymbol, UnitTools.Acceleration.UnitToolsAcceleration.GetDisplayName, UnitTools.Acceleration.UnitToolsAcceleration.Convert),
                Create<UnitTools.ActivityConcentration.UnitToolsActivityConcentrationUnit>(UnitToolsFamily.ActivityConcentration, "ActivityConcentration", "BecquerelPerCubicMeter", UnitTools.ActivityConcentration.UnitToolsActivityConcentration.GetSymbol, UnitTools.ActivityConcentration.UnitToolsActivityConcentration.GetDisplayName, UnitTools.ActivityConcentration.UnitToolsActivityConcentration.Convert),
                Create<UnitTools.AmountOfSubstance.UnitToolsAmountOfSubstanceUnit>(UnitToolsFamily.AmountOfSubstance, "AmountOfSubstance", "Mole", UnitTools.AmountOfSubstance.UnitToolsAmountOfSubstance.GetSymbol, UnitTools.AmountOfSubstance.UnitToolsAmountOfSubstance.GetDisplayName, UnitTools.AmountOfSubstance.UnitToolsAmountOfSubstance.Convert),
                Create<UnitTools.Angle.UnitToolsAngleUnit>(UnitToolsFamily.Angle, "Angle", "Degree", UnitTools.Angle.UnitToolsAngle.GetSymbol, UnitTools.Angle.UnitToolsAngle.GetDisplayName, UnitTools.Angle.UnitToolsAngle.Convert),
                Create<UnitTools.AngularAcceleration.UnitToolsAngularAccelerationUnit>(UnitToolsFamily.AngularAcceleration, "AngularAcceleration", "RadianPerSecondSquared", UnitTools.AngularAcceleration.UnitToolsAngularAcceleration.GetSymbol, UnitTools.AngularAcceleration.UnitToolsAngularAcceleration.GetDisplayName, UnitTools.AngularAcceleration.UnitToolsAngularAcceleration.Convert),
                Create<UnitTools.AngularMomentum.UnitToolsAngularMomentumUnit>(UnitToolsFamily.AngularMomentum, "AngularMomentum", "KilogramSquareMeterPerSecond", UnitTools.AngularMomentum.UnitToolsAngularMomentum.GetSymbol, UnitTools.AngularMomentum.UnitToolsAngularMomentum.GetDisplayName, UnitTools.AngularMomentum.UnitToolsAngularMomentum.Convert),
                Create<UnitTools.AngularVelocity.UnitToolsAngularVelocityUnit>(UnitToolsFamily.AngularVelocity, "AngularVelocity", "RadianPerSecond", UnitTools.AngularVelocity.UnitToolsAngularVelocity.GetSymbol, UnitTools.AngularVelocity.UnitToolsAngularVelocity.GetDisplayName, UnitTools.AngularVelocity.UnitToolsAngularVelocity.Convert),
                Create<UnitTools.Area.UnitToolsAreaUnit>(UnitToolsFamily.Area, "Area", "SquareMeter", UnitTools.Area.UnitToolsArea.GetSymbol, UnitTools.Area.UnitToolsArea.GetDisplayName, UnitTools.Area.UnitToolsArea.Convert),
                Create<UnitTools.AreaDensity.UnitToolsAreaDensityUnit>(UnitToolsFamily.AreaDensity, "AreaDensity", "KilogramPerSquareMeter", UnitTools.AreaDensity.UnitToolsAreaDensity.GetSymbol, UnitTools.AreaDensity.UnitToolsAreaDensity.GetDisplayName, UnitTools.AreaDensity.UnitToolsAreaDensity.Convert),
                Create<UnitTools.Capacitance.UnitToolsCapacitanceUnit>(UnitToolsFamily.Capacitance, "Capacitance", "Farad", UnitTools.Capacitance.UnitToolsCapacitance.GetSymbol, UnitTools.Capacitance.UnitToolsCapacitance.GetDisplayName, UnitTools.Capacitance.UnitToolsCapacitance.Convert),
                Create<UnitTools.ChargeDensity.UnitToolsChargeDensityUnit>(UnitToolsFamily.ChargeDensity, "ChargeDensity", "CoulombPerCubicMeter", UnitTools.ChargeDensity.UnitToolsChargeDensity.GetSymbol, UnitTools.ChargeDensity.UnitToolsChargeDensity.GetDisplayName, UnitTools.ChargeDensity.UnitToolsChargeDensity.Convert),
                Create<UnitTools.Compressibility.UnitToolsCompressibilityUnit>(UnitToolsFamily.Compressibility, "Compressibility", "PerPascal", UnitTools.Compressibility.UnitToolsCompressibility.GetSymbol, UnitTools.Compressibility.UnitToolsCompressibility.GetDisplayName, UnitTools.Compressibility.UnitToolsCompressibility.Convert),
                Create<UnitTools.Conductance.UnitToolsConductanceUnit>(UnitToolsFamily.Conductance, "Conductance", "Siemens", UnitTools.Conductance.UnitToolsConductance.GetSymbol, UnitTools.Conductance.UnitToolsConductance.GetDisplayName, UnitTools.Conductance.UnitToolsConductance.Convert),
                Create<UnitTools.Current.UnitToolsCurrentUnit>(UnitToolsFamily.Current, "Current", "Ampere", UnitTools.Current.UnitToolsCurrent.GetSymbol, UnitTools.Current.UnitToolsCurrent.GetDisplayName, UnitTools.Current.UnitToolsCurrent.Convert),
                Create<UnitTools.CurrentDensity.UnitToolsCurrentDensityUnit>(UnitToolsFamily.CurrentDensity, "CurrentDensity", "AmperePerSquareMeter", UnitTools.CurrentDensity.UnitToolsCurrentDensity.GetSymbol, UnitTools.CurrentDensity.UnitToolsCurrentDensity.GetDisplayName, UnitTools.CurrentDensity.UnitToolsCurrentDensity.Convert),
                Create<UnitTools.DataRate.UnitToolsDataRateUnit>(UnitToolsFamily.DataRate, "DataRate", "BitPerSecond", UnitTools.DataRate.UnitToolsDataRate.GetSymbol, UnitTools.DataRate.UnitToolsDataRate.GetDisplayName, UnitTools.DataRate.UnitToolsDataRate.Convert),
                Create<UnitTools.Density.UnitToolsDensityUnit>(UnitToolsFamily.Density, "Density", "KilogramPerCubicMeter", UnitTools.Density.UnitToolsDensity.GetSymbol, UnitTools.Density.UnitToolsDensity.GetDisplayName, UnitTools.Density.UnitToolsDensity.Convert),
                Create<UnitTools.DiffusionCoefficient.UnitToolsDiffusionCoefficientUnit>(UnitToolsFamily.DiffusionCoefficient, "DiffusionCoefficient", "SquareMeterPerSecond", UnitTools.DiffusionCoefficient.UnitToolsDiffusionCoefficient.GetSymbol, UnitTools.DiffusionCoefficient.UnitToolsDiffusionCoefficient.GetDisplayName, UnitTools.DiffusionCoefficient.UnitToolsDiffusionCoefficient.Convert),
                Create<UnitTools.DigitalStorage.UnitToolsDigitalStorageUnit>(UnitToolsFamily.DigitalStorage, "DigitalStorage", "Byte", UnitTools.DigitalStorage.UnitToolsDigitalStorage.GetSymbol, UnitTools.DigitalStorage.UnitToolsDigitalStorage.GetDisplayName, UnitTools.DigitalStorage.UnitToolsDigitalStorage.Convert),
                Create<UnitTools.DoseRate.UnitToolsDoseRateUnit>(UnitToolsFamily.DoseRate, "DoseRate", "GrayPerSecond", UnitTools.DoseRate.UnitToolsDoseRate.GetSymbol, UnitTools.DoseRate.UnitToolsDoseRate.GetDisplayName, UnitTools.DoseRate.UnitToolsDoseRate.Convert),
                Create<UnitTools.DynamicPressure.UnitToolsDynamicPressureUnit>(UnitToolsFamily.DynamicPressure, "DynamicPressure", "Pascal", UnitTools.DynamicPressure.UnitToolsDynamicPressure.GetSymbol, UnitTools.DynamicPressure.UnitToolsDynamicPressure.GetDisplayName, UnitTools.DynamicPressure.UnitToolsDynamicPressure.Convert),
                Create<UnitTools.DynamicViscosity.UnitToolsDynamicViscosityUnit>(UnitToolsFamily.DynamicViscosity, "DynamicViscosity", "PascalSecond", UnitTools.DynamicViscosity.UnitToolsDynamicViscosity.GetSymbol, UnitTools.DynamicViscosity.UnitToolsDynamicViscosity.GetDisplayName, UnitTools.DynamicViscosity.UnitToolsDynamicViscosity.Convert),
                Create<UnitTools.ElectricCharge.UnitToolsElectricChargeUnit>(UnitToolsFamily.ElectricCharge, "ElectricCharge", "Coulomb", UnitTools.ElectricCharge.UnitToolsElectricCharge.GetSymbol, UnitTools.ElectricCharge.UnitToolsElectricCharge.GetDisplayName, UnitTools.ElectricCharge.UnitToolsElectricCharge.Convert),
                Create<UnitTools.ElectricFieldStrength.UnitToolsElectricFieldStrengthUnit>(UnitToolsFamily.ElectricFieldStrength, "ElectricFieldStrength", "VoltPerMeter", UnitTools.ElectricFieldStrength.UnitToolsElectricFieldStrength.GetSymbol, UnitTools.ElectricFieldStrength.UnitToolsElectricFieldStrength.GetDisplayName, UnitTools.ElectricFieldStrength.UnitToolsElectricFieldStrength.Convert),
                Create<UnitTools.ElectricFlux.UnitToolsElectricFluxUnit>(UnitToolsFamily.ElectricFlux, "ElectricFlux", "VoltMeter", UnitTools.ElectricFlux.UnitToolsElectricFlux.GetSymbol, UnitTools.ElectricFlux.UnitToolsElectricFlux.GetDisplayName, UnitTools.ElectricFlux.UnitToolsElectricFlux.Convert),
                Create<UnitTools.ElectricFluxDensity.UnitToolsElectricFluxDensityUnit>(UnitToolsFamily.ElectricFluxDensity, "ElectricFluxDensity", "CoulombPerSquareMeter", UnitTools.ElectricFluxDensity.UnitToolsElectricFluxDensity.GetSymbol, UnitTools.ElectricFluxDensity.UnitToolsElectricFluxDensity.GetDisplayName, UnitTools.ElectricFluxDensity.UnitToolsElectricFluxDensity.Convert),
                Create<UnitTools.ElectricResistance.UnitToolsElectricResistanceUnit>(UnitToolsFamily.ElectricResistance, "ElectricResistance", "Ohm", UnitTools.ElectricResistance.UnitToolsElectricResistance.GetSymbol, UnitTools.ElectricResistance.UnitToolsElectricResistance.GetDisplayName, UnitTools.ElectricResistance.UnitToolsElectricResistance.Convert),
                Create<UnitTools.ElectricalConductivity.UnitToolsElectricalConductivityUnit>(UnitToolsFamily.ElectricalConductivity, "ElectricalConductivity", "SiemensPerMeter", UnitTools.ElectricalConductivity.UnitToolsElectricalConductivity.GetSymbol, UnitTools.ElectricalConductivity.UnitToolsElectricalConductivity.GetDisplayName, UnitTools.ElectricalConductivity.UnitToolsElectricalConductivity.Convert),
                Create<UnitTools.ElectricalResistivity.UnitToolsElectricalResistivityUnit>(UnitToolsFamily.ElectricalResistivity, "ElectricalResistivity", "OhmMeter", UnitTools.ElectricalResistivity.UnitToolsElectricalResistivity.GetSymbol, UnitTools.ElectricalResistivity.UnitToolsElectricalResistivity.GetDisplayName, UnitTools.ElectricalResistivity.UnitToolsElectricalResistivity.Convert),
                Create<UnitTools.Energy.UnitToolsEnergyUnit>(UnitToolsFamily.Energy, "Energy", "Joule", UnitTools.Energy.UnitToolsEnergy.GetSymbol, UnitTools.Energy.UnitToolsEnergy.GetDisplayName, UnitTools.Energy.UnitToolsEnergy.Convert),
                Create<UnitTools.EnergyDensity.UnitToolsEnergyDensityUnit>(UnitToolsFamily.EnergyDensity, "EnergyDensity", "JoulePerCubicMeter", UnitTools.EnergyDensity.UnitToolsEnergyDensity.GetSymbol, UnitTools.EnergyDensity.UnitToolsEnergyDensity.GetDisplayName, UnitTools.EnergyDensity.UnitToolsEnergyDensity.Convert),
                Create<UnitTools.ExposureRate.UnitToolsExposureRateUnit>(UnitToolsFamily.ExposureRate, "ExposureRate", "CoulombPerKilogramSecond", UnitTools.ExposureRate.UnitToolsExposureRate.GetSymbol, UnitTools.ExposureRate.UnitToolsExposureRate.GetDisplayName, UnitTools.ExposureRate.UnitToolsExposureRate.Convert),
                Create<UnitTools.Force.UnitToolsForceUnit>(UnitToolsFamily.Force, "Force", "Newton", UnitTools.Force.UnitToolsForce.GetSymbol, UnitTools.Force.UnitToolsForce.GetDisplayName, UnitTools.Force.UnitToolsForce.Convert),
                Create<UnitTools.ForcePerLength.UnitToolsForcePerLengthUnit>(UnitToolsFamily.ForcePerLength, "ForcePerLength", "NewtonPerMeter", UnitTools.ForcePerLength.UnitToolsForcePerLength.GetSymbol, UnitTools.ForcePerLength.UnitToolsForcePerLength.GetDisplayName, UnitTools.ForcePerLength.UnitToolsForcePerLength.Convert),
                Create<UnitTools.FrameRate.UnitToolsFrameRateUnit>(UnitToolsFamily.FrameRate, "FrameRate", "FramePerSecond", UnitTools.FrameRate.UnitToolsFrameRate.GetSymbol, UnitTools.FrameRate.UnitToolsFrameRate.GetDisplayName, UnitTools.FrameRate.UnitToolsFrameRate.Convert),
                Create<UnitTools.Frequency.UnitToolsFrequencyUnit>(UnitToolsFamily.Frequency, "Frequency", "Hertz", UnitTools.Frequency.UnitToolsFrequency.GetSymbol, UnitTools.Frequency.UnitToolsFrequency.GetDisplayName, UnitTools.Frequency.UnitToolsFrequency.Convert),
                Create<UnitTools.FuelEconomy.UnitToolsFuelEconomyUnit>(UnitToolsFamily.FuelEconomy, "FuelEconomy", "KilometerPerLiter", UnitTools.FuelEconomy.UnitToolsFuelEconomy.GetSymbol, UnitTools.FuelEconomy.UnitToolsFuelEconomy.GetDisplayName, UnitTools.FuelEconomy.UnitToolsFuelEconomy.Convert, null, UnitToolsDimensions.ForFuelEconomyUnit),
                Create<UnitTools.HeatTransferCoefficient.UnitToolsHeatTransferCoefficientUnit>(UnitToolsFamily.HeatTransferCoefficient, "HeatTransferCoefficient", "WattPerSquareMeterKelvin", UnitTools.HeatTransferCoefficient.UnitToolsHeatTransferCoefficient.GetSymbol, UnitTools.HeatTransferCoefficient.UnitToolsHeatTransferCoefficient.GetDisplayName, UnitTools.HeatTransferCoefficient.UnitToolsHeatTransferCoefficient.Convert),
                Create<UnitTools.HydraulicPermeability.UnitToolsHydraulicPermeabilityUnit>(UnitToolsFamily.HydraulicPermeability, "HydraulicPermeability", "SquareMeter", UnitTools.HydraulicPermeability.UnitToolsHydraulicPermeability.GetSymbol, UnitTools.HydraulicPermeability.UnitToolsHydraulicPermeability.GetDisplayName, UnitTools.HydraulicPermeability.UnitToolsHydraulicPermeability.Convert),
                Create<UnitTools.Illuminance.UnitToolsIlluminanceUnit>(UnitToolsFamily.Illuminance, "Illuminance", "Lux", UnitTools.Illuminance.UnitToolsIlluminance.GetSymbol, UnitTools.Illuminance.UnitToolsIlluminance.GetDisplayName, UnitTools.Illuminance.UnitToolsIlluminance.Convert),
                Create<UnitTools.Impulse.UnitToolsImpulseUnit>(UnitToolsFamily.Impulse, "Impulse", "NewtonSecond", UnitTools.Impulse.UnitToolsImpulse.GetSymbol, UnitTools.Impulse.UnitToolsImpulse.GetDisplayName, UnitTools.Impulse.UnitToolsImpulse.Convert),
                Create<UnitTools.Inductance.UnitToolsInductanceUnit>(UnitToolsFamily.Inductance, "Inductance", "Henry", UnitTools.Inductance.UnitToolsInductance.GetSymbol, UnitTools.Inductance.UnitToolsInductance.GetDisplayName, UnitTools.Inductance.UnitToolsInductance.Convert),
                Create<UnitTools.Irradiance.UnitToolsIrradianceUnit>(UnitToolsFamily.Irradiance, "Irradiance", "WattPerSquareMeter", UnitTools.Irradiance.UnitToolsIrradiance.GetSymbol, UnitTools.Irradiance.UnitToolsIrradiance.GetDisplayName, UnitTools.Irradiance.UnitToolsIrradiance.Convert),
                Create<UnitTools.Jerk.UnitToolsJerkUnit>(UnitToolsFamily.Jerk, "Jerk", "MeterPerSecondCubed", UnitTools.Jerk.UnitToolsJerk.GetSymbol, UnitTools.Jerk.UnitToolsJerk.GetDisplayName, UnitTools.Jerk.UnitToolsJerk.Convert),
                Create<UnitTools.KinematicViscosity.UnitToolsKinematicViscosityUnit>(UnitToolsFamily.KinematicViscosity, "KinematicViscosity", "SquareMeterPerSecond", UnitTools.KinematicViscosity.UnitToolsKinematicViscosity.GetSymbol, UnitTools.KinematicViscosity.UnitToolsKinematicViscosity.GetDisplayName, UnitTools.KinematicViscosity.UnitToolsKinematicViscosity.Convert),
                Create<UnitTools.Length.UnitToolsLengthUnit>(UnitToolsFamily.Length, "Length", "Meter", UnitTools.Length.UnitToolsLength.GetSymbol, UnitTools.Length.UnitToolsLength.GetDisplayName, UnitTools.Length.UnitToolsLength.Convert),
                Create<UnitTools.LinearDensity.UnitToolsLinearDensityUnit>(UnitToolsFamily.LinearDensity, "LinearDensity", "KilogramPerMeter", UnitTools.LinearDensity.UnitToolsLinearDensity.GetSymbol, UnitTools.LinearDensity.UnitToolsLinearDensity.GetDisplayName, UnitTools.LinearDensity.UnitToolsLinearDensity.Convert),
                Create<UnitTools.Luminance.UnitToolsLuminanceUnit>(UnitToolsFamily.Luminance, "Luminance", "CandelaPerSquareMeter", UnitTools.Luminance.UnitToolsLuminance.GetSymbol, UnitTools.Luminance.UnitToolsLuminance.GetDisplayName, UnitTools.Luminance.UnitToolsLuminance.Convert),
                Create<UnitTools.LuminousEfficacy.UnitToolsLuminousEfficacyUnit>(UnitToolsFamily.LuminousEfficacy, "LuminousEfficacy", "LumenPerWatt", UnitTools.LuminousEfficacy.UnitToolsLuminousEfficacy.GetSymbol, UnitTools.LuminousEfficacy.UnitToolsLuminousEfficacy.GetDisplayName, UnitTools.LuminousEfficacy.UnitToolsLuminousEfficacy.Convert),
                Create<UnitTools.LuminousEnergy.UnitToolsLuminousEnergyUnit>(UnitToolsFamily.LuminousEnergy, "LuminousEnergy", "LumenSecond", UnitTools.LuminousEnergy.UnitToolsLuminousEnergy.GetSymbol, UnitTools.LuminousEnergy.UnitToolsLuminousEnergy.GetDisplayName, UnitTools.LuminousEnergy.UnitToolsLuminousEnergy.Convert),
                Create<UnitTools.LuminousExposure.UnitToolsLuminousExposureUnit>(UnitToolsFamily.LuminousExposure, "LuminousExposure", "LuxSecond", UnitTools.LuminousExposure.UnitToolsLuminousExposure.GetSymbol, UnitTools.LuminousExposure.UnitToolsLuminousExposure.GetDisplayName, UnitTools.LuminousExposure.UnitToolsLuminousExposure.Convert),
                Create<UnitTools.LuminousFlux.UnitToolsLuminousFluxUnit>(UnitToolsFamily.LuminousFlux, "LuminousFlux", "Lumen", UnitTools.LuminousFlux.UnitToolsLuminousFlux.GetSymbol, UnitTools.LuminousFlux.UnitToolsLuminousFlux.GetDisplayName, UnitTools.LuminousFlux.UnitToolsLuminousFlux.Convert),
                Create<UnitTools.LuminousIntensity.UnitToolsLuminousIntensityUnit>(UnitToolsFamily.LuminousIntensity, "LuminousIntensity", "Candela", UnitTools.LuminousIntensity.UnitToolsLuminousIntensity.GetSymbol, UnitTools.LuminousIntensity.UnitToolsLuminousIntensity.GetDisplayName, UnitTools.LuminousIntensity.UnitToolsLuminousIntensity.Convert),
                Create<UnitTools.MagneticField.UnitToolsMagneticFieldUnit>(UnitToolsFamily.MagneticField, "MagneticField", "Tesla", UnitTools.MagneticField.UnitToolsMagneticField.GetSymbol, UnitTools.MagneticField.UnitToolsMagneticField.GetDisplayName, UnitTools.MagneticField.UnitToolsMagneticField.Convert),
                Create<UnitTools.MagneticFlux.UnitToolsMagneticFluxUnit>(UnitToolsFamily.MagneticFlux, "MagneticFlux", "Weber", UnitTools.MagneticFlux.UnitToolsMagneticFlux.GetSymbol, UnitTools.MagneticFlux.UnitToolsMagneticFlux.GetDisplayName, UnitTools.MagneticFlux.UnitToolsMagneticFlux.Convert),
                Create<UnitTools.MagneticPermeability.UnitToolsMagneticPermeabilityUnit>(UnitToolsFamily.MagneticPermeability, "MagneticPermeability", "HenryPerMeter", UnitTools.MagneticPermeability.UnitToolsMagneticPermeability.GetSymbol, UnitTools.MagneticPermeability.UnitToolsMagneticPermeability.GetDisplayName, UnitTools.MagneticPermeability.UnitToolsMagneticPermeability.Convert),
                Create<UnitTools.MagnetizingFieldStrength.UnitToolsMagnetizingFieldStrengthUnit>(UnitToolsFamily.MagnetizingFieldStrength, "MagnetizingFieldStrength", "AmperePerMeter", UnitTools.MagnetizingFieldStrength.UnitToolsMagnetizingFieldStrength.GetSymbol, UnitTools.MagnetizingFieldStrength.UnitToolsMagnetizingFieldStrength.GetDisplayName, UnitTools.MagnetizingFieldStrength.UnitToolsMagnetizingFieldStrength.Convert),
                Create<UnitTools.Mass.UnitToolsMassUnit>(UnitToolsFamily.Mass, "Mass", "Kilogram", UnitTools.Mass.UnitToolsMass.GetSymbol, UnitTools.Mass.UnitToolsMass.GetDisplayName, UnitTools.Mass.UnitToolsMass.Convert),
                Create<UnitTools.MassConcentration.UnitToolsMassConcentrationUnit>(UnitToolsFamily.MassConcentration, "MassConcentration", "KilogramPerCubicMeter", UnitTools.MassConcentration.UnitToolsMassConcentration.GetSymbol, UnitTools.MassConcentration.UnitToolsMassConcentration.GetDisplayName, UnitTools.MassConcentration.UnitToolsMassConcentration.Convert),
                Create<UnitTools.MassFlowRate.UnitToolsMassFlowRateUnit>(UnitToolsFamily.MassFlowRate, "MassFlowRate", "KilogramPerSecond", UnitTools.MassFlowRate.UnitToolsMassFlowRate.GetSymbol, UnitTools.MassFlowRate.UnitToolsMassFlowRate.GetDisplayName, UnitTools.MassFlowRate.UnitToolsMassFlowRate.Convert),
                Create<UnitTools.MassFlux.UnitToolsMassFluxUnit>(UnitToolsFamily.MassFlux, "MassFlux", "KilogramPerSquareMeterSecond", UnitTools.MassFlux.UnitToolsMassFlux.GetSymbol, UnitTools.MassFlux.UnitToolsMassFlux.GetDisplayName, UnitTools.MassFlux.UnitToolsMassFlux.Convert),
                Create<UnitTools.MolarConcentration.UnitToolsMolarConcentrationUnit>(UnitToolsFamily.MolarConcentration, "MolarConcentration", "MolePerCubicMeter", UnitTools.MolarConcentration.UnitToolsMolarConcentration.GetSymbol, UnitTools.MolarConcentration.UnitToolsMolarConcentration.GetDisplayName, UnitTools.MolarConcentration.UnitToolsMolarConcentration.Convert),
                Create<UnitTools.MolarMass.UnitToolsMolarMassUnit>(UnitToolsFamily.MolarMass, "MolarMass", "KilogramPerMole", UnitTools.MolarMass.UnitToolsMolarMass.GetSymbol, UnitTools.MolarMass.UnitToolsMolarMass.GetDisplayName, UnitTools.MolarMass.UnitToolsMolarMass.Convert),
                Create<UnitTools.MomentOfInertia.UnitToolsMomentOfInertiaUnit>(UnitToolsFamily.MomentOfInertia, "MomentOfInertia", "KilogramSquareMeter", UnitTools.MomentOfInertia.UnitToolsMomentOfInertia.GetSymbol, UnitTools.MomentOfInertia.UnitToolsMomentOfInertia.GetDisplayName, UnitTools.MomentOfInertia.UnitToolsMomentOfInertia.Convert),
                Create<UnitTools.Momentum.UnitToolsMomentumUnit>(UnitToolsFamily.Momentum, "Momentum", "KilogramMeterPerSecond", UnitTools.Momentum.UnitToolsMomentum.GetSymbol, UnitTools.Momentum.UnitToolsMomentum.GetDisplayName, UnitTools.Momentum.UnitToolsMomentum.Convert),
                Create<UnitTools.ParticleFluence.UnitToolsParticleFluenceUnit>(UnitToolsFamily.ParticleFluence, "ParticleFluence", "ParticlePerSquareMeter", UnitTools.ParticleFluence.UnitToolsParticleFluence.GetSymbol, UnitTools.ParticleFluence.UnitToolsParticleFluence.GetDisplayName, UnitTools.ParticleFluence.UnitToolsParticleFluence.Convert),
                Create<UnitTools.ParticleFlux.UnitToolsParticleFluxUnit>(UnitToolsFamily.ParticleFlux, "ParticleFlux", "ParticlePerSquareMeterSecond", UnitTools.ParticleFlux.UnitToolsParticleFlux.GetSymbol, UnitTools.ParticleFlux.UnitToolsParticleFlux.GetDisplayName, UnitTools.ParticleFlux.UnitToolsParticleFlux.Convert),
                Create<UnitTools.Permittivity.UnitToolsPermittivityUnit>(UnitToolsFamily.Permittivity, "Permittivity", "FaradPerMeter", UnitTools.Permittivity.UnitToolsPermittivity.GetSymbol, UnitTools.Permittivity.UnitToolsPermittivity.GetDisplayName, UnitTools.Permittivity.UnitToolsPermittivity.Convert),
                Create<UnitTools.PixelDensity.UnitToolsPixelDensityUnit>(UnitToolsFamily.PixelDensity, "PixelDensity", "PixelPerMeter", UnitTools.PixelDensity.UnitToolsPixelDensity.GetSymbol, UnitTools.PixelDensity.UnitToolsPixelDensity.GetDisplayName, UnitTools.PixelDensity.UnitToolsPixelDensity.Convert),
                Create<UnitTools.Power.UnitToolsPowerUnit>(UnitToolsFamily.Power, "Power", "Watt", UnitTools.Power.UnitToolsPower.GetSymbol, UnitTools.Power.UnitToolsPower.GetDisplayName, UnitTools.Power.UnitToolsPower.Convert),
                Create<UnitTools.PowerDensity.UnitToolsPowerDensityUnit>(UnitToolsFamily.PowerDensity, "PowerDensity", "WattPerCubicMeter", UnitTools.PowerDensity.UnitToolsPowerDensity.GetSymbol, UnitTools.PowerDensity.UnitToolsPowerDensity.GetDisplayName, UnitTools.PowerDensity.UnitToolsPowerDensity.Convert),
                Create<UnitTools.Pressure.UnitToolsPressureUnit>(UnitToolsFamily.Pressure, "Pressure", "Pascal", UnitTools.Pressure.UnitToolsPressure.GetSymbol, UnitTools.Pressure.UnitToolsPressure.GetDisplayName, UnitTools.Pressure.UnitToolsPressure.Convert),
                Create<UnitTools.PressureGradient.UnitToolsPressureGradientUnit>(UnitToolsFamily.PressureGradient, "PressureGradient", "PascalPerMeter", UnitTools.PressureGradient.UnitToolsPressureGradient.GetSymbol, UnitTools.PressureGradient.UnitToolsPressureGradient.GetDisplayName, UnitTools.PressureGradient.UnitToolsPressureGradient.Convert),
                Create<UnitTools.Radiance.UnitToolsRadianceUnit>(UnitToolsFamily.Radiance, "Radiance", "WattPerSteradianSquareMeter", UnitTools.Radiance.UnitToolsRadiance.GetSymbol, UnitTools.Radiance.UnitToolsRadiance.GetDisplayName, UnitTools.Radiance.UnitToolsRadiance.Convert),
                Create<UnitTools.RadiationDose.UnitToolsRadiationDoseUnit>(UnitToolsFamily.RadiationDose, "RadiationDose", "Gray", UnitTools.RadiationDose.UnitToolsRadiationDose.GetSymbol, UnitTools.RadiationDose.UnitToolsRadiationDose.GetDisplayName, UnitTools.RadiationDose.UnitToolsRadiationDose.Convert),
                Create<UnitTools.RadiationExposure.UnitToolsRadiationExposureUnit>(UnitToolsFamily.RadiationExposure, "RadiationExposure", "CoulombPerKilogram", UnitTools.RadiationExposure.UnitToolsRadiationExposure.GetSymbol, UnitTools.RadiationExposure.UnitToolsRadiationExposure.GetDisplayName, UnitTools.RadiationExposure.UnitToolsRadiationExposure.Convert),
                Create<UnitTools.Radioactivity.UnitToolsRadioactivityUnit>(UnitToolsFamily.Radioactivity, "Radioactivity", "Becquerel", UnitTools.Radioactivity.UnitToolsRadioactivity.GetSymbol, UnitTools.Radioactivity.UnitToolsRadioactivity.GetDisplayName, UnitTools.Radioactivity.UnitToolsRadioactivity.Convert),
                Create<UnitTools.Snap.UnitToolsSnapUnit>(UnitToolsFamily.Snap, "Snap", "MeterPerSecondFourth", UnitTools.Snap.UnitToolsSnap.GetSymbol, UnitTools.Snap.UnitToolsSnap.GetDisplayName, UnitTools.Snap.UnitToolsSnap.Convert),
                Create<UnitTools.SpecificGravity.UnitToolsSpecificGravityUnit>(UnitToolsFamily.SpecificGravity, "SpecificGravity", "Ratio", UnitTools.SpecificGravity.UnitToolsSpecificGravity.GetSymbol, UnitTools.SpecificGravity.UnitToolsSpecificGravity.GetDisplayName, UnitTools.SpecificGravity.UnitToolsSpecificGravity.Convert),
                Create<UnitTools.SpecificHeatCapacity.UnitToolsSpecificHeatCapacityUnit>(UnitToolsFamily.SpecificHeatCapacity, "SpecificHeatCapacity", "JoulePerKilogramKelvin", UnitTools.SpecificHeatCapacity.UnitToolsSpecificHeatCapacity.GetSymbol, UnitTools.SpecificHeatCapacity.UnitToolsSpecificHeatCapacity.GetDisplayName, UnitTools.SpecificHeatCapacity.UnitToolsSpecificHeatCapacity.Convert),
                Create<UnitTools.SpecificVolume.UnitToolsSpecificVolumeUnit>(UnitToolsFamily.SpecificVolume, "SpecificVolume", "CubicMeterPerKilogram", UnitTools.SpecificVolume.UnitToolsSpecificVolume.GetSymbol, UnitTools.SpecificVolume.UnitToolsSpecificVolume.GetDisplayName, UnitTools.SpecificVolume.UnitToolsSpecificVolume.Convert),
                Create<UnitTools.SpecificWeight.UnitToolsSpecificWeightUnit>(UnitToolsFamily.SpecificWeight, "SpecificWeight", "NewtonPerCubicMeter", UnitTools.SpecificWeight.UnitToolsSpecificWeight.GetSymbol, UnitTools.SpecificWeight.UnitToolsSpecificWeight.GetDisplayName, UnitTools.SpecificWeight.UnitToolsSpecificWeight.Convert),
                Create<UnitTools.Speed.UnitToolsSpeedUnit>(UnitToolsFamily.Speed, "Speed", "MeterPerSecond", UnitTools.Speed.UnitToolsSpeed.GetSymbol, UnitTools.Speed.UnitToolsSpeed.GetDisplayName, UnitTools.Speed.UnitToolsSpeed.Convert),
                Create<UnitTools.SurfaceTension.UnitToolsSurfaceTensionUnit>(UnitToolsFamily.SurfaceTension, "SurfaceTension", "NewtonPerMeter", UnitTools.SurfaceTension.UnitToolsSurfaceTension.GetSymbol, UnitTools.SurfaceTension.UnitToolsSurfaceTension.GetDisplayName, UnitTools.SurfaceTension.UnitToolsSurfaceTension.Convert),
                Create<UnitTools.Temperature.UnitToolsTemperatureUnit>(UnitToolsFamily.Temperature, "Temperature", "Kelvin", UnitTools.Temperature.UnitToolsTemperature.GetSymbol, UnitTools.Temperature.UnitToolsTemperature.GetDisplayName, UnitTools.Temperature.UnitToolsTemperature.Convert),
                Create<UnitTools.TemperatureDelta.UnitToolsTemperatureDeltaUnit>(UnitToolsFamily.TemperatureDelta, "TemperatureDelta", "Kelvin", UnitTools.TemperatureDelta.UnitToolsTemperatureDelta.GetSymbol, UnitTools.TemperatureDelta.UnitToolsTemperatureDelta.GetDisplayName, UnitTools.TemperatureDelta.UnitToolsTemperatureDelta.Convert),
                Create<UnitTools.ThermalConductivity.UnitToolsThermalConductivityUnit>(UnitToolsFamily.ThermalConductivity, "ThermalConductivity", "WattPerMeterKelvin", UnitTools.ThermalConductivity.UnitToolsThermalConductivity.GetSymbol, UnitTools.ThermalConductivity.UnitToolsThermalConductivity.GetDisplayName, UnitTools.ThermalConductivity.UnitToolsThermalConductivity.Convert),
                Create<UnitTools.ThermalDiffusivity.UnitToolsThermalDiffusivityUnit>(UnitToolsFamily.ThermalDiffusivity, "ThermalDiffusivity", "SquareMeterPerSecond", UnitTools.ThermalDiffusivity.UnitToolsThermalDiffusivity.GetSymbol, UnitTools.ThermalDiffusivity.UnitToolsThermalDiffusivity.GetDisplayName, UnitTools.ThermalDiffusivity.UnitToolsThermalDiffusivity.Convert),
                Create<UnitTools.ThermalExpansion.UnitToolsThermalExpansionUnit>(UnitToolsFamily.ThermalExpansion, "ThermalExpansion", "PerKelvin", UnitTools.ThermalExpansion.UnitToolsThermalExpansion.GetSymbol, UnitTools.ThermalExpansion.UnitToolsThermalExpansion.GetDisplayName, UnitTools.ThermalExpansion.UnitToolsThermalExpansion.Convert),
                Create<UnitTools.Time.UnitToolsTimeUnit>(UnitToolsFamily.Time, "Time", "Second", UnitTools.Time.UnitToolsTime.GetSymbol, UnitTools.Time.UnitToolsTime.GetDisplayName, UnitTools.Time.UnitToolsTime.Convert),
                Create<UnitTools.Torque.UnitToolsTorqueUnit>(UnitToolsFamily.Torque, "Torque", "NewtonMeter", UnitTools.Torque.UnitToolsTorque.GetSymbol, UnitTools.Torque.UnitToolsTorque.GetDisplayName, UnitTools.Torque.UnitToolsTorque.Convert),
                Create<UnitTools.TorquePerAngle.UnitToolsTorquePerAngleUnit>(UnitToolsFamily.TorquePerAngle, "TorquePerAngle", "NewtonMeterPerRadian", UnitTools.TorquePerAngle.UnitToolsTorquePerAngle.GetSymbol, UnitTools.TorquePerAngle.UnitToolsTorquePerAngle.GetDisplayName, UnitTools.TorquePerAngle.UnitToolsTorquePerAngle.Convert),
                Create<UnitTools.VaporPressure.UnitToolsVaporPressureUnit>(UnitToolsFamily.VaporPressure, "VaporPressure", "Pascal", UnitTools.VaporPressure.UnitToolsVaporPressure.GetSymbol, UnitTools.VaporPressure.UnitToolsVaporPressure.GetDisplayName, UnitTools.VaporPressure.UnitToolsVaporPressure.Convert),
                Create<UnitTools.Voltage.UnitToolsVoltageUnit>(UnitToolsFamily.Voltage, "Voltage", "Volt", UnitTools.Voltage.UnitToolsVoltage.GetSymbol, UnitTools.Voltage.UnitToolsVoltage.GetDisplayName, UnitTools.Voltage.UnitToolsVoltage.Convert),
                Create<UnitTools.Volume.UnitToolsVolumeUnit>(UnitToolsFamily.Volume, "Volume", "Liter", UnitTools.Volume.UnitToolsVolume.GetSymbol, UnitTools.Volume.UnitToolsVolume.GetDisplayName, UnitTools.Volume.UnitToolsVolume.Convert),
                Create<UnitTools.VolumetricFlowRate.UnitToolsVolumetricFlowRateUnit>(UnitToolsFamily.VolumetricFlowRate, "VolumetricFlowRate", "CubicMeterPerSecond", UnitTools.VolumetricFlowRate.UnitToolsVolumetricFlowRate.GetSymbol, UnitTools.VolumetricFlowRate.UnitToolsVolumetricFlowRate.GetDisplayName, UnitTools.VolumetricFlowRate.UnitToolsVolumetricFlowRate.Convert),
                Create<UnitTools.VolumetricFlux.UnitToolsVolumetricFluxUnit>(UnitToolsFamily.VolumetricFlux, "VolumetricFlux", "MeterPerSecond", UnitTools.VolumetricFlux.UnitToolsVolumetricFlux.GetSymbol, UnitTools.VolumetricFlux.UnitToolsVolumetricFlux.GetDisplayName, UnitTools.VolumetricFlux.UnitToolsVolumetricFlux.Convert),
                Create<UnitTools.Yank.UnitToolsYankUnit>(UnitToolsFamily.Yank, "Yank", "NewtonPerSecond", UnitTools.Yank.UnitToolsYank.GetSymbol, UnitTools.Yank.UnitToolsYank.GetDisplayName, UnitTools.Yank.UnitToolsYank.Convert),
        };

        private static readonly UnitToolsFamilyDescriptor[] FamilyDescriptors =
            BuildAllFamilyDescriptors();

        private static UnitToolsFamilyDescriptor[] BuildAllFamilyDescriptors()
        {
            UnitToolsFamilyDescriptor[] additional = GetAdditionalFamilyDescriptors();
            var result = new UnitToolsFamilyDescriptor[CoreFamilyDescriptors.Length + additional.Length];
            Array.Copy(CoreFamilyDescriptors, 0, result, 0, CoreFamilyDescriptors.Length);
            Array.Copy(additional, 0, result, CoreFamilyDescriptors.Length, additional.Length);
            return result;
        }

        private static readonly Dictionary<UnitToolsFamily, UnitToolsFamilyDescriptor> FamiliesById =
            BuildFamiliesById();

        private static readonly Dictionary<string, UnitToolsFamilyDescriptor> FamiliesByName =
            BuildFamiliesByName();

        private static readonly Dictionary<Type, UnitToolsFamilyDescriptor> FamiliesByUnitType =
            BuildFamiliesByUnitType();

        public static UnitToolsFamilyDescriptor[] GetFamilies()
        {
            return (UnitToolsFamilyDescriptor[])FamilyDescriptors.Clone();
        }

        public static UnitToolsFamilyDescriptor GetFamily(UnitToolsFamily family)
        {
            UnitToolsFamilyDescriptor descriptor;
            if (!FamiliesById.TryGetValue(family, out descriptor))
            {
                throw new ArgumentOutOfRangeException(nameof(family), family, "Unsupported unit family.");
            }

            return descriptor;
        }

        public static bool TryGetFamily(
            UnitToolsFamily family,
            out UnitToolsFamilyDescriptor descriptor)
        {
            return FamiliesById.TryGetValue(family, out descriptor);
        }

        public static bool TryGetFamily(
            string familyName,
            out UnitToolsFamilyDescriptor descriptor)
        {
            descriptor = null;

            if (string.IsNullOrWhiteSpace(familyName))
            {
                return false;
            }

            return FamiliesByName.TryGetValue(familyName.Trim(), out descriptor);
        }

        public static bool TryGetFamily<TUnit>(
            out UnitToolsFamilyDescriptor<TUnit> descriptor)
            where TUnit : struct
        {
            UnitToolsFamilyDescriptor rawDescriptor;
            if (FamiliesByUnitType.TryGetValue(typeof(TUnit), out rawDescriptor))
            {
                descriptor = rawDescriptor as UnitToolsFamilyDescriptor<TUnit>;
                return descriptor != null;
            }

            descriptor = null;
            return false;
        }

        private static UnitToolsFamilyDescriptor Create<TUnit>(
            UnitToolsFamily family,
            string name,
            string baseUnitName,
            Func<TUnit, string> getSymbol,
            Func<TUnit, string> getDisplayName,
            Func<double, TUnit, TUnit, double> convert,
            Func<TUnit, string[]> getAliases = null,
            Func<TUnit, UnitToolsDimensions> getDimensions = null,
            Func<TUnit, global::UnitTools.UnitToolsRational> getExactScale = null)
            where TUnit : struct
        {
            return new UnitToolsFamilyDescriptor<TUnit>(
                family,
                name,
                baseUnitName,
                getSymbol,
                getDisplayName,
                convert,
                getAliases,
                getDimensions,
                getExactScale);
        }

        private static Dictionary<UnitToolsFamily, UnitToolsFamilyDescriptor> BuildFamiliesById()
        {
            var result = new Dictionary<UnitToolsFamily, UnitToolsFamilyDescriptor>();

            foreach (UnitToolsFamilyDescriptor descriptor in FamilyDescriptors)
            {
                result.Add(descriptor.Family, descriptor);
            }

            return result;
        }

        private static Dictionary<string, UnitToolsFamilyDescriptor> BuildFamiliesByName()
        {
            var result = new Dictionary<string, UnitToolsFamilyDescriptor>(StringComparer.OrdinalIgnoreCase);

            foreach (UnitToolsFamilyDescriptor descriptor in FamilyDescriptors)
            {
                result.Add(descriptor.Name, descriptor);
            }

            return result;
        }

        private static Dictionary<Type, UnitToolsFamilyDescriptor> BuildFamiliesByUnitType()
        {
            var result = new Dictionary<Type, UnitToolsFamilyDescriptor>();

            foreach (UnitToolsFamilyDescriptor descriptor in FamilyDescriptors)
            {
                result.Add(descriptor.UnitType, descriptor);
            }

            return result;
        }
    }
}
