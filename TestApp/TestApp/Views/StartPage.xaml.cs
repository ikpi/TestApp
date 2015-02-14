using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using TestApp.ViewModels;

namespace TestApp
{
    public partial class StartPage : PhoneApplicationPage
    {
        // Constructor
        public StartPage()
        {
            InitializeComponent();
            Loaded += delegate
            {
                DataContext = new StartViewModel(this);
            };
        }
    }
}