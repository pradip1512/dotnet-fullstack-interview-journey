using System;
using System.Collections.Generic;
using System.Text;

namespace Day03_Operators
{
    public class SwitchExamples
    {
        public static void RunDayExample()
        {
            Console.WriteLine("\n========== Day Example ==============");

            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is Monday.");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday.");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednesday.");
                    break;
                default:
                    Console.WriteLine("Invalid day number.");
                    break;
            }

        }

        public static void RunGradeExample()
        {
            Console.WriteLine("\n========== Grade Example ==============");

            char grade = 'A';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Well done!");
                    break;
                case 'C':
                    Console.WriteLine("Good!");
                    break;
                default:
                    Console.WriteLine("Invalid grade.");
                    break;
            }
        }

        public static void RunCalculatorExample() 
        {
            Console.WriteLine("\n========== Calculator Example ==============");

            double a = 20;
            double b = 10;

            double result = 0;

            char operation = '+';

            switch(operation)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }
            Console.WriteLine($"Result = {result}");
        }

        public static void RunMonthExample() 
        {
            Console.WriteLine("\n================= Month Example =================");

            int month = 7;

            switch (month) 
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                    case 4:
                        Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;  
                default:
                    Console.WriteLine("Invalid month number.");
                    break;
            }

        }
    }
}
