using System;
using System.Collections.Generic;
using System.Text;

namespace Day15_DelegatesLambdas;

public static class LambdaExamples
{
    public static void Run()
    {
        Console.WriteLine("===== Lambda Examples =====");
        Func<int,int> doubleValue = number => number * 2;

        Console.WriteLine($"Double of 5 is {doubleValue(5)}");

        Func<int, int> square = number => number * number;

        Console.WriteLine($"Square of 10 is {square(10)}");

        Func<int, int, int> add = (a, b) => a + b;

        Console.WriteLine($"Add 10 and 20 is {add(10, 20)}");

        Func<int, bool> isPositive = number => number > 0;

        Console.WriteLine($"Is 10 positive? {isPositive(10)}");

        Func<int, bool> isEven = number => number % 2 == 0;

        Console.WriteLine($"Is 10 even? {isEven(10)}");

        Console.WriteLine();
    }
}
