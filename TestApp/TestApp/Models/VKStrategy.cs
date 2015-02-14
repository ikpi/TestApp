using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Models
{
    internal class VKStrategy : ISotialNetwork
    {
        public string Name
        {
            get
            {
                return "Vkontakte";
            }
        }

        public string ImageSource
        {
            get
            {
                return "/Images/vk_logo.png";
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
