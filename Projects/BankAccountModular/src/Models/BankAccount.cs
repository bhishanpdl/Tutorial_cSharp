using System;
using System.Collections.Generic;

namespace BankAccountModular.Models
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public string Owner { get; set; }
        public decimal Balance { get; private set; }

        private static int accountNumberSeed = 1000000000;
        private List<Transaction> transactions = new List<Transaction>();

        public BankAccount(string owner, decimal initialBalance)
        {
            Owner = owner;
            Balance = initialBalance;
            AccountNumber = accountNumberSeed.ToString();
            accountNumberSeed++;

            AddTransaction(initialBalance, "Initial balance");
        }

        public void AddTransaction(decimal amount, string note)
        {
            if (amount == 0)
                throw new ArgumentException("Amount cannot be zero");

            Balance += amount;
            transactions.Add(new Transaction(amount, DateTime.Now, note));
        }

        public string GetTransactionHistory()
        {
            var report = new System.Text.StringBuilder();
            report.AppendLine("Date\t\tAmount\tBalance\tNote");

            decimal runningBalance = 0;
            foreach (var item in transactions)
            {
                runningBalance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{runningBalance}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}