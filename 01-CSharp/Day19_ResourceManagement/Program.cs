
namespace Day19_ResourceManagement;

public class Program
{
    public static void Main()
    {
        ResourceExamples.Run();
        ExceptionCleanupExample.Run();
        SpanExamples.Run();

        Console.WriteLine();
        Console.WriteLine("=== WorkSphere Report ===");

        List<Employee> employees =
        [
            new Employee
            {
                Id = 1,
                Name = "Pradip",
                Department = "Engineering"
            },
            new Employee
            {
                Id = 2,
                Name = "Rahul",
                Department = "Finance"
            },
            new Employee
            {
                Id = 3,
                Name = "Sneha",
                Department = "Human Resources"
            }
        ];

        EmployeeReportService service = new();

        string filePath = Path.Combine(
            AppContext.BaseDirectory,
            "WorkSphereEmployees.txt");

        service.GenerateReport(employees, filePath);

        Console.WriteLine($"Report created: {filePath}");
        Console.WriteLine(File.ReadAllText(filePath));
    }
}
