using GO8.ServerModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TestApp.Models;
using TestApp.Views;

namespace TestApp.ViewModels
{
    public class AllDebtsViewModel : BaseViewModel
    {
        AllDebtsPivotPage _page;

        private ObservableCollection<Debt> _debts;

        public AllDebtsViewModel(AllDebtsPivotPage page)
        {
            _page = page;
            // Test data. Remove when release.
            _debts = new ObservableCollection<Debt>()
            {
                new Debt(new Individual("Lol1","Lolenko1"),100,true, DateTime.Now),
                new Debt(new Individual("Lol2","Lolenko2"),100,true, DateTime.Now),
                new Debt(new Individual("Lol3","Lolenko3"),100,false, DateTime.Now),
                new Debt(new Individual("Lol4","Lolenko4"),100,false, DateTime.Now),
                new Debt(new Individual("Lol5","Lolenko5"),100,false, DateTime.Now),
            };
        }

        public ObservableCollection<Debt> Debits
        {
            get
            {
                return new ObservableCollection<Debt>(_debts.Where(w => w.IsDebit));
            }
        }
        public ObservableCollection<Debt> Credits
        {
            get
            {
                return new ObservableCollection<Debt>(_debts.Where(w =>!w.IsDebit));
            }
        }
    }
}
