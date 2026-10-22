using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_AsyncAwait;

public static class AsyncExceptionExamples
{
    private static async Task ProcessAsync()
    {
        await Task.Delay(500);

        throw new InvalidOperationException("Something went wrong.");
    }

    public static async Task RunAsync()
    {
        Console.WriteLine("==== Async Exception Handling ====");

        try
        {
            await ProcessAsync();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Handled exception: {ex.Message}");
        }
    }
}
