using GO8.ServerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace TestApp.ViewModels
{
    public class StartViewModel:BaseViewModel
    {
        private StartPage _page;
        public StartViewModel(StartPage page)
        {
            _page = page;
            VKClickCommand = new RelayCommand(OnVKClickCommand);
        }

        private void OnVKClickCommand(object obj)
        {
            _page.NavigationService.Navigate(new Uri("/Views/AuthorizationPage.xaml", UriKind.Relative));
        }

        public ICommand VKClickCommand { get; set; }
    }
}
