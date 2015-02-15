using GO8.ServerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Views;

namespace TestApp.ViewModels
{
    public class AllDebtsViewModel : BaseViewModel
    {
        AllDebtsPivotPage _page;

        public AllDebtsViewModel(AllDebtsPivotPage page)
        {
            _page = page;
        }
    }
}
