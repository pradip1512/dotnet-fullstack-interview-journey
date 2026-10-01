using Day12_Collections;
using Day12_Collections._02_Challenge;

// ===================================================
// PART 1: ORIGINAL DAY 12 EXERCISES
// ===================================================
Console.WriteLine("====== PART 1: Basic Collections & Repository ======");

EmployeeRepository repository = new();
repository.AddEmployee(new Employee(1, "Pradip", "IT"));
repository.AddEmployee(new Employee(2, "Rahul", "HR"));
repository.AddEmployee(new Employee(3, "Amit", "Finance"));

Console.WriteLine("\n--- All Employees (List) ---");
foreach (Employee employee in repository.GetAllEmployees())
{
    employee.Display();
}

Console.WriteLine("\n--- Dictionary Lookup ---");
Dictionary<int, Employee> employeeDictionary = new();
foreach (Employee employee in repository.GetAllEmployees())
{
    employeeDictionary.Add(employee.EmployeeId, employee);
}

if (employeeDictionary.TryGetValue(3, out Employee? employeeFromDict))
{
    employeeFromDict.Display();
}

Console.WriteLine("\n--- Unique Departments (HashSet) ---");
HashSet<string> departments = new();
foreach (Employee employee in repository.GetAllEmployees())
{
    departments.Add(employee.Department);
}
foreach (string dept in departments)
{
    Console.WriteLine(dept);
}

Console.WriteLine("\n--- Task Processing (Queue) ---");
Queue<string> taskQueue = new();
taskQueue.Enqueue("Generate Employee Report");
taskQueue.Enqueue("Send Email");
taskQueue.Enqueue("Process Payroll");

while (taskQueue.Count > 0)
{
    Console.WriteLine($"Processing: {taskQueue.Dequeue()}");
}

Console.WriteLine("\n--- Navigation (Stack) ---");
Stack<string> pageHistory = new();
pageHistory.Push("Dashboard");
pageHistory.Push("Employees");
pageHistory.Push("Employee Details");

Console.WriteLine($"Back from: {pageHistory.Pop()}");
Console.WriteLine($"Back from: {pageHistory.Pop()}");


// ===================================================
// PART 2: FINAL DAY 12 CHALLENGE
// ===================================================
Console.WriteLine("\n===================================================");
Console.WriteLine("====== PART 2: WorkSphere Employee Manager ======");
Console.WriteLine("===================================================");

WorkSphereEmployeeManager manager = new();

// 1. Add Employees
manager.AddEmployee(new Employee(1, "Pradip", "IT"));
manager.AddEmployee(new Employee(2, "Rahul", "HR"));
manager.AddEmployee(new Employee(3, "Amit", "Finance"));
manager.AddEmployee(new Employee(4, "Sneha", "IT"));

        // 2. Display All & Unique Departments
manager.DisplayAllEmployees();
manager.DisplayDepartments();

// 3. Find Employee
Console.WriteLine("\n====== Find Employee ======");
Employee? challengeEmp = manager.GetEmployeeById(2);
if (challengeEmp != null)
{
    challengeEmp.Display();
}

// 4. Processing Queue (FIFO)
Console.WriteLine("\n====== Processing Queue ======");
manager.AddEmployeeToProcessingQueue(1);
manager.AddEmployeeToProcessingQueue(3);
manager.ProcessNextEmployee();
manager.ProcessNextEmployee();
manager.ProcessNextEmployee();

// 5. Recently Viewed Stack (LIFO)
Console.WriteLine("\n====== Recently Viewed ======");
manager.ViewEmployee(1);
manager.ViewEmployee(3);
manager.ViewEmployee(2);
manager.GoBack();
manager.GoBack();