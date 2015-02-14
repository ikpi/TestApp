using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Models
{
    public class TWStrategy : ISocialNetwork
    {
        public string Name
        {
            get
            {
                return "Twitter";
            }
        }

        public string ImageSource
        {
            get
            {
                return "/Images/tw_logo.png";
            }
        }

        public void LogIn()
        {
            throw new NotImplementedException();
        }
        public void LogOut()
        {
            throw new NotImplementedException();
        }
    }
}
