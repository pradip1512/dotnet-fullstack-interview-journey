namespace Day16_LINQ;

public class Program
{
    public static void Main()
    {
        BasicLinqExamples.Run();

        EmployeeLinqExamples.Run();

        AggregationExamples.Run();

        ElementExamples.Run();

        GroupingExamples.Run();

        SelectManyExamples.Run();

        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("=== Employee Report Challenge ===");
        Console.WriteLine("=================================");

        List<Employee> employees =
        [
            new Employee
            {
                Id = 1,
                Name = "Pradip",
                Department = "IT",
                Salary = 70000,
                IsActive = true
            },

            new Employee
            {
                Id = 2,
                Name = "Rahul",
                Department = "IT",
                Salary = 55000,
                IsActive = true
            },

            new Employee
            {
                Id = 3,
                Name = "Amit",
                Department = "HR",
                Salary = 80000,
                IsActive = false
            },

            new Employee
            {
                Id = 4,
                Name = "Sneha",
                Department = "Finance",
                Salary = 65000,
                IsActive = true
            },

            new Employee
            {
                Id = 5,
                Name = "Neha",
                Department = "HR",
                Salary = 60000,
                IsActive = true
            }
        ];

        EmployeeReportService service =
            new(employees);

        Console.WriteLine();
        Console.WriteLine("=== Active Employees ===");

        foreach (Employee employee in
                 service.GetActiveEmployees())
        {
            Console.WriteLine(employee.Name);
        }

        Console.WriteLine();
        Console.WriteLine("=== High Salary Employees ===");

        foreach (Employee employee in
                 service.GetHighSalaryEmployees())
        {
            Console.WriteLine(
                $"{employee.Name} - {employee.Salary}");
        }

        Console.WriteLine();
        Console.WriteLine("=== Employee Names ===");

        foreach (string name in
                 service.GetEmployeeNames())
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();
        Console.WriteLine("=== Highest Paid Employee ===");

        Employee? highestPaid =
            service.GetHighestPaidEmployee();

        if (highestPaid is not null)
        {
            Console.WriteLine(
                $"{highestPaid.Name} - " +
                $"{highestPaid.Salary}");
        }

        Console.WriteLine();
        Console.WriteLine("=== Inactive Employee Exists ===");

        Console.WriteLine(
            service.HasInactiveEmployees());

        Console.WriteLine();
        Console.WriteLine("=== Departments ===");

        foreach (string department in
                 service.GetDepartments())
        {
            Console.WriteLine(department);
        }

        Console.WriteLine();
        Console.WriteLine("=== Department Summary ===");

        foreach (var summary in
                 service.GetDepartmentSummary())
        {
            Console.WriteLine(summary);
        }
    }
}
