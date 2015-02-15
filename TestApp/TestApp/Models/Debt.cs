using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Models
{
    public class Debt
    {
        private Debt(Debtor debtor, int amount, DateTime dateOfCreation, string comment)
        {
            Debtor = debtor;
            Amount = amount;
            DateOfCreation = dateOfCreation;
            Comment = comment;
        }

        public Debt(Debtor debtor, int debt, DateTime dateOfCreation) :
            this(debtor, debt, dateOfCreation, string.Empty) { }

        public Debtor Debtor { get; private set; }

        public int Amount  { get;private set; }

        public string Comment { get;private set; }

        public DateTime DateOfCreation { get; private set; }
    }
}
