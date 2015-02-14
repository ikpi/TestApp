using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TestApp.ViewModels;

namespace TestApp.Views
{
    public partial class AuthorizationPage : PhoneApplicationPage
    {
        public AuthorizationPage()
        {
            InitializeComponent();
            Loaded += delegate
            {
                DataContext = new AuthorizationViewModel(this);
            };
        }
    }
}