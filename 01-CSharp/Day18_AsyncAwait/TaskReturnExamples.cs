using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_AsyncAwait;

public static class TaskReturnExamples
{
    public static async Task<int> GetEmployeeCountAsync()
    {
        // Simulate an asynchronous operation
        await Task.Delay(500);
        return 5;
    }

    public static async Task<string> GetEmployeeNameAsync()
    {
        // Simulate an asynchronous operation
        await Task.Delay(500);
        return "Pradip";
    }

    public static async Task RunAsync()
    {
        int count = await GetEmployeeCountAsync();
        Console.WriteLine($"Employee Count: {count}");

        string name = await GetEmployeeNameAsync();
        Console.WriteLine($"Employee Name: {name}");
    }
}
