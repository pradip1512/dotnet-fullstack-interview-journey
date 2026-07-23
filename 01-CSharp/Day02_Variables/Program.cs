using Day02_Variables;
using System.Runtime.CompilerServices;

string name = "Pradip";
int age = 27;
decimal salary =782621.00m;
bool isEmployed = true;
char grade = 'C';
double heightInFeet = 5.10;
const string companyName = "TCS";

Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Salary: {salary}");
Console.WriteLine($"IsEmployed: {isEmployed}");
Console.WriteLine($"Grade: {grade}");
Console.WriteLine($"Height In Feet: {heightInFeet}");
Console.WriteLine($"CompanyName: {companyName}");

Console.WriteLine("-------------------------Value Type copy-------------------------");

var example = new Day02_Variables.MemoryExamples();
example.RunExample();

Console.WriteLine("-------------------------Refrence type copy-------------------------");
var example2 = new Day02_Variables.Employee();
example2.EmployeeExample();

Console.WriteLine("------------------------- Conversion-------------------------");
var example3 = new Day02_Variables.TypeCastingExamples();
example3.RunImplicitAndExplicitExamples();
example3.RunParsingExamples();
example3.RunEmployeeInputExample();