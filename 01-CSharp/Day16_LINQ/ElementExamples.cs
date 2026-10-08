using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_LINQ;

public static class ElementExamples
{
    public static void Run()
    {
        List<int> numbers = [ 10, 20, 30, 40, ];
        
        Console.WriteLine("===== Element Operators =====");

        int first = numbers.First();

        Console.WriteLine($"First: {first}");

        int? firstGreaterThan100 = numbers
            .FirstOrDefault(n => n > 100);

        Console.WriteLine($"First > 100: {firstGreaterThan100}");

        int single = numbers.Single(n => n == 20);

        Console.WriteLine($"Single == 20: {single}");

        int? singleOrDefault = numbers
            .SingleOrDefault(n => n == 100);

        Console.WriteLine($"SingleOrDefault == 100: {singleOrDefault}");
    }
}
