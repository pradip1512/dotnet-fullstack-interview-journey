using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_LINQ;

public class EmployeeReportService
{
    private readonly List<Employee> _employees;

    public EmployeeReportService(List<Employee> employees)
    {
        _employees = employees;
    }

    public List<Employee> GetActiveEmployees()
    {
        return _employees
            .Where(employee => employee.IsActive)
            .ToList();
    }

    public List<Employee> GetHighSalaryEmployees()
    {
        return _employees
            .Where(employee => employee.Salary > 60000)
            .OrderByDescending(employee => employee.Salary)
            .ToList();
    }

    public List<string> GetEmployeeNames()
    {
        return _employees
            .Select(employee => employee.Name)
            .ToList();
    }

    public Employee? GetHighestPaidEmployee()
    {
        return _employees
            .OrderByDescending(employee => employee.Salary)
            .FirstOrDefault();
    }

    public bool HasInactiveEmployees()
    {
        return _employees
            .Any(employee => !employee.IsActive);
    }

    public List<string> GetDepartments()
    {
        return _employees
            .Select(employee => employee.Department)
            .Distinct()
            .ToList();
    }

    public IEnumerable<object> GetDepartmentSummary()
    {
        return _employees
            .GroupBy(employee => employee.Department)
            .Select(group => new
            {
                Department = group.Key,
                EmployeeCount = group.Count(),
                AverageSalary = group.Average(
                    employee => employee.Salary)
            });
    }
}
