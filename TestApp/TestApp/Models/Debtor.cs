using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Models
{
    public class Debtor
    {
        private Debtor(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public Debtor(string firstName, string lastName) :
            this(firstName, lastName, string.Empty) { }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string PhoneNumber { get; private set; }
    }
}
