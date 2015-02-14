﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Models
{
    internal class FBStrategy : ISotialNetwork
    {
        public string Name
        {
            get
            {
                return "Facebook";
            }
        }

        public string ImageSource
        {
            get
            {
                return "/Images/fb_logo.png";
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
