namespace Day15_DelegatesLambdas;

public class Program
{
    public static void Main() 
    {
        DelegateExamples.Run();
        LambdaExamples.Run();
        FuncActionPredicateExamples.Run();

        Console.WriteLine("====== WorkSphere Employee processing ======");

        List<Employee> employees =
            [
                new Employee { Id = 1, Name = "Pradip", Salary = 60000, IsActive = true },
                new Employee { Id = 2, Name = "Rahul", Salary = 55000, IsActive = false },
                new Employee { Id = 3, Name = "Amit", Salary = 70000, IsActive = true },
            ];
        EmployeeProcessor processor = new();

        Console.WriteLine();
        Console.WriteLine("Active Employees:");

        List<Employee> activeEmployee = processor.process(employees, employee => employee.IsActive);

        foreach (Employee employee in activeEmployee)
        {
            employee.Display();
        }

        Console.WriteLine();
        Console.WriteLine("Employees with Salary > 60000:");

        List<Employee> highSalaryEmployee = processor.process(employees, employee => employee.Salary > 60000);

        foreach (Employee employee in highSalaryEmployee)
        {
            employee.Display();
        }

        Console.WriteLine();
        Console.WriteLine("======Employees whose name starts with 'P'======");

        List<Employee> employeeStartsWithP = processor.process(employees, employee => employee.Name.StartsWith("P", StringComparison.OrdinalIgnoreCase));

        foreach (Employee employee in employeeStartsWithP)
        {
            employee.Display();
        }
    }
}
