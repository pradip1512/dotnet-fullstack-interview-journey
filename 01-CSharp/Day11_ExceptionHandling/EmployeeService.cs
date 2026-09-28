using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_ExceptionHandling;

public class EmployeeService
{
    public void ValidateEmployeeName(string name)
    {
        ArgumentNullException.ThrowIfNull(name);

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Employee name cannot be empty", nameof(name));
        }
        Console.WriteLine($"Employee name '{name}' is valid");
    }

    public void ValidateAge(int age)
    {
        if (age < 18 || age > 65)
        {
            throw new ArgumentOutOfRangeException(nameof(age), "Employee age must be between 18 and 65");
        }
        Console.WriteLine($"Employee age '{age}' is valid");
    }
}
