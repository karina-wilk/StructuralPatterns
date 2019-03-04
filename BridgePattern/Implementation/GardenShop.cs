using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementation
{
    public class GardenShop : IShopSupplier
    {
        private Dictionary<int, ProductInStock> stock = new Dictionary<int, ProductInStock>
        {
            { 123, new ProductInStock("Grabie", 24, 10) },
            { 124, new ProductInStock("Łopata", 54, 1) },
            { 125, new ProductInStock("Taczka", 98, 5) },
            { 126, new ProductInStock("Szpadel", 56, 32) },
            { 127, new ProductInStock("Donica duża", 74, 4) },
            { 128, new ProductInStock("Donica mała", 4, 100) }
        };

        public bool CheckIfAvailable(int productCode)
            =>  stock.ContainsKey(productCode) && stock[productCode].QuantityInStock > 0;

        public ProductInShop DeliverProduct(int productCode)
        {
            if(CheckIfAvailable(productCode))
            {
                var product = stock[productCode];
                product.QuantityInStock -= 1;

                return new ProductInShop(product.Name, product.Price);
            }
            return null;
        }
    }
}
