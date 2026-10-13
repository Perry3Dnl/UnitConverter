using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using UnitTools;
using UnitTools.Length;
using UnitTools.SystemTextJson;

public static class Program
{
    public static void Main()
    {
        var options = new JsonSerializerOptions();
        options.AddUnitTools<UnitToolsLengthUnit>();

        var context = new AppJsonContext(options);
        JsonTypeInfo<UnitValue<UnitToolsLengthUnit>> typeInfo =
            (JsonTypeInfo<UnitValue<UnitToolsLengthUnit>>)context.GetTypeInfo(
                typeof(UnitValue<UnitToolsLengthUnit>));

        var value =
            new UnitValue<UnitToolsLengthUnit>(
                1.8d,
                UnitToolsLengthUnit.Kilometer);

        string json = JsonSerializer.Serialize(value, typeInfo);
        UnitValue<UnitToolsLengthUnit> restored =
            JsonSerializer.Deserialize(json, typeInfo);

        if (!restored.Equals(value))
        {
            throw new InvalidOperationException(
                "NativeAOT JSON round-trip failed.");
        }
    }
}

[JsonSerializable(typeof(UnitValue<UnitToolsLengthUnit>))]
internal partial class AppJsonContext : JsonSerializerContext
{
}
