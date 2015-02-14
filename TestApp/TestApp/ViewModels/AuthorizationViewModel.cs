using GO8.ServerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Models;
using TestApp.Views;

namespace TestApp.ViewModels
{
    public class AuthorizationViewModel : BaseViewModel
    {
        private readonly AuthorizationPage _page;

        public AuthorizationViewModel(AuthorizationPage page)
        {
            _page = page;
        }

        public string Title
        {
            get
            {
                return SotialNetworkProvider.Instance.GetSotialNetwork().Name;
            }
        }
    }
}
