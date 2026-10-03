using Day12_Collections;
using Day13_Generics;



Box<int> numberBox = new(100);
Box<string> nameBox = new("Pradip");

numberBox.Display();

Console.WriteLine();

nameBox.Display();

GenericHelper.Display(100);
GenericHelper.Display("Hello");
GenericHelper.Display(5000m);

int result = GenericHelper.GetFirst(10, 20);
Console.WriteLine($"First number: {result}");

GenericRepository<string> names = new();
names.Add("Pradip");
names.Add("Rahul");

foreach (string name in names.GetAll())
{
    Console.WriteLine(name);
}

GenericRepository<Employee> employee = new();
employee.Add(new Employee(1, "Pradip", "IT")); 
employee.Add(new Employee(2, "Rahul", "HR"));   
