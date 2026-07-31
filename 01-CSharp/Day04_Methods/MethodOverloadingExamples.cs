using System;
using System.Collections.Generic;
using System.Text;

namespace Day04_Methods
{
    public class MethodOverloadingExamples
    {
        //Resumable helper method to run method overloading examples
        public static void PrintHeading(string heading)
        {
            Console.WriteLine($"\n========== {heading} ==============");
        }

        public static void DisplayEmployee()
        {
            PrintHeading("DISPLAY EMPLOYEE (No parameters)");

            Console.WriteLine("Employee information is not provided");
        }

        public static void DisplayEmployee(string name)
        {
            PrintHeading("DISPLAY EMPLOYEE (With 1 parameter)");

            Console.WriteLine($"Employee Name: {name}");
        }

        public static void DisplayEmployee(string name, string department)
        {
            PrintHeading("DISPLAY EMPLOYEE (With 2 parameters)");
            Console.WriteLine($"Employee Name: {name}, Department: {department}");
        }

        public static int CalculateBonus(int salary)
        {
            PrintHeading("CALCULATE BONUS (by overloading datatype)");
            return (int)(salary * 0.10);
        }

        public static double CalculateBonus(double salary)
        {
            return salary * 0.12;
        }

        public static void DisplayProject(string projectName, int teamsize)
        {
            PrintHeading("Display Project (string, int)");
            Console.WriteLine($"Project : {projectName}");
            Console.WriteLine($"Team Size : {teamsize}");
        }

        public static void DisplayProject(int teamsize, string projectName)
        {
            PrintHeading("Display Project (int, string)");
            Console.WriteLine($"Project : {projectName}");
            Console.WriteLine($"Team Size : {teamsize}");
        }

        public static void RegisterEmployee(string name)
        {
            PrintHeading("Employee Registered");
            Console.WriteLine($"Name: {name}");
        }

        public static void RegisterEmployee(string name, string email)
        {
            PrintHeading("Employee Registered");
            Console.WriteLine($"Name: {name}, Email: {email}");
        }

        public static void RegisterEmployee(string name, string email, string department)
        {
            PrintHeading("Employee Registered");
            Console.WriteLine($"Name: {name}, Email: {email}, Department: {department}");
        }

    }
}
