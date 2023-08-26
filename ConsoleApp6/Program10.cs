using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class BankAccount
    {
        public string AccountNumber { get; }
        public decimal Balance { get; protected set; }

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. New balance: {Balance}");
        }
    }
    sealed class SavingsAccount : BankAccount
    {
        private decimal InterestRate { get; }

        public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate)
            : base(accountNumber, initialBalance)
        {
            InterestRate = interestRate;
        }
        public void CalculateInterest()
        {
            decimal interestAmount = Balance * InterestRate;
            Deposit(interestAmount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount("123456", 1000, 0.05m);

            Console.WriteLine($"Account Number: {savingsAccount.AccountNumber}");
            Console.WriteLine($"Initial Balance: {savingsAccount.Balance}");

            savingsAccount.Deposit(500);
            savingsAccount.Withdraw(200);

            savingsAccount.CalculateInterest();
            Console.ReadLine();
        }
    }

}