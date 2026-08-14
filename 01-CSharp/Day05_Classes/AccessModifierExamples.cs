using System;
using System.Collections.Generic;
using System.Text;

namespace Day05_Classes
{
    public class Employee
    {
        public string Name { get; set; }

        private decimal _salary;

        protected string Department = "IT";

        public void SetSalary(decimal salary)
        {
            if (salary < 0)
            {
                throw new ArgumentException("Salary cannot be negative.");
            }
            _salary = salary;
        }

        public decimal GetSalary()
        {
            return _salary;
        }
    }

    public class Developer : Employee
    {
        protected string Technology = "C#";

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Department : {Department}");
        }
    }

    public class EmployeeService
    {
        private string _serviceName = "Employee Service";

        public void ProcessEmployee()
        {
            Console.WriteLine("Processing Employee...");
        }

        private void LogInternal()
        {
            Console.WriteLine("Internal Log.");
        }
    }
}
