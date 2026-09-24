using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_Interfaces
{
    public class CardPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            // Implementation for card payment processing
            Console.WriteLine($"Processing card payment of ₹{amount}");
        }
    }
}
