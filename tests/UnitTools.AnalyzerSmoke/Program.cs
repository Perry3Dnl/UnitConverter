using System;
using UnitTools;

public static class Program
{
    public static void Main()
    {
        double result = UnitToolsDynamic.Convert("2 km", "m");
        UnitToolsDynamicResult tryResult =
            UnitToolsDynamic.TryConvert("3 km", "m");

        // Compile-time constants that do not represent a valid invariant quantity
        // must not trigger UC0002.
        if (DateTime.UtcNow.Ticks < 0)
        {
            UnitToolsDynamic.Convert("not a quantity", "m");
            UnitToolsDynamic.Convert("", "m");
            UnitToolsDynamic.Convert("2 km", "");
        }

        Console.WriteLine(result);
        Console.WriteLine(tryResult.Value);
    }
}