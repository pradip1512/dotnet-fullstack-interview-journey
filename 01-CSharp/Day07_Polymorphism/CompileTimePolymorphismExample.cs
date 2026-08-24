using System;
using System.Collections.Generic;
using System.Text;

namespace Day07_Polymorphism
{
    public class SalaryCalculator
    {
        public decimal CalculateSalary(decimal basicSalary)
        {
            return basicSalary;
        }
        public decimal CalculateSalary(decimal basicSalary, decimal bonus)
        {
            return basicSalary + bonus;
        }
        public decimal CalculateSalary(decimal basicSalary, decimal bonus, decimal allowance)
        {
            return basicSalary + bonus + allowance;
        }
    }
}
