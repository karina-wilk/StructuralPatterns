using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.DeliveryExternalSystems
{
    public class PHLDelivery
    {
        public Guid OrderExpressPackage(string address)
        {
            //Some operations.
            return new Guid();
        }
        public Guid OrderBigPackage(string address, int weight)
        {
            //Some operations.
            return new Guid();
        }
    }
}
