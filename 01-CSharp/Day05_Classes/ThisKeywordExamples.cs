using System;
using System.Collections.Generic;
using System.Text;

namespace Day05_Classes
{
    public class ThisKeywordExamples
    {
        public class Employee
        {
            public string Name { get; set; }
            public string Department { get; set; }

            public decimal Salary { get; set; }

            public Employee(string name, string department, decimal salary)
            {
                this.Name = name;
                this.Department = department;
                this.Salary = salary;
            }

            public Employee()
            {
                Name = "Unknown";
                Department = "Unknown";
                Salary = 0;

            }

            public Employee (string name) : this(name, "Unknown", 0)
            {
                Name = name;
                Department = "IT";
                Salary = 0;
            } 
            
            public Employee (string name, string department, int salary) : this(name, department, (decimal)salary)
            {
                Name = name;
                Department = department;
                Salary = 60000;
            } 
            
            public void Display()
            {
                Console.WriteLine($"Employee Name: {this.Name}");
                Console.WriteLine($"Employee Department: {this.Department}");
                Console.WriteLine($"Employee Salary: {this.Salary}");
            }


        }

        public class Project
        {
            public string ProjectName { get; set; }
            public string ClientName { get; set; }

            public decimal Budget { get; set; }

            public Project()
            {
                ProjectName = "WorkSphere";
                ClientName = "Unknown";
                Budget = 0;

            }

            public Project(string projectName) : this(projectName, "Unknown", 0)
            {
            }

            public Project(string projectName, string clientName, decimal budget)
            {
                this.ProjectName = projectName;
                this.ClientName = clientName;
                this.Budget = budget;
            }

            public void Display()
            {
                Console.WriteLine($"Project Name: {this.ProjectName}");
                Console.WriteLine($"Client Name: {this.ClientName}");
                Console.WriteLine($"Project Budget: {this.Budget}");
            }

        }
    }
}
