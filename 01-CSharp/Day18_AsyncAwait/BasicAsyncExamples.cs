using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_AsyncAwait;

public static class BasicAsyncExamples
{
    public static async Task RunAsync()
    {
        Console.WriteLine("Starting ...");

        await Task.Delay(1000); // Simulate an asynchronous operation
        Console.WriteLine("Async operation completed.");
    }
}
