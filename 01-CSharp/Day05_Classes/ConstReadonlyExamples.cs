using System;
using System.Collections.Generic;
using System.Text;

namespace Day05_Classes
{
    public class ConstReadonlyExamples
    {
        public class ApplicationConfiguration
        {
            public const string CompanyName = "WorkSphere";

            public const string Country = "India";

            public const string ApplicationVersion = "1.0.0";

        }

        public class Employee
        {
            public string Name { get; set; }

            private readonly int _employeeId;

            private readonly int _joiningYear;

            public Employee(string name, int employeeId, int joiningYear)
            {
                this.Name = name;
                this._employeeId = employeeId;
                this._joiningYear = joiningYear;
            }

            public void Display()
            {
                Console.WriteLine($"Employee Name: {this.Name}");
                Console.WriteLine($"Employee ID: {this._employeeId}");
                Console.WriteLine($"Joining Year: {this._joiningYear}");
            }

        }

        public class ApplicationSettings
        {
            public static readonly string ApplicationName = "WorkSphere Application";
            public static readonly string Environment = "Development";

        }

        public class Product
        {
            public string ProductName { get; set; }
            public int price { get; set; }

            public readonly int ProductId;

            public readonly int CreatedYear;

            public const int TaxRate = 18;


            public Product (int productId, string productName, int price, int createdYear)
            {
                this.ProductId = productId;
                this.ProductName = productName;
                this.price = price;
                this.CreatedYear = createdYear;
            }
            public void Display()
            {
                Console.WriteLine($"Product ID: {this.ProductId}");
                Console.WriteLine($"Product Name: {this.ProductName}");
                Console.WriteLine($"Product Price: {this.price}");
                Console.WriteLine($"Created Year: {this.CreatedYear}");
                Console.WriteLine($"Tax Rate: {Product.TaxRate}%");
            }
        }
    }
}
