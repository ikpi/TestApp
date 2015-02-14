using GO8.ServerModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TestApp.Models;
//using TestApp.Models;

namespace TestApp.ViewModels
{
    public class StartViewModel:BaseViewModel
    {
        private StartPage _page;
        private readonly ObservableCollection<ISotialNetwork> _sotialNetworks = new ObservableCollection<ISotialNetwork>()
        {
            new VKStrategy(),
            new TWStrategy(),
            new FBStrategy(),
        };

        public StartViewModel(StartPage page)
        {
            _page = page;
            SotialNetworkClickCommand = new RelayCommand(OnSotialNetworkClickCommand);
        }

        public ObservableCollection<ISotialNetwork> SotialNetworks
        {
            get
            {
                return _sotialNetworks;
            }
        }

        public ICommand SotialNetworkClickCommand { get; set; }

        private void OnSotialNetworkClickCommand(object obj)
        {
            ISotialNetwork selectedSotialNetwork = obj as ISotialNetwork;
            _page.NavigationService.Navigate(new Uri("/Views/AuthorizationPage.xaml", UriKind.Relative));
        }
    }
}
