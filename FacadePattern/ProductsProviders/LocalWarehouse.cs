using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.ProductsProviders
{
    public class LocalWarehouse
    {
        public bool IsProductAvailable(int productCode)
        {
            //Some operations.
            return true;
        }

        public int GetPrice(int productCode)
        {
            //Some operations.

            var r = new Random();
            return r.Next(1, 2000);
        }

        public bool Reserve(int productCode)
        {
            //Some operations.
            return true;
        }

    }
}
