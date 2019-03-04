using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.DeliveryExternalSystems
{
    public class EnveloDelivery
    {
        public string SendCheapMail(string address)
        {
            //Some operations.
            var random = new Random(2);
            return random.Next(1000, 1000000).ToString();
        }
        public Guid OrderBigPackage(string address, int weight)
        {
            //Some operations.
            return new Guid();
        }
    }
}
