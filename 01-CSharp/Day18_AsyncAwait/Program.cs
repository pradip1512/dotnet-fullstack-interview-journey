using Day18_AsyncAwait;

public class Program
{
    public static async Task Main()
    {
        Console.WriteLine("Async/Await Examples");

        await BasicAsyncExamples.RunAsync();

        Console.WriteLine();

        await TaskReturnExamples.RunAsync();
        Console.WriteLine();

        await ConcurrentTasksExamples.RunAsync();
        Console.WriteLine();

        await AsyncExceptionExamples.RunAsync();
        Console.WriteLine();

        await CancellationExamples.RunAsync();
        Console.WriteLine();

        Console.WriteLine("==== Employee Dashboard ====");

        EmployeeDashboardService service = new();

        using CancellationTokenSource cts = new();

        try
        {
            DateTime startTime = DateTime.Now;

            EmployeeDashboard dashboard = await service.LoadDashboardAsync(cts.Token);

            TimeSpan elapsed = DateTime.Now - startTime;

            Console.WriteLine($"Employees: {dashboard.Employees.Count}");

            Console.WriteLine($"Projects: {dashboard.Projects.Count}");

            Console.WriteLine($"Tasks: {dashboard.Tasks.Count}");

            Console.WriteLine($"Elapsed time: {elapsed.TotalSeconds} seconds");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Dashboard loading was canceled.");
        }
    }
}
