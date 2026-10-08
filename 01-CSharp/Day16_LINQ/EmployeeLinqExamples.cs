using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_LINQ;

public static class EmployeeLinqExamples
{
    public static void Run()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Pradip", Department = "IT", Salary = 60000, IsActive = true },
            new Employee { Id = 2, Name = "Rahul", Department = "IT", Salary = 55000, IsActive = true },
            new Employee { Id = 3, Name = "Amit", Department = "HR", Salary = 80000, IsActive = false },
            new Employee { Id = 4, Name = "Sneha", Department = "Finance", Salary = 90000, IsActive = true },
        };

        Console.WriteLine("==== Active Employees ====");
        var activeEmployees = employees.Where(e => e.IsActive).ToList();
        foreach (Employee employee in activeEmployees)
        {
            Console.WriteLine(employee.Name);
        }
        Console.WriteLine();

        Console.WriteLine("==== High Salary Employees ====");
        var highSalaryEmployees = employees
            .Where(e => e.Salary > 60000)
            .OrderByDescending(e => e.Salary)
            .ToList();
        foreach (Employee employee in highSalaryEmployees)
        {
            Console.WriteLine($"{employee.Name} - ${employee.Salary}");
        }
        Console.WriteLine();

        Console.WriteLine("==== Employees Names ====");
        var employeeNames = employees
            .Select(e => e.Name)
            .ToList();
        foreach (string name in employeeNames)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();

        Console.WriteLine("==== Active Employees Names ====");
        var activeEmployeeNames = employees
            .Where(e => e.IsActive)
            .Select(e => e.Name)
            .ToList();
        foreach (string name in activeEmployeeNames)
        {
            Console.WriteLine(name);
        }
    }
}
