using System;
using NUnit.Framework;
using UnitConverter.Quantities;

namespace UnitConverter.Tests.Quantities
{
    [TestFixture]
    public sealed class FullLengthQuantityTests
    {
        [Test]
        public void EveryExistingLengthEnumUnitIsSupportedByTypedIndirectApi()
        {
            foreach (UnitConverter.Length.UnitConverterLengthUnit unit in Enum.GetValues<UnitConverter.Length.UnitConverterLengthUnit>())
            {
                Length<double> quantity = LengthMethods.From(1d, unit);
                double roundTrip = quantity.In(unit);

                Assert.That(roundTrip, Is.EqualTo(1d).Within(1e-12), unit.ToString());
            }
        }

        [Test]
        public void ExplicitLengthMethodsCoverRepresentativeUnitFamilies()
        {
            Assert.That(LengthMethods.FromFemtometer(1m).ToFemtometer(), Is.EqualTo(1m).Within(0.000000000001m));
            Assert.That(LengthMethods.FromNauticalMile(1m).ToMetres(), Is.EqualTo(1852m));
            Assert.That(LengthMethods.FromUSSurveyFoot(1m).ToUSSurveyFoot(), Is.EqualTo(1m).Within(0.000000000001m));
            Assert.That(LengthMethods.FromAstronomicalUnit(1m).ToMetres(), Is.EqualTo(149597870700m));
            Assert.That(LengthMethods.FromParsec(1m).ToParsec(), Is.EqualTo(1m).Within(0.000000000001m));
            Assert.That(LengthMethods.FromRackUnit(1m).ToRackUnit(), Is.EqualTo(1m).Within(0.000000000001m));
        }

        [Test]
        public void ExactCoreLengthUnitsKeepDecimalArithmetic()
        {
            Assert.That(LengthMethods.FromInch(1m).ToMetres(), Is.EqualTo(0.0254m));
            Assert.That(LengthMethods.FromFoot(1m).ToMetres(), Is.EqualTo(0.3048m));
            Assert.That(LengthMethods.FromYard(1m).ToMetres(), Is.EqualTo(0.9144m));
            Assert.That(LengthMethods.FromMile(1m).ToMetres(), Is.EqualTo(1609.344m));
        }

        [Test]
        public void LengthEnumAndExplicitConversionShareTheSameTypedKernel()
        {
            decimal explicitValue = LengthMethods.FromNauticalMile(2m).ToKilometres();
            decimal indirectValue = LengthMethods.Convert(
                2m,
                UnitConverter.Length.UnitConverterLengthUnit.NauticalMile,
                UnitConverter.Length.UnitConverterLengthUnit.Kilometer);

            Assert.That(indirectValue, Is.EqualTo(explicitValue));
        }
    }
}
