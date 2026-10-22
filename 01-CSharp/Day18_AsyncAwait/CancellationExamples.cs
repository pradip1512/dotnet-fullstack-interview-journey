using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_AsyncAwait;

public static class CancellationExamples
{
    public static async Task ProcessAsync( CancellationToken cancellationToken )
    {
        for (int i = 0; i < 10; i++)
        {
            cancellationToken.ThrowIfCancellationRequested();
            Console.WriteLine($"processing step {i}");

            await Task.Delay(500, cancellationToken);
        }
    }

    public static async Task RunAsync()
    {
        Console.WriteLine("==== Cancellation ====");

        using CancellationTokenSource cts = new();

        try
        {
            Task processingTask = ProcessAsync(cts.Token);
            // Cancel the operation after 2 seconds
            cts.CancelAfter(2000);
            await processingTask;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Processing was canceled.");

        }
    }
}
