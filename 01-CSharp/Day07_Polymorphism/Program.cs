using Day07_Polymorphism;
using System.Xml;
using static Day07_Polymorphism.Employee;

Employee employee = new Employee();
employee.Work();

Employee developer = new Developer();
developer.Work();

Employee manager = new Manager();
manager.Work();

Console.WriteLine("\n ------- Method Hidding Example ----------");
MethodHidingExample.Employee employee1 = new MethodHidingExample.Developer();
employee1.Work();

MethodHidingExample.Developer developer1 = new MethodHidingExample.Developer();
developer1.Work();

Console.WriteLine("\n--------- Base Method Example ---------");
RuntimePolymorphismBaseExample.Employee employee2 = new RuntimePolymorphismBaseExample.Developer();
employee2.Work();

Console.WriteLine();
RuntimePolymorphismBaseExample.Employee employee3 = new RuntimePolymorphismBaseExample.Manager();
employee3.Work();

Console.WriteLine("\n--------- Compile Time Polymorphism Example ---------");
SalaryCalculator calculator = new SalaryCalculator();

decimal salary1 = calculator.CalculateSalary(50000);
decimal salary2 = calculator.CalculateSalary(50000, 10000);
decimal salary3 = calculator.CalculateSalary(50000, 10000, 5000);

Console.WriteLine("Salary with basic salary: " + salary1);
Console.WriteLine("Salary with basic salary and bonus: " + salary2);
Console.WriteLine("Salary with basic salary, bonus, and allowance: " + salary3);

Console.WriteLine("\n--------- Casting Example ---------");
CastingExample.Developer developer2 = new CastingExample.Developer();
CastingExample.Employee employee4 = developer2; // Upcasting
employee4.Work();

CastingExample.Developer developer3 = (CastingExample.Developer)employee4; // Downcasting
developer3.Work();

//Pattern Matching with 'is' operator
if (employee4 is CastingExample.Developer developer4)
{
    developer4.Work();
}

//Invalid Casting Example
CastingExample.Employee managerEmployee = new CastingExample.Manager();

try
{
    CastingExample.Developer invalidDeveloper = (CastingExample.Developer)managerEmployee; // Invalid downcasting
    invalidDeveloper.Work();
}
catch (InvalidCastException ex)
{
    Console.WriteLine("Invalid casting: " + ex.Message);
}

//as operator

CastingExample.Developer? developer5 = managerEmployee as CastingExample.Developer; // Invalid downcasting using 'as' operator
if (developer5 != null)
{
    developer5.Work();
}
else
{
    Console.WriteLine("Invalid casting using 'as' operator.");
}

Console.WriteLine("\n------------ WorkSphere Example -----------");
WorkSpherePolymorphismChallenge.Developer developer6 = new WorkSpherePolymorphismChallenge.Developer();
developer6.Name = "Pradip";
developer6.EmployeeId = 101;
developer6.Department = "IT";
developer6.ProgrammingLanguage = "C#";

WorkSpherePolymorphismChallenge.Manager manager1 = new WorkSpherePolymorphismChallenge.Manager();
manager1.TeamSize = 10;

WorkSpherePolymorphismChallenge.Employee employee5 = developer6;
WorkSpherePolymorphismChallenge.Employee employee6 = manager1;

employee5.Work();
employee6.Work();

//Downcasting
WorkSpherePolymorphismChallenge.Developer developer7 = (WorkSpherePolymorphismChallenge.Developer) employee5;
developer7.Work();

//WorkSpherePolymorphismChallenge.Developer developer8 = (WorkSpherePolymorphismChallenge.Developer)employee6;
//developer8.Work();

//safe casting (pattern matching)
if (employee5 is WorkSpherePolymorphismChallenge.Developer developer9)
{
    developer9.Work();
}
else
{
    Console.WriteLine("Employee5 is not a developer");
}

//as operator
WorkSpherePolymorphismChallenge.Developer? developer10 = employee6 as WorkSpherePolymorphismChallenge.Developer;

if (developer10 != null)
{
    developer10.Work();
}
else
{
    Console.WriteLine("Conversion Failed.");
}