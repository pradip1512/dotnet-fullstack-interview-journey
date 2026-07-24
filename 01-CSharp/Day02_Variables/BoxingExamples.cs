using System;
using System.Collections.Generic;
using System.Text;

namespace Day02_Variables
{
    public class BoxingExamples
    {
        public void RunBoxingExamples()
        {
            Console.WriteLine("============== Boxing ================");

            int number = 10;

            object boxed = number;

            Console.WriteLine($"Original : {number}");
            Console.WriteLine($"Boxed : {boxed}");

            Console.WriteLine("\n=============== Unboxing ===================");

            int unboxed = (int)boxed;

            Console.WriteLine($"Unboxed : {unboxed}");

            Console.WriteLine("\n================ Wrong Unboxing ===================");
            object text = "Hello";

            try
            {
                int value = (int)text;
                Console.WriteLine($"Value : {value}");
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");

            }

            Console.WriteLine("\n================= Object vs Var =================");

            object obj = 100;
            var inferred = 100;

            Console.WriteLine($"Object type : {obj.GetType().Name}");
            Console.WriteLine($"Var type : {inferred.GetType().Name}");


        }
    }
}
