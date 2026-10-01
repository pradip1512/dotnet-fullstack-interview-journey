using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_Collections._02_Challenge;

public class WorkSphereEmployee
{
    public int EmployeeId { get; init; }
    public string Name { get; set; }
    public string Department { get; set; }

    public WorkSphereEmployee(int employeeId, string name, string department)
    {
        EmployeeId = employeeId;
        Name = name;
        Department = department;
    }

    public void Display()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Department: {Department}");
    }
}