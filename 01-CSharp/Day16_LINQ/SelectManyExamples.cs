using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_LINQ;

public static class SelectManyExamples
{
    public static void Run()
    {
        List<List<int>> numbersGroup =
            [
                [ 1, 2 ],
                [ 3, 4 ],
                [ 5, 6 ]
            ];

        var flattendNumbers = numbersGroup
            .SelectMany(group => group)
            .ToList();

        Console.WriteLine("=== Select Many ===");

        foreach (int number in flattendNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
