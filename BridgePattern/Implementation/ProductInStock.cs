using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementation
{
    public class ProductInStock : ProductInShop
    {
        public int QuantityInStock { get; set; }

        public ProductInStock(string name, decimal price, int quantity): base(name, price)
            => QuantityInStock = quantity;
    }
}
