using System;
using System.Collections.Generic;
using System.Text;

namespace Day06_Inheritance
{
    public class InheritanceExamples
    {
        public class Employee
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; }

            public string Department { get; set; }

            public Employee( int employeeId, string name, string department)
            {
                EmployeeId = employeeId;
                Name = name;
                Department = department;

                Console.WriteLine("Employee Constructor Called");

            }


            public void DisplayEmployee()
            {
                Console.WriteLine($"Employee Id : {EmployeeId}");
                Console.WriteLine($"Name : {Name}");
                Console.WriteLine($"Department : {Department}");
            }
        }

        public class Developer : Employee
        {
            public string ProgrammingLanguage { get; set; }

            public Developer(string programmingLanguage, int employeeId, string name, string department) : base(employeeId, name, department)
            {
                ProgrammingLanguage = programmingLanguage;
                Console.WriteLine("Developer Constructor Called");
            }

            public void WriteCode() 
            {
                Console.WriteLine($"Programming Language : {ProgrammingLanguage}");
            }
        }

        public class SeniorDeveloper : Developer
        {
            public int YearOfExperience { get; set; }

            public SeniorDeveloper(int yearOfExperience, string programmingLanguage, int employeeId, string name, string department) : base(programmingLanguage, employeeId, name, department)
            {
                YearOfExperience = yearOfExperience;
                Console.WriteLine("Senior Developer Constructor Called");

            }

            public void DisplaySeniorDeveloper()
            {
                Console.WriteLine("\n------Senior Developer ------");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Employee Id: {EmployeeId}");
                Console.WriteLine($"Department: {Department}");
                Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
                Console.WriteLine($"Year of Experience: {YearOfExperience}");


            }
        }

        public class Manager : Employee
        {
            public int TeamSize { get; set; }

            public Manager(int teamSize, int employeeId, string name, string department) : base(employeeId, name, department)
            {
                TeamSize = teamSize;
            }
            public void DisplayManagerInfo()
            {
                Console.WriteLine("\n------Manager ------");
                Console.WriteLine($"Employee Id: {EmployeeId}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Department: {Department}");
                Console.WriteLine($"Team Size: {TeamSize}");
            }
        }
    }
}
