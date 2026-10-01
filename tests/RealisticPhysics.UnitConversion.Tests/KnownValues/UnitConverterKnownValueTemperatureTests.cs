namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.Temperature;

    public sealed class UnitConverterKnownValueTemperatureTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Temperature_ToBaseUnit_ReturnsExpectedValue(UnitConverterTemperatureUnit unit, double input, double expected)
        {
            double result = UnitConverterTemperature.ToKelvin(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Temperature_FromBaseUnit_ReturnsExpectedValue(UnitConverterTemperatureUnit unit, double input, double expected)
        {
            double result = UnitConverterTemperature.FromKelvin(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Temperature_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterTemperatureUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterTemperature.ToKelvin(input, unit);
            double result = UnitConverterTemperature.FromKelvin(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterTemperatureUnit.Kelvin, 1d, 1.0d).SetName("Temperature_ToBase_Kelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Celsius, 1d, 274.14999999999998d).SetName("Temperature_ToBase_Celsius");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Fahrenheit, 1d, 255.92777777777778d).SetName("Temperature_ToBase_Fahrenheit");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Rankine, 1d, 0.55555555555555558d).SetName("Temperature_ToBase_Rankine");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Delisle, 1d, 372.48333333333329d).SetName("Temperature_ToBase_Delisle");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Newton, 1d, 276.18030303030298d).SetName("Temperature_ToBase_Newton");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Reaumur, 1d, 274.39999999999998d).SetName("Temperature_ToBase_Reaumur");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Romer, 1d, 260.76904761904757d).SetName("Temperature_ToBase_Romer");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Millikelvin, 1d, 0.001d).SetName("Temperature_ToBase_Millikelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Microkelvin, 1d, 9.9999999999999995e-07d).SetName("Temperature_ToBase_Microkelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Nanokelvin, 1d, 1.0000000000000001e-09d).SetName("Temperature_ToBase_Nanokelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Kilokelvin, 1d, 1000.0d).SetName("Temperature_ToBase_Kilokelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Megakelvin, 1d, 1000000.0d).SetName("Temperature_ToBase_Megakelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Gigakelvin, 1d, 1000000000.0d).SetName("Temperature_ToBase_Gigakelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.PlanckTemperature, 1d, 1.416784e+32d).SetName("Temperature_ToBase_PlanckTemperature");
            yield return new TestCaseData(UnitConverterTemperatureUnit.ElectronVoltTemperature, 1d, 11604.518121550082d).SetName("Temperature_ToBase_ElectronVoltTemperature");
            yield return new TestCaseData(UnitConverterTemperatureUnit.MillielectronVoltTemperature, 1d, 11.604518121550083d).SetName("Temperature_ToBase_MillielectronVoltTemperature");
            yield return new TestCaseData(UnitConverterTemperatureUnit.KiloelectronVoltTemperature, 1d, 11604518.121550081d).SetName("Temperature_ToBase_KiloelectronVoltTemperature");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterTemperatureUnit.Kelvin, 300d, 300.0d).SetName("Temperature_FromBase_Kelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Celsius, 300d, 26.850000000000023d).SetName("Temperature_FromBase_Celsius");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Fahrenheit, 300d, 80.329999999999984d).SetName("Temperature_FromBase_Fahrenheit");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Rankine, 300d, 540.0d).SetName("Temperature_FromBase_Rankine");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Delisle, 300d, 109.72499999999997d).SetName("Temperature_FromBase_Delisle");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Newton, 300d, 8.8605000000000071d).SetName("Temperature_FromBase_Newton");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Reaumur, 300d, 21.480000000000018d).SetName("Temperature_FromBase_Reaumur");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Romer, 300d, 21.596250000000012d).SetName("Temperature_FromBase_Romer");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Millikelvin, 300d, 300000.0d).SetName("Temperature_FromBase_Millikelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Microkelvin, 300d, 300000000.0d).SetName("Temperature_FromBase_Microkelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Nanokelvin, 300d, 300000000000.0d).SetName("Temperature_FromBase_Nanokelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Kilokelvin, 300d, 0.29999999999999999d).SetName("Temperature_FromBase_Kilokelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Megakelvin, 300d, 0.00029999999999999997d).SetName("Temperature_FromBase_Megakelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.Gigakelvin, 300d, 2.9999999999999999e-07d).SetName("Temperature_FromBase_Gigakelvin");
            yield return new TestCaseData(UnitConverterTemperatureUnit.PlanckTemperature, 300d, 2.1174716823453682e-30d).SetName("Temperature_FromBase_PlanckTemperature");
            yield return new TestCaseData(UnitConverterTemperatureUnit.ElectronVoltTemperature, 300d, 0.025851999786435535d).SetName("Temperature_FromBase_ElectronVoltTemperature");
            yield return new TestCaseData(UnitConverterTemperatureUnit.MillielectronVoltTemperature, 300d, 25.851999786435531d).SetName("Temperature_FromBase_MillielectronVoltTemperature");
            yield return new TestCaseData(UnitConverterTemperatureUnit.KiloelectronVoltTemperature, 300d, 2.5851999786435536e-05d).SetName("Temperature_FromBase_KiloelectronVoltTemperature");
        }
    }
}
