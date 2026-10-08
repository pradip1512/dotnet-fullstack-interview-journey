using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_LINQ;

public static class GroupingExamples
{
    public static void Run()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Pradip", Department = "IT", Salary = 70000, IsActive = true },
            new Employee { Id = 2, Name = "Rahul", Department = "IT", Salary = 55000, IsActive = true },
            new Employee { Id = 3, Name = "Amit", Department = "HR", Salary = 80000, IsActive = false },

        };

        var result = employees
            .GroupBy(e => e.Department)
            .Select (group => new
            {
                Department = group.Key,
                EmployeeCount = group.Count(),
                AverageSalary = group.Average(e => e.Salary)
            });

        foreach (var group in result)
        {
            Console.WriteLine($"Department: {group.Department}, Employee Count: {group.EmployeeCount}, Average Salary: {group.AverageSalary}");
        }
    }
}
