using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Models
{
    public class Debt
    {
        public Debt(Individual individual, int amount, bool isDebit, DateTime dateOfCreation, string comment)
        {
            Individual = individual;
            Amount = amount;
            DateOfCreation = dateOfCreation;
            IsDebit = isDebit;
            Comment = comment;
        }

        public Debt(Individual individual, int debt, bool isDebit, DateTime dateOfCreation) :
            this(individual, debt, isDebit, dateOfCreation, string.Empty) { }

        public Individual Individual { get; private set; }

        public int Amount  { get;private set; }

        public string Comment { get;private set; }

        public DateTime DateOfCreation { get; private set; }

        /// <summary>
        /// Return true if this is debit, false - credit
        /// </summary>
        public bool IsDebit { get; private set; }
    }
}
