using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_Interfaces
{
    public interface IPayment
    {
        void ProcessPayment(decimal amount);
    }
}
