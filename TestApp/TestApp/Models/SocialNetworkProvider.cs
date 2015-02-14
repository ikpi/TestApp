using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Models
{
    public class SocialNetworkProvider
    {
        private static SocialNetworkProvider instance;

        private readonly ISocialNetwork _sotialNetwork;

        public static SocialNetworkProvider SetInstance(ISocialNetwork sotialNetwork)
        {
            instance = new SocialNetworkProvider(sotialNetwork);
            return instance;
        }

        public static SocialNetworkProvider Instance
        {
            get
            {
                return instance;
            }
        }
        private SocialNetworkProvider()
        { }

        private SocialNetworkProvider(ISocialNetwork sotialNetwork)
        {
            _sotialNetwork = sotialNetwork;
        }

        public ISocialNetwork GetSotialNetwork()
        {
            return _sotialNetwork;
        }
    }
}
