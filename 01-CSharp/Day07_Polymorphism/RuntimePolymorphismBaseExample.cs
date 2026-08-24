using System;
using System.Collections.Generic;
using System.Text;

namespace Day07_Polymorphism
{
    public class RuntimePolymorphismBaseExample
    {
        public class Employee
        {
            public virtual void Work()
            {
                Console.WriteLine("Employee is Working");
            }
        }
        public class Developer : Employee
        {
            public override void Work()
            {
                base.Work();
                Console.WriteLine("Deevelolper is Coding");

            }
        }
        public class Manager : Employee
        {
            public override void Work()
            {
                base.Work();
                Console.WriteLine("Manager is managing team");
            }
        }
    }
}
