using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_AsyncAwait;

public class EmployeeDashboard
{
    public List<Employee> Employees { get; set; } = [];
    public List<Project> Projects { get; set; } = [];

    public List<TaskItem> Tasks { get; set; } = [];
}
