using System;
using System.Collections.Generic;
using System.Text;

namespace Day07_Polymorphism
{
    public class WorkSpherePolymorphismChallenge
    {
        public class Employee
        {
            public string Name { get; set; }
            public int EmployeeId { get; set; }

            public string Department { get; set; }  

            public virtual void Work()
            {
                Console.WriteLine("Employee is working.");
            }
        }

        public class Developer : Employee
        {
            public string ProgrammingLanguage { get; set; }
            public override void Work()
            {
                Console.WriteLine($"Developer is coding in {ProgrammingLanguage}.");
            }
        }

        public class Manager : Employee
        {
            public int TeamSize { get; set; }
            public override void Work()
            {
                Console.WriteLine($"Manager is managing a team of {TeamSize} members.");
            }
        }
    }
}
