using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_Strings;

public static class StringExamples
{
    public static void RunBasicExamples()
    {
        string name = "Pradip";
        string department = "IT";

        Console.WriteLine($"Name: {name}");

        Console.WriteLine($"Department: {department}");

        Console.WriteLine($"Name Length: {name.Length}");

        Console.WriteLine($"First Character: {name[0]}");

        Console.WriteLine($"Uppercase: {name.ToUpper()}");

        Console.WriteLine($"Lowercase: {name.ToLower()}");

        Console.WriteLine($"Contains 'dip': {name.Contains("dip")}");
    }
}
