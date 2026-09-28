using Day11_ExceptionHandling;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("============ Employee Validation ============");

var employeeService = new EmployeeService();

try
{
    employeeService.ValidateEmployeeName("Pradip");
    employeeService.ValidateAge(27);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Validation Error: {ex.Message}");
}

Console.WriteLine("\n============ Bank Account ============");

var account = new BankAccount(101, "Pradip", 50000m);

account.DisplayAccountInfo();

Console.WriteLine("\n========= Valid Deposit ==========");

try
{
    account.Deposit(10000m);
}
catch( ArgumentException ex)
{
    Console.WriteLine($"Deposit Error: {ex.Message}");
}

account.DisplayAccountInfo();

Console.WriteLine("\n=========== Valid Withdrawal ===========");

try
{
    account.Withdraw(15000m);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Withdrawal Error: {ex.Message}");
}
catch (InsufficientBalanceException ex)
{
    Console.WriteLine($"Balance Error: {ex.Message}");
}

account.DisplayAccountInfo();

Console.WriteLine("\n=========== Invalid Withdrawal ===========");

try
{
    account.Withdraw(100000m);

}
catch (InsufficientBalanceException ex)
{
    Console.WriteLine($"Balance Error: {ex.Message}");

}

Console.WriteLine("\n=========== Invalid Deposit ===========");
try
{
    account.Deposit(-5000m);

}
catch (ArgumentException ex)
{
    Console.WriteLine($"Deposit Error: {ex.Message}");
}

Console.WriteLine("\n=========== Invalid Age ===========");
try
{
    employeeService.ValidateAge(17);

}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Age Validation Error: {ex.Message}");
}
Console.WriteLine("\nProgram completed.");


var orderService = new OrderService();

try
{
    Console.WriteLine("\n====== Order Processing ======");

    orderService.ProcessOrder(101, 5000m);

    Console.WriteLine("\n====== Duplicate Order ======");

    orderService.ProcessOrder(101, 5000m);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Argument Error: {ex.Message}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Operation Error: {ex.Message}");
}
finally
{
    Console.WriteLine("\nOrder processing attempt completed.");
}