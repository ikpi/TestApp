using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Models
{
    public class Debt
    {
        public Individual Individual { get; private set; }

        /// <summary>
        /// Return true if this is debit, false - credit
        /// </summary>
        public bool IsDebit { get; private set; }

        public int Amount { get; private set; }

        public string Comment { get; private set; }

        public DateTime DateOfCreation { get; private set; }

        /// <summary>
        /// Перид долга
        /// </summary>
        public int DaysPeriod { get; private set; }

        /// <summary>
        /// Осталось дней
        /// </summary>
        public int RemainingDays 
        {
            get
            {
                return DaysPeriod - (DateTime.Now - DateOfCreation).Days;
            }
        }

        /// <summary>
        /// Признак просрочки долга
        /// </summary>
        public bool isOverdue
        {
            get
            {
                return RemainingDays < 0;
            }
        }        

        private Debt(Individual individual, int amount, DateTime dateOfCreation,bool isDebit, string comment)
        {
            Individual = individual;
            Amount = amount;
            DateOfCreation = dateOfCreation;
            IsDebit = isDebit;
            Comment = comment;
        }

        public Debt(Individual individual, int debt, bool isDebit, DateTime dateOfCreation) :
            this(individual, debt, dateOfCreation, isDebit, string.Empty) { }

        public Debt() :
            this(new Individual(), 0, true, DateTime.Now) { }
    }
}
