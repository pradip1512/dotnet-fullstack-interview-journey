using System;
using System.Collections.Generic;
using System.Text;


namespace Day19_ResourceManagement;

public class EmployeeReportService
{
    public void GenerateReport(
        IEnumerable<Employee> employees,
        string filePath)
    {
        ArgumentNullException.ThrowIfNull(employees);
        ArgumentException.ThrowIfNullOrWhiteSpace(filePath);

        using StreamWriter writer = new(filePath);

        writer.WriteLine("WorkSphere Employee Report");
        writer.WriteLine("==========================");

        foreach (Employee employee in employees)
        {
            writer.WriteLine(
                $"{employee.Id} | {employee.Name} | {employee.Department}");
        }
    }
}
