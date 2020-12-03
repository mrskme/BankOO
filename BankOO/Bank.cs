using System;
using System.Collections.Generic;
using System.Text;

namespace BankOO
{
    public class Bank
    {
        public Customer CreateCustomer(string terje)
        {
            return new Customer(terje);
        }

        public Account CreateAccount(Customer customer, string accountName)
        {
            return new Account(customer, accountName);
        }

        public void Transfer(Customer customer, Account account1, Account account2, decimal amount)
        {
            if (account1._customer == customer)
            {
                if (account1.Balance >= amount)
                {
                    account1.Balance -= amount;
                    account1.AddTransaction(amount);
                    account2.Balance += amount;
                    account2.AddTransaction(amount);
                }
            }
        }
    }
}
