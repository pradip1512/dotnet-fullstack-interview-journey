using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_LINQ;

public static class AggregationExamples
{
    public static void Run()
    {
        List<int> numbers =[ 10, 20, 30, 40, 50 ];

        Console.WriteLine("===== Aggregation Examples =====");
        Console.WriteLine($"Count: {numbers.Count()}");
        Console.WriteLine($"Sum: {numbers.Sum()}");
        Console.WriteLine($"Average: {numbers.Average()}");
        Console.WriteLine($"Min: {numbers.Min()}");
        Console.WriteLine($"Max: {numbers.Max()}");
        Console.WriteLine();

        Console.WriteLine("===== Any/All Examples =====");
        Console.WriteLine($"Any > 40: {numbers.Any(n => n > 40)}");
        Console.WriteLine($"All > 0: {numbers.All(n => n > 0)}");
    }
}
