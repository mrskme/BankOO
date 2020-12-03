using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BankOO
{
    public class Account
    {
        public decimal Balance { get; set; }
        public Customer _customer;
        private string AccountName;
        private List<Transaction> Transactions = new List<Transaction>();
        private List<Statement> Statements = new List<Statement>();

        public Account(Customer customer, string accountName)
        {
            _customer = customer;
            AccountName = accountName;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void AddTransaction(decimal amount)
        {
            Transactions.Add(new Transaction(amount, $"{_customer._name} recieved {amount} money on {AccountName}", DateTime.Now));
        }

        public void AddStatement()
        {
            Statements.Add(new Statement(Transactions, DateTime.Now.Year, DateTime.Now.Month));
            //Transactions.Clear();
        }
        public Statement GetLatestStatement()
        {
            var dateTime = DateTime.Now;
            return GetStatement(dateTime.Year, dateTime.Month/* - 1*/);
        }

        public Statement GetStatement(int year, int month)
        {
            foreach (Statement statement in Statements)
            {
                if (statement.Year == year && statement.Month == month) return statement;
            }
            return null;
        }
    }
}
