using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Models
{
    public class Individual
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string PhoneNumber { get; private set; }

        public ContactType ContactFrom { get; set; }

        private Individual(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public Individual(string firstName, string lastName) :
            this(firstName, lastName, string.Empty) { }

        public Individual() :
            this(string.Empty, string.Empty) { }

        public enum ContactType
        {
            Manually,
            PhoneBook,
            SocialNetwork
        }
    }
}
