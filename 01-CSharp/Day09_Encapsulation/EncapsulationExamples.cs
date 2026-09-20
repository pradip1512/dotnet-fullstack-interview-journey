using System;
using System.Collections.Generic;
using System.Text;

namespace Day09_Encapsulation
{
    public class EncapsulationExamples
    {
        public class Employee
        {
            public int EmployeeId { get; init; }
            public string Name { get; set; }

            public decimal Salary { get; private set; }

            public string Department { get; private set; }

            public Employee(int employeeId, string name, decimal salary, string department)
            {
                EmployeeId = employeeId;
                Name = name;
                Salary = salary;
                Department = department;
            }

            public void GiveRaise(decimal amount)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Raise amount must be greater than zero.");
                }

                Salary += amount;
            }

            public void ChangeDepartment(string department)
            {
                if (string.IsNullOrWhiteSpace(department))
                {
                    throw new ArgumentException("Department name cannot be empty.");
                }
                Department = department;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Employee ID: {EmployeeId}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Salary: {Salary:C}");
                Console.WriteLine($"Department: {Department}");
            }
        }
    }
}
