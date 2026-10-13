using Day17_EnumerableQueryable;

EnumeratorExamples.Run();
Console.WriteLine();
IteratorExamples.Run();
Console.WriteLine();
DeferredExecutionExamples.Run();
Console.WriteLine();
MultipleEnumerationExamples.Run();
Console.WriteLine();
ExpressionExamples.Run();
Console.WriteLine();
Console.WriteLine("==== Employee Query Service ====");
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
        Salary = 80000,
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

EmployeeQueryService service = new(employees);
Console.WriteLine();
Console.WriteLine("==== Active Employees:");
foreach (Employee employee in service.GetActiveEmployees())
{
    Console.WriteLine(employee.Name);
}
Console.WriteLine();

Console.WriteLine("==== High Salary Employees (Salary > 60000):");
foreach (Employee employee in service.GetHighSalaryEmployees(60000))
{
    Console.WriteLine($" - {employee.Name} - ${employee.Salary}");
}
Console.WriteLine();

Console.WriteLine("==== Highest Paid Employee:");
Employee? highestPaid = service.GetHighestPaidEmployee();
if(highestPaid != null)
{
    Console.WriteLine($" - {highestPaid.Name} - ${highestPaid.Salary}");
}
else
{
    Console.WriteLine("No employees found.");
}
Console.WriteLine();

Console.WriteLine("==== Employees in IT Department:");
foreach(Employee employee in service.GetEmployeesByDepartment("IT"))
{
    Console.WriteLine($" - {employee.Name} - ${employee.Salary}");
}
Console.WriteLine();

Console.WriteLine("==== Expression filter: Employees with Salary > 65000");
foreach (Employee employee in service.Filter(emp => emp.Salary > 65000))
{
    Console.WriteLine($" - {employee.Name} - ${employee.Salary}");
}
Console.WriteLine();

Console.WriteLine("==== Departments:");
foreach (string department in service.GetDepartment())
{
    Console.WriteLine($" - {department}");
}

