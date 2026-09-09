using Day08_Abstraction;

Console.WriteLine("====== WorkSphere Abstraction Example ======");

// Upcasting + Runtime Polymorphism
AbstractionExamples.Employee employee1 =
    new AbstractionExamples.Developer(
        101,
        "Pradip",
        "IT",
        "C#");

AbstractionExamples.Employee employee2 =
    new AbstractionExamples.Manager(
        102,
        "Rahul",
        "IT",
        10);

AbstractionExamples.Employee employee3 =
    new AbstractionExamples.Tester(
        103,
        "Amit",
        "QA",
        "Selenium");

Console.WriteLine("\n====== Developer ======");
employee1.DisplayBasicInfo();
employee1.Work();

Console.WriteLine("\n====== Manager ======");
employee2.DisplayBasicInfo();
employee2.Work();

Console.WriteLine("\n====== Tester ======");
employee3.DisplayBasicInfo();
employee3.Work();