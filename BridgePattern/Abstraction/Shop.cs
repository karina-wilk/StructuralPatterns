using BridgePattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstraction
{
    public class Shop
    {
        protected IShopSupplier supplier;

        List<ProductInShop> stock = new List<ProductInShop>();

        public Shop(IShopSupplier supplier)
        {
            this.supplier = supplier;
            stock = new List<ProductInShop>();
        }

        public void SetSupplier(IShopSupplier supplier)
        {
            this.supplier = supplier;
        }

        public void Restock(int productCode)
        {
            var product = supplier.DeliverProduct(productCode);
            if (product != null)
            {
                Console.WriteLine($"Product {product.Name} arrived to stock!");
                stock.Add(product);
            }
            else
            {
                Console.WriteLine("Product was unavailable! Better look for another supplier!");
            }
        }
    }
}
