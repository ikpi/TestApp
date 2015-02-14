using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Models
{
    internal class SotialNetworkProvider
    {
        private readonly ISotialNetwork _sotialNetwork;
        internal SotialNetworkProvider(ISotialNetwork sotialNetwork)
        {
            _sotialNetwork = sotialNetwork;
        }

        public ISotialNetwork GetSotialNetwork()
        {
            return _sotialNetwork;
        }
    }
}
