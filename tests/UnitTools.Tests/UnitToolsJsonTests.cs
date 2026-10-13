namespace UnitTools.Tests
{
    using NUnit.Framework;
    using System;
    using System.Reflection;
    using System.Text.Json;
    using UnitTools.Catalog;
    using UnitTools.Length;
    using UnitTools.SystemTextJson;
    using UnitTools.Temperature;

    public sealed class UnitToolsJsonTests
    {
        private static JsonSerializerOptions CreateOptions()
        {
            return new JsonSerializerOptions().AddUnitTools();
        }

        [Test]
        public void UnitValue_RoundTrips()
        {
            var value = new UnitValue<UnitToolsLengthUnit>(
                1.8d,
                UnitToolsLengthUnit.Kilometer);

            JsonSerializerOptions options = CreateOptions();
            string json = JsonSerializer.Serialize(value, options);
            UnitValue<UnitToolsLengthUnit> restored =
                JsonSerializer.Deserialize<UnitValue<UnitToolsLengthUnit>>(
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

            UnitValue<UnitToolsLengthUnit> restored =
                JsonSerializer.Deserialize<UnitValue<UnitToolsLengthUnit>>(
                    json,
                    CreateOptions());

            Assert.That(restored.Value, Is.EqualTo(2d));
            Assert.That(
                restored.Unit,
                Is.EqualTo(UnitToolsLengthUnit.Kilometer));
        }

        [Test]
        public void UnitValue_Deserializer_IsCaseInsensitiveForPropertyNames()
        {
            const string json = "{\"VALUE\":20,\"UNIT\":\"Celsius\"}";

            UnitValue<UnitToolsTemperatureUnit> restored =
                JsonSerializer.Deserialize<UnitValue<UnitToolsTemperatureUnit>>(
                    json,
                    CreateOptions());

            Assert.That(restored.Value, Is.EqualTo(20d));
            Assert.That(
                restored.Unit,
                Is.EqualTo(UnitToolsTemperatureUnit.Celsius));
        }

        [Test]
        public void UnitValue_Deserializer_RejectsUnknownUnit()
        {
            const string json = "{\"value\":2,\"unit\":\"not-a-length\"}";

            Assert.Throws<JsonException>(() =>
                JsonSerializer.Deserialize<UnitValue<UnitToolsLengthUnit>>(
                    json,
                    CreateOptions()));
        }

        [TestCase("{\"value\":\"2\",\"unit\":\"km\"}")]
        [TestCase("{\"value\":2,\"unit\":2}")]
        public void UnitValue_Deserializer_RejectsWrongPropertyTypes(string json)
        {
            Assert.Throws<JsonException>(() =>
                JsonSerializer.Deserialize<UnitValue<UnitToolsLengthUnit>>(
                    json,
                    CreateOptions()));
        }

        [Test]
        public void EveryCatalogUnit_RoundTripsWithStableEnumName()
        {
            JsonSerializerOptions options = CreateOptions();

            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                Type unitValueType = typeof(UnitValue<>).MakeGenericType(family.UnitType);
                ConstructorInfo constructor = unitValueType.GetConstructor(
                    new[] { typeof(double), family.UnitType });

                Assert.That(constructor, Is.Not.Null, family.Name);

                PropertyInfo valueProperty = unitValueType.GetProperty("Value");
                PropertyInfo unitProperty = unitValueType.GetProperty("Unit");

                foreach (UnitToolsUnitDescriptor unit in family.Units)
                {
                    object original = constructor.Invoke(new[] { (object)1.25d, unit.Unit });
                    string json = JsonSerializer.Serialize(original, unitValueType, options);
                    object restored = JsonSerializer.Deserialize(json, unitValueType, options);

                    string context = family.Name + "." + unit.Name;
                    Assert.That(restored, Is.Not.Null, context);
                    Assert.That(
                        (double)valueProperty.GetValue(restored),
                        Is.EqualTo(1.25d),
                        context);
                    Assert.That(
                        unitProperty.GetValue(restored),
                        Is.EqualTo(unit.Unit),
                        context);
                    Assert.That(
                        json,
                        Does.Contain("\"unit\":\"" + unit.Name + "\""),
                        context);
                }
            }
        }

        [Test]
        public void EveryCatalogSymbol_IsAcceptedAsJsonInputWhenUnambiguous()
        {
            JsonSerializerOptions options = CreateOptions();

            foreach (UnitToolsFamilyDescriptor family in UnitToolsCatalog.GetFamilies())
            {
                Type unitValueType = typeof(UnitValue<>).MakeGenericType(family.UnitType);
                PropertyInfo unitProperty = unitValueType.GetProperty("Unit");

                foreach (UnitToolsUnitDescriptor unit in family.Units)
                {
                    object resolved;
                    if (family.ResolveUnit(unit.Symbol, out resolved) !=
                        UnitToolsUnitResolution.Resolved)
                    {
                        continue;
                    }

                    string json =
                        "{\"value\":2.5,\"unit\":" +
                        JsonSerializer.Serialize(unit.Symbol) +
                        "}";

                    object restored =
                        JsonSerializer.Deserialize(json, unitValueType, options);

                    Assert.That(
                        unitProperty.GetValue(restored),
                        Is.EqualTo(unit.Unit),
                        family.Name + "." + unit.Name);
                }
            }
        }

        [Test]
        public void AddUnitTools_IsIdempotent()
        {
            var options = new JsonSerializerOptions();

            options.AddUnitTools();
            options.AddUnitTools();

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