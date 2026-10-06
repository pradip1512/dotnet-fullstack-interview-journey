using System;
using System.Collections.Generic;
using System.Text;

namespace Day15_DelegatesLambdas;

public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Salary { get; set; }

    public bool IsActive { get; set; }

    public void Display()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Salary: {Salary}, IsActive: {IsActive}");
    }
}
