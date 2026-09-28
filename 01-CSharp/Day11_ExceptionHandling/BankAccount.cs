using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Day11_ExceptionHandling;

public class BankAccount
{
    public int AccountId { get; init; }
    public string AccountHolderName { get; private set; }
    public decimal Balance { get; private set; }

    public bool IsActive { get; private set; }

    public BankAccount(int accountId, string accountHolderName, decimal initialBalance)
    {
        if(accountId <= 0)
        {
            throw new ArgumentException("Account Id must be greater than zero.", nameof(accountId));
        }

        ArgumentNullException.ThrowIfNull(accountHolderName);

        if (string.IsNullOrWhiteSpace(accountHolderName))
        {
            throw new ArgumentException("Account Holder name can not be empty.", nameof(accountHolderName));
        }

        if (initialBalance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialBalance), "Intial Balance cannot be negative.");
        }

        AccountId = accountId;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
        IsActive = true;

    }

    public void Deposit(decimal amount)
    {
        if (!IsActive)
        {
            throw new InvalidOperationException("Can not deposit into the inactive account.");
        }

        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.", nameof(amount));
        }

        Balance += amount;
        Console.WriteLine($"Deposited: ₹{amount}");
    }

    public void Withdraw(decimal amount)
    {
        if(!IsActive)
        {
            throw new InvalidOperationException("Can not withdraw from the inactive account.");
        }

        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than zero.", nameof(amount));
        }

        if (amount > Balance)
        {
            throw new InsufficientBalanceException("Insufficient account balance.");
        }

        Balance -= amount;
        Console.WriteLine($"Withdrew: ₹{amount}");
    }

    public void Deactive()
    {
        IsActive = false;
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Id: {AccountId}");
        Console.WriteLine($"Account Holder Name: {AccountHolderName}");
        Console.WriteLine($"Balance: ₹{Balance}");
        Console.WriteLine($"Is Active: {IsActive}");
    }
}
