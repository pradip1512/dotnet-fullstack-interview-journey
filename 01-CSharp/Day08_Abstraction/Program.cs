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

Console.WriteLine("\n====== Notification Example ======");

Notification notification1 = new EmailNotification(1, "user@example.com", "Hello, User!", "Important Update");

Notification notification2 = new SmsNotification(2, "+1234567890", "Your OTP is 123456", "+1234567890");
Notification notification3 = new TeamNotification(3, "IT Team", "Meeting scheduled for tomorrow.", "IT");

notification1.DisplayNotificationInfo();
notification1.Send();

notification2.DisplayNotificationInfo();
notification2.Send();

notification3.DisplayNotificationInfo();
notification3.Send();
