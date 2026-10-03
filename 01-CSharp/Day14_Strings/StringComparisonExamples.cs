using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_Strings;

public static class StringComparisonExamples
{
    public static void Run()
    {
        string first = "admin";
        string second = "ADMIN";

        Console.WriteLine($"Using == : {first == second}");

        Console.WriteLine($"Ordinal Ignore Case: " +$"{string.Equals(
                first,
                second,
                StringComparison.OrdinalIgnoreCase)}");
    }
}
