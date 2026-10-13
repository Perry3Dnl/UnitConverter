namespace UnitTools.Tests
{
    using NUnit.Framework;
    using UnitTools.Catalog;

    public sealed class UnitToolsCompositeTests
    {
        [Test]
        public void Parse_ForceExpression_HasForceDimensions()
        {
            UnitToolsUnitExpression expression =
                UnitToolsExpressionParser.Parse("kg*m/s^2");

            UnitToolsDimensions force =
                UnitToolsCatalog.GetFamily(UnitToolsFamily.Force).Dimensions;

            Assert.That(expression.Dimensions, Is.EqualTo(force));
            Assert.That(expression.ScaleToCanonical, Is.EqualTo(1d));
        }

        [Test]
        public void Parse_SuperscriptPower_IsAccepted()
        {
            UnitToolsUnitExpression expression =
                UnitToolsExpressionParser.Parse("kg*m/s²");

            Assert.That(
                expression.Dimensions,
                Is.EqualTo(UnitToolsCatalog.GetFamily(UnitToolsFamily.Force).Dimensions));
        }

        [Test]
        public void Parse_NormalizedCacheKeyPreservesCallerExpressionText()
        {
            UnitToolsUnitExpression superscript =
                UnitToolsExpressionParser.Parse("  kg·m/s²  ");
            UnitToolsUnitExpression ascii =
                UnitToolsExpressionParser.Parse("kg*m/s^2");

            Assert.That(superscript.Text, Is.EqualTo("kg·m/s²"));
            Assert.That(ascii.Text, Is.EqualTo("kg*m/s^2"));
            Assert.That(superscript.Dimensions, Is.EqualTo(ascii.Dimensions));
            Assert.That(superscript.ScaleToCanonical, Is.EqualTo(ascii.ScaleToCanonical));
        }

        [Test]
        public void Parse_ParenthesizedThermalConductivityExpression_Works()
        {
            UnitToolsUnitExpression expression =
                UnitToolsExpressionParser.Parse("W/(m^2*K)");

            Assert.That(
                expression.Dimensions,
                Is.EqualTo(UnitToolsCatalog.GetFamily(UnitToolsFamily.HeatTransferCoefficient).Dimensions));
            Assert.That(expression.ScaleToCanonical, Is.EqualTo(1d));
        }

        [Test]
        public void Parse_MolarConcentrationExpression_Works()
        {
            UnitToolsUnitExpression expression =
                UnitToolsExpressionParser.Parse("mol/m³");

            Assert.That(
                expression.Dimensions,
                Is.EqualTo(UnitToolsCatalog.GetFamily(UnitToolsFamily.MolarConcentration).Dimensions));
        }

        [Test]
        public void Convert_KilometersPerHour_ToMetersPerSecond()
        {
            double result = UnitToolsComposite.Convert(
                36d,
                "km/h",
                "m/s");

            Assert.That(result, Is.EqualTo(10d).Within(1e-12d));
        }

        [Test]
        public void Convert_Liters_ToCubicMeters_UsesCanonicalVolumeScale()
        {
            double result = UnitToolsComposite.Convert(
                1000d,
                "liter",
                "m^3");

            Assert.That(result, Is.EqualTo(1d).Within(1e-12d));
        }

        [Test]
        public void Convert_NewtonMeter_ToJoule_AllowsDimensionalEquivalence()
        {
            double result = UnitToolsComposite.Convert(
                1d,
                "N*m",
                "J");

            Assert.That(result, Is.EqualTo(1d).Within(1e-12d));
        }

        [Test]
        public void Parse_AmbiguousEquivalentPascalCandidates_AreCoalesced()
        {
            UnitToolsExpressionParseResult result =
                UnitToolsExpressionParser.TryParse("Pa");

            Assert.That(result.Success, Is.True);
            Assert.That(
                result.Expression.Dimensions,
                Is.EqualTo(UnitToolsCatalog.GetFamily(UnitToolsFamily.Pressure).Dimensions));
        }

        [TestCase("L")]
        [TestCase("h")]
        public void Parse_TrueSymbolCollision_RemainsAmbiguous(string expression)
        {
            UnitToolsExpressionParseResult result =
                UnitToolsExpressionParser.TryParse(expression);

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.AmbiguousUnit));
        }

        [Test]
        public void Convert_TrueSymbolCollision_CanResolveFromTargetDimensions()
        {
            double result = UnitToolsComposite.Convert(
                1000d,
                "L",
                "m^3");

            Assert.That(result, Is.EqualTo(1d).Within(1e-12d));
        }

        [Test]
        public void CachedBuiltInParseStillRespectsLaterCustomUnitAmbiguity()
        {
            UnitToolsCustomUnits.Clear();

            try
            {
                UnitToolsExpressionParseResult builtIn =
                    UnitToolsExpressionParser.TryParse("light-year");
                Assert.That(builtIn.Success, Is.True);

                UnitToolsCustomUnits.RegisterLinear(
                    UnitToolsFamily.Time,
                    "CustomLightYear",
                    "custom-light-year",
                    "Second",
                    2d,
                    "light-year");

                UnitToolsExpressionParseResult withCustom =
                    UnitToolsExpressionParser.TryParse("light-year");

                Assert.That(withCustom.Success, Is.False);
                Assert.That(
                    withCustom.Error,
                    Is.EqualTo(UnitToolsError.AmbiguousUnit));
            }
            finally
            {
                UnitToolsCustomUnits.Clear();
            }
        }

        [Test]
        public void Convert_IncompatibleDimensions_ReturnsStructuredError()
        {
            UnitToolsCompositeResult result =
                UnitToolsComposite.TryConvert(
                    1d,
                    "m",
                    "s");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.IncompatibleDimensions));
        }

        [Test]
        public void Parse_UnknownFactor_ReturnsStructuredError()
        {
            UnitToolsExpressionParseResult result =
                UnitToolsExpressionParser.TryParse("kg*definitely-not-a-unit");

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.EqualTo(UnitToolsError.UnknownUnit));
        }

        [Test]
        public void Convert_DigitalStorage_UsesBitAsCanonicalInformationDimension()
        {
            double result = UnitToolsComposite.Convert(
                1d,
                "B",
                "bit");

            Assert.That(result, Is.EqualTo(8d).Within(1e-12d));
        }
    }
}
