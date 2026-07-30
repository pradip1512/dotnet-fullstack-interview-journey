using System;
using System.Collections.Generic;
using System.Text;

namespace Day03_Operators
{
    public static class LoopExamples
    {
        //New Reusable helper method to run loop examples
        public static void PrintHeading (string heading)
        {
            Console.WriteLine($"\n========== {heading} ==============");
        }

        public static void RunForLoopExample()
        {
            PrintHeading("FOR LOOP");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            PrintHeading("FOR LOOP (Even Numbers)");
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public static void RunWhileLoopExample() 
        { 
            PrintHeading("WHILE LOOP");

            int i = 10;

            while (i >= 1) 
            { 
                Console.WriteLine(i);
                i--;
            }
        }

        public static void RunDoWhileLoopExample()
        {
            PrintHeading("DO-WHILE LOOP");

            int attempt = 1;

            do 
            {
                Console.WriteLine($"Attempt  {attempt}");
                attempt++;
            }
            while (attempt <= 3);
        }

        public static void RunForeachLoopExample() 
        {
            PrintHeading("FOR-EACH LOOP");

            string[] technologies =
            {
                "C#",
                ".NET",
                "Angular",
                "PostgreSQL",
                "Azure"
            };

            foreach(string technology in technologies)
            {
                Console.WriteLine($"Technology: {technology}");
            }
        }

        public static void RunBreakExample() 
        {
            PrintHeading("BREAK EXAMPLE");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5) 
                {
                    break;
                }
                Console.WriteLine(i);

            }
        }

        public static void RunContinueExample() 
        {
            PrintHeading("CONTINUE EXAMPLE");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public static void RunMultiplicationTableExample()
        {
            PrintHeading("MULTIPLICATION TABLE");
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine($" 5 x {i} = {5 * i}");
            }
        }
    }
}
