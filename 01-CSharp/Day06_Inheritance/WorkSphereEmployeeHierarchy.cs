using System;
using System.Collections.Generic;
using System.Text;

namespace Day06_Inheritance
{
    public class WorkSphereEmployeeHierarchy
    {
        public class Employee
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; }

            public string Department { get; set; }

            public decimal Salary { get; private set; }

            public Employee (int employeeId, string name, string department, decimal salary)
            {
                EmployeeId = employeeId;
                Name = name;
                Department = department;
                Salary = salary;

                Console.WriteLine("Employee Constructor Executed.");
            }

            public void DisplayEmployee()
            {
                Console.WriteLine($"Employee ID: {EmployeeId}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Department: {Department}");
                Console.WriteLine($"Salary: {Salary}");
            }

        }

        public class Developer : Employee
        {
            public string ProgrammingLanguage { get; set; }

            public Developer(int employeeId, string name, string department, decimal salary, string programmingLanguage)
                : base(employeeId, name, department, salary)
            {
                ProgrammingLanguage = programmingLanguage;
                Console.WriteLine("Developer Constructor Executed.");
            }

            public void WriteCode()
            {
                DisplayEmployee();
                Console.WriteLine($"Programming Language : {ProgrammingLanguage}");
            }
        }

        public class SeniorDeveloper : Developer
        {
            public int YearsOfExperience { get; set; }
            public SeniorDeveloper(int employeeId, string name, string department, decimal salary, string programmingLanguage, int yearsOfExperience)
                : base(employeeId, name, department, salary, programmingLanguage)
            {
                YearsOfExperience = yearsOfExperience;
                Console.WriteLine("Senior Developer Constructor Executed.");
            }
            public void DisplaySeniorDeveloper()
            {
                WriteCode();
                Console.WriteLine($"Years of Experience: {YearsOfExperience}");
            }
        }

        public class Manager : Employee
        {
            public int TeamSize { get; set; }
            public Manager(int employeeId, string name, string department, decimal salary, int teamSize)
                : base(employeeId, name, department, salary)
            {
                TeamSize = teamSize;
                Console.WriteLine("Manager Constructor Executed.");
            }
            public void DisplayManagerInfo()
            {
                DisplayEmployee();
                Console.WriteLine($"Team Size: {TeamSize}");
            }
        }
    }
}
