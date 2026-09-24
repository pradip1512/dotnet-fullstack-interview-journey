
using Day09_Encapsulation;

Console.OutputEncoding = System.Text.Encoding.UTF8;
EncapsulationExamples.Employee employee = new EncapsulationExamples.Employee(1, "Pradip", 50000m, "IT");
Console.WriteLine("Display initial information:");
employee.DisplayInfo();

Console.WriteLine("\nGiving a valid raise of 5000...");
employee.GiveRaise(5000m);

Console.WriteLine("Display information again:");
employee.DisplayInfo();

Console.WriteLine("\nChanging department to 'Finance'...");
employee.ChangeDepartment("Finance");

Console.WriteLine("Display information after department change:");
employee.DisplayInfo();

Console.WriteLine("\nAttempting to give an invalid raise of -5000...");
try
{
    employee.GiveRaise(-5000m);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
