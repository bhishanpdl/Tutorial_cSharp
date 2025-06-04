using System;
using BankAccountModular.Models;
using BankAccountModular.Services;

class Program
{
    static void Main()
    {
        var bankService = new BankService();

        Console.WriteLine("Creating new account...");
        var account = bankService.CreateAccount("John Doe", 1000);

        Console.WriteLine($"Account created for {account.Owner}");
        Console.WriteLine($"Account #: {account.AccountNumber}");
        Console.WriteLine($"Balance: ${account.Balance}");

        Console.WriteLine("\nMaking deposit of $500...");
        bankService.Deposit(account, 500, "First deposit");
        Console.WriteLine($"New balance: ${account.Balance}");

        Console.WriteLine("\nMaking withdrawal of $200...");
        bankService.Withdraw(account, 200, "ATM withdrawal");
        Console.WriteLine($"New balance: ${account.Balance}");

        Console.WriteLine("\nTransaction History:");
        Console.WriteLine(account.GetTransactionHistory());
    }
}