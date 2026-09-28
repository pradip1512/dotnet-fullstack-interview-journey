using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_ExceptionHandling;

public class OrderService
{
    private bool _isProcessed;

    public void ProcessOrder(int orderId, decimal amount)
    {
        if (orderId <= 0)
        {
            throw new ArgumentException(
                "Order ID must be greater than zero.",
                nameof(orderId));
        }

        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "Order amount must be greater than zero.");
        }

        if (_isProcessed)
        {
            throw new InvalidOperationException(
                "Order has already been processed.");
        }

        Console.WriteLine(
            $"Order {orderId} processed successfully for ₹{amount}.");

        _isProcessed = true;
    }
}