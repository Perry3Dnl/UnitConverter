namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.Mass;

    public sealed class UnitConverterKnownValueMassTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Mass_ToBaseUnit_ReturnsExpectedValue(UnitConverterMassUnit unit, double input, double expected)
        {
            double result = UnitConverterMass.ToKilogram(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Mass_FromBaseUnit_ReturnsExpectedValue(UnitConverterMassUnit unit, double input, double expected)
        {
            double result = UnitConverterMass.FromKilogram(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Mass_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterMassUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterMass.ToKilogram(input, unit);
            double result = UnitConverterMass.FromKilogram(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterMassUnit.Microgram, 1d, 1.0000000000000001e-09d).SetName("Mass_ToBase_Microgram");
            yield return new TestCaseData(UnitConverterMassUnit.Milligram, 1d, 9.9999999999999995e-07d).SetName("Mass_ToBase_Milligram");
            yield return new TestCaseData(UnitConverterMassUnit.Centigram, 1d, 1.0000000000000001e-05d).SetName("Mass_ToBase_Centigram");
            yield return new TestCaseData(UnitConverterMassUnit.Decigram, 1d, 0.0001d).SetName("Mass_ToBase_Decigram");
            yield return new TestCaseData(UnitConverterMassUnit.Gram, 1d, 0.001d).SetName("Mass_ToBase_Gram");
            yield return new TestCaseData(UnitConverterMassUnit.Decagram, 1d, 0.01d).SetName("Mass_ToBase_Decagram");
            yield return new TestCaseData(UnitConverterMassUnit.Hectogram, 1d, 0.10000000000000001d).SetName("Mass_ToBase_Hectogram");
            yield return new TestCaseData(UnitConverterMassUnit.Kilogram, 1d, 1.0d).SetName("Mass_ToBase_Kilogram");
            yield return new TestCaseData(UnitConverterMassUnit.MetricTon, 1d, 1000.0d).SetName("Mass_ToBase_MetricTon");
            yield return new TestCaseData(UnitConverterMassUnit.Kilotonne, 1d, 1000000.0d).SetName("Mass_ToBase_Kilotonne");
            yield return new TestCaseData(UnitConverterMassUnit.Ounce, 1d, 0.028349523125000001d).SetName("Mass_ToBase_Ounce");
            yield return new TestCaseData(UnitConverterMassUnit.Pound, 1d, 0.45359237000000002d).SetName("Mass_ToBase_Pound");
            yield return new TestCaseData(UnitConverterMassUnit.Stone, 1d, 6.3502931800000004d).SetName("Mass_ToBase_Stone");
            yield return new TestCaseData(UnitConverterMassUnit.Quarter, 1d, 12.700586360000001d).SetName("Mass_ToBase_Quarter");
            yield return new TestCaseData(UnitConverterMassUnit.HundredweightUS, 1d, 45.359237d).SetName("Mass_ToBase_HundredweightUS");
            yield return new TestCaseData(UnitConverterMassUnit.HundredweightUK, 1d, 50.802345440000003d).SetName("Mass_ToBase_HundredweightUK");
            yield return new TestCaseData(UnitConverterMassUnit.ShortTon, 1d, 907.18474000000003d).SetName("Mass_ToBase_ShortTon");
            yield return new TestCaseData(UnitConverterMassUnit.LongTon, 1d, 1016.0469088d).SetName("Mass_ToBase_LongTon");
            yield return new TestCaseData(UnitConverterMassUnit.Grain, 1d, 6.4798909999999995e-05d).SetName("Mass_ToBase_Grain");
            yield return new TestCaseData(UnitConverterMassUnit.Pennyweight, 1d, 0.0015551738400000001d).SetName("Mass_ToBase_Pennyweight");
            yield return new TestCaseData(UnitConverterMassUnit.TroyOunce, 1d, 0.031103476800000002d).SetName("Mass_ToBase_TroyOunce");
            yield return new TestCaseData(UnitConverterMassUnit.TroyPound, 1d, 0.37324172160000002d).SetName("Mass_ToBase_TroyPound");
            yield return new TestCaseData(UnitConverterMassUnit.Carat, 1d, 0.00020000000000000001d).SetName("Mass_ToBase_Carat");
            yield return new TestCaseData(UnitConverterMassUnit.Slug, 1d, 14.593902937206d).SetName("Mass_ToBase_Slug");
            yield return new TestCaseData(UnitConverterMassUnit.AtomicMassUnit, 1d, 1.6605390666e-27d).SetName("Mass_ToBase_AtomicMassUnit");
            yield return new TestCaseData(UnitConverterMassUnit.Femtogram, 1d, 1.0000000000000001e-18d).SetName("Mass_ToBase_Femtogram");
            yield return new TestCaseData(UnitConverterMassUnit.Picogram, 1d, 1.0000000000000001e-15d).SetName("Mass_ToBase_Picogram");
            yield return new TestCaseData(UnitConverterMassUnit.Nanogram, 1d, 9.9999999999999998e-13d).SetName("Mass_ToBase_Nanogram");
            yield return new TestCaseData(UnitConverterMassUnit.Megagram, 1d, 1000.0d).SetName("Mass_ToBase_Megagram");
            yield return new TestCaseData(UnitConverterMassUnit.Gigagram, 1d, 1000000.0d).SetName("Mass_ToBase_Gigagram");
            yield return new TestCaseData(UnitConverterMassUnit.Teragram, 1d, 1000000000.0d).SetName("Mass_ToBase_Teragram");
            yield return new TestCaseData(UnitConverterMassUnit.Petagram, 1d, 1000000000000.0d).SetName("Mass_ToBase_Petagram");
            yield return new TestCaseData(UnitConverterMassUnit.Megatonne, 1d, 1000000000.0d).SetName("Mass_ToBase_Megatonne");
            yield return new TestCaseData(UnitConverterMassUnit.Gigatonne, 1d, 1000000000000.0d).SetName("Mass_ToBase_Gigatonne");
            yield return new TestCaseData(UnitConverterMassUnit.Dram, 1d, 0.0017718451953125001d).SetName("Mass_ToBase_Dram");
            yield return new TestCaseData(UnitConverterMassUnit.ApothecariesScruple, 1d, 0.0012959782d).SetName("Mass_ToBase_ApothecariesScruple");
            yield return new TestCaseData(UnitConverterMassUnit.ApothecariesDram, 1d, 0.0038879346000000002d).SetName("Mass_ToBase_ApothecariesDram");
            yield return new TestCaseData(UnitConverterMassUnit.ApothecariesOunce, 1d, 0.031103476800000002d).SetName("Mass_ToBase_ApothecariesOunce");
            yield return new TestCaseData(UnitConverterMassUnit.ApothecariesPound, 1d, 0.37324172160000002d).SetName("Mass_ToBase_ApothecariesPound");
            yield return new TestCaseData(UnitConverterMassUnit.ElectronMass, 1d, 9.1093837015000008e-31d).SetName("Mass_ToBase_ElectronMass");
            yield return new TestCaseData(UnitConverterMassUnit.ProtonMass, 1d, 1.6726219236900001e-27d).SetName("Mass_ToBase_ProtonMass");
            yield return new TestCaseData(UnitConverterMassUnit.NeutronMass, 1d, 1.67492749804e-27d).SetName("Mass_ToBase_NeutronMass");
            yield return new TestCaseData(UnitConverterMassUnit.PlanckMass, 1d, 2.1764340000000001e-08d).SetName("Mass_ToBase_PlanckMass");
            yield return new TestCaseData(UnitConverterMassUnit.EarthMass, 1d, 5.9722000000000002e+24d).SetName("Mass_ToBase_EarthMass");
            yield return new TestCaseData(UnitConverterMassUnit.JupiterMass, 1d, 1.89813e+27d).SetName("Mass_ToBase_JupiterMass");
            yield return new TestCaseData(UnitConverterMassUnit.SolarMass, 1d, 1.98847e+30d).SetName("Mass_ToBase_SolarMass");
            yield return new TestCaseData(UnitConverterMassUnit.Shekel, 1d, 0.0114d).SetName("Mass_ToBase_Shekel");
            yield return new TestCaseData(UnitConverterMassUnit.Mina, 1d, 0.5d).SetName("Mass_ToBase_Mina");
            yield return new TestCaseData(UnitConverterMassUnit.Talent, 1d, 26.0d).SetName("Mass_ToBase_Talent");
            yield return new TestCaseData(UnitConverterMassUnit.Mark, 1d, 0.24879999999999999d).SetName("Mass_ToBase_Mark");
            yield return new TestCaseData(UnitConverterMassUnit.Oka, 1d, 1.2828999999999999d).SetName("Mass_ToBase_Oka");
            yield return new TestCaseData(UnitConverterMassUnit.Catty, 1d, 0.60478982000000003d).SetName("Mass_ToBase_Catty");
            yield return new TestCaseData(UnitConverterMassUnit.Tael, 1d, 0.037799399999999997d).SetName("Mass_ToBase_Tael");
            yield return new TestCaseData(UnitConverterMassUnit.Momme, 1d, 0.0037499999999999999d).SetName("Mass_ToBase_Momme");
            yield return new TestCaseData(UnitConverterMassUnit.PlanckMassGram, 1d, 2.1764339999999999e-11d).SetName("Mass_ToBase_PlanckMassGram");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterMassUnit.Microgram, 1d, 999999999.99999988d).SetName("Mass_FromBase_Microgram");
            yield return new TestCaseData(UnitConverterMassUnit.Milligram, 1d, 1000000.0d).SetName("Mass_FromBase_Milligram");
            yield return new TestCaseData(UnitConverterMassUnit.Centigram, 1d, 99999.999999999985d).SetName("Mass_FromBase_Centigram");
            yield return new TestCaseData(UnitConverterMassUnit.Decigram, 1d, 10000.0d).SetName("Mass_FromBase_Decigram");
            yield return new TestCaseData(UnitConverterMassUnit.Gram, 1d, 1000.0d).SetName("Mass_FromBase_Gram");
            yield return new TestCaseData(UnitConverterMassUnit.Decagram, 1d, 100.0d).SetName("Mass_FromBase_Decagram");
            yield return new TestCaseData(UnitConverterMassUnit.Hectogram, 1d, 10.0d).SetName("Mass_FromBase_Hectogram");
            yield return new TestCaseData(UnitConverterMassUnit.Kilogram, 1d, 1.0d).SetName("Mass_FromBase_Kilogram");
            yield return new TestCaseData(UnitConverterMassUnit.MetricTon, 1d, 0.001d).SetName("Mass_FromBase_MetricTon");
            yield return new TestCaseData(UnitConverterMassUnit.Kilotonne, 1d, 9.9999999999999995e-07d).SetName("Mass_FromBase_Kilotonne");
            yield return new TestCaseData(UnitConverterMassUnit.Ounce, 1d, 35.273961949580411d).SetName("Mass_FromBase_Ounce");
            yield return new TestCaseData(UnitConverterMassUnit.Pound, 1d, 2.2046226218487757d).SetName("Mass_FromBase_Pound");
            yield return new TestCaseData(UnitConverterMassUnit.Stone, 1d, 0.15747304441776969d).SetName("Mass_FromBase_Stone");
            yield return new TestCaseData(UnitConverterMassUnit.Quarter, 1d, 0.078736522208884843d).SetName("Mass_FromBase_Quarter");
            yield return new TestCaseData(UnitConverterMassUnit.HundredweightUS, 1d, 0.022046226218487758d).SetName("Mass_FromBase_HundredweightUS");
            yield return new TestCaseData(UnitConverterMassUnit.HundredweightUK, 1d, 0.019684130552221211d).SetName("Mass_FromBase_HundredweightUK");
            yield return new TestCaseData(UnitConverterMassUnit.ShortTon, 1d, 0.0011023113109243879d).SetName("Mass_FromBase_ShortTon");
            yield return new TestCaseData(UnitConverterMassUnit.LongTon, 1d, 0.00098420652761106058d).SetName("Mass_FromBase_LongTon");
            yield return new TestCaseData(UnitConverterMassUnit.Grain, 1d, 15432.358352941432d).SetName("Mass_FromBase_Grain");
            yield return new TestCaseData(UnitConverterMassUnit.Pennyweight, 1d, 643.01493137255954d).SetName("Mass_FromBase_Pennyweight");
            yield return new TestCaseData(UnitConverterMassUnit.TroyOunce, 1d, 32.15074656862798d).SetName("Mass_FromBase_TroyOunce");
            yield return new TestCaseData(UnitConverterMassUnit.TroyPound, 1d, 2.6792288807189983d).SetName("Mass_FromBase_TroyPound");
            yield return new TestCaseData(UnitConverterMassUnit.Carat, 1d, 5000.0d).SetName("Mass_FromBase_Carat");
            yield return new TestCaseData(UnitConverterMassUnit.Slug, 1d, 0.068521765856793468d).SetName("Mass_FromBase_Slug");
            yield return new TestCaseData(UnitConverterMassUnit.AtomicMassUnit, 1d, 6.0221407620811229e+26d).SetName("Mass_FromBase_AtomicMassUnit");
            yield return new TestCaseData(UnitConverterMassUnit.Femtogram, 1d, 9.9999999999999987e+17d).SetName("Mass_FromBase_Femtogram");
            yield return new TestCaseData(UnitConverterMassUnit.Picogram, 1d, 999999999999999.88d).SetName("Mass_FromBase_Picogram");
            yield return new TestCaseData(UnitConverterMassUnit.Nanogram, 1d, 1000000000000.0d).SetName("Mass_FromBase_Nanogram");
            yield return new TestCaseData(UnitConverterMassUnit.Megagram, 1d, 0.001d).SetName("Mass_FromBase_Megagram");
            yield return new TestCaseData(UnitConverterMassUnit.Gigagram, 1d, 9.9999999999999995e-07d).SetName("Mass_FromBase_Gigagram");
            yield return new TestCaseData(UnitConverterMassUnit.Teragram, 1d, 1.0000000000000001e-09d).SetName("Mass_FromBase_Teragram");
            yield return new TestCaseData(UnitConverterMassUnit.Petagram, 1d, 9.9999999999999998e-13d).SetName("Mass_FromBase_Petagram");
            yield return new TestCaseData(UnitConverterMassUnit.Megatonne, 1d, 1.0000000000000001e-09d).SetName("Mass_FromBase_Megatonne");
            yield return new TestCaseData(UnitConverterMassUnit.Gigatonne, 1d, 9.9999999999999998e-13d).SetName("Mass_FromBase_Gigatonne");
            yield return new TestCaseData(UnitConverterMassUnit.Dram, 1d, 564.38339119328657d).SetName("Mass_FromBase_Dram");
            yield return new TestCaseData(UnitConverterMassUnit.ApothecariesScruple, 1d, 771.61791764707152d).SetName("Mass_FromBase_ApothecariesScruple");
            yield return new TestCaseData(UnitConverterMassUnit.ApothecariesDram, 1d, 257.20597254902384d).SetName("Mass_FromBase_ApothecariesDram");
            yield return new TestCaseData(UnitConverterMassUnit.ApothecariesOunce, 1d, 32.15074656862798d).SetName("Mass_FromBase_ApothecariesOunce");
            yield return new TestCaseData(UnitConverterMassUnit.ApothecariesPound, 1d, 2.6792288807189983d).SetName("Mass_FromBase_ApothecariesPound");
            yield return new TestCaseData(UnitConverterMassUnit.ElectronMass, 1d, 1.0977691057577633e+30d).SetName("Mass_FromBase_ElectronMass");
            yield return new TestCaseData(UnitConverterMassUnit.ProtonMass, 1d, 5.9786374065567836e+26d).SetName("Mass_FromBase_ProtonMass");
            yield return new TestCaseData(UnitConverterMassUnit.NeutronMass, 1d, 5.9704076813485953e+26d).SetName("Mass_FromBase_NeutronMass");
            yield return new TestCaseData(UnitConverterMassUnit.PlanckMass, 1d, 45946718.347535461d).SetName("Mass_FromBase_PlanckMass");
            yield return new TestCaseData(UnitConverterMassUnit.EarthMass, 1d, 1.6744248350691536e-25d).SetName("Mass_FromBase_EarthMass");
            yield return new TestCaseData(UnitConverterMassUnit.JupiterMass, 1d, 5.2683430534262667e-28d).SetName("Mass_FromBase_JupiterMass");
            yield return new TestCaseData(UnitConverterMassUnit.SolarMass, 1d, 5.0289921396852858e-31d).SetName("Mass_FromBase_SolarMass");
            yield return new TestCaseData(UnitConverterMassUnit.Shekel, 1d, 87.719298245614027d).SetName("Mass_FromBase_Shekel");
            yield return new TestCaseData(UnitConverterMassUnit.Mina, 1d, 2.0d).SetName("Mass_FromBase_Mina");
            yield return new TestCaseData(UnitConverterMassUnit.Talent, 1d, 0.038461538461538464d).SetName("Mass_FromBase_Talent");
            yield return new TestCaseData(UnitConverterMassUnit.Mark, 1d, 4.019292604501608d).SetName("Mass_FromBase_Mark");
            yield return new TestCaseData(UnitConverterMassUnit.Oka, 1d, 0.77948398160417809d).SetName("Mass_FromBase_Oka");
            yield return new TestCaseData(UnitConverterMassUnit.Catty, 1d, 1.6534669846129353d).SetName("Mass_FromBase_Catty");
            yield return new TestCaseData(UnitConverterMassUnit.Tael, 1d, 26.455446382746818d).SetName("Mass_FromBase_Tael");
            yield return new TestCaseData(UnitConverterMassUnit.Momme, 1d, 266.66666666666669d).SetName("Mass_FromBase_Momme");
            yield return new TestCaseData(UnitConverterMassUnit.PlanckMassGram, 1d, 45946718347.535469d).SetName("Mass_FromBase_PlanckMassGram");
        }
    }
}
