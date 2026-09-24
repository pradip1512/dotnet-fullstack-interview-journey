using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_Interfaces
{
    public class UpiPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            // Implementation for UPI payment processing
            Console.WriteLine($"Processing UPI payment of ₹{amount}");
        }
    }
}
