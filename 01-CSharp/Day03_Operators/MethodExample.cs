using System;
using System.Collections.Generic;
using System.Text;
using static Day03_Operators.LoopExamples;

namespace Day03_Operators
{
    public class MethodExample
    {
        public static void RunWelcomeExample()
        {
            PrintHeading("WELCOME EXAMPLE(No parameters, No return value)");
            Console.WriteLine("Welcome to DotNet-90Days Journey");
        }

        public static void RunGreetingExample(string name)
        {
            PrintHeading("GREETING EXAMPLE(With parameters, No return value)");
            Console.WriteLine($"Hello {name}");
        }

        public static int RunCurrentYearExample()
        {
            PrintHeading("CURRENT YEAR EXAMPLE(No parameters, With return value)");
            return DateTime.Now.Year;
        }

        public static int RunCalculateRectangleAreaExample(int length, int width)
        {
            PrintHeading("CALCULATE RECTANGLE AREA EXAMPLE(With parameters, With return value)");
            return length * width;
        }
    }
}
