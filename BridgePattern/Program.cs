using BridgePattern.Abstraction;
using BridgePattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IShopSupplier supplier = new GardenShop();
            Shop stationaryShop = new Shop(supplier);

            Console.WriteLine("-------> Supplier set to Garden Shop!");

            stationaryShop.Restock(125);
            stationaryShop.Restock(124);
            stationaryShop.Restock(124);

            Console.WriteLine();
            Console.WriteLine("-------> Supplier exchanged to Bakery!");
            stationaryShop.SetSupplier(new Bakery());
            stationaryShop.Restock(328);

            Console.Read();
        }
    }
}
