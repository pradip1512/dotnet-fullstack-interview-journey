using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_LINQ;

public static class BasicLinqExamples
{
    public static void Run() 
    {
        Console.WriteLine("===== Basic LINQ =====");

        List<int> numbers = [10,20,30,40,50];

        IEnumerable<int> filtered = numbers.Where(number => number > 25);

        Console.WriteLine("Numbers greater than 25:");

        foreach (int number in filtered)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

        IEnumerable<int> doubled = numbers.Select(number => number * 2);
        Console.WriteLine("Doubled numbers:");

        foreach (int number in doubled)
        {
            Console.WriteLine(number);
        }
    }
}
