using BankAccountModular.Models;

namespace BankAccountModular.Services
{
    public class BankService
    {
        public BankAccount CreateAccount(string owner, decimal initialDeposit)
        {
            return new BankAccount(owner, initialDeposit);
        }

        public void Deposit(BankAccount account, decimal amount, string note = "")
        {
            account.AddTransaction(amount, note);
        }

        public void Withdraw(BankAccount account, decimal amount, string note = "")
        {
            if (account.Balance < amount)
                throw new InvalidOperationException("Insufficient funds");

            account.AddTransaction(-amount, note);
        }
    }
}