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
        private readonly ObservableCollection<ISocialNetwork> _socialNetworks = new ObservableCollection<ISocialNetwork>()
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

        public ObservableCollection<ISocialNetwork> SocialNetworks
        {
            get
            {
                return _socialNetworks;
            }
        }

        public ICommand SotialNetworkClickCommand { get; set; }

        private void OnSotialNetworkClickCommand(object obj)
        {
            ISocialNetwork selectedSotialNetwork = obj as ISocialNetwork;
            SocialNetworkProvider.SetInstance(selectedSotialNetwork);
            _page.NavigationService.Navigate(new Uri("/Views/AuthorizationPage.xaml", UriKind.Relative));
        }
    }
}
