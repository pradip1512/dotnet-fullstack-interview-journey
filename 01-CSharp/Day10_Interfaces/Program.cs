using Day10_Interfaces;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("====== Interface Payment Example ======");

IPayment cardPayment = new CardPayment();
cardPayment.ProcessPayment(1000.00m);

IPayment upiPayment = new UpiPayment();
upiPayment.ProcessPayment(500.00m);

IPayment cashPayment = new CashPayment();
cashPayment.ProcessPayment(200.00m);
