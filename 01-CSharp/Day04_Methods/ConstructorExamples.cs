using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day04_Methods
{
    public class ConstructorExamples
    {
        //employee class with default constructor

        public class Employee
        {
            //properties
            public string Name { get; set; }
            public string Department { get; set; }
            public decimal Salary { get; set; }

            //1. Default constructor
            public Employee()
            {
                Console.WriteLine("Default Constructor called");
            }

            //2. Default constructor with Name
            public Employee(string name)
            {
                Name = name;
                Console.WriteLine("Constructor called with Name");
            }

            //3. Default constructor with Name + Department

            public Employee(string name, string department) : this(name)
            {
                Department = department;
                Console.WriteLine("Constructor called with Name + Department");
            }

            //4. Parameterized constructor with Name + Department + Salary
            public Employee(string name, string department, decimal salary) : this(name, department)
            {
                Salary = salary;
                Console.WriteLine("Constructor called with Name + Department + Salary");
            }

            //Display method to show employee details
            public void Display()
            {
                Console.WriteLine($"Name: {Name}, Department: {Department}, Salary: {Salary}");
            }
        }
    }
}
