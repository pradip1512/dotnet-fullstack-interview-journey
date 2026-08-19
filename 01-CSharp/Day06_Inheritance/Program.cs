using Day06_Inheritance;


Console.WriteLine("------Inheritance Examples------");

InheritanceExamples.SeniorDeveloper seniorDeveloper = new InheritanceExamples.SeniorDeveloper(5, "C#", 101, "Pradip", "IT");
seniorDeveloper.DisplaySeniorDeveloper();

InheritanceExamples.Manager manager = new InheritanceExamples.Manager(10, 102, "Rahul", "IT");
manager.DisplayManagerInfo();

Console.WriteLine("\n------Access Modifier Inheritance Examples------");
//AccessModifierInheritanceExample.Employee employee = new AccessModifierInheritanceExample.Employee("Rahul", "IT", 60000); employee.DisplayEmployee();
AccessModifierInheritanceExample.Developer developer = new AccessModifierInheritanceExample.Developer("Pradip", "IT", 70000, "C#"); developer.DisplayDeveloper();

Console.WriteLine("\n------WorkSphere Examples------");
Console.WriteLine("\n====== Senior Developer ======");
WorkSphereEmployeeHierarchy.SeniorDeveloper seniorDeveloperWorkSphere = new WorkSphereEmployeeHierarchy.SeniorDeveloper(1, "Pradip", "IT", 80000, "C#", 5);
seniorDeveloperWorkSphere.DisplaySeniorDeveloper();

Console.WriteLine("\n====== Manager ======");
WorkSphereEmployeeHierarchy.Manager managerWorkSphere = new WorkSphereEmployeeHierarchy.Manager(2, "Rahul", "IT", 90000, 10);
managerWorkSphere.DisplayManagerInfo();