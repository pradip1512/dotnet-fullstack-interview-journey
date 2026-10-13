using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day17_EnumerableQueryable;

public static class IteratorExamples
{
    public static IEnumerable<int> GenerateNumbers()
    {
        Console.WriteLine("Generating 1");
        yield return 1;

        Console.WriteLine("Generating 2");
        yield return 2;

        Console.WriteLine("Generating 3");
        yield return 3;

    }

    public static IEnumerable<int> GenerateEvenNumbers(int start, int end)
    {
        for (int number = start; number <= end; number++)
        {
            if (number % 2 == 0)
            {
                yield return number;
            }
        }
    }

    public static void Run()
    {
        Console.WriteLine("==== Iterator Examples: ====");

        IEnumerable<int> numbers = GenerateNumbers();

        Console.WriteLine("==== Before Foreach ====");
        foreach (var number in numbers)
        {
            Console.WriteLine($"Received: {number}");
        }

        Console.WriteLine();

        Console.WriteLine("==== Even Numbers ====");
        foreach (var evenNumber in GenerateEvenNumbers(1, 10))
        {
            Console.WriteLine($"Even Number: {evenNumber}");
        }
    }
}
