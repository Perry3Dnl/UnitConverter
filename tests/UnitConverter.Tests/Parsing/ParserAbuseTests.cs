namespace UnitConverter.Tests.Parsing
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using NUnit.Framework;
    using UnitConverter.Length;

    [TestFixture]
    public sealed class ParserAbuseTests
    {
        [Test]
        public void TryApis_DoNotThrowForDeterministicMalformedInputCorpus()
        {
            foreach (string input in BuildCorpus())
            {
                string captured = input;

                Assert.DoesNotThrow(() =>
                {
                    double value;
                    UnitConverterLengthUnit unit;
                    UnitConverterParser.TryParse(
                        captured,
                        CultureInfo.InvariantCulture,
                        out value,
                        out unit);
                }, "typed parser: " + Describe(captured));

                Assert.DoesNotThrow(() =>
                    UnitConverterDetector.Detect(
                        captured,
                        CultureInfo.InvariantCulture),
                    "detector: " + Describe(captured));

                Assert.DoesNotThrow(() =>
                    UnitConverterDynamic.TryConvert(
                        captured,
                        "m",
                        CultureInfo.InvariantCulture),
                    "dynamic: " + Describe(captured));

                Assert.DoesNotThrow(() =>
                    UnitConverterExpressionParser.TryParse(captured),
                    "expression parser: " + Describe(captured));

                Assert.DoesNotThrow(() =>
                    UnitConverterComposite.TryConvert(
                        1d,
                        captured,
                        "m"),
                    "composite converter: " + Describe(captured));
            }
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("1")]
        [TestCase("1e309 m")]
        [TestCase("NaN m")]
        [TestCase("Infinity m")]
        [TestCase("1 / / m")]
        [TestCase("kg***m")]
        [TestCase("((((((((((((((((((((m")]
        [TestCase("m))))))))))))))))))))")]
        [TestCase("m^^999999999")]
        [TestCase("1,2,3 km")]
        [TestCase("1\u00A0\u00A0\u00A0")]
        public void CuratedMalformedInputs_ReturnStructuredFailureWithoutThrowing(string input)
        {
            Assert.DoesNotThrow(() =>
            {
                UnitConverterExpressionParseResult expression =
                    UnitConverterExpressionParser.TryParse(input);

                UnitConverterCompositeResult composite =
                    UnitConverterComposite.TryConvert(1d, input, "m");

                UnitConverterDetectionResult detection =
                    UnitConverterDetector.Detect(
                        input,
                        CultureInfo.InvariantCulture);

                UnitConverterDynamicResult dynamic =
                    UnitConverterDynamic.TryConvert(
                        input,
                        "m",
                        CultureInfo.InvariantCulture);

                Assert.That(expression.Success || !string.IsNullOrEmpty(expression.ErrorMessage), Is.True);
                Assert.That(composite.Success || !string.IsNullOrEmpty(composite.ErrorMessage), Is.True);
                Assert.That(detection.Success || !string.IsNullOrEmpty(detection.ErrorMessage), Is.True);
                Assert.That(dynamic.Success || !string.IsNullOrEmpty(dynamic.ErrorMessage), Is.True);
            });
        }

        private static IEnumerable<string> BuildCorpus()
        {
            yield return null;
            yield return string.Empty;

            string[] curated =
            {
                " ",
                "\t\r\n",
                "1",
                "m",
                "1m",
                "1 m",
                "1e+9999 m",
                "1e-9999 m",
                "--1 km",
                "++1 km",
                "1..2 km",
                "1,2,3 km",
                "kg/m/s",
                "kg//m",
                "kg**m",
                "(kg*m",
                "kg*m)",
                "m^-",
                "m^+",
                "m^2147483648",
                "m²³",
                "°°°",
                "µμu",
                "\u00A0\u2009\u202F",
                new string('(', 256),
                new string(')', 256),
                new string('*', 256),
                new string('9', 256) + " km",
            };

            foreach (string value in curated)
            {
                yield return value;
            }

            const string alphabet =
                "0123456789eE+-., \t*/^()[]{}·²³µμΩ°Δ_%abcXYZ!?\\|:;";

            var random = new Random(0x51A7C0DE);
            for (int caseIndex = 0; caseIndex < 1500; caseIndex++)
            {
                int length = random.Next(0, 97);
                var chars = new char[length];

                for (int index = 0; index < chars.Length; index++)
                {
                    chars[index] = alphabet[random.Next(alphabet.Length)];
                }

                yield return new string(chars);
            }
        }

        private static string Describe(string value)
        {
            if (value == null)
            {
                return "<null>";
            }

            string escaped = value
                .Replace("\r", "\\r")
                .Replace("\n", "\\n")
                .Replace("\t", "\\t");

            return escaped.Length <= 120
                ? escaped
                : escaped.Substring(0, 120) + "...";
        }
    }
}
