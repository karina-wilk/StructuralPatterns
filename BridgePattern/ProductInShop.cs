using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class ProductInShop
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ProductInShop(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
