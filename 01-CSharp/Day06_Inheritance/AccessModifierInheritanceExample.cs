using System;
using System.Collections.Generic;
using System.Text;

namespace Day06_Inheritance
{
    public class AccessModifierInheritanceExample
    {
        public class Employee
        {
            public string Name { get; set; }

            protected string Department { get; set; }

            private decimal Salary { get; set; }

            public Employee(string name, string department, decimal salary)
            {
                Name = name;
                Department = department;
                Salary = salary;
            }

            public void DisplayEmployee()
            {
                Console.WriteLine($"Name : {Name}");
                Console.WriteLine($"Department : {Department}");
                Console.WriteLine($"Salary : {Salary}");
            }
        }

        public class Developer : Employee
        {
            public string ProgrammingLanguage { get; set; }
            
            public Developer(string name, string department, decimal salary, string programmingLanguage) : base(name, department, salary)
            {
                ProgrammingLanguage = programmingLanguage;
            }

            public void DisplayDeveloper()
            {
                Console.WriteLine($"Name : {Name}");
                Console.WriteLine($"Department : {Department}");
                //Console.WriteLine($"Salary : {Salary}"); // This line will cause a compilation error because Salary is private in the base class    
                Console.WriteLine($"Programming Language : {ProgrammingLanguage}");
            }
        }

    }
}
