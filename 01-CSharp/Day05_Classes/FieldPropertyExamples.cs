using System;
using System.Collections.Generic;
using System.Text;

namespace Day05_Classes
{
    public class FieldPropertyExamples
    {
        public class Employee
        {
            //1. Field

            private string _name;

            //2. Auto-implemented property
            public string Department { get; set; }

            //3. Property with backing field
            public string Name
            {
                get 
                { 
                    return _name;
                }

                set
                {
                    _name = value;
                }
            }

            //4. Salary property with validation
            private double _salary;
            public double Salary
            {
                get { return _salary; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Salary cannot be negative.");
                    _salary = value;
                }
            }
        }

        public class EmployeeProfile
        {
            //Can not change from outside
            public int Id { get; private set; }

            //Can be changed from outside
            public string Name { get; set; }

            //Assignable only during object initialization
            public string EmployeeCode { get; init; }
           

            //Can be changed from outside
            public string Department { get; set; }

            //constructor to initialize the Id property
            public EmployeeProfile(int id) {
                Id = id;
            }
        }
    }
}
