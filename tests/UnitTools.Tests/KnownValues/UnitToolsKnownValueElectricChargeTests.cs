namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.ElectricCharge;

    public sealed class UnitToolsKnownValueElectricChargeTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricCharge_ToBaseUnit_ReturnsExpectedValue(UnitToolsElectricChargeUnit unit, double input, double expected)
        {
            double result = UnitToolsElectricCharge.ToCoulomb(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void ElectricCharge_FromBaseUnit_ReturnsExpectedValue(UnitToolsElectricChargeUnit unit, double input, double expected)
        {
            double result = UnitToolsElectricCharge.FromCoulomb(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void ElectricCharge_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsElectricChargeUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsElectricCharge.ToCoulomb(input, unit);
            double result = UnitToolsElectricCharge.FromCoulomb(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Nanocoulomb, 1d, 1.0000000000000001e-09d).SetName("ElectricCharge_ToBase_Nanocoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Microcoulomb, 1d, 9.9999999999999995e-07d).SetName("ElectricCharge_ToBase_Microcoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Millicoulomb, 1d, 0.001d).SetName("ElectricCharge_ToBase_Millicoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Coulomb, 1d, 1.0d).SetName("ElectricCharge_ToBase_Coulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Kilocoulomb, 1d, 1000.0d).SetName("ElectricCharge_ToBase_Kilocoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.AmpereHour, 1d, 3600.0d).SetName("ElectricCharge_ToBase_AmpereHour");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.MilliampereHour, 1d, 3.6000000000000001d).SetName("ElectricCharge_ToBase_MilliampereHour");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Faraday, 1d, 96485.332123310014d).SetName("ElectricCharge_ToBase_Faraday");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.ElementaryCharge, 1d, 1.6021766339999999e-19d).SetName("ElectricCharge_ToBase_ElementaryCharge");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Femtocoulomb, 1d, 1.0000000000000001e-15d).SetName("ElectricCharge_ToBase_Femtocoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Picocoulomb, 1d, 9.9999999999999998e-13d).SetName("ElectricCharge_ToBase_Picocoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Megacoulomb, 1d, 1000000.0d).SetName("ElectricCharge_ToBase_Megacoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Gigacoulomb, 1d, 1000000000.0d).SetName("ElectricCharge_ToBase_Gigacoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Statcoulomb, 1d, 3.3356409519815202e-10d).SetName("ElectricCharge_ToBase_Statcoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Franklin, 1d, 3.3356409519815202e-10d).SetName("ElectricCharge_ToBase_Franklin");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Abcoulomb, 1d, 10.0d).SetName("ElectricCharge_ToBase_Abcoulomb");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Nanocoulomb, 1d, 999999999.99999988d).SetName("ElectricCharge_FromBase_Nanocoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Microcoulomb, 1d, 1000000.0d).SetName("ElectricCharge_FromBase_Microcoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Millicoulomb, 1d, 1000.0d).SetName("ElectricCharge_FromBase_Millicoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Coulomb, 1d, 1.0d).SetName("ElectricCharge_FromBase_Coulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Kilocoulomb, 1d, 0.001d).SetName("ElectricCharge_FromBase_Kilocoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.AmpereHour, 1d, 0.00027777777777777778d).SetName("ElectricCharge_FromBase_AmpereHour");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.MilliampereHour, 1d, 0.27777777777777779d).SetName("ElectricCharge_FromBase_MilliampereHour");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Faraday, 1d, 1.0364269656262175e-05d).SetName("ElectricCharge_FromBase_Faraday");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.ElementaryCharge, 1d, 6.2415090744607631e+18d).SetName("ElectricCharge_FromBase_ElementaryCharge");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Femtocoulomb, 1d, 999999999999999.88d).SetName("ElectricCharge_FromBase_Femtocoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Picocoulomb, 1d, 1000000000000.0d).SetName("ElectricCharge_FromBase_Picocoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Megacoulomb, 1d, 9.9999999999999995e-07d).SetName("ElectricCharge_FromBase_Megacoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Gigacoulomb, 1d, 1.0000000000000001e-09d).SetName("ElectricCharge_FromBase_Gigacoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Statcoulomb, 1d, 2997924580.0000005d).SetName("ElectricCharge_FromBase_Statcoulomb");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Franklin, 1d, 2997924580.0000005d).SetName("ElectricCharge_FromBase_Franklin");
            yield return new TestCaseData(UnitToolsElectricChargeUnit.Abcoulomb, 1d, 0.10000000000000001d).SetName("ElectricCharge_FromBase_Abcoulomb");
        }
    }
}
