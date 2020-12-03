using System;
using System.Collections.Generic;
using System.Text;

namespace BankOO
{
    public class Transaction
    {
        public decimal Amount { get; }
        public string Text { get; }
        public DateTime Date { get; }

        public Transaction(decimal amount, string text, DateTime date)
        {
            Amount = amount;
            Text = text;
            Date = date;    
        }
    }
}
