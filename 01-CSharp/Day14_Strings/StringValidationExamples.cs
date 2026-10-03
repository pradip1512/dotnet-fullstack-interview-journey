using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_Strings;

public static class StringValidationExamples
{
    public static void Run()
    {
        string? value1 = null;
        string value2 = "";
        string value3 = "   ";
        string value4 = "Pradip";

        Console.WriteLine($"value1 IsNullOrEmpty: " + $"{string.IsNullOrEmpty(value1)}");

        Console.WriteLine($"value2 IsNullOrEmpty: " + $"{string.IsNullOrEmpty(value2)}");

        Console.WriteLine($"value3 IsNullOrWhiteSpace: " + $"{string.IsNullOrWhiteSpace(value3)}");

        Console.WriteLine($"value4 IsNullOrWhiteSpace: " + $"{string.IsNullOrWhiteSpace(value4)}");
    }
}
