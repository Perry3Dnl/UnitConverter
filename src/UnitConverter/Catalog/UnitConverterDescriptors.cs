namespace UnitConverter.Catalog
{
    using System;
    using System.Collections.Generic;

    public enum UnitConverterUnitResolution
    {
        Unknown = 0,
        Resolved = 1,
        Ambiguous = 2,
    }

    public sealed class UnitConverterUnitDescriptor
    {
        internal UnitConverterUnitDescriptor(
            object unit,
            string name,
            string symbol,
            string displayName,
            string[] aliases,
            UnitConverterDimensions dimensions,
            UnitConverterProvenance provenance)
        {
            Unit = unit;
            Name = name;
            Symbol = symbol;
            DisplayName = displayName;
            Aliases = aliases ?? new string[0];
            Dimensions = dimensions;
            Provenance = provenance ?? throw new ArgumentNullException(nameof(provenance));
        }

        public object Unit { get; }
        public string Name { get; }
        public string Symbol { get; }
        public string DisplayName { get; }
        public string[] Aliases { get; }
        public UnitConverterDimensions Dimensions { get; }
        public UnitConverterProvenance Provenance { get; }
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
        public abstract UnitConverterDimensions Dimensions { get; }
        public abstract bool HasUniformDimensions { get; }
        public abstract Type UnitType { get; }
        public abstract IReadOnlyList<UnitConverterUnitDescriptor> Units { get; }

        public abstract UnitConverterUnitResolution ResolveUnit(string text, out object unit);
        public abstract double Convert(double value, object from, object to);
    }

    public sealed class UnitConverterFamilyDescriptor<TUnit> : UnitConverterFamilyDescriptor
        where TUnit : struct
    {
        private readonly Func<double, TUnit, TUnit, double> _convert;
        private readonly Func<TUnit, global::UnitConverter.UnitConverterRational> _getExactScale;
        private readonly UnitConverterUnitDescriptor[] _units;
        private readonly Dictionary<TUnit, UnitConverterUnitDescriptor> _unitsByValue;
        private readonly Dictionary<string, TUnit> _exactAliases;
        private readonly Dictionary<string, TUnit> _ignoreCaseAliases;
        private readonly HashSet<string> _ambiguousExactAliases;
        private readonly HashSet<string> _ambiguousIgnoreCaseAliases;
        private readonly UnitConverterDimensions _dimensions;
        private readonly bool _hasUniformDimensions;

        internal UnitConverterFamilyDescriptor(
            UnitConverterFamily family,
            string name,
            string baseUnitName,
            Func<TUnit, string> getSymbol,
            Func<TUnit, string> getDisplayName,
            Func<double, TUnit, TUnit, double> convert,
            Func<TUnit, string[]> getAliases,
            Func<TUnit, UnitConverterDimensions> getDimensions,
            Func<TUnit, global::UnitConverter.UnitConverterRational> getExactScale)
            : base(family, name, baseUnitName)
        {
            if (!typeof(TUnit).IsEnum)
            {
                throw new InvalidOperationException(typeof(TUnit).FullName + " must be an enum.");
            }

            _convert = convert ?? throw new ArgumentNullException(nameof(convert));
            _getExactScale = getExactScale;
            _unitsByValue = new Dictionary<TUnit, UnitConverterUnitDescriptor>();
            _exactAliases = new Dictionary<string, TUnit>(StringComparer.Ordinal);
            _ignoreCaseAliases = new Dictionary<string, TUnit>(StringComparer.OrdinalIgnoreCase);
            _ambiguousExactAliases = new HashSet<string>(StringComparer.Ordinal);
            _ambiguousIgnoreCaseAliases = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var units = new List<UnitConverterUnitDescriptor>();
            UnitConverterDimensions? firstDimensions = null;
            bool uniformDimensions = true;

            foreach (TUnit unit in UnitConverterUnitValues.GetValues<TUnit>())
            {
                string enumName = unit.ToString();
                string symbol = getSymbol == null ? null : getSymbol(unit);
                string displayName = getDisplayName == null ? null : getDisplayName(unit);
                string[] additionalAliases = getAliases == null ? null : getAliases(unit);
                string[] generatedAliases = UnitConverterAliases.GetAliases(family, enumName);

                string[] acceptedAliases = BuildAcceptedAliases(
                    enumName,
                    symbol,
                    displayName,
                    generatedAliases,
                    additionalAliases,
                    UnitConverterAliasVariants.GetNotationVariants(symbol));

                UnitConverterDimensions unitDimensions =
                    getDimensions == null
                        ? UnitConverterDimensions.ForFamily(family)
                        : getDimensions(unit);

                if (!firstDimensions.HasValue)
                {
                    firstDimensions = unitDimensions;
                }
                else if (firstDimensions.Value != unitDimensions)
                {
                    uniformDimensions = false;
                }

                var unitDescriptor = new UnitConverterUnitDescriptor(
                    unit,
                    enumName,
                    symbol,
                    displayName,
                    acceptedAliases,
                    unitDimensions,
                    UnitConverterProvenanceCatalog.Get(family, enumName));

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
            _dimensions = firstDimensions ?? UnitConverterDimensions.Dimensionless;
            _hasUniformDimensions = uniformDimensions;
        }

        public override UnitConverterDimensions Dimensions => _dimensions;
        public override bool HasUniformDimensions => _hasUniformDimensions;
        public override Type UnitType => typeof(TUnit);
        public override IReadOnlyList<UnitConverterUnitDescriptor> Units => _units;

        public bool TryResolveUnit(string text, out TUnit unit)
        {
            return ResolveUnit(text, out unit) == UnitConverterUnitResolution.Resolved;
        }

        public UnitConverterUnitResolution ResolveUnit(string text, out TUnit unit)
        {
            unit = default(TUnit);

            if (string.IsNullOrWhiteSpace(text))
            {
                return UnitConverterUnitResolution.Unknown;
            }

            string candidate = text.Trim();

            if (_ambiguousExactAliases.Contains(candidate))
            {
                return UnitConverterUnitResolution.Ambiguous;
            }

            if (_exactAliases.TryGetValue(candidate, out unit))
            {
                return UnitConverterUnitResolution.Resolved;
            }

            if (_ambiguousIgnoreCaseAliases.Contains(candidate))
            {
                return UnitConverterUnitResolution.Ambiguous;
            }

            if (_ignoreCaseAliases.TryGetValue(candidate, out unit))
            {
                return UnitConverterUnitResolution.Resolved;
            }

            return UnitConverterUnitResolution.Unknown;
        }

        public double Convert(double value, TUnit from, TUnit to)
        {
            return _convert(value, from, to);
        }

        internal bool TryGetExactScale(
            TUnit unit,
            out global::UnitConverter.UnitConverterRational scale)
        {
            if (_getExactScale == null)
            {
                scale = global::UnitConverter.UnitConverterRational.Zero;
                return false;
            }

            GetUnit(unit);
            scale = _getExactScale(unit);
            return true;
        }

        public UnitConverterUnitDescriptor GetUnit(TUnit unit)
        {
            UnitConverterUnitDescriptor descriptor;
            if (!TryGetUnit(unit, out descriptor))
            {
                throw new ArgumentOutOfRangeException(nameof(unit), unit, "Unsupported unit.");
            }

            return descriptor;
        }

        public bool TryGetUnit(TUnit unit, out UnitConverterUnitDescriptor descriptor)
        {
            return _unitsByValue.TryGetValue(unit, out descriptor);
        }

        public override UnitConverterUnitResolution ResolveUnit(string text, out object unit)
        {
            TUnit typedUnit;
            UnitConverterUnitResolution resolution = ResolveUnit(text, out typedUnit);
            unit = resolution == UnitConverterUnitResolution.Resolved
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

    public static partial class UnitConverterCatalog
    {
        private static readonly UnitConverterFamilyDescriptor[] CoreFamilyDescriptors =
        {
                Create<UnitConverter.Acceleration.UnitConverterAccelerationUnit>(UnitConverterFamily.Acceleration, "Acceleration", "MeterPerSecondSquared", UnitConverter.Acceleration.UnitConverterAcceleration.GetSymbol, UnitConverter.Acceleration.UnitConverterAcceleration.GetDisplayName, UnitConverter.Acceleration.UnitConverterAcceleration.Convert),
                Create<UnitConverter.ActivityConcentration.UnitConverterActivityConcentrationUnit>(UnitConverterFamily.ActivityConcentration, "ActivityConcentration", "BecquerelPerCubicMeter", UnitConverter.ActivityConcentration.UnitConverterActivityConcentration.GetSymbol, UnitConverter.ActivityConcentration.UnitConverterActivityConcentration.GetDisplayName, UnitConverter.ActivityConcentration.UnitConverterActivityConcentration.Convert),
                Create<UnitConverter.AmountOfSubstance.UnitConverterAmountOfSubstanceUnit>(UnitConverterFamily.AmountOfSubstance, "AmountOfSubstance", "Mole", UnitConverter.AmountOfSubstance.UnitConverterAmountOfSubstance.GetSymbol, UnitConverter.AmountOfSubstance.UnitConverterAmountOfSubstance.GetDisplayName, UnitConverter.AmountOfSubstance.UnitConverterAmountOfSubstance.Convert),
                Create<UnitConverter.Angle.UnitConverterAngleUnit>(UnitConverterFamily.Angle, "Angle", "Degree", UnitConverter.Angle.UnitConverterAngle.GetSymbol, UnitConverter.Angle.UnitConverterAngle.GetDisplayName, UnitConverter.Angle.UnitConverterAngle.Convert),
                Create<UnitConverter.AngularAcceleration.UnitConverterAngularAccelerationUnit>(UnitConverterFamily.AngularAcceleration, "AngularAcceleration", "RadianPerSecondSquared", UnitConverter.AngularAcceleration.UnitConverterAngularAcceleration.GetSymbol, UnitConverter.AngularAcceleration.UnitConverterAngularAcceleration.GetDisplayName, UnitConverter.AngularAcceleration.UnitConverterAngularAcceleration.Convert),
                Create<UnitConverter.AngularMomentum.UnitConverterAngularMomentumUnit>(UnitConverterFamily.AngularMomentum, "AngularMomentum", "KilogramSquareMeterPerSecond", UnitConverter.AngularMomentum.UnitConverterAngularMomentum.GetSymbol, UnitConverter.AngularMomentum.UnitConverterAngularMomentum.GetDisplayName, UnitConverter.AngularMomentum.UnitConverterAngularMomentum.Convert),
                Create<UnitConverter.AngularVelocity.UnitConverterAngularVelocityUnit>(UnitConverterFamily.AngularVelocity, "AngularVelocity", "RadianPerSecond", UnitConverter.AngularVelocity.UnitConverterAngularVelocity.GetSymbol, UnitConverter.AngularVelocity.UnitConverterAngularVelocity.GetDisplayName, UnitConverter.AngularVelocity.UnitConverterAngularVelocity.Convert),
                Create<UnitConverter.Area.UnitConverterAreaUnit>(UnitConverterFamily.Area, "Area", "SquareMeter", UnitConverter.Area.UnitConverterArea.GetSymbol, UnitConverter.Area.UnitConverterArea.GetDisplayName, UnitConverter.Area.UnitConverterArea.Convert),
                Create<UnitConverter.AreaDensity.UnitConverterAreaDensityUnit>(UnitConverterFamily.AreaDensity, "AreaDensity", "KilogramPerSquareMeter", UnitConverter.AreaDensity.UnitConverterAreaDensity.GetSymbol, UnitConverter.AreaDensity.UnitConverterAreaDensity.GetDisplayName, UnitConverter.AreaDensity.UnitConverterAreaDensity.Convert),
                Create<UnitConverter.Capacitance.UnitConverterCapacitanceUnit>(UnitConverterFamily.Capacitance, "Capacitance", "Farad", UnitConverter.Capacitance.UnitConverterCapacitance.GetSymbol, UnitConverter.Capacitance.UnitConverterCapacitance.GetDisplayName, UnitConverter.Capacitance.UnitConverterCapacitance.Convert),
                Create<UnitConverter.ChargeDensity.UnitConverterChargeDensityUnit>(UnitConverterFamily.ChargeDensity, "ChargeDensity", "CoulombPerCubicMeter", UnitConverter.ChargeDensity.UnitConverterChargeDensity.GetSymbol, UnitConverter.ChargeDensity.UnitConverterChargeDensity.GetDisplayName, UnitConverter.ChargeDensity.UnitConverterChargeDensity.Convert),
                Create<UnitConverter.Compressibility.UnitConverterCompressibilityUnit>(UnitConverterFamily.Compressibility, "Compressibility", "PerPascal", UnitConverter.Compressibility.UnitConverterCompressibility.GetSymbol, UnitConverter.Compressibility.UnitConverterCompressibility.GetDisplayName, UnitConverter.Compressibility.UnitConverterCompressibility.Convert),
                Create<UnitConverter.Conductance.UnitConverterConductanceUnit>(UnitConverterFamily.Conductance, "Conductance", "Siemens", UnitConverter.Conductance.UnitConverterConductance.GetSymbol, UnitConverter.Conductance.UnitConverterConductance.GetDisplayName, UnitConverter.Conductance.UnitConverterConductance.Convert),
                Create<UnitConverter.Current.UnitConverterCurrentUnit>(UnitConverterFamily.Current, "Current", "Ampere", UnitConverter.Current.UnitConverterCurrent.GetSymbol, UnitConverter.Current.UnitConverterCurrent.GetDisplayName, UnitConverter.Current.UnitConverterCurrent.Convert),
                Create<UnitConverter.CurrentDensity.UnitConverterCurrentDensityUnit>(UnitConverterFamily.CurrentDensity, "CurrentDensity", "AmperePerSquareMeter", UnitConverter.CurrentDensity.UnitConverterCurrentDensity.GetSymbol, UnitConverter.CurrentDensity.UnitConverterCurrentDensity.GetDisplayName, UnitConverter.CurrentDensity.UnitConverterCurrentDensity.Convert),
                Create<UnitConverter.DataRate.UnitConverterDataRateUnit>(UnitConverterFamily.DataRate, "DataRate", "BitPerSecond", UnitConverter.DataRate.UnitConverterDataRate.GetSymbol, UnitConverter.DataRate.UnitConverterDataRate.GetDisplayName, UnitConverter.DataRate.UnitConverterDataRate.Convert),
                Create<UnitConverter.Density.UnitConverterDensityUnit>(UnitConverterFamily.Density, "Density", "KilogramPerCubicMeter", UnitConverter.Density.UnitConverterDensity.GetSymbol, UnitConverter.Density.UnitConverterDensity.GetDisplayName, UnitConverter.Density.UnitConverterDensity.Convert),
                Create<UnitConverter.DiffusionCoefficient.UnitConverterDiffusionCoefficientUnit>(UnitConverterFamily.DiffusionCoefficient, "DiffusionCoefficient", "SquareMeterPerSecond", UnitConverter.DiffusionCoefficient.UnitConverterDiffusionCoefficient.GetSymbol, UnitConverter.DiffusionCoefficient.UnitConverterDiffusionCoefficient.GetDisplayName, UnitConverter.DiffusionCoefficient.UnitConverterDiffusionCoefficient.Convert),
                Create<UnitConverter.DigitalStorage.UnitConverterDigitalStorageUnit>(UnitConverterFamily.DigitalStorage, "DigitalStorage", "Byte", UnitConverter.DigitalStorage.UnitConverterDigitalStorage.GetSymbol, UnitConverter.DigitalStorage.UnitConverterDigitalStorage.GetDisplayName, UnitConverter.DigitalStorage.UnitConverterDigitalStorage.Convert),
                Create<UnitConverter.DoseRate.UnitConverterDoseRateUnit>(UnitConverterFamily.DoseRate, "DoseRate", "GrayPerSecond", UnitConverter.DoseRate.UnitConverterDoseRate.GetSymbol, UnitConverter.DoseRate.UnitConverterDoseRate.GetDisplayName, UnitConverter.DoseRate.UnitConverterDoseRate.Convert),
                Create<UnitConverter.DynamicPressure.UnitConverterDynamicPressureUnit>(UnitConverterFamily.DynamicPressure, "DynamicPressure", "Pascal", UnitConverter.DynamicPressure.UnitConverterDynamicPressure.GetSymbol, UnitConverter.DynamicPressure.UnitConverterDynamicPressure.GetDisplayName, UnitConverter.DynamicPressure.UnitConverterDynamicPressure.Convert),
                Create<UnitConverter.DynamicViscosity.UnitConverterDynamicViscosityUnit>(UnitConverterFamily.DynamicViscosity, "DynamicViscosity", "PascalSecond", UnitConverter.DynamicViscosity.UnitConverterDynamicViscosity.GetSymbol, UnitConverter.DynamicViscosity.UnitConverterDynamicViscosity.GetDisplayName, UnitConverter.DynamicViscosity.UnitConverterDynamicViscosity.Convert),
                Create<UnitConverter.ElectricCharge.UnitConverterElectricChargeUnit>(UnitConverterFamily.ElectricCharge, "ElectricCharge", "Coulomb", UnitConverter.ElectricCharge.UnitConverterElectricCharge.GetSymbol, UnitConverter.ElectricCharge.UnitConverterElectricCharge.GetDisplayName, UnitConverter.ElectricCharge.UnitConverterElectricCharge.Convert),
                Create<UnitConverter.ElectricFieldStrength.UnitConverterElectricFieldStrengthUnit>(UnitConverterFamily.ElectricFieldStrength, "ElectricFieldStrength", "VoltPerMeter", UnitConverter.ElectricFieldStrength.UnitConverterElectricFieldStrength.GetSymbol, UnitConverter.ElectricFieldStrength.UnitConverterElectricFieldStrength.GetDisplayName, UnitConverter.ElectricFieldStrength.UnitConverterElectricFieldStrength.Convert),
                Create<UnitConverter.ElectricFlux.UnitConverterElectricFluxUnit>(UnitConverterFamily.ElectricFlux, "ElectricFlux", "VoltMeter", UnitConverter.ElectricFlux.UnitConverterElectricFlux.GetSymbol, UnitConverter.ElectricFlux.UnitConverterElectricFlux.GetDisplayName, UnitConverter.ElectricFlux.UnitConverterElectricFlux.Convert),
                Create<UnitConverter.ElectricFluxDensity.UnitConverterElectricFluxDensityUnit>(UnitConverterFamily.ElectricFluxDensity, "ElectricFluxDensity", "CoulombPerSquareMeter", UnitConverter.ElectricFluxDensity.UnitConverterElectricFluxDensity.GetSymbol, UnitConverter.ElectricFluxDensity.UnitConverterElectricFluxDensity.GetDisplayName, UnitConverter.ElectricFluxDensity.UnitConverterElectricFluxDensity.Convert),
                Create<UnitConverter.ElectricResistance.UnitConverterElectricResistanceUnit>(UnitConverterFamily.ElectricResistance, "ElectricResistance", "Ohm", UnitConverter.ElectricResistance.UnitConverterElectricResistance.GetSymbol, UnitConverter.ElectricResistance.UnitConverterElectricResistance.GetDisplayName, UnitConverter.ElectricResistance.UnitConverterElectricResistance.Convert),
                Create<UnitConverter.ElectricalConductivity.UnitConverterElectricalConductivityUnit>(UnitConverterFamily.ElectricalConductivity, "ElectricalConductivity", "SiemensPerMeter", UnitConverter.ElectricalConductivity.UnitConverterElectricalConductivity.GetSymbol, UnitConverter.ElectricalConductivity.UnitConverterElectricalConductivity.GetDisplayName, UnitConverter.ElectricalConductivity.UnitConverterElectricalConductivity.Convert),
                Create<UnitConverter.ElectricalResistivity.UnitConverterElectricalResistivityUnit>(UnitConverterFamily.ElectricalResistivity, "ElectricalResistivity", "OhmMeter", UnitConverter.ElectricalResistivity.UnitConverterElectricalResistivity.GetSymbol, UnitConverter.ElectricalResistivity.UnitConverterElectricalResistivity.GetDisplayName, UnitConverter.ElectricalResistivity.UnitConverterElectricalResistivity.Convert),
                Create<UnitConverter.Energy.UnitConverterEnergyUnit>(UnitConverterFamily.Energy, "Energy", "Joule", UnitConverter.Energy.UnitConverterEnergy.GetSymbol, UnitConverter.Energy.UnitConverterEnergy.GetDisplayName, UnitConverter.Energy.UnitConverterEnergy.Convert),
                Create<UnitConverter.EnergyDensity.UnitConverterEnergyDensityUnit>(UnitConverterFamily.EnergyDensity, "EnergyDensity", "JoulePerCubicMeter", UnitConverter.EnergyDensity.UnitConverterEnergyDensity.GetSymbol, UnitConverter.EnergyDensity.UnitConverterEnergyDensity.GetDisplayName, UnitConverter.EnergyDensity.UnitConverterEnergyDensity.Convert),
                Create<UnitConverter.ExposureRate.UnitConverterExposureRateUnit>(UnitConverterFamily.ExposureRate, "ExposureRate", "CoulombPerKilogramSecond", UnitConverter.ExposureRate.UnitConverterExposureRate.GetSymbol, UnitConverter.ExposureRate.UnitConverterExposureRate.GetDisplayName, UnitConverter.ExposureRate.UnitConverterExposureRate.Convert),
                Create<UnitConverter.Force.UnitConverterForceUnit>(UnitConverterFamily.Force, "Force", "Newton", UnitConverter.Force.UnitConverterForce.GetSymbol, UnitConverter.Force.UnitConverterForce.GetDisplayName, UnitConverter.Force.UnitConverterForce.Convert),
                Create<UnitConverter.ForcePerLength.UnitConverterForcePerLengthUnit>(UnitConverterFamily.ForcePerLength, "ForcePerLength", "NewtonPerMeter", UnitConverter.ForcePerLength.UnitConverterForcePerLength.GetSymbol, UnitConverter.ForcePerLength.UnitConverterForcePerLength.GetDisplayName, UnitConverter.ForcePerLength.UnitConverterForcePerLength.Convert),
                Create<UnitConverter.FrameRate.UnitConverterFrameRateUnit>(UnitConverterFamily.FrameRate, "FrameRate", "FramePerSecond", UnitConverter.FrameRate.UnitConverterFrameRate.GetSymbol, UnitConverter.FrameRate.UnitConverterFrameRate.GetDisplayName, UnitConverter.FrameRate.UnitConverterFrameRate.Convert),
                Create<UnitConverter.Frequency.UnitConverterFrequencyUnit>(UnitConverterFamily.Frequency, "Frequency", "Hertz", UnitConverter.Frequency.UnitConverterFrequency.GetSymbol, UnitConverter.Frequency.UnitConverterFrequency.GetDisplayName, UnitConverter.Frequency.UnitConverterFrequency.Convert),