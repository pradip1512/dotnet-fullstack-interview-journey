using System;
using System.Collections.Generic;
using System.Text;

namespace Day02_Variables
{
    public class TypeCastingExamples
    {
        public void RunImplicitAndExplicitExamples()
        {
            Console.WriteLine("===== Implicit Conversion =====");

            int age = 27;
            long population = age;
            double salary = age;
            char grade = 'A';
            int asciiValue = grade;

            Console.WriteLine($" Age: {age}");
            Console.WriteLine($"Population: {population}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"AsciiValue: {asciiValue}");

            Console.WriteLine("\n ===== Explicit Conversion ====");

            double price = 99.99;
            int amount = (int)price;
            long totalUsers = 5_000_000_000;
            int users = (int)totalUsers;

            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Total Users: {totalUsers}");
            Console.WriteLine($"Users: {users}");

            
        }

        public void RunParsingExamples()
        {
            Console.WriteLine("\n ===== Convert class =====");
            string ageText = "27";
            string salaryText = "25000.75";
            string activeText = "true";

            int age = Convert.ToInt32(ageText);
            decimal salary = Convert.ToDecimal(salaryText);
            bool isActive = Convert.ToBoolean(activeText);

            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Salary : {salary}");
            Console.WriteLine($"IsActive : {isActive}");

            Console.WriteLine("\n=============== Parse ===============");
            string marks = "95";
            int totalMarks = int.Parse(marks);
            Console.WriteLine($"Total Marks: {marks}");

            //Test Invalid inputs
            Console.WriteLine("----------------Invalid Input--------------------");
            try
            {
                string inValid = "ABC";
                int.Parse(inValid);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }


            Console.WriteLine("\n============= TryParse ===============");

            string input = "250";
            bool success = int.TryParse(input, out int result);

            Console.WriteLine($"Success : {success}");
            Console.WriteLine($"Result : {result}");

            string invalidInput = "ABC";
            bool failed = int.TryParse(invalidInput, out int invalidResult);

            Console.WriteLine($"Failed : {failed}");
            Console.WriteLine($"Invalid Result : {invalidResult}");

            Console.WriteLine("\n================== Var =======================");
            var name = "Pradip";
            var ageNumber = 27;
            var salaryAmount = 25000.75;

            Console.WriteLine(name);
            Console.WriteLine(ageNumber);
            Console.WriteLine(salaryAmount);

            Console.WriteLine("\n================== Dynamic =======================");
            dynamic value = 10;
            Console.WriteLine(value);

            value = "Hello";
            Console.WriteLine(value);

            value = true;
            Console.WriteLine(value);

            value = 25.75;
            Console.WriteLine(value);

        }

        public void RunEmployeeInputExample()
        {
            Console.WriteLine("\n================= Employee Details =====================");
            Console.Write("Enter Name: ");
            string name = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Age:");

            bool validAge = int.TryParse(Console.ReadLine(), out int age);

            Console.Write("Enter Salary:");

            bool validSalary = decimal.TryParse(Console.ReadLine(), out  decimal salary);

            if (validAge && validSalary)
            {
                Console.WriteLine("\nEmployee Information");
                Console.WriteLine($"Name : {name}");
                Console.WriteLine($"Age : {age}");
                Console.WriteLine($"Salary : {salary}");
            }
            else
            {
                Console.WriteLine("Invalid Age or Salary entered.");
            }


        }
    }
}
