using Day05_Classes;

FieldPropertyExamples.Employee employee = new FieldPropertyExamples.Employee();
employee.Name = "Pradip";
employee.Department = "IT";
employee.Salary = 60000;

Console.WriteLine($"Employee Name: {employee.Name}");
Console.WriteLine($"Employee Department: {employee.Department}");
Console.WriteLine($"Employee Salary: {employee.Salary}");

Console.WriteLine("\n---------------- Mini Challenge---------------------");
// Creating an instance of EmployeeProfile using object initializer
FieldPropertyExamples.EmployeeProfile employeeProfile = new FieldPropertyExamples.EmployeeProfile(101)
{
    Name = "Pradip",
    EmployeeCode = "E101",
    Department = "IT"   
};

//1.Which property can be changed from outside the class?
employeeProfile.Name = "Rahul";
employeeProfile.Department = "HR";


//2.which propert can not be changed from outside the class?
//employeeProfile.Id = 102;// This will cause a compile-time error because Id has a private setter.
//employeeProfile.EmployeeCode = "E102"; // This will cause a compile-time error because EmployeeCode is an init-only property.

Console.WriteLine($"Employee Profile Id: {employeeProfile.Id}");
Console.WriteLine($"Employee Profile Name: {employeeProfile.Name}");
Console.WriteLine($"Employee Profile EmployeeCode: {employeeProfile.EmployeeCode}");
Console.WriteLine($"Employee Profile Department: {employeeProfile.Department}");

Console.WriteLine("\n---------------- Access Modifiers-----------");
Employee emp = new Employee();
emp.Name = "Pradip";
emp.SetSalary(60000);
Console.WriteLine($"Salary of {emp.Name} is: {emp.GetSalary()}");
//emp._salary = 70000; // This will cause a compile-time error because _salary is private and cannot be accessed from outside the class.

Developer developer = new Developer();
developer.DisplayEmployeeInfo();
//developer.Department = "HR"; // This will cause a compile-time error because Department is protected and cannot be accessed from outside the class or its derived classes.


EmployeeService employeeService = new EmployeeService();
employeeService.ProcessEmployee();
//employeeService.LogInternal(); // This will cause a compile-time error because LogInternal is private and cannot be accessed from outside the class.

Console.WriteLine("\n----------------  This Keyword Examples---------------------");
ThisKeywordExamples.Employee employee1 = new ThisKeywordExamples.Employee();
employee1.Display();
employee1 = new ThisKeywordExamples.Employee("Pradip");
employee1.Display();
employee1 = new ThisKeywordExamples.Employee("Pradip", "IT", 60000);
employee1.Display();

Console.WriteLine("\n----------------  Project Examples---------------------");
ThisKeywordExamples.Project project1 = new ThisKeywordExamples.Project("WorkSphere");
project1.Display();

Console.WriteLine("\n----------------  Const Examples---------------------");
Console.WriteLine($"Company Name: {ConstReadonlyExamples.ApplicationConfiguration.CompanyName}");
Console.WriteLine($"Country: {ConstReadonlyExamples.ApplicationConfiguration.Country}");
Console.WriteLine($"Application Version: {ConstReadonlyExamples.ApplicationConfiguration.ApplicationVersion}");
Console.WriteLine("\n----------------  Readonly Examples---------------------");
ConstReadonlyExamples.Employee employee2 = new ConstReadonlyExamples.Employee("Pradip", 101, 2020);
employee2.Display();
Console.WriteLine("\n----------------  Static Readonly Examples---------------------");
Console.WriteLine($"Application Name: {ConstReadonlyExamples.ApplicationSettings.ApplicationName}");
Console.WriteLine($"Environment: {ConstReadonlyExamples.ApplicationSettings.Environment}");

Console.WriteLine("\n----------------  Product Examples---------------------");
ConstReadonlyExamples.Product product1 = new ConstReadonlyExamples.Product(1001, "Laptop", 750000, 2026);
product1.Display();

Console.WriteLine("\n----------------  Static Examples---------------------");
Console.WriteLine($"Addition: {StaticClassExamples.NumberUtility.Add(10, 20)}");
Console.WriteLine($"Subtraction: {StaticClassExamples.NumberUtility.Subtract(20, 10)}");
Console.WriteLine($"Multiplication: {StaticClassExamples.NumberUtility.Multiply(10, 20)}");

//NumberUtility utility = new NumberUtility();// This will cause a compile-time error because NumberUtility is a static class and cannot be instantiated.
Console.WriteLine("\n----------------  Mini Challenge ---------------------");
StaticClassExamples.ApplicationInfo.DispalyInfo();