using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Models;
using TestApp.Views;

namespace TestApp.ViewModels
{
    public class AddNewDebtViewModel
    {
        private readonly AddNewDebtPage _page;

        private Debt _debt;

        public AddNewDebtViewModel(AddNewDebtPage page)
        {
            _page = page;
            _debt = new Debt();
        }

        public Individual.ContactType IndividualContactType
        {
            get { return _debt.Individual.ContactFrom; }
            set { _debt.Individual.ContactFrom = value; }
        } 
    }
}
