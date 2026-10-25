using System;
using System.Collections.Generic;
using System.Text;

namespace Day19_ResourceManagement;

public static class ExceptionCleanupExample
{
    public static void Run()
    {
        Console.WriteLine("\n==== Exception and cleanup ====");

        try
        {
            using DemoResource resource = new();
            resource.DoWork();

            throw new InvalidOperationException("Simulated proccesing failure");

        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine($"Caught: {ex.Message}");
        }

        Console.WriteLine("Application continues");
    }
}
