using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.PaymentExternalSystems
{
    public class EKardSystem
    {
        public bool CardPayment(decimal amount)
        {
            //Some operations.
            return true;
        }

        public bool PayInPolishBank(decimal amount)
        {
            //Some operations.
            return true;
        }

        public bool PayInZantanderBank(decimal amount)
        {
            //Some operations.
            return true;
        }

        public bool PayInWesternUnion(decimal amount)
        {
            //Some operations.
            return true;
        }

    }
}
