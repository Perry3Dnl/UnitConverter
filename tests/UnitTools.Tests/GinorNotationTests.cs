namespace UnitTools.Tests
{
    using System;
    using System.Numerics;
    using NUnit.Framework;
    using UnitTools.Numbers;

    public sealed class GinorNotationTests
    {
        [Test]
        public void GinozillionHasReadableShortName()
        {
            var position = new GeneratedNumberScalePosition(2, 4, 1);
            Assert.That(GinorNotation.ToShortName(position), Is.EqualTo("G2:4:1"));
            Assert.That(GinorNotation.ParseShortName("G2:4:1"), Is.EqualTo(position));
            Assert.That(GeneratedNumberNames.GetName(
                GinorNotation.ParseShortName("G2:4:1")), Is.EqualTo("ginozillion"));
        }

        [TestCase(2, 4, 1, 0, false)]
        [TestCase(2, 4, 1, 0, true)]
        [TestCase(3, 27, 7, 5, false)]
        [TestCase(100, 1000, 999, 100, true)]
        public void BothFormatsRoundTrip(int layer, int magnitude, int coefficient,
            int fold, bool tiny)
        {
            var address = new GeneratedNumberNameAddress(
                new GeneratedNumberScalePosition(tiny ?
                    GeneratedNumberScaleDirection.Tiny :
                    GeneratedNumberScaleDirection.Large,
                    layer, magnitude, coefficient), fold);

            Assert.That(GinorNotation.ParseShortAddress(
                GinorNotation.ToShortName(address)), Is.EqualTo(address));
            Assert.That(GinorNotation.ParseCompactName(
                GinorNotation.ToCompactName(address)), Is.EqualTo(address));
        }

        [Test]
        public void VeryLargeCoordinatesRoundTrip()
        {
            var address = new GeneratedNumberNameAddress(
                new GeneratedNumberScalePosition(
                    BigInteger.Pow(10, 40), BigInteger.Pow(10, 30),
                    BigInteger.Pow(10, 20)), BigInteger.Pow(10, 8));
            Assert.That(GinorNotation.ParseCompactName(
                GinorNotation.ToCompactName(address)), Is.EqualTo(address));
        }

        [TestCase("G2:4:0")]
        [TestCase("G2:4:1:F0")]
        [TestCase("G02:4:1")]
        [TestCase("G-2:4")]
        public void InvalidReadableNamesFail(string input)
        {
            GeneratedNumberNameAddress address;
            Assert.That(GinorNotation.TryParseShortAddress(input, out address), Is.False);
        }

        [TestCase("G~")]
        [TestCase("G~00")]
        [TestCase("G~?")]
        public void InvalidCompactNamesFail(string input)
        {
            GeneratedNumberNameAddress address;
            Assert.That(GinorNotation.TryParseCompactName(input, out address), Is.False);
        }
    }
}
