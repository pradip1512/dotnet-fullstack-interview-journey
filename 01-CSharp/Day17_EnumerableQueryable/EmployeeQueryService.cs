using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Day17_EnumerableQueryable;

public class EmployeeQueryService
{
    private readonly IEnumerable<Employee> _employees;

    public EmployeeQueryService(IEnumerable<Employee> employees)
    {
        _employees = employees;
    }

    public IEnumerable<Employee> GetActiveEmployees()
    {
        return _employees
            .Where(employee => employee.IsActive);
    }

    public List<Employee> GetActiveEmployeesMaterialized()
    {
        return _employees
            .Where(employee => employee.IsActive)
            .ToList();
    }

    public IEnumerable<Employee> GetHighSalaryEmployees(decimal minimumSalary)
    {
        return _employees
            .Where(employee => employee.Salary > minimumSalary);
    }

    public Employee? GetHighestPaidEmployee()
    {
        return _employees
            .OrderByDescending(employee => employee.Salary)
            .FirstOrDefault();
    }   

    public IEnumerable<Employee> Filter(Expression<Func<Employee, bool>> expression)
    {
        Func<Employee, bool> compiled = expression.Compile();
        return _employees.Where(compiled);
    }
    
    public IEnumerable<String> GetDepartment()
    {
        return _employees.Select(employee => employee.Department)
            .Distinct();
    }

    public IEnumerable<Employee> GetEmployeesByDepartment(string department)
    {
        return _employees
            .Where(employee => string
            .Equals(employee.Department, department, StringComparison.OrdinalIgnoreCase));
    }
}
