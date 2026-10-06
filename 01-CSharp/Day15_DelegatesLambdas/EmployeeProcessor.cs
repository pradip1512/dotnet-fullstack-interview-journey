using System;
using System.Collections.Generic;
using System.Text;

namespace Day15_DelegatesLambdas;

public class EmployeeProcessor
{
    public List<Employee> process (List<Employee> employees, Func<Employee, bool> filter)
    {
        return employees.Where(filter).ToList();
    }
}
