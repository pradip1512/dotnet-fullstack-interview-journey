using System;

namespace Day08_Abstraction
{
    public class AbstractionExamples
    {
        // Abstract Base Class
        public abstract class Employee
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }

            // Protected constructor
            protected Employee(int employeeId, string name, string department)
            {
                EmployeeId = employeeId;
                Name = name;
                Department = department;

                Console.WriteLine("Employee Constructor Executed.");
            }

            // Common implementation
            public void DisplayBasicInfo()
            {
                Console.WriteLine($"Employee Id: {EmployeeId}");
                Console.WriteLine($"Employee Name: {Name}");
                Console.WriteLine($"Employee Department: {Department}");
            }

            // Abstract method - derived classes must implement
            public abstract void Work();
        }

        // Developer
        public class Developer : Employee
        {
            public string ProgrammingLanguage { get; set; }

            public Developer(
                int employeeId,
                string name,
                string department,
                string programmingLanguage)
                : base(employeeId, name, department)
            {
                ProgrammingLanguage = programmingLanguage;

                Console.WriteLine("Developer Constructor Executed.");
            }

            public override void Work()
            {
                Console.WriteLine(
                    $"Developer is writing {ProgrammingLanguage} code.");
            }
        }

        // Manager
        public class Manager : Employee
        {
            public int TeamSize { get; set; }

            public Manager(
                int employeeId,
                string name,
                string department,
                int teamSize)
                : base(employeeId, name, department)
            {
                TeamSize = teamSize;

                Console.WriteLine("Manager Constructor Executed.");
            }

            public override void Work()
            {
                Console.WriteLine(
                    $"Manager is managing a team of {TeamSize} members.");
            }
        }

        // Tester
        public class Tester : Employee
        {
            public string TestingTool { get; set; }

            public Tester(
                int employeeId,
                string name,
                string department,
                string testingTool)
                : base(employeeId, name, department)
            {
                TestingTool = testingTool;

                Console.WriteLine("Tester Constructor Executed.");
            }

            public override void Work()
            {
                Console.WriteLine(
                    $"Tester is testing the application using {TestingTool}.");
            }
        }
    }
}