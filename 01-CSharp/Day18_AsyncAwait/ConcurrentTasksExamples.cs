using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_AsyncAwait;

public static class ConcurrentTasksExamples
{
    private static async Task<string> GetEmployeesAsync()
    {
        // Simulate an asynchronous operation
        await Task.Delay(2000);
        return "Employees loaded";
    }

    private static async Task<string> GetProjectsAsync()
    {
        // Simulate an asynchronous operation
        await Task.Delay(3000);
        return "Projects loaded";
    }
    
    public static async Task RunAsync()
    {
        Console.WriteLine("==== Concurrent Tasks ====");

        //start tracking execution time
        DateTime startTime = DateTime.Now;

        //Initiate both tasks concurrently (do not await here!)
        Task<string> employeesTask = GetEmployeesAsync();
        Task<string> projectsTask = GetProjectsAsync();

        await Task.WhenAll(employeesTask, projectsTask);

        //retrieve results after both tasks have completed
        Console.WriteLine(employeesTask.Result);
        Console.WriteLine(projectsTask.Result);

        //Calculate and display total elapsed time
        TimeSpan elapsedTime = DateTime.Now - startTime;
        Console.WriteLine($"Execution time: {elapsedTime.TotalMilliseconds} ms");
        Console.WriteLine($"Total execution time: {elapsedTime.TotalSeconds:F2} seconds");
    }
}
