using System;
using System.Collections.Generic;
using System.Text;

namespace Day04_Methods
{
    public class MethodOverridingExamples
    {
        public class Employee
        {
            public virtual double CalculateSalary(double baseSalary)
            {
                return baseSalary;
            }
        }

        public class Developer : Employee
        {
            private const double projectBonus = 5000;
            public override double CalculateSalary(double baseSalary)
            {
                return base.CalculateSalary(baseSalary) + projectBonus;
            }
        }

        public class Manager : Employee
        {
            private const double leadershipBonus = 7000;

            public override double CalculateSalary(double baseSalary)
            {
                return base.CalculateSalary(baseSalary) + leadershipBonus;
            }
        }

        public class HR : Employee
        {
            private const double RecruitmentBonus = 3000;

            public override double CalculateSalary(double baseSalary)
            {
                return base.CalculateSalary(baseSalary) + RecruitmentBonus;
            }
        }

        public class Intern : Employee
        {       
            private const   double Stipend = 1000;
            public override double CalculateSalary(double baseSalary)
            {
                return base.CalculateSalary(baseSalary) + Stipend;
            }
        }
    }
}
