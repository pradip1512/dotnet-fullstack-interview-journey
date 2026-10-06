using System;
using System.Collections.Generic;
using System.Text;

namespace Day15_DelegatesLambdas;

public static class FuncActionPredicateExamples
{
    public static void Run()
    {
        Console.WriteLine("===== Func =======");

        Func<int, int> square = number => number * number;

        Console.WriteLine($"Square : {square(5)}");

        Func<int, int, int> add = (a, b) => a + b;

        Console.WriteLine($"Addition : {add(10, 20)}");

        Console.WriteLine();

        Console.WriteLine("===== Action =======");

        Action<string> printMessage = message => Console.WriteLine(message);

        printMessage("Hello, from Action!");

        Console.WriteLine();

        Console.WriteLine("===== Predicate =======");

        Predicate<int> isEven = number => number % 2 == 0;

        Console.WriteLine($"Is 10 even? : {isEven(10)}");
        Console.WriteLine($"Is 11 even? : {isEven(11)}");

        Console.WriteLine();

        Console.WriteLine("===== Closure =======");

        int minimum = 50;

        Predicate<int> checkMinimum = value => value >= minimum;

        minimum = 100;

        Console.WriteLine($"Is 75 greater than or equal to minimum? : {checkMinimum(75)}");

        Console.WriteLine();

    }
}
