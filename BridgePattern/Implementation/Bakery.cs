using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BridgePattern.Implementation
{
    public class Bakery : IShopSupplier
    {
        private Dictionary<int, ProductInStock> stock = new Dictionary<int, ProductInStock>
        {
            { 323, new ProductInStock("Chleb pszenny", 4, 100) },
            { 324, new ProductInStock("Chleb mieszany", 54, 1) },
            { 325, new ProductInStock("Bułka pszenna", 0.6m, 200) },
            { 326, new ProductInStock("Bułka razowa", 0.45m, 132) },
            { 327, new ProductInStock("Rogal", 0.74m, 4) },
            { 328, new ProductInStock("Drożdżówka", 1.8m, 0) }
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
            else
            {
                var bakedProduct = BakeProduct(productCode);

                bakedProduct.QuantityInStock -= 1;
                return new ProductInShop(bakedProduct.Name, bakedProduct.Price);
            }
        }

        private ProductInStock BakeProduct(int productCode)
        {
            Console.WriteLine("Baking in progress.... :)");
            Thread.Sleep(2_000);
            if (!stock.ContainsKey(productCode))
            {
                throw new ArgumentException("There is no product with given code!");
            }
            else
            {
                Console.WriteLine("Baked!");

                var product = stock[productCode];
                product.QuantityInStock += 10; // baking 10 products at the same time.
                return product;
            }
        }
    }
}
