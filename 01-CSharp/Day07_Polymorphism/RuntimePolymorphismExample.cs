using System;
using System.Collections.Generic;
using System.Text;

namespace Day07_Polymorphism
{
    public class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is working.");
        }
        public class Developer : Employee
        {
            public override void Work()
            {
                Console.WriteLine("Developer is coding");
            }

        }
        public class Manager : Employee
        {
            public override void Work()
            {
                Console.WriteLine("Manager is managing the team");
            }
        }
    }
}
