using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Day15_DelegatesLambdas;

public delegate int Calculator(int a, int b);

public static class DelegateExamples
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static void ExecuteOperation(
                        int a,
                        int b,
                        Calculator operation)
    {
        Console.WriteLine(operation(a, b));
    }

    public static void Run()
    {
        Console.WriteLine("===== Delegate Examples =====");

        Calculator calculator = Add;

        Console.WriteLine($"Add : {calculator(10, 20)}");

        calculator = Subtract;

        Console.WriteLine($"Subtract : {calculator(20, 10)}");

        calculator = Multiply;

        Console.WriteLine($"Multiply : {calculator(10, 20)}");

        Console.WriteLine();

        Console.WriteLine("===== Delegate as parameter =====");
        ExecuteOperation(10, 20, Add);
        ExecuteOperation(20, 10, Subtract);
        ExecuteOperation(10, 20, Multiply);

        Console.WriteLine();

        Console.WriteLine("===== Multicast Delegate =====");

        Action action = FirstMessage;

        action += SecondMessage;

        action();

        Console.WriteLine();

    }

        private static void FirstMessage()
        {
            Console.WriteLine("First method executed");
        }

        private static void SecondMessage()
        {
            Console.WriteLine("Second method executed");
        }
}
