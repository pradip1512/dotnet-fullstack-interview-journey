using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_EnumerableQueryable;

public static class MultipleEnumerationExamples
{
    public static IEnumerable<int> GetNumbers()
    {
        Console.WriteLine("Generating numbers...");

        for(int i = 1; i <= 5; i++)
        {
            yield return i;
        }
    }

    public static void Run()
    {
        Console.WriteLine("==== Multiple Enumeration ====");

        IEnumerable<int> numbers = GetNumbers();

        Console.WriteLine("==== First Enumeration ====");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("==== Second Enumeration ====");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
