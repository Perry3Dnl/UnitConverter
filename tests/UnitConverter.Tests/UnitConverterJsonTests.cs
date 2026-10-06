namespace UnitConverter.Tests
{
    using NUnit.Framework;
    using System.Text.Json;
    using UnitConverter.Length;
    using UnitConverter.SystemTextJson;
    using UnitConverter.Temperature;

    public sealed class UnitConverterJsonTests
    {
        private static JsonSerializerOptions CreateOptions()
        {
            return new JsonSerializerOptions().AddUnitConverter();
        }

        [Test]
        public void UnitValue_RoundTrips()
        {
            var value = new UnitValue<UnitConverterLengthUnit>(
                1.8d,
                UnitConverterLengthUnit.Kilometer);

            JsonSerializerOptions options = CreateOptions();
            string json = JsonSerializer.Serialize(value, options);
            UnitValue<UnitConverterLengthUnit> restored =
                JsonSerializer.Deserialize<UnitValue<UnitConverterLengthUnit>>(
                    json,
                    options);

            Assert.That(restored, Is.EqualTo(value));
            Assert.That(json, Does.Contain("\"value\":1.8"));
            Assert.That(json, Does.Contain("\"unit\":\"Kilometer\""));
        }

        [Test]
        public void UnitValue_Deserializer_AcceptsAliases()
        {
            const string json = "{\"value\":2,\"unit\":\"km\"}";

            UnitValue<UnitConverterLengthUnit> restored =
                JsonSerializer.Deserialize<UnitValue<UnitConverterLengthUnit>>(
                    json,
                    CreateOptions());

            Assert.That(restored.Value, Is.EqualTo(2d));
            Assert.That(
                restored.Unit,
                Is.EqualTo(UnitConverterLengthUnit.Kilometer));
        }

        [Test]
        public void UnitValue_Deserializer_IsCaseInsensitiveForPropertyNames()
        {
            const string json = "{\"VALUE\":20,\"UNIT\":\"Celsius\"}";

            UnitValue<UnitConverterTemperatureUnit> restored =
                JsonSerializer.Deserialize<UnitValue<UnitConverterTemperatureUnit>>(
                    json,
                    CreateOptions());

            Assert.That(restored.Value, Is.EqualTo(20d));
            Assert.That(
                restored.Unit,
                Is.EqualTo(UnitConverterTemperatureUnit.Celsius));
        }

        [Test]
        public void UnitValue_Deserializer_RejectsUnknownUnit()
        {
            const string json = "{\"value\":2,\"unit\":\"not-a-length\"}";

            Assert.Throws<JsonException>(() =>
                JsonSerializer.Deserialize<UnitValue<UnitConverterLengthUnit>>(
                    json,
                    CreateOptions()));
        }

        [Test]
        public void AddUnitConverter_IsIdempotent()
        {
            var options = new JsonSerializerOptions();

            options.AddUnitConverter();
            options.AddUnitConverter();

            int count = 0;
            foreach (System.Text.Json.Serialization.JsonConverter converter in
                options.Converters)
            {
                if (converter is UnitValueJsonConverterFactory)
                {
                    count++;
                }
            }

            Assert.That(count, Is.EqualTo(1));
        }
    }
}
