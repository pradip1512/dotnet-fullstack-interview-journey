using Day04_Methods;

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

