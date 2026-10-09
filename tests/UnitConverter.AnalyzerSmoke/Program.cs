using System;
using UnitConverter;

public static class Program
{
    public static void Main()
    {
        double result = UnitConverterDynamic.Convert("2 km", "m");
        Console.WriteLine(result);
    }
}
