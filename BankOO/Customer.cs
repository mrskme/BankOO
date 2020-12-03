using System;
using System.Collections.Generic;
using System.Text;

namespace BankOO
{
    public class Customer
    {
        public string _name;

        public Customer(string name)
        {
            _name = name;   
        }
        public Statement GetLatestStatements()
        {
            var dateTime = DateTime.Now;
            return GetStatements(dateTime.Year, dateTime.Month - 1);
        }

        public Statement GetStatements(int year, int month)
        {
            return null;
        }
    }
}
