using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementation
{
    public interface IShopSupplier
    {
        bool CheckIfAvailable(int productCode);
        ProductInShop DeliverProduct(int productCode);
    }
}
