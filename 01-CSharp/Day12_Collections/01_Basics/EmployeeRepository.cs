using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_Collections;

public class EmployeeRepository
{
    private readonly List<Employee> _employees = new();

    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    public List<Employee> GetAllEmployees()
    {
        return _employees;
    }

    public Employee? GetEmployeeById(int employeeId)
    {
        return _employees.FirstOrDefault(_employees => _employees.EmployeeId == employeeId);
    }
}
