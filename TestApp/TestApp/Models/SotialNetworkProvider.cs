using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Models
{
    public class SotialNetworkProvider
    {
        private static SotialNetworkProvider instance;

        private readonly ISotialNetwork _sotialNetwork;

        public static SotialNetworkProvider SetInstance(ISotialNetwork sotialNetwork)
        {
            if (instance != null)
            {
                instance = new SotialNetworkProvider(sotialNetwork);
            }
            return instance;
        }

        public static SotialNetworkProvider Instance
        {
            get
            {
                if (instance != null)
                {
                    instance = new SotialNetworkProvider();
                }
                return instance;
            }
        }
        private SotialNetworkProvider()
        { }

        private SotialNetworkProvider(ISotialNetwork sotialNetwork)
        {
            _sotialNetwork = sotialNetwork;
        }

        public ISotialNetwork GetSotialNetwork()
        {
            return _sotialNetwork;
        }
    }
}
