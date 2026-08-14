using System;
using System.Collections.Generic;
using System.Text;

namespace Day05_Classes
{
    public class StaticClassExamples
    {
        public static class NumberUtility
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }

            public static int Subtract(int a, int b)
            {
                return a - b;
            }

            public static int Multiply(int a, int b)
            {
                return a * b;
            }
        }

        public static class ApplicationInfo
        {
            public static string ApplicationName { get; } = "WorkSphere";
            public static string Version { get; } = "1.0.0";

            public static string Environment { get; } = "Development";

            public static void DispalyInfo()
            {
                Console.WriteLine($"Application Name: {ApplicationName}");
                Console.WriteLine($"Version: {Version}");
                Console.WriteLine($"Environment: {Environment}");
            }

        }
    }
}
