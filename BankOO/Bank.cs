using System;
using System.Collections.Generic;
using System.Text;

namespace BankOO
{
    public class Bank
    {
        public Customer CreateCustomer(string terje)
        {
            throw new NotImplementedException();
        }

        public Account CreateAccount(Customer customer, string brukskonto)
        {
            throw new NotImplementedException();
        }

        public void Transfer(Customer customer, Account account1, Account account2, decimal @decimal)
        {
            // vi sender med kunde. Hvis kunden ikke eier fra-konto => feil

            throw new NotImplementedException();
        }
    }
}
