using System;
using System.Collections.Generic;
using System.Text;

namespace Day02_Variables
{
    public class MemoryExamples
    {
        public void RunExample()
        {
            int x = 10;
            int y = x;
            y = 20;

            Console.WriteLine($"Value of x is:  {x}");
            Console.WriteLine($"Value of y is:  {y}");

        }
        
    }

    public class Employee 
        {
        public string Name { get; set; } = string.Empty;

        public void EmployeeExample() 
        { 
            Employee e1 = new Employee();
            e1.Name = "Pradip";

            Employee e2 = e1;

            e2.Name = "Rahul";

            Console.WriteLine($"Employee e1 name is : {e1.Name}");
            Console.WriteLine($"Employee e2 name is : {e2.Name}");
        }

        }
}
