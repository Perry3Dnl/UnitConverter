namespace UnitConverter.Tests
{
    using NUnit.Framework;
    using UnitConverter.Catalog;

    public sealed class UnitConverterCompositeTests
    {
        [Test]
        public void Parse_ForceExpression_HasForceDimensions()
        {
            UnitConverterUnitExpression expression =
                UnitConverterExpressionParser.Parse("kg*m/s^2");

            UnitConverterDimensions force =
                UnitConverterCatalog.GetFamily(UnitConverterFamily.Force).Dimensions;

            Assert.That(expression.Dimensions, Is.EqualTo(force));
            Assert.That(expression.ScaleToCanonical, Is.EqualTo(1d));
        }

        [Test]
        public void Parse_SuperscriptPower_IsAccepted()
        {
            UnitConverterUnitExpression expression =
                UnitConverterExpressionParser.Parse("kg*m/s²");

            Assert.That(
                expression.Dimensions,
                Is.EqualTo(UnitConverterCatalog.GetFamily(UnitConverterFamily.Force).Dimensions));
        }

        [Test]
        public void Parse_ParenthesizedThermalConductivityExpression_Works()
        {
            UnitConverterUnitExpression expression =
                UnitConverterExpressionParser.Parse("W/(m^2*K)");

            Assert.That(
                expression.Dimensions,
                Is.EqualTo(UnitConverterCatalog.GetFamily(UnitConverterFamily.ThermalConductivity).Dimensions));
            Assert.That(expression.ScaleToCanonical, Is.EqualTo(1d));
        }

        [Test]
        public void Parse_MolarConcentrationExpression_Works()
        {
            UnitConverterUnitExpression expression =
                UnitConverterExpressionParser.Parse("mol/m³");

            Assert.That(
                expression.Dimensions,
                Is.EqualTo(UnitConverterCatalog.GetFamily(UnitConverterFamily.MolarConcentration).Dimensions));
        }

        [Test]
        public void Convert_KilometersPerHour_ToMetersPerSecond()
        {
            double result = UnitConverterComposite.Convert(
                36d,
                "km/h",
                "m/s");

            Assert.That(result, Is.EqualTo(10d).Within(1e-12d));
        }

        [Test]
        public void Convert_Liters_ToCubicMeters_UsesCanonicalVolumeScale()
        {
            double result = UnitConverterComposite.Convert(
                1000d,
                "L",
                "m^3");

            Assert.That(result, Is.EqualTo(1d).Within(1e-12d));
        }

        [Test]
        public void Convert_NewtonMeter_ToJoule_AllowsDimensionalEquivalence()
        {
            double result = UnitConverterComposite.Convert(
                1d,
                "N*m",
                "J");

            Assert.That(result, Is.EqualTo(1d).Within(1e-12d));
        }

        [Test]
        public void Parse_AmbiguousEquivalentPascalCandidates_AreCoalesced()
        {
            UnitConverterExpressionParseResult result =
                UnitConverterExpressionParser.TryParse("Pa");

            Assert.That(result.Success, Is.True);
            Assert.That(
                result.Expression.Dimensions,
                Is.EqualTo(UnitConverterCatalog.GetFamily(UnitConverterFamily.Pressure).Dimensions));
        }

        [Test]
        public void Convert_IncompatibleDimensions_ReturnsStructuredError()
        {
            UnitConverterCompositeResult result =
                UnitConverterComposite.TryConvert(
                    1d,
                    "m",
                    "s");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.IncompatibleDimensions));
        }

        [Test]
        public void Parse_UnknownFactor_ReturnsStructuredError()
        {
            UnitConverterExpressionParseResult result =
                UnitConverterExpressionParser.TryParse("kg*definitely-not-a-unit");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitConverterError.UnknownUnit));
        }

        [Test]
        public void Convert_DigitalStorage_UsesBitAsCanonicalInformationDimension()
        {
            double result = UnitConverterComposite.Convert(
                1d,
                "B",
                "bit");

            Assert.That(result, Is.EqualTo(8d).Within(1e-12d));
        }
    }
}
