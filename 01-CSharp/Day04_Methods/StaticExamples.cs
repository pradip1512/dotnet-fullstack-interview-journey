using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Day04_Methods
{
    public class StaticExamples
    {
        // Static method to add two numbers
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Static method to multiply two numbers
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    public class Student
    {
        // Instance property
        public string Name { get; set; }

        // Static property to keep track of the number of students
        public static int StudentCount { get; private set; }

        // Default constructor
        public Student(string name)
        {
            Name = name;
            StudentCount++;
        }

        // Method to display student details
        public void Display()
        {
            Console.WriteLine($"Student Name: {Name}");
        }
    }

    
    public static class CompanyConfiguration
    {
        public static string CompanyName { get; set; } = "WorkSphere";

        public static string CompanyLocation { get; set; } = "India";

        public static void DisplayCompanyInfo()
        {
            Console.WriteLine($"Company Name: {CompanyName}");
            Console.WriteLine($"Company Location: {CompanyLocation}");
        }
    }

}
