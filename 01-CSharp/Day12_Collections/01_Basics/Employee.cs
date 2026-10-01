using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_Collections;

public class Employee
{
    public int EmployeeId { get; init; }

    public string Name { get; set; }

    public string Department { get; set; }

    public Employee(int employeeId, string name, string department)
    {
        EmployeeId = employeeId;
        Name = name;
        Department = department;
    }
    public void Display()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}, Name: {Name}, Department: {Department}");
    }
}
