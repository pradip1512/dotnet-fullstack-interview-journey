using System;
using System.Collections.Generic;
using System.Text;

namespace Day07_Polymorphism
{
    public class MethodHidingExample
    {
        public class Employee
        {
            public void Work()
            {
                Console.WriteLine("Employee is working");
            }
        }
        public class Developer : Employee
        {
            public new void Work()
            {
                Console.WriteLine("Developer is coding");
            }
        }
    }
}
