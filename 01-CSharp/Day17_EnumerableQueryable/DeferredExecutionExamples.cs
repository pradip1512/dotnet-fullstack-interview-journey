using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Day17_EnumerableQueryable;

public static class DeferredExecutionExamples
{
    public static void Run()
    {
        Console.WriteLine("==== Deferred Execution ====");

        List<int> numbers =
            [1, 2, 3];

        IEnumerable<int> query = numbers
            .Where (x => x > 1);

        numbers.Add(4);

        Console.WriteLine("====  Deferred Query ====");
        foreach (int number in query)
        {
            Console.WriteLine($"Received: {number}");
        }

        Console.WriteLine();

        List<int> materialized = numbers
            .Where(x => x > 1)
            .ToList();

        numbers.Add(5);

        Console.WriteLine("==== Materialized Result: ====");
        foreach (int number in materialized)
        {
            Console.WriteLine($"Received after materialized: {number}");
        }
    }
}
