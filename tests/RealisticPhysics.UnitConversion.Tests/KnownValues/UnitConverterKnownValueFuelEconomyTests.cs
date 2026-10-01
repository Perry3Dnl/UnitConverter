namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.FuelEconomy;

    public sealed class UnitConverterKnownValueFuelEconomyTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void FuelEconomy_ToBaseUnit_ReturnsExpectedValue(UnitConverterFuelEconomyUnit unit, double input, double expected)
        {
            double result = UnitConverterFuelEconomy.ToKilometerPerLiter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void FuelEconomy_FromBaseUnit_ReturnsExpectedValue(UnitConverterFuelEconomyUnit unit, double input, double expected)
        {
            double result = UnitConverterFuelEconomy.FromKilometerPerLiter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void FuelEconomy_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterFuelEconomyUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterFuelEconomy.ToKilometerPerLiter(input, unit);
            double result = UnitConverterFuelEconomy.FromKilometerPerLiter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.KilometerPerLiter, 10.0d, 10.0d).SetName("FuelEconomy_ToBase_KilometerPerLiter");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.LiterPer100Kilometer, 5.0d, 20.0d).SetName("FuelEconomy_ToBase_LiterPer100Kilometer");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.MilePerUSGallon, 30.0d, 12.754311222908161d).SetName("FuelEconomy_ToBase_MilePerUSGallon");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.MilePerImperialGallon, 30.0d, 10.620185698039414d).SetName("FuelEconomy_ToBase_MilePerImperialGallon");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.LiterPerKilometer, 0.10000000000000001d, 10.0d).SetName("FuelEconomy_ToBase_LiterPerKilometer");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.LiterPerMile, 0.20000000000000001d, 8.0467200000000005d).SetName("FuelEconomy_ToBase_LiterPerMile");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.USGallonPerMile, 0.050000000000000003d, 8.5028741486054411d).SetName("FuelEconomy_ToBase_USGallonPerMile");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.ImperialGallonPerMile, 0.050000000000000003d, 7.0801237986929424d).SetName("FuelEconomy_ToBase_ImperialGallonPerMile");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.MilePerLiter, 10.0d, 16.093440000000001d).SetName("FuelEconomy_ToBase_MilePerLiter");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.NauticalMilePerUSGallon, 10.0d, 4.8924664096729087d).SetName("FuelEconomy_ToBase_NauticalMilePerUSGallon");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.MeterPerLiter, 10000.0d, 10.0d).SetName("FuelEconomy_ToBase_MeterPerLiter");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.KilometerPerUSGallon, 40.0d, 10.566882094325937d).SetName("FuelEconomy_ToBase_KilometerPerUSGallon");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.KilometerPerImperialGallon, 40.0d, 8.7987699319635109d).SetName("FuelEconomy_ToBase_KilometerPerImperialGallon");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.NauticalMilePerImperialGallon, 10.0d, 4.0738304784991053d).SetName("FuelEconomy_ToBase_NauticalMilePerImperialGallon");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.MilliliterPerKilometer, 100.0d, 10.0d).SetName("FuelEconomy_ToBase_MilliliterPerKilometer");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.LiterPer10Kilometer, 1.0d, 10.0d).SetName("FuelEconomy_ToBase_LiterPer10Kilometer");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.LiterPer100Mile, 20.0d, 8.0467200000000005d).SetName("FuelEconomy_ToBase_LiterPer100Mile");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.USGallonPer100Mile, 5.0d, 8.5028741486054411d).SetName("FuelEconomy_ToBase_USGallonPer100Mile");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.ImperialGallonPer100Mile, 5.0d, 7.0801237986929433d).SetName("FuelEconomy_ToBase_ImperialGallonPer100Mile");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.USGallonPer100Kilometer, 5.0d, 5.2834410471629685d).SetName("FuelEconomy_ToBase_USGallonPer100Kilometer");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.ImperialGallonPer100Kilometer, 5.0d, 4.3993849659817554d).SetName("FuelEconomy_ToBase_ImperialGallonPer100Kilometer");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.KilometerPerMilliliter, 0.01d, 10.0d).SetName("FuelEconomy_ToBase_KilometerPerMilliliter");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.MeterPerMilliliter, 10.0d, 10.0d).SetName("FuelEconomy_ToBase_MeterPerMilliliter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.KilometerPerLiter, 12.5d, 12.5d).SetName("FuelEconomy_FromBase_KilometerPerLiter");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.LiterPer100Kilometer, 12.5d, 8.0d).SetName("FuelEconomy_FromBase_LiterPer100Kilometer");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.MilePerUSGallon, 12.5d, 29.401822916666664d).SetName("FuelEconomy_FromBase_MilePerUSGallon");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.MilePerImperialGallon, 12.5d, 35.310117041477767d).SetName("FuelEconomy_FromBase_MilePerImperialGallon");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.LiterPerKilometer, 12.5d, 0.080000000000000002d).SetName("FuelEconomy_FromBase_LiterPerKilometer");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.LiterPerMile, 12.5d, 0.12874752d).SetName("FuelEconomy_FromBase_LiterPerMile");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.USGallonPerMile, 12.5d, 0.034011496594421764d).SetName("FuelEconomy_FromBase_USGallonPerMile");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.ImperialGallonPerMile, 12.5d, 0.028320495194771769d).SetName("FuelEconomy_FromBase_ImperialGallonPerMile");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.MilePerLiter, 12.5d, 7.7671399029666741d).SetName("FuelEconomy_FromBase_MilePerLiter");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.NauticalMilePerUSGallon, 12.5d, 25.549485583153345d).SetName("FuelEconomy_FromBase_NauticalMilePerUSGallon");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.MeterPerLiter, 12.5d, 12500.0d).SetName("FuelEconomy_FromBase_MeterPerLiter");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.KilometerPerUSGallon, 12.5d, 47.317647299999997d).SetName("FuelEconomy_FromBase_KilometerPerUSGallon");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.KilometerPerImperialGallon, 12.5d, 56.826125000000005d).SetName("FuelEconomy_FromBase_KilometerPerImperialGallon");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.NauticalMilePerImperialGallon, 12.5d, 30.683652807775378d).SetName("FuelEconomy_FromBase_NauticalMilePerImperialGallon");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.MilliliterPerKilometer, 12.5d, 80.0d).SetName("FuelEconomy_FromBase_MilliliterPerKilometer");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.LiterPer10Kilometer, 12.5d, 0.80000000000000004d).SetName("FuelEconomy_FromBase_LiterPer10Kilometer");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.LiterPer100Mile, 12.5d, 12.874752000000001d).SetName("FuelEconomy_FromBase_LiterPer100Mile");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.USGallonPer100Mile, 12.5d, 3.4011496594421766d).SetName("FuelEconomy_FromBase_USGallonPer100Mile");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.ImperialGallonPer100Mile, 12.5d, 2.8320495194771769d).SetName("FuelEconomy_FromBase_ImperialGallonPer100Mile");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.USGallonPer100Kilometer, 12.5d, 2.1133764188651876d).SetName("FuelEconomy_FromBase_USGallonPer100Kilometer");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.ImperialGallonPer100Kilometer, 12.5d, 1.7597539863927021d).SetName("FuelEconomy_FromBase_ImperialGallonPer100Kilometer");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.KilometerPerMilliliter, 12.5d, 0.012500000000000001d).SetName("FuelEconomy_FromBase_KilometerPerMilliliter");
            yield return new TestCaseData(UnitConverterFuelEconomyUnit.MeterPerMilliliter, 12.5d, 12.5d).SetName("FuelEconomy_FromBase_MeterPerMilliliter");
        }
    }
}
