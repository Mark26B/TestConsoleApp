using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    class BankAccount
    {
        private static int accountNumber = 1000000001;
        public string Number { get; }

        public string Owner { get; }

        public decimal Balance { get; }

        public DateTime Created { get; }

        public string Currency { get; }

        public BankAccount(string owner, decimal balance, string currency)
        {
            this.Number = accountNumber.ToString();
            accountNumber++;
            this.Owner = owner;
            this.Balance = balance;
            this.Currency = currency;
            this.Created = DateTime.Now;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Account number {this.Number} created on {this.Created.ToShortDateString()} belongs to {this.Owner} and has a balance of {this.Balance} {this.Currency}");
        }

        //MakeDeposit();
        //MakeWithdrawal();
        //class Transactions();
    }
}
