using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_Collections._02_Challenge;

public class WorkSphereEmployeeManager
{
    private readonly List<Employee> _employees = new();

    private readonly Dictionary<int, Employee> _employeeDictionary = new();

    private readonly HashSet<string> _departments = new();

    private readonly Queue<Employee> _processingQueue = new();

    private readonly Stack<Employee> _recentlyViewed = new();

    public void AddEmployee(Employee employee)
    {
        if (_employeeDictionary.ContainsKey(employee.EmployeeId))
        {
            Console.WriteLine("Employee ID already exists.");

            return;
        }

        _employees.Add(employee);

        _employeeDictionary.Add(employee.EmployeeId, employee);

        _departments.Add(employee.Department);

        Console.WriteLine($"Employee {employee.Name} added successfully.");
    }

    public Employee? GetEmployeeById(int employeeId)
    {
        if (_employeeDictionary.TryGetValue(employeeId, out Employee? employee))
        {
            return employee;
        }

        return null;
    }

    public void DisplayAllEmployees()
    {
        Console.WriteLine("\n====== All Employees ======");

        foreach (Employee employee in _employees)
        {
            employee.Display();

            Console.WriteLine();
        }
    }

    public void DisplayDepartments()
    {
        Console.WriteLine("\n====== Departments ======");

        foreach (string department in _departments)
        {
            Console.WriteLine(department);
        }
    }

    public void AddEmployeeToProcessingQueue(int employeeId)
    {
        Employee? employee = GetEmployeeById(employeeId);

        if (employee == null)
        {
            Console.WriteLine("Employee not found.");

            return;
        }

        _processingQueue.Enqueue(employee);

        Console.WriteLine($"{employee.Name} added to processing queue.");
    }

    public void ProcessNextEmployee()
    {
        if (_processingQueue.Count == 0)
        {
            Console.WriteLine("No employees in processing queue.");

            return;
        }

        Employee employee = _processingQueue.Dequeue();

        Console.WriteLine($"Processing employee: {employee.Name}");
    }

    public void ViewEmployee(int employeeId)
    {
        Employee? employee = GetEmployeeById(employeeId);

        if (employee == null)
        {
            Console.WriteLine("Employee not found.");

            return;
        }

        _recentlyViewed.Push(employee);


        Console.WriteLine("\n====== Employee Details ======");

        employee.Display();
    }

    public void GoBack()
    {
        if (_recentlyViewed.Count == 0)
        {
            Console.WriteLine("No previous employee available.");

            return;
        }

        Employee employee = _recentlyViewed.Pop();

        Console.WriteLine($"Going back from: {employee.Name}");
    }
}
