using System;
using System.Collections.Generic;
using System.Text;

namespace Day03_Operators
{
    public class OperatorExamples
    {
        public static void RunArithmeticExamples()
        {
            
            int a = 20;
            int b = 10;

            Console.WriteLine("\n================== ArithmeticExamples ==========================");

            Console.WriteLine($" Addition: {a + b}");
            Console.WriteLine($" Subtraction: {a - b}");
            Console.WriteLine($" Multiplication: {a * b}");
            Console.WriteLine($" Division: {a / b}");
            Console.WriteLine($" Modulus: {a % b}");
        }

        public static void RunAssignmentExamples()
        {
            int a = 20;
            int b = 10;

            Console.WriteLine("\n================== AssignmentExamples ==========================");
            a += b; // a = a + b
            Console.WriteLine($" a += b: {a}");
            a -= b; // a = a - b
            Console.WriteLine($" a -= b: {a}");
            a *= b; // a = a * b
            Console.WriteLine($" a *= b: {a}");
            a /= b; // a = a / b
            Console.WriteLine($" a /= b: {a}");
            a %= b; // a = a % b
            Console.WriteLine($" a %= b: {a}");
        }

        public static void RunComparisonExamples()
        {
            int a = 20;
            int b = 10;

            Console.WriteLine("\n================== ComparisonExamples ==========================");
            Console.WriteLine($" a == b: {a == b}");
            Console.WriteLine($" a != b: {a != b}");
            Console.WriteLine($" a > b: {a > b}");
            Console.WriteLine($" a < b: {a < b}");
            Console.WriteLine($" a >= b: {a >= b}");
            Console.WriteLine($" a <= b: {a <= b}");
        }

        public static void RunLogicalExamples()
        {
            bool a = true;
            bool b = false;

            Console.WriteLine("\n================== LogicalExamples ==========================");
            Console.WriteLine($" a && b: {a && b}");
            Console.WriteLine($" a || b: {a || b}");
            Console.WriteLine($" !a: {!a}");
            Console.WriteLine($" !b: {!b}");
        }

        public static void RunIncrementDecrementExamples()
        {
            int a = 20;

            Console.WriteLine("\n================== IncrementDecrementExamples ==========================");
            Console.WriteLine($" a++: {a++}"); // Post-increment
            Console.WriteLine($" ++a: {++a}"); // Pre-increment
            Console.WriteLine($" a--: {a--}"); // Post-decrement
            Console.WriteLine($" --a: {--a}"); // Pre-decrement
        }
    }
}
