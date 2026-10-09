using System;
using UnitConverter;

public static class Program
{
    public static void Main()
    {
        double result = UnitConverterDynamic.Convert("2 km", "m");
        UnitConverterDynamicResult tryResult =
            UnitConverterDynamic.TryConvert("3 km", "m");

        // Compile-time constants that do not represent a valid invariant quantity
        // must not trigger UC0002.
        if (DateTime.UtcNow.Ticks < 0)
        {
            UnitConverterDynamic.Convert("not a quantity", "m");
            UnitConverterDynamic.Convert("", "m");
            UnitConverterDynamic.Convert("2 km", "");
        }

        Console.WriteLine(result);
        Console.WriteLine(tryResult.Value);
    }
}