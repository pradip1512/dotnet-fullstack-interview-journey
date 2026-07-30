using System;
using System.Collections.Generic;
using System.Text;

namespace Day03_Operators
{
    public class ConditionalExamples
    {
        public static void RunIfExample()
        {
            Console.WriteLine("\n========== Voting Eligibility =============");

            int  age = 20;

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
        }

        public static void RunIfElseExample()
        {
            Console.WriteLine("\n========== Even/Odd number =============");

            int number = 7;

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }
        }

        public static void RunElseIfExample()
        {
            Console.WriteLine("\n==========  student Grade Evaluation =============");

            int marks = 85;

            if (marks >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else
            {
                Console.WriteLine("Grade: C");
            }
        }

        public static void RunNestedIfExample()
        {
            Console.WriteLine("\n========== Employee login + Admin Access =============");

            string username = "admin";
            string password = "admin";

            if (username == "admin")
            {
                if (password == "admin")
                {
                    Console.WriteLine("Login successful. Admin access granted.");
                }
                else
                {
                    Console.WriteLine("Invalid password.");
                }
            }
            else
            {
                Console.WriteLine("Invalid username.");
            }
        }

        public static void RunTernaryOperatorExample()
        {
            Console.WriteLine("\n========== Adult/Minor Example =============");
            int age = 20;
            string result = age >= 18 ? "Adult" : "Minor";
            Console.WriteLine($"The person is {result}.");
        }
    }
}
