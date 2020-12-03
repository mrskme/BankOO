using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BankOO
{
    public class Statement
    {
        public IEnumerable<Transaction> Transactions { get; }
        public int Year;
        public int Month;

        public Statement(IEnumerable<Transaction> transactions, int year, int month)
        {
            Transactions = transactions;
            Year = year;
            Month = month;
        }
    }
}
