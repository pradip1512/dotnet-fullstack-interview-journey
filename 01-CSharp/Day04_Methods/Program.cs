using Day04_Methods;
using static Day04_Methods.MethodOverridingExamples;

Console.WriteLine("\n========== Method Overloading Examples ==========");
MethodOverloadingExamples.DisplayEmployee();
MethodOverloadingExamples.DisplayEmployee("Pradip");
MethodOverloadingExamples.DisplayEmployee("Pradip", "IT");

int bonus = MethodOverloadingExamples.CalculateBonus(50000);
Console.WriteLine($"Calculated 10 % Bonus: {bonus}");
double bonus2 = MethodOverloadingExamples.CalculateBonus(50000.0);
Console.WriteLine($"Calculated 12 % Bonus: {bonus2}");

MethodOverloadingExamples.DisplayProject("WorkSphere", 8);
MethodOverloadingExamples.DisplayProject(8, "WorkSphere");

Console.WriteLine("\n============Enterprise Challenge===========");
MethodOverloadingExamples.RegisterEmployee("Pradip");
MethodOverloadingExamples.RegisterEmployee("Pradip", "pradip@example.com");
MethodOverloadingExamples.RegisterEmployee("Pradip", "pradip@example.com", "IT");

Console.WriteLine("\n=============== Method Overriding ==================");
MethodOverridingExamples.Employee developer = new MethodOverridingExamples.Developer();
MethodOverridingExamples.Employee manager = new MethodOverridingExamples.Manager();
MethodOverridingExamples.Employee hr = new MethodOverridingExamples.HR();
MethodOverridingExamples.Employee intern = new MethodOverridingExamples.Intern();
        
Console.WriteLine($"Developr Salary : {developer.CalculateSalary(40000)}");
Console.WriteLine($"Manager Salary : {manager.CalculateSalary(50000)}");
Console.WriteLine($"HR Salary : {hr.CalculateSalary(30000)}");
Console.WriteLine($"Intern Salary : {intern.CalculateSalary(20000)}");

Console.WriteLine("\n=============== Constructor Examples ==================");
//1. Default constructor
ConstructorExamples.Employee employee1 = new ConstructorExamples.Employee();
employee1.Display();

//2. Default constructor with Name
ConstructorExamples.Employee employee2 = new ConstructorExamples.Employee("Pradip");
employee2.Display();

//3. Default constructor with Name + Department
ConstructorExamples.Employee employee3 = new ConstructorExamples.Employee("Pradip", "IT");
employee3.Display();

//4. Parameterized constructor with Name + Department + Salary
ConstructorExamples.Employee employee4 = new ConstructorExamples.Employee("Pradip", "IT", 60000);
employee4.Display();

Console.WriteLine("\n=============== Static Method Examples ==================");
int sum = StaticExamples.Add(10, 20);
Console.WriteLine($"Sum: {sum}");

int product = StaticExamples.Multiply(10, 20);
Console.WriteLine($"Product: {product}");

Student student1 = new Student("Pradip");
Student student2 = new Student("Amit");
Student student3 = new Student("Rohit");

student1.Display();
student2.Display();
student3.Display();
Console.WriteLine($"Total Students: {Student.StudentCount}");

CompanyConfiguration.DisplayCompanyInfo();
