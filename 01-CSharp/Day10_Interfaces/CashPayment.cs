using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_Interfaces
{
    public class CashPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            // Implementation for cash payment processing
            Console.WriteLine($"Processing cash payment of ₹{amount}");
        }
    }
}
