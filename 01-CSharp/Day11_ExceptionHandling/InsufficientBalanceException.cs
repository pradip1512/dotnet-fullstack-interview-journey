using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_ExceptionHandling;

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}
