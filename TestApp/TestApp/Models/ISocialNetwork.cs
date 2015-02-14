using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Models
{
    public interface ISocialNetwork
    {
        string Name{get;}
        string ImageSource { get; }
        void LogIn();
        void LogOut();
    }
}
