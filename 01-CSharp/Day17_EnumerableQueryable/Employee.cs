using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_EnumerableQueryable
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;

        public decimal Salary { get; set; }

        public bool IsActive { get; set; }
    }
}
